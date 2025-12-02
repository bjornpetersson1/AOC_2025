using AOC_2025;
using System;
using System.Reflection.Emit;

string input = InputData.input;
string[] inputs = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
int code = 0;
int dialNo = 50;
for (int i = 0; i < inputs.Length; i++)
{
    string ticks = string.Empty;
    string rotation = inputs[i];
    char direction = rotation[0];

    for (global::System.Int32 j = 1; j < rotation.Length; j++)
    {
        ticks += rotation[j];
    }
    int intTicks = int.Parse(ticks);
    
    dialNo = ((dialNo % 100) + 100) % 100;
    int oldValue = dialNo;
    
    if (direction == 'L') dialNo -= intTicks;
    else dialNo += intTicks;
    
    if (dialNo == 0 ) code++;
    else if (dialNo >= 100 )
    {
        int counting = Math.Abs(dialNo / 100);
        code += counting;
    }
    else if (dialNo < 0)
    {
        if (oldValue == 0)
        {
            int counting = Math.Abs(dialNo / 100);
            code += counting;
        }
        else
        {
            int counting = Math.Abs(dialNo / 100);
            code += counting;
            code++;
        }
    }
}

Console.WriteLine(code);





