Console.Write("Insert text: ");
string text = Console.ReadLine();

Console.WriteLine(text.ToLower());
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}