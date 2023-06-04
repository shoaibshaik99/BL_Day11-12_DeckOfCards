namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards;
        private Random random = new Random();
        private int currentIndex = 0;

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        // Fisher-Yates shuffle also known as Knuth shuffle algorithm
        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)//when 1 cards is left swapping will replace it with itself hence n>1
            {
                n--;
                int k = random.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        public Card DrawCard()
        {
            if (currentIndex >= cards.Count)
            {
                Console.WriteLine("No more cards in the deck.");
                return null;
            }
            Card card = cards[currentIndex];
            currentIndex++;
            return card;
        }
    }
}
