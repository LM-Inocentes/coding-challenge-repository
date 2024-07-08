**PROBLEM SET 3: Longest Increasing Subsequence**

Problem Description:
Given an unsorted array of integers, find the length of the longest increasing subsequence.
For context. The "Longest Increasing Subsequence" is a common problem in computer science and
dynamic programming. In the context of an array of integers, the goal is to find the length of the longest
subsequence of a given array such that all elements of the subsequence are sorted in increasing order.

**SOLUTION OVERVIEW**

**Dynamic Programming Setup**<br />
  &emsp;-Create an array LISarr of the same length as nums, initialized to 1. This array will store the length of the longest increasing subsequence ending at each index.<br />
  &emsp;-Initialize maxLength to 1, which will eventually hold the maximum length of the LIS found.<br />

**Iterating through the Array**<br />
   &emsp;-Loop through each element in nums starting from the second element (i = 1).<br />
   &emsp;-For each element nums[i], iterate through all previous elements nums[j] (where j < i).<br />
   &emsp;-Compare nums[j] with nums[i]. If nums[j] < nums[i], it means nums[i] can extend the increasing subsequence ending at nums[j].<br />
   &emsp;-Update LISarr[i] to be the maximum of its current value (LISarr[i]) and the length of the subsequence ending at nums[j] plus one (LISarr[j] + 1).<br />

**Updating Maximum Length**<br />
  &emsp;-Update maxLength to be the maximum of its current value and LISarr[i]. This ensures maxLength always holds the length of the longest increasing subsequence found so far.<br />

  **Return Result**<br />
  &emsp;-After iterating through all elements of nums, maxLength will contain the length of the longest increasing subsequence.<br />

**Printing the Result**<br />
  &emsp;-The printLIS function formats the input array nums and prints both the input and the result of lengthOfLIS(nums).<br />

**Example Execution**<br />
Given nums = [10, 9, 2, 5, 3, 7, 101, 100, 101, 101, 18]:<br />

The function computes the LIS, which is [2, 3, 7, 100, 101] with a length of 5.<br />
The algorithm efficiently computes the LIS using a dynamic programming approach, ensuring that each subproblem (finding the LIS ending at each index) is solved optimally.
