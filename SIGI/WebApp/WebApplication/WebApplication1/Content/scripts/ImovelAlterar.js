var negocio = $("#form-cadastro-PJ").attr("data-tipoNegocio");
$(".negocio-alterar").val(negocio);

var imovel = $("#form-cadastro-PJ").attr("data-tipoImovel");
$(".tipoImvl-alterar").val(imovel);

var finalidade = $("#form-cadastro-PJ").attr("data-finalidade");
$(".finalidade-alterar").val(finalidade);

var endereco = $("#form-cadastro-PJ").attr("data-endereco");
$(".endereco-alterar").val(endereco);

var pessoa = $("#form-cadastro-PJ").attr("data-responsavel");
$(".responsavel-alterar").val(pessoa);

if (negocio == "Venda") {

    var financia = $("#form-cadastro-PJ").attr("data-financia");
    if (financia == "True") {

    $(".podeFinanc-alterar").attr("checked","checked");    
    }

    var escriturado = $("#form-cadastro-PJ").attr("data-escritura");
    if (escriturado=="True") {

        $(".escritura-alterar").attr("checked", "checked");
    }

    var averbado = $("#form-cadastro-PJ").attr("data-averbado");
    if (averbado == "True") {

        $(".averbado-alterar").attr("checked", "checked");
    }

}