/*
    Fibonacci Sequence - Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
 */

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

    int[] fibonacciSeq = new int[digits];
    fibonacciSeq[0] = 0;
    fibonacciSeq[1] = 1;

    for (int i = 2; i < digits; i++)
    {
        fibonacciSeq[i] = fibonacciSeq[i - 1] + fibonacciSeq[i - 2];
    }
    Console.WriteLine(String.Join(' ',fibonacciSeq));
    exit();
    break;
} while (true);


void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}