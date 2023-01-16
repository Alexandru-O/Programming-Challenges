int number;

do
{
    try
    {
        Console.Write("First number: ");
        number = int.Parse(Console.ReadLine());

    }
    catch
    {
        Console.WriteLine("Please insert only numbers!");
        continue;
    }
    Console.WriteLine($"Result: {(Math.Abs(number - 100) <= 20 || Math.Abs(number - 200) <= 20)}");
    exit();
    break;
}
while (true);
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}