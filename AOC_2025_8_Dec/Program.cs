using AOC_2025_8_Dec;
using System.Drawing;
//räkna ut avståndet, sortera, koppla ihop, multiplicera top 3 grupper

    //allt hamnar i samma grupp nu.. måste läsa igenom uppgiften igen, måste ha missat någon parameter

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
var results = new HashSet<((float x, float y, float z) p1, (float x, float y, float z) p2, double distance)>();

foreach (var p1 in points)
{
    foreach (var p2 in points)
    {
        double distance = Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2) + Math.Pow((p1.z - p2.z), 2));
        if (distance != 0)
        {
            results.Add((p1, p2, distance));
        }
    }
}

var sortedPoints = results.OrderBy(r => r.distance).ToList();
var groupedPoints = new Dictionary<(float x, float y, float z), int>();
int group = 1;
foreach (var s in sortedPoints)
{
    if(groupedPoints.TryGetValue(s.p1, out int point1Group) && !groupedPoints.TryGetValue(s.p2, out int point2Group))
    {
        groupedPoints.Add(s.p2, point1Group);
    }
    else if (!groupedPoints.TryGetValue(s.p1, out int point3Group) && groupedPoints.TryGetValue(s.p2, out int point4Group))
    {
        groupedPoints.Add(s.p1, point4Group);
    }
    else if (groupedPoints.TryGetValue(s.p1, out int point5Group) && groupedPoints.TryGetValue(s.p2, out int point6Group))
    {
        if (point5Group != point6Group)
        {
            int size1 = CountGroupMembers(point5Group);
            int size2 = CountGroupMembers(point6Group);

            int targetGroup;
            int sourceGroup;

            if (size1 >= size2)
            {
                targetGroup = point5Group;   
                sourceGroup = point6Group;   
            }
            else
            {
                targetGroup = point6Group;
                sourceGroup = point5Group;
            }

            var keysToMove = groupedPoints
                .Where(p => p.Value == sourceGroup)
                .Select(p => p.Key)
                .ToList();

            foreach (var key in keysToMove)
            {
                groupedPoints[key] = targetGroup;
            }
        }
    }
    else
    {
        groupedPoints.Add(s.p1, group);
        groupedPoints.Add(s.p2, group);
        group++;
    }
}
Console.WriteLine();

int CountGroupMembers(int groupId)
{
    return groupedPoints.Count(p => p.Value == groupId);
}
