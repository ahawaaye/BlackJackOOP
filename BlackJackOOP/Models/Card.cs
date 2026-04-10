using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackOOP.Models
{
    public class Card
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

        public Suit suit;
        public Rank rank;

        public int GetValue()
        {
            // cards 2-10
            if ((int)rank <= 10)
            {
                return (int)rank;
            }

            // face cards
            if (rank == Rank.Jack || rank == Rank.Queen || rank == Rank.King)
            {
                return 10;
            }

            // Ace
            return 11;
        }
    }
}