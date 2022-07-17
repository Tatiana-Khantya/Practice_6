//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет 

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} ]");
        }
        Console.WriteLine();
    }
}

void FindElem(int[,] arr, int a, int b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                Console.WriteLine($"Значение элемента: {arr[i, j]}");
                return;
            }
        }

    }
    Console.WriteLine("Такого элемента в массиве нет");
}
int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(arrayResult);
Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
Console.Write("Номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
FindElem(arrayResult, x, y);