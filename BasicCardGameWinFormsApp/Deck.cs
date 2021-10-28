using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCardGameWinFormsApp
{
    class Deck
    {

        // CREATE DECK OF CARDS LIST AND FILL WITH CARD OBJECTS
        public List<Card> deckOfCards = new List<Card>
            { 
                // Create 13 cards Hearts
                new Card { Face = "A", Type = "H", Value = 1 },
                new Card { Face = "2", Type = "H", Value = 2 },
                new Card { Face = "3", Type = "H", Value = 3 },
                new Card { Face = "4", Type = "H", Value = 4 },
                new Card { Face = "5", Type = "H", Value = 5 },
                new Card { Face = "6", Type = "H", Value = 6 },
                new Card { Face = "7", Type = "H", Value = 7 },
                new Card { Face = "8", Type = "H", Value = 8 },
                new Card { Face = "9", Type = "H", Value = 9 },
                new Card { Face = "10", Type = "H", Value = 10 },
                new Card { Face = "J", Type = "H", Value = 11 },
                new Card { Face = "Q", Type = "H", Value = 12 },
                new Card { Face = "K", Type = "H", Value = 13 },

                // Create 13 cards Clubs
                new Card { Face = "A", Type = "C", Value = 1 },
                new Card { Face = "2", Type = "C", Value = 2 },
                new Card { Face = "3", Type = "C", Value = 3 },
                new Card { Face = "4", Type = "C", Value = 4 },
                new Card { Face = "5", Type = "C", Value = 5 },
                new Card { Face = "6", Type = "C", Value = 6 },
                new Card { Face = "7", Type = "C", Value = 7 },
                new Card { Face = "8", Type = "C", Value = 8 },
                new Card { Face = "9", Type = "C", Value = 9 },
                new Card { Face = "10", Type = "C", Value = 10 },
                new Card { Face = "J", Type = "C", Value = 11 },
                new Card { Face = "Q", Type = "C", Value = 12 },
                new Card { Face = "K", Type = "C", Value = 13 },

                // Create 13 cards Diamonds
                new Card{ Face = "A", Type = "D", Value = 1 },
                new Card{ Face = "2", Type = "D", Value = 2 },
                new Card{ Face = "3", Type = "D", Value = 3 },
                new Card{ Face = "4", Type = "D", Value = 4 },
                new Card{ Face = "5", Type = "D", Value = 5 },
                new Card{ Face = "6", Type = "D", Value = 6 },
                new Card{ Face = "7", Type = "D", Value = 7 },
                new Card{ Face = "8", Type = "D", Value = 8 },
                new Card{ Face = "9", Type = "D", Value = 9 },
                new Card{ Face = "10", Type = "D", Value = 10 },
                new Card{ Face = "J", Type = "D", Value = 11 },
                new Card{ Face = "Q", Type = "D", Value = 12 },
                new Card{ Face = "K", Type = "D", Value = 13 },

                // Create 13 cards Spades
                new Card { Face = "A", Type = "S", Value = 1 },
                new Card { Face = "2", Type = "S", Value = 2 },
                new Card { Face = "3", Type = "S", Value = 3 },
                new Card { Face = "4", Type = "S", Value = 4 },
                new Card { Face = "5", Type = "S", Value = 5 },
                new Card { Face = "6", Type = "S", Value = 6 },
                new Card { Face = "7", Type = "S", Value = 7 },
                new Card { Face = "8", Type = "S", Value = 8 },
                new Card { Face = "9", Type = "S", Value = 9 },
                new Card { Face = "10", Type = "S", Value = 10 },
                new Card { Face = "J", Type = "S", Value = 11 },
                new Card { Face = "Q", Type = "S", Value = 12 },
                new Card { Face = "K", Type = "S", Value = 13 }
            };

        // FUNCTIONALITY TO SHUFFLE THE DECK OF CARDS, CARDS GET PUT RANDOMLY IN A SECOND DECK AND GET PUT BACK IN THE FIRST DECK
        public List<Card> shuffleDeck = new List<Card>();
        public void Shuffle()
        {
            Random random = new Random();
            int rnd;
            Deck deck = new Deck();
            int i = deck.deckOfCards.Count;
            while (i > 0)
            {
                rnd = random.Next(0, deckOfCards.Count);
                shuffleDeck.Add(deckOfCards[rnd]);
                deckOfCards.Remove(deckOfCards[rnd]);
                i--;
            }
            foreach (var item in shuffleDeck) deckOfCards.Add(item);
            //foreach (var item in deckOfCards) Console.WriteLine(item);
        }
    }
}
