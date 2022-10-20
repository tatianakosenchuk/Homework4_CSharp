/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int Getnumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int GetSumOfDigits(int number)
{
    int summ = 0;
    for (int i = number; i > 0; i = i / 10)
    {
        summ = summ + i % 10;
    }
    {
        return summ;
    }
}

int number = Getnumber("Введите число");
int result = GetSumOfDigits(number);
Console.WriteLine($"{number} -> {result}");