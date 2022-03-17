function printSquare(n){

    const starSymbol = '* ';
    let str = starSymbol.repeat(n);

    for (let index = 0; index < n; index++) {
        console.log(str.trimEnd());
    }
}
