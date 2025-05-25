using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Card/Deck and BankAccount Classes\n");

        TestCardAndDeck();
        Console.WriteLine("\n");
        TestBankAccount();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void TestCardAndDeck()
    {
        Console.WriteLine("Testing Card and Deck Classes\n");

        Card card1 = new Card(Rank.Ace, Suit.Spades);
        Card card2 = new Card(Rank.King, Suit.Hearts, true);

        Console.WriteLine($"Card 1: {card1}");
        Console.WriteLine($"Card 2: {card2}");
        Console.WriteLine($"Card 1 value: {card1.GetValue()}");

        card1.FlipOver();
        Console.WriteLine($"Card 1 after flipping: {card1}");

        Deck deck = new Deck();
        Console.WriteLine($"\nNew deck created with {deck.Count} cards");

        Console.WriteLine("\nTaking top 5 cards:");
        for (int i = 0; i < 5; i++)
        {
            Card topCard = deck.TakeTopCard();
            topCard.FlipOver();
            Console.WriteLine($"Card {i + 1}: {topCard}");
        }

        Console.WriteLine($"Cards remaining: {deck.Count}");

        deck.Shuffle();
        Console.WriteLine("Deck shuffled!");

        deck.Cut(20);
        Console.WriteLine("Deck cut at position 20");

        Console.WriteLine($"Final deck count: {deck.Count}");
    }

    static void TestBankAccount()
    {
        Console.WriteLine("Testing BankAccount Class\n");

        BankAccount account1 = new BankAccount("John Smith", 1000.00m);
        BankAccount account2 = new BankAccount("Jane Doe", 500.50m);

        account1.DisplayAccountInfo();
        account2.DisplayAccountInfo();

        Console.WriteLine("\nTesting Operations:");
        account1.Deposit(250.75m);
        account1.Withdraw(150.00m);
        account2.Deposit(-50.00m);
        account2.Withdraw(1000.00m);

        account1.DisplayAccountInfo();
        account2.DisplayAccountInfo();

        account1.DisplayTransactionHistory();
    }
}