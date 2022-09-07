        Console.WriteLine("Введите первое число: ");

        string first_input = Console.ReadLine();

        int first_number = int.Parse(first_input);

        Console.WriteLine("Введите второе число: ");

        string second_input = Console.ReadLine();
        
        int second_number = int.Parse(second_input);

        Console.WriteLine("Введите третье число: ");

        string third_input = Console.ReadLine();
        
        int third_number = int.Parse(third_input);

        int maxNumber = second_number;
        
        
        if (second_number < first_number) maxNumber = first_number; 
        if (third_number > first_number) maxNumber = third_number;
    
        Console.WriteLine($"Максимум из этих трех чисел равен {maxNumber}");
