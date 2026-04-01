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
                //numbers 2-10 
                if((int)rank <= 10) // the value of the cards (2-10) is the same as their rank
                {
                    return (int)rank;
                }
                // the faces of the cards (they all return the value of 10)
                if (rank == Rank.Jack || rank == Rank.Queen || rank == Rank.King)
                    return 10; 

                // ace can be worth either 1 or 11 but for defult we will return 11
            }

        }
    }
}
