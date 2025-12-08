using AOC_2025_6_Dec;
using System.Runtime.ConstrainedExecution;
using System.Xml;
//del 1
//string[] rowsOfNumbers = InputData.numbers.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
//string[] numbers0 = rowsOfNumbers[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
//string[] numbers1 = rowsOfNumbers[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
//string[] numbers2 = rowsOfNumbers[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);
//string[] numbers3 = rowsOfNumbers[3].Split(' ', StringSplitOptions.RemoveEmptyEntries);
//string[] operators = InputData.operators.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//long totalSum = 0;

//for (int i = 0; i < operators.Length; i++)
//{
//    long num0 = long.Parse(numbers0[i]);
//    long num1 = long.Parse(numbers1[i]);
//    long num2 = long.Parse(numbers2[i]);
//    long num3 = long.Parse(numbers3[i]);
//    if (operators[i] == "*")
//    {
//        long product = num0 * num1 * num2 * num3;
//        totalSum += product;
//    }
//    else if (operators[i] == "+")
//    {
//        long sum = num0 + num1 + num2 + num3;
//        totalSum += sum;
//    }
//}


//Console.WriteLine(totalSum);

//del 2
//Du räknar från fel håll du ska gå från höger till vänster och dom
    //eller inte, det varierar tydligen, du måste splitta på ett bättre sätt för att få koll på vilken kolumn dom är i
string[] rowsOfNumbers = InputData.numbers.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
string[] numbers0 = rowsOfNumbers[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] numbers1 = rowsOfNumbers[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] numbers2 = rowsOfNumbers[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] numbers3 = rowsOfNumbers[3].Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] operators = InputData.operators.Split(' ', StringSplitOptions.RemoveEmptyEntries);
long totalSum = 0;
List<string> toSortNum = new List<string>();
List<string> sortedNums = new List<string>();
List<string> convertedNums = new List<string>();
List<char> numIinputs = new List<char>();

foreach (var item in InputData.numbers)
{
    numIinputs.Add(item);
}
    //GENOM DET HÄR FINNS LÖSNINGEN

for (int i = 0; i < operators.Length; i++)
{
    toSortNum.Clear();
    convertedNums.Clear();
    string convertedNum = string.Empty;
    long sumProduct = 0;
    toSortNum.Add(numbers0[i]);
    toSortNum.Add(numbers1[i]);
    toSortNum.Add(numbers2[i]);
    toSortNum.Add(numbers3[i]);


    if (operators[i] == "*")
    {
        for (global::System.Int32 j = 0; j < 6; j++)
        {
            convertedNum = string.Empty;
            for (global::System.Int32 k = 0; k < toSortNum.Count; k++)
            {
                if (toSortNum[k].Length > j) convertedNum += toSortNum[k][j];

            }
            if (convertedNum.Length == 0)
            {
                totalSum += sumProduct;
                break;
            }
            else if (j == 0) sumProduct += long.Parse(convertedNum);
            else sumProduct *= long.Parse(convertedNum);
        }
    }
    else if (operators[i] == "+")
    {
        for (global::System.Int32 j = 0; j < 6; j++)
        {
            convertedNum = string.Empty;
            for (global::System.Int32 k = 0; k < toSortNum.Count; k++)
            {
                if (toSortNum[k].Length > j) convertedNum += toSortNum[k][j];

            }
            if (convertedNum.Length == 0)
            {
                totalSum += sumProduct;
                break;
            }
            else sumProduct += long.Parse(convertedNum);
        }
    }
}


Console.WriteLine(totalSum);

