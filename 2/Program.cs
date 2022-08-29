/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


//Так и не додумалась как найти общее решение, с помощью циклов, для всех чисел. Только линейно(
//Объясните, пожалуйста, как правильно сделать.

using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
if (number <= 99)
{
    WriteLine("третьей цифры нет");
}
if (number > 99 & number < 1000)
{
    int result = number % 10;
    WriteLine(result);
}
if (number > 999 & number < 10000)
{
    int result = number / 10 % 10;
    WriteLine(result);

}
if (number > 9999 & number < 100000)
{
    int result = number / 10 / 10 % 10;
    WriteLine(result);

}

