function solve(numbers){

    let result = [];
    let biggestNumber = Number.MIN_SAFE_INTEGER;

    for (let index = 0; index < numbers.length; index++) {
        
        const currentNumber = numbers[index];

        let isEqualsOrBigger = currentNumber >= biggestNumber;
        if (isEqualsOrBigger) {
            result.push(currentNumber);
            biggestNumber = currentNumber;
        }
    }

    return result
}
