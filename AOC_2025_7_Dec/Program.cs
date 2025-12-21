// Del 1
using AOC_2025_7_Dec;
using System.Numerics;

//List<string> rowsOfTree = (InputData.christmasTree.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)).ToList();
//List<int> cascadeIndex = new List<int>();
//int count = 0;
//List<char> futureChars = new List<char>();
//List<char> currentChars = new List<char>();
//int splitCount = 0;
//for (int i = 0; i < rowsOfTree.Count; i++)
//{
//    futureChars.Add('.');
//}
//foreach (var c in rowsOfTree[0])
//{
//    currentChars.Add(c);
//}
//for (int i = 0; i < rowsOfTree.Count - 1; i++)
//{
//    count = 0;
//    cascadeIndex.Clear();
//    foreach (var c in currentChars)
//    {
//        if (c == 'S')
//        {
//            cascadeIndex.Add(count);
//        }
//        count++;
//    }
//    for (global::System.Int32 j = 0; j < rowsOfTree[i].Length; j++)
//    {
//        if (cascadeIndex.Contains(j))
//        {
//            if (rowsOfTree[i + 1][j] == '^')
//            {
//                futureChars[j - 1] = 'S';
//                futureChars[j] = '^';
//                futureChars[j + 1] = 'S';
//                j++;
//                splitCount++;
//            }
//            else
//            {
//                futureChars[j] = 'S';
//            }
//        }
//        else futureChars[j] = '.';
//    }
//    foreach (var s in cascadeIndex)
//    {
//    }

//    currentChars.Clear();
//    foreach (var c in futureChars)
//    {
//        currentChars.Add(c);
//    }
//}
//Console.WriteLine(splitCount);



//Del två

// räkna hur många strålar som åker genom en specifik punkt och spara det istället för att hålla på och jämnföra strängar
// summera sen antalet på sista raden :)

List<string> rowsOfTree = (InputData.christmasTree
            .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
            .ToList();

int height = rowsOfTree.Count;
int width = rowsOfTree[0].Length;

BigInteger[,] possiblePaths = new BigInteger[height, width];


for (int x = 0; x < width; x++)
{
    if (rowsOfTree[0][x] == 'S')
        possiblePaths[0, x] = 1;
}

for (int y = 0; y < height - 1; y++)
{
    for (int x = 0; x < width; x++)
    {
        if (possiblePaths[y, x] == 0) continue;

        char below = rowsOfTree[y + 1][x];

        if (below == '^')
        {
            if (x > 0) possiblePaths[y + 1, x - 1] += possiblePaths[y, x];
            if (x < width - 1) possiblePaths[y + 1, x + 1] += possiblePaths[y, x];
        }
        else
        { 
            possiblePaths[y + 1, x] += possiblePaths[y, x];
        }
    }
}

BigInteger total = 0;
for (int x = 0; x < width; x++)
    total += possiblePaths[height - 1, x];

Console.WriteLine(total);













