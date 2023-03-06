// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("выведите число: ");
// int num= Convert.ToInt32(Console.ReadLine());
// int[ ] Fibonacci (int numFib);

// (Random rand = new Random();
// int[]array = rand.Next(0,10));

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    if (num == 1)
    {
        return array;
    }
    array[1] = 1;


    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;

}

Console.WriteLine("Введите количество первых чисел Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Некорректное число.");
}
else
    Console.WriteLine("Первые " + (number) + " чисел Фибоначчи: " + "[" + String.Join(", ", Fibonacci(number)) + "]");
