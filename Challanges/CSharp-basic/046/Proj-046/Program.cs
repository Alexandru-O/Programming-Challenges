int[] ints;
int number;
int count = 0;
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

        Console.Write("Input an integer: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }

    Console.WriteLine(ints[0] == number || ints[ints.Length - 1] == number);
    break;

} while (true);
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}