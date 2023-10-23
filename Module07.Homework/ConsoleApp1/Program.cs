using MyClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Tank> T34 = new List<Tank>();
            Console.WriteLine("T-34:");
            for (int i = 0; i < 5; i++)
            {
                string name = "T34 - "+i.ToString();

                T34.Add ( new Tank(name,rand));
                T34[i].GetSpecifications();
            }
            string separator = new string('-', 15);
            Console.WriteLine(separator);

            Console.WriteLine("Pantera:");
            List<Tank> Pantera = new List<Tank>();

            for (int i = 0; i < 5; i++)
            {
                string name = "Pantera - " + i.ToString();
                Pantera.Add( new Tank(name, rand));
                Pantera[i].GetSpecifications();
            }

            
            List<Tank> WonTanks = new List<Tank>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(separator);

                Console.WriteLine("{0} VS {1}", T34[i].GetName(), Pantera[i].GetName());
                WonTanks.Add ( T34[i]*Pantera[i]);

                Console.WriteLine("Победитель: {0}",WonTanks[i].GetName());
            }



        }
    }
}
