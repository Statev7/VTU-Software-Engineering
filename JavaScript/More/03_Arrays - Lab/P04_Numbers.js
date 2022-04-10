function solve(numbers){
    let result = [];

    let negativeNumbers = numbers.filter(x => x < 0).reverse();
    let possitiveNumbers = numbers.filter(x => x >= 0);

    result = negativeNumbers.concat(possitiveNumbers);
    console.log(result);
}
