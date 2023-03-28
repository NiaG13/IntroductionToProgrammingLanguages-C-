//программа принимает на вход число и выдаёт, является ли оно чётным

int a = 0;

Console.Write("Enter an integer: ");

if(int.TryParse(Console.ReadLine(), out a) && a != 0)
{
    if( a % 2 == 0 )
    {
        Console.WriteLine("This number is even");
    }
    else
    {
        Console.WriteLine("This number isn't even");
    }
}
else
{
    Console.WriteLine("Not a number");
}
