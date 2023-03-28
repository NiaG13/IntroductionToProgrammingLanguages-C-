// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Enter();

void Enter()
{
    bool work = true;
    while(work)
    {
        Console.WriteLine("Run the programm? y/n");
        string a = Console.ReadLine();
        switch(a)
        {
            case "y": task(); break;
            case "n": work = false; break;
            default: break;
        }
    }
    Console.WriteLine("Have a good time!");
}

void task()
{
    int Number = ReadInt("Number");
    int twoNumber = Number / 10;
    int secondNumber = twoNumber % 10;
    Console.WriteLine($"Second numer: {secondNumber}");
}

int ReadInt(string argument)
{
    int number;
    Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 99 || number > 1000)
    {
        Console.WriteLine("It's not that!");
    }
    return number;
}