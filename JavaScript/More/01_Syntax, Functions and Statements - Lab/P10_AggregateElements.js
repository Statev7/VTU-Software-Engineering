function sum(arr){
    let sum = 0;
    for (let index = 0; index < arr.length; index++) {
        sum += array[index];
    }

    return sum;
}

function inverseSum(arr) {
    let sum = 0;
    for (let index = 0; index < arr.length; index++) {
        const element = 1 / arr[index];
        sum += element;
    }

    return sum;
}

function concat(arr){
    let concatSum = '';
    for (let index = 0; index < arr.length; index++) {
        concatSum += array[index];
    }

    return concatSum;
}

function solve(arr){
    let sum = 0;
    let inverseSum = 0;
    let concat = '';

    for (let index = 0; index < arr.length; index++) {
        const element = arr[index];
        sum += element;
        inverseSum += 1 / element;
        concat += element;
    }

    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}

solve([1, 2, 3]);