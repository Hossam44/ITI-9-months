
let fun = function(){
    var flag_error = (arguments.length > 0)? 0 : 1;
    var err = new Error("Invalid Parameters");
    var sum = 0;
    for(var i=0;i<arguments.length;i++)
    {
        if(isNaN(arguments[i]))
        {
            flag_error = 1;
        }
        sum += arguments[i];

    }
    
    if(flag_error)
        throw err;
    return sum;
}

m = fun(1,5,6);
