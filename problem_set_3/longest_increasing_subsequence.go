package main

import (
	"fmt"
	"strings"
)

func main() {
	nums := []int{10, 9, 2, 5, 3, 7, 101, 100, 101, 101, 18}
	printLIS(nums) // Output: 5
}

func lengthOfLIS(nums []int) int {
	n := len(nums)
	if n == 0 {
		return 0
	}

	LISarr := make([]int, n)
	for i := range LISarr {
		LISarr[i] = 1
	}

	maxLength := 1

	for i := 1; i < n; i++ {
		for j := 0; j < i; j++ {
			if nums[j] < nums[i] {
				LISarr[i] = max(LISarr[i], LISarr[j]+1)
			}
		}
		maxLength = max(maxLength, LISarr[i])
		// fmt.Printf("After processing index %d: LISarr = [%s], maxLength = %d\n", i, intsToString(LISarr), maxLength)
	}

	return maxLength
}

func printLIS(nums []int) {
	fmt.Printf("Input: [%s]\n", intsToString(nums))
	fmt.Printf("Output: %d\n", lengthOfLIS(nums))
}

func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}

func intsToString(nums []int) string {
	strs := make([]string, len(nums))
	for i, num := range nums {
		strs[i] = fmt.Sprintf("%d", num)
	}
	return strings.Join(strs, ", ")
}