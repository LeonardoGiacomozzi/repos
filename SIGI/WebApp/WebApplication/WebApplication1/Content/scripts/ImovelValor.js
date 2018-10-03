$("#bot-valores").click(function (event) {
    console.log("a");
    event.preventDefault();
    var divCategoria = $("#div-categoria");
    divCategoria.attr("style", "display: none;");
    var divValor = $("#div-valor");
    divValor.attr("style", "display: block;");
    var divDetalhe = $("#div-detalhes");
    divDetalhe.attr("style", "display: none;");
    var divCrm = $("#div-crm");
    divCrm.attr("style", "display: none;");
    
});

$(".negocio-alterar").change(mudaValor());

function mudaValor() {

  
        var locacao = $("#locacao");
        var venda = $("#venda");


        if ($(".negocio-alterar").val() == "Venda") {

            locacao.attr("style", "display: none");
            venda.attr("style", "display: block");
        } else {
            locacao.attr("style", "display: block");
            venda.attr("style", "display: none");

        }
    

}