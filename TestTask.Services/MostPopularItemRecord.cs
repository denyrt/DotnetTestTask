namespace TestTask.Services;

public record MostPopularItemRecord
{
    public int Year { get; init; }

    public string ItemName { get; init; }

    public int BoughtNumber { get; init; }

    public MostPopularItemRecord(int year, string itemName, int boughtNumber)
    {
        Year = year;
        ItemName = itemName;
        BoughtNumber = boughtNumber;
    }
}
