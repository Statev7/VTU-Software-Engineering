function stringLenght(...arr){

    let sumLenght = 0;
    for (let index = 0; index < arr.length; index++) {
        sumLenght += arr[index].length;
    }

    let avgLenght = Math.floor(sumLenght / arr.length);
    console.log(sumLenght);
    console.log(avgLenght);
}
