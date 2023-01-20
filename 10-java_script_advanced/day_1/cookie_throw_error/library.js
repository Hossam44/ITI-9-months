var err = new Error("Invalid In Parameters");
function setcookie(cookieName,cookieValue,expiryDate)
{
    if((arguments.length <2 || arguments.length > 3)  || (typeof cookieName !== 'string'))
        throw err;
    if(arguments.length===3 && expiryDate instanceof Date)
        document.cookie = cookieName +"=" +encodeURIComponent(cookieValue) +";expiryDate="+expiryDate;
    else
        document.cookie = cookieName +"=" +encodeURIComponent(cookieValue);

}

function getCookie(name) {

    if(arguments.length!=1 && (typeof cookieName !== 'string'))
        throw err;
    var cookieArr = document.cookie.split(";");
    
    for(var i = 0; i < cookieArr.length; i++) {
        var cookiePair = cookieArr[i].split("=");
        
        if(name == cookiePair[0].trim()) {
            return decodeURIComponent(cookiePair[1]);
        }
    }
    throw err;
}


function checkCookie(name) {

    if(arguments.length!=1 || (typeof cookieName !== 'string'))
        throw err;
    var firstName = getCookie(name);
    
    if(firstName!=null) 
        return true;
    else 
        throw err;
}

function deleteCookie(key) {
    if(arguments.length!=1 || (typeof cookieName !== 'string'))
        throw err;
    var last_month = new Date();
    last_month.setMonth(last_month.getMonth()-1);
    var keyValue = getCookie(key);
    setcookie(key, keyValue, last_month);
}

function GetAllCokie() {
    return document.cookie;
}