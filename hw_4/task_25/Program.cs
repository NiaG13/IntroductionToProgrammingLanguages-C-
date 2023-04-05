// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

double Exponent(int x, int y)
{
    double result = 1;
    for(int i = 1; i <= y; i++)
    {
        result *=x;
    }
    return result;
}

void Task()
{
    int a = ReadInt("an integer number A");
    int b = ReadInt("an integer exponent B");
    System.Console.WriteLine($"{a}^{b} = {Exponent(a,b)}");
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 0)
    {
        System.Console.WriteLine("It's not an integer number");
    }
    return number;
}