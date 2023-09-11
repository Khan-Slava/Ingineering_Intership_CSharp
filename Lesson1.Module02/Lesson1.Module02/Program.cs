using System;

internal class Program
{
    private static void Main(string[] args)
    {

        //task2();
        //task4();
        //task5();
        //task6();
        //task8();
        //task9();
        //task10();
        task11();
        task12();
        task13();
        task14();
        task15();    
        task16();
        task17();
        task18();
        task19();
        task20();
        task21();
        task22();


    }
    static void task2()
    {
        System.Console.WriteLine("Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым" +
            " (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).\n");
        bool flag = true;

        int num = int.MaxValue;
       
        while (flag || num < 99999 || num > 1000000)
        {
            System.Console.WriteLine("Введите номер трамвайного билета (6 цифр)");

            flag = !Int32.TryParse(System.Console.ReadLine(), out num);
            
        }
        int lastNumbers;
        lastNumbers = num % 1000;
        num = num / 1000;
        int firstSumma = 0, lastSumma = 0;
        while (num > 0 && lastNumbers >0)
        {
            firstSumma += num % 10;
            lastSumma += lastNumbers % 10;

            num = num / 10;
            lastNumbers = lastNumbers / 10;
        
        }
        if (lastSumma == firstSumma)
        {
            System.Console.WriteLine("билет счастливый");
        }
        else { System.Console.WriteLine("билет не счастливый"); }
        
    }
    static void task4() {
        /*Даны целые положительные числа A и B(A < B).Вывести все целые числа от A до B включительно каждое число должно выводиться на новой строке
         * при этом каждое число должно выводиться количество раз, равное его значению.
         * Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
         3 3 3
         4 4 4 4
         5 5 5 5 5
         6 6 6 6 6 6
         7 7 7 7 7 7 7*/

        int A, B;
        System.Console.WriteLine("введите число А:");
        while (!Int32.TryParse(System.Console.ReadLine(), out A) || A<=0 )
        {
            System.Console.WriteLine("Введите положительное целое число!");

        }
        System.Console.WriteLine("введите число B:");
        while (!Int32.TryParse(System.Console.ReadLine(), out B) || B <= 0 || B<=A)
        {
            if (B <= A)
            {
                System.Console.WriteLine("B должно быть больше чем A({0})", A);

            }
            else
            {
                System.Console.WriteLine("Введите положительное целое число!");
            }

        }

        for(int i = A; i <= B; i++)
        {
            System.Console.WriteLine(String.Concat(Enumerable.Repeat(i, i)));
        } 
    }

    static void task5() {
        System.Console.WriteLine("Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево." +
            " \nНапример, если было введено число 345, то программа должна вывести число 543.\n");

        int num;

        do { System.Console.WriteLine("Введите положительное целое число!"); }
        while (!Int32.TryParse(System.Console.ReadLine(), out num) || num <= 0);


        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        System.Console.WriteLine(result);
    }

