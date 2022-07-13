// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int m = 6;
Console.WriteLine($"Введите {m} чисел: ");

    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}
    int Pos(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) count++;
        }
        return count;
    }
// PrintArray(numbers);
Console.WriteLine();
int pos = Pos(numbers);
Console.WriteLine($"{pos} больше 0");