int firstNumber, secondNumber;
do
{
    try
    {
        Console.Write("First integer: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second integer: ");
        secondNumber = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }

    if (firstNumber == secondNumber)
        Console.WriteLine(0);
    else
    {
        Console.WriteLine(Math.Abs(20 - firstNumber) < Math.Abs(20 - secondNumber) ? firstNumber : secondNumber);
    }
    exit();
    break;
}while(true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}