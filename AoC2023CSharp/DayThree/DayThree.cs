namespace AoC2023CSharp.DayThree;

public class DayThree
{
    public static int PartOne(List<string> input)
    {
        for (int y = 0; y < input.Count; y++)
        {
            string currentNumber = "";
            bool validNumber = false;

            string[] chars = input[y].Split();
            for (int x = 0; x < chars.Length; x++)
            {
                string symbol = chars[x];
                
                if (int.TryParse(symbol, out _))
                {
                    currentNumber += symbol;

                    int[,] neighbors = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 }, { -1, -1 }, { -1, 1 }, { 1, -1 }, { 1, 1 } };
                    foreach (int neighbor in neighbors)
                    {
                        int dy = neighbor[0];
                        int dx = neighbor[1];
                        int new_y = y + dy;
                        int new_x = x + dx;

                        if (0 <= new_y && new_y < schematic.GetLength(0) && 0 <= new_x && new_x < schematic.GetLength(1))
                        {
                            valid = valid || IsPart(schematic[new_y, new_x]);
                        }
                    }

                }

                if (symbol == ".")
                {
                    currentNumber = "";
                    validNumber = false;
                }
            }
        }

        return 0;
    }
}