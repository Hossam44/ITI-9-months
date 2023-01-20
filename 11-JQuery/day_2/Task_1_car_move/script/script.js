$(function(){
    $(".car").animate({
        "left" : "1240px"
    }, 10000);

    var timer = setInterval(function(){
        var leftvalue = Math.round($(".car").offset().left);
        $(".move").text("<img src='12.gif' style='left: " + leftvalue + "'/>" );
    },1 )
    
})
