// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MatrixMultiplication(int[,] mtrxA, int[,] mtrxB)
{
    if (mtrxA.GetLength(1) == mtrxB.GetLength(0))
    {
        int[,] mtrxC = new int[mtrxA.GetLength(0), mtrxB.GetLength(1)];
        for (int i = 0; i < mtrxC.GetLength(0); i++)
        {
            for (int j = 0; j < mtrxC.GetLength(1); j++)
            {
                for (int k = 0; k < mtrxA.GetLength(1); k++)
                {
                    mtrxC[i, j] += mtrxA[i, k] * mtrxB[k, j];
                }
            }
        }

        Console.WriteLine("Произведение двух матриц");
        PrintMatrix(mtrxC);
    }
    else
    {
        Console.WriteLine("Нельзя перемножать");
    }
}

int[,] ArrayWithRandom(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 10);
        }

    }
    return mtrx;
}

int[,] ArrayFillManually(int[,] mtrx)
{

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = Entry($"Задайте значение матрицы строки {i + 1} столбца {j + 1}: ");
        }

    }
    return mtrx;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Entry(string txt)
{
    Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int value = Entry("Введите\n1 чтобы заполнить матрицу вручную\n2 чтобы заполнить матрицу рандомно\n");

int row = Entry("Введите число строк первой матрицы: ");
int column = Entry("Введите число столбцов первой матрицы: ");
int[,] matrixA = new int[row, column];
row = Entry("Введите число строк второй матрицы: ");
column = Entry("Введите число столбцов второй матрицы: ");
int[,] matrixB = new int[row, column];

if (value > 1)
{
    matrixA = ArrayWithRandom(matrixA);
    matrixB = ArrayWithRandom(matrixB);
}
else
{
    Console.WriteLine("Заполните первую матрицу");
    matrixA = ArrayFillManually(matrixA);
    Console.WriteLine("Заполните вторую матрицу");
    matrixB = ArrayFillManually(matrixB);
}

Console.WriteLine("Матрица 1");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintMatrix(matrixB);
Console.WriteLine();
MatrixMultiplication(matrixA, matrixB);