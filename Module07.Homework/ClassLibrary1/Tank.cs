using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    
    public class Tank
    {
        
        string name { get ; set; }
        private int Maneuverability { get; set; }
        private int ammunition { get; set; }
        private int armor { get; set; }

        public Tank(string name,Random rnd)
        {
            
            this.name = name;
            this.Maneuverability =GetRand(rnd);
            this.armor = GetRand(rnd);
            this.ammunition = GetRand(rnd);

        }
        public int GetRand(Random rnd)
        {
            
            int num = rnd.Next(0, 100);
            return num;
        }
        public void GetSpecifications() {

            Console.WriteLine( "Имя: {0} -> Маневренность: {1} -> Уровени брони: {2} -> Урон: {3}",name,Maneuverability,ammunition,armor);
        }
        public string GetName()
        {

            return name;
                }
        public static Tank operator * (Tank tank1,Tank tank2) 
        {
            try {//если танк 1 превосходит по какой - то величине, то его счетчик увеличивается и уменьшается в противном случае
                //если счетчик в минусе, то танк проиграл
                int count = 0;
                if (tank1.Maneuverability > tank2.Maneuverability)
                {
                    count++;
                }
                else count--;
                
                if (tank1.armor > tank2.armor)
                {
                    count++;
                }
                else count--;
                
                if (tank1.ammunition > tank2.ammunition)
                {
                    count++;
                }
                else count--;

                if (count > 0) {
                    return tank1;
                }
                else return tank2;
            }
            catch {
                return null;
            }
            
        }
    }
}
