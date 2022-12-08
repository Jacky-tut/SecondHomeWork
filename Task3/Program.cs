/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int numberDay = int.Parse(Console.ReadLine()??"");
if(numberDay == 6 || numberDay == 7)
Console.WriteLine("Этот день выходной");
else if(numberDay >= 1 && numberDay <= 5)
Console.WriteLine("Этот день не выходной");
else
Console.WriteLine("Это вообще не день недели");

