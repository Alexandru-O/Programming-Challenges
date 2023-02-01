/*
    Find PI to the Nth Digit - Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.
 */

int digits;
const double Pi = Math.PI;
do
{
    try
    {
        Console.Write("How many digits (limit is 15): ");
        digits = Convert.ToInt32(Console.ReadLine());
    }
    catch 
    {
        Console.WriteLine("Please insert only numbers");
        continue;
    }
    break;
} while(true);

if (digits > 15)
    digits = 15;

Console.WriteLine(Math.Round(Pi, digits));
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}