function lengthOfLIS(nums) {
    if (nums.length === 0) {
        return 0;
    }
    
    let LISarr = new Array(nums.length).fill(1);
    let maxLength = 1;
    
    for (let i = 1; i < nums.length; i++) {
        for (let j = 0; j < i; j++) {
            if (nums[j] < nums[i]) {
                LISarr[i] = Math.max(LISarr[i], LISarr[j] + 1);
            }
        }
        maxLength = Math.max(maxLength, LISarr[i]);
        // console.log(`After processing index ${i}: LISarr = [${LISarr.join(', ')}], maxLength = ${maxLength}`);
    }
    
    return maxLength;
}

function printLIS(nums) {
    console.log(`Input: [${nums.join(', ')}]`);
    console.log(`Output: ${lengthOfLIS(nums)}`);
}

let nums = [10, 9, 2, 5, 3, 7, 101, 100, 101, 101, 18];  // Output: 5
printLIS(nums);