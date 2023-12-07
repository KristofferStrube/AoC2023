var lines = Day07Task2.Input.Literal
    .Split("\r\n");

var hands = lines
    .Select(line => line.Split(" "))
    .Select(lineParts => (
        hand: lineParts[0],
        bid: int.Parse(lineParts[1]),
        groups: lineParts[0].GroupBy(c => c).Where(g => g.First() != 'J'),
        jokers: lineParts[0].Count(c => c is 'J')
    ))
    .Select(hand => new Hand(
        hand.hand,
        hand.bid,
        type: hand.groups.Count() is 0 ? 7
            : hand.groups.Any(g => g.Count() >= 5 - hand.jokers) ? 7
            : hand.groups.Any(g => g.Count() >= 4 - hand.jokers) ? 6
            : hand.groups.FirstOrDefault(g => g.Count() >= 3 - hand.jokers) is { } larger && hand.groups.Any(g => g.First() != larger.First() && g.Count() >= 2) ? 5
            : hand.groups.Any(g => g.Count() >= 3 - hand.jokers) ? 4
            : hand.groups.FirstOrDefault(g => g.Count() >= 2) is { } firstPair && hand.groups.Any(g => g.First() != firstPair.First() && g.Count() >= 2 - hand.jokers) ? 3
            : hand.groups.Any(g => g.Count() >= 2 - hand.jokers) ? 2
            : 1
    ))
    .ToArray();

var orderedHands = hands
    .OrderBy(hand => hand, new HandComparer())
    .ToArray();

int winnings = 0;
for (int i = 0; i < orderedHands.Length; i++)
{
    winnings += orderedHands[i].bid * (i + 1);
}

Console.WriteLine(winnings);


public class HandComparer : IComparer<Hand>
{
    public int Compare(Hand x, Hand y)
    {
        int typeComparison = x.type - y.type;
        if (typeComparison is not 0) return typeComparison;
        int c0 = value(x.hand[0]) - value(y.hand[0]);
        if (c0 is not 0) return c0;
        int c1 = value(x.hand[1]) - value(y.hand[1]);
        if (c1 is not 0) return c1;
        int c2 = value(x.hand[2]) - value(y.hand[2]);
        if (c2 is not 0) return c2;
        int c3 = value(x.hand[3]) - value(y.hand[3]);
        if (c3 is not 0) return c3;
        int c4 = value(x.hand[4]) - value(y.hand[4]);
        return c4;
    }

    private int value(char card) => card switch
    {
        'A' => 13,
        'K' => 12,
        'Q' => 11,
        'T' => 10,
        '9' => 9,
        '8' => 8,
        '7' => 7,
        '6' => 6,
        '5' => 5,
        '4' => 4,
        '3' => 3,
        '2' => 2,
        _ => 1
    };
}

public record struct Hand(string hand, int bid, int type);