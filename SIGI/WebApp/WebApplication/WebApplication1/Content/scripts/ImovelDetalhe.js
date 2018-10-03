$("#bot-detalhe").click(function (event) {
    console.log("a");
    event.preventDefault();
    var divCategoria = $("#div-categoria");
    divCategoria.attr("style", "display: none;");
    var divValor = $("#div-valor");
    divValor.attr("style", "display: none;");
    var divDetalhe = $("#div-detalhes");
    divDetalhe.attr("style", "display: block;");
    var divCrm = $("#div-crm");
    divCrm.attr("style", "display: none;");
});