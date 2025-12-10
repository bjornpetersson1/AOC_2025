// Del 1
using AOC_2025_7_Dec;

List<string> rowsOfTree = (InputData.christmasTree.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)).ToList();
List<int> cascadeIndex = new List<int>();
int count = 0;
List<char> futureChars = new List<char>();
List<char> currentChars = new List<char>();
int splitCount = 0;
for (int i = 0; i < rowsOfTree.Count; i++)
{
    futureChars.Add('.');
}
foreach (var c in rowsOfTree[0])
{
    currentChars.Add(c);
}
for (int i = 0; i < rowsOfTree.Count - 1; i++)
{
    count = 0;
    cascadeIndex.Clear();
    foreach (var c in currentChars)
    {
        if (c == 'S')
        {
            cascadeIndex.Add(count);
        }
        count++;
    }
    for (global::System.Int32 j = 0; j < rowsOfTree[i].Length; j++)
    {
        if (cascadeIndex.Contains(j))
        {
            if (rowsOfTree[i + 1][j] == '^')
            {
                futureChars[j - 1] = 'S';
                futureChars[j] = '^';
                futureChars[j + 1] = 'S';
                j++;
                splitCount++;
            }
            else
            {
                futureChars[j] = 'S';
            }
        }
        else futureChars[j] = '.';
    }
    foreach (var s in cascadeIndex)
    {
    }

    currentChars.Clear();
    foreach (var c in futureChars)
    {
        currentChars.Add(c);
    }
}
Console.WriteLine(splitCount);