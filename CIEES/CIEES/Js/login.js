$(function () {
    $('#btn').click(function (e) {
        e.preventDefault();
        var url = "Autoevaluacion.cshtml";
        window.open(url, "_blank", 'width=500,height=400');
        return false;
    });
});