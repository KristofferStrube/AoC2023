var lines = Day01Task1.Input.Literal
    .Split("\r\n")
    .Select(line => line.Where(c => c is '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9').ToArray())
    .ToArray();

var result = lines
    .Sum(line => int.Parse(new string(new char[] { line.First(), line.Last() })));

Console.WriteLine(result);