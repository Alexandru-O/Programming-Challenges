int number;
try
{
    Console.Write("Enter a digit: ");
    number = int.Parse(Console.ReadLine());

    /*-- first part with Console.Write --*/
    Console.Write(number);
    Console.Write(' ');
    Console.Write(number);
    Console.Write(' ');
    Console.Write(number);
    Console.Write(' ');
    Console.Write(number);
    Console.Write('\n');

    Console.Write(number);
    Console.Write(number);
    Console.Write(number);
    Console.Write(number);
    Console.Write('\n');

    /*-- second part with Console.Write --*/

    Console.WriteLine("{0} {0} {0} {0}", number);
    Console.WriteLine("{0}{0}{0}{0}",number);


}
catch
{
    Console.WriteLine("Please insert only numbers!");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}
/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();