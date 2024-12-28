using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TestTask.Services;

namespace TestTask.API.Controllers;

[ApiController]
[Route("market")]
public class MarketController : ControllerBase
{
    private readonly MarketService _marketService;

    public MarketController(MarketService marketService)
    {
        _marketService = marketService;
    }

    [HttpPost]
    public async Task BuyAsync(int userId, int itemId)
    {
        await _marketService.BuyAsync(userId, itemId);
    }

    [HttpGet("most-popular")]
    public async Task<ActionResult<MostPopularItemRecord[]>> GetMostPopularItems()
    {
        IEnumerable<MostPopularItemRecord> items = await _marketService.MostPopularItemsAsync();
        return Ok(items);
    }
}