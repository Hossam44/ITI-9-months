function setcookie(cookieName,cookieValue,expiryDate)
{
    if(expiryDate)
    {
        document.cookie = cookieName +"=" +encodeURIComponent(cookieValue) +";expiryDate="+expiryDate;
    }
}
function getCookie(name) {

    var cookieArr = document.cookie.split(";");
    
    for(var i = 0; i < cookieArr.length; i++) {
        var cookiePair = cookieArr[i].split("=");
        
        if(name == cookiePair[0].trim()) {
            return decodeURIComponent(cookiePair[1]);
        }
    }
    return null;
}
function checkCookie(name) {

    var firstName = getCookie(name);
    
    if(firstName!=null) 
        return true;
    else 
        return false;
}

function deleteCookie(key) {
    var last_month = new Date();
    last_month.setMonth(last_month.getMonth()-1);
    var keyValue = getCookie(key);
    setcookie(key, keyValue, last_month);
}

function GetAllCokie() {
    return document.cookie;
}