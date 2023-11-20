using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Practice
{
    public class HDD : Storage
    {
        double speedForUSB_2=0;
        int countOfSection=0;
        List<double> sections = new List<double>();
        List<double> storage = new List<double>();

        public HDD()
        {

        }
        public HDD(string name, string model, double memory, double speedForUSB_2,int countOfSection, List<double> sections) : base(name, model, memory)
        {

            this.speedForUSB_2 = speedForUSB_2;
            this.countOfSection = countOfSection;
            foreach(var section in sections)
            {
                this.sections.Add(section);
            }
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
            int neededMemory = 0;
            foreach (int i in sizeOfFile)
            {
                neededMemory += i;
            }

            //проверка на наличие места для клонирования и само клонирование
            if (freeMemory > neededMemory)
            {
                Console.WriteLine("клонирование началось...");
                
                
                
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
            Console.WriteLine("name: {0} \n model: {1}\n memory: {2} \n speed for usb2.0: {3}" +
                "\n count of sections: {4}", base.name, base.model, base.memory, speedForUSB_2, countOfSection);
        }
    }
}
