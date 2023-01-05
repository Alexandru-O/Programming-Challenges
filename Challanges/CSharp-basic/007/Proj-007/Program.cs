int firstNumber, secondNumber;

try
{
    Console.Write("Input the first number: ");
    firstNumber = int.Parse(Console.ReadLine());
    Console.Write("Input the second number: ");
    secondNumber= int.Parse(Console.ReadLine());

    /*--- output ---*/

    Console.WriteLine($"Sum:\t\t {firstNumber + secondNumber}");
    Console.WriteLine($"Dif:\t\t {firstNumber - secondNumber}");
    Console.WriteLine($"Multiply:\t {firstNumber * secondNumber}");
    Console.WriteLine($"Div:\t\t {firstNumber / secondNumber}");
    Console.WriteLine($"Mod:\t\t {firstNumber % secondNumber}");
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