using AOC_2025_8_Dec;
//räkna ut avståndet, sortera, koppla ihop, multiplicera top 3 grupper

List<string> stringPoints = (InputData.inputPoints.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)).ToList();
var points = new HashSet<(float x, float y, float z)>();

foreach (var s in stringPoints)
{
    var coOrds = s.Split(',');
    
    float x = float.Parse(coOrds[0]);
    float y = float.Parse(coOrds[1]);
    float z = float.Parse(coOrds[2]);

    points.Add((x, y, z));
}
var results = new HashSet<((float x, float y, float z) p1, (float x, float y, float z) p2, double distance, int group)>();

foreach (var p1 in points)
{
    foreach (var p2 in points)
    {
        double distance = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2) + Math.Pow((p1.z - p2.z), 2));
        if (distance != 0)
        {
            results.Add((p1, p2, distance, 0));
        }
    }
}

var sortedPoints = results.OrderBy(r => r.distance).ToList();
//hitta ett sätt att gruppera :) tänk på om båda punkterna tillhör varsin grupp
Console.WriteLine();