using TestTask.Data.Entities;

namespace TestTask.API.Tests.DatabaseSeed;

internal static partial class DefaultDatabaseSeed
{
    public const int USER_ID_1 = 1;
    public const int USER_ID_2 = 2;
    public const int USER_ID_3 = 3;

    private static readonly User[] Users = 
    [
        new()
        {
            Id = USER_ID_1,
            Email = "User1@test",
            Balance = 100000
        },
        new()
        {
            Id = USER_ID_2,
            Email = "User2@test",
            Balance = 100000
        },
        new()
        {
            Id = USER_ID_3,
            Email = "User3@test",
            Balance = 100000
        }
    ];
}
