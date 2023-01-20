var timer_id,top_=10,left_=10,right_=570,cnt=1,flag=0,le;
document.getElementById("move_btn").addEventListener("click",function(){
    if(flag==0)
    {
        timer_id = setInterval(function(){
            
            var all_spam = document.getElementsByTagName("span");
            var all_div = document.getElementsByTagName("div");
            
            all_spam[0].innerHTML = left_;
            all_spam[1].innerHTML = right_;


            all_div[1].style.top = top_.toString()+"px";
            all_div[2].style.left = left_.toString()+"px";
            all_div[3].style.left = right_.toString()+"px";
            
            if(top_>=570)
            {
                cnt *=-1;
            }
            else if(top_==10)
            {
                console.log(top);
                cnt=1;
            }
            top_+=cnt;
            left_+=cnt;
            right_-=cnt;
        },5)
        event.target.value = "Stop";
        flag = 1;
    }
    else
    {
        clearInterval(timer_id);
        flag=0;
        event.target.value = "Go";
    }
})

document.getElementById("reset_btn").addEventListener("click",function(){
    top_=10,left_=10,right_=570;
})