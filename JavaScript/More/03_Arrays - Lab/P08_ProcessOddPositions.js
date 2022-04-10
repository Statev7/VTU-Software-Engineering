function solve(numbers){

    let result = numbers
    .filter((x, i) => i % 2 == 1)
    .map(x => x * 2)
    .reverse();

    console.log(result.join(" "));
}
