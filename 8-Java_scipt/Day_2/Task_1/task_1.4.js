        function Take_Name()
        {
            do{
                var massege = prompt('Enter Your Name');
            }while(massege.search(/^[a-zA-Z]+$/i) === -1);
            return massege;
        }
        function Take_Phone()
        {
            do{
                var Phone = prompt('Enter Your Phone');
            }while(Phone.search(/^[0-9]{8,8}$/) === -1);
            return Phone;

        }
        function Take_Moile()
        {
            do{
                var Mobile = prompt('Enter Your Mobile');
            }while(Mobile.search(/^(010|011|012)[0-9]{8,8}$/) === -1);
            return Mobile;
        }
        function Take_Email()
        {
            do{
                var Email = prompt('Enter Your Email');
            }while(Email.search(/^[\w|\d|\W]+@[\w]+\.[\w]+$/) === -1);
            return Email;
        }  
        
        var Name_ = Take_Name();
        
        var Phone_ = Take_Phone();
        var Mobie_ = Take_Moile();
        var Email_ = Take_Email();

        var color = prompt('Enter Your Color','blue');


        document.write("<spam style =\" color:" + color + "\" >Welcome dear guest </spam> "+ Name_);
        document.write("<br><spam style =\" color:" + color + "\" >Your Telephone Number is </spam> "+ Phone_);
        document.write("<br><spam style =\" color:" + color + "\" >Your Mobile Number is </spam> "+ Mobie_);
        document.write("<br><spam style =\" color:" + color + "\" >Your Email Adress is </spam> "+ Email_);
