var grid = Input.Literal
    .Split("\r\n");

var height = grid.Length;
var width = grid[0].Length;

var distances = new int[height, width];

(int y, int x) start = default;
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if (grid[i][j] is 'S')
        {
            start = (i, j);
        }
    }
}

int greatestDistance = 0;
Queue<(int y, int x, int dist)> nextPoints = new();
nextPoints.Enqueue((start.y, start.x, 0));
while (nextPoints.TryDequeue(out var point))
{
    if (distances[point.y, point.x] is not 0) continue;
    distances[point.y, point.x] = point.dist;
    greatestDistance = Math.Max(greatestDistance, point.dist);

    switch (GetChar(point.y, point.x))
    {
        case 'S':
            if (IsLeftConnector(GetChar(point.y, point.x + 1)))
                nextPoints.Enqueue((point.y, point.x + 1, point.dist + 1));
            if (IsRightConnector(GetChar(point.y, point.x - 1)))
                nextPoints.Enqueue((point.y, point.x - 1, point.dist + 1));
            if (IsTopConnector(GetChar(point.y + 1, point.x)))
                nextPoints.Enqueue((point.y + 1, point.x, point.dist + 1));
            if (IsBottomConnector(GetChar(point.y - 1, point.x)))
                nextPoints.Enqueue((point.y - 1, point.x, point.dist + 1));
            break;
        case '|':
            if (IsTopConnector(GetChar(point.y + 1, point.x)))
                nextPoints.Enqueue((point.y + 1, point.x, point.dist + 1));
            if (IsBottomConnector(GetChar(point.y - 1, point.x)))
                nextPoints.Enqueue((point.y - 1, point.x, point.dist + 1));
            break;
        case '-':
            if (IsLeftConnector(GetChar(point.y, point.x + 1)))
                nextPoints.Enqueue((point.y, point.x + 1, point.dist + 1));
            if (IsRightConnector(GetChar(point.y, point.x - 1)))
                nextPoints.Enqueue((point.y, point.x - 1, point.dist + 1));
            break;
        case 'L':
            if (IsLeftConnector(GetChar(point.y, point.x + 1)))
                nextPoints.Enqueue((point.y, point.x + 1, point.dist + 1));
            if (IsBottomConnector(GetChar(point.y - 1, point.x)))
                nextPoints.Enqueue((point.y - 1, point.x, point.dist + 1));
            break;
        case 'J':
            if (IsRightConnector(GetChar(point.y, point.x - 1)))
                nextPoints.Enqueue((point.y, point.x - 1, point.dist + 1));
            if (IsBottomConnector(GetChar(point.y - 1, point.x)))
                nextPoints.Enqueue((point.y - 1, point.x, point.dist + 1));
            break;
        case '7':
            if (IsRightConnector(GetChar(point.y, point.x - 1)))
                nextPoints.Enqueue((point.y, point.x - 1, point.dist + 1));
            if (IsTopConnector(GetChar(point.y + 1, point.x)))
                nextPoints.Enqueue((point.y + 1, point.x, point.dist + 1));
            break;
        case 'F':
            if (IsLeftConnector(GetChar(point.y, point.x + 1)))
                nextPoints.Enqueue((point.y, point.x + 1, point.dist + 1));
            if (IsTopConnector(GetChar(point.y + 1, point.x)))
                nextPoints.Enqueue((point.y + 1, point.x, point.dist + 1));
            break;
    }
}

char GetChar(int y, int x)
{
    if (x < 0 || x >= width || y < 0 || y >= height)
    {
        return '.';
    }

    return grid[y][x];
}

static bool IsBottomConnector(char input) => input is '|' or '7' or 'F';
static bool IsTopConnector(char input) => input is '|' or 'L' or 'J';
static bool IsLeftConnector(char input) => input is '-' or 'J' or '7';
static bool IsRightConnector(char input) => input is '-' or 'L' or 'F';

Console.WriteLine(greatestDistance);
