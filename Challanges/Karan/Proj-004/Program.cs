int digits;
do
{
    try
    {
        Console.Write("How many elements (limit is 20): ");
        digits = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only numbers");
        continue;
    }
    if (digits > 20)
        digits = 20;

    List<int> primes = GeneratePrimes(digits);
    Console.WriteLine(String.Join(" ", primes.ToArray()));

    exit();
    break;
} while (true);


void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}

List<int> GeneratePrimes(int n)
{
    List<int> primes = new List<int>();
    primes.Add(2);
    int nextPrime = 3;
    while (primes.Count < n)
    {
        int sqrt = (int)Math.Sqrt(nextPrime);
        bool isPrime = true;
        for (int i = 0; (int)primes[i] <= sqrt; i++)
        {
            if (nextPrime % primes[i] == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            primes.Add(nextPrime);
        }
        nextPrime += 2;
    }
    return primes;
}
