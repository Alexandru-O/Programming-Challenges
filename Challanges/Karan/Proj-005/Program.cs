/*
    Next Prime Number - Have the program find prime numbers until the user chooses to stop asking for the next one.
*/

List<int> primes = new List<int>();
int nextPrime = 0;
bool isPrime = true;
do
{
    while (!isPrime)
    {
        int sqrt = (int)Math.Sqrt(nextPrime);
        isPrime = true;
        for (int i = 0; (int)primes[i] <= sqrt; i++)
        {
            if (nextPrime % primes[i] == 0)
            {
                isPrime = false;
                break;
            }
        }
        if(isPrime)
            primes.Add(nextPrime);
        nextPrime += 2;
    }

    if (primes.Count > 0)
    {
        Console.WriteLine($"\nNext prime: {primes.Last()}");
        isPrime = false;
    }

    if (primes.Count == 0)
    {
        primes.Add(2);
        nextPrime = 3;
    }

    Console.WriteLine("\nOptions:");
    Console.WriteLine("1 - Generate next prime number");
    Console.WriteLine("2 - Exit");

} while (Console.ReadKey().Key == ConsoleKey.D1);