int firstNumber, secondNumber, thirdNumber;

try
{
    Console.Write("Enter the first number: ");
    firstNumber = int.Parse(Console.ReadLine());
    Console.Write("Enter the second number: ");
    secondNumber= int.Parse(Console.ReadLine());
    Console.Write("Enter the third number: ");
    thirdNumber= int.Parse(Console.ReadLine());

    Console.WriteLine($"({firstNumber} + {secondNumber}) * {thirdNumber} = {(firstNumber + secondNumber) * thirdNumber}");
    Console.WriteLine($"{firstNumber} * {secondNumber} + {secondNumber} * {thirdNumber} = {firstNumber * secondNumber + secondNumber * thirdNumber}");
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