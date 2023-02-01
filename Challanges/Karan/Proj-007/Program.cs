/*
    Credit Card Validator - Takes in a credit card number from a common credit card vendor (Visa, MasterCard, American Express, Discoverer) and validates it to make sure 
    that it is a valid number (look into how credit cards use a checksum).
*/

int[] creditCardNumber;
do
{


    try
    {
        Console.Write("Credit card number: ");
        char[] numbers = Console.ReadLine().Replace(" ", "").Replace("-", "").ToCharArray();
        creditCardNumber = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
            creditCardNumber[i] = int.Parse(numbers[i].ToString());
    }
    catch
    {
        Console.WriteLine("Please enter only numbers!");
        continue;
    }

    if (IsValid(creditCardNumber))
    {
        Console.WriteLine($"The {CardBrand(creditCardNumber)} card is valid");
        exit();
        break;
    }
    else
    {
        Console.WriteLine($"The {CardBrand(creditCardNumber)} card is invalid");
        exit();
        continue;
    }
}while(true);

bool IsValid(int[] cardNumber)
{
    int checkSum = 0;
    //cardNumber = new int[creditCardNumber.Length];
    Array.Copy(cardNumber, creditCardNumber, creditCardNumber.Length);

    for (int i = 0; i < cardNumber.Length; i++)
    {
        if (i % 2 == 0)
        {
            if (cardNumber[i] * 2 > 9)
                cardNumber[i] = (cardNumber[i] * 2) / 10 + (cardNumber[i] * 2) % 10;
            else
                cardNumber[i] = cardNumber[i] * 2;
        }
        checkSum += cardNumber[i];
    }
    Console.WriteLine(string.Join("", creditCardNumber));
    if (checkSum % 10 == 0)
        return true;
    return false;
}

string CardBrand(int[] creditCardNumber)
{
    string card = string.Join("", creditCardNumber);
    Console.WriteLine(card.Substring(0, 2));
    switch(card.Substring(0,2))
    {
        case "36":
            return "American Express";
        case "44":
            return "Visa";
        case "40":
        case "41":
        case "45":
        case "48":
        case "49":
            return "Visa Electron";
        case "51":
        case "52":
        case "53":
        case "54":
        case "55":
            return "Mastercard";
        default:
            return "Unknown";
            break;
    }
}

void exit()
{
    Console.WriteLine("Press Enter to exit!");
    Console.ReadLine();
}