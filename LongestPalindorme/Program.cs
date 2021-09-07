using System;

namespace LongestPalindorme
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            string s = "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffgggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg";

            string temp = P.LongestPalindrome(s);
            Console.WriteLine(temp);
            Console.WriteLine(temp.Length);
        }

        public string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }

        //public string LongestPalindrome(string s)
        //{
        //    int len = s.Length;
        //    string lng = "";
        //    for (int i = 0; i < len; i++)
        //    {
        //        for (int j = len; j >= i; j--)
        //        {
        //            if (lng.Length > j - i)
        //            {
        //                break;
        //            }

        //            if ((j - i == 1) || IsPalindrome(s.Substring(i, j - i)))
        //            {
        //                if (j - i > lng.Length)
        //                    lng = s.Substring(i, j - i);
        //                Console.WriteLine("--" + lng.Length + " " + lng);
        //            }
        //        }
        //    }
        //    return lng;
        //}

        //public bool IsPalindrome(string s)
        //{
        //    int len = s.Length;
        //    for (int i = 0; i < len; i++)
        //    {
        //        if (s[i] != s[len - i - 1])
        //            return false;
        //    }
        //    return true;
        //}
    }
}
