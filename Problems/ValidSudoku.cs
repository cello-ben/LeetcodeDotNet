namespace LeetcodeDotNet.Proble
{
    internal class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> colFound = new HashSet<char>();
                HashSet<char> rowFound = new HashSet<char>();

                for (int j = 0; j < 9; j++)
                {
                    if (colFound.Contains(board[j][i]) || rowFound.Contains(board[i][j]))
                    {
                        return false;
                    }
                    if (board[j][i] != '.')
                    {
                        colFound.Add(board[j][i]);
                    }
                    if (board[i][j] != '.')
                    {
                        rowFound.Add(board[i][j]);
                    }
                }
            }

            int[][] boxes = [
                    [0, 0],
                    [0, 3],
                    [0, 6],
                    [3, 3],
                    [3, 6],
                    [6, 0],
                    [6, 3],
                    [6, 6]
                ];

            foreach (int[] box in boxes)
            {
                HashSet<char> colFound = new HashSet<char>();
                HashSet<char> rowFound = new HashSet<char>();

                for (int i = box[0]; i < box[0] + 3; i++)
                {
                    for (int j = box[1]; j < box[1] + 3; j++)
                    {
                        if (colFound.Contains(board[j][i]) || rowFound.Contains(board[i][j]))
                        {
                            return false;
                        }
                        if (board[j][i] != '.')
                        {
                            colFound.Add(board[j][i]);
                        }
                        if (board[i][j] != '.')
                        {
                            rowFound.Add(board[i][j]);
                        }
                    }
                }
            }
            

            return true;
        }
    }
}
