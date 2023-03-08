// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] ArrayWithRandom(int[,] arr)
{
    //int temp;
    //bool check = false;

    int count = 0,
        l1 = arr.GetLength(0),
        l2 = arr.GetLength(1);
    for (int g = 0; g < arr.Length; g++)
    {
        for (int i = 0 + g; i < l2 - g; i++)
        {
            count++;
            arr[g, i] = count;
        }
        for (int j = 1 + g; j < l1 - g; j++)
        {
            count++;
            arr[j, l2 - 1 - g] = count;
        }
        for (int i = l2 - 2 - g; i >= g; i--)
        {
            count++;
            arr[l1 - 1 - g, i] = count;
        }
        for (int j = l1 - 2 - g; j > g; j--)
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
array = ArrayWithRandom(array);
PrintMatrix(array);
Console.WriteLine();
Console.ReadLine();