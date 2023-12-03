var sidePaddedInput = Day03Task1.Input.Literal
    .Split("\r\n")
    .Select(line => line.Prepend('.').Append('.').ToArray())
    .ToArray();

var paddedInput = sidePaddedInput
    .Prepend(Enumerable.Range(0, sidePaddedInput.Length).Select(_ => '.').ToArray())
    .Append(Enumerable.Range(0, sidePaddedInput.Length).Select(_ => '.').ToArray())
    .ToArray();

var sum = 0;

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
        if (number.Length is not 0
            && (
            Enumerable.Range(j - number.Length - 1, number.Length + 2).Any(c => paddedInput[i - 1][c] is not '0' and not '1' and not '2' and not '3' and not '4' and not '5' and not '6' and not '7' and not '8' and not '9' and not '.')
            || Enumerable.Range(j - number.Length - 1, number.Length + 2).Any(c => paddedInput[i + 1][c] is not '0' and not '1' and not '2' and not '3' and not '4' and not '5' and not '6' and not '7' and not '8' and not '9' and not '.')
            || paddedInput[i][j] is not '0' and not '1' and not '2' and not '3' and not '4' and not '5' and not '6' and not '7' and not '8' and not '9' and not '.'
            || paddedInput[i][j - number.Length - 1] is not '0' and not '1' and not '2' and not '3' and not '4' and not '5' and not '6' and not '7' and not '8' and not '9' and not '.'
            ))
        {
            sum += int.Parse(number);
        }
    }
}

Console.WriteLine(sum);