char word;
do
{
    try
    {
        Console.Write("Insert char: ");
        word = char.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert a char!");
        continue;
    }
    break;
} while (true);

Console.Write("Insert text: ");
string text = Console.ReadLine();

int count = text.Split(word).Length - 1;

Console.WriteLine(count >= 1 && count <= 3);
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}
