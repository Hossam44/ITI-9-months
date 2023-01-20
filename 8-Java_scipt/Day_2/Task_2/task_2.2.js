function Take_num()
{
    var num = parseInt(prompt('Enter Element'));
    return num;
}
function sort_Asc(numbers)
{
    numbers.sort(function(a, b){return a-b});
    return numbers;
}
function sort_Desc(numbers)
{
    numbers.sort(function(a, b){return b-a});
    return numbers;
}

var arr = [];
for(var i=0;i<5;i++)
    arr[i] =Take_num();

document.write("<spam style =\" color:red\" >u 've entered the values of</spam> "+ arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4]);
arr = sort_Desc(arr);
document.write("<spam style =\" color:red\" > <br>ur 'values after being sorted decs</spam> "+ arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4]);
arr = sort_Asc(arr);
document.write("<spam style =\" color:red\" ><br>ur 'values after being sorted Asc</spam> "+ arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4]);
