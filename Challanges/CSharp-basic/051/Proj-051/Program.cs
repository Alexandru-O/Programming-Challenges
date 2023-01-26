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

    if (nums.Length != 3)
    {
        Console.WriteLine("Length must be equal to 3!");
        continue;
    }

    Console.WriteLine(nums[0] > nums[nums.Length - 1] ? nums[0] : nums[nums.Length - 1]);

    exit();
    break;
} while (true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}