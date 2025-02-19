    Console.WriteLine("Введите ваше имя: ");
    string name = Console.ReadLine();
    Console.WriteLine("Введите вашу фамилию: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("Введите число вашего рождения: ");
    int day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
        case < 1:
        case > 31:
            Console.WriteLine($"Вы ввели некорректное значение \ud83d\ude21"); //это в конце смайлик если что
            return;
    }

    Console.WriteLine("Введите месяц вашего рождения (числом): ");
        int month = Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
            case < 1:
            case > 12:
                Console.WriteLine($"Вы ввели некорректное значение \ud83d\ude21");
                return;
        }

        string zodiac = "";
        switch (month)
        {
            case 1:
                if (day <= 19)
                {
                    zodiac = "Козерог";
                }
                else
                {
                    zodiac = "Водолей";
                }

                break;

            case 2:
                if (day <= 18)
                {
                    zodiac = "Водолей";
                }
                else if (day >= 19 && day <= 29)
                {
                    zodiac = "Рыбы";
                }
                else if (day >= 30)
                {

                    zodiac = "Неправильный день в феврале";
                }

                break;

            case 3:
                if (day <= 20)
                {
                    zodiac = "Рыбы";
                }
                else
                {
                    zodiac = "Овен";
                }

                break;

            case 4:
                if (day <= 19)
                {
                    zodiac = "Овен";
                }
                else
                {
                    zodiac = "Телец";
                }

                break;

            case 5:
                if (day <= 20)
                {
                    zodiac = "Телец";
                }
                else
                {
                    zodiac = "Близнецы";
                }

                break;

            case 6:
                if (day <= 20)
                {
                    zodiac = "Близнецы";
                }
                else
                {
                    zodiac = "Рак";
                }

                break;

            case 7:
                if (day <= 22)
                {
                    zodiac = "Рак";
                }
                else
                {
                    zodiac = "Лев";
                }

                break;

            case 8:
                if (day <= 22)
                {
                    zodiac = "Лев";
                }
                else
                {
                    zodiac = "Дева";
                }

                break;

            case 9:
                if (day <= 22)
                {
                    zodiac = "Дева";
                }
                else
                {
                    zodiac = "Весы";
                }

                break;

            case 10:
                if (day <= 22)
                {
                    zodiac = "Весы";
                }
                else
                {
                    zodiac = "Скорпион";
                }

                break;

            case 11:
                if (day <= 21)
                {
                    zodiac = "Скорпион";
                }
                else
                {
                    zodiac = "Стрелец";
                }

                break;

            case 12:
                if (day <= 21)
                {
                    zodiac = "Стрелец";
                }
                else
                {
                    zodiac = "Козерог";
                }

                break;

            default:
                zodiac = "Неизвестный знак зодиака";
                break;
        }

        Console.WriteLine($"Ваше имя: {name}, Ваша фамилия: {lastName}, Ваш знак зодиака: {zodiac}");
    
