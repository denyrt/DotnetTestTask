using TestTask.Data.Entities;

namespace TestTask.API.Tests.DatabaseSeed;

internal static partial class DefaultDatabaseSeed
{
    public const string ITEM_NAME_COMMON    = "Common Item";
    public const string ITEM_NAME_UNCOMMON  = "Uncommon Item";
    public const string ITEM_NAME_RARE      = "Rare Item";
    public const string ITEM_NAME_EPIC      = "Epic Item";
    public const string ITEM_NAME_LEGENDARY = "Legendary Item";

    public const int ITEM_ID_COMMON    = 1;
    public const int ITEM_ID_UNCOMMON  = 2;
    public const int ITEM_ID_RARE      = 3;
    public const int ITEM_ID_EPIC      = 4;
    public const int ITEM_ID_LEGENDARY = 5;

    private static readonly Item[] Items = 
    [
        new()
        {
            Id = ITEM_ID_COMMON,
            Name = ITEM_NAME_COMMON,
            Cost = 100
        },
        new()
        {
            Id = ITEM_ID_UNCOMMON,
            Name = ITEM_NAME_UNCOMMON,
            Cost = 200
        },
        new()
        {
            Id = ITEM_ID_RARE,
            Name = ITEM_NAME_RARE,
            Cost = 500
        },
        new()
        {
            Id = ITEM_ID_EPIC,
            Name = ITEM_NAME_EPIC,
            Cost = 1000
        },
        new()
        {
            Id = ITEM_ID_LEGENDARY,
            Name = ITEM_NAME_LEGENDARY,
            Cost = 5000
        }
    ];
}
