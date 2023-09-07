internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1) Написать приложение, которое выведет на экран Ваше имя и фамилию \n");

        Console.WriteLine("Здравствуйте, Введите свое ФИО: ");

        String name = Console.ReadLine();

        Console.WriteLine("Приветствую тебя " + name);
        
        Console.WriteLine("2) Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму.");

        int num1 = 0, num2 = 0;

        Console.WriteLine("Введите первое число!");

        while (Int32.TryParse(Console.ReadLine(), out num1) != true)
        {

            Console.WriteLine("Введите число!");

        };
        Console.WriteLine(num1);

        Console.WriteLine("Введите второе число!");

        while (Int32.TryParse(Console.ReadLine(), out num2) != true)
        {

            Console.WriteLine("Введите число!");

        };

        Console.WriteLine(" {0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine(num1 + num2);

    }


}