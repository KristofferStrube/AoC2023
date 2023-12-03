var sanitizedInput = Day01Task2.Input.Literal
    .Replace("one", "o1e").Replace("two", "t2o").Replace("three", "t3e").Replace("four", "4").Replace("five", "5e")
    .Replace("six", "6").Replace("seven", "7n").Replace("eight", "e8t").Replace("nine", "n9e");

var lines = sanitizedInput
    .Split("\r\n")
    .Select(line => line.Where(c => c is '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9').ToArray())
    .ToArray();

var result = lines
    .Sum(line => int.Parse(new string(new char[] { line.First(), line.Last() })));

Console.WriteLine(result);