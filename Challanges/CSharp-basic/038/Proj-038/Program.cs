string newText;
do
{
    Console.Write("Insert text: ");
    string text = Console.ReadLine();
    if (text.Length < 2)
    {
        Console.WriteLine("Text length must be min 2");
        continue;
    }

    if (text.StartsWith("PH"))
        newText = text.Substring(0, 2);
    else
    {
        Console.WriteLine("Text must start with \"PH\"");
        continue;
    }

    Console.WriteLine(newText);
    exit();
    break;
}
while (true);
void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}