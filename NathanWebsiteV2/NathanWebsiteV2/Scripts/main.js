$(document).ready(function () {


    $("body").on("click", ".nav-tabs li", function (event) {
        $(".nav-tabs li").removeClass("active");
        $(this).addClass("active");
        $(".nav-tabs li").css( "width", "175");
        $(this).css("width", "325")
    });

    
   
    $("body").on("click", ".nav-tabs li a", function (event) {

        $(".nav-tabs li a").removeAttr("style");
        $(this).css({ "width": "325", "background-color": "black" })
        var url = $(this).attr("href");
        event.preventDefault();

        $.get(url, function(data){
            $("#page-content").html(data);
        });
    });
       
    $("body").on("click", ".side-nav-bar li", function (event) {
       

        var sideUrl = $(this).data("link");
      
        event.preventDefault();
        $.get(sideUrl, function (data) {
            $(".right-side").html(data);
        });
    });
});