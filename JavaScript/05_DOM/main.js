let input = document.getElementById('userInput');
input.addEventListener("keypress", function (event) {
    if (event.key === "Enter") {
      event.preventDefault();
      search();
    }
  });
  

function search(){
    const array = document.getElementsByTagName('li');

    let count = 0;
    const userSubstring = document.getElementById('userInput').value;
    
    for (let index = 0; index < array.length; index++) {
        const city = array[index];
        
        if (userSubstring && city.innerHTML.includes(userSubstring)){
            
            city.style.fontWeight = 'bold';
            count++;
        } else {
            city.style.fontWeight = 'normal';
        }   
    }

    const output = document.getElementById('text');
    output.style.color = 'green';

    let message = `${count} matches found`;
    if(!userSubstring){
        output.style.color = 'red';
        message = "Enter value in the input";
    }

    output.innerHTML = message;
}