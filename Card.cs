using System;

public class Card
{
    private Rank rank;
    private Suit suit;
    private bool faceUp;

    public Card(Rank rank, Suit suit, bool faceUp = false)
    {
        this.rank = rank;
        this.suit = suit;
        this.faceUp = faceUp;
    }

    public Suit Suit { get { return suit; } }
    public Rank Rank { get { return rank; } }
    public bool FaceUp { get { return faceUp; } }

    public void FlipOver()
    {
        faceUp = !faceUp;
    }

    public override string ToString()
    {
        if (faceUp)
            return $"{rank} of {suit}";
        else
            return "Face Down Card";
    }

    public int GetValue()
    {
        switch (rank)
        {
            case Rank.Ace:
                return 1;
            case Rank.Jack:
            case Rank.Queen:
            case Rank.King:
                return 10;
            default:
                return (int)rank + 1;
        }
    }
}