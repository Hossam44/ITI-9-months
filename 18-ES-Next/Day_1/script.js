
// First Task Swap Numbers
//----------------------------------------------------------------------------------

var a=5;
var b=10;
console.log(`Before the Swap ${a}  ${b}`)

var [b,a]=[a,b];
console.log(`After the Swap ${a}  ${b}`)

//----------------------------------------------------------------------------------

//Second Task Min and Max with spread and Rest
//----------------------------------------------------------------------------------

var arr = [1,2,3,4,5,6];

function min_max(...parms){
    return [Math.min(...parms),Math.max(...parms)]
}

var [min,max] = min_max(...arr);
console.log(`The Min is ${min} and The Max is ${max}`);

//----------------------------------------------------------------------------------

//Third Task
//----------------------------------------------------------------------------------

var fruits = [1,"apple","strawberry","banana","orange","mango"];

//-------------- a
var condtion = (currentValue) => (typeof currentValue === 'string');
var IsElemntsStrings = fruits.every(condtion);
console.log(IsElemntsStrings);
//-------------- 

//-------------- b
condtion = (currentValue) => (typeof currentValue === 'string' && currentValue.startsWith('a'));

IsElemntsStrings = fruits.some(condtion);
console.log(IsElemntsStrings);
//-------------- 

//-------------- c

condtion = (currentValue) => (typeof currentValue === 'string' && (currentValue.startsWith('b')||currentValue.startsWith('s')));
var filterd_fruits = fruits.filter(condtion);
console.log(filterd_fruits);
//-------------- 

//-------------- d
condtion = (currentValue) => ("I Like " + currentValue);
var mapped_fruits = fruits.map(condtion);
console.log(mapped_fruits);
//-------------- 

//-------------- e
condtion = (currentValue) => (console.log(currentValue));
mapped_fruits.forEach(condtion);
//-------------- 

//----------------------------------------------------------------------------------
