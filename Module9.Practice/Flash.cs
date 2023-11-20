using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Practice
{
    public class Flash : Storage
    {
        double speedForUSB_3;
        List<double> storage = new List<double>();
        public Flash()
        {
            
        }
        public Flash(string name,string model,double memory, double speedForUSB_3) : base(name, model,memory)
        {

            this.speedForUSB_3 = speedForUSB_3;

        }


        public override double GetMemory() {
            return memory;
        }

        public override void Copying(List<double> sizeOfFile) 
        {
            //расчет свободной памяти
            double freeMemory = GetFreeMemory();

            //расчет необходимой памяти
            double neededMemory = 0;
            foreach(double i in sizeOfFile)
            {
                neededMemory += i;
            }

            //проверка на наличие места для клонирования и само клонирование
            if(freeMemory > neededMemory)
            {
                foreach (double i in sizeOfFile)
                {
                    storage.Add(i);
                }
                Console.WriteLine("клонирование закончилось...");

            }
            else Console.WriteLine("недостаточно памяти");

        }

        public override double GetFreeMemory() {

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
            Console.WriteLine("name: {0} \n model: {1}\n memory: {2} \n speed for usb3.0: {3}",base.name,base.model,base.memory,speedForUSB_3);
        }
    }
}
