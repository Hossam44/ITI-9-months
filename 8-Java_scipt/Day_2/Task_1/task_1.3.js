function Take_String()
{
    var msg = prompt('Enter Your Massage','');
    return msg;
}
function get_max(msg)
{
    var max=0;
    for(var i=0;i<msg.length;i++)
    {
        if(msg[i].length>msg[max].length)
        {
            max = i;
        }
    }
    return max;
}

var message = Take_String();
var max_size=0;

message = message.split(" ");
max_size = get_max(message);
document.write("Longest String : "+message[max_size]);