function Take_num()
{
    var num = parseInt(prompt('Enter Element'));
    return num;
}
function Adding(ar)
{
    var sum=0;
    for(var i=0;i<ar.length;i++)
    {
        sum+=(ar[i]);
    }
    return sum;
}
function Mult(arr)
{
    var mul=1;
    for(var i=0;i<arr.length;i++)
        mul*=arr[i];
    return mul;
}
function Div(arr)
{
    var div=arr[0];
    for(var i=1;i<arr.length;i++)
        div/=arr[i];
    return div;
}

var arr = [];
for(var i=0;i<3;i++)
    arr[i] =Take_num();

var s = Adding(arr);
document.write("<spam style =\" color:red\" >Adding of the 3 valus</spam> "+ arr[0] + "+" + arr[1] + "+" + arr[2] + " = "+s)
s = Mult(arr);
document.write("<spam style =\" color:red\" ><br><br>multiplication of the 3 valus</spam> "+ arr[0] + "*" + arr[1] + "*" + arr[2] + " = "+s);

s = Div(arr);
document.write("<spam style =\" color:red\" ><br><br>division of the 3 valus</spam> "+ arr[0] + "/" + arr[1] + "/" + arr[2] + " = "+s);