    Console.Write("Введите ваше имя: ");
    string name = Console.ReadLine();

    Console.Write("Введите вашу фамилию: ");
    string lastName = Console.ReadLine();

    Console.Write("Введите число вашего рождения: ");
    int day = int.Parse(Console.ReadLine());
    
    // на дурачка проверка
    if (day > 31)
    {
        Console.WriteLine("Вы ввели некорректное значение, в месяце максмимально 31 день");
        return;
    }
    
    else if (day < 1)
    {
        Console.WriteLine("Вы ввели некорректное значение, в месяце минимально один день");
        return;
    }

    Console.Write("Введите месяц вашего рождения(числом): ");
    int month = int.Parse(Console.ReadLine());
    
    // на дурачка проверка
    if (month > 12)
    {
        Console.WriteLine("Вы ввели некорректное значение, в году максимум 12 месяцев");
        return;
    }
    
    else if (month < 1)
    {
        Console.WriteLine("Вы ввели некорректное значение, в году минимум 1 месяц");
        return;
    }

    
    string zodiac = "";

    if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
    {
        zodiac = "Овен";
    }

    else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
    {
        zodiac = "Телец";
    }

    else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
    {
        zodiac = "Близнецы";
    }

    else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
    {
        zodiac = "Рак";
    }

    else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
    {
        zodiac = "Лев";
    }

    else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
    {
        zodiac = "Дева";
    }

    else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
    {
        zodiac = "Весы";
    }

    else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
    {
        zodiac = "Скорпион";
    }

    else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
    {
        zodiac = "Стрелец";
    }

    else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
    {
        zodiac = "Козерог";
    }

    else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
    {
        zodiac = "Водолей";
    }

    else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
    {
        zodiac = "Рыбы";
    }

    Console.WriteLine($"Ваше имя: {name}, Ваша фамилия: {lastName}, Ваш знак зодиака: {zodiac}");
