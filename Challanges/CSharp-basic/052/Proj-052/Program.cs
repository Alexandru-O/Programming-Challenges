int[] nums1;
int[] nums2;
int[] nums3;
do
{
    try
    {
        Console.Write("Input first array: ");
        nums1 = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }), s => int.Parse(s));

        Console.Write("Input second array: ");
        nums2 = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }), s => int.Parse(s));

        Console.Write("Input third array: ");
        nums3 = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }), s => int.Parse(s));
    }
    catch
    {
        Console.WriteLine("Please insert only integers!");
        continue;
    }

    if (nums1.Length != 3 || nums2.Length != 3 || nums1.Length != 3)
    {
        Console.WriteLine("Length must be equal to 3!");
        continue;
    }

    Console.WriteLine("New array:" + nums1[1] + ' ' + nums2[1] + ' ' + nums3[1]);

    exit();
    break;
} while (true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}