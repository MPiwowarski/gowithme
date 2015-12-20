$(document).ready(function() {
    $("#rideDate").datepicker({
        dateFormat: "dd/mm/yy", dayNamesMin: ["Nd", "Pn", "Wt", "Sr", "Cz", "Pt", "So"],
        monthNames: ["Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"]
    });
});


$(document).ready(function () {
    $("#dateRideControl").datepicker({
        dateFormat: "dd/mm/yy", dayNamesMin: ["Nd", "Pn", "Wt", "Sr", "Cz", "Pt", "So"],
        monthNames: ["Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"]
    });
});