using AOC_2025_8_Dec;

List<string> stringPoints = (InputData.inputPoints.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)).ToList();
var points = new HashSet<(int x, int y, int z)>();

foreach (var s in stringPoints)
{
    var coOrds = s.Split(',');
    
    int x = int.Parse(coOrds[0]);
    int y = int.Parse(coOrds[1]);
    int z = int.Parse(coOrds[2]);

    points.Add((x, y, z));
}
Console.WriteLine();