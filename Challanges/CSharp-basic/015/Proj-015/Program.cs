string str;
int pos;

Console.Write("Insert text: ");
str = Console.ReadLine();

try
{
    Console.Write("Insert position to be removed: ");
    pos = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Position must be a number!");
    exit();
    return;
}

if (str.Length < pos)
{
    Console.WriteLine("The position is higher then text length!");
    exit();
    return;
}

Console.WriteLine($"Result: {remove_char(str, pos)}");

static string remove_char(string str, int pos)
{
    return str.Remove(pos,1);
}

void exit()
{
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();
}
