/// <reference path="smooth-scroll.ts" />
var scroller = new SmoothScroll();
scroller.bindAllLocalAnchors();
$(function () {
    $('.sidenav').sidenav();
    $('.parallax').parallax();
    $('.materialboxed').materialbox();
});
