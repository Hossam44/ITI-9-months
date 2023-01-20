onload = function(){

var video_=document.querySelector("video");
var all_buttons = document.querySelectorAll("div input");
var minites,seconds;
var time_span = document.getElementById("time")
all_buttons[0].max = video_.duration;

all_buttons[0].addEventListener("change",function(){  //Slider to Control the Sound
    video_.currentTime = this.value;
})

all_buttons[1].addEventListener("click",function(){  // Play Video
    video_.play();
})
all_buttons[2].addEventListener("click",function(){  //Pause Video
    video_.pause();
})
all_buttons[3].addEventListener("click",function(){  //Go to the Start of video
    video_.currentTime = 0;
})
all_buttons[4].addEventListener("click",function(){  //back Ten Seconds
    (video_.currentTime>10) ? video_.currentTime-=10 : video_.currentTime=0
})
all_buttons[5].addEventListener("click",function(){  //forward TEn Seconds
    (video_.currentTime+10<video_.duration) ? video_.currentTime+=10 : video_.currentTime=video_.duration;
})

all_buttons[6].addEventListener("click",function(){  //Go to the End of video
    video_.currentTime = video_.duration;
})

all_buttons[7].addEventListener("change",function(){  //Slider to Control the Sound

    video_.volume = parseInt(this.value)/100;
})

all_buttons[8].addEventListener("click",function(){  //Mute The Video
    video_.volume = 0;
})

all_buttons[9].addEventListener("change",function(){  //Slider to Control the speed
    (this.value<=10) ? video_.playbackRate=this.value/10 : video_.playbackRate=this.value-10;

})


function set_time(){
    time = parseInt(video_.currentTime);
    minites = parseInt(time/60);
    seconds = time - (minites*60);
    if(seconds<=9)
        seconds = "0"+ seconds;
}


video_.ontimeupdate = function(){
    set_time();
    all_buttons[0].value = video_.currentTime;
    time_span.innerHTML = minites+":"+seconds;
}
}
