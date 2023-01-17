FileInfo f;
do
{
    try
    {
        Console.Write("Path to file: ");
        string path = Console.ReadLine();

        f = new FileInfo(path);
        Console.WriteLine($"The file size is {f.Length} bytes");
        exit();
        break;
    }
    catch
    {
        Console.WriteLine("The path is invalid!");
        continue;
    }
} while(true);
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}