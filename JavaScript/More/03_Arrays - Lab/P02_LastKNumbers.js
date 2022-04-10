function solve(n, k){
    let arr = [1];

    for (let index = arr.length; index < n; index++) {
        
        let startIndex = Math.max(0, index - k);

        let sum = arr
        .slice(startIndex, index)
        .reduce((a, x) => a + x, 0);

        arr.push(sum);
    }

    console.log(arr)
}

solve();