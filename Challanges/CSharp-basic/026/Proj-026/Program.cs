int sum = 0;
for (int i = 1; i <= 500; i++)
{
    if (isPrime(i))
        sum += i;
}

Console.WriteLine($"Result: {sum}");
exit();
bool isPrime(int n)
{
    if (n == 1) return false;
    if (n == 2) return true;
    for (int i = 2; i < n / 2; i++)
        if (n % i == 0)
            return false;
    return true;
}

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}
