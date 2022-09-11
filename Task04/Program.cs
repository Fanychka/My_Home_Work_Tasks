        // Задача 4: 
        // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        

        Console.WriteLine("Введите первое число: ");

        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число: ");

        int thirdNumber = int.Parse(Console.ReadLine());

        int maxNumber = firstNumber;
        
        
        if (secondNumber > firstNumber) maxNumber = secondNumber; 
        if (thirdNumber > maxNumber) maxNumber = thirdNumber;
    
        Console.WriteLine($"Максимальным из этих трех чисел является число {maxNumber}");
