var rect = function(hieght=0,width=0){

    this.hieght = hieght;
    this.width = width;
    this.getHieght = function(){
        return this.hieght;
    };
    this.getWidth = function(){
        return this.width;
    };
    this.area = function(){
        return this.width*this.hieght;
    }
    this.perimeter = function(){
        return (this.width+this.hieght)*2;
    }
    this.display = function(){
        console.log(`Heigth :${this.hieght}  Width :${this.width}  area :${this.area()}   perimeter :${this.perimeter()}`)
    }
}

var r1 = new rect(5,5);
