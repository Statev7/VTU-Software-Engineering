function calculateArea(input){

    let message = `We can not calculate the circle area, because we receive a ${typeof(input)}.`
    if(typeof(input) === 'number'){

        let area = Math.PI * Math.pow(input, 2);
        message = `${area.toFixed(2)}`
    }

    console.log(message);
}