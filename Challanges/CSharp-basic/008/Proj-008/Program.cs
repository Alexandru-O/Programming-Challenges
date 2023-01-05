int number;

try
{
    Console.Write("Enter the number: ");
    number = int.Parse(Console.ReadLine());

    for(int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{number} * {i} = {number * i}");
    }
}
catch
{
    Console.WriteLine("Please insert only numbers!");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}

/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();