let people = ["Greg", "Mary", "Devon", "James"];

people.shift(); // Премахване на елемент в началото
people.pop(); // Премахване на елемент в края
people.unshift('Matt'); // Добавяне на елемент в началото
people.shift('Petyo'); // Добавяне на елемент в края

let indexOfMary = people.indexOf('Mary');

for (let index = 0; index <= indexOfMary; index++) {
    console.log(people[index]);
}

onsole.log(people.indexOf('Foo'));

people.splice(2, 2, "Elizabeth", "Artie");
console.log(people);