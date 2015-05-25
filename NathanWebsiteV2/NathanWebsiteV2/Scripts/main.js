$(document).ready(function () {


    $("body").on("click", ".nav-tabs li", function (event) {
        $(".nav-tabs li").removeClass("active");
        $(this).addClass("active");
        $(".nav-tabs li").css( "width", "175");
        $(this).css({"width": "350", "font-size": "150%" })
    });

    $("body").on("click", ".nav-tabs li a", function (event) {
       
        var url = $(this).attr("href");
        event.preventDefault();

        $.get(url, function(data){
            $("#page-content").html(data);
        });
    });
       
    $(".about-me").on("click", ".side-nav-bar li a", function (event) {

        var sideUrl = $(this).attr("href");

        $.get(sideUrl, function (data) {
            $(".right-side").html(data);
        });
    });
});