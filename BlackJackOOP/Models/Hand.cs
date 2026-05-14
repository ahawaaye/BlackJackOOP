using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackOOP.Models
{


    public class Hand
    {
        public List<Card> Cards = new List<Card>();

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int GetValue()
        {
            int value = 0;
            int aceCount = 0;

            foreach (Card card in Cards) // counts the value of the hand and counts the number of aces
            {
                value += card.GetValue();
                if (card.rank == Card.Rank.Ace)
                {
                    aceCount++;
                }
            }

            while (value > 21 && aceCount > 0) // ace correction: if the value is over 21 and there are aces, it will count the ace as 1 instead of 11
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }
    }

}
