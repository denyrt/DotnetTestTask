using TestTask.API.Controllers;
using TestTask.API.Tests.DatabaseSeed;
using TestTask.Services;

namespace TestTask.API.Tests.MarketTestCases;

public class GetMostPopularItemsTests : BaseTest
{
    protected override async Task SetupBase()
    {
        await DefaultDatabaseSeed.ApplyAsync();
        await base.SetupBase();
    }

    [Test]
    public async Task GetMostPopularItems_ShouldReturnMostPopularItems()
    {
        var response = await Rait<MarketController>().Call(controller => controller.GetMostPopularItems());
        var items = response?.Value;

        // According to 'DefaultDatabaseSeed' we should get 9 records
        const int TOTAL_RECORDS_AMOUNT = 9;

        // 3 records for 2022 year | most popular: common (4 purchases), rare (3 purchases), legendary (3 purchases)
        var common_2022 = new MostPopularItemRecord(2022, DefaultDatabaseSeed.ITEM_NAME_COMMON, 4);
        var rare_2022 = new MostPopularItemRecord(2022, DefaultDatabaseSeed.ITEM_NAME_RARE, 3);
        var legendary_2022 = new MostPopularItemRecord(2022, DefaultDatabaseSeed.ITEM_NAME_LEGENDARY, 3);

        // 3 records for 2023 year | most popular: uncommon (4 purchases), epic (3 purchases), rare (3 purchases)
        var uncommon_2023 = new MostPopularItemRecord(2023, DefaultDatabaseSeed.ITEM_NAME_UNCOMMON, 4);
        var epic_2023 = new MostPopularItemRecord(2023, DefaultDatabaseSeed.ITEM_NAME_EPIC, 3);
        var rare_2023 = new MostPopularItemRecord(2023, DefaultDatabaseSeed.ITEM_NAME_RARE, 3);

        // 3 records for 2024 year | most popular: uncommon (4 purchases), epic (3 purchases), legendary (3 purchases)
        var uncommon_2024 = new MostPopularItemRecord(2024, DefaultDatabaseSeed.ITEM_NAME_UNCOMMON, 4);
        var epic_2024 = new MostPopularItemRecord(2024, DefaultDatabaseSeed.ITEM_NAME_EPIC, 3);
        var legendary_2024 = new MostPopularItemRecord(2024, DefaultDatabaseSeed.ITEM_NAME_LEGENDARY, 3);

        Assert.That(response, Is.Not.Null);
        Assert.That(items, Is.Not.Null);
        Assert.That(items, Has.Length.EqualTo(TOTAL_RECORDS_AMOUNT));

        // Thanks to 'MostPopularItemRecord' is 'record' we could use this 'Contains.Item()'.
        // Records have ovverided equals to check property values.

        Assert.That(items, Contains.Item(common_2022));
        Assert.That(items, Contains.Item(rare_2022));
        Assert.That(items, Contains.Item(legendary_2022));

        Assert.That(items, Contains.Item(uncommon_2023));
        Assert.That(items, Contains.Item(epic_2023));
        Assert.That(items, Contains.Item(rare_2023));

        Assert.That(items, Contains.Item(uncommon_2024));
        Assert.That(items, Contains.Item(epic_2024));
        Assert.That(items, Contains.Item(legendary_2024));
    }
}
