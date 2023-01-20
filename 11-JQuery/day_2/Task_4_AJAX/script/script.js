$(function(){
    var data;
    $.ajax({
        method: "Get",
        url: "../Json/rockbands.json", 
        success: function(result){
            data = result;
            console.log(result);
            for(i in result){
                $("#bands").append("<option>"+i+"</option>");
            }
        }
    });
    $("#bands").change(function(){
        var band = $(this).val();
        $("#Artist").html("").append("<option>"+"Select Artist"+"</option>");
        for(var art in data[band])
        {
            $("#Artist").append("<option value="+data[band][art].value+">"+data[band][art].name+"</option>");
        }

    })
    $("#Artist").change(function(){
        window.location.href = $('#Artist option:selected').val();
    })

})