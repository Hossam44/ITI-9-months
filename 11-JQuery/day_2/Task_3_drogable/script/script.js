$( function() {
    $( ".rabbit" ).draggable();
    $( ".blackhole" ).droppable({
        drop: function( event, ui ) {
            $(".rabbit").hide("explode", 3000);
        }
    });
});

