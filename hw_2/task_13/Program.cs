// Напишите программу, которая выводит ТРЕТЬЮ цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Main ();

void Main()
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
    if(num < 100)
    {
        System.Console.WriteLine("No a third number");
    }
    else
    {
        while(num > 1000)
        {
            num = num / 10;
        }
        int thirdNumber = num % 10;
        System.Console.WriteLine($"The third number: {thirdNumber}");
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
