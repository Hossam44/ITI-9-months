var cnt=1;
$(".hidden_id").hide();

$("#About_id").click(function(){
    $(".hidden_id").hide();
    $("#div_2").show();
})
$("#Gallary_id").click(function(){
    $(".hidden_id").hide();
    $("#div_3").show();
})
$("#services_id").click(function(){
    $(".hidden_id").hide();
    $("#div_4").slideDown();
})
$("#complain_id").click(function(){
    $(".hidden_id").hide();
    $("#div_5").show();
})

$("#left_id").click(function(){
    cnt = (cnt === 1)? 8:cnt-1;
    $("#img_id").attr("src",`../images/${cnt}.jpg`);
})

$("#right_id").click(function(){
    cnt = (cnt === 8)? 1:cnt+1;
    $("#img_id").attr("src",`../images/${cnt}.jpg`);
})

$("#send_id").click(function(){

    $(".hidden_id").hide();
    
    $("#name_reg_id")[0].value = ($("#name_id")[0].value);
    $("#Email_reg_id")[0].value = ($("#Email_id")[0].value);
    $("#Phone_reg_id")[0].value = ($("#Phone_id")[0].value);


    $("#complain_reg_id")[0].value = ($("#complain_msg_id")[0].value);


    $("#div_6").show();

})

$("#Edit_id").click(function(){

    $(".hidden_id").hide();
    $("#div_5").show();

})