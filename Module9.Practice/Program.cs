using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Разработать приложение «Резервная копия»*/

            DVD dvd = new DVD("my dvd","TOSHIBA 1234",1024,6.6,2.5);
            Flash flash = new Flash("my flash", "Kingston 5678", 512, 16.6);
            List<double> sizeOfSections = new List<double>() {200,300,400,124 };
            HDD hdd = new HDD("my dvd", "TOSHIBA 1234", 2048, 8.1, 4, sizeOfSections);

            double DVDMemory = 0, FlashMemory = 0, HDDMemory = 0;

            double DVDFreeMemory = 0, FlashFreeMemory = 0, HDDFreeMemory = 0;

            List<double> listForCopy = new List<double>() {523.44};
            dvd.GetInfo();
            DVDMemory = dvd.GetMemory();
            Console.WriteLine(DVDMemory);
            dvd.Copying(listForCopy);
            DVDFreeMemory = dvd.GetFreeMemory();
            Console.WriteLine(DVDFreeMemory);
            
            Console.WriteLine("------------------------------------------------------------------");
            flash.GetInfo();
            FlashMemory = flash.GetMemory();
            Console.WriteLine(FlashMemory);
            flash.Copying(listForCopy);
            FlashFreeMemory = flash.GetFreeMemory();
            Console.WriteLine(FlashFreeMemory);

            Console.WriteLine("------------------------------------------------------------------");
            hdd.GetInfo();
            HDDMemory = hdd.GetMemory();
            Console.WriteLine(HDDMemory);
            hdd.Copying(listForCopy);
            HDDFreeMemory = hdd.GetFreeMemory();
            Console.WriteLine(HDDFreeMemory);
            Console.WriteLine("------------------------------------------------------------------");




        }
    }
}
