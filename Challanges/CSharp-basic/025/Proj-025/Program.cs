
for(int i = 1; i<= 99; i++)
{
    if (i % 2 != 0)
        Console.WriteLine(i);
}
exit();
void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.Read();
}