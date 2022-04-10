function solve(numbers){

    let result = numbers
    .filter((x, i) => i % 2 == 0)
    .join(" ");

    console.log(result);
}