string text;
char word;
do
{

    Console.Write("Input word: ");
    if (!char.TryParse(Console.ReadLine(),out word))
    {
        Console.WriteLine("Word must have 1 char!");
        continue;
    }

    Console.Write("Input text: ");
    text = Console.ReadLine();

    if (text.Length < 3)
    {
        Console.WriteLine("Text length must have min 3 char!");
        continue;
    }
    break;
} while (true);

Console.WriteLine(text.Substring(0, 1) == word.ToString() && text.Substring(1, 2) == word.ToString() + word);

exit();

void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}