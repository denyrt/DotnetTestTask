using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Data.Entities;

namespace TestTask.Services;

public class MarketService
{
    private readonly TestDbContext _testDbContext;

    public MarketService(TestDbContext testDbContext)
    {
        _testDbContext = testDbContext;
    }

    public async Task BuyAsync(int userId, int itemId)
    {
        var user = await _testDbContext.Users.FirstOrDefaultAsync(n => n.Id == userId);
        if (user == null)
            throw new Exception("User not found");
        var item = await _testDbContext.Items.FirstOrDefaultAsync(n => n.Id == itemId);
        if (item == null)
            throw new Exception("Item not found");

        if (user.Balance < item.Cost)
        {
            if (item == null)
                throw new Exception("Not enough balance");
        }

        user.Balance -= item.Cost;
        await _testDbContext.UserItems.AddAsync(new UserItem
        {
            UserId = userId,
            ItemId = itemId,
            PurchaseDate = DateTime.UtcNow
        });

        await _testDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<MostPopularItemRecord>> MostPopularItemsAsync()
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
            .ToArrayAsync();

        return items
            .SelectMany(x => x)
            .Select(x => new MostPopularItemRecord(x.Year, x.ItemName, x.BoughtNumber));
    }
}