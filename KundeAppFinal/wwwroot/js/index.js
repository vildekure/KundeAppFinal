$(function () {
    hentAlleKunder();
});

function hentAlleKunder() {
    $.get("kunde/hentAlle", function (kunder) {
        formaterKunder(kunder);
    });
}

function formaterKunder(kunder) {
    let ut = "<table class='table table-striped'" +
        "<tr>" +
        "<th>Navn</th><th>Adresse</th><th>Test</th><th>Test</th>" +
        "</tr>";
    for (let kunde of kunder) {
        ut += "<tr>" +
            "<td>" + kunde.navn + "</td>" +
            "<td>" + kunde.adresse + "</td>" +
            "<td> hei </td>" +
            "<td> hei </td>" +
            "</tr>";
    }
    ut += "</table>"
    $("#kundene").html(ut);
}