namespace LeetcodeDotNet.Problems
{
    internal class ValidAnagram
    {
        public static bool IsValidAnagram(string s, string t) {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> d1 = new Dictionary<char, int>();
            Dictionary<char, int> d2 = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d1.ContainsKey(s[i]))
                {
                    d1[s[i]]++;
                }
                else
                {
                    d1.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (d2.ContainsKey(t[i]))
                {
                    d2[t[i]]++;
                }
                else
                {
                    d2.Add(t[i], 1);
                }
            }
            foreach (KeyValuePair<char, int> pair in d1)
            {
                if (!d2.ContainsKey(pair.Key))
                {
                    return false;
                }
                if (d2[pair.Key] != pair.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}