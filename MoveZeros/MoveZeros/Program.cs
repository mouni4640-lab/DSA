namespace TwoSum_LeetCode
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

            var indices = MoveZeros(nums);
            Console.WriteLine("Indices are: ");
            for (int i = 0; i < indices.Length; i++)
            {
                Console.WriteLine(indices[i]);
            }
        }

        public static int[] MoveZeros(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == 0 && nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }
            return nums;
        }

        /* Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]*/
    }
}
