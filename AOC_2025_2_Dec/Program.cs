using AOC_2025_2_Dec;

string input = InputData2Dec.input;

string[] ranges = input.Split(',');
long sumOfInvalids = 0;
// Del 1
for (int i = 0; i < ranges.Length; i++)
{
    string startIdString = ranges[i].Split('-')[0];
    string stopIdString = ranges[i].Split('-')[1];
    if (startIdString.Length % 2 == 1 && stopIdString.Length % 2 == 1) continue;

    long startId = long.Parse(startIdString);
    long stopId = long.Parse(stopIdString);

    int span = (int)(stopId - startId);

    for (global::System.Int32 j = 0; j <= span; j++)
    {
        string id = startId.ToString();
        int mid = id.Length / 2;
        string left = id.Substring(0, mid);
        string right = id.Substring(mid);
        if (left == right) sumOfInvalids += startId;
        startId++;
    }
}

Console.WriteLine(sumOfInvalids);
