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
            "<td> <a class='btn btn-primary' href='endre.html?id=" + kunde.Id + "'>Endre</td>" +
            "<td> <button class='btn btn-danger' onclick='slettKunde(" + kunde.Id + ")'>Slett</td>" +
            "</tr>";
    }
    ut += "</table>"
    $("#kundene").html(ut);
}