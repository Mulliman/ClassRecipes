/// <reference path="smooth-scroll.ts" />

interface JQuery {

    sidenav(): any;
    parallax(): any;
    materialbox(): any;
}

var scroller = new SmoothScroll();
scroller.bindAllLocalAnchors();

$(function () {
    
    $('.sidenav').sidenav();
    $('.parallax').parallax();

    $('.materialboxed').materialbox();

});