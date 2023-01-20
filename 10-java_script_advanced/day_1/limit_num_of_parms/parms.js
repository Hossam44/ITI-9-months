
let fun = function(a,b){
    var err = new Error("Invalid Parameter");
    if(arguments.length!=2)
    {
        throw err;
    }
}

m = fun(1,2);
