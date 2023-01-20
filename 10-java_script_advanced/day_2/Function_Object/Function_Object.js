
var obj = {
    id:"SD-10",
    location:"SV",
    addr:"123 st.",
    getSetGen: function(){

        var current = this;
        for(i in current)
        {
            (function(i){
                if(typeof(current[i]) != "function"){
                    current["get"+i] = function(){
                        return current[i];
                    }
                    current["set"+i] = function(value){
                        current[i] = value;
                    }
                }
            })(i);
        }
    }
}

var user = {
    name : "ali",
    age : 15,      
    }


obj.getSetGen.call(user);
console.log(user);
console.log(user.getage());
console.log(user.getname());

//console.log(user.setage(20));
//console.log(user.setname("hossam"));

//console.log(user.getname());
//console.log(user.getage());


//console.log(user.getname());

