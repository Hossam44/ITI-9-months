var err = new Error("Not Allowed");
box = function(height=0, width=0, length=0, material=0,content=[]){


    this.toString = function(){
        console.log(`height: ${this.height} width: ${this.width} length: ${this.length} Num Of Boxes: ${this.numOfBooks()}`)
    }

    Object.defineProperty(this, "height", {
        value: height,
    });
    Object.defineProperty(this, "width", {
        value: width,
    });
    Object.defineProperty(this, "length", {
        value: length,
    });
    Object.defineProperty(this, "material", {
        value: material,
    });
    Object.defineProperty(this, "content", {
        value: content,
    });
    Object.defineProperty(this, "addBook", {
        value: function(book){
            content.push(book);
        },
    });
    Object.defineProperty(this, "numOfBooks", {
        value: function(book){
            return content.length;
        },
    });
    Object.defineProperty(this, "deleteByTitle", {
        value: function(title){
            var flag=1;
            for(var i=0;i<content.length;i++)
            {
                if(flag){
                    if(content[i].title=title)
                    {
                        content.splice(i,1);
                        flag=0;
                    }
                }
            }
        },
    });
}
box.prototype.valueOf = function(){
    return this.numOfBooks();
}
book = function(title="", numofChapters=0, author="", numofPages=0, publisher="", numofCopies=0){

    book.count++;
    Object.defineProperty(this, "title", {
        value: title,
    });
    Object.defineProperty(this, "numofChapters", {
        value: numofChapters,
    });
    Object.defineProperty(this, "author", {
        value: author,
    });
    Object.defineProperty(this, "numofPages", {
        value: numofPages,
    });
    Object.defineProperty(this, "publisher", {
        value: publisher,
    });
    Object.defineProperty(this, "numofCopies", {
        value: numofCopies,
    });
}
book.count=0;
book.numOfCreatedBooks = function(){
    return book.count;
}