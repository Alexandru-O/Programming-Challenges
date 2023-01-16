do
{

    Console.Write("Insert text: ");
    string str = Console.ReadLine();
    if (str.Length < 2)
    {
        Console.WriteLine("The text must have min 2 char!");
        continue;
    }

    string result = str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
    Console.WriteLine($"Result: {result}");

    exit();
    break;

} while (true);
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}
