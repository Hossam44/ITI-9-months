
let reverse_fun = function(){
    return Array.from([].reverse.call(arguments));
}

let reverse_fun_2 = function(){
    return Array.from([].reverse.apply(arguments));
}

w = reverse_fun(1,2,3,4);

m = reverse_fun_2(1,2,3);