using AOC_2025_4_Dec;

//Del 1
//string[] inputRows = InputData.input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

//int rowsCount = inputRows.Length;
//int colsCount = inputRows[0].Length;

//char[,] inputRowsAndColums = new char[rowsCount, colsCount];

//for (int i = 0; i < rowsCount; i++)
//{
//    for (int j = 0; j < colsCount; j++)
//    {
//        inputRowsAndColums[i, j] = inputRows[i][j];
//    }
//}
//int accessablePapers = 0;
//for (int i = 0; i < rowsCount; i++)
//{
//    for (global::System.Int32 j = 0; j < colsCount; j++)
//    {
//        if (inputRowsAndColums[i, j] != '@') continue;
//        int paperCount = 0;
//        if (i == 0 && j == 0)
//        {
//            if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 2; k++)
//            {
//                if (inputRowsAndColums[i + 1, j + k] == '@') paperCount++;
//            }
//        }
//        else if (i == 0 && j == colsCount - 1)
//        {
//            if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 2; k++)
//            {
//                if (inputRowsAndColums[i + 1, j - 1 + k] == '@') paperCount++;
//            }
//        }
//        else if (i == rowsCount - 1 && j == 0)
//        {
//            if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 2; k++)
//            {
//                if (inputRowsAndColums[i - 1, j + k] == '@') paperCount++;
//            }
//        }
//        else if (i == rowsCount - 1 && j == colsCount - 1)
//        {
//            if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 2; k++)
//            {
//                if (inputRowsAndColums[i - 1, j - 1 + k] == '@') paperCount++;
//            }
//        }
//        else if (i == 0)
//        {
//            if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
//            if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 3; k++)
//            {
//                if (inputRowsAndColums[i + 1, j - 1 + k] == '@') paperCount++;
//            }
//        }
//        else if (i == rowsCount -1)
//        {
//            if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
//            if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 3; k++)
//            {
//                if (inputRowsAndColums[i - 1, j - 1 + k] == '@') paperCount++;
//            }
//        }
//        else if (j == 0)
//        {
//            if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 2; k++)
//            {
//                if (inputRowsAndColums[i - 1, j + k] == '@') paperCount++;
//                if (inputRowsAndColums[i + 1, j + k] == '@') paperCount++;
//            }
//        }
//        else if (j == colsCount - 1)
//        {
//            if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 2; k++)
//            {
//                if (inputRowsAndColums[i - 1, j - k] == '@') paperCount++;
//                if (inputRowsAndColums[i + 1, j - k] == '@') paperCount++;
//            }
//        }
//        else
//        {
//            if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
//            if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
//            for (global::System.Int32 k = 0; k < 3; k++)
//            {
//                if (inputRowsAndColums[i - 1, j - 1 + k] == '@') paperCount++;
//                if (inputRowsAndColums[i + 1, j - 1 + k] == '@') paperCount++;
//            }
//        }
//        if (paperCount < 4) accessablePapers++;
//    }
//}

//Console.WriteLine(accessablePapers);

//del 2

string[] inputRows = InputData.input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

int rowsCount = inputRows.Length;
int colsCount = inputRows[0].Length;

char[,] inputRowsAndColums = new char[rowsCount, colsCount];

for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < colsCount; j++)
    {
        inputRowsAndColums[i, j] = inputRows[i][j];
    }
}
int accessablePapers = 0;
int accPapThisRound = 0;
do
{
    accPapThisRound = 0;
    for (int i = 0; i < rowsCount; i++)
    {
        for (global::System.Int32 j = 0; j < colsCount; j++)
        {
            if (inputRowsAndColums[i, j] != '@') continue;
            int paperCount = 0;
            if (i == 0 && j == 0)
            {
                if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 2; k++)
                {
                    if (inputRowsAndColums[i + 1, j + k] == '@') paperCount++;
                }
            }
            else if (i == 0 && j == colsCount - 1)
            {
                if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 2; k++)
                {
                    if (inputRowsAndColums[i + 1, j - 1 + k] == '@') paperCount++;
                }
            }
            else if (i == rowsCount - 1 && j == 0)
            {
                if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 2; k++)
                {
                    if (inputRowsAndColums[i - 1, j + k] == '@') paperCount++;
                }
            }
            else if (i == rowsCount - 1 && j == colsCount - 1)
            {
                if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 2; k++)
                {
                    if (inputRowsAndColums[i - 1, j - 1 + k] == '@') paperCount++;
                }
            }
            else if (i == 0)
            {
                if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
                if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 3; k++)
                {
                    if (inputRowsAndColums[i + 1, j - 1 + k] == '@') paperCount++;
                }
            }
            else if (i == rowsCount - 1)
            {
                if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
                if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 3; k++)
                {
                    if (inputRowsAndColums[i - 1, j - 1 + k] == '@') paperCount++;
                }
            }
            else if (j == 0)
            {
                if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 2; k++)
                {
                    if (inputRowsAndColums[i - 1, j + k] == '@') paperCount++;
                    if (inputRowsAndColums[i + 1, j + k] == '@') paperCount++;
                }
            }
            else if (j == colsCount - 1)
            {
                if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 2; k++)
                {
                    if (inputRowsAndColums[i - 1, j - k] == '@') paperCount++;
                    if (inputRowsAndColums[i + 1, j - k] == '@') paperCount++;
                }
            }
            else
            {
                if (inputRowsAndColums[i, j - 1] == '@') paperCount++;
                if (inputRowsAndColums[i, j + 1] == '@') paperCount++;
                for (global::System.Int32 k = 0; k < 3; k++)
                {
                    if (inputRowsAndColums[i - 1, j - 1 + k] == '@') paperCount++;
                    if (inputRowsAndColums[i + 1, j - 1 + k] == '@') paperCount++;
                }
            }
            if (paperCount < 4)
            {
                accessablePapers++;
                accPapThisRound++;
                inputRowsAndColums[i, j] = '.';
            }
        }
    }
}
while (accPapThisRound != 0);

Console.WriteLine(accessablePapers);