Random rnd = new Random();
int value = rnd.Next(1, 100);
int attempts = 5;
Console.WriteLine("Играем в игру, я загадала число от 1 до 100, попробуй его угадать, но у вас есть только 5 попыток");
Console.Write("Введите свое число: ");
int user = Convert.ToInt32(Console.ReadLine());
if (user < 1 || user > 100)
{
    Console.WriteLine("Вы не соблюли условия игры, я просила от 1 до 100. Попробуйте еще раз.");
    user = Convert.ToInt32(Console.ReadLine());
}

if (user == value)
{
    Console.WriteLine("Поздравляю, вы угадали \ud83e\udd73\ud83e\udd73\ud83e\udd73. Игра окончена.");
    return;
}
else 
{
    attempts--;
    Console.WriteLine($"Ну и ну, вы не угадали, но у вас осталось еще {attempts} попытки.");
}

if (attempts > 0)
{
    Console.WriteLine("Попытка намбер ту, введите свое число: ");
    user = Convert.ToInt32(Console.ReadLine());
    if (user < 1 || user > 100)
    {
        Console.WriteLine("Вы не соблюли условия игры, я просила от 1 до 100. Попробуйте еще раз.");
        user = Convert.ToInt32(Console.ReadLine());
    }
    
    if (user == value)
    {
        Console.WriteLine("Поздравляю, вы угадали \ud83e\udd73\ud83e\udd73\ud83e\udd73. Игра окончена.");
        return;
    }
    else
    {
        attempts--;
        Console.WriteLine($"Как же так, вы опять не угадали, у вас осталось {attempts} попыток");
    }
}

if (attempts > 0)
{
    Console.WriteLine("Попытка намбер фор, введите свое число: ");
    user = Convert.ToInt32(Console.ReadLine());
    if (user < 1 || user > 100)
    {
        Console.WriteLine("Вы не соблюли условия игры, я просила от 1 до 100. Попробуйте еще раз.");
        user = Convert.ToInt32(Console.ReadLine());
    }
    
    if (user == value)
    {
        Console.WriteLine("Поздравляю, вы угадали \ud83e\udd73\ud83e\udd73\ud83e\udd73. Игра окончена.");
        return;
    }
    else
    {
        attempts--;
        Console.WriteLine($"Очень жаль, но вы опять не угадали, осталось {attempts} попыток");
    }
}
   if (attempts > 0)
   {
       Console.WriteLine("Попытка намбер фри, введите свое число: ");
       user = Convert.ToInt32(Console.ReadLine());
       if (user < 1 || user > 100)
       {
           Console.WriteLine("Вы не соблюли условия игры, я просила от 1 до 100. Попробуйте еще раз.");
           user = Convert.ToInt32(Console.ReadLine());
       }
       if (user == value)
       {
           Console.WriteLine("Поздравляю, вы угадали \ud83e\udd73\ud83e\udd73\ud83e\udd73. Игра окончена.");
           return;
       }
       else
       {
           attempts--;
           Console.WriteLine($"Что за дела, вы опять не угадали, у вас осталось {attempts} попыток");
       }
   }
if (attempts > 0)
{
    Console.WriteLine("Будьте внимательны, последняя попытка!! Введите свое число:  ");
    user = Convert.ToInt32(Console.ReadLine());
    if (user < 1 || user > 100)
    {
        Console.WriteLine("Вы не соблюли условия игры, я просила от 1 до 100. Попробуйте еще раз.");
        user = Convert.ToInt32(Console.ReadLine());
    }
    if (user == value)
    {
        Console.WriteLine("Ураааа, вы наконец-то смогли угадать число, теперь смело можете идти на битву экстрасенцев. Игра окончена.");
    }
    else
    {
        Console.WriteLine($"Вы не угадали, кажется сегодня удача не на вашей стороне.  Игра окончена. ,");
    }
}
