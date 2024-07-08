**PROBLEM SET 1: Palindrome Pairs**

Problem Description:
Given a list of unique words, your task is to find all pairs of distinct indices (i, j) in the list so that
the concatenation of the two words, i.e., words[i] + words[j], forms a palindrome.

**SOLUTION OVERVIEW**

**Main Function**
  -Initialize an array of strings words containing various words.<br />
  -Call PalindromePairs(words) to find palindrome pairs and store the result in result.<br />
  -Print the result in the specified output format.<br />

**Palindrome Checking Function (IsPalindrome)**
  -Checks if a given string s is a palindrome.<br />
  -Uses two pointers (left and right) starting from the beginning and end of the string respectively.<br />
  -Compares characters at these pointers moving towards the center. If characters don't match, returns false; otherwise, returns true if the entire string is traversed without mismatches.<br />

**Palindrome Pairs Function (PalindromePairs)**
  -Initialize tempResult to store potential palindrome pairs with a size sufficient to hold all pairs (n * (n - 1)).<br />
  -Loop through each pair of words in the array words.<br />
  -Concatenate each pair of words (words[i] + words[j]) and check if the resulting string is a palindrome using IsPalindrome.<br />
  -If a palindrome pair is found, store the indices [i, j] in tempResult and increment count.<br />
  -Copy valid pairs from tempResult into result, which is resized to count to hold exactly the number of valid pairs found.<br />
  -Return result, which contains all valid palindrome pairs.<br />

**Output Formatting**
  -In Main, iterate through result and print each pair in the format [i, j].<br />
  -Manage the output format and ensure no trailing comma after the last pair.<br />
