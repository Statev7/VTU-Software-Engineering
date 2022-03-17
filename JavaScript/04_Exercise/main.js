const obj = {};
let newArray = [];

function findDuplicatesInArray(arr){
    
    for (let index = 0; index < arr.length; index++) {
        const element = arr[index];
        
        if(!obj[element]){
            obj[element] = 0;
        }
        obj[element] += 1;
    }

    for (const key in obj) {

        let value = obj[key];

        if(value > 1){
            newArray.push(parseInt(key));
        }
    }

    newArray.sort(function(a, b){return a-b});
    document.getElementById("demo").innerHTML = newArray;
}
