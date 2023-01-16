int n;
int sum = 0;
do
{
    try {
        Console.Write("Input a number: ");
        n = int.Parse(Console.ReadLine());
    }
    catch {
        Console.WriteLine("Insert only numbers!");
        continue;
        exit();
    }

    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }

    Console.WriteLine($"Result: {sum}");
    exit();
    break;
}
while(true);
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}
