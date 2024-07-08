using System;

class Program
{
    static void Main()
    {
        PrintIsValid("[{()}]");     // Output: Input: [{()}] Output: True
        PrintIsValid("()[]{}");     // Output: Input: ()[]{} Output: True
        PrintIsValid("{}([){}]");   // Output: Input: {}([){}] Output: False
        PrintIsValid("");           // Output: Input:  Output: True (empty string)
        PrintIsValid("}");          // Output: Input: } Output: False
        PrintIsValid("(");          // Output: Input: ( Output: False
    }

    static void PrintIsValid(string brackets)
    {
        Console.WriteLine($"Input: {brackets}");
        Console.WriteLine($"Output: {IsValid(brackets)}");
        Console.WriteLine();
    }

    static bool IsValid(string brackets)
    {
        char[] stack = new char[brackets.Length];
        int top = -1; // Index of the top element in the stack

        foreach (char bracket in brackets)
        {
            if (bracket == '(' || bracket == '{' || bracket == '[')
            {
                stack[++top] = bracket; // Push onto stack
                // Console.WriteLine($"Pushed onto stack: {bracket}, new top: {top}");
            }
            else if (bracket == ')' || bracket == '}' || bracket == ']')
            {
                if (top == -1)
                {
                    // Console.WriteLine($"Executed - No matching opening bracket");
                    return false; // No matching opening bracket
                }

                char topChar = stack[top--]; // Pop from stack post decrement
                // Console.WriteLine($"Popped from stack: {topChar}, new top: {top}");
                if ((bracket == ')' && topChar != '(') ||
                    (bracket == '}' && topChar != '{') ||
                    (bracket == ']' && topChar != '['))
                {
                    // Console.WriteLine($"Executed - Mismatched brackets");
                    return false; // Mismatched brackets
                }
            }
        }
    
        return top == -1; // Stack should be empty if all brackets matched
    }
}