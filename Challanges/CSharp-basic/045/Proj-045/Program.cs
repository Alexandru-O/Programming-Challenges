int[] ints;
int number;
int count = 0;
do
{
    try
    {
        Console.Write("Input int array: ");
        ints = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }), s => Convert.ToInt32(s));

        Console.Write("Input an integer: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }

    Console.WriteLine($"Number of {number} present in the said array: {ints.Count(n => n == number)}");
    break;

}while(true);
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}