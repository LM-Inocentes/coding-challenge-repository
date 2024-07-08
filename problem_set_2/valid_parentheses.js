function main() {
    printIsValid("[{()}]");     // Output: Input: [{()}] Output: true
    printIsValid("()[]{}");     // Output: Input: ()[]{} Output: true
    printIsValid("{}([){}]");   // Output: Input: {}([){}] Output: false
    printIsValid("");           // Output: Input:  Output: true (empty string)
    printIsValid("}");          // Output: Input: } Output: false
    printIsValid("(");          // Output: Input: ( Output: false
}

function printIsValid(brackets) {
    console.log(`Input: ${brackets}`);
    console.log(`Output: ${isValid(brackets)}`);
    console.log();
}

function isValid(brackets) {
    let stack = [];
    
    for (let i = 0; i < brackets.length; i++) {
        let bracket = brackets[i];
        
        if (bracket === '(' || bracket === '{' || bracket === '[') {
            stack.push(bracket); // Push onto stack
            // console.log(`Pushed onto stack: ${bracket}, new stack: ${stack.join(', ')}`);
        } else if (bracket === ')' || bracket === '}' || bracket === ']') {
            if (stack.length === 0) {
                // console.log(`Executed - No matching opening bracket`);
                return false; // No matching opening bracket
            }
            
            let topChar = stack.pop(); // Pop from stack
            // console.log(`Popped from stack: ${topChar}, new stack: ${stack.join(', ')}`);
            
            if ((bracket === ')' && topChar !== '(') ||
                (bracket === '}' && topChar !== '{') ||
                (bracket === ']' && topChar !== '[')) {
                // console.log(`Executed - Mismatched brackets`);
                return false; // Mismatched brackets
            }
        }
    }
    
    return stack.length === 0; // Stack should be empty if all brackets matched
}

main();