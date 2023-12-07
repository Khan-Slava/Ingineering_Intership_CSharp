using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Module15.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task1();
            Console.WriteLine("--------------------------------------------------------");
            task2();
            Console.WriteLine("---------------------------------------------------------");
            task3();
            Console.WriteLine("----------------------------------------------------------");
            task4();

        }
        public static void task1()
        {
            /*С помощью рефлексии получить список методов класса Console и вывести на экран.*/

            Type consoleType = typeof(Console);

            MethodInfo[] methods = consoleType.GetMethods();


            Console.WriteLine("Методы класса Console:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            }
        }
        public static void task2() {
            /*Описать класс с несколькими свойствами.Создать экземпляр класса и инициализировать его свойства.
             * С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. Вывести полученные значения на экран*/
            MyClass myObject = new MyClass();

            myObject.Id = 1;
            myObject.Name = "Пример";
            myObject.Price = 9.99;

            Type objectType = myObject.GetType();
            PropertyInfo[] properties = objectType.GetProperties();

            Console.WriteLine("Значения свойств объекта: {0}", objectType.Name);

            foreach (var property in properties)
            {
                object value = property.GetValue(myObject);
                Console.WriteLine($"{property.Name}: {value}");
            }
        }
        public static void task3()
        {
            string MyStr = "С помощью рефлексии вызвать метод Substring класса String и извлечь из строки подстроку заданного размера.";
            Type stringType = typeof(string);
            MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            Console.WriteLine(stringType);
            object[] arguments = { 20,30 }; // Начальный индекс и длина подстроки

            // Вызываем метод Substring на исходной строке
            object result = substringMethod.Invoke(MyStr, arguments);

            Console.WriteLine(result);


        }
        public static void task4()
        {
            /*Получить список конструкторов класса List<T>*/

            Type objectType = typeof(List<>);
            ConstructorInfo[] ctors = objectType.GetConstructors();
            foreach(var ctor in ctors)
            {
                Console.WriteLine(ctor.Name);//не понимаю зачем это вообще нужно
            }


        }

    }
    
}
