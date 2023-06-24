class Solution:
    def MaximumValue(self,strs:list[str]) -> int :
        res = float('-inf')

        for str in strs:
            if str.isdigit():
                res = max(res,int(str))
            else:
                res = max(res,len(str))
        
        return res

test1 = ["alic3","bob","3","4","00000"]
maximumValue1 = Solution.MaximumValue(None,test1)
print("Test 1:")
print(maximumValue1)

test2 = ["1","01","001","0001"]
maximumValue2 = Solution.MaximumValue(None,test2)
print("Test 2:")
print(maximumValue2)
