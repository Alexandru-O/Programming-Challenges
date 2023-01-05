int firstNumber, secondNumber, thirdNumber, fourthNumber, avgNumber;

try
{
    Console.Write("Enter the first number: ");
    firstNumber = int.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    secondNumber = int.Parse(Console.ReadLine());
    Console.Write("Enter the third number: ");
    thirdNumber = int.Parse(Console.ReadLine());
    Console.Write("Enter the fourth number: ");
    fourthNumber = int.Parse(Console.ReadLine());

    avgNumber = (firstNumber+ secondNumber + thirdNumber + fourthNumber) / 4;

    Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is {avgNumber}");
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