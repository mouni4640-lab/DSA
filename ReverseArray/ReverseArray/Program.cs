namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array with spaces:");
            string input = Console.ReadLine();

            // Convert the input string into an array of integers
            int[] nums = input.Split(' ') // Split by spaces
                                 .Select(int.Parse) // Convert each part to an integer
                                 .ToArray();

            var indices = ReverseArray(nums);
            Console.WriteLine("Result: ");
            for (int i = 0; i < indices.Length; i++)
            {
                Console.WriteLine(indices[i]);
            }
        }

        public static int[] ReverseArray(int[] nums)
        {
            for (int i = 0; i < nums.Length/2; i++)
            {
                int j = nums.Length-1 - i;
                int item = nums[i];
                    nums[i] = nums[j];
                    nums[j] = item;
            
            }
            return nums;
        }
    }
}
