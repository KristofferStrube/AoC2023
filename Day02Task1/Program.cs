var games = Day02Task1.Input.Literal
    .Split("\r\n")
    .Select(line => line.Split(": "))
    .Select(lineParts => (
        id: int.Parse(lineParts[0].Split(" ")[1]),
        draws: lineParts[1].Split("; ")
            .Select(draw =>
                draw.Split(", ")
                .Select(cube => cube.Split(" "))
                .Select(cube => (amount: int.Parse(cube[0]), color: cube[1]))
                .ToArray())
            .ToArray()
    ))
    .ToArray();

var result = games
    .Where(game => !game.draws
        .Any(draw =>
            draw.Any(cube => cube.color == "red" && cube.amount > 12)
            || draw.Any(cube => cube.color == "green" && cube.amount > 13)
            || draw.Any(cube => cube.color == "blue" && cube.amount > 14)
        )
    ).Sum(game => game.id);

Console.WriteLine(result);