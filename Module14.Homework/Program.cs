using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Card> listOfCards = new List<Card>();
            listOfCards.Add(new Card(6, "Clubs"));
            listOfCards.Add(new Card(6, "Diamonds"));
            listOfCards.Add(new Card(6, "Hearts"));
            listOfCards.Add(new Card(6, "Spades"));

            listOfCards.Add(new Card(7, "Clubs"));
            listOfCards.Add(new Card(7, "Diamonds"));
            listOfCards.Add(new Card(7, "Hearts"));
            listOfCards.Add(new Card(7, "Spades"));

            listOfCards.Add(new Card(8, "Clubs"));
            listOfCards.Add(new Card(8, "Diamonds"));
            listOfCards.Add(new Card(8, "Hearts"));
            listOfCards.Add(new Card(8, "Spades"));

            listOfCards.Add(new Card(9, "Clubs"));
            listOfCards.Add(new Card(9, "Diamonds"));
            listOfCards.Add(new Card(9, "Hearts"));
            listOfCards.Add(new Card(9, "Spades"));

            listOfCards.Add(new Card(10, "Clubs"));
            listOfCards.Add(new Card(10, "Diamonds"));
            listOfCards.Add(new Card(10, "Hearts"));
            listOfCards.Add(new Card(10, "Spades"));

            listOfCards.Add(new Card(11, "Clubs"));
            listOfCards.Add(new Card(11, "Diamonds"));
            listOfCards.Add(new Card(11, "Hearts"));
            listOfCards.Add(new Card(11, "Spades"));

            listOfCards.Add(new Card(12, "Clubs"));
            listOfCards.Add(new Card(12, "Diamonds"));
            listOfCards.Add(new Card(12, "Hearts"));
            listOfCards.Add(new Card(12, "Spades"));

            listOfCards.Add(new Card(13, "Clubs"));
            listOfCards.Add(new Card(13, "Diamonds"));
            listOfCards.Add(new Card(13, "Hearts"));
            listOfCards.Add(new Card(13, "Spades"));

            listOfCards.Add(new Card(14, "Clubs"));
            listOfCards.Add(new Card(14, "Diamonds"));
            listOfCards.Add(new Card(14, "Hearts"));
            listOfCards.Add(new Card(14, "Spades"));

            List<Player> playerList = new List<Player>();
            playerList.Add(new Player());
            playerList.Add(new Player());
            playerList.Add(new Player());
            Game game = new Game(playerList, listOfCards);

        }
    }
}
