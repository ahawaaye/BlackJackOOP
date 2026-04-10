using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackOOP.Models
{
    internal class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            // Create full deck (52 cards)
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.rank = rank;

                    Cards.Add(card);
                }
            }

            // Shuffle after creating deck
            Shuffle();
        }

        public Card DrawCard()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            List<Card> pile1 = new List<Card>();
            List<Card> pile2 = new List<Card>();
            List<Card> pile3 = new List<Card>();

            // Split into 3 piles
            for (int i = 0; i < Cards.Count; i++)
            {
                if (i % 3 == 0)
                    pile1.Add(Cards[i]);
                else if (i % 3 == 1)
                    pile2.Add(Cards[i]);
                else
                    pile3.Add(Cards[i]);
            }

            // Clear original deck
            Cards.Clear();

            Random rand = new Random();

            // Mix piles back together
            while (pile1.Count > 0 || pile2.Count > 0 || pile3.Count > 0)
            {
                int choice = rand.Next(3);

                if (choice == 0 && pile1.Count > 0)
                {
                    Cards.Add(pile1[0]);
                    pile1.RemoveAt(0);
                }
                else if (choice == 1 && pile2.Count > 0)
                {
                    Cards.Add(pile2[0]);
                    pile2.RemoveAt(0);
                }
                else if (choice == 2 && pile3.Count > 0)
                {
                    Cards.Add(pile3[0]);
                    pile3.RemoveAt(0);
                }
            }
        }
    }
}