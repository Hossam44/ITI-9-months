
const path = "D:/9_months/NodeJs/day_2/Client/";
const http = require("http");
const fs = require("fs");

let mainHtml = fs.readFileSync(path + "main.html").toString();
let profileHtml = fs.readFileSync(path + "profile.html").toString();
let script = fs.readFileSync(path + "script.js").toString();
let all_users = fs.readFileSync("D:\\9_months\\NodeJs\\day_2\\Client\\all_Users.html").toString();
let Json_data = fs.readFileSync(path + "../Json_data/list_data.json").toString();
let styleCSS = fs.readFileSync(path + "style.css").toString();
let favIcon = fs.readFileSync(path + "Icons/favicon.ico");

let userName="";
let Mobile="";
let Adress="";
let Email="";

http.createServer((req, res)=>{
    console.log(req.url);
    // GET
    if(req.method == "GET"){
        switch(req.url){
            case '/':
            case '/main.html':
            case '/client/main.html':
                res.write(mainHtml);
            break;

            case '/':
            case '/profile.html':
            case '/client/profile.html':
                res.write(profileHtml);
            break;

            case '/script.js':
            case '/Client/script.js':
                res.write(script);
            break;

            case '/style.css':
            case '/client/style.css':
                res.write(styleCSS);
            break;

            case '/favicon.ico':
            case '/client/favicon.ico':
            case '/client/Icons/favicon.ico':
                res.write(favIcon);
            break;

            case '/All_data':
                res.write(Json_data);
            break;
            
            case '/all_Users.html?':
                res.write(all_users);
            break;

            default:
                    res.write(mainHtml);
            break;
        }
        res.end();
    }
    
    // POST
    else if(req.method=="POST"){
        req.on("data",(data)=>{
            all_Data = data.toString().split("&");

            userName = all_Data[0].toString().split("=")[1];
            Mobile = all_Data[1].toString().split("=")[1];
            Adress = all_Data[2].toString().split("=")[1];
            Email = (all_Data[3].toString().split("=")[1]).replace("%40","@");

            fs.readFile(path + "../Json_data/list_data.json", 'utf8', (err, jsonString) => {
            if (err) {
              console.log('Error reading file:', err);
              return;
            }
              
            try {
                    let list_of_data = JSON.parse(jsonString);
                    console.log(typeof(list_of_data));
                    list_of_data.users.push({"userName": userName, "Mobile": Mobile, "Adress": Adress, "Email": Email});


                      // Convert the array back to JSON
                    const newJsonString = JSON.stringify(list_of_data);

                    // Write the new JSON string to a file
                    fs.writeFileSync(path + "../Json_data/list_data.json", newJsonString, err => {
                    if (err) {
                        console.log('Error writing file:', err);
                        return;
                    }

                    console.log('New data written to file!');
                    });


                } catch (err) {
                  console.log('Error parsing JSON string:', err);
                }
            });



        })
        req.on("end",()=>{
            profileHtml=profileHtml.replace("{clientName}",userName)
            profileHtml=profileHtml.replace("{MobileNumber}",Mobile)
            profileHtml=profileHtml.replace("{Address}",Adress)
            profileHtml=profileHtml.replace("{Email}",Email)
            console.log(profileHtml);
            res.write(profileHtml);
            res.end();
        })
    }
    //#endregion

    
    //#region Default
    else{
        res.end("Please Select Common Method");
    }
    //#endregion
}).listen(7000,()=>{console.log("Listining on Port 7007")})