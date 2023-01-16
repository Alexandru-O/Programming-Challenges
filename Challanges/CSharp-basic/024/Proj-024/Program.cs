Console.Write("Insert text: ");
string[] words = Console.ReadLine().Split(' ');
string max = "";
foreach(string word in words)
{
    if (word.Length >= max.Length)
        max = word;
}

Console.WriteLine($"Result: {max}");
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}
