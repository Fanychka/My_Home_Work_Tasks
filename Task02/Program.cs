        // Задача 2: 
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.       
        


        Console.WriteLine("Введите первое число: ");

                                                                                // string first_input = Console.ReadLine();

        int first_number = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");

                                                                                // string second_input = Console.ReadLine();
        
        int second_number = int.Parse(Console.ReadLine());

        int maxNumber = second_number; // "присваиваем" максимальное значение любому вводимому числу (метод сравнения гирек) 
        int minNumber;
        
        if (second_number < first_number) {
                maxNumber = first_number; minNumber = second_number;}
        else { minNumber = first_number;}
    
        Console.WriteLine($"Большее число здесь {maxNumber}, а меньшее {minNumber}");