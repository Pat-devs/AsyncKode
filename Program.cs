Task timer = Task.Delay(2000);

Console.WriteLine("Order recieved");
Console.WriteLine("Here is your receipt");
// Thread.Sleep(2000);


await timer;

Console.WriteLine("Coffe ready!");