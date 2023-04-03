// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Main();
void Main()
{
    bool work = true;
    while (work)
    {
        System.Console.WriteLine("Hello! Run the program? y/n");
        string a = Console.ReadLine();
        switch (a)
        {
            case "y": Task(); break;
            case "n": work = false; break;
            default: break;
        }
    }
    System.Console.WriteLine("Have a good time!");
}

void Task()
{
    int fiveDigitNum = ReadInt("A");
    int fiveDigit = fiveDigitNum / 10000;
    int fourDigit = fiveDigitNum / 1000 % 10;
    int twoDigit = fiveDigitNum / 10 % 10;
    int oneDigit = fiveDigitNum % 10;
    if(fiveDigit == oneDigit && fourDigit == twoDigit)
    {
        System.Console.WriteLine("This is palindrome!");
    }
    else System.Console.WriteLine("This isn't palindrome");
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input a five-digit number {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 10000 || number > 99999)
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}
