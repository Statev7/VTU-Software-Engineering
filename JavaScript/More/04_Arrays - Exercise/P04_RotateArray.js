function solve(numbers, rotateCount){

    for (let index = 0; index < rotateCount; index++) {
        let lastElement = numbers.pop();
        numbers.unshift(lastElement);
    }

    console.log(numbers.join(' '));
}

solve(['1', 
'2', 
'3', 
'4'], 
2

)