namespace LeetcodeDotNET.Problems
{
    internal class AddDigits
    {
        public static int RepeatedlyAddDigits(int num)
        {
            while (num >= 10)
            {
                int tmp = num, sum = 0;
                while (tmp > 0)
                {
                    sum += tmp % 10;
                    tmp /= 10;
                }
                num = tmp;
            }
            return num;
        }
    }
}