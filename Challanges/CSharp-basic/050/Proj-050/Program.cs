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
    var temp = nums[0];
    for (var i = 0; i < nums.Length - 1; i++)
    {
        nums[i] = nums[i + 1];
    }
    nums[nums.Length - 1] = temp;
    Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
    exit();
    break;
}while(true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}