        var timerid;
        var i = 0;
        var f=0;
        var flying_win,scoll_win,typing_win;
        function flying()   
        {
            flying_win = open("flying_win.html","","width=150,height=150");

            timerid = setInterval(function(){

                flying_win.resizeTo(100,100);
                move_win();

            },5)
        }
        function stop()
        {
            clearInterval(timerid);
            flying_win.focus();
        }
        function open_win()
        {
            win = open("childwin.html","","width=150,height=150");
            win.moveTo(0,0);
        }
        function move_win()
        {
            if(i>=screen.availHeight-120)
                f = 0;
            if(i==0)
                f=1;
            if(f)
            flying_win.moveTo(i++,i++);
            else
            flying_win.moveTo(i--,i--);
        }
        function scrol()
        {
            scoll_win = open("scoll_win.html","","width=150,height=150");
            timerid = setInterval(function(){
            scoll_win.scrollBy(0,5);
            },8)
        }
        function typing()
        {
            var k = 0;
            typing_win = open("flying_win.html","","width=200,height=200");
            arr = "hossam mahmoud metwally metwally ......";
            arr = arr.split("");
            timerid = setInterval(function(){
                if(k>=arr.length)
                {
                    typing_win.clearInterval(timerid);
                    typing_win.close();
                }
                else
                    typing_win.document.write(arr[k++]);
            },80)
        }