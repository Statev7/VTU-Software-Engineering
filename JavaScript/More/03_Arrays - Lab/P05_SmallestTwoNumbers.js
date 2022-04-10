function solve(numbers){
    let result = [];

    let sortedNumbers = numbers.sort((a, b) => compare(a, b));
    result.push(sortedNumbers[0]);
    result.push(sortedNumbers[1]);

    console.log(result.join(" "))
}

function compare(a, b){
    if(a < b){
        return -1;
    } 
    else if(a > b){
        return 1;
    }
    return 0;
}

solve([30, 15, 50, 5]);