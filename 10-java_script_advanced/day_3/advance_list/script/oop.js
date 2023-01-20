var err = new Error("Not Allowed");
linked_list = function(start=0,end=0,step=0){

    this.start=start;
    this.end=end;
    this.step=step;
    var arr = [];
    this.toString = function(){
        console.log("Our New To String")
        console.log("List :")
        for(var i=0;i<arr.length;i++)
        {
            console.log(arr[i])
        }
    }
    var fill = (function(){
        var value = 0;
        for(var i=start;i<end;i++)
        {
            arr[i]={ "val" : value };
            value+=this.step;
        }
    }).bind(this);
    fill();
    Object.defineProperty(this, "get", {
        value: function (index) {
            if(arr.length > index)
                return arr[index];
            else
            {
                throw err;
            }       
        },
        writable:false,
        configurable: false,
        enumerable: false
    });

    Object.defineProperty(this, "push_", {
        value: function (value) {
            if(arr.length == 0 || arr[arr.length-1]["val"]<value)
                arr.push({ "val" : value });
            else
            {
                throw err;
            }       
        },
        writable:false,
        configurable: false,
        enumerable: false
    });

    Object.defineProperty(this, "pop_", {
        value: function () {
            if(arr.length>0)
            {
                arr.pop();
            }
            else
            {
                throw err;
            }    
        },
        writable:false,
        configurable: false,
        enumerable: false
    });


    Object.defineProperty(this, "enqueue", {
        value: function (value) {
            if(arr.length == 0 || arr[0].val > value)
                arr.unshift({ "val" : value });
            else
            {
                throw err;
            }
        },
        writable:false,
        configurable: false,
        enumerable: false
    });


    Object.defineProperty(this, "dequeue", {
        value: function () {
            if(arr.length>0)
            {
                arr.shift();
            }
            else
            {
                throw err;
            }
        },
        writable:false,
        configurable: false,
        enumerable: false
    });


    Object.defineProperty(this, "insert", {
        value: function (index ,value) {
            if(index >=0 && index<=arr.length)
            {
                if(arr.length==0 || (index == 0 && arr[0].val > value))
                {
                    console.log("sds");
                    arr.splice(index, 0, { "val" : value });
                }
                else if(arr[index].val > value && arr[index-1].val < value)
                {
                    arr.splice(index, 0, { "val" : value });
                }
                else
                {
                    throw err;
                }
            }
        },
        writable:false,
        configurable: false,
        enumerable: false
    });


    Object.defineProperty(this, "remove", {
        value: function (value) {
            let flag = 1;
            for(var i=0;i<arr.length;i++)
            {
                if(arr[i].val===value)
                {
                    flag = 0;
                    arr.splice(i,1);
                }
            }
            if(flag)
            {
                var err_notfound = new Error("Not Found");
                throw err_notfound;
            }
        },
        writable:false,
        configurable: false,
        enumerable: false
    });


    Object.defineProperty(this, "is_dulicat", {
        value: function (value) {
            for(var i=0;i<arr.length;i++)
            {
                if(arr.val===value)
                    return true;
            }
            return false;
        },
        writable:false,
        configurable: false,
        enumerable: false
    });


    Object.defineProperty(this, "display", {
        value: function () {
            for(var i=0;i<arr.length;i++)
            {
                console.log(arr[i].val)
            }
        },
        writable:false,
        configurable: false,
        enumerable: false
    });

    Object.defineProperty(this, "Length", {
        value: function () {
            return arr.length;
        },
        writable:false,
        configurable: false,
        enumerable: false
    });

    Object.defineProperty(this, "isempty", {
        value: function () {
            return (arr.length===0);
        },
        writable:false,
        configurable: false,
        enumerable: false
    });
}