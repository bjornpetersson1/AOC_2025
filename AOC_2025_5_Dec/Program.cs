using AOC_2025_5_Dec;
//del 1
//string[] ingridients = InputData.inputIngridients.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
//string[] freshSpan = InputData.inputFreshSpan.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
//long[,] freshSpanSplit = new long[freshSpan.Length, 2];
//int freshIngridients = 0;

//for (int i = 0; i < freshSpan.Length; i++)
//{
//    string[] startStop = freshSpan[i].Split('-');
//    freshSpanSplit[i, 0] = long.Parse(startStop[0]);
//    freshSpanSplit[i, 1] = long.Parse(startStop[1]);
//}
//for (int i = 0; i < ingridients.Length; i++)
//{
//    long longIngridient = long.Parse(ingridients[i]);
//    for (global::System.Int32 j = 0; j < freshSpan.Length; j++)
//    {
//        if (longIngridient >= freshSpanSplit[j, 0] && longIngridient <= freshSpanSplit[j, 1])
//        {
//            freshIngridients++;
//            break;
//        }
//    }
//}
//Console.WriteLine(freshIngridients);

//del 2
//Kolla vilket spann det är, spara start och stop, koll nästa om överlappar ändra start eller stoppvärde, om utanför range skapa en ny :)
//Räkna sen ihop allas spann
string[] ingridients = InputData.inputIngridients.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
string[] freshSpan = InputData.inputFreshSpan.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
long[,] freshSpanSplit = new long[freshSpan.Length, 2];
int freshIngridients = 0;

for (int i = 0; i < freshSpan.Length; i++)
{
    string[] startStop = freshSpan[i].Split('-');
    freshSpanSplit[i, 0] = long.Parse(startStop[0]);
    freshSpanSplit[i, 1] = long.Parse(startStop[1]);
}
for (int i = 0; i < ingridients.Length; i++)
{
    long longIngridient = long.Parse(ingridients[i]);
    for (global::System.Int32 j = 0; j < freshSpan.Length; j++)
    {
        if (longIngridient >= freshSpanSplit[j, 0] && longIngridient <= freshSpanSplit[j, 1])
        {
            freshIngridients++;
            break;
        }
    }
}
Console.WriteLine(freshIngridients);