$("#MudaPendet").click(function () {

    var resultado = $(".resultado");
    resultado.val("@ViewBag.pendente");
});

$("#MudaFinalz").click(function () {

    var resultado = $(".resultado");
    resultado.val("@ViewBag.naoConvertido");
});