// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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
    double x1 = ReadDoub("x1");
    double y1 = ReadDoub("y1");
    double z1 = ReadDoub("z1");
    double x2 = ReadDoub("x2");
    double y2 = ReadDoub("y2");
    double z2 = ReadDoub("z2");
    System.Console.WriteLine($"The segment length is {Length(x1, y1, z1, x2, y2, z2)}");
}

// просто интересно было поработать с большим (относительно) количеством аргументов
double Length(double a1, double b1, double c1, double a2, double b2, double c2)
{
    double length = Math.Round(Math.Sqrt(Math.Pow( a1 - a2, 2) + Math.Pow( b1 - b2, 2) + Math.Pow ( c1 - c2, 2)), 2);
    return length;
}

double ReadDoub (string argument)
{
    double number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!double.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not a number!");
    }
    return number;
}