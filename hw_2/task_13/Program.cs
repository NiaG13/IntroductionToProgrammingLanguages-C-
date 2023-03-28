// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Enter ();

void Enter()
{
    bool work = true;
    while(work)
    {
        Console.WriteLine("Run the program? y/n");
        string a = Console.ReadLine();
        switch(a)
        {
            case "y": task(); break;
            case "n": work = false; break;
            default: break;
        }
    }
    System.Console.WriteLine("Have a good day!");
}

void task()
{
    int num = ReadInt("num");
    if(num < 99)
    {
        System.Console.WriteLine("No third digit");
    }
    else
    {
        int minusTwoDigit = num / 100;
        int thirdDigit = minusTwoDigit % 10;
        System.Console.WriteLine($"Third digit: {thirdDigit}");
    }
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}