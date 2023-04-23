// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
    int M = new Random().Next(0, 20);
    int N = new Random().Next(0, 20);
    if(M > N)
    {
        int temp = N;
        N = M;
        M = temp;
    }
    System.Console.Write($"Sum of numbers from {M} to {N} is ");
    System.Console.WriteLine(Sum(M, N) + ".");
}

int Sum(int m, int n)
{
    int sum = m;
    if(m < n)
    {
        sum += Sum(m + 1, n);
    }
    return sum;
}