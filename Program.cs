using System;
using System.Collections;
using System.Collections.Generic;

namespace card_game {
   class Program {
        static string[] games = new string[]{"BLACKJACK"};
        static void Main(string[] args) {
            // int selectedGame = SelectGame();
            Card card = new Card(Card.Suit.CLUB, Card.Rank.ACE);
            Console.WriteLine(card.suit);
        }

        private static int SelectGame() {
            Console.WriteLine("SELECT A GAME:");

            for (int i = 0; i < games.Length; i++) {
                Console.WriteLine("[{0}] - {1}", i, games[i]);
            }

            int selectedGame = -1;
            do {
                string selectedGameStr = Console.ReadLine();
                selectedGame = Int32.Parse(selectedGameStr);
            } while (selectedGame >= games.Length || selectedGame < 0);

            return selectedGame;
        }

        private static List<Card> SetupGame() {
            int numSuits = Enum.GetNames(typeof(Card.Suit)).Length;
            int numRanks = Enum.GetNames(typeof(Card.Rank)).Length;
            List<Card> deck = new List<Card>();

            foreach (Card.Suit suit in (Card.Suit[]) Enum.GetValues(typeof(Card.Suit))) {
                foreach (Card.Rank rank in (Card.Rank[]) Enum.GetValues(typeof(Card.Rank))) {
                }
            }
        }
    }
}
