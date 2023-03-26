// программа принимает на вход число (N), а на выходе показывает все чётные числа от 1 до N

int N = 0;

Console.Write("Enter a number more than one: ");

if(int.TryParse(Console.ReadLine(), out N) && N != 0)
{
    if( N > 0 )
    {
        for(int i = 1; i < N; i ++)
        {
            if( i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
    else
    {
        for(int i = -1; i > N; i --)
        {
            if( i % 2 == 0 )
            {
                Console.Write(i + " ");
            }
        }
    }
}
else
{
    Console.WriteLine("Not a number");
}
