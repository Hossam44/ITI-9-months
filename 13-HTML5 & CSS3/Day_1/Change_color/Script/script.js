onload = function(){


var my_paragraoh = document.querySelector("h2");
var red,green,blue;

function set_colors(){
    red = document.getElementById("red").value;
    green = document.getElementById("green").value;
    blue = document.getElementById("blue").value;
}

all_ranges = document.querySelectorAll("input[type=range]");
console.log(all_ranges);
for(var i=0;i<all_ranges.length;i++)
{
    all_ranges[i].addEventListener("change",function(){
        set_colors();
        my_paragraoh.style.color= "rgb(" + red + "," + green + "," + blue + ")";
    })
}
}