/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
int Getnumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ??"");
    return result;
}

int GetStepen(int A, int B)
{
    int result = 1;
    for (int count = 1; count <= B; count++)
    {
        result = result * A;
    }
    return result;
}


int A = Getnumber("Введите число A");
int B = Getnumber("Введите число B");
int result = GetStepen(A, B);
Console.WriteLine($"{A}, {B} -> {result}");
