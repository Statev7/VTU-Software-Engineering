function solve(names){

    let index = 1;
    let sortedNames = names.sort((x,y) => {
        if(x.toUpperCase() > y.toUpperCase() ){
            return 1;
        }else if(y.toUpperCase()  > x.toUpperCase() ){
            return -1;
        }
        return 0;
    })
    .map(x => `${index++}.${x}`);
    
    console.log(sortedNames.join('\n'));
}

solve(["John", "Bob", "Christina", "Ema"])