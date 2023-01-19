int[] ints;
int sum = 0;

do
{
    try
    {
        Console.Write("Input int array: ");
        ints = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',', }), s => Convert.ToInt32(s));

        if (ints.Length == 0)
        {
            Console.WriteLine("Array length must be greater then 0");
            continue;
        }
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }

    foreach(int i in ints)
    {
        sum += i;
    }
    break;

} while (true);
Console.WriteLine("Sum:" + sum);
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}