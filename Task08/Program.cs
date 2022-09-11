// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");

//string inputNumber = Console.ReadLine(); 


int Number = int.Parse(Console.ReadLine()); // Парсить можно одновременно с чтением входных данных: //int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= Number; i++)
if (i % 2 == 0)

Console.WriteLine($"{i} - четное число входящее в число {Number}");

