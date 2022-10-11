function validerFornavn(fornavn) {
    const regexp = /^[a-zA-ZæøåÆØÅ\.\ \-]{2,20}$/;
    const ok = regexp.test(fornavn);
    if (!ok) {
        $("#feilFornavn").html("Fornavnet må bestå av 2 til 20 bokstaver");
        return false;
    }
    else {
        $("#feilFornavn").html("");
        return true;
    }
}

function validerEtternavn(etternavn) {
    const regexp = /^[a-zA-ZæøåÆØÅ\.\ \-]{2,20}$/;
    const ok = regexp.test(etternavn);
    if (!ok) {
        $("#feilEtternavn").html("Etternavnet må bestå av 2 til 20 bokstaver");
        return false;
    }
    else {
        $("#feilEtternavn").html("");
        return true;
    }
}

function validerAdresse(adresse) {
    const regexp = /^[0-9a-zA-ZæøåÆØÅ\.\ \-]{2,50}$/;
    const ok = regexp.test(adresse);
    if (!ok) {
        $("#feilAdresse").html("Adressen må bestå av 2 til 50 bokstaver og tall");
        return false;
    }
    else {
        $("#feilAdresse").html("");
        return true;
    }
}

function validerPostnr(postnr) {
    const regexp = /^[0-9]{4}$/;
    const ok = regexp.test(postnr);
    if (!ok) {
        $("#feilPostnr").html("Postnummer må bestå av 4 tall");
        return false;
    }
    else {
        $("#feilPostnr").html("");
        return true;
    }
}

function validerPoststed(poststed) {
    const regexp = /^[a-zA-ZæøåÆØÅ\.\ \-]{2,50}$/;
    const ok = regexp.test(poststed);
    if (!ok) {
        $("#feilPoststed").html("Etternavnet må bestå av 2 til 20 bokstaver");
        return false;
    }
    else {
        $("#feilPoststed").html("");
        return true;
    }
}



