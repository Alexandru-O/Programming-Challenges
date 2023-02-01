/*
    Find e to the Nth Digit - Just like the previous problem, but with e instead of PI. Enter a number and have the program generate e up to that many decimal places. 
    Keep a limit to how far the program will go.
*/
int digits;
const double e = Math.E;
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
} while (true);

if (digits > 15)
    digits = 15;

Console.WriteLine(Math.Round(e, digits));
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}