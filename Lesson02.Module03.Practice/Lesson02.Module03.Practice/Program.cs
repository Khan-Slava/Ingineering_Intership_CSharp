internal class Program
{
    private static void Main(string[] args)
    {
        //task13();
        task12();
        task11();
    }
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
    static void task10()
    {
        Console.WriteLine("Дано слово.\r\n\r\nа) Удалить из него третью букву.\r\n\r\nб) Удалить из него k-ю букву.");
        string word = System.Console.ReadLine();
        string NewWord = word ;
    }

}