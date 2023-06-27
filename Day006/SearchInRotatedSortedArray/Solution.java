package Day006.SearchInRotatedSortedArray;

import java.util.Arrays;

public class Solution {
    
    private static int BinarySearch(int[] nums,int target){
        int left = 0;
        int rigth = nums.length - 1;
        
        while(left <= rigth){
            int mid = left + (rigth - left) / 2;

            if(nums[mid] == target){
                return mid;
            }

            if(nums[left] <= nums[mid]){
                if(target >= nums[left] && target < nums[mid]){
                    rigth = mid - 1;
                }else{
                    left = mid + 1;
                }
            } else{
                if(target <= nums[rigth] && target > nums[mid]){
                    left = mid + 1;
                } else{
                    rigth = mid - 1;
                }
            }
        }

        return -1;
    }

    public static void main(String[] args){
        // First example
        int[] nums = {4,5,6,7,0,1,2};
        int target = 0;
        System.out.println("Example 1, input array:" + Arrays.toString(nums) + ", target: " + target);
        int test = BinarySearch(nums, target);
        System.out.println("Output: " + test);

        // Second example
        target = 3;
        System.out.println("Example 2, input array:" + Arrays.toString(nums) + ", target: " + target);
        test = BinarySearch(nums, target);
        System.out.println("Output: " + test);

        // Third example
        int[] nums2 = {1};
        target = 0;
        System.out.println("Example 3, input array:" + Arrays.toString(nums2) + ", target: " + target);
        test = BinarySearch(nums2, target);
        System.out.println("Output: " + test);
    }
}
