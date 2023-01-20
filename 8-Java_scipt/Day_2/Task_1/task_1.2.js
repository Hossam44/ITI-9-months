        function Take_String()
        {
            var msg = prompt('Enter Your Massage','');
            return msg;
        }
        function Confirm_Sensitiviyt()
        {
            var msg = confirm("Confirm Sensitivity");
            return msg;
        }
        
        function Check_Palindrome(msg)
        {
            for(var i=0;i<msg.length/2;i++)
            {
                if(msg[i]!=msg[msg.length-1-i])
                {
                    return 0;
                }
            }
            return 1;
        }  
        var message = Take_String();

        if(!Confirm_Sensitiviyt())
        {
            message = message.toUpperCase();
        }

        if(Check_Palindrome(message))
        {
            document.write("String is Palindrome");
        }
        else
        {
            document.write("String is not Palindrome");
        }