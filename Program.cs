Task<string> ticket = Task.FromResult("Window");

string seat = await ticket;
Console.WriteLine($"Your seat is by the {seat}");