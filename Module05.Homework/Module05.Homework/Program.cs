using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05.Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sep = new string('-', 50);
            task1();
            Console.WriteLine(sep);
            task2();
            Console.WriteLine(sep);
            task3();
            Console.WriteLine(sep);


        }
        /*Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка.
         * Программа должна завершиться без ошибок.*/
        static void task1()
        {
            try
            {

                string url = "https://eeeeeeeeeeeeeeeeeee.com";
                var request = System.Net.WebRequest.Create(url);
                var response = request.GetResponse();

                response.Close();
            }
            catch (System.Net.WebException e)
            {
                
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }


        }
        /*Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.
         * После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.*/
        static void task2()
        {
            int[] array = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }

        }
/*
        Реализовать несколько методов или классов с методами и вызвать один метод из другого.
        В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.*/
        static void task3() {

            try
            {
                GenerateException();
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e);
                Console.WriteLine(); 
            }

        }
        static void GenerateException()
        {

            throw new Exception("Это исключение было сгенерировано компьютером самостоятельыфвфвоофолволфововолл\n\n\n ВОССТАНИЕ МАШИН НАЧИНАЕТСЯ СЕГОДНЯ!!!\n\n\nзагрузка ног........ ");
        }
        static void task4() { }

    }
}
