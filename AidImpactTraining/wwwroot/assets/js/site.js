// Whenever links are clicked inside of the navigation section request that content with ajax
$(function () {
    $("#blog-asp").on("click", ".pager a", function () {
        var url = $(this).attr("href");

        $("#blog-asp").load(url);

        return false;
    })
})