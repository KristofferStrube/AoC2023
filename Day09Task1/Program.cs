var lines = Input.Literal
    .Split("\r\n");

int sum = 0;

foreach(var line in lines)
{
    List<int[]> differences = new();
    differences.Add(line.Split(" ").Select(int.Parse).ToArray());
    while(differences.Last().Any(n => n is not 0))
    {
        var last = differences.Last();
        differences.Add(Enumerable
            .Range(1, last.Length - 1)
            .Select(i => last[i] - last[i - 1])
            .ToArray());
    }
    int extrapolated = 0;
    for (int i = differences.Count - 2; i >= 0; i--)
    {
        extrapolated = differences[i][^1] + extrapolated;
    }
    sum += extrapolated;
}

Console.WriteLine(sum);
