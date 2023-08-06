// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            // Ввод трех чисел с клавиатуры

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());


// Нахождение максимального числа
            int max = a;
            
            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

// Вывод результата

   Console.WriteLine($"Максимальное число: {max}");

