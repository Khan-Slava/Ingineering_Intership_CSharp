using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Practice
{
    public class DVD:Storage
    {
        double ReadingSpeed;
        double WritingSpeed;
        List<double> storage = new List<double>();

        public DVD()
        {

        }
        public DVD(string name, string model, double memory, double ReadingSpeed,double WritingSpeed) : base(name, model, memory)
        {

            this.ReadingSpeed = ReadingSpeed;
            this.WritingSpeed = WritingSpeed;

        }


        public override double GetMemory()
        {
            return memory;
        }

        public override void Copying(List<double> sizeOfFile)
        {
            //расчет свободной памяти
            double freeMemory = GetFreeMemory();

            //расчет необходимой памяти
            double neededMemory = 0;
            foreach (double i in sizeOfFile)
            {
                neededMemory += i;
            }

            //проверка на наличие места для клонирования и само клонирование
            if (freeMemory > neededMemory)
            {
                Console.WriteLine("клонирование началось...");
                double speed = neededMemory * WritingSpeed;
                Console.WriteLine("клонирование займет: {0} с", speed);
                
                foreach (double i in sizeOfFile)
                {
                    storage.Add(i);
                }
                Console.WriteLine("клонирование закончилось...");

            }
            else Console.WriteLine("недостаточно памяти");

        }

        public override double GetFreeMemory()
        {

            double nonFreeMemory = 0;
            foreach (double i in storage)
            {
                nonFreeMemory += i;
            }
            double freeMemory = memory - nonFreeMemory;

            return freeMemory;

        }
        public override void GetInfo()
        {
            Console.WriteLine("name: {0} \n model: {1}\n memory: {2} \n reading speed: {3} \n writing speed: {4}", base.name, base.model, base.memory, ReadingSpeed,WritingSpeed);
        }
    }
}
