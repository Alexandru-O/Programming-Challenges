int number;
try
{
    Console.Write("Enter a number: ");
    number = int.Parse(Console.ReadLine());

    Console.WriteLine("{0}{0}{0}", number);
    Console.WriteLine("{0} {0}", number);
    Console.WriteLine("{0} {0}", number);
    Console.WriteLine("{0} {0}", number);
    Console.WriteLine("{0}{0}{0}", number);
}
catch
{
    Console.WriteLine("Please insert a number!");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}
/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();