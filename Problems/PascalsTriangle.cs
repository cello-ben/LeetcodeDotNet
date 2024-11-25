namespace LeetcodeDotNet.Problems
{
    internal class PascalsTriangle
    {
        public static void PrintPascalsTriangle(List<List<int>> triangle)
        {
            foreach (List<int> row in triangle)
            {
                int offset = triangle.Count - row.Count;
                string displayRow = new string(' ', offset);
                foreach (int n in row)
                {
                    displayRow += $"{n} ";
                }
                displayRow += offset > 1 ? new string(' ', offset - 1) : "";
                Console.WriteLine(displayRow);
            }
        }
        public static List<List<int>> CreatePascalsTriangle(int numRows)
        {
            List<List<int>> rows = new List<List<int>>();
            rows.Add(new List<int> { 1 });
            rows.Add(new List<int> { 1, 1 });
            rows.Add(new List<int> { 1, 2, 1 });
            if (numRows < 3)
            {
                return rows[0..numRows];
            }

            for (int i = 3; i < numRows; i++)
            {
                List<int> tmp = new List<int>();
                tmp.Add(1);
                for (int j = 1; j < rows[i - 1].Count; j++)
                {
                    if (j < rows[i - j].Count - 1)
                    {
                        tmp.Add((rows[i - 1][j - 1] + rows[i - 1][j]));
                    }
                    else
                    {
                        tmp.Add(rows[i - 1][j] + rows[i - 1][j - 1]);
                    }
                }

                tmp.Add(1);
                rows.Add(tmp);
            }

            return rows;
        }
    }
}
