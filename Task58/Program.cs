// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatriksRndInt(int rows, int columns, int min, int max)
{
  int[,] matriks = new int[rows, columns]; 
  Random rnd = new Random();

  for (int i = 0; i < matriks.GetLength(0); i++)
  {
    for (int j = 0; j < matriks.GetLength(1); j++) 
    {
      matriks[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matriks;
}


int[,] MultiplyMatriks(int[,] firstMatriks, int[,] secondMatriks) 
{
  int[,] multiplyMatriks = new int [firstMatriks.GetLength(0), secondMatriks.GetLength(1)];
  for (int i = 0; i < multiplyMatriks.GetLength(0); i++)
  {
    for (int j = 0; j <  multiplyMatriks.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k <  firstMatriks.GetLength(1); k++)
      {
        sum += firstMatriks[i,k] * secondMatriks[k,j];
      }
      multiplyMatriks[i,j] = sum;
    }
  }
  return multiplyMatriks;
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

int[,] firstArray2d = CreateMatriksRndInt(3, 3, 1, 5);
PrintMatriks(firstArray2d);
Console.WriteLine();
int[,] secondArray2d = CreateMatriksRndInt(3, 3, 1, 5);
PrintMatriks(secondArray2d);
Console.WriteLine();
int[,] multiplyArray2d = MultiplyMatriks(firstArray2d, secondArray2d);
PrintMatriks(multiplyArray2d);