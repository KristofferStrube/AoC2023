var games = Day02Task2.Input.Literal
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
    .Select(game =>
        game.draws.Max(cubes => cubes.FirstOrDefault(cube => cube.color is "red") is { } match ? match.amount : 0)
        * game.draws.Max(cubes => cubes.FirstOrDefault(cube => cube.color is "green") is { } match ? match.amount : 0)
        * game.draws.Max(cubes => cubes.FirstOrDefault(cube => cube.color is "blue") is { } match ? match.amount : 0)
    ).Sum();

Console.WriteLine(result);