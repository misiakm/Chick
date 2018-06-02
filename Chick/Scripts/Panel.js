
$("#szukaniePacjenta").autocomplete({
    source: function (request, response) {
    $.ajax({
        url: "/Panel/Klienci",
        dataType: "jsonp",
        data: {
            term: request.term
        },
        success: function (data) {
            response(data);
        }
    });
}
})