function solve(n, m){

    let sum = 0;
    let firstNumber = Number(n);
    let secondNumber = Number(m);

    for (let i = firstNumber; i <= secondNumber; i++) {
        sum += i;
    }

    return sum;
}