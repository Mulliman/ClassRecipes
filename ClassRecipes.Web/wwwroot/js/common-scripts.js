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

//# sourceMappingURL=data:application/json;charset=utf8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNtb290aC1zY3JvbGwudHMiLCJjb21tb24udHMiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7SUFFSTtJQUNBLENBQUM7SUFFRCwwQ0FBbUIsR0FBbkI7UUFDSSxDQUFDLENBQUMsY0FBYyxDQUFDLENBQUMsS0FBSyxDQUFDLFVBQVUsQ0FBQztZQUMvQixDQUFDLENBQUMsY0FBYyxFQUFFLENBQUM7WUFFbkIsSUFBSSxJQUFJLEdBQUcsQ0FBQyxDQUFDLElBQUksQ0FBQyxDQUFDLElBQUksQ0FBQyxNQUFNLENBQUMsQ0FBQztZQUNoQyxDQUFDLENBQUMsV0FBVyxDQUFDLENBQUMsT0FBTyxDQUFDLEVBQUUsU0FBUyxFQUFFLENBQUMsQ0FBQyxJQUFJLENBQUMsQ0FBQyxNQUFNLEVBQUUsQ0FBQyxHQUFHLEVBQUUsRUFBRSxNQUFNLENBQUMsQ0FBQztRQUV4RSxDQUFDLENBQUMsQ0FBQztJQUNQLENBQUM7SUFDTCxtQkFBQztBQUFELENBZEEsQUFjQyxJQUFBO0FDZEQseUNBQXlDO0FBRXpDLElBQUksUUFBUSxHQUFHLElBQUksWUFBWSxFQUFFLENBQUM7QUFDbEMsUUFBUSxDQUFDLG1CQUFtQixFQUFFLENBQUMiLCJmaWxlIjoiLi4vLi4vd3d3cm9vdC9qcy9jb21tb24tc2NyaXB0cy5qcyIsInNvdXJjZXNDb250ZW50IjpbImNsYXNzIFNtb290aFNjcm9sbCB7XG5cbiAgICBjb25zdHJ1Y3RvcigpIHtcclxuICAgIH0gICBcbiAgICBcbiAgICBiaW5kQWxsTG9jYWxBbmNob3JzKCkge1xuICAgICAgICAkKFwiYVtocmVmXj1cXFxcI11cIikuY2xpY2soZnVuY3Rpb24gKGUpIHtcclxuICAgICAgICAgICAgZS5wcmV2ZW50RGVmYXVsdCgpO1xyXG5cclxuICAgICAgICAgICAgdmFyIGRlc3QgPSAkKHRoaXMpLmF0dHIoJ2hyZWYnKTtcclxuICAgICAgICAgICAgJCgnaHRtbCxib2R5JykuYW5pbWF0ZSh7IHNjcm9sbFRvcDogJChkZXN0KS5vZmZzZXQoKS50b3AgfSwgJ3Nsb3cnKTtcclxuXHJcbiAgICAgICAgfSk7XHJcbiAgICB9XHJcbn0iLCIvLy8gPHJlZmVyZW5jZSBwYXRoPVwic21vb3RoLXNjcm9sbC50c1wiIC8+XHJcblxyXG52YXIgc2Nyb2xsZXIgPSBuZXcgU21vb3RoU2Nyb2xsKCk7XHJcbnNjcm9sbGVyLmJpbmRBbGxMb2NhbEFuY2hvcnMoKTsiXX0=
