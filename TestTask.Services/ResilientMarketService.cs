using TestTask.Data;

namespace TestTask.Services;

public class ResilientMarketService(TestDbContext testDbContext) : MarketService(testDbContext), IMarketService
{
    public new async Task<PurchaseResult> BuyAsync(int userId, int itemId, CancellationToken ct = default)
    {
        int currentRetry = 0;
        const int maxRetry = 3;

        while (currentRetry < maxRetry) 
        {
            PurchaseResult purchase = await base.BuyAsync(userId, itemId, ct);
            
            if (purchase == PurchaseResult.ConcurrentPurchase)
            {
                ++currentRetry;
                continue;
            }

            return purchase;
        }

        return PurchaseResult.None;
    }

    public new Task<IEnumerable<MostPopularItemRecord>> GetMostPopularItemsAsync(CancellationToken ct = default)
    {
        return base.GetMostPopularItemsAsync(ct);
    }
}
