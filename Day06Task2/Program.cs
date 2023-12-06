//(int time, int distance)[] races = new[] { (7, 9), (15, 40), (30, 200) };
//(long time, long distance)[] races = new[] { ((long)71530, (long)940200) };
(long time, long distance) race = (49877895, 356137815021882);

long solutions = 0;
long lastSolution = 0;
long hold = 0;
while (true)
{
    long currSolution = (race.time - hold) * hold;
    if (currSolution < lastSolution && currSolution < race.distance) break;
    if (currSolution > race.distance) solutions++;
    lastSolution = currSolution;
    hold++;
}

Console.WriteLine(solutions);