function solve(numbers){

    let firstDiagonalSum = 0;
    let secondDiagonalSum = 0;

    for (let row = 0; row < numbers.length; row++) {
        firstDiagonalSum += numbers[row][row];
    }

    let colCount = numbers.length - 1;
    for (let row = 0; row < numbers.length; row++) {
        secondDiagonalSum += numbers[row][colCount--];
    }

    let outputMessage = `${firstDiagonalSum} ${secondDiagonalSum}`;
    console.log(outputMessage);
}

solve([[20, 40],
    [10, 60]]
   )