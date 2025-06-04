# NeetCode150Practice

2 pointer approach - Mainly used for reducing our time complexity from Big O(n) to linear n i.e O(n^2) -> O(n)
Sliding window approach.
# Qs.Considering the constraint that s consists of English letters, digits, symbols, and spaces, what is the maximum possible size of our window?
Ans. In ASCII, there are 95 printable characters: 26 lowercase English letters, 26 uppercase English letters, 10 digits (0-9), 32 special characters and symbols, and the space character. This makes a total of 95 unique characters. Even if you don’t know there are exactly 95, it reasonable that there would be more than 52 (26 uppercase, 26 lowercase).


#**HashSet**: A Set is a data structure maintaining a collection of unique elements. It provides constant-time complexity for search, insertion, and deletion, making it suitable for tracking unique characters in a string.
- `HashSet<ListNode>` A hash set is like a *special list* that stores items **without duplicates** and checks very fast if something is already inside it.
**Step	  Meaning**
1.	      Take the key (like a ListNode, a number, or a string).
2.	      Run it through a hash function (a math formula) that turns it into a number (hash code).
3.	      Use that number to find the "bucket" (memory location) where to store the value.
4.	      When you want to retrieve it later, hash the key again and jump to the same spot!


The sliding window approach allows us to scan through the string once (linear time complexity) while keeping track of the longest substring without repeating characters. It's an optimal strategy for this problem as it avoids unnecessary repeated computations.


#**Deque** (Double-Ended Queue/ linkedlist) is a type of data structure that allows insertion and removal of elements from both the front and rear. In C#, it can be implemented using LinkedList<T> and List<T>.

#**PIVOT** Pivot element is always an element that has the left and right elements greater to it. eg. 10,0,1 **0** is the pivot here.

#**Binary Search** is always applied to a sorted array. time complexity to `O(log N)`

//Initialization means creating the object in memory before using it.

//creating an empty dictionary that you can start adding keys and values to.
Field declaration: private Dictionary<string, List<Tuple<int, string>>> keyStore;
Initialization (usually in constructor): keyStore = new Dictionary<string, List<Tuple<int, string>>>();

#***LinkedList*** is a linear data structure that stores elements in a **non-contiguous** location.
-**Non-contiguous** memory is allocated 1 by 1 to individual elements.
-In C#, **LinkedList** is the generic type of collection that is defined in the System.Collections.Generic namespace.
-can store duplicate elements of the same type.
-prefer linked list over arrays is due to ease of insertion and deletion in linked list.
-Access is *SEQUENTIAL*.
- Never manipulate *head* of a linkedlist. *Create* a new *temp* variable and store *'head'*, then perform operations.

- #**Traverse a LinkedList** create a new *current node* and point to the *"head"*.

**TYPES:-** "Single", "Double", "Circular"

**Trees**-A tree is a data structure used to represent *hierarchical relationships*, like folders on your computer.
-The most common type is the binary tree, where:
-Each node can have at most 2 children, referred to as the left and right child.
**Inorder** (Left, Root, Right)
**Preorder** (Root, Left, Right)
**Postorder** (Left, Right, Root)

**Iterative DFS = We Need a Stack! Why?**

So when we convert recursion to iteration, we must use a stack manually to remember where we left off, just like recursion does.
**Concept	Why Stack is Used**
**DFS** = Depth First	We need to go deep first
**Iterative** version	Requires us to remember where we paused → use stack
**Stack (LIFO)**	Works like recursive function calls
**Order matters**	Push right first, so left is processed first uses a stack behind the scenes!
