var str = "hossam mahmoud metwally";
var obj = {
    [Symbol.replace]:function(st,len){
        if(st.length>len)
            return st.substring(0, len)+"...";
        return st;
    }
}
console.log(str.replace(obj,15));
