string text;

Console.Write("Please insert text: ");
text = Console.ReadLine();

Console.WriteLine(text.Length < 4 ? text + text + text + text : text.Substring(text.Length-4, 4) + text.Substring(text.Length - 4, 4) + text.Substring(text.Length - 4, 4) + text.Substring(text.Length - 4, 4));
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}
