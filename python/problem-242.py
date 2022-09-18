#Runtime: 116 ms
#Memory Usage: 15.2 MB

#Problem prompt:
#Given two strings s and t, return true if t is an anagram of s, and false otherwise.
#An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        slist = list(s)
        tlist = list(t)
        #Sort lists
        slist.sort()
        tlist.sort()
        #If lists aren't equal, they aren't comprised of the same letters
        return (slist == tlist)