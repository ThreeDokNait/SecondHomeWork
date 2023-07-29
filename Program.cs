Console.Clear();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int num1 = num / 10;
// int LostNum = num1 % 10;
// Console.WriteLine(LostNum);



// Задача 13.1: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Get number, please");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 - 100 > 0)
// {
//     Console.WriteLine("Третье число равно:");
//     Console.WriteLine(num1 % 10);
// }
// else
// {
//     Console.WriteLine("Нет третьего числа");
// }



// Задача 13.2: Напишите программу, которая выводит третью цифру заданного числа сосстоящее из 3-х цифр или сообщает, что третьей цифры нет/введено более 3-х цифр.

// Console.WriteLine("Get number, please");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if ((num1 - 100 > 0)&&(num1 / 3 <= 333))
// {
//     Console.WriteLine("Третье число равно:");
//     Console.WriteLine(num1 % 10);
// }
// else
// {
//     Console.WriteLine("Нет третьего числа/введено более трех цифр");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("введите цифру");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number == 7) || (number == 6))
// {
//     Console.WriteLine("Выходной день:");
// }
// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
