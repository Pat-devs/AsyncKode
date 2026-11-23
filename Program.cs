Task kettle = Task.Delay(1000);
Task toaster = Task.Delay(2000);

await Task.WhenAll(kettle, toaster);

Console.WriteLine("Breakfast ready!");