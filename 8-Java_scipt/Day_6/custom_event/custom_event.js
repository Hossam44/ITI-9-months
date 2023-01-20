var myEvent = new Event("timeout");
var timer_id;
var wi;
document.getElementById("text_id").addEventListener("click",function(){
    clearTimeout(timer_id);
})
document.getElementById("sub_id").addEventListener("timeout",function(){
    //wi = open('time_out.html',"","");
    alert("Time_out");
})
document.getElementById("sub_id").addEventListener("click",function(event){
    event.preventDefault();
    clearTimeout(timer_id);
    console.log("nsldnaskldasnd");
    if(confirm("Want To Continue"))
    {

        alert("Ok");
        window.location.assign('https:google.com');
    
    }
    else
    {
        document.getElementById("text_id").value = "";
        timer_id = setTimeout(function(){
            document.getElementById("sub_id").dispatchEvent(myEvent);
        },2000);
    }
})

timer_id = setTimeout(function(){
    document.getElementById("sub_id").disabled ="false";
    document.getElementById("sub_id").dispatchEvent(myEvent);
},2000);
