var div_2 = document.getElementsByTagName("div")[0];
div_2.classList.remove("center");
div_2.classList.add("right")

var div_1 = document.createElement("div");
var img_1 = document.createElement("img");
div_1.prepend(img_1);
img_1.setAttribute("src","images/dom.jpg");
div_1.classList.add("left");
//div_1.style.textAlign= "left";
document.body.append(div_1);

document.getElementById("navigation").classList.add("center");
