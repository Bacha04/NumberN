// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write number");
var n = Console.ReadLine();
try
{
    int x = int.Parse(n);
    Console.WriteLine($"Ви ввели число {x}");
}
catch 
{
    Console.WriteLine("Ви не ввели число!");
}
