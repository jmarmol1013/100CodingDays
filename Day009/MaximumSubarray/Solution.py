class Solution:
    def Maximum_subarray(self,nums:list[int]):
        max_sum = float('-inf')
        current_sum = 0

        for num in nums:
            current_sum += num

            if max_sum < current_sum:
                max_sum = current_sum
            
            if current_sum < 0:
                current_sum = 0
        
        return max_sum
    
test1 = [-2,1,-3,4,-1,2,1,-5,4]
maximum_subarray = Solution.Maximum_subarray(None,test1)
print("Test 1:")
print(maximum_subarray)

test2 = [1]
maximum_subarray = Solution.Maximum_subarray(None,test2)
print("Test 2:")
print(maximum_subarray)

test3 = [5,4,-1,7,8]
maximum_subarray = Solution.Maximum_subarray(None,test3)
print("Test 3:")
print(maximum_subarray)