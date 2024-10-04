// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6

int[,] GetMatrixdigits(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix )
{
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i,j], 4} ");
        }
        Console.WriteLine("| ");
    }
}
void FliipMatrix(int[,] matrix)
{
    
     for(int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write("| ");
        for(int j = 0; j < matrix.GetLength(0) ; j++)
        {
          Console.Write($"{matrix[j,i], 4} ");
        }
        Console.WriteLine("| ");
    }
}
int [,] array2d = GetMatrixdigits(3, 4, 1, 1000);
PrintMatrix(array2d);

Console.WriteLine();

FliipMatrix(array2d);
PrintMatrix(array2d);