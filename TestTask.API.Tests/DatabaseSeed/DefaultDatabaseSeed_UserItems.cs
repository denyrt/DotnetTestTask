using TestTask.Data.Entities;

namespace TestTask.API.Tests.DatabaseSeed;

internal static partial class DefaultDatabaseSeed
{
    /// <summary>
    /// Purchases for 2022.
    /// Most popular items: COMMON, RARE, LEGENDARY.
    /// </summary>
    private static readonly UserItem[] UserItems_2022 = [
        // user1 bought 4 common items in a single day. (#1 popular item for 2022)
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("1/2/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("1/2/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("1/2/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("1/2/2022").ToUniversalTime()
        },

        // user2 bought 3 rare items in a single day. (#2 popular item for 2022)
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_RARE,
            PurchaseDate = DateTime.Parse("1/3/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_RARE,
            PurchaseDate = DateTime.Parse("1/3/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_RARE,
            PurchaseDate = DateTime.Parse("1/3/2022").ToUniversalTime()
        },

        // user3 bought 3 legendary items in a single day. (#3 popular item for 2022)
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_LEGENDARY,
            PurchaseDate = DateTime.Parse("1/4/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_LEGENDARY,
            PurchaseDate = DateTime.Parse("1/4/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_LEGENDARY,
            PurchaseDate = DateTime.Parse("1/4/2022").ToUniversalTime()
        },

        // Other purchases that not effects most popular items statistics.
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("2/2/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("2/3/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("2/4/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("2/5/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("2/6/2022").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("2/7/2022").ToUniversalTime()
        }
    ];

    /// <summary>
    /// Purchases for 2023.
    /// Most popular items: UNCOMMON, EPIC, RARE.
    /// </summary>
    private static readonly UserItem[] UserItems_2023 = [
        // user2 bought 4 uncommon items in a single day. (#1 popular item for 2023)
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2023").ToUniversalTime()
        },

        // user1 bought 3 epic items in a single day. (#2 popular item for 2023)
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("1/3/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("1/3/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("1/3/2023").ToUniversalTime()
        },

        // user3 bought 3 rare items in a single day. (#3 popular item for 2023)
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_RARE,
            PurchaseDate = DateTime.Parse("1/4/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_RARE,
            PurchaseDate = DateTime.Parse("1/4/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_RARE,
            PurchaseDate = DateTime.Parse("1/4/2023").ToUniversalTime()
        },

        // Other purchases that not effects most popular items statistics.
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("2/2/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("2/3/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("2/4/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("2/5/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("2/6/2023").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("2/7/2023").ToUniversalTime()
        }
    ];

    /// <summary>
    /// Purchases for 2024.
    /// Most popular items: UNCOMMON, EPIC, LEGENDARY.
    /// </summary>
    private static readonly UserItem[] UserItems_2024 = [
        // user2 bought 4 uncommon items in a single day. (#1 popular item for 2024)
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("1/2/2024").ToUniversalTime()
        },

        // user1 bought 3 epic items in a single day. (#2 popular item for 2024)
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("1/3/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("1/3/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("1/3/2024").ToUniversalTime()
        },

        // user3 bought 3 legendary items in a single day. (#3 popular item for 2024)
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_LEGENDARY,
            PurchaseDate = DateTime.Parse("1/4/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_LEGENDARY,
            PurchaseDate = DateTime.Parse("1/4/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_LEGENDARY,
            PurchaseDate = DateTime.Parse("1/4/2024").ToUniversalTime()
        },

        // Other purchases that not effects most popular items statistics.
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("2/2/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("2/3/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("2/4/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_1,
            ItemId = ITEM_ID_COMMON,
            PurchaseDate = DateTime.Parse("2/5/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_2,
            ItemId = ITEM_ID_UNCOMMON,
            PurchaseDate = DateTime.Parse("2/6/2024").ToUniversalTime()
        },
        new()
        {
            UserId = USER_ID_3,
            ItemId = ITEM_ID_EPIC,
            PurchaseDate = DateTime.Parse("2/7/2024").ToUniversalTime()
        }
    ];
}
