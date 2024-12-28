namespace TestTask.API.Tests.DatabaseSeed;

internal static partial class DefaultDatabaseSeed
{
    public static async Task ApplyAsync()
    {
        await Context.DbContext.Users.AddRangeAsync(Users);
        await Context.DbContext.Items.AddRangeAsync(Items);

        await Context.DbContext.UserItems.AddRangeAsync(UserItems_2022);
        await Context.DbContext.UserItems.AddRangeAsync(UserItems_2023);
        await Context.DbContext.UserItems.AddRangeAsync(UserItems_2024);

        await Context.DbContext.SaveChangesAsync();
    }
}
