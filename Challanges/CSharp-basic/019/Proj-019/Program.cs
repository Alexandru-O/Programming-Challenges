int firstNumber, secondNumber;

do
{

    try
    {
        Console.Write("First number: ");
        firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        secondNumber= int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only numbers!");
        continue;
    }
    /*--- if its equal then return triple of their sum ---*/
    Console.WriteLine(firstNumber == secondNumber ? (firstNumber + secondNumber) * 3 : firstNumber + secondNumber);
    exit();
    break;
}
while (true);
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}