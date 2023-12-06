(int time, int distance)[] races = new[] { (49, 356), (87, 1378), (78, 1502), (95, 1882) };

int multSum = 1;

foreach(var race in races)
{
    int solutions = 0;
    int lastSolution = 0;
    int hold = 0;
    while (true)
    {
        int currSolution = (race.time - hold) * hold;
        if (currSolution < lastSolution && currSolution < race.distance) break;
        if (currSolution > race.distance) solutions++;
        lastSolution = currSolution;
        hold++;
    }
    multSum *= solutions;
}

Console.WriteLine(multSum);