// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? string.Empty);

int row = new Random().Next(1,6) + columns;

int[,] array = GetArray(row, columns, 0, 9);
PrintArray(array);

Console.WriteLine();
SmallestRow(array, columns);

int[,] GetArray(int m, int n, int minVaiue, int maxVaiue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minVaiue, maxVaiue +1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SmallestRow(int[,] arr, int col)
{
    int sum1 = col *10; 
    int count = 0; 
    int fin = 1;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int sum2 = 0; 
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum2 = arr[i,j] + sum2;
            
        }

        if(sum1 > sum2)
        {
            sum1 = sum2;
            count++;
            fin = i+1;
        }
        sum2 = 0;
    
    }
    Console.WriteLine($"Программа считает, что строка с наименьшнй суммой: {fin} строка.");
}
