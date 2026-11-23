Console.WriteLine("A: calling");
Task<string> pending = ReadLabelAsync();
Console.WriteLine("C: caller has the task");
string label = await pending;
Console.WriteLine($"E: {label}");


static async Task<string> ReadLabelAsync()
{
    Console.WriteLine("B: entered method");
    await Task.Delay(2000);
    Console.WriteLine("D: label ready");
    return "Fragile";
}