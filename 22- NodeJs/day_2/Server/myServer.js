
let {myClass} = require("../Modules/myModule");//{} ==> exports

let Ticket = new myClass();
Ticket.AddItem(1, 1,"cairo","Dubai","3/29/2023");   //insert
console.log("\n***************************************************");
Ticket.Display_Ticket(1);

let my_Ticket = Ticket.get_Ticket(1);    //get

my_Ticket.arrival_Airports = "ALex";

Ticket.update_Ticket(1,my_Ticket);

console.log("\n***************************************************");
console.log("Display After Update any thing");
console.log("\n***************************************************");
Ticket.Display_Ticket(1);
console.log("\n***************************************************");


