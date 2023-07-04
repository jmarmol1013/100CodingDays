using System;

class Solution{
    static bool CanPartitionKSubsets(int[] nums, int k)
    {
        int totalSum = 0;
        foreach (int num in nums)
        {
            totalSum += num;
        }

        if (totalSum % k != 0)
        {
            return false;
        }

        int targetSum = totalSum / k;
        bool[] visited = new bool[nums.Length];
        return Partition(nums, k, 0, 0, targetSum, visited);
    }

    static bool Partition(int[] nums, int k, int currentSum, int start, int targetSum, bool[] visited)
    {
        if (k == 1)
        {
            return true;
        }

        if (currentSum == targetSum)
        {
            return Partition(nums, k - 1, 0, 0, targetSum, visited);
        }

        for (int i = start; i < nums.Length; i++)
        {
            if (!visited[i] && currentSum + nums[i] <= targetSum)
            {
                visited[i] = true;

                if (Partition(nums, k, currentSum + nums[i], i + 1, targetSum, visited))
                {
                    return true;
                }

                visited[i] = false;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] nums = { 4, 3, 2, 3, 5, 2, 1 };
        int k = 4;

        bool canPartition = CanPartitionKSubsets(nums, k);
        Console.WriteLine("Example 1");
        Console.WriteLine("Can partition into {0} equal sum subsets: {1}", k, canPartition);
       
        int[] nums2 = { 1,2,3,4 };
        k = 3;
        Console.WriteLine("Example 2");
        bool canPartition2 = CanPartitionKSubsets(nums2, k);
        Console.WriteLine("Can partition into {0} equal sum subsets: {1}", k, canPartition2);
    }
}