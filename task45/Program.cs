// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
// void RandArray (int[] array)
// {
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++) 
//             copy[i] = arr[i];
//             {
// array [i] = rand.Next(1,11);
// }
// }
// void PrintArr (int [] array)
// console.Write('[')
using System;
 
public class Example
{
    public static void Main()
    {
        int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            copy[i] = arr[i];
        }
 
        Console.WriteLine(String.Join(", ", copy));       
    }
}