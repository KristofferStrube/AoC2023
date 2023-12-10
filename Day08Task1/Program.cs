var lines = Day08Task1.Input.Literal
    .Split("\r\n");

var instructions = lines[0];

var nodes = lines
    .Skip(2)
    .Select(line => line.Split(" = "))
    .ToDictionary(lineParts => lineParts[0], lineParts => lineParts[1][1..^1].Split(", "));

var position = "AAA";
int inst = 0;

while(position is not "ZZZ")
{
    position = nodes[position][instructions[inst % instructions.Length] is 'L' ? 0 : 1];
    inst++;
}

Console.WriteLine(inst);
