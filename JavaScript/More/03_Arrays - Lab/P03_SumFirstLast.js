function solve(numbers){
    let firstNum = Number(numbers[0]);
    let lastNum = Number(numbers[numbers.length - 1]);

    let sum = firstNum + lastNum;

    console.log(sum);
}

solve(['20', '30', '40']);