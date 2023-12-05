﻿var lines = Day05Task2.Input.Literal
    .Split("\r\n");

List<long> seeds = new();

foreach(var chunk in lines[0][7..].Split(" ")
    .Select(long.Parse)
    .Chunk(2)
    .Select(chunk => (start: chunk[0], length: chunk[1])))
{
    for (long k = 0; k < chunk.length; k++)
    {
        seeds.Add(chunk.start + k);
    }
}

int i = 2;
while (i < lines.Length - 1)
{
    i++;
    List<(long destinationRangeStart, long sourceRangeStart, long rangeLength)> maps = new();

    while (i < lines.Length && lines[i] is { Length: > 0 } line)
    {
        var lineParts = line.Split(" ").Select(long.Parse).ToArray();
        maps.Add((lineParts[0], lineParts[1], lineParts[2]));
        i++;
    }

    for (int j = 0; j < seeds.Count; j++)
    {
        if (maps.FirstOrDefault(map => seeds[j] >= map.sourceRangeStart && seeds[j] < map.sourceRangeStart + map.rangeLength) is { } match)
        {
            seeds[j] = seeds[j] - match.sourceRangeStart + match.destinationRangeStart;
        }
    }

    i++;
}

Console.WriteLine(seeds.Min());