/*2.Changing color in hover jQueryUI*/
$(document).ready(function () {
    $("#offerRide").hover(function () {
        $(this).animate({ "backgroundColor": "yellow", "color": "black" }, 200);
    },
    //back to custom colors
function () {
    $(this).animate({ "backgroundColor": "darkorange", "color": "black" }, 200);
}
);
});