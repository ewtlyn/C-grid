using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальные координаты x0 и y0:");
        double x0 = Convert.ToDouble(Console.ReadLine());
        double y0 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите начальную скорость v0 (м/с):");
        double v0 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите угол в градусах:");
        double angleDegrees = Convert.ToDouble(Console.ReadLine());
        double angleRadians = angleDegrees * Math.PI / 180; // перевод в радианы
        

        // компоненты начальной скорости
        double vx0 = v0 * Math.Cos(angleRadians);
        double vy0 = v0 * Math.Sin(angleRadians);
        
        double g = 9.81; // гравитационное ускорение
        
        double dt = 0.1; // параметр времени
        double t = 0; // время

        // вывод координат
        Console.WriteLine("Время\tX(t)\tY(t)");

        while (true)
        {
            double x = x0 + vx0 * t;
            double y = y0 + vy0 * t - 0.5 * g * t * t; //формула

            Console.WriteLine($" {x,-10:F2} {y,-10:F2} {t,-10:F1} "); //выводим с нормальными отступами

            if (y < 0)
            {
                break;
            }

            t += dt;  //чтоб передти к след моменту во времени
        }
    }
}
