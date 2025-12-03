

using AOC_2025_3_Dec;

string[] inputs = InputData3Dec.input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
int totalJoltage = 0;
for (int i = 0; i < inputs.Length; i++)
{
    string joltage = string.Empty;
    bool joltageDone = false;
    for (global::System.Int32 j = 9; j > 0 && !joltageDone; j--)
    {
        if (inputs[i].Contains((char)('0' + j)))
        {
            if (inputs[i].IndexOf((char)('0' + j)) != inputs[i].Length - 1)
            {
                joltage += (char)('0' + j);
                int firstIndex = inputs[i].IndexOf((char)('0' + j));
                string rest = inputs[i].Substring(firstIndex + 1);

                for (global::System.Int32 k = 9; k >= 0; k--)
                {
                    if (rest.Contains((char)('0' + k)))
                    {
                        joltage += (char)('0' + k);
                        totalJoltage += int.Parse(joltage);
                        joltageDone = true;
                        break;
                    }
                }
            }
        }
    }
}

Console.WriteLine(totalJoltage);