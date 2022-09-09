Console.WriteLine("Введите число: ");

string input_number = Console.ReadLine();
int Number = int.Parse(input_number);

for (int i = 1; i < Number; i++)
if (i % 2 == 0)

Console.WriteLine($"{i} - четное число входящее в число {Number}");

