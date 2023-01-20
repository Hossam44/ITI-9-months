var err = new Error("Not Allowed");
linked_list = {

    arr : [],

    push_ : function(value){
        if(this.arr.length == 0 || this.arr[this.arr.length-1]["val"]<value)
            this.arr.push({ "val" : value });
        else
        {
            throw err;
        }
    },

    pop_ : function(){
        if(this.arr.length>0)
        {
            this.arr.pop();
        }
        else
        {
            throw err;
        }
    },

    enqueue : function(value){
        if(this.arr.length == 0 || this.arr[0].val > value)
            this.arr.unshift({ "val" : value });
        else
        {
            throw err;
        }
    },

    dequeue : function(){
        if(this.arr.length>0)
        {
            this.arr.shift();
        }
        else
        {
            throw err;
        }

    },

    insert : function(index ,value){
        if(index >=0 && index<=this.arr.length)
        {
            if(this.arr.length==0 || (index == 0 && this.arr[0].val > value))
            {
                console.log("sds");
                this.arr.splice(index, 0, { "val" : value });
            }
            else if(this.arr[index].val > value && this.arr[index-1].val < value)
            {
                this.arr.splice(index, 0, { "val" : value });
            }
            else
            {
                throw err;
            }
        }
    },

    remove : function(value){
        let flag = 1;
        for(var i=0;i<this.arr.length;i++)
        {
            if(this.arr[i].val===value)
            {
                flag = 0;
                this.arr.splice(i,1);
            }
        }
        if(flag)
        {
            var err_notfound = new Error("Not Found");
            throw err_notfound;
        }
    },

    is_dulicat : function(value)
    {
        for(var i=0;i<arr.length;i++)
        {
            if(this.arr.val===value)
                return true;
        }
        return false;
    },

    display: function(){
        for(var i=0;i<arr.length;i++)
        {
            console.log(this.arr[i].val)
        }
    },

    Length : function()
    {
        return this.arr.length;
    },

    isempty : function()
    {
        return (this.arr.length===0);
    }
}