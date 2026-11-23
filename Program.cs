Task<int> ticket = Task.FromResult(42);

int seat = await ticket;
Console.WriteLine($"Your seat is {seat}");