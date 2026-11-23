try
{
    string answer = await GetAnswerAsync();
    Console.WriteLine(answer);
}
catch (InvalidOperationException error)
{
    Console.WriteLine($"Could not get answer: {error.Message}");
}

static async Task<string> GetAnswerAsync()
{
    await Task.Delay(300);
    throw new InvalidOperationException("Reader is offline.");
}