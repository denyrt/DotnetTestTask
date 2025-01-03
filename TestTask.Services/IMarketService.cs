namespace TestTask.Services;

public interface IMarketService
{
    Task<PurchaseResult> BuyAsync(int userId, int itemId, CancellationToken ct = default);

    Task<IEnumerable<MostPopularItemRecord>> GetMostPopularItemsAsync(CancellationToken ct = default);
}
