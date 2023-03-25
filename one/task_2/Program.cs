// программа принимает два числа и выводит, какое большее, а какое меньшее.

double a = 0;
double b = 0;

Console.WriteLine("Enter numbers 'a' & 'b': ");

if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b))
{
    if (a == b)
    {
    Console.WriteLine("These numbers are equal");
    }
    else if ( a < b )
    {
    Console.WriteLine("Min = " + a);
    Console.WriteLine("Max = " + b);
    }
    else
    {
    Console.WriteLine("Min = " + b);
    Console.WriteLine("Max = " + a);
    }
}
else
{
    Console.WriteLine("Not a number");
}
