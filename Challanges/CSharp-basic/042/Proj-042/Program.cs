Console.Write("Input text: ");
string text = Console.ReadLine();

if (text.Length < 4)
    Console.WriteLine(text.ToUpper());
else
    Console.WriteLine(text.Substring(0,4).ToLower() + text.Substring(4));
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}