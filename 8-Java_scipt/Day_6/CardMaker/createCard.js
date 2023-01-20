radio_inputs = document.querySelectorAll("input[type='radio']");
for(var i = 0 ;i<radio_inputs.length;i++)
{
    var now = radio_inputs[i];
    console.log(now.value);
    now.addEventListener("click", function(){
        var all_images = document.getElementsByTagName("img");
        //console.log(all_images[1].id);

        for(var j = 0;j<all_images.length;j++)
        {
            if(all_images[j].id==event.target.value)                         //important                  
            {
                all_images[j].style.border="5px solid #555";
                //all_images[j].style.borderColor="red";
            }
            else
            {
                all_images[j].style.border="";
            }
        }
    })
}


var win;
document.getElementById("Generate_id").addEventListener("click",function(){
    text = document.getElementById("text_id").value;
    var cheked_image = "images/"+document.querySelector("input[name='images']:checked").value;

    win = open("welcome.html","","width=800,height=900");
    //win.document.write("lmlm");
    


    win.onload = function(){
        div_1 = win.document.createElement("div");
        div_1.style.textAlign = "center";
        win.document.body.prepend(div_1);
    
        img1 = win.document.createElement("img");
        img1.setAttribute("src",cheked_image);
        img1.setAttribute("width","500px");
        img1.setAttribute("height","600px");
        div_1.append(img1);
    
        par = win.document.createElement("p");
        par.innerText=text;
        par.style.fontSize = "20px";
        par.style.color = "rgb(121, 125, 124)";
        div_1.append(par);
    
        btn = win.document.createElement("input");
        btn.type="button";
        btn.value = "close preview";
        btn.addEventListener("click",function(){
            win.close();
        })
        div_1.append(btn);
    }

    //img1.src="images/"+cheked_image;
    //img1.width="500px";
    //img1.height="700px";
    //console.log(text);
    //win.document.body.append(img1);
})