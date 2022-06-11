/* Напишите программу, которая принимает на вход 
два числа и проверяет, является ли одно число 
квадратом другого: 5, 25 -> да; -4, 16 -> да; 
25, 5 -> да; 8,9 -> нет  */

Console.Clear();
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int numSquared1 = num1 * num1;
int numSquared2 = num2 * num2;

if (num1 == numSquared2 || num2 == numSquared1)
{
    Console.Write("ДА");
}
else
{
    Console.Write("НЕТ");
}