using System.Threading.Channels;

Console.Write("Enter Word: ");
string word = Console.ReadLine();
Console.Write("Enter text: ");
string text = Console.ReadLine();

Console.WriteLine(text.StartsWith(word));
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
}