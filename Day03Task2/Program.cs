var sidePaddedInput = Day03Task2.Input.Literal
    .Split("\r\n")
    .Select(line => line.Prepend('.').Append('.').ToArray())
    .ToArray();

var paddedInput = sidePaddedInput
    .Prepend(Enumerable.Range(0, sidePaddedInput.Length).Select(_ => '.').ToArray())
    .Append(Enumerable.Range(0, sidePaddedInput.Length).Select(_ => '.').ToArray())
    .ToArray();

var partNumbers = new List<(int number, int y, int x, int length)>();
var gears = new List<(int y, int x)>();

for (int i = 1; i < paddedInput.Length - 1; i++)
{
    for (int j = 1; j < paddedInput[0].Length - 1; j++)
    {
        string number = "";
        while (paddedInput[i][j] is '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9')
        {
            number += paddedInput[i][j];
            j++;
        }
        if (paddedInput[i][j] is '*')
        {
            gears.Add((i, j));
        }
        if (number.Length is not 0)
        {
            partNumbers.Add((int.Parse(number), i, j - number.Length, number.Length));
        }
    }
}

int sum = 0;

foreach (var gear in gears)
{
    if (partNumbers.Where(part => part.y >= gear.y - 1 && part.y <= gear.y + 1 && part.x <= gear.x + 1 && part.x + part.length >= gear.x).ToArray() is { Length: >= 2} parts)
    {
        sum += parts[0].number * parts[1].number;
        Console.WriteLine(parts.Length);
        Console.WriteLine($"at {gear.y}, {gear.x}: {parts[0].number} * {parts[1].number} = {parts[0].number * parts[1].number}");
    }
}

Console.WriteLine(sum);