do
{
    Console.Write("Insert text: ");
    string str = Console.ReadLine();

    if (str.Length < 2)
    {
        Console.WriteLine("The text must have min 2 char!");
        continue;
    }

    Console.WriteLine(str[0] + str + str[0]);
    exit();
    break;

} while(true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}