// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int SumNumber (int num)
{
  int res = 0;
  while (num > 0)
  {
    res = res + num % 10;
    num = num / 10;
  }
  return res;
}
int number = Promt ("Введите число ");
// int sumNumber = SumNumber (number);
Console.WriteLine($"Сумма цифр числа {number} равна -- {SumNumber (number)}");