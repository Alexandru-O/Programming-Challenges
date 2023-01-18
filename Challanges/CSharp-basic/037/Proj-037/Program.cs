do
{
    Console.Write("Insert word: ");
    string word = Console.ReadLine();
    if (word.Length < 2)
    {
        Console.WriteLine("Word length must be min 2");
        continue;
    }

    Console.Write("Insert text: ");
    string text = Console.ReadLine();
    if (text.Length < 2)
    {
        Console.WriteLine("Text length must be min 2");
        continue;
    }

    Console.WriteLine(text.Substring(1,2) == "HP" ? text.Remove(1,2) : false);
    exit();
    break;
}
while (true);
void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}