
using System.ComponentModel;
using LeetcodeDotNet.Proble;
using LeetcodeDotNet.Problems;

namespace LeetcodeDotNet
{
    internal class Test
    {
        public static int TestSolutions()
        {
            int totalErrors = 0;

            //Testcases from Leetcode.

            //AreValidParentheses
            (string, bool)[] areValidParenthesesTestCases = [("()", true), ("()[]{}", true), ("(]", false), ("([])", true)];
            
            Console.WriteLine("AreValidParentheses\n");
            foreach ((string testCase, bool expectedResult) testTuple in areValidParenthesesTestCases)
            {
                Console.WriteLine($"Testing \"{testTuple.testCase}\", which should yield {testTuple.expectedResult}.");
                bool res = ValidParentheses.AreValidParentheses(testTuple.testCase);
                if (res != testTuple.expectedResult)
                {
                    Console.Error.WriteLine($"Test failed. Expected: {testTuple.expectedResult} Got: {res}");
                    totalErrors++;
                }
                else
                {
                    Console.WriteLine("Test passed.");
                }
            }
            Console.WriteLine("");

            //IsValidSudoku
            (char[][] testCase, bool)[] isValidSudokuTestCases = [
                ([['5', '3', '.', '.', '7', '.', '.', '.', '.'],
                ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                ['.', '.', '.', '.', '8', '.', '.', '7', '9']
                ], true),

                ([['8', '3', '.', '.', '7', '.', '.', '.', '.'],
                ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                ['.', '.', '.', '.', '8', '.', '.', '7', '9']
                ], false)
            ];

            Console.WriteLine("AreValidParentheses");
            foreach ((char[][] testCase, bool expectedResult) testTuple in isValidSudokuTestCases)
            {
                Console.WriteLine($"Testing [[{new string(testTuple.testCase[0])}]");
                for (int i = 1; i < testTuple.testCase.Length - 1; i++)
                {
                    Console.WriteLine($"\t[{new string(testTuple.testCase[i])}],");
                }
                Console.WriteLine($"\t[{new string(testTuple.testCase[testTuple.testCase.Length - 1])}], which should yield {testTuple.expectedResult}.\"");
                bool res = ValidSudoku.IsValidSudoku(testTuple.testCase);
                if (res != testTuple.expectedResult)
                {
                    Console.Error.WriteLine($"Test FAILED. Expected: {testTuple.expectedResult} Got: {res}");
                    totalErrors++;
                }
                else
                {
                    Console.WriteLine("Test passed.");
                }
            }
            Console.WriteLine("");



            //Pascal's Triangle
            List<List<int>> pascalsTriangleExpectedResult1 = new List<List<int>>();
            pascalsTriangleExpectedResult1.Add(new List<int> { 1 });
            pascalsTriangleExpectedResult1.Add(new List<int> { 1, 1 });
            pascalsTriangleExpectedResult1.Add(new List<int> { 1, 2, 1 });
            pascalsTriangleExpectedResult1.Add(new List<int> { 1, 3, 3, 1 });
            pascalsTriangleExpectedResult1.Add(new List<int> { 1, 4, 6, 4, 1 });

            List<List<int>> pascalsTriangleResult1 = PascalsTriangle.CreatePascalsTriangle(5);
            Console.WriteLine("CreatePascalsTriangle");
            Console.WriteLine("Testing 5, which should yield:");
            PascalsTriangle.PrintPascalsTriangle(pascalsTriangleExpectedResult1);

            bool pascalsTriangleHasError = false;
            for (int i = 0; i < pascalsTriangleExpectedResult1.Count; i++)
            {
                bool _pascalsTriangleHasError = false;
                if (pascalsTriangleExpectedResult1.Count != pascalsTriangleResult1.Count)
                {
                    pascalsTriangleHasError = true;
                    break;
                }
                for (int j = 0; j < pascalsTriangleExpectedResult1[i].Count; j++)
                {
                    if (pascalsTriangleExpectedResult1[i].Count != pascalsTriangleResult1[i].Count || pascalsTriangleExpectedResult1[i][j] != pascalsTriangleResult1[i][j])
                    {
                        _pascalsTriangleHasError = true;
                        break;
                    }
                }
                if (_pascalsTriangleHasError)
                {
                    pascalsTriangleHasError = true;
                    break;
                }
            }

            if (pascalsTriangleHasError)
            {
                Console.WriteLine("Test FAILED. Expected:");
                PascalsTriangle.PrintPascalsTriangle(pascalsTriangleExpectedResult1);
                Console.WriteLine("Got:");
                totalErrors++;

                PascalsTriangle.PrintPascalsTriangle(pascalsTriangleResult1);
            }
            else
            {
                Console.WriteLine("Test passed.");
            }
            pascalsTriangleHasError = false;

            List<List<int>> pascalsTriangleResult2 = PascalsTriangle.CreatePascalsTriangle(1);
            List<List<int>> pascalsTriangleExpectedResult2 = new List<List<int>>();
            pascalsTriangleExpectedResult2.Add(new List<int> { 1 });

            Console.WriteLine("Testing 1, which should yield:");
            PascalsTriangle.PrintPascalsTriangle(pascalsTriangleExpectedResult2);

            if (pascalsTriangleResult2.Count != 1 || pascalsTriangleResult2[0].Count != 1 || pascalsTriangleResult2[0][0] != 1)
            {
                Console.WriteLine("Test FAILED. Expected:");
                PascalsTriangle.PrintPascalsTriangle(pascalsTriangleExpectedResult2);
                Console.WriteLine("Got:");
                PascalsTriangle.PrintPascalsTriangle(pascalsTriangleResult2);
                totalErrors++;
            }
            else
            {
                Console.WriteLine("Test passed.");
            }

            return totalErrors;
        }
    }
}
