int firstNumber, secondNumber, thirdNumber;

try
{
    Console.Write("Input the first number to multiply:");
    firstNumber = int.Parse(Console.ReadLine());
    Console.Write("Input the second number to multiply:");
    secondNumber = int.Parse(Console.ReadLine());
    Console.Write("Input the third number to multiply:");
    thirdNumber = int.Parse(Console.ReadLine());

    Console.WriteLine($"Result: {firstNumber * secondNumber * thirdNumber}");
}
catch
{
    Console.WriteLine("Please insert only numbers");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}
/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();