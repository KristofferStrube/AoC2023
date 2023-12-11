var grid = Input.Literal
    .Split("\r\n");

var emptyRows = Enumerable
    .Range(0, grid.Length)
    .Where(row => !Enumerable.Range(0, grid[0].Length).Any(column => grid[row][column] is '#'))
    .ToArray();

var emptyColumns = Enumerable
    .Range(0, grid[0].Length)
    .Where(column => !Enumerable.Range(0, grid.Length).Any(row => grid[row][column] is '#'))
    .ToArray();

List<(int y, int x)> galaxies = new();

for (int i = 0; i < grid.Length; i++)
{
    for (int j = 0; j < grid[0].Length; j++)
    {
        if (grid[i][j] is '#')
        {
            galaxies.Add((i, j));
        }
    }
}

long sum = 0;

for (int i = 0; i < galaxies.Count; i++)
{
    for (int j = 0; j < i; j++)
    {
        var galaxy1 = galaxies[i];
        var galaxy2 = galaxies[j];
        int manhatten = Math.Abs(galaxy2.x - galaxy1.x) + Math.Abs(galaxy2.y - galaxy1.y);
        int rowDiff = emptyRows.Count(r => r < Math.Max(galaxy1.y, galaxy2.y) && r > Math.Min(galaxy1.y, galaxy2.y));
        int columnDiff = emptyColumns.Count(c => c < Math.Max(galaxy1.x, galaxy2.x) && c > Math.Min(galaxy1.x, galaxy2.x));
        sum += manhatten + (rowDiff + columnDiff) * 999999;
    }
}

Console.WriteLine(sum);
