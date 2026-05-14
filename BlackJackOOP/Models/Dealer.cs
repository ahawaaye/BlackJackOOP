using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackOOP.Models
{
    public class Dealer : Player

    {
        public Dealer() : base("Dealer",true )
        { 
        }
        // Dealer hits until they have 17 or more points
        public void PlayTurn(Deck deck)
        {
            while (GetHandValue() < 17)
            {
                Hit(deck);
            }
        }

    }
}
