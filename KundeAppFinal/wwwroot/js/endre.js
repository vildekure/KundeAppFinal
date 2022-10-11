$(function () {
    // hent kunden med id og vis på siden
    const id = window.location.search.substring(1);
    const url = "Kunde/HentEn?" + id;
    $.get(url, function (kunde) {
        $("#id").val(kunde.id); // må ha med id inn i skjemaet, hidden i html
        $("#fornavn").val(kunde.fornavn);
        $("#etternavn").val(kunde.etternavn);
        $("#adresse").val(kunde.adresse);
        $("#postnr").val(kunde.postnr);
        $("#poststed").val(kunde.poststed);
    });
});

function validerOgEndreKunde() {
    const fornavnOK = validerFornavn($("#fornavn").val());
    const etternavnOK = validerEtternavn($("#etternavn").val());
    const adresseOK = validerAdresse($("#adresse").val());
    const postnrOK = validerPostnr($("#postnr").val());
    const poststedOK = validerPoststed($("#poststed").val());
    if (fornavnOK && etternavnOK && adresseOK && postnrOK && poststedOK) {
        endreKunde();
    }
}


function endreKunde() {
    const kunde = {
        id: $("#id").val(), // må ha med denne som ikke er endret for å vite kunde id. 
        fornavn: $("#fornavn").val(),
        etternavn: $("#etternavn").val(),
        adresse: $("#adresse").val(),
        postnr: $("#postnr").val(),
        poststed: $("#poststed").val()
    };
    $.post("Kunde/Endre", kunde, function () {
        window.location.href = 'index.html';
    })
    .fail(function () {
        $("#feil").html("Feil på server - prøv igjen senere");
    });
};