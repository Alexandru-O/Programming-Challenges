int[] ints;
do
{
    try
    {
        Console.Write("Insert 3 numbers with separator between them: ");
        ints = Array.ConvertAll(Console.ReadLine().Split(new Char[] { ' ', ',' }), s => int.Parse(s));
    }
    catch
    {
        Console.WriteLine("Insert only numbers!");
        continue;
    }

    if (ints.Length != 3)
    {
        Console.WriteLine("Insert only 3 numbers!");
        continue;
    }
   
    Console.WriteLine($"Max: {ints.Max()} \nMin: {ints.Min()}");
    exit();
    break;
    
} while(true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}