// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите количество строк для первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов для первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows1, columns1, 0, 10);
Console.Write("Введите количество строк для второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов для второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array1);
Console.WriteLine(" ");
PrintArray(array2);
Console.WriteLine(" ");
int[,] result = Multiplication(array1, array2);
PrintArray(result);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] array1,int[,] array2)
{
    int[,] result=new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum=0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum+=array1[i,k]*array2[k,j];
            }
            result[i,j]=sum;
        }
    }
    return result;
}