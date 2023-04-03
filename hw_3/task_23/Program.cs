// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу (СТРОКУ) кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input integer {argument} > 1: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 1)
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}

void Task()
{
    int N = ReadInt("N");
    for (int i = 1; i <= N; i++)
    {
        System.Console.Write(Math.Pow( i, 3) + " ");
    }
    System.Console.WriteLine();
}
