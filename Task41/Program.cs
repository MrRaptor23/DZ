// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string ConverDecimalToBinary(int num)
{
    string number = "";
    
    while (num > 0)
    {
        if (num % 2 == 0)
        {
            number = number + "0";
            num = num / 2;            
        } else {
            number = number + "1";
            num = num / 2;            
        }

    }
    return number;
}

Console.Write(ConverDecimalToBinary(decimalNumber));

