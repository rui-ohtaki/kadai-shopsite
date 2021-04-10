$(window).on("load", function() {
    $("#menu-body-2 img").click(function() {
        let img_src = $(this).attr("src");
        $("#menu-body-1 img").attr("src", img_src);
    });
});
