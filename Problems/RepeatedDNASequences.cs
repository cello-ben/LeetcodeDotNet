namespace LeetcodeDotNet.Problems
{
    internal class RepeatedDNASequences
    {
        public static List<string> FindRepeatedDNASequences(string s)
        {
            Dictionary<string, int> seq = new Dictionary<string, int>();
            List<string> res = new List<string>();

            for (int i = 0; i <= s.Length - 10; i++)
            {
                string substring = s.Substring(i, 10);
                if (!seq.ContainsKey(substring))
                {
                    seq.Add(substring, 1);
                }
                else
                {
                    seq[substring]++;
                }
            }

            foreach (KeyValuePair<string, int> entry in seq)
            {
                if (entry.Value > 1)
                {
                    res.Add(entry.Key);
                }
            }

            return res;
        }
    }
}
