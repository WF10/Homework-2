// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numberN > 99)
{
    Console.WriteLine((numberN / 100) % 10);
}
if (numberN < 100)
{
    Console.WriteLine("в числе " + numberN + " третьей цифры нет");
}
// Находит третью цифру с конца, как математически найти третью цифру с начала - не додумалась.
*/

// Решение через массив
/*
Console.WriteLine("Введите массив из 5 чисел:");
string numbers = Console.ReadLine();

Console.WriteLine("У числа " + numbers + " третья цифра " + numbers[2]);
 if (numbers.Length < 3)
 {
    Console.WriteLine("У числа " + numbers + " нет третьей цифры");
 }
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
Console.WriteLine("Введите число:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6)
{
    Console.WriteLine("Выходной день");
    Console.WriteLine("Суббота");
}
if (dayNumber == 7)
{
    Console.WriteLine("Выходной день");
    Console.WriteLine("Воскресенье");
}
if (dayNumber == 5)
{
    Console.WriteLine("Будний день");
    Console.WriteLine("Пятница");
}
if (dayNumber == 4)
{
    Console.WriteLine("Будний день");
    Console.WriteLine("Четвег");
}
if (dayNumber == 3)
{
    Console.WriteLine("Будний день");
    Console.WriteLine("Среда");
}
if (dayNumber == 2)
{
    Console.WriteLine("Будний день");
    Console.WriteLine("Вторник");
}
if (dayNumber == 1)
{
    Console.WriteLine("Будний день");
    Console.WriteLine("Понедельник");
}
if (dayNumber > 7 || dayNumber < 1)
{
    Console.WriteLine("Такого дня недели пока не придумали");
}
*/