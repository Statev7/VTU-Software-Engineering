function solve(numbers){

    let maxNumber = Number.MIN_SAFE_INTEGER;
    for (let row = 0; row < numbers.length; row++) {
        
        let currentMaxElement = Math.max(...numbers[row]);

        if (currentMaxElement > maxNumber) {
            maxNumber = currentMaxElement;
        }
    }
    
    return maxNumber;
}