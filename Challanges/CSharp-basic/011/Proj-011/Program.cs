int age;
try
{
    Console.Write("Please insert your age: ");
    age = int.Parse(Console.ReadLine());

    Console.WriteLine($"You look older then {age}!");
}
catch
{
    Console.WriteLine("Age must be a number!");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}
/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();