function solve(flovors, firstFlower, secondFlower){

    const firstFlowerIndex = flovors.indexOf(firstFlower);
    const secondFlowerIndex = flovors.indexOf(secondFlower);

    const result = flovors.slice(firstFlowerIndex, secondFlowerIndex + 1);
    return result;
}
