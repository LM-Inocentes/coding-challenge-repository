package main
import "fmt"

func main() {
	printIsValid("[{()}]")     // Output: Input: [{()}] Output: true
	printIsValid("()[]{}")     // Output: Input: ()[]{} Output: true
	printIsValid("{}([){}]")   // Output: Input: {}([){}] Output: false
	printIsValid("")           // Output: Input:  Output: true (empty string)
	printIsValid("}")          // Output: Input: } Output: false
	printIsValid("(")          // Output: Input: ( Output: false
}

func printIsValid(brackets string) {
	fmt.Printf("Input: %s\n", brackets)
	fmt.Printf("Output: %v\n\n", isValid(brackets))
}

func isValid(brackets string) bool {
	stack := make([]rune, 0) // Using a slice to simulate stack of runes (characters)

	for _, bracket := range brackets {
		if bracket == '(' || bracket == '{' || bracket == '[' {
			stack = append(stack, bracket) // Push onto stack
			// fmt.Printf("Pushed onto stack: %c, new stack: %s\n", bracket, string(stack))
		} else if bracket == ')' || bracket == '}' || bracket == ']' {
			if len(stack) == 0 {
				// fmt.Println("Executed - No matching opening bracket")
				return false // No matching opening bracket
			}

			topChar := stack[len(stack)-1] // Peek top of stack
			stack = stack[:len(stack)-1]   // Pop from stack
			// fmt.Printf("Popped from stack: %c, new stack: %s\n", topChar, string(stack))

			if (bracket == ')' && topChar != '(') ||
				(bracket == '}' && topChar != '{') ||
				(bracket == ']' && topChar != '[') {
				// fmt.Println("Executed - Mismatched brackets")
				return false // Mismatched brackets
			}
		}
	}

	return len(stack) == 0 // Stack should be empty if all brackets matched
}