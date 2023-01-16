int firstInt, secondInt;

do
{
    try
    {
        Console.Write("Insert first number: ");
        firstInt = int.Parse(Console.ReadLine());

        Console.Write("Insert second number: ");
        secondInt = int.Parse(Console.ReadLine());
    }

    catch
    {
        Console.WriteLine("Please insert only numbers!");
        continue;
    }

    Console.WriteLine((firstInt < 0 && secondInt > 0) || (firstInt > 0 && secondInt < 0));
    exit();
    break;
}
while (true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}