int[] ints1;
int[] ints2;
do
{
    try
    {
        Console.Write("Input first array: ");
        ints1 = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',', }), s => Convert.ToInt32(s));

        Console.Write("Input second array: ");
        ints2 = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',', }), s => Convert.ToInt32(s));

        if (ints1.Length == 0 || ints2.Length == 0)
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
    break;

} while (true);
Console.WriteLine(ints1[0] == ints2[0] || ints1[ints1.Length - 1] == ints2[ints2.Length - 1]);
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}
