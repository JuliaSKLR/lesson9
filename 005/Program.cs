// Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


bool IsBinary(int number)
{
    if (number == 1)
    {
        return (true);
    }
    return IsBinary(number / 2) && (number%2==0);
    
}

int num = Prompt("Enter number");
bool result = IsBinary(num);
System.Console.WriteLine(result);