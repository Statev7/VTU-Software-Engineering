const numbers = [10, 20, 30, 40, 50, 75, 125];

//Print array
// numbers.forEach(element => {
//     console.log(element);
// });

console.log(numbers.map(myFunc));

function myFunc(num){
    let result = `${num} е нечетно число`;

    if(num % 2 === 0){
        result = `${num} е четно число`;
    }

    return result;
}

// avarage 

let result = numbers.reduce((num1, num2) => num1 + num2 / numbers.length);
console.log(`${Math.round(result, 0)}`);

// Filter
console.log(numbers.filter((x) => x > 25));