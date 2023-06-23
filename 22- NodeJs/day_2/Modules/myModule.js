class myClass{
    Items = [];//Property
    AddItem(seat_Num, flight_Num,arrival_Airports,departure_Airports,Travelling_Date) {
       let newItem = {seat_Num, flight_Num,arrival_Airports,departure_Airports,Travelling_Date};
       this.Items.push(newItem);
    }
    Display_Ticket(ID) 
    { 
       console.log(`Seat Number : ${this.Items[parseInt(ID)-1].seat_Num}`);
       console.log(`flight_Num : ${this.Items[ID-1].flight_Num}`);
       console.log(`arrival_Airports : ${this.Items[ID-1].arrival_Airports}`);
       console.log(`departure_Airports : ${this.Items[ID-1].departure_Airports}`);
       console.log(`Travelling_Date : ${this.Items[ID-1].Travelling_Date}`);
    }
    get_Ticket(ID){
        return this.Items[ID-1];
    }
    update_Ticket(ID,new_Item){
        this.Items[ID-1] = new_Item;
    }
}

module.exports = {
    myClass
}