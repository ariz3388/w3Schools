// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#homeLink').removeClass('active');
    $('#techLink').removeClass('active');
    $('#expLink').removeClass('active');

    if ($('#pageName').val() === "Companies" || $('#pageName').val() === "Projects") $('#expLink').addClass('active');
    if ($('#pageName').val() === "Technology"
        || $('#pageName').val() == "cSide"
        || $('#pageName').val() == "sSide"
        || $('#pageName').val() == "dBase"
        || $('#pageName').val() == "sControl") $('#techLink').addClass('active');
    if ($('#pageName').val() === "Home") $('#homeLink').addClass('active');
});