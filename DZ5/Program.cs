// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] ArraySpiralFilling(int[,] arr)
{
    int count = 0,
        row = arr.GetLength(0),
        column = arr.GetLength(1);

    for (int g = 0; count < arr.Length; g++)
    {
        for (int i = g; count < arr.Length && i < column - g; i++)
        {
            count++;
            arr[g, i] = count;
        }
        for (int j = 1 + g; count < arr.Length && j < row - g; j++)
        {
            count++;
            arr[j, column - 1 - g] = count;
        }
        for (int i = column - 2 - g; count < arr.Length && i >= g; i--)
        {
            count++;
            arr[row - 1 - g, i] = count;
        }
        for (int j = row - 2 - g; count < arr.Length && j > g; j--)
        {
            count++;
            arr[j, g] = count;
        }
    }
    
    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0: 00}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int Entry(string txt)
{
    Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int row = Entry("Введите кол-во строк: ");
int column = Entry("Введите кол-во столбцов: ");
int[,] array = new int[row, column];
array = ArraySpiralFilling(array);
PrintMatrix(array);