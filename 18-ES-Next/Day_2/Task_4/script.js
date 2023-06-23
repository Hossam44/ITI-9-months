var obj={
    prop1:1,
    prop2:2,
    prop3:3,
    prop4:4,
    prop5:5,
    [Symbol.iterator] :function *(){
        for(key in obj)
        {
            yield key + " " + obj[key];
        }
     }
}
var iter = obj[Symbol.iterator]();
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());

for(element of obj[Symbol.iterator]())
{
    console.log(element);
}
