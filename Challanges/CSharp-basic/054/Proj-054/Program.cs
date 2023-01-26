int year;
do
{
    try
    {
        Console.Write("Insert year: ");
        year = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }
    break;

} while(true);

Console.WriteLine($"Century: {year / 100 + (year % 100 == 0 ? 0 : 1)}");
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}