        
function Take_num(choose)
{
    var num;
    if(choose == 0)
        num = parseFloat(prompt('What is the value of your circles radius',"Type your radius here"));
    else if(choose==1)
        num = parseFloat(prompt('What is the value you want to calculate its square root',"Type your value here"));
    else
        num = parseFloat(prompt('What is the angle you want to calculate its cos value',"Type your value here"));

    return num;
}
function Cul_area(rad)
{
    return Math.PI*rad*rad;
}
function Square_root(n)
{
    return Math.sqrt(n);
}
function cal_cos(n)
{
    return Math.cos(n*Math.PI/180);
}

var radius = Take_num(0);
var area = Cul_area(radius);
alert("Total area of the circle "+ area );

//----------------------------------------

var m = Take_num(1);
var sqr_m = Square_root(m);
alert("Square root of "+ m +" is "+ sqr_m);
//----------------------------------------

m = Take_num(2);
var cos_m = cal_cos(m);
document.write("cos "+ m + " is " + cos_m.toFixed(2));
