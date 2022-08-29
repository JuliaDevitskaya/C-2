/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

using static System.Console;
Clear();

WriteLine("Введите число от 1 до 7: ");
int number=Convert.ToInt32(ReadLine());
if(number==1)
{
    WriteLine("Понедельник");
}
if(number==2)
{
WriteLine("Вторник");
}
if(number==3)
{
    WriteLine("Среда");
}
if(number==4)
{
    WriteLine("Четверг");
}
if(number==5)
{
    WriteLine("Пятница");
}
if(number==6)
{
    WriteLine("Суббота");
}
if(number==7)
{
    WriteLine("Воскресенье");
}
 
if(number>0 && number<6)
{
    WriteLine("Будний день");
}
if(number>5 && number<8)
{
    WriteLine("Выходной");
}