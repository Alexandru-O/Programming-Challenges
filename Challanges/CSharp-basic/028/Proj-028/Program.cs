Console.Write("Insert text: ");
string[] words = Console.ReadLine().Split(' ');
for (int i = words.Length - 1; i>= 0; i--)
{
    Console.Write(words[i]+ " ");
}
exit();


void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}