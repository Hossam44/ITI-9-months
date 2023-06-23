const fs = require("fs");
const exp = require("express");
const app = exp();
const path = require("path");
let PORT = process.env.PORT || 7008;
const bodyParser = require("body-parser");
console.log(path.join(__dirname,"../Client/main.html"));
/** JSON.parse() */
/**MiddleWare */

app.use(bodyParser.json())
app.use(bodyParser.urlencoded({extended:true}))

//root
//main
app.get("/",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))
})
app.get("/main.html",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))
})
app.get("/client/main.html",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))
})

//profile html
app.get("/profile.html",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/profile.html"))
})
app.get("/client/profile.html",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/profile.html"))
})

//js
app.get("/script.js",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/script.js"))
})
app.get("/Client/script.js",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/script.js"))
})

//style
app.get("/style.css",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/style.css"))
})
app.get("/client/style.css",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/style.css"))
})

//favicon
app.get("/favicon.ico",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Icons/favicon.ico"))
})
app.get("/client/favicon.ico",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Icons/favicon.ico"))
})
app.get("/client/Icons/favicon.ico",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Icons/favicon.ico"))
})

//users data
app.get("/All_data",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Json_data/list_data.json"))
})

//users_table page
app.get("/all_Users.html?",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/all_Users.html"))
})

app.post("/profile.html",(req,res)=>{
    let { name, mobile, address, email} = req.body    
    console.log(email);
    console.log(mobile);
    console.log(name);
    console.log(address);

    fs.readFile(path.join(__dirname,"../Json_data/list_data.json"), 'utf8', (err, jsonString) => {
        if (err) {
        console.log('Error reading file:', err);
        return;
        }
      
        try {
            var list_of_data = JSON.parse(jsonString);
            console.log(typeof(list_of_data));
            list_of_data.users.push({"userName": name, "Mobile": mobile, "Adress": address, "Email": email});


              // Convert the array back to JSON
            const newJsonString = JSON.stringify(list_of_data);

            // Write the new JSON string to a file
            fs.writeFileSync(path.join(__dirname,"../Json_data/list_data.json"), newJsonString, err => {
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

    let path_to_profile = path.join(__dirname,"../Client/profile.html");

    let profileHtml = fs.readFileSync(path.join(__dirname,"../Client/temp.html")).toString()

    .replace("{clientName}",name)
    .replace("{MobileNumber}",mobile)
    .replace("{Address}",address)
    .replace("{Email}",email);

    fs.writeFile(path_to_profile, profileHtml, (err) => {
        if (err) throw err;
        console.log('The file has been updated!'); 
    res.sendFile(path_to_profile);
    })

})


app.listen(PORT,()=>{console.log("http://www.localhost:"+PORT)});
