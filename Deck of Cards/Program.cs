internal class Program
{
    private static void Main(string[] args)
    {
        var suits = new List<string> {"Clubs", "Diamonds", "Hearts", "Spades"};
        var cards = new List<string> {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

        var deck = new List<string>();

        foreach (var suit in suits) {
            foreach (var card in cards) {
                deck.Add($"{card} of {suit}");
            }
        }

        var random = new Random();
        var selectedCard = deck[random.Next(0, deck.Count - 1)];

        Console.WriteLine($"Card drawn: {selectedCard}");
    }
}