using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackOOP.Models
{
    internal class Card
    {
        public enum Suit
        {
             Hearts,
            Diamonds,
            Clubs,
            Spades

        }

        public enum Rank
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace


        }
        
        public class card
        {
            public Suit suit;
            public Rank rank;

            public int GetValue()
            {
                 
            }

        }
    }
}
