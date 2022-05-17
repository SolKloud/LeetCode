using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        public static int SearchPosition(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
                return low;
        }
    }
}
