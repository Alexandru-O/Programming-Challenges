int number;
do
{
    try
    {
        Console.Write("Insert a positive number: ");
        number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Please insert a positive number!");
            continue;

        }
    }
    catch
    {
        Console.WriteLine("Please insert a positive number!");
        continue;
    }
    Console.WriteLine(number % 3 == 0 || number % 7 == 0);
    exit();
    break;

} while(true);

void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}