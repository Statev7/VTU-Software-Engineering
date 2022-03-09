// const user = {
//     firstName: "Pesho", 
//     lastName: "Peshev", 
//     age: 15,
//     fullName : function(){
//         return this.firstName + " " + this.lastName;
//     },
//     yearOfBirth : function(){
//         const year = new Date().getFullYear();
//         return year - this.age;
//     }
// };

// //console.log(user.yearOfBirth());
// //console.log(user.firstName);
// //delete user.firstName;

// for (const property in user) {
//     console.log(`${property}: ${user[property]}`);
// }

// class User{
//     constructor(firstName, lastName, age){
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.age = age;
//     }

//     getFullName(){
//         return this.firstName + " " + this.lastName;
//     }

//     getYearOfBirth(){
//         const year = new Date().getFullYear();
//         return year - this.age;
//     }
// }

// let user = new User("Pesho", "Peshev", 20);

// console.log(user.getFullName());
// console.log(user.getYearOfBirth());

// function myFunc(str, target){
    
//     let count = 0;
//     for (let index = 0; index < str.length; index++) {
//         if(str.charAt(index) === target)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// let result = myFunc("w3resource.com", "o");
// console.log(result);

function myFunc(str, targetStr){
    let index = str.indexOf(targetStr);

    if(index === -1){
        return str;
    }

    let lenght = targetStr.length;
    let result = str.slice(index + lenght);
    return result;
}

let result = myFunc("the laptop is not broken", "is");
console.log(result);