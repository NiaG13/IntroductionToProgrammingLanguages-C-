// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
    int num = ReadInt("an integer number");
    System.Console.WriteLine(Sum(num));
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not an integer number");
    }
    if(number < 0)
    {
        number *=-1;
    }
    return number;
}

int Sum(int number)
{
    int sum = 0;
    while( number % 10 != 0)
    {
        int temp = number % 10;
        sum += temp;
        number = number / 10;
    }
    return sum;
}
//                  !!! НЕ МОГУ ПОНЯТЬ ПОЧЕМУ НЕ РАБОТАЕТ !!!
//                   сперва пытался использовать эту функцию
// int Sum(int number)
// {
//     string num = number.ToString();
//     int j = 0;
//     int[] array = new int [num.Length];
//     for(int i = 0; i < num.Length; i++)
//     {
//         array[i] = num[j];
//         System.Console.Write( array[i] + " ");
//         j++;
//     }
//     int sum = 0;
//     int index = 0;
//     for(int n = 0; n <= array.Length; n++)
//     {
//         sum += array[index];
//         index++;
//     }
//     return sum;
// }