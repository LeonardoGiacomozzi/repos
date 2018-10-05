$("#bot-valores").click(function (event) {
    event.preventDefault();
    var divCategoria = $("#div-categoria");
    divCategoria.attr("style", "display: none;");
    var divValor = $("#div-valor");
    divValor.attr("style", "display: block;");
    var divDetalhe = $("#div-detalhes");
    divDetalhe.attr("style", "display: none;");
    var divCrm = $("#div-crm");
    divCrm.attr("style", "display: none;");
    mudaValor()
    $("#FinalidadeDeNegocio").change(mudaValor());
});

$(document).ready(function () {
    
    $("#FinalidadeDeNegocio").change(function () {
        mudaValor();
    });
}
);

function mudaValor() {

    console.log("bbb");

    var locacao = $(".locacao");
    var venda = $(".venda");


    if ($(".negocio-alterar").val() == "Venda") {

        locacao.attr("style", "display: none");
        venda.attr("style", "display: block");

    } else {
        locacao.attr("style", "display: block");
        venda.attr("style", "display: none");

    }


}