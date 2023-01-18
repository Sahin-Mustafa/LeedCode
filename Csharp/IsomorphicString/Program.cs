using System.Text;

namespace IsomorphicString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCase();

        }

        private static void TestCase()
        {
            //bool result = IsIsomorphic("egg", "add");
            //Console.WriteLine($"Test 1: {result}\n----");


            //bool result2 = IsIsomorphic("foo", "bar");
            //Console.WriteLine($"Test 2: {result2}\n----");

            //bool result3 = IsIsomorphic("paper", "title");
            //Console.WriteLine($"Test 3: {result3}\n----");

            //bool result4 = IsIsomorphic("badc", "baba");
            //Console.WriteLine($"Test 4: {result4}\n----");

            bool result5 = IsIsomorphic("abcdefghijklmnopqrstuvwxyzva", "abcdefghijklmnopqrstuvwxyzck");
            Console.WriteLine($"Test 5: {result5}\n----");

        }

        public static bool IsIsomorphic(string s, string t)
        {
            return Transform(s).Equals(Transform(t));
        }

        private static StringBuilder Transform(string s)
        {
            IDictionary<string, int> match = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!match.ContainsKey(s[i].ToString()))
                {
                    match.Add(new KeyValuePair<string, int>(s[i].ToString(), i));
                }
                sb.Append($"{match[s[i].ToString()]}-");
                
            }
            //sb.ToString();
            Console.WriteLine(sb);
            //foreach (KeyValuePair<string, string> ele in match)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", ele.Key, ele.Value);
            //}
            return sb;
        }
    }
}
