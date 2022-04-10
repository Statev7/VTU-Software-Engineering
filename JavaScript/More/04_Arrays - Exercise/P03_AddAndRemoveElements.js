function solve(commands){

    let date = [];
    let intialValue = 1;

    for (let index = 0; index < commands.length; index++) {
        
        const currentCommand = commands[index];
        
        if(currentCommand === 'add'){
            date.push(intialValue);
        } else if(currentCommand === 'remove'){
            date.pop();
        }
        intialValue++;
    }

    const resultAsString = date.length !== 0 ? date.join('\n') : 'Empty';
    console.log(resultAsString);
}

solve(['remove', 
'remove', 
'remove']

)