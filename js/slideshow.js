$(window).on("load", function() {
    $("#menu-body-2 img").click(function() {
        let img_src = $(this).attr("src");
        $("#menu-body-1 img").attr("src", img_src);
    });
        $("#menu-body-bread-2 img").click(function() {
        let img_src = $(this).attr("src");
        $("#menu-body-bread-1 img").attr("src", img_src);
    });
        $("#menu-body-pasta-2 img").click(function() {
        let img_src = $(this).attr("src");
        $("#menu-body-pasta-1 img").attr("src", img_src);
    });
        $("#menu-body-sweets-2 img").click(function() {
        let img_src = $(this).attr("src");
        $("#menu-body-sweets-1 img").attr("src", img_src);
    });
});
