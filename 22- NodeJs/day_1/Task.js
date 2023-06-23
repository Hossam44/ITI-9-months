
const fs = require("fs");
const http = require("http");
http.createServer((req,res)=>{
    //logic
    if(req.url != "/favicon.ico"){
        console.log(req.url);
        var result = myFunction(req.url);
        console.log(result);
        fs.appendFile("D:/9_months/NodeJs/day_1/operator.txt",`The result ${result} 
`,()=>{})
        res.writeHead(200,"ok",{"content-type":"text/plain"})
        res.write(`<h1>The result ${result} </h1>`)
        res.end();
    }
}).listen(8000)

function myFunction(url) {
    var oplist = url.split("/")
    let res = parseInt(oplist[2]);
    switch(oplist[1]) {
        case "add":
            for(let i=3;i<oplist.length;i++)
            {
                res+= parseInt(oplist[i]);
            }
          return res;
          break;
        case "sub":
            console.log(res);
            for(let i=3;i<oplist.length;i++)
            {
                res = res -  parseInt(oplist[i]);
            }
            return res;
          break;
        case "mul":
            for(let i=3;i<oplist.length;i++)
            {
                res*= parseInt(oplist[i]);
            }
            return res;
            break;
        case "div":
            for(let i=3;i<oplist.length;i++)
            {
                res/= parseInt(oplist[i]);
            }
            return res;
        break;
        default:
          return "Not Valid Operator"
      }
  }
