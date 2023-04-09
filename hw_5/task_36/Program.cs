// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    int[] arr = FillArray(ReadInt("an array length"));
    PrintArray(arr);
    System.Console.WriteLine($"The sum of elements of odd array positions is {SumOddPositions(arr)}.");
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number > 0)
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("Array: [ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine(array[array.Length-1] + " ]");
}

int SumOddPositions (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}