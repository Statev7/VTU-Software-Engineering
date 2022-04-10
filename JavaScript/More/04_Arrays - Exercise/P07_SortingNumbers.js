function solve(numbers){

    let result = [];
    let sortedNumber = numbers.sort((x, y) =>{
        if(x > y) return 1;
        if(y > x) return -1;
        return 0;
    })

    while(sortedNumber.length > 0){

        let currentMinElement = numbers.shift();
        let currentMaxElement = numbers.pop();

        result.push(currentMinElement);
        result.push(currentMaxElement);
    }

    return result;
}

solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56])