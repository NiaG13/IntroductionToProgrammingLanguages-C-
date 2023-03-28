// программа принимает три числа и выдаёт максимальное из них

double a = 0;
double b = 0;
double c = 0;
double max = a;

Console.WriteLine("Enter three humbers:");

if(double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
{
    if( b > max )
    {
        max = b;
        if( max > c )
        {
            Console.WriteLine("max= " + max);
        }
        else
        {
            max = c;
            Console.WriteLine("max= " + max);
        }
    }
    else if( c > max )
    {
        max = c;
        Console.WriteLine("max= " + max);
    }
    else
    {
        Console.WriteLine("max= " + max);
    }
}
else
{
    Console.WriteLine("Not a number");
}
