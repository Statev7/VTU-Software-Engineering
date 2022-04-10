function solve(array, steps){

    let result = [];
    for (let index = 0; index < array.length; index+= steps) {
        result.push(array[index]);
    }

    return result;
}

