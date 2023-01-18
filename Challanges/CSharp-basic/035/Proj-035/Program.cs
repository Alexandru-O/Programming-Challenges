int firstNumber, secondNumber;
do
{
    try
    {
        Console.Write("First number: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        secondNumber = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only numbers!");
        continue;
    }
    Console.WriteLine(firstNumber < 100 && secondNumber > 200);
    exit();
    break;

} while (true);

void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}
