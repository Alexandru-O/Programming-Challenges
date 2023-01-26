int[] nums;
do
{
    try
    {
        Console.Write("Input array: ");
        nums = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }), s => int.Parse(s));
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }
    break;
} while (true);

bool check = false;

foreach (int num in nums)
{
    if (num % 2 == 1)
        check = true;
}
Console.WriteLine(check);
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}