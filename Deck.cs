using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards = new List<Card>();

    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(rank, suit));
            }
        }
    }

    public List<Card> Cards 
    { 
        get { return new List<Card>(cards); } 
    }

    public int Count 
    { 
        get { return cards.Count; } 
    }

    public Card TakeTopCard()
    {
        if (cards.Count == 0)
            return null;
        
        Card topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }

    public void Shuffle()
    {
        Random random = new Random();
        
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int randomIndex = random.Next(0, i + 1);
            
            Card temp = cards[i];
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }
    }

    public void Cut(int index)
    {
        if (index <= 0 || index >= cards.Count)
            return;
        
        List<Card> topPart = cards.GetRange(0, index);
        List<Card> bottomPart = cards.GetRange(index, cards.Count - index);
        
        cards.Clear();
        cards.AddRange(bottomPart);
        cards.AddRange(topPart);
    }

    public bool IsEmpty()
    {
        return cards.Count == 0;
    }
}