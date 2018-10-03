$("#bot-crm").click(function (event) {
    console.log("a");
    event.preventDefault();
    var divCategoria = $("#div-categoria");
    divCategoria.attr("style", "display: none;");
    var divValor = $("#div-valor");
    divValor.attr("style", "display: none;");
    var divDetalhe = $("#div-detalhes");
    divDetalhe.attr("style", "display: none;");
    var divCrm = $("#div-crm");
    divCrm.attr("style", "display: block;");
});