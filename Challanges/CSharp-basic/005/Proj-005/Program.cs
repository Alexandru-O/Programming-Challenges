int firstNumber;
int secondNumber;
int temp;
try
{
    Console.Write("Input the first number: ");
    firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Input the second number: ");
    secondNumber = int.Parse(Console.ReadLine());

    temp = firstNumber;
    firstNumber= secondNumber;
    secondNumber= temp;

    Console.WriteLine($"First number:{firstNumber}");
    Console.WriteLine($"Second number:{secondNumber}");
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