// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lengthArray = 8, a = -100, b = 101;

Main ();

void Main ()
{
    bool work = true;
    while (work)
    {
        System.Console.WriteLine("Hello! Run the program? y/n");
        string w = Console.ReadLine();
        switch (w)
        {
            case "y": ArrayFill(lengthArray, a, b); break;
            case "n": work = false; break;
            default: break;
        }
    }
    System.Console.WriteLine("Have a good time!");
}

void ArrayFill(int length, int a, int b)
{
    int[] array = new int[length];
    System.Console.Write("Array [  ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
        System.Console.Write(array[i] + "  ");
    }
    System.Console.WriteLine("]");
}