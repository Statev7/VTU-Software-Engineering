function solve(names){
 
    let orderedNames = names
    .sort((a, b) => {
        let nameA = a.toLowerCase();
        let nameB = b.toLowerCase();
        if (nameA < nameB) 
            return -1;
        if (nameA > nameB)
            return 1;
        return 0;
    })
    .sort((a, b) => a.length - b.length);

    console.log(orderedNames.join('\n'));
}
