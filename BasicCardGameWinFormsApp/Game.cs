using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCardGameWinFormsApp
{
    class Game
    {
        Card displayCard1;
        Card displayCard2;
        public void playGame(Player player1, Player player2)
        {
            // SETUP GAME
            Deck deck = new Deck();
            deck.Shuffle();

            List<Card> player1Hand = new List<Card>();
            for (int i = 0; i < 26; i++)
            {
                player1Hand.Add(deck.deckOfCards[i]);
                deck.deckOfCards.Remove(deck.deckOfCards[i]);
            }

            List<Card> player2Hand = new List<Card>();
            foreach (var card in deck.deckOfCards) player2Hand.Add(card);
            deck.deckOfCards.Clear();

            // GAME LOGIC
            Random random = new Random();
            Card player1choice;
            Card player2choice;
            int rnd;

            rnd = random.Next(0, player1Hand.Count);
            player1choice = player1Hand[rnd];
            //Debug.WriteLine("{0}'s choice: {1}\n", player1.Name, player1choice);
            displayCard1 = player1choice;

            rnd = random.Next(0, player2Hand.Count);
            player2choice = player2Hand[rnd];
            //Debug.WriteLine("{0}'s choice: {1}\n", player2.Name, player2choice);
            displayCard2 = player2choice;
        }

        //GET THE PLAYER CARD FACE AND TYPE TO COMPARE IT AND CHANGE THE IMAGES IN MAIN
        public string getPlayer1Card()
        {
            return displayCard1.Face + displayCard1.Type;
        }
        public string getPlayer2Card()
        {
            return displayCard2.Face + displayCard2.Type;
        }

        //GET THE PLAYER CARD FACE AND TYPE AND CONVERT IT TO ITS FULL NAME TO DISPLAY IT IN MAIN
        string p1CardType;
        string p1CardFace;
        public string getPlayer1CardName()
        {
            //CORRECT FACE RETURN
            if (displayCard1.Face == "A")
            {
                p1CardFace = "Ace";
            }
            else if (displayCard1.Face == "J")
            {
                p1CardFace = "Jack";
            }
            else if (displayCard1.Face == "Q")
            {
                p1CardFace = "Queen";
            }
            else if (displayCard1.Face == "K")
            {
                p1CardFace = "King";
            }
            else
            {
                p1CardFace = displayCard1.Face;
            }

            //CORRECT TYPE RETURN
            if (displayCard1.Type == "H")
            {
                p1CardType = "Hearts";
            }
            else if (displayCard1.Type == "C")
            {
                p1CardType = "Clubs";
            }
            else if (displayCard1.Type == "D")
            {
                p1CardType = "Diamonds";
            }
            else if (displayCard1.Type == "S")
            {
                p1CardType = "Spades";
            }
            else
            {
                p1CardType = displayCard1.Type;
            }
            return p1CardFace + " of " + p1CardType;
        }

        string p2CardFace;
        string p2CardType;
        public string getPlayer2CardName()
        {
            //CORRECT FACE RETURN
            if (displayCard2.Face == "A")
            {
                p2CardFace = "Ace";
            }
            else if (displayCard2.Face == "J")
            {
                p2CardFace = "Jack";
            }
            else if (displayCard2.Face == "Q")
            {
                p2CardFace = "Queen";
            }
            else if (displayCard2.Face == "K")
            {
                p2CardFace = "King";
            }
            else
            {
                p2CardFace = displayCard2.Face;
            }

            //CORRECT TYPE RETURN
            if (displayCard2.Type == "H")
            {
                p2CardType = "Hearts";
            }
            else if (displayCard2.Type == "C")
            {
                p2CardType = "Clubs";
            }
            else if (displayCard2.Type == "D")
            {
                p2CardType = "Diamonds";
            }
            else if (displayCard2.Type == "S")
            {
                p2CardType = "Spades";
            }
            else
            {
                p2CardType = displayCard2.Type;
            }
            return p2CardFace + " of " + p2CardType;
        }

        //GET THE PLAYER CARD VALUE TO EXECUTE THE ACTUAL GAME LOGIC AND DETERMIN A WINNER
        public int getPlayer1CardValue()
        {
            return displayCard1.Value;
        }
        public int getPlayer2CardValue()
        {
            return displayCard2.Value;
        }
    }
}
