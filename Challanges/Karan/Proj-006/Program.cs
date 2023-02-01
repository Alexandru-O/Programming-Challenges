/*
    Numbers 06. Find Cost of Tile to Cover W x H Floor - Calculate the total cost of tile it would take to cover a floor plan of width and height, 
                using a cost entered by the user.
 */

double height;
double width;
double cost;

do
{
    try
    {
        Console.Write("Floor height: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Floor width: ");
        width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cost per square meter: ");
        cost = Convert.ToDouble(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Please insert only numbers!");
        continue;
    }
    break;
}while(true);

Console.WriteLine($"The total cost is {height * width * cost} for {height * width} square meters");
exit();

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}

