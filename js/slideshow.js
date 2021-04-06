$(window).on("load", function() {
    $("#thumbnail img").click(function() {
        let img_src = $(this).attr("src");
        $("#slideshow-image img").attr("src", img_src);
    });
});
