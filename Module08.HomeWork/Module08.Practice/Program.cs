using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module08.Practice
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
            task3();

        }
/*
        1. В С # индексация начинается с нуля, но в некоторых языках программирования это не так.
Например, в Turbo Pascal индексация массиве начинается с 1.
Напишите класс RangeOfArray, который позволяет работать с массивом такого типа,
в котором индексный диапазон устанавливается пользователем. Например, в диапазоне от 6 до 10, или от –9 до 15.*/
        static void task1() 
        {
            int startNum = 0;
            int needNum = 0;
            RangeOfArray MyClass = new RangeOfArray();
            List<int> MyArray = MyClass.array; 
            foreach (int i in MyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Введите начало массива:");
            Int32.TryParse(Console.ReadLine(),out startNum); 
            Console.WriteLine("Введите нужный элемент массива:");
            Int32.TryParse(Console.ReadLine(), out needNum);
            int count = MyClass[startNum, needNum];
            Console.WriteLine(count);



        }
        /*
        2)Написать программу «Продуктовый супермаркет»: выбирается ряд продуктов,
        рассчитывается их сумма с учетом скидки в 5% (скидка предоставляется, если покупка сделана с 8.00 до 12.00
        по текущему времени)*/
        static void task2()
        {
            
            List<Products> MyProducts = new List<Products>();
            MyProducts.Add(new Products() { name = "pen", price = 100});
            MyProducts.Add(new Products() { name = "pencel", price = 50 });
            MyProducts.Add(new Products() { name = "book", price = 15000 });
            MyProducts.Add(new Products() { name = "note", price = 10 });
            MyProducts.Add(new Products() { name = "paints", price = 1600 });
            MyProducts.Add(new Products() { name = "dictionary", price = 450 });
            Supermarket market = new Supermarket(MyProducts);

            Console.WriteLine("Кассир А.С.Пушкин");
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Console.WriteLine("список покупок:");
            foreach (var i in MyProducts)
            {
                Console.Write("{0} --- {1} тг \n",i.name, i.price);
            }
            Console.WriteLine("Сумма: {0}", market["А.С.Пушкин"]);


            Console.WriteLine("скидка 5% работает с 8:00 до 12:00");

        }
        
        /*
        В файле хранится информация об объеме продаж товара за пять последних месяцев.
        С помощью метода наименьших квадратов спрогнозировать объемы продаж на следующие три месяца.
        В качестве линии тренда выбрать линейную функцию*/
        static void task3() {
        
            List<Prod> MyProd = new List<Prod>();
            MyProd.Add(new Prod(new DateTime(2023, 01, 01), "йогурт", 1234));
            MyProd.Add(new Prod(new DateTime(2023, 02, 01), "йогурт", 2222));
            MyProd.Add(new Prod(new DateTime(2023, 03, 01), "йогурт", 1000));
            MyProd.Add(new Prod(new DateTime(2023, 04, 01), "йогурт", 5934));
            MyProd.Add(new Prod(new DateTime(2023, 05, 01), "йогурт", 162));
            Forecast forecast = new Forecast(MyProd);

            
            Console.WriteLine(forecast[forecast.products]);
        }
    }
    //task1
    public class RangeOfArray
    {
        public List<int> array = new List<int> () ;

        public RangeOfArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array.Add(rnd.Next(100));
                
            }
            
        }

         public int this[int start , int numOfArray]
         {
            get{
                
                try
                {
                    if ( (start - numOfArray) > 0) {
                        return  0;
                    }
                    else
                    {
                        return array[Math.Abs(start - numOfArray)];

                    }
                }
                catch { return 0; }

            }
            //1 2 3 4
            //    1 2 3 4
            

}   
    }
    
    public class Products
    {
        public Products()
        {
            
        }
        public string name {  get; set; }
        public double price { get; set; }


    }
    //task2
    public class Supermarket
    {
        List<Products> products = null;
        public Supermarket()
        {
            products = new List<Products>();
            products.Add(new Products(){name = "pen", price = 100 }) ;

        }
        public Supermarket(List<Products> list)
        {
            products = list;
        }

        public double this[string name]
        {
            get
            {
                TimeSpan start = new TimeSpan(8,0,0);
                TimeSpan end = new TimeSpan(12,0,0);
                double sum = 0;
                foreach (Products product in products)
                    {
                        sum+=product.price ;
                    }
                if (DateTime.Now.TimeOfDay >start && DateTime.Now.TimeOfDay<end)
                {
                    
                    return sum*0.95;
                }
                else { return sum; }  
            }
        }
    }

    //task3
    public class Prod
    {
        public DateTime date { get; set; }
        public string name { get; set; }
        public int countOfSold { get; set; }
        public Prod() { }
        public Prod(DateTime date, string name,int countOfSold)
        {
            this.date = date;
            this.name = name;
            this.countOfSold = countOfSold;
        }
    }
    public class Forecast
    {
        public List<Prod> products = null;
        public Forecast()
        {
            
        }
        public Forecast(List<Prod> products)
        {
            this.products = products;
        }
        public double this[List<Prod> products]
        {
            get
            {
                //вычисления метода наименьшего квадрата
                
                int x = 0, xx=0;
                for(int i = 1; i <= products.Count; i++)
                {
                    x += i;
                    xx += i*i;

                }
                double y = 0, xy = 0;
                int count =0;
                foreach(Prod prod in products) 
                {
                    count++;
                    y += prod.countOfSold;
                    xy += y * count;
                    
                }

                //xx * A+x * B=xy
                //x * A+count * B = y

                double result = xx * count - x * x;
                //пусть будет так...
                return result;

            }
        }
    }







































}
