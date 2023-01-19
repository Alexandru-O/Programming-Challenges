Console.Write("Input text: ");
string text = Console.ReadLine();

for (int i = 0; i < text.Length; i++)
{
    if (i % 2 == 0)
        Console.Write(text[i]);
}
Console.WriteLine();
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}
