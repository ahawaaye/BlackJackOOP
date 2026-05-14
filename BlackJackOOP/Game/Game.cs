using System;
using System.Collections.Generic;
using System.Text;
using BlackJackOOP.Models;

namespace BlackJackOOP.Game
{
    public class Game
    {
        private Deck deck;
        private Player player;
        private Dealer dealer;

        public Game()
        {
            deck = new Deck();
            player = new Player("Player");
            dealer = new Dealer();
        }

        public void Start()
        {

            player.ResetHand();
            dealer.ResetHand();


            // Initial deal: 2 cards to player, 1 card to dealer
            player.Hit(deck);
            player.Hit(deck);

            dealer.Hit(deck);
            dealer.Hit(deck);

            Console.WriteLine($"Your hand value: {player.GetHandValue()}");
            Console.WriteLine($"Dealer shows: {dealer.Hand.Cards[0].rank}");

            PlayerTurn();
            DealerTurn();
            DetermineWinner();

        }

        private void PlayerTurn()
        {
            while (true)
            {
                Console.Write("Do you want to hit or stand? (h/s): ");
                string input = Console.ReadLine().ToLower();
                if (input == "h")
                {
                    player.Hit(deck);
                    Console.WriteLine($"Your hand value: {player.GetHandValue()}");
                    if (player.GetHandValue() > 21)
                    {
                        Console.WriteLine("You bust! Dealer wins.");
                        return;
                    }
                }
                else if (input == "s")
                {
                    return;
                }
            }
        }
        private void DealerTurn()
        {
            Console.WriteLine($"Dealer's hand value: {dealer.GetHandValue()}");
            dealer.PlayTurn(deck);
            Console.WriteLine($"Dealer's final hand value: {dealer.GetHandValue()}");
        }

        private void DetermineWinner()
        {
            int playerValue = player.GetHandValue();
            int dealerValue = dealer.GetHandValue();
            if (playerValue > 21)
            {
                Console.WriteLine("You bust! Dealer wins.");
            }
            else if (dealerValue > 21)
            {
                Console.WriteLine("Dealer busts! You win!");
            }
            else if (playerValue > dealerValue)
            {
                Console.WriteLine("You win!");
            }
            else if (dealerValue > playerValue)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }



        }
    }
}
