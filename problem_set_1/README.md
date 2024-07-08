**PROBLEM SET 1: Palindrome Pairs**

Problem Description:
Given a list of unique words, your task is to find all pairs of distinct indices (i, j) in the list so that
the concatenation of the two words, i.e., words[i] + words[j], forms a palindrome.

**SOLUTION OVERVIEW**

**Main Function**<br />
  &ensp;-Initialize an array of strings words containing various words.<br />
  &ensp;-Call PalindromePairs(words) to find palindrome pairs and store the result in result.<br />
  &ensp;-Print the result in the specified output format.<br />

**Palindrome Checking Function (IsPalindrome)**<br />
  &ensp;-Checks if a given string s is a palindrome.<br />
  &ensp;-Uses two pointers (left and right) starting from the beginning and end of the string respectively.<br />
  &ensp;-Compares characters at these pointers moving towards the center. If characters don't match, returns false; otherwise, returns true if the entire string is traversed without mismatches.<br />

**Palindrome Pairs Function (PalindromePairs)**<br />
  &ensp;-Initialize tempResult to store potential palindrome pairs with a size sufficient to hold all pairs (n * (n - 1)).<br />
  &ensp;-Loop through each pair of words in the array words.<br />
  &ensp;-Concatenate each pair of words (words[i] + words[j]) and check if the resulting string is a palindrome using IsPalindrome.<br />
  &ensp;-If a palindrome pair is found, store the indices [i, j] in tempResult and increment count.<br />
  &ensp;-Copy valid pairs from tempResult into result, which is resized to count to hold exactly the number of valid pairs found.<br />
  &ensp;-Return result, which contains all valid palindrome pairs.<br />

**Output Formatting**<br />
  &ensp;-In Main, iterate through result and print each pair in the format [i, j].<br />
  &ensp;-Manage the output format and ensure no trailing comma after the last pair.<br />
