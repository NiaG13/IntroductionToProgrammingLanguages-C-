// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа n и m.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29
// P.S.: поменял местами коэффициенты, для более лёгкого восприятия функции в общем виде.

Main();

void Main()
{
    bool work = true;
    while(work)
    {
        System.Console.WriteLine("Hello! Run the program? y/n");
        string a = Console.ReadLine();
        switch(a)
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
    double n = 3;
    double m = 10; // максиум для рекурсивного метода, итеративный не смог пока придумать
    System.Console.Write($"A({n},{m}) = ");
    System.Console.WriteLine(Ackerman(n, m) + ".");
}

double Ackerman(double n, double m)
{
    double number;
    if(n == 0)
    {
        number = m + 1;
    }
    else if(m == 0)
    {
        return Ackerman(n-1, 1);
    }
    else
    {
        return Ackerman(n - 1, Ackerman(n, m - 1));
    }
    return number;
}
