namespace IsSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCase();
        }
        private static void TestCase()
        {
            bool result = IsSubsequence("abc", "ahbgdc");
            Console.WriteLine($"Test 1: {result}\n----");

            bool result2 = IsSubsequence("axc", "ahbgdc");
            Console.WriteLine($"Test 2: {result2}\n----");

            bool result3 = IsSubsequence("acb", "ahbgdc");
            Console.WriteLine($"Test 3: {result3}\n----");

            bool result4 = IsSubsequence("aaaaaa", "bbaaaa");
            Console.WriteLine($"Test 4: {result4}\n----");
            
            bool result5 = IsSubsequence("", "bbaaaa");
            Console.WriteLine($"Test 5: {result5}\n----");

        }

        private static bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length ) return false;
            if(s.Length == 0) return true;

            int subCount = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (subCount > s.Length - 1) break;

                if ((char)t[i] == (char)s[subCount])
                {
                    subCount++;
                }

            }

            return subCount==s.Length;
        }
    }
}