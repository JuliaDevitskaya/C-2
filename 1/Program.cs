/*Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

using static System.Console;
Clear();

WriteLine("Введите трехзначное число: ");
int number1 = Convert.ToInt32(ReadLine());
if (number1 > 99 && number1 < 1000)
{
    int number2 = number1 / 10 % 10;
    WriteLine(number2);
}
else
{
    WriteLine();
}
