 // Задача 6: 
 // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
 

 Console.WriteLine("Введите число: ");

        string input_number = Console.ReadLine();
        int Number = int.Parse(input_number);

        
        
        
        if (Number % 2 == 0) {
                Console.WriteLine($"Введенное число {Number} является четным");
                }
        else {
            Console.WriteLine($"Введенное число {Number} не является четным");
            }