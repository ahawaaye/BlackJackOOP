using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackOOP.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; set; } = new Hand();
        public bool IsDealer { get; set; }

        public Player(string name, bool isDealer = false)
        {
            Name = name;
            IsDealer = isDealer;
        }

        public void Hit(Deck deck)
        {
            Card? card = deck.DrawCard();
            if (card != null)
            {
                Hand.AddCard(card);
            }
        }


        public int GetHandValue()
        {
            return Hand.GetValue();
        }

        public void ResetHand()
        {
            Hand = new Hand();
        }
    }


}
