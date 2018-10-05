$('.instaslider .left-arrow').click(function(){
    $('#instafeed').animate({
        scrollLeft:"-="+157*3
    },600);
});

$('.instaslider .right-arrow').click(function(){
    $('#instafeed').animate({
        scrollLeft:"+="+157*3
    },600);
});

$('.momentsslider .left-arrow').click(function(){
    $('.moments').animate({scrollLeft:'-='+240},600);
});

$('.momentsslider .right-arrow').click(function(){
    $('.moments').animate({scrollLeft:'+='+240},600);
});