/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/

Console.WriteLine("Введите 8 чисел через запятую");
string str = Console.ReadLine() ?? "";
string[] array = str.Split(",");

if (array.Length != 8)
{
    Console.WriteLine("Неверное количество чисел");
}
else
{
int[] newarray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    newarray[i] = int.Parse(array[i]);
}
for (int i = 0; i < newarray.Length; i++)
{
    Console.Write($"{newarray[i]} ");
}
}
