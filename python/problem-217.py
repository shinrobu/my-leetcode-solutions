#Problem prompt:
#Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

#Second Approach
#Runtime: 489 ms (faster than 87.98% of submissions)
#Memory Usage: 26 MB
#O(1) time complexity

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        #Sets cannot have duplicate values. This assigns all the unique values to uniques
        uniques = set(nums)
        #If the list of numbers were all unique, they would be the same length as the above list
        if (len(uniques) != len(nums)):
            return True
        else:
            return False


#Initial Approach
#Runtime: 1393 ms
#Memory Usage: 25.7 MB
#O(n) time complexity
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        #This approach essentially checked for duplicates by having a sorted list and keeping in mind that duplicates are right next to each other
        nums.sort()
        for i, number in enumerate(nums):
            if(i+1 < len(nums)):
                if(nums[i] == nums[i+1]):
                    return True
        return False
        