// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns]; // 0 , 1
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++) // rows
  {
    for (int j = 0; j < matrix.GetLength(1); j++) // columns
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}


void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
      else Console.Write($"{matrix[i, j],3}");
    }
    Console.WriteLine("|");
  }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
Console.WriteLine();

Console.WriteLine($"Среднее арифметическое каждого столбца: ");
for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum += array2d[i, j];
    }
    Console.Write($"{ Math.Round(sum / array2d.GetLength(0),1)};  ");
}

