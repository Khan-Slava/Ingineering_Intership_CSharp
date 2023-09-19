internal class Program
{
    private static void Main(string[] args)
    {
        //task1();
        //task2();
        //task3();
        //task13();
        //task12();
        //task11();
        //task10();

    }
    //Объявить одномерный(5 элементов ) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел
    //с именем B.Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный
    //массив В случайными числами с помощью циклов.Вывести на экран значения массивов: массива А в одну строку,
    //массива В — в виде матрицы.Найти в данных массивах общий максимальный элемент, минимальный элемент,
    //общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов массива А,
    //сумму нечетных столбцов массива В
    public static void task1()
    {
        Console.WriteLine("Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В");
        int[] A = new int[5];
        double[,] B = new double[3, 4];
        
        Console.WriteLine("Введите числа для массива через enter");

        for (int i = 0; i < A.Length; i++)
        {
            while (!Int32.TryParse(Console.ReadLine(), out A[i]))
            {
                Console.WriteLine("введите целое число ");
            }
        }

        foreach (int i in A)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();

        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i,j] = random.NextDouble();
                Console.Write("{0} ", B[i,j]);
            }
            Console.WriteLine();
        }

        double maxA = A[0];
        double maxB = B[0, 0];
        foreach (double element in A)
        {
            if (element > maxA)
                maxA = element;

        }
        foreach (double element in B)
        {
            if (element > maxB)
                maxB = element;
        }
        if (maxA > maxB)
        {
            Console.WriteLine("Общий максимальный элемент: {0}",maxA);
        }
        else
            Console.WriteLine("Общий максимальный элемент: {0}", maxB);


        double minA = A[0];
        double minB = B[0, 0];
        foreach (double element in A)
        {
            if (element < minA)
                minA = element;
        }
        foreach (double element in B)
        {
            if (element < minB)
                minB = element;
        }
        if (minA < minB)
        {
            Console.WriteLine("Общий минимальный элемент: {0}", minA);
        }
        else
            Console.WriteLine("Общий минимальный элемент: {0}", minB);

        double sumA = 0;
        double sumB = 0;
        foreach (double element in A)
        {
            sumA += element;
        }
        foreach (double element in B)
        {
            sumB += element;
        }
        Console.WriteLine("Общая сумма всех элементов: {0}" , (sumA + sumB));

        double productA = 1;
        double productB = 1;
        foreach (double element in A)
        {
            productA *= element;
        }
        foreach (double element in B)
        {
            productB *= element;
        }
        Console.WriteLine("Общее произведение всех элементов: {0}" , (productA * productB));


    }
    /*
        Подсчитать количество слов во введенном предложении..*/
    public static void task2()
    {
        Console.WriteLine("Подсчитать количество слов во введенном предложении.");
        Console.Write("Введите предложение: ");
        string str = Console.ReadLine();
        int wordCount = 0;

        char[] delimiters = { ' ', '.', ',', '!', '?', ';', ':' };

        // Разделяем предложение на слова с использованием разделителей
        string[] words = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        wordCount = words.Length;
        Console.WriteLine($"Количество слов в предложении: {wordCount}");
    }


    //Пользователь вводит строку.Проверить, является ли эта строка палиндромом.
    //Палиндромом называется строка, которая одинаково читается слева направо и справа налево
    static void task3()
    {
        Console.WriteLine(" Пользователь вводит строку.Проверить, является ли эта строка палиндромом.Палиндромом называется строка, которая одинаково читается слева направо и справа налево.");

        Console.Write("Введите строку: ");
        string str = Console.ReadLine();

        int left = 0;
        int right = str.Length - 1;

        bool isPaliandr = true;
        while (left < right)
        {
            if (str[left] != str[right])
            {
                isPaliandr =  false;
                break;
            }
            left++;
            right--;
        }
        if (isPaliandr)
        {
            Console.WriteLine("Эта строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Эта строка не является палиндромом.");
        }

    }

    //Дано предложение из 10 слов.Заполнить ими массив из 10 элементов.
    static void task13()
    {
        Console.WriteLine("Дано предложение из 10 слов. Заполнить ими массив из 10 элементов.");
        string text = "Дано предложение из 10 слов Заполнить ими массив элементов";
        string[] array = text.Split(" ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        
    }

    //Дан текст.Найти сумму всех имеющихся в нем чисел
    static void task12()
    {
        Console.WriteLine("Дан текст. Найти сумму всех имеющихся в нем чисел");
        string text = "55djkvbsdjvs,vav";
        int num = 0;
        int summa = 0;
        for(int i=0;i< text.Length;i++)
        {
            if (Int32.TryParse(text[i].ToString(),out num ))
            {
                summa += num;    
            }
        }
        Console.WriteLine(summa);

    }

    //Дан текст.Определить количество цифр в нем
    static void task11() {
        Console.WriteLine("Дан текст. Определить количество цифр в нем.");
        string text = "55djkvbsdjvs,vav";
        int num = 0;
        int summa = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (Int32.TryParse(text[i].ToString(), out num))
            {
                summa ++;
            }
        }
        Console.WriteLine(summa);
    }
/*
    Дано слово.

а) Удалить из него третью букву.

б) Удалить из него k-ю букву*/
    static void task10()
    {
        Console.WriteLine("Дано слово.\r\n\r\nа) Удалить из него третью букву.\r\n\r\nб) Удалить из него k-ю букву.");
        string word = "Слово";
        string NewWord = word.Remove(2);
        Console.WriteLine(word);
        Console.WriteLine(NewWord);

    }

}