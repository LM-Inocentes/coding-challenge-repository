**PROBLEM SET 2: Valid Parentheses**

Problem Description: Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid. An input string is valid if:
1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.

**SOLUTION OVERVIEW**

**Main Function**<br />
  &emsp;-Calls PrintIsValid for each test case with different strings of brackets.<br />
  &emsp;-Outputs the result in the specified format.<br />

**PrintIsValid Function:**<br />
  &emsp;-Takes a string brackets as input.<br />
  &emsp;-Calls IsValid to check if the string of brackets is valid.<br />
  &emsp;-Prints the input and the result of IsValid.<br />

**IsValid Function:**<br />
  &emsp;-Takes a string brackets as input.<br />
  &emsp;-Initializes a stack of characters to store opening brackets.<br />
  &emsp;-Initializes top to keep track of the top element in the stack.<br />
  &emsp;-Iterates through each character bracket in the input string brackets.<br />
    &emsp;&emsp;-If bracket is an opening bracket pushes it onto the stack.<br />
    &emsp;&emsp;-If bracket is a closing bracket:<br />
      &emsp;&emsp;&emsp;-Checks if the stack is empty (top == -1). If true, returns false (no matching opening bracket).<br />
      &emsp;&emsp;&emsp;-Pops the top character from the stack and checks if it matches the current closing bracket bracket.<br />
        &emsp;&emsp;&emsp;&emsp;-If not matched, returns false (mismatched brackets).<br />
  &emsp;-After iterating through all characters, checks if the stack is empty (top == -1).<br />
    &emsp;&emsp;-If true, returns true (all brackets matched and nested correctly).<br />
    &emsp;&emsp;-Otherwise, returns false (there are unmatched opening brackets).<br />

**Example Execution**<br />
**Given the test cases:**<br />
&emsp;"[{()}]" should return true because all brackets are correctly nested.<br />
&emsp;"()[]{}" should return true for the same reason.<br />
&emsp;"{}([){}]" should return false due to mismatched brackets.<br />
&emsp;"" (empty string) should return true because there are no brackets to check.<br />
&emsp;"}" should return false because there's a closing bracket without a corresponding opening bracket.<br />
&emsp;"(" should return false for the same reason.<br />

The solution efficiently checks each character in the string using a stack to ensure that all brackets are properly nested and returns true or false based on whether the string of brackets is valid.<br />

This approach ensures that the solution is both clear and efficient, leveraging a stack to handle the nested structure of brackets and providing accurate validation for different input scenarios.<br />
