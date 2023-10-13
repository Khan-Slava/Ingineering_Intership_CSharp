using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module05.Practice
{
    /*Реализовать несколько методов или классов с методами и вызвать один метод из другого.
     * В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.*/
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.");
            Console.WriteLine();
            Class2 caller = new Class2();
            caller.CallMethod();
        }
    }
    public class Class1
    {
        public void GenerateException()
        {
            throw new Exception("Весь мир одно сплошное исключение... ");
        }
    }

    public class Class2
    {
        public void CallMethod()
        {
            Class1 target = new Class1();

            try
            {
                target.GenerateException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошло исключение: " + e.Message);
            }
        }
    }
}
