// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
    return arr;
}

int MinSumRow(int[,] matrix)
{
    int sumTemp = 0, sum = 0, indexRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumTemp = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < 1) sum += matrix[i, j];

            sumTemp += matrix[i, j];
        }

        if (sumTemp < sum)
        {
            sum = sumTemp;
            indexRow = i;
        }
    }
    return indexRow;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов на строке {MinSumRow(matrix) + 1}");