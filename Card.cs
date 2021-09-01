namespace card_game {
    class Card {
        public Suit suit {get; init;}
        public Rank rank {get; init;}

        public Card(Suit suit, Rank rank) {
            this.suit = suit;
            this.rank = rank;
        }

        public enum Suit {
            DIAMOND, CLUB, SPADE, HEART
        }

        public enum Rank {
            ACE, JACK, QUEEN, KING, JOKER, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN
        }
    }
}