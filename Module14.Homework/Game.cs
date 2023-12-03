using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14.Homework
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public List<Card> AllCards { get; set; }


        //раздача карт
        void givesCards()
        {
            int numOfPlayer = 0;
            int countOfplayers= Players.Count;
            while(AllCards.Count!=0)
            {

                Players[numOfPlayer].Cards.Add(AllCards[AllCards.Count-1]);
                AllCards.RemoveAt(AllCards.Count-1);
                
                numOfPlayer++;
                if (numOfPlayer > countOfplayers)
                {
                    numOfPlayer = 0;
                }
            }

        
        }

        //перетасовка карт
        void shuffle() 
        {
            List<Card> ShuffledCards = new List<Card>();
            Random random = new Random();
            int ListSize = AllCards.Count;
            for (int i = 0; i < ListSize; i++)
            {
                int item = random.Next(0,AllCards.Count);
                ShuffledCards.Add(AllCards[item]);
                AllCards.Remove(AllCards[item]);

            }
            AllCards = ShuffledCards;
        } 

        public Game(List<Player> Players,List<Card> AllCards)
        {
            this.Players = Players;
            this.AllCards = AllCards;
            
        }

    }
}