    static void task6() {

        System.Console.WriteLine("Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.\n");

        double first, second, third;

        do { System.Console.WriteLine("Введите первое число!(в дробных числах используйте запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out first));

        do { System.Console.WriteLine("Введите второе число!(в дробных числах используйте запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out second));

        do { System.Console.WriteLine("Введите третье число!(в дробных числах используйте запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out third));

        System.Console.WriteLine("{0}  {1}  {2}", first, second, third);
    }

    public static void task7()
    {
        Console.WriteLine("Вывести на экран числа 5, 10 и 21 одно под другим.");

        Console.WriteLine("5\n10\n21");
    }
    public static void task8() {
        Console.WriteLine("Дано расстояние в сантиметрах. Найти число полных метров в нем");

        double centimeter;

        do { System.Console.WriteLine("Введите число! "); }
        while (!Double.TryParse(System.Console.ReadLine(), out centimeter));

        Console.WriteLine("в {0} см {1} полных метров", centimeter, Convert.ToInt32(centimeter / 100));

    }
    public static void task9()
    {
        Console.WriteLine("С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");

        Console.WriteLine("прошло {0} полных недель", 234 / 7);
    }

    public static void task10()
    {
        
        Console.WriteLine("Дано двузначное число. Найти:\r\n\r\na. число десятков в нем\r\n\r\nb. число единиц в нем\r\n\r\nc. сумму его цифр\r\n\r\nd. произведение его цифр");
        int number, dec, ed, summa, proizvedenie;

        do { System.Console.WriteLine("Введите двухзначное число: "); }
        while (!int.TryParse(System.Console.ReadLine(), out number) || number < 10 || number > 99);

        dec = number / 10;
        ed = number % 10;
        summa = dec + ed;
        proizvedenie = dec * ed;
        Console.WriteLine("a. число десятков в нем = {0};\r\n\r\nb. число единиц в нем = {1};\r\n\r\nc. сумму его цифр = {2};\r\n\r\nd. произведение его цифр = {3}",dec,ed,summa,proizvedenie);


    }
    public static void task11()
    {
        Console.WriteLine("Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:\r\n\r\na. А или В;\r\n\r\nb. А и В;\r\n\r\nc. В или С");

        bool A = true, B = false, C = false;
        Console.WriteLine("\na. А или В = {0};\r\n\r\nb. А и В = {1};\r\n\r\nc. В или С = {2}", (A || B), (A && B), (B || C));

    }
    public static void task12()
    {
        Console.WriteLine("Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");

        double circle,areaOfCircle, square,areaOfSquare;
        
        
        
        do { Console.WriteLine("введите радиус круга(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out circle));

        do { Console.WriteLine("введите длину стороны квадрата(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out square));

        areaOfCircle = Math.PI * circle * circle;
        areaOfSquare = square * square;

        if (areaOfCircle > areaOfSquare)
        {
            Console.WriteLine("площадь круга({0}) больше площади квадрата({1})", areaOfCircle, areaOfSquare);
        }
        else if (areaOfCircle < areaOfSquare)
        {
            Console.WriteLine("площадь круга({0}) меньше площади квадрата({1})", areaOfCircle, areaOfSquare);
        }
        else { Console.WriteLine("площадь круга({0}) равен площади квадрата({1})", areaOfCircle, areaOfSquare); }
        
    }
    public static void task13()
    {
        Console.WriteLine("Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");

        double volume1, mass1, density1,volume2, mass2,density2 ;

        do { Console.WriteLine("введите объем первого материала(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out volume1));

        do { Console.WriteLine("введите массу первого материала(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out mass1));

        do { Console.WriteLine("введите объем второго материала(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out volume2));

        do { Console.WriteLine("введите массу второго материала(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out mass2));
        
        density1 = mass1 / volume1;
        density2 = mass2/volume2 ;

        if (density1 > density2)
        {
            Console.WriteLine("плотность первого материала({0}) больше плотности второго материала({1})", density1, density2);
        }
        else if (density1 < density2)
        {
            Console.WriteLine("плотность первого материала({0}) меньше плотности второго материала({1})", density1, density2);
        }
        else { Console.WriteLine("плотность первого материала({0}) равен плотности второго материала({1})", density1, density2); }


    }
    public static void task14()
    {
        Console.WriteLine("Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");
        
        double U1, U2, R1, R2 ;

        do { Console.WriteLine("введите напряжение первой цепи(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out U1));

        do { Console.WriteLine("введите сопротивление первой цепи(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out R1));

        do { Console.WriteLine("введите напряжение второй цепи(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out U2));

        do { Console.WriteLine("введите сопротивление второй цепи(дробное число вводится через запятую)"); }
        while (!Double.TryParse(System.Console.ReadLine(), out R2));

       

        if (U1 / R1 > U2 / R2)
        {
            Console.WriteLine("Ток второй цепи меньше ");
        }
        else if (U1 / R1 < U2 / R2)
        {
            Console.WriteLine("ток первой цепи меньше");
        }
        else { Console.WriteLine("токи равны "); }
    }
    public static void task15()
    {
        Console.WriteLine("Напечатать \"столбиком\":\r\n\r\na. все целые числа от 20 до 35;");
        for (int i = 25; i < 35; i++)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("b. квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);");

        int b = 0;

        do { System.Console.WriteLine("Введите двухзначное число больше 10: "); }
        while (!int.TryParse(System.Console.ReadLine(), out b) || b<=10);

        for (int i = 10; i < b; i++)
        {
            Console.WriteLine(i * i);
        }

        Console.WriteLine("третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);");
        int a = 0;
        
        do { System.Console.WriteLine("Введите число меньше 50: "); }
        while (!int.TryParse(System.Console.ReadLine(), out a) || a >= 50);


        for (int i = a; i < 50; i++)
        {
            Console.WriteLine(Math.Pow(a, 3));
        }

        Console.WriteLine("все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a)");
        int num1 = 0, num2 = 0;

        do { System.Console.WriteLine("Введите первое число: "); }
        while (!int.TryParse(System.Console.ReadLine(), out num1) );

        do { System.Console.WriteLine("Введите второе число больше первого: "); }
        while (!int.TryParse(System.Console.ReadLine(), out num2) || num2 <= num1);

        for (int i = num1; i < num2; i++)
        {
            Console.WriteLine(i);
        }

    }
    public static void task16()
    {
        Console.WriteLine("вычисления значения функции y= 7x2-3x+6 при любом значении x");
        double x;

        do { Console.WriteLine("введите х"); }
        while (!Double.TryParse(Console.ReadLine(), out x));

        Console.WriteLine("y = {0}",7*x*x-3*x+6);
    }
    public static void task17()
    {
        Console.WriteLine("вычисления значения функции x= 12a2+7a-16 при любом значении а.");

        double a;

        do { Console.WriteLine("введите а"); }
        while (!Double.TryParse(Console.ReadLine(), out a));

        Console.WriteLine("x = {0}",12*a*a + 7*a - 16);
    }
    public static void task18()
    {
        Console.WriteLine("Дана сторона квадрата.Найти его периметр.");

        double a;

        do { Console.WriteLine("введите сторону квадрата"); }
        while (!Double.TryParse(Console.ReadLine(), out a));

        Console.WriteLine("Периметр = {0}", 4*a);
    }
    public static void task19()
    {
        Console.WriteLine("Дан радиус окружности. Найти ее диаметр.");
        double r;

        do { Console.WriteLine("введите радиус окружности"); }
        while (!Double.TryParse(Console.ReadLine(), out r));

        Console.WriteLine("диаметр = {0},", 2 * r);
    }
    public static void task20()
    {
        Console.WriteLine("Считая, что Земля — идеальная сфера с радиусом R 6350 км, определить расстояние до линии горизонта от точки с заданной высотой над Землей.");
    }
    public static void task21()
    {
        Console.WriteLine("вычисления значения функции z=x3-2.5xy+1.78x2-2.5y+1 при любых значениях х и y;");
    }
    public static void task22()
    {
        Console.WriteLine("Даны два целых числа. Найти:\r\n\r\na. их среднее арифметическое;\r\n\r\nb. их среднее геометрическое.");
    }






}