Console.WriteLine("Starting");
await AnnounceReadyAsync();
Console.WriteLine("Done");

static async Task AnnounceReadyAsync()
{
    Console.WriteLine("Preparing...");
    await Task.Delay(2000);
    Console.WriteLine("Ready!");
}
