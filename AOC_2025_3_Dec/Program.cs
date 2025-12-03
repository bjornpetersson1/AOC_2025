

using AOC_2025_3_Dec;

string[] inputs = InputData3Dec.input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
long totalJoltage = 0;
//for (int i = 0; i < inputs.Length; i++)
//{
//    string joltage = string.Empty;
//    bool joltageDone = false;
//    for (global::System.Int32 j = 9; j > 0 && !joltageDone; j--)
//    {
//        if (inputs[i].Contains((char)('0' + j)))
//        {
//            if (inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 1)
//            {
//                joltage += (char)('0' + j);
//                int firstIndex = inputs[i].IndexOf((char)('0' + j));
//                string rest = inputs[i].Substring(firstIndex + 1);

//                for (global::System.Int32 k = 9; k >= 0; k--)
//                {
//                    if (rest.Contains((char)('0' + k)))
//                    {
//                        joltage += (char)('0' + k);
//                        totalJoltage += int.Parse(joltage);
//                        joltageDone = true;
//                        break;
//                    }
//                }
//            }
//        }
//    }
//}

//Console.WriteLine(totalJoltage);

for (int i = 0; i < inputs.Length; i++)
{
    string joltage = string.Empty;
    bool joltageDone = false;
    string rest = inputs[i]; 
    for (global::System.Int32 j = 9; j > 0 && !joltageDone; j--)
    {
        if (rest.Contains((char)('0' + j)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 11)
        {
            joltage += (char)('0' + j);
            int Index = rest.IndexOf((char)('0' + j));
            rest = rest.Substring(Index + 1);

            for (global::System.Int32 k = 9; k >= 0 && !joltageDone; k--)
            {
                if (rest.Contains((char)('0' + k)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 10)
                {
                    joltage += (char)('0' + k);
                    Index = rest.IndexOf((char)('0' + k));
                    rest = rest.Substring(Index + 1);

                    for (global::System.Int32 l = 9; l >= 0 && !joltageDone; l--)
                    {
                        if (rest.Contains((char)('0' + l)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 9)
                        {
                            joltage += (char)('0' + l);
                            Index = rest.IndexOf((char)('0' + l));
                            rest = rest.Substring(Index + 1);

                            for (global::System.Int32 m = 9; m >= 0 && !joltageDone; m--)
                            {
                                if (rest.Contains((char)('0' + m)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 8)
                                {
                                    joltage += (char)('0' + m);
                                    Index = rest.IndexOf((char)('0' + m));
                                    rest = rest.Substring(Index + 1);

                                    for (global::System.Int32 n = 9; n >= 0 && !joltageDone; n--)
                                    {
                                        if (rest.Contains((char)('0' + n)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 7)
                                        {
                                            joltage += (char)('0' + n);
                                            Index = rest.IndexOf((char)('0' + n));
                                            rest = rest.Substring(Index + 1);

                                            for (global::System.Int32 o = 9; o >= 0 && !joltageDone; o--)
                                            {
                                                if (rest.Contains((char)('0' + o)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 6)
                                                {
                                                    joltage += (char)('0' + o);
                                                    Index = rest.IndexOf((char)('0' + o));
                                                    rest = rest.Substring(Index + 1);

                                                    for (global::System.Int32 p = 9; p >= 0 && !joltageDone; p--)
                                                    {
                                                        if (rest.Contains((char)('0' + p)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 5)
                                                        {
                                                            joltage += (char)('0' + p);
                                                            Index = rest.IndexOf((char)('0' + p));
                                                            rest = rest.Substring(Index + 1);

                                                            for (global::System.Int32 q = 9; q >= 0 && !joltageDone; q--)
                                                            {
                                                                if (rest.Contains((char)('0' + q)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 4)
                                                                {
                                                                    joltage += (char)('0' + q);
                                                                    Index = rest.IndexOf((char)('0' + q));
                                                                    rest = rest.Substring(Index + 1);

                                                                    for (global::System.Int32 r = 9; r >= 0 && !joltageDone; r--)
                                                                    {
                                                                        if (rest.Contains((char)('0' + r)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 3)
                                                                        {
                                                                            joltage += (char)('0' + r);
                                                                            Index = rest.IndexOf((char)('0' + r));
                                                                            rest = rest.Substring(Index + 1);

                                                                            for (global::System.Int32 s = 9; s >= 0 && !joltageDone; s--)
                                                                            {
                                                                                if (rest.Contains((char)('0' + s)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 2)
                                                                                {
                                                                                    joltage += (char)('0' + s);
                                                                                    Index = rest.IndexOf((char)('0' + s));
                                                                                    rest = rest.Substring(Index + 1);

                                                                                    for (global::System.Int32 t = 9; t >= 0 && !joltageDone; t--)
                                                                                    {
                                                                                        if (rest.Contains((char)('0' + t)) && inputs[i].IndexOf((char)('0' + j)) < inputs[i].Length - 1)
                                                                                        {
                                                                                            joltage += (char)('0' + t);
                                                                                            Index = rest.IndexOf((char)('0' + t));
                                                                                            rest = rest.Substring(Index + 1);

                                                                                            for (global::System.Int32 x = 9; x >= 0; x--)
                                                                                            {
                                                                                                if (rest.Contains((char)('0' + x)))
                                                                                                {
                                                                                                    joltage += (char)('0' + x);
                                                                                                    totalJoltage += long.Parse(joltage);
                                                                                                    joltageDone = true;
                                                                                                    break;
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

Console.WriteLine(totalJoltage);

