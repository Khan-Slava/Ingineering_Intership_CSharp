using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module08.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            task1();
            string slash = new string('-', 30);
            Console.WriteLine(slash);
            task2();
            Console.WriteLine(slash);
            

        }
        /*
                Создать индексатор, для одномерного массива, который при установке значения будет возводить в квадрат передаваемое
        значение переменной и устанавливать его для указанного индекса. При получении элемента массива по индексу будет 
        возвращаться его текущее значение..*/
        static void task1() 
        {
            int num = 0;
            int position = 0;

            task1_Array MyArray = new task1_Array();


            bool flag = true;
            Console.WriteLine("напишите 123456789 в ввод позиции для остановки");
            while (flag)
            {
                Console.WriteLine("Введите позицию(от 0 до 100):");
                Int32.TryParse(Console.ReadLine(), out position);
                if (position == 123456789)
                {
                    break;
                }
                Console.WriteLine("Введите число для заполнения:");
                Int32.TryParse(Console.ReadLine(), out num);
                MyArray[position] = num;

            }
            Console.WriteLine("Введите позицию для показа:");
            Int32.TryParse(Console.ReadLine(), out position);
            int count = MyArray[position];
            Console.WriteLine(count);



        }
        /*
        2)Написать программу, рассчитывающую сумму коммунальных платежей:
        есть базовые тарифы на отопление (на 1 м2 площади), на воду (на 1 чел), на газ (на 1 чел), 
        на текущий ремонт (на 1 м2 площади). 
        Задается метраж помещения, количество проживающих людей, сезон (осенью и зимой отопление дороже), 
        наличие льгот (ветеран труда– 30 % от его части; ветеран войны- 50% от его части). 
        Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка, Итого. Посчитать итоговую сумму.*/
        static void task2()
        {

            UtilityBills bills = new UtilityBills(new Water(2), new Otoplenie(25.5), new Gas(2));
            Console.WriteLine("Написать программу, рассчитывающую сумму коммунальных платежей: " +
                "есть базовые тарифы на отопление(на 1 м2 площади), на воду(на 1 чел), на газ(на 1 чел), " +
                "на текущий ремонт(на 1 м2 площади).Задается метраж помещения, количество проживающих людей, " +
                "сезон(осенью и зимой отопление дороже), наличие льгот(ветеран труда– 30 % от его части; " +
                "ветеран войны-50 % от его части). Вывести таблицу со столбцами: Вид платежа, Начислено, Льготная скидка, " +
                "Итого.Посчитать итоговую сумму.");
            Console.WriteLine("veteran = false; season =false");
            bool veteran = false;
            bool season = false;
            Console.WriteLine(bills[season,veteran]);

            Console.WriteLine("veteran = true; season =true");
            veteran = true;
            season = true;
            Console.WriteLine(bills[season, veteran]);

            Console.WriteLine("veteran = false; season =true");
            veteran = false;
            season = true;
            Console.WriteLine(bills[season, veteran]);

            Console.WriteLine("veteran = true; season =false");
            veteran = true;
            season = false;
            Console.WriteLine(bills[season, veteran]);
        }
        
        
    }
    //task1
    public class task1_Array
    {

        public int[] array = new int[100];
        

        public task1_Array()
        {
            
        }

         public int this[int position]
         {

            set
            {
                this.array[position] = value*value;
            }
            get { return this.array[position]; }
            

}   
    }


    //task2
    public class Water
    {
        public double price = 26;
        public int countOfPeople { get; set; }
        public Water(int count) {
            this.countOfPeople = count;
        }
        public Water()
        {

        }
        public double result()
        {
            return this.price*countOfPeople;
        }

    }
    public class Otoplenie
    {
        public double price = 456.23;
        public double area { get; set; }
        public Otoplenie(double area)
        {
            this.area = area;
        }
        public Otoplenie()
        {
            
        }
        public double result()
        {
            return this.price * area;
        }
    }
    public class Gas
    {
        public double price = 666.66;
        public int countOfPeople { get; set; }
        public Gas(int count)
        {
            this.countOfPeople = count;
        }
        public Gas()
        {
            
        }
        public double result()
        {
            return this.price * countOfPeople;
        }

    }
    public class UtilityBills
    {
        
        Water water ;
        Otoplenie otoplenie;
        Gas gas ;

        public UtilityBills(Water water, Otoplenie otoplenie, Gas gas)
        {
            this.water = water;
            this.otoplenie = otoplenie;
            this.gas = gas;
        }

        public double this[bool season, bool veteran]
        {
            get
            {
                double result = 0;
                result = water.result() + otoplenie.result() + gas.result();
                if (season) { result = result * 1.2; }
                if (veteran) { result = result * 0.7; }
                return result;   
            }
        }
    }

   
        
    }








































