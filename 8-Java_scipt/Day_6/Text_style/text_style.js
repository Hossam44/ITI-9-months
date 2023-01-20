var radio_inputs =  document.querySelectorAll("input[type = 'radio']");
for(var i = 0 ;i<radio_inputs.length;i++)
{
    var now = radio_inputs[i];
    now.addEventListener("click", function(){
        document.getElementById("par_id").style[event.target.name]=event.target.value;
    })
}