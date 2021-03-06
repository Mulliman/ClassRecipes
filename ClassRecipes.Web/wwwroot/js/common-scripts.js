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
/// <reference path="smooth-scroll.ts" />
var scroller = new SmoothScroll();
scroller.bindAllLocalAnchors();
$(function () {
    $('.sidenav').sidenav();
    $('.parallax').parallax();
    $('.materialboxed').materialbox();
});

//# sourceMappingURL=data:application/json;charset=utf8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNtb290aC1zY3JvbGwudHMiLCJjb21tb24taW5pdC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFBQTtJQUVJO0lBQ0EsQ0FBQztJQUVELDBDQUFtQixHQUFuQjtRQUNJLENBQUMsQ0FBQyxjQUFjLENBQUMsQ0FBQyxLQUFLLENBQUMsVUFBVSxDQUFDO1lBQy9CLENBQUMsQ0FBQyxjQUFjLEVBQUUsQ0FBQztZQUVuQixJQUFJLElBQUksR0FBRyxDQUFDLENBQUMsSUFBSSxDQUFDLENBQUMsSUFBSSxDQUFDLE1BQU0sQ0FBQyxDQUFDO1lBQ2hDLENBQUMsQ0FBQyxXQUFXLENBQUMsQ0FBQyxPQUFPLENBQUMsRUFBRSxTQUFTLEVBQUUsQ0FBQyxDQUFDLElBQUksQ0FBQyxDQUFDLE1BQU0sRUFBRSxDQUFDLEdBQUcsRUFBRSxFQUFFLE1BQU0sQ0FBQyxDQUFDO1FBRXhFLENBQUMsQ0FBQyxDQUFDO0lBQ1AsQ0FBQztJQUNMLG1CQUFDO0FBQUQsQ0FkQSxBQWNDLElBQUE7QUNkRCx5Q0FBeUM7QUFVekMsSUFBSSxRQUFRLEdBQUcsSUFBSSxZQUFZLEVBQUUsQ0FBQztBQUNsQyxRQUFRLENBQUMsbUJBQW1CLEVBQUUsQ0FBQztBQUUvQixDQUFDLENBQUM7SUFFRSxDQUFDLENBQUMsVUFBVSxDQUFDLENBQUMsT0FBTyxFQUFFLENBQUM7SUFDeEIsQ0FBQyxDQUFDLFdBQVcsQ0FBQyxDQUFDLFFBQVEsRUFBRSxDQUFDO0lBRTFCLENBQUMsQ0FBQyxnQkFBZ0IsQ0FBQyxDQUFDLFdBQVcsRUFBRSxDQUFDO0FBRXRDLENBQUMsQ0FBQyxDQUFDIiwiZmlsZSI6Ii4uLy4uL3d3d3Jvb3QvanMvY29tbW9uLXNjcmlwdHMuanMiLCJzb3VyY2VzQ29udGVudCI6WyJjbGFzcyBTbW9vdGhTY3JvbGwge1xuXG4gICAgY29uc3RydWN0b3IoKSB7XHJcbiAgICB9ICAgXG4gICAgXG4gICAgYmluZEFsbExvY2FsQW5jaG9ycygpIHtcbiAgICAgICAgJChcImFbaHJlZl49XFxcXCNdXCIpLmNsaWNrKGZ1bmN0aW9uIChlKSB7XHJcbiAgICAgICAgICAgIGUucHJldmVudERlZmF1bHQoKTtcclxuXHJcbiAgICAgICAgICAgIHZhciBkZXN0ID0gJCh0aGlzKS5hdHRyKCdocmVmJyk7XHJcbiAgICAgICAgICAgICQoJ2h0bWwsYm9keScpLmFuaW1hdGUoeyBzY3JvbGxUb3A6ICQoZGVzdCkub2Zmc2V0KCkudG9wIH0sICdzbG93Jyk7XHJcblxyXG4gICAgICAgIH0pO1xyXG4gICAgfVxyXG59IiwiLy8vIDxyZWZlcmVuY2UgcGF0aD1cInNtb290aC1zY3JvbGwudHNcIiAvPlxyXG5cclxuaW50ZXJmYWNlIEpRdWVyeSB7XHJcblxyXG4gICAgc2lkZW5hdigpOiBhbnk7XHJcbiAgICBwYXJhbGxheCgpOiBhbnk7XHJcbiAgICBtYXRlcmlhbGJveCgpOiBhbnk7XHJcbn1cclxuXHJcblxyXG52YXIgc2Nyb2xsZXIgPSBuZXcgU21vb3RoU2Nyb2xsKCk7XHJcbnNjcm9sbGVyLmJpbmRBbGxMb2NhbEFuY2hvcnMoKTtcclxuXG4kKGZ1bmN0aW9uICgpIHtcbiAgICBcbiAgICAkKCcuc2lkZW5hdicpLnNpZGVuYXYoKTtcbiAgICAkKCcucGFyYWxsYXgnKS5wYXJhbGxheCgpO1xuXG4gICAgJCgnLm1hdGVyaWFsYm94ZWQnKS5tYXRlcmlhbGJveCgpO1xuXG59KTsiXX0=
