function solve(numbers){

    let sortedArr = numbers.sort((a, b) => {
        if(a < b){
            return -1;
        } 
        else if(a > b){
            return 1;
        }
        return 0;
    });
    
    let minIndex = sortedArr.length / 2;
    let result = sortedArr.slice(minIndex);

    return result;
}

solve([3, 19, 14, 7, 2, 19, 6])