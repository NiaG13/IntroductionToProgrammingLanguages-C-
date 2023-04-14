// вычислить интеграл для функций f1(x)=-x^2+4 и f2(x)=-9x^2+8
// (-3 в скобах с икс возвёл сразу в квадрат для понятного содержания функции)

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
            case "y": Tusk(); break;
            case "n": work = false; break;
            default: break;
        }
    }
    System.Console.WriteLine("Have a good time!");
}

double[] FindPoint(double k1, double b1, double k2, double b2)
{
    double[] coordinates = new double[4];
    coordinates[0] = -1 * Math.Sqrt((b2 - b1) / (k1 - k2));     // x1
    coordinates[1] = -1 * Math.Pow(coordinates[0], 2) + 4;      // y1
    coordinates[2] = -coordinates[0];                           // x2
    coordinates[3] = -1 * Math.Pow(coordinates[2], 2) + 4;      // y2
    return coordinates;
}

void Tusk()
{
    double k1 = -1;
    double b1 = 4;
    double k2 = -9;
    double b2 = 8;
    double[] points = FindPoint( k1, b1, k2, b2 );
    System.Console.WriteLine($"Points intersection ( {Math.Round(points[0], 3)}; {Math.Round(points[1], 3)} ) and ( {Math.Round(points[2], 3)}; {Math.Round(points[3], 3)}).");
    double square = IntegralCalculation( points, k1, b1, k2, b2 );
    System.Console.WriteLine($"The figure square {Math.Round(square, 3)}");
}

double IntegralCalculation(double[] coordinates, double k1, double b1, double k2, double b2)
{
    double result = 0;
    double offset = 0.000001;
    for (double i = coordinates[0]; i < coordinates[2]; i += offset )
    {
        double sqareRectangle = ((k1 * Math.Pow(i + offset, 2) + b1) - (k2 * Math.Pow(i + offset, 2) + b2)) * offset;
        if (sqareRectangle < 0) sqareRectangle *= -1;
        result += sqareRectangle;
    }
    return result;
}


