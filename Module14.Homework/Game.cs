using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14.Homework
{
    public class Game<T>
    {
        public List<T> Players { get; set; }
        public List<T> Cards { get; set; }


        //раздача карт
        void givesCards()
        {

        }

        //перетасовка карт
        void shuffle() 
        {
            List<T> ShuffledCards = new List<T>();
            Random random = new Random();
            int ListSize = Cards.Count;
            for (int i = 0; i < ListSize; i++)
            {
                int item = random.Next(0,Cards.Count);
                ShuffledCards.Add(Cards[item]);
                Cards.Remove(Cards[item]);

            }
            Cards = ShuffledCards;
        } 

        public Game()
        {
            List<T> Players;
            
        }
    }
}
