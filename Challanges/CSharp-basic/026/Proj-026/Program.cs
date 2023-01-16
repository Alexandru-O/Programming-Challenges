int sum = 0;
int counter = 0;
int n = 2;
while(counter < 500)
{
    if (isPrime(n))
    {
        sum += n;
        counter++;
    }
    n++;
}

Console.WriteLine($"Result: {sum}");
exit();
bool isPrime(int n)
{
    int x = (int)Math.Floor(Math.Sqrt(n));
    if (n == 1) return false;
    if (n == 2) return true;
    for (int i = 2; i <= x; i++)
        if (n % i == 0)
            return false;
    return true;
}

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}
