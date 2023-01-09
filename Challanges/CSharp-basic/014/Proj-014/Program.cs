int temp;
try
{
    Console.Write("Enter the amount of celsius: ");
    temp = int.Parse(Console.ReadLine());

    Console.WriteLine($"Kelvin = {temp + 273}");
    Console.WriteLine($"Fahrenheit = {temp * 1.8 + 32}");
}
catch
{
    Console.WriteLine("Temperature must be a number!");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}
/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();