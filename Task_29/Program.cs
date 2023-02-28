// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int[] CreateArrayInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

int length = Promt("Введите длинну массива: ");
int min = Promt("Введите начальное значение массива: ");
int max = Promt("Введите конечное значение массива: ");
int[] array = CreateArrayInt(length, min, max);
PrintArray(array);