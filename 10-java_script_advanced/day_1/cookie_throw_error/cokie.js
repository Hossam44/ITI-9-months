document.getElementById("bt_id").onclick = function(){

    var Name = document.getElementById("name_id").value;
    var Age = document.getElementById("age_id").value;
    var genger = document.querySelector('input[name="Gen"]:checked').value;
    var color = document.getElementById("sel_id").value;
    var dat = new Date();
    if(getCookie("Count") == null)
    {
        setcookie("Count","1",dat);
    }

    setcookie("Name",Name,dat);
    setcookie("Age",Age,dat);
    setcookie("genger",genger,dat);
    setcookie("color",color,dat);
    window.location.assign("welcome_page.html")

}