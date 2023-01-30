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