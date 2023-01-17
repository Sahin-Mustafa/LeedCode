namespace FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCase();

        }

        private static void TestCase()
        {
            Console.WriteLine("Test1");
            int[] data1 = { 1, 2, 3, 4 };
            int response1 = PivotIndex(data1);
            Console.Write($"{response1} ");


            Console.WriteLine("\nTest2");
            int[] data2 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int response2 = PivotIndex(data2);
            Console.Write($"{response2} ");


            Console.WriteLine("\nTest3");
            int[] data3 = { 3, 10, 11, 25, 65, 18, 17, 99 };
            int response3 = PivotIndex(data3);
            Console.Write($"{response3} ");

        }

        private static int PivotIndex(int[] nums)
        {
            int sum = 0, leftSum = 0;
            foreach (int item in nums)
            {
                sum += item;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i]) return i;
                leftSum += nums[i];
            }
            return -1;
        }
    }
}