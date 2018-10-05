

$("#bot-categoria").click(function (event) {
    console.log("a");
    event.preventDefault();
    var divCategoria = $("#div-categoria");
    divCategoria.attr("style", "display: block;");
    var divValor = $("#div-valor");
    divValor.attr("style", "display: none;");
    var divDetalhe = $("#div-detalhes");
    divDetalhe.attr("style", "display: none;");
    
 });

