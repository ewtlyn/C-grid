//комментарии оставляю для себя, потому что путаюсь 
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите систему счисления (от 2 до 9): ");
    int q1 = Convert.ToInt32(Console.ReadLine());

    while (q1 < 2 || q1 > 9)
    {
        Console.WriteLine("Написано же, система счисления должна быть от 2 до 9. Введите еще раз корректную систему: ");
        q1 = Convert.ToInt32(Console.ReadLine());
    }
    
    int DNumber = 0; //переменная для хранения результата перевода в десятичную систему
    int i = 0;
    
    while (number > 0)
    {
        int cifra = number % 10; // берем остаток от деления number на 10, позволяет получить последнюю цифру числа

        if (cifra >= q1)
        {
            Console.WriteLine($"Цифра {cifra} не входит в систему счисления {q1}.");
            return;
        }
        
        DNumber += cifra * (int)Math.Pow(q1, i); //возводит q1 в степень i, умножает q1 в степени i чтобы перевести в десятичную.
        i++; //увеличивает счетчик i на 1
        
        number /= 10; // целочисленное деление number на 10, из за которого убирается последняя цифра
    }
    
    Console.WriteLine($"Число в десятичной системе: {DNumber}");
    
    
