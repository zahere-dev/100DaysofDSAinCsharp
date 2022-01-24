namespace _100DaysofDSAinCsharp.src.Day13
{

    public class FindTheDuplicateNumber
    {
        /// <summary>
        /// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
        ///There is only one repeated number in nums, return this repeated number.
        ///You must solve the problem without modifying the array nums and uses only constant extra space.
        /// </summary>
        /// <param name="inputList">[ 3, 1, 3, 4, 2]</param>
        /// <returns>3</returns>
        public static int Find(int[] nums)
        {

            // Find the intersection point of the two runners.
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            //Find the "entrance" to the cycle.
            fast = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return fast;
        }
    }
}
