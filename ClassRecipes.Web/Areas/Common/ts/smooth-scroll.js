var SmoothScroll = /** @class */ (function () {
    function SmoothScroll() {
    }
    SmoothScroll.prototype.bindAllLocalAnchors = function () {
        $("a[href^=\\#]").click(function (e) {
            e.preventDefault();
            var dest = $(this).attr('href');
            $('html,body').animate({ scrollTop: $(dest).offset().top }, 'slow');
        });
    };
    return SmoothScroll;
}());
