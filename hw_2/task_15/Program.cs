// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

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
    string message = "DAY OF!!!";
    if(Number < 6) message = "weekday";
    System.Console.WriteLine(message);
}

int ReadInt(string argument)
{
    int number;
    Console.WriteLine($"Input the day's number {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 7)
    {
        Console.WriteLine("It's not that!");
    }
    return number;
}