/*  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random rnd = new Random();
int number = rnd.Next(100, 1000);

Console.WriteLine($"Число равно {number}");

int firstDigit = number / 10;
int secondDigit = firstDigit % 10;

Console.WriteLine($"Вторая цифра равна {secondDigit}");


