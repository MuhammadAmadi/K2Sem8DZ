// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] ArrayWithRandom(int[,,] arr, int min, int max)
{
    int temp;
    bool check = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Random rnd = new Random();
                temp = rnd.Next(min, max);
                check = Check(arr, temp);
                if (check)
                {
                    arr[i, j, k] = temp;
                }
                else
                {
                    k--;
                }
            }
        }

    }
    return arr;
}

bool Check(int[,,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i,j,k] == value)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int Entry(string txt)
{
    Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int leaf = Entry("Введите длину третьего измерения: ");
int row = Entry("Введите длину второго измерения: ");
int column = Entry("Введите длину первого измерения: ");
int min = Entry("Введите минимальное значение: ");
int max = Entry("Введите максимальное значение: ");
int[,,] array = new int[leaf, row, column];
array = ArrayWithRandom(array, min, max);
PrintMatrix(array);
Console.WriteLine();