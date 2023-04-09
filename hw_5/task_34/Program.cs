// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    System.Console.WriteLine("Have a good day!");
}

void Task()
{
    int[] arr = FillArray(ReadInt("an array length"));
    PrintArray(arr);
    System.Console.WriteLine(CountEven(arr));
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number <= 0)
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}

int[] FillArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
    System.Console.WriteLine($"{array[array.Length-1]} ]");
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
