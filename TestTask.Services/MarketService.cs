using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data;
using TestTask.Data;
using TestTask.Data.Entities;

namespace TestTask.Services;

public class MarketService(TestDbContext testDbContext) : IMarketService
{
    private readonly TestDbContext _testDbContext = testDbContext;

    public async Task<PurchaseResult> BuyAsync(int userId, int itemId, CancellationToken ct = default)
    {
        using var transaction = await _testDbContext.Database.BeginTransactionAsync(IsolationLevel.RepeatableRead, ct);

        var user = await _testDbContext.Users.FirstOrDefaultAsync(n => n.Id == userId, ct);
        if (user == null)
            throw new Exception("User not found");
        var item = await _testDbContext.Items.FirstOrDefaultAsync(n => n.Id == itemId, ct);
        if (item == null)
            throw new Exception("Item not found");

        if (user.Balance < item.Cost)
        {
            return PurchaseResult.NotEnoughtBalance;
        }

        try
        {
            user.Balance -= item.Cost;
            await _testDbContext.SaveChangesAsync(ct);

            await _testDbContext.UserItems.AddAsync(new UserItem
            {
                UserId = userId,
                ItemId = itemId,
                PurchaseDate = DateTime.UtcNow
            }, ct);
            await _testDbContext.SaveChangesAsync(ct);

            await transaction.CommitAsync(ct);
            return PurchaseResult.Success;
        }
        catch (Exception ex) when (ex.InnerException is DbUpdateException dbEx && dbEx.InnerException is NpgsqlException npgEx)
        {
            await transaction.RollbackAsync(ct);

            const string ConcurrentSqlError = "40001";
            if (npgEx.SqlState == ConcurrentSqlError)
            {
                return PurchaseResult.ConcurrentPurchase;
            }
            else
            {
                throw;
            }
        }
    }

    public async Task<IEnumerable<MostPopularItemRecord>> GetMostPopularItemsAsync(CancellationToken ct = default)
    {
        const int TAKEN_ITEMS_PER_YEAR = 3;

        var groups = _testDbContext.UserItems
            .AsNoTracking()
            .Include(x => x.Item)
            .GroupBy(x => new
            {
                x.PurchaseDate.Date,
                x.UserId,
                ItemName = x.Item!.Name
            })
            .Select(g => new
            {
                g.Key.Date.Year,
                g.Key.ItemName,
                BoughtNumber = g.Count()
            });

        var items = await groups
            .GroupBy(x => x.Year)
            .OrderByDescending(x => x.Key)
            .Select(g => g.OrderByDescending(x => x.BoughtNumber).Take(TAKEN_ITEMS_PER_YEAR))
            .ToArrayAsync(ct);

        return items
            .SelectMany(x => x)
            .Select(x => new MostPopularItemRecord(x.Year, x.ItemName, x.BoughtNumber));
    }
}