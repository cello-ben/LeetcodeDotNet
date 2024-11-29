namespace LeetcodeDotNet
{
    internal class Util
    {
        public static string StringifyArray<T>(T[] arr)
        {
            if (arr.Length == 0)
            {
                return "[]";
            }
            else if (arr.Length == 1)
            {
                if (typeof(T) == typeof(string))
                {
                    return $"[\"{arr[0]}\"]";
                }
                return $"[{arr[0]}]";
            }
            string res = "[";
            foreach (T elem in arr)
            {
                if (typeof(T) == typeof(string))
                {
                    res += $"\"{elem}\", ";
                }
                else
                {
                    res += $"{elem}, ";
                }
            }
            res = res.Substring(0, res.Length - 2);
            return res + "]";
        }
        
    }
}
