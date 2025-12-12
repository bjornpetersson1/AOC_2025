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

    // du måste hitta ett sätt att mergea S
    //..SSS..
    //.S^S^S.  <-Det egdecaset

//Kanske gå en annan väg, räkna en väg åt gången?
    //först alla till vänster, sista höger, näst sista höger -> sista höger + vänster

//Splitnivåer är på jämna rader
    //Kolla om det splittar
        //gå vänster till slut
        //gå upp en från slutet, gå höger
            //kolla om det splittar ner mot botten
                //gå vänster 
                //gå höger

List<string> rowsOfTree = (InputData.christmasTree.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)).ToList();
List<int> cascadeIndex = new List<int>();
int count = 0;
List<char> futureChars = new List<char>();
List<char> currentChars = new List<char>();
int splitCount = 1;
BigInteger possibleWays = BigInteger.Zero;
List<int> sCount = new List<int>();


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

    sCount.Clear();
    int activeWays = 0;
    for (global::System.Int32 j = 0; j < currentChars.Count; j++)
    {
        if (i == 0 && currentChars[j] == 'S') activeWays++; 
        else if (i != 0)
        {
            bool leftIsSplitter = j > 0 && currentChars[j - 1] == '^';
            bool rightIsSplitter = j < currentChars.Count - 1 && currentChars[j + 1] == '^';
            if (currentChars[j] == 'S' && (leftIsSplitter || rightIsSplitter))
            {
                activeWays++;
            }
        }

    }
    currentChars.Clear();
    foreach (var c in futureChars)
    {
        currentChars.Add(c);
    }

    if (i == 0) possibleWays = activeWays;
    else if (i % 2 == 0) possibleWays *= activeWays;
}
Console.WriteLine(splitCount);