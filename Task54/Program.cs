//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatriksRndInt(int rows, int columns, int min, int max)
{
  int[,] matriks = new int[rows, columns]; // 0 , 1
  Random rnd = new Random();

  for (int i = 0; i < matriks.GetLength(0); i++) // rows
  {
    for (int j = 0; j < matriks.GetLength(1); j++) // columns
    {
      matriks[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matriks;
}
void SortMatriks(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int n = 0; n < array.GetLength(1) - 1; n++)
      {
        if (array[i, n] < array[i, n + 1])
        {
          int temp = array[i, n + 1];
          array[i, n + 1] = array[i, n];
          array[i, n] = temp;
        }
      }
    }
  }
}
void PrintMatriks(int[,] matriks)
{
  for (int i = 0; i < matriks.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matriks.GetLength(1); j++)
    {
      if (j < matriks.GetLength(1) - 1) Console.Write($"{matriks[i, j],3}, ");
      else Console.Write($"{matriks[i, j],3}");
    }
    Console.WriteLine("|");
  }
}
int[,] array2d = CreateMatriksRndInt(3, 4, 1, 5);
PrintMatriks(array2d);
Console.WriteLine();
SortMatriks(array2d);
PrintMatriks(array2d);