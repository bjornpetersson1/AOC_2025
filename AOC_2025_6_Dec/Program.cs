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
string[] rowsOfNumbers = InputData.numbers.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
string[] operators = InputData.operators.Split(' ', StringSplitOptions.RemoveEmptyEntries);
long totalSum = 0;
List<string> convertedNums = new List<string>();
List<string> num0inputs = new List<string>();
List<string> num1inputs = new List<string>();
List<string> num2inputs = new List<string>();
List<string> num3inputs = new List<string>();

string numWithPlacement = string.Empty;
string convertedNum = string.Empty;

List<char> operatorInputs = new List<char>();
List<int> splitIndexes = new List<int>();
int splitIndex = 0;

foreach (var o in InputData.operators)
{
    if (o != ' ')
    {
        splitIndexes.Add(splitIndex);
        splitIndex++;
    }
    else splitIndex++;
}

for (global::System.Int32 j = 0; j < splitIndexes.Count; j++)
{
    if (j == splitIndexes.Count - 1)
    {
        num0inputs.Add(rowsOfNumbers[0].Substring(splitIndexes[j]));
        num1inputs.Add(rowsOfNumbers[1].Substring(splitIndexes[j]));
        num2inputs.Add(rowsOfNumbers[2].Substring(splitIndexes[j]));
        num3inputs.Add(rowsOfNumbers[3].Substring(splitIndexes[j]));
    }
    else
    {
        num0inputs.Add(rowsOfNumbers[0].Substring(splitIndexes[j], splitIndexes[j + 1] - splitIndexes[j]));
        num1inputs.Add(rowsOfNumbers[1].Substring(splitIndexes[j], splitIndexes[j + 1] - splitIndexes[j]));
        num2inputs.Add(rowsOfNumbers[2].Substring(splitIndexes[j], splitIndexes[j + 1] - splitIndexes[j]));
        num3inputs.Add(rowsOfNumbers[3].Substring(splitIndexes[j], splitIndexes[j + 1] - splitIndexes[j]));
    }
}

for (int i = 0; i < operators.Length; i++)
{
    convertedNums.Clear();
    if (operators[i] == "*")
    {
        for (global::System.Int32 j = 0; j < num0inputs[i].Length; j++)
        {
            convertedNum = string.Empty;
            convertedNum += num0inputs[i][j];
            convertedNum += num1inputs[i][j];
            convertedNum += num2inputs[i][j];
            convertedNum += num3inputs[i][j];
            convertedNums.Add(convertedNum.Trim());
        }
        convertedNums.RemoveAll(s => string.IsNullOrWhiteSpace(s));
        long product = 0;
        for (global::System.Int32 j = 0; j < convertedNums.Count; j++)
        {
            if (j == 0) product = long.Parse(convertedNums[j]);
            else product *= long.Parse(convertedNums[j]);
        }
        totalSum += product;
    }
    else if (operators[i] == "+")
    {
        for (global::System.Int32 j = 0; j < num0inputs[i].Length; j++)
        {
            convertedNum = string.Empty;
            convertedNum += num0inputs[i][j];
            convertedNum += num1inputs[i][j];
            convertedNum += num2inputs[i][j];
            convertedNum += num3inputs[i][j];
            convertedNums.Add(convertedNum.Trim());
        }
        convertedNums.RemoveAll(s => string.IsNullOrWhiteSpace(s));
        long sum = 0;
        for (global::System.Int32 j = 0; j < convertedNums.Count; j++)
        {
            sum += long.Parse(convertedNums[j]);
        }
            totalSum += sum;
    }
}

Console.WriteLine(totalSum);

