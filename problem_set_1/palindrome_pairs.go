package main
import "fmt"

func isPalindrome(s string) bool {
	left := 0
	right := len(s) - 1

	for left < right {
		if s[left] != s[right] {
			return false
		}
		left++
		right--
	}

	return true
}

func palindromePairs(words []string) [][]int {
	n := len(words)
	tempResult := make([][]int, 0, n*(n-1))
	count := 0

	for i := 0; i < n; i++ {
		for j := 0; j < n; j++ {
			if i != j {
				concatenatedWord := words[i] + words[j]
				if isPalindrome(concatenatedWord) {
					tempResult = append(tempResult, []int{i, j})
					count++
				}
			}
		}
	}

	result := make([][]int, count)
	copy(result, tempResult[:count])
	return result
}

func main() {
	words := []string{"bat", "tab", "cat", "race", "car", "ooo", "ooo", "_124?#", "_124?#", "#?421"}
	result := palindromePairs(words)

	//following the output format, answer must be: [[0, 1], [1, 0], [3, 4], [5, 6], [6, 5], [9, 7], [9, 8]]
	output := "["
	for i := 0; i < len(result); i++ {
		output += fmt.Sprintf("[%d, %d]", result[i][0], result[i][1])
		if i < len(result)-1 {
			output += ", "
		}
	}
	output += "]"
	fmt.Println(output)
}