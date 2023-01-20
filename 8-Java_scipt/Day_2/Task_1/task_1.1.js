      
function Take_String()
{
    var massege = prompt('Enter Your Massage','');
    return massege;
}
function Take_letter()
{
    var leter = prompt('Enter Your Letter','');
    return leter;
}
function Confirm_Sensitiviyt()
{
    var massege = confirm("Confirm un Sensitivity");
    return massege;
}

function Count_Letters(Msg,Ltr)
{
    var count = 0;
    for(var i=0;i<Msg.length;i++)
    {
        if(Msg[i]==Ltr)
            count++;
    }
    return count;
}  

var count_print = 0;      
var message = Take_String();
var letter = Take_letter();
if(Confirm_Sensitiviyt())
{
    count_print=Count_Letters(message,letter);
}
else
{
    message = message.toUpperCase();
    letter = letter.toUpperCase();
    count_print=Count_Letters(message,letter);
}
document.write("<h"+1+">"+"Number Of Letters : "+count_print+"</h"+1+">");
