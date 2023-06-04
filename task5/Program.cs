//Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine(" ");

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    int k=1;
        for (int j = 0; j < n; j++)
        {
            result[0, j] = k;
            k++;
        }
        for (int j = 1; j < m; j++)
        {
            result[j, 3] = k;
            k++;
        }
        for (int j = n-2; j >= 0; j--)
        {
            result[3, j] = k;
            k++;
        }
        for (int j = m-2; j > 0; j--)
        {
            result[j, 0] = k;
            k++;
        }
        for (int j = 1; j < n-1; j++)
        {
            result[1, j] = k;
            k++;
        }
        for (int j = n-2; j > 0; j--)
        {
            result[2, j] = k;
            k++;
        }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i,j]<10)
                Console.Write($"0{inArray[i, j]} ");
            else
                Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
