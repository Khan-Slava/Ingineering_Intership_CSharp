using System;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //task2();
        //Snikers();
        //task3();
        //task4();
        //task5();
        //task6();
        //task7();
        //task8();
        //task9();
        //task10();
        //task11();
        //task12();
        //task13();
        task14();
    }

    static void Snikers()
    {
        Console.WriteLine("Дана строка символов, состоящая из цифр от 0 до 9 и пробелов. Группы цифр, разделенные пробелами (одним или несколькими) и не содержащие пробелов внутри себя, будем называть словами. Рассматривая эти слова как числа, определить и напечатать сумму чисел, оканчивающихся на цифры 3 или 4.");
        String MyString = Console.ReadLine();
        int count = 0, sum = 0;

        foreach (var i in MyString.Split(" "))
        {

            Int32.TryParse(i, out count);


            if ((count % 10 == 3) || (count % 10 == 4)) {
                sum += count;
            }

        }
        Console.WriteLine("сумма = {0}", sum);
    }
    static void task2()
    {
        Console.WriteLine("Дана строка символов. Группы символов, разделенные пробелами и не содержащие пробелов внутри себя, будем называть словами. Найти количество слов, у которых первый и последний символы совпадают между собой (если можно с комментариями).");
        String myString = Console.ReadLine();//вводим строку

        int countOfWords = 0;//счетчик слов

        foreach (var i in myString.Split(" "))//проходим по элементам строки разделенных пробелами 
        {

            if (i.StartsWith(i[i.Length - 1]))//если строка начинается с последнего символа то увеличим счетчик 
            {
                countOfWords++;
            }

        }
        Console.WriteLine(countOfWords);
    }
    static void task3()
    {
        Console.WriteLine("Ввести небольшой текст (с пробелами) в строку S. Подсчитать количество слов в строке и вывести все слова в столбик");

        string MyString = Console.ReadLine();
        int countOfWords = 0;

        foreach (var i in MyString.Split(" "))
        {
            if (!string.IsNullOrWhiteSpace(i))
            {
                countOfWords++;
                Console.WriteLine(i);

            }

        }
        Console.WriteLine("количество слов: {0}", countOfWords);

    }
    static void task4()
    {
        Console.WriteLine("Дана строка, посчитать количество вхождений буквы P");
        Console.WriteLine("Введите текст: ");
        String MyString = Console.ReadLine();
        int count = 0;

        foreach (var i in MyString.ToUpper())
        {
            if (i == 'P' || i == 'Р')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    public static void task5()
    {
        Console.WriteLine("Нужно ввести текст и определить, на какую букв начинается больше всего слов в тексте.");

        Console.WriteLine("Введите текст: ");
        string myText = Console.ReadLine().Trim();
        int count = 0, maxCounter = int.MinValue;

        char letter, maxLetter = ' ';

        while (myText.Contains("  ")) {
            myText = myText.Replace("  ", " ");

        }


        foreach (var i in myText.Split(" "))
        {
            letter = i[0];
            count = 0;

            foreach (var j in myText.Split(" "))
            {
                if (j[0] == letter)
                {
                    count++;
                }
            }
            if (count > maxCounter)
            {


                maxCounter = count;

                maxLetter = letter;
            }

        }
        Console.WriteLine(maxLetter);

    }
    static void task6()
    {
        Console.WriteLine("Дан текст. Определить, есть ли в тексте слово one");
        string myText = Console.ReadLine().ToLower();

        if (myText.Contains("one"))
        {
            Console.WriteLine("Содержится");
        }
        else { Console.WriteLine("Нет"); }

    }
    
    public static void task7()
    {
        Console.WriteLine("Есть строка (любая), нужно удалить из этой строки знаки / и");
        string myText = Console.ReadLine();

        while (myText.Contains("\\"))
        {
            myText = myText.Replace("\\", "");

        }
        while (myText.Contains("/"))
        {
            myText = myText.Replace("/", "");
        }

        Console.WriteLine(myText);
    }
    public static void task8()
    {
        Console.WriteLine("Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.\r\n\r\n(Подсказка – вспомните что есть строка, и как мы с ней можем работать)");
        int num = 0;
        string ReversedNum;

        do { Console.WriteLine("Введите число: "); }
        while (!Int32.TryParse(Console.ReadLine(), out num));
        string StringNum = num.ToString();
        char[] NumArray = StringNum.ToCharArray();
        Array.Reverse(NumArray);

        ReversedNum = new string(NumArray);

        Console.WriteLine(ReversedNum);
    }
    public static void task9()
    {
        Console.WriteLine("Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. Определить сумму элементов массива, расположенных между минимальным и максимальным элементами\r\n\r\nПодсказка – Random rnd = new Random, rnd.Next(1, 15).");
        int[,] arr = new int[5, 5];
        Random random = new Random();
        int rows = arr.GetUpperBound(0) + 1;
        int columns = arr.GetUpperBound(1) + 1;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;
        int[] maxPos = new int[2];
        int[] minPos = new int[2];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = random.Next(-100, 100);

                if (arr[i, j] > maxValue)
                {
                    maxPos[0] = i;
                    maxPos[1] = j;
                    maxValue = arr[i, j];
                }
                else if (arr[i, j] < minValue)
                {
                    minPos[0] = i;
                    minPos[1] = j;
                    minValue = arr[i, j];

                }


            }

        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{arr[i, j]} \t");

            }
            Console.WriteLine();
        }
        int[] first = new int[2];
        int[] last = new int[2];
        if (maxPos[0] < minPos[0])
        {

            first[0] = maxPos[0];
            first[1] = maxPos[1];
            last[0] = minPos[0];
            last[1] = minPos[1];

        }
        else if (maxPos[0] == minPos[0] && maxPos[1] < minPos[1])
        {
            first[0] = maxPos[0];
            first[1] = maxPos[1];
            last[0] = minPos[0];
            last[1] = minPos[1];
        }
        else
        {
            first[0] = minPos[0];
            first[1] = minPos[1];
            last[0] = maxPos[0];
            last[1] = maxPos[1];

        }
        Console.WriteLine("---");
        bool isFirst = true;
        int sum = 0;
        for (int i = first[0]; i <= last[0]; i++)
        {

            for (int j = 0; j < columns; j++)
            {
                if (isFirst)
                {
                    j = first[1];
                    isFirst = false;
                }
                else if (i == last[0] && j == last[1])
                {
                    sum += arr[i, j];
                    break;
                }

                sum += arr[i, j];
                Console.WriteLine(sum);
            }

        }
        Console.WriteLine(sum);

    }
    public static void task10()
    {
        Console.WriteLine("Найти индекс максимального значения в массиве");
        int[] arr = new int[10] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };
        foreach( int i in arr )
        {
            Console.Write("{0}, ",i);
        }
        int index = Array.IndexOf(arr, arr.Max());
        Console.WriteLine(index);


    }
    public static void task11()
    {
        Console.WriteLine("Найти индекс максимального четного значения в массиве");
        int[] arr = new int[10] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };
        foreach( int i in arr)
        {
            Console.Write("{0}, ",i);
        }
        int max = int.MinValue;
        foreach (int i in arr)
        {
            if (i % 2 == 0 && i > max)
            {
                max = i;
            }
        }
        int index = Array.IndexOf(arr, max);
        Console.WriteLine(index);

    }

    public static void task12()
    {
        Console.WriteLine("Удалить элемент из массива по индексу");
        int[] array = new int[10] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };

        foreach (int i in array)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();


        int index;
        do { Console.WriteLine("введите индекс числа для удаления (в диапазоне массива): "); }
        while (!Int32.TryParse(Console.ReadLine(), out index)  || (index < 0) || (index >= array.Length));

        int[] newArray = new int[array.Length - 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = index + 1; i < array.Length; i++)
        {
            newArray[i - 1] = array[i];
        }

        foreach(int i in newArray)
        {
            Console.Write($"{i}, ");
        }
    }

    public static void task13()
    {      
        Console.WriteLine("Вставить элемент в массив по индекс");

        int[] array = new int[10] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };

        foreach (int i in array)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();


        int index,num;
        do { Console.WriteLine("введите индекс числа для добавления : "); }
        while (!Int32.TryParse(Console.ReadLine(), out index) || (index < 0) || (index > array.Length));

        do { Console.WriteLine("введите число для добавления : "); }
        while (!Int32.TryParse(Console.ReadLine(), out num) );


        int[] newArray = new int[array.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        newArray[index] = num; 
        
        for (int i = index + 1; i < newArray.Length; i++)
        {
            newArray[i] = array[i-1];
        }

        foreach (int i in newArray)
        {
            Console.Write($"{i}, ");
        }
    }
    public static void task14()
    {
        Console.WriteLine("Удалить из строки слова, в которых есть буква 'a': ");

        Console.WriteLine("Введите строку:");
        string StrByDeleteA = Console.ReadLine();

        string[] words = StrByDeleteA.Split(' ');
        string result = "";

        foreach (string word in words)
        {
            bool containsA = false;

            foreach (char letter in word)
            {
                if (letter == 'a' || letter == 'A'|| letter =='а' || letter =='А')
                {
                    containsA = true;
                    break;
                }
            }
            if (!containsA)
            {
                result = result + " " + word;
            }
        }
        Console.WriteLine(result);

    }




    }       