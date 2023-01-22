//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите порядковый номер дня недели, от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 7 | number == 6)
{
    Console.WriteLine("День является выходным");
}
else if (number == 1 | number == 2 | number == 3 | number == 4 | number == 5)
{
    Console.WriteLine("день рабочий");
}
else
{
    Console.WriteLine("прядковый номер некорректный");
}
