 Console.WriteLine("Введите число: ");
 
        string input_number = Console.ReadLine();
        int Number = int.Parse(input_number);

        
        
        
        if (Number % 2 == 0) 
            Console.WriteLine($"Введенное число {Number} является четным ");

        if (Number % 2 != 0)
            Console.WriteLine($"Введенное число {Number} не является четным");