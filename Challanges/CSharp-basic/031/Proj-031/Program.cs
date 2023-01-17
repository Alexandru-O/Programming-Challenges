
string[] values;
int[] firstArray, secondArray;
do
{
    try
    {
        Console.Write("First array: ");
        values = Console.ReadLine().Split(new char[] { ',', '\n', ' ' });

        firstArray = new int[values.Length];

        for (int i = 0; i < values.Length; i++)
            firstArray[i] = int.Parse(values[i]);

        Console.Write("Second array: ");
        values = Console.ReadLine().Split(new char[] { ',', '\n', ' ' });

        secondArray = new int[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            secondArray[i] = int.Parse(values[i]);
        }

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Array length does not match!");
            continue;
        }
    }
    catch
    {
        Console.WriteLine("Insert only integer numbers!");
        continue;
    }
    Console.Write("Result: ");
    for (int i = 0; i < firstArray.Length; i++)
    {
        Console.Write($"{firstArray[i] * secondArray[i]} ");
    }
    Console.WriteLine();
    exit();
    break;
} while (true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}