function addElement(){

    const userInput = document.getElementById("input");
    const errorElement = document.getElementById("errorMsg");

    if(!userInput.value){
        errorElement.innerHTML = "Error!";
        errorElement.style.color = "Red";
        return;
    }
    
    const ul = document.getElementById("items");
    const li = document.createElement("li");
    li.innerHTML = userInput.value;
    
    const deleteBtn = document.createElement("span");
    deleteBtn.style.width = "20px";

    const a = document.createElement('a');
    a.href = "#";
    a.innerHTML = "[Delete]";

    a.addEventListener("click", function(){
        ul.removeChild(li);
    });

    deleteBtn.appendChild(a);
    li.appendChild(deleteBtn);
    ul.appendChild(li);

    userInput.value = '';
    errorElement.innerHTML = '';
}