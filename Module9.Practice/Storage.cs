using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Practice
{
    public abstract class Storage
    {
        protected string name;
        
    protected string model;
        
    protected double memory;
        

        public Storage()
        {
            
        }
        public Storage(string name,string model,double memory)
        {
            this.name = name;
            this.model = model;
            this.memory = memory;
        }


        public abstract double GetMemory();
        public abstract void Copying(List<double> sizeOfFile);

        public abstract double GetFreeMemory();
        public abstract void GetInfo();
    }
}
