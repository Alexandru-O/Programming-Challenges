string hexaNumber;
int decimalNumber = 0;

do
{
    try
    {
        Console.Write("Please insert a hexadecimal number: ");
        hexaNumber = Console.ReadLine();

        decimalNumber = int.Parse(hexaNumber, System.Globalization.NumberStyles.HexNumber);
    }
    catch
    {
        Console.WriteLine("Insert only hexadecimal numbers!");
        continue;
    }

    Console.WriteLine($"Decimal number: {decimalNumber}");
    exit();
    break;
}while(true);

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}