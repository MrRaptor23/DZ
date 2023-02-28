// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size, int min, int max) 
{     
    double[] arr = new double[size];     
    Random rnd = new Random();     
    for (int i = 0; i < arr.Length; i++)     
    {         
        arr[i] = rnd.NextDouble() * (max - min) + min;  
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }     
    return arr; 
    }  

void PrintArrayDouble (double[] arr) 
    {     
        Console.Write("[");     
        for (int i = 0; i < arr.Length; i++)     
        {         
            if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");         
            else Console.Write($"{arr[i]}");     
            }     
        Console.Write("]"); 
    }

double FindMaxElement (double [] arr)
    {
        double max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]> max) max = arr[i];
        }
        return max;
   }

double FindMinElement (double [] arr)
    {
        double min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
        }
        return min;
    }

double FindDifference (double max, double min)
    {
        double difference = Math.Round((max - min), 1, MidpointRounding.ToZero);;
        return difference;
    }

double[] array = CreateArrayRndDouble(10,1,99);
PrintArrayDouble(array);
Console.WriteLine();
double numMax = FindMaxElement (array);
double numMin = FindMinElement (array);
double result = FindDifference();
Console.Write($"Разница между максимальным элементом массива {numMax} и минимальным {numMin} равна {result} .");

