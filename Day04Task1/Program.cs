var cards = Day04Task1.Input.Literal
    .Split("\r\n")
    .Select(line => line.Split(":"))
    .Select(lineParts => (start: lineParts[0], numberSections: lineParts[1].Split(" |")))
    .Select(lineParts => (
        id: lineParts.start.Split(" ")[1],
        winning: lineParts.numberSections[0].Chunk(3).Select(n => new string(n)),
        yours: lineParts.numberSections[1].Chunk(3).Select(n => new string(n))
    ))
    .ToArray();

var points = cards.Sum(card =>
    card.yours.Count(your => card.winning.Contains(your)) is { } corrects and >= 1 ? Math.Pow(2, corrects - 1) : 0
);

Console.WriteLine(points);