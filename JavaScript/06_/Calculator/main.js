function calculate(){

    const billValue = document.getElementById("bill").value;
    const options = document.getElementById("options");
    const peopleValue = document.getElementById("peopleCount").value;

    const outputMessage = document.getElementById("errorMessage");
    outputMessage.style.color = "red";

    let errorMessage = validateDate(billValue, peopleValue);
    outputMessage.innerHTML = errorMessage;

    if(!errorMessage){
        const optionValue = Number(options.value) / 100;

        const result = Number(billValue) * (optionValue / Number(peopleValue));
        outputMessage.style.color = "black";
        outputMessage.innerHTML = `По ${result.toFixed(2)}лв на човек`;
    }
}

function validateDate(billValue, peopleValue){

    let errorMessage = '';

    if(!billValue && !peopleValue){
        return errorMessage = "Попълнете всички полета!";
    }

    if(!billValue || Number(billValue) <= 0){
        return errorMessage = "Сметката трябва да бъде поне 1лв!";
    }

    if(!peopleValue || Number(peopleValue) < 1){
        return errorMessage = "Трябва да има поне един човек!";
    }

    return errorMessage;
}