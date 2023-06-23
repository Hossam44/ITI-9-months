function * fib_V1(n){
   var [first,second] = [0,1];
   if(n>=0)
      yield 0;
   for(var i =0;i<n-1;i++){
      yield first+second;
      first += second;
      second = first - second;
   }
}
console.log("First Version");

var iter = fib_V1(5);
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());


console.log("Second Version");

function * fib_V2(n){
   var [first,second] = [0,1];
   if(n>=0)
      yield 0;
   while(first + second <= n ){
      first += second;
      second = first - second;
      yield first;
   }
}

var iter = fib_V2(10);
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
