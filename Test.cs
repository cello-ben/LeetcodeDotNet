
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
            
            Console.WriteLine("AreValidParentheses");
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
            Console.Write("\n");

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

            Console.WriteLine("IsValidSudoku");
            foreach ((char[][] testCase, bool expectedResult) testTuple in isValidSudokuTestCases)
            {
                Console.WriteLine($"Testing [[{new string(testTuple.testCase[0])}]");
                for (int i = 1; i < testTuple.testCase.Length - 1; i++)
                {
                    Console.WriteLine($"\t[{new string(testTuple.testCase[i])}],");
                }
                Console.WriteLine($"\t[{new string(testTuple.testCase[testTuple.testCase.Length - 1])}], which should yield {testTuple.expectedResult}.");
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
            Console.Write("\n");



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
                Console.Error.WriteLine("Test FAILED. Expected:");
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
                Console.Error.WriteLine("Test FAILED. Expected:");
                PascalsTriangle.PrintPascalsTriangle(pascalsTriangleExpectedResult2);
                Console.WriteLine("Got:");
                PascalsTriangle.PrintPascalsTriangle(pascalsTriangleResult2);
                totalErrors++;
            }
            else
            {
                Console.WriteLine("Test passed.");
            }
            Console.Write("\n");

            Console.WriteLine("FindRepeatedDNASequences");
            Console.WriteLine("Testing \"AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT\", which should yield: [\"AAAAACCCCC\", \"CCCCCAAAAA\"]");
            List<string> dnaSequenceResult1 = RepeatedDNASequences.FindRepeatedDNASequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");

            if (dnaSequenceResult1.Count != 2 || dnaSequenceResult1[0] != "AAAAACCCCC" || dnaSequenceResult1[1] != "CCCCCAAAAA")
            {
                Console.Error.Write("Test FAILED. Expected: [\"AAAAACCCCC\", \"CCCCCAAAAA\"] Got: [");
                for (int i = 0; i < dnaSequenceResult1.Count - 1; i++)
                {
                    Console.Error.Write("\"" + dnaSequenceResult1[i] + "\"" + ", ");
                }
                if (dnaSequenceResult1.Count > 0)
                {
                    Console.Error.Write("\"" + dnaSequenceResult1.Last() + "\"");
                }
                Console.Error.Write("]\n");
            }
            else
            {
                Console.WriteLine("Test passed.");
            }
            Console.Write("\n");

            Console.WriteLine("HammingWeight");
            (int, int)[] hammingWeightTestCases = [(11, 3), (128, 1), (2147483645, 30)];
            foreach ((int testCase, int expectedResult) testTuple in hammingWeightTestCases)
            {
                Console.WriteLine($"Testing {testTuple.testCase}, which should yield {testTuple.expectedResult}.");
                int res = NumberOf1Bits.HammingWeight(testTuple.testCase);
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
            Console.Write("\n");

            Console.WriteLine("IsHappyNumber");
            (int, bool)[] happyNumberTestCases = [(19, true), (2, false)];
            foreach ((int testCase, bool expectedResult) testTuple in happyNumberTestCases)
            {
                Console.WriteLine($"Testing {testTuple.testCase}, which should yield {testTuple.expectedResult}.");
                bool res = HappyNumber.IsHappyNumber(testTuple.testCase);
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
            Console.Write("\n");
            
            Console.WriteLine("IsValidAnagram");
            (string, string, bool)[] validAnagramTestCases = [("anagram", "nagaram", true), ("rat", "car", false)];
            foreach ((string word1, string word2, bool expectedResult) testTuple in validAnagramTestCases)
            {
                Console.WriteLine($"Testing {testTuple.word1} and {testTuple.word2}, which should yield {testTuple.expectedResult}.");
                bool res = ValidAnagram.IsValidAnagram(testTuple.word1, testTuple.word2);
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
            Console.Write("\n");

            Console.WriteLine("RepeatedlyAddDigits");
            (int, int)[] repeatedlyAddDigitsTestCases = [(38, 2), (0, 0)];
            foreach ((int testCase, int expectedResult) testTuple in repeatedlyAddDigitsTestCases)
            {
                Console.WriteLine($"Testing {testTuple.testCase}, which should yield {testTuple.expectedResult}.");
                int res = AddDigits.RepeatedlyAddDigits(testTuple.testCase);
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
            Console.Write("\n");

            Console.WriteLine("MyQueue");
            Console.WriteLine("Testing Push(1), Push(2), Peek, Pop, Empty, which should yield: [1], [2], 2, 2, false.");
            MyQueue queue = new MyQueue();
            queue.Push(1);
            queue.Push(2);
            bool queueHasError = false;
            List<int> stack = queue.GetStack();
            if (stack.Count != 2 || stack[0] != 1 || stack[1] != 2)
            {
                queueHasError = true;
            }
            int n = queue.Peek();
            if (n != 1)
            {
                queueHasError = true;
            }
            n = queue.Pop();
            if (n != 1)
            {
                queueHasError = true;
            }
            if (queue.Empty())
            {
                queueHasError = true;
            }
            if (queueHasError)
            {
                Console.WriteLine($"Test FAILED."); //TODO Expand
            }
            else
            {
                Console.WriteLine("Test passed.");
            }
            Console.Write("\n");

            //TODO Learn if/why <string> necessary.
            //Console.WriteLine(Util.StringifyArray<string>(new string[] {"Hello", "Goodbye"}));

            Console.WriteLine("FormatLicenseKey");
            (string, int, string)[] formatLicenseKeyTestCases = [("5F3Z-2e-9-w", 4, "5F3Z-2E9W"), ("2-5g-3-J", 2, "2-5G-3J")];
            foreach ((string key, int k, string expectedResult) testTuple in formatLicenseKeyTestCases)
            {
                Console.WriteLine($"Testing key = \"{testTuple.key}\", k = {testTuple.k}, which should yield \"{testTuple.expectedResult}\".");
                string res = LicenseKeyFormatting.FormatLicenseKey(testTuple.key, testTuple.k);
                if (res != testTuple.expectedResult)
                {
                    Console.WriteLine($"Test FAILED. Expected: {testTuple.expectedResult} Got: {res}");
                }
                else
                {
                    Console.WriteLine("Test passed.");
                }
            }

            Console.Write("\n");
            
            return totalErrors;
        }
    }
}
