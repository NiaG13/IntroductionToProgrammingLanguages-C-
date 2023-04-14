// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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
    int M = ReadInt("How much numbers do you want to input?");
    int[] arr = FillArray(M);
    int countNegative = CountNegative(arr);
    switch (countNegative)
    {
        case >1: System.Console.WriteLine($"{countNegative} numbers are negative"); break;
        case 1: System.Console.WriteLine($"{countNegative} number is negative"); break;
        default: System.Console.WriteLine("No negative numbers "); break;
    }
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine(argument);
    while(!int.TryParse(Console.ReadLine(), out number) || number < 1)
    {
        System.Console.WriteLine("It's nit that");
    }
    return number;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
        {
            System.Console.WriteLine($"Enter {length - i} positive and negative integers:");
        }
        else
        {
            System.Console.WriteLine($"Enter last positive and negative integer:");
        }
        int number = int.Parse(Console.ReadLine());
        array[i] = number;
    }
    System.Console.Write("Entered numbers: ");
    System.Console.WriteLine(string.Join("; ", array));
    return array;
}

int CountNegative(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            count ++;
        }
    }
    return count;
}