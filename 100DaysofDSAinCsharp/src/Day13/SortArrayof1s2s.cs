namespace _100DaysofDSAinCsharp.src.Day13
{
    public class SortArrayof1s2s
    {
        /// <summary>
        /// Dutch National Flag Algorithm
        /// </summary>
        /// <param name="nums">[1, 1, 0, 0, 1, 1, 2, 2, 0, 1]</param>
        /// <returns>[0,0,0,1,1,1,1,1,2,2]</returns>
        public static int[] SortColors(int[] nums)
        {
            //Keep three indices low = 1, mid = 1 and high = N and there are four ranges,            
            //1 to low(the range containing 0),
            int lo = 0;
            //low to mid(the range containing 1),            
            int mid = 0;
            //mid to high(the range containing unknown elements)
            //high to N(the range containing 2)
            int hi = nums.Length - 1;

            int temp = 0;

            //Traverse the array from start to end and mid is less than or equal to high. (Loop counter is i)
            while (mid <= hi)
            {
                //If the element is 0 then swap the element with the element at index low and update low = low + 1 and mid = mid + 1
                if (nums[mid] == 0)
                {
                    temp = nums[lo];
                    nums[lo] = nums[mid];
                    nums[mid] = temp;
                    lo++;
                    mid++;
                }
                //If the element is 1 then update mid = mid + 1
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                //If the element is 2 then swap the element with the element at index high and update high = high – 1 and update i = i – 1
                else
                {
                    temp = nums[mid];
                    nums[mid] = nums[hi];
                    nums[hi] = temp;
                    hi--;
                }
            }

            return nums;
        }
    }
}
