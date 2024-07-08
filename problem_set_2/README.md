**PROBLEM SET 1: Valid Parentheses**

Problem Description: Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid. An input string is valid if:
1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.

**SOLUTION OVERVIEW**

**Main Function**
  -Calls PrintIsValid for each test case with different strings of brackets.
  -Outputs the result in the specified format.

**PrintIsValid Function:**
  -Takes a string brackets as input.
  -Calls IsValid to check if the string of brackets is valid.
  -Prints the input and the result of IsValid.

**IsValid Function:**
  -Takes a string brackets as input.
  -Initializes a stack of characters to store opening brackets.
  -Initializes top to keep track of the top element in the stack.
  -Iterates through each character bracket in the input string brackets.
    -If bracket is an opening bracket pushes it onto the stack.
    -If bracket is a closing bracket:
      -Checks if the stack is empty (top == -1). If true, returns false (no matching opening bracket).
      -Pops the top character from the stack and checks if it matches the current closing bracket bracket.
        -If not matched, returns false (mismatched brackets).
  -After iterating through all characters, checks if the stack is empty (top == -1).
    -If true, returns true (all brackets matched and nested correctly).
    -Otherwise, returns false (there are unmatched opening brackets).
