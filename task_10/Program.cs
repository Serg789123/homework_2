//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number / 10;
int result = num % 10;
Console.WriteLine($"Вторая цифра числа равна {result}");