// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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
    double k1 = ReadInt("the coefficient k1 for f(x) = k1*x + b1");
    double b1 = ReadInt("the coefficient b1 for f(x) = k1*x + b1");
    double k2 = ReadInt("the coefficient k2 for f(x) = k2*x + b2");
    double b2 = ReadInt("the coefficient b2 for f(x) = k2*x + b2");
    double[] point = FinderPoint(k1, b1, k2, b2);
    bool intersection = Intersection(k1, k2);
    if(intersection) System.Console.WriteLine($"Intersection point ({string.Join(";", point)})");
    else System.Console.WriteLine("Intersection point does not exist");
}

double ReadInt(string argument)
{
    double number;
    System.Console.WriteLine($"Enter {argument}: ");
    while(!double.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not that");
    }
    return number;
}

bool Intersection(double k1, double k2)
{
    return k1 - k2 != 0;
}

double[] FinderPoint(double k1, double b1, double k2, double b2)
{
    double[] coordinates = new double[2];
    coordinates[0] = (b2 - b1) / (k1 - k2);
    coordinates[1] = k1 * coordinates[0] + b1;
    return coordinates;
}