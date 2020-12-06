using System;

namespace Lesson2_Bases_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------
            //              ДОМАШНЕЕ ЗАДАНИЕ
            //------------------------------------------

            ////Задание 1
            //int num1 = 1, num2 = 2, num3 = 3;
            //Console.WriteLine($"{num1}  {num2}  {num3}");

            ////Задание 2
            //Console.WriteLine("5\n10\n21");

            ////Задание 3
            //int metrs;
            //Console.WriteLine("Введите расстояние в сантиметрах: ");
            //metrs = int.Parse(Console.ReadLine()) /100;
            //Console.WriteLine($"Полных метров {metrs}");

            ////Задание 4
            //int weeks = 234 / 7;
            //Console.WriteLine($"234 дня это {weeks} полных недель");

            ////Задание 5
            //int twoDigitNumber = 46;
            //Console.WriteLine($"Дано чилсо {twoDigitNumber}"); ;
            //Console.WriteLine("Число десятков = " + (46 /10));
            //Console.WriteLine("Число единиц = " + (46 % 10));
            //Console.WriteLine("Сумма цифр = "+ (46%10 + 46/10));
            //Console.WriteLine("Произведение цифр = " + ((46 % 10) * (46 / 10)));

            ////Задание 6
            //bool A = true, B = false, C = false;
            //if (A || B) Console.WriteLine($"A или B = {true}");
            //else Console.WriteLine($"A или B = {false}");

            //if(A&&B) Console.WriteLine($"A и B = {true}");
            //else Console.WriteLine($"A и B = {false}");

            //if (B || C) Console.WriteLine($"B или С = {true}");
            //else Console.WriteLine($"B или С = {false}");

            ////Задание 7
            //double circleRadius = 4;
            //int squareSide = 6;
            //double circleS = Math.PI * Math.Pow(circleRadius, 2);
            //double squareS = Math.Pow(squareSide, 2);
            //Console.WriteLine($"Площадь круга = {circleS}");
            //Console.WriteLine($"Площадь квадрата = {squareS}");
            //if (circleS > squareS)
            //    Console.WriteLine("Площадь КРУГА > площади КВАДРАТА!");
            //else if (circleS < squareS)
            //    Console.WriteLine("Площадь КВАДРАТА > площади КРУГА!");
            //else
            //    Console.WriteLine("Площади Равны!");

            ////Задание 8
            //double weight_1 = 10, weight_2 = 15;//масса КГ
            //double volum_1 = 8, volum_2 = 17;//объем M^3
            ////Плотность КГ/M^3
            //double density_1 = weight_1 / volum_1;
            //double density_2 = weight_2 / volum_2;
            //Console.WriteLine($"Плотность 1-го материала = {density_1}");
            //Console.WriteLine($"Плотность 2-го материала = {density_2}");
            //if (density_1 > density_2)
            //    Console.WriteLine("Плотность 1-го > 2-го!");
            //else if (density_1 < density_2)
            //    Console.WriteLine("Плотность 1-го < 2-го!");
            //else
            //    Console.WriteLine("Плотности равны!");

            ////Задание 9
            //double R_1 = 10, R_2 = 12;//Сопротивление
            //double U_1 = 15, U_2 = 20;//Напряжение
            //double I_1 = U_1 / R_1, I_2 = U_2 / R_2;//Сила тока
            //Console.WriteLine($"Сила тока в 1-ой цепи = {I_1}");
            //Console.WriteLine($"Сила тока в 2-ой цепи = {I_2}");
            //if (I_1 < I_2)
            //    Console.WriteLine("По 1-му участку протекает МЕНЬШИЙ ТОК!");
            //else if (I_2 < I_1)
            //    Console.WriteLine("По 2-му участку протекает МЕНЬШИЙ ТОК!");
            //else
            //    Console.WriteLine("I1 = I2");


            ////Задание 10
            //Console.WriteLine();
            //for (int i = 20; i <= 35; i++)
            //    Console.Write($"{i} ");
            //int begin = 0,end = 0;
            //Console.WriteLine("\nВведите число > 10: ");
            //begin = int.Parse(Console.ReadLine());
            //if (begin > 10)
            //    for (int i = 10; i <= begin; i++)
            //        Console.WriteLine($"{Math.Pow(i, 2)} ");
            //else
            //    Console.WriteLine("Вы ввели неправильное число!!!");
            //Console.WriteLine("Введите число меньше 50: ");
            //begin = int.Parse(Console.ReadLine());
            //if (begin < 50)
            //    for (int i = begin; i <= 50; i++)
            //        Console.WriteLine($"{Math.Pow(i, 3)} ");
            //else
            //    Console.WriteLine("Вы ввели неправильное число!!!");
            //Console.WriteLine("Введите Begin: ");
            //begin = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите End: ");
            //end = int.Parse(Console.ReadLine());
            //if (begin < end)
            //    for (int i = begin; i <= end; i++)
            //        Console.WriteLine($"{i} ");
            //else
            //    Console.WriteLine("Вы ввели неправильные числа!!!");



            //------------------------------------------
            //            ПРАКТИЧЕСКАЯ РАБОТА
            //------------------------------------------

            ////Задание 1
            //double x = 0,y = 0;
            //Console.WriteLine("y = 7x^2 - 3x + 4");
            //Console.Write("Введите значение x: ");
            //x = int.Parse(Console.ReadLine());
            //y = 7 * Math.Pow(x, 2) - 3 * x + 4;
            //Console.WriteLine($"y = {y}");

            ////Задание 2
            //double circleR = 4;
            //double circleS = Math.PI * Math.Pow(circleR, 2);
            //double circleP = 2 * Math.PI * circleR;
            //Console.WriteLine($"Радиус окружности = {circleR}");
            //Console.WriteLine($"Площадь окружности = {circleS}");
            //Console.WriteLine($"Длина окружности = {circleP}");


            ////Задание 3
            //int metrs;
            //Console.WriteLine("Введите расстояние в сантиметрах: ");
            //metrs = int.Parse(Console.ReadLine()) /100;
            //Console.WriteLine($"Полных метров {metrs}");


            ////Задание 4
            //int weeks = 234 / 7;
            //Console.WriteLine($"234 дня это {weeks} полных недель");


            ////Задание 5
            //int twoDigitNumber = 79;
            //Console.WriteLine($"Дано чилсо {twoDigitNumber}"); ;
            //Console.WriteLine("Число десятков = " + (46 /10));
            //Console.WriteLine("Число единиц = " + (46 % 10));
            //Console.WriteLine("Сумма цифр = "+ (46%10 + 46/10));
            //Console.WriteLine("Произведение цифр = " + ((46 % 10) * (46 / 10)));

            ////Задание 6
            //int fourDigitNumber = 1234;
            //Console.WriteLine($"Дано 4-ое число: {fourDigitNumber}");
            //int sum = fourDigitNumber / 1000 + fourDigitNumber % 1000 / 100 + fourDigitNumber % 100 / 10 + fourDigitNumber % 10;
            //int proiz = (fourDigitNumber / 1000) * (fourDigitNumber % 1000 / 100) * (fourDigitNumber % 100 / 10) * (fourDigitNumber % 10);
            //Console.WriteLine($"Сумма его цифр = {sum}");
            //Console.WriteLine($"Произведение его цифр = {proiz}");

            ////Задание 7
            //string finishNum = "456";
            //string figure = finishNum[2].ToString();
            //finishNum = finishNum.Remove(2, 1);
            //finishNum = finishNum.Insert(1, figure);
            //Console.WriteLine($"X = {finishNum}");


            ////Задание 8
            //LogicalResult(true, true);
            //LogicalResult(false, false);
            //LogicalResult(true, false);
            //LogicalResult(false, true);
        }

        static void LogicalResult(bool X, bool Y)
        {
            bool result;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"При X = {X} и Y = {Y}");
            result = !X && !Y;
            Console.WriteLine($"не X и не Y = {result}");
            result = X || (!X && Y);
            Console.WriteLine($"X или (не X и Y) = {result}");
            result = (!X && Y) || Y;
            Console.WriteLine($"(не X и Y) или Y = {result}");
            Console.WriteLine("-------------------------------\n");
        }
    }
}
