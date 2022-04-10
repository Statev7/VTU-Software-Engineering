function solve(matrix){

    let firstRowSum = matrix[0].reduce((a, x) => a + x, 0);

    for (let row = 1; row < matrix.length; row++) {
        
        let currentRowSum = matrix[row].reduce((a, x) => a + x, 0);

        let isEqual = currentRowSum === firstRowSum;
        if (!isEqual) {
            console.log(false);
            return;
        }
    }

    for (let col = 0; col < matrix.length; col++) {
        
        let currentColSum = 0;
        for (let row = 0; row < matrix.length; row++) {
            
            currentColSum += matrix[row][col];
        }

        let isEqual = currentColSum === firstRowSum;
        if (!isEqual) {
            console.log(false);
            return;
        }
    }

    console.log(true);
}

solve([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]
   
   
   )
