# NeetCode150Practice

2 pointer approach - Mainly used for reducing our time complexity from Big O(n) to linear n i.e O(n^2) -> O(n)
Sliding window approach.
# Qs.Considering the constraint that s consists of English letters, digits, symbols, and spaces, what is the maximum possible size of our window?
Ans. In ASCII, there are 95 printable characters: 26 lowercase English letters, 26 uppercase English letters, 10 digits (0-9), 32 special characters and symbols, and the space character. This makes a total of 95 unique characters. Even if you don’t know there are exactly 95, it reasonable that there would be more than 52 (26 uppercase, 26 lowercase).


HashSet:- A Set is a data structure that maintains a collection of unique elements. It provides constant-time complexity for search, insertion, and deletion, making it a suitable choice for tracking unique characters in a string.

The sliding window approach allows us to scan through the string once (linear time complexity) while keeping track of the longest substring without repeating characters. It's an optimal strategy for this problem as it avoids unnecessary repeated computations.
