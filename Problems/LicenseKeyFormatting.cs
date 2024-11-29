namespace LeetcodeDotNet.Problems
{
    internal class LicenseKeyFormatting
    {
        public static string FormatLicenseKey(string s, int k)
        {
            string sanitized = "";
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (s[i] != '-')
                {
                    sanitized += s[i].ToString().ToUpper();
                }
            }
            len = sanitized.Length;
            if (len == 0)
            {
                return "";
            }
            List<string> res = new List<String>();
            int offset = len % k;

            if (offset > 0)
            {
                res.Add(sanitized.Substring(0, offset));
                for (int i = 0; i < len / k; i++)
                {
                    res.Add(sanitized.Substring(offset + (i * k), k));
                }
            }
            else
            {
                for (int i = 0; i < len / k; i++)
                {
                    res.Add(sanitized.Substring(i * k, k));
                }
            }
            string ret = "";
            len = res.Count;
            for (int i = 0; i < len - 1; i++)
            {
                ret += res[i] + "-";
            }
            ret += res[len - 1];
            return ret;
        }
    }
}