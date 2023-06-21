def binarySearch(numbers,searchNum) -> int:
    leftIndex = 0
    rightIndex = len(numbers) - 1

    while leftIndex <= rightIndex:
        mid = (leftIndex + rightIndex) // 2
        if numbers[mid] == searchNum:
            return mid
        elif numbers[mid] < searchNum:
            leftIndex = mid + 1
        else:
            rightIndex = mid - 1
    
    return -1

nums = [-1,0,3,5,9,12]
target1 = 9 
target2 = 2

test1 = binarySearch(nums,target1)
test2 = binarySearch(nums,target2)

print("Exercise 1")
print(test1)

print("Exercise 2")
print(test2)
