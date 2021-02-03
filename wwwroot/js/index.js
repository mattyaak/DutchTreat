jQuery(document).ready(function () {

    console.log("Hello World!");


    var theForm = jQuery("#theForm");
    theForm.hide();
    var button = jQuery("buyButton")
    button.on("click", function () {
        console.log("Buying Item");
    });

    var productInfo = jQuery(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + jQuery(this).text());
    });


var $loginToggle = jQuery("#loginToggle");
var $popupForm = jQuery(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.slideToggle(1000);
    });
});