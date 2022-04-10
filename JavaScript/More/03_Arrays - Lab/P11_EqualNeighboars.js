function solve(input){

    let neighbors = 0;
 
    for (let row = 0; row < input.length - 1; row++) {
        for (let col = 0; col < input[row].length; col++) {
            if (input[row][col] == input[row + 1][col]) {
                neighbors++;
            }
            if (input[row][col] == input[row][col + 1]) {
                neighbors++;
            }
            if (row == input.length - 2 && input[row + 1][col] == input[row + 1][col + 1]) {
                neighbors++;
            }
        }
    }
    
    return neighbors;
}
