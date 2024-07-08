function isPalindrome(s) {
    let left = 0;
    let right = s.length - 1;

    while (left < right) {
        if (s[left] !== s[right]) {
            return false;
        }
        left++;
        right--;
    }

    return true;
}

function palindromePairs(words) {
    const n = words.length;
    const tempResult = new Array(n * (n - 1));
    let count = 0;

    for (let i = 0; i < n; i++) {
        for (let j = 0; j < n; j++) {
            if (i !== j) {
                const concatenatedWord = words[i] + words[j];
                if (isPalindrome(concatenatedWord)) {
                    tempResult[count] = [i, j];
                    count++;
                }
            }
        }
    }

    const result = tempResult.slice(0, count);
    return result;
}

function main() {
    const words = ["bat", "tab", "cat", "race", "car", "ooo", "ooo", "_124?#", "_124?#", "#?421"];
    const result = palindromePairs(words);

    // Following the output format, answer must be: [[0, 1], [1, 0], [3, 4], [5, 6], [6, 5]]
    let output = "[";
    for (let i = 0; i < result.length; i++) {
        output += `[${result[i][0]}, ${result[i][1]}]`;
        if (i < result.length - 1) {
            output += ", ";
        }
    }
    output += "]";
    console.log(output);
}

main();