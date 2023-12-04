var cards = Day04Task1.Input.Literal
    .Split("\r\n")
    .Select(line => line.Split(":"))
    .Select(lineParts => (start: lineParts[0], numberSections: lineParts[1].Split(" |")))
    .Select(lineParts => (
        id: int.Parse(new string(lineParts.start.Skip(5).ToArray())),
        winning: lineParts.numberSections[0].Chunk(3).Select(n => new string(n)),
        yours: lineParts.numberSections[1].Chunk(3).Select(n => new string(n))
    ))
    .ToArray();

Dictionary<int, int> cardCounts = new(cards.Length);
foreach (var card in cards)
{
    cardCounts.Add(card.id, 1);
}

foreach (var card in cards)
{
    if (card.yours.Count(your => card.winning.Contains(your)) is { } corrects and >= 1)
    {
        for (int i = 0; i < corrects; i++)
        {
            cardCounts[card.id + i + 1] += cardCounts[card.id];
        }
    }
}

Console.WriteLine(cardCounts.Values.Sum());