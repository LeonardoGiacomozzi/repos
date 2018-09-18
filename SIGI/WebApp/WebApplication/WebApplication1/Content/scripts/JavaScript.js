$('#gridPaises.table tbody tr').dblclick(function () {

    var formulario = $("#form-cadastro-pais");
    var ide = $(this).attr('data-id');
    var nome = $(this).attr('data-nome');

    formulario.find(".id-secreto").val(ide);
    formulario.find(".nome-alterar").val(nome);

    
});//ok

$("#botao-add-cidade").click(function () {
    console.log("a")

    var formulario = $("#form-cadastro-cidades");

    formulario.find("#id-secreto3").val(0);
    formulario.find("#nomec-alterar").val(null);
    formulario.find("#estado-select").val(0);

});//ok

$("#botao-add-estado").click(function () {
    var formulario = $("#form-cadastro-estados");
    console.log('a');
    formulario.find("#id-secreto2").val(0);
    formulario.find("#nomeE-alterar").val(null);
    formulario.find("#pais-select").val(0);

});//ok

$("#botao-add-pais").click(function () {
    var formulario = $("#form-cadastro-pais");

    formulario.find(".id-secreto").val(0);
    formulario.find(".nome-alterar").val(null);

});//ok

$("#gridEstados.table tbody tr").dblclick(function () {
   

    var formulario = $("#form-cadastro-estados");
    var ide = $(this).attr("data-id");
    var nome = $(this).attr('data-nome');
    var pais = $(this).attr('data-pais');

    formulario.find("#id-secreto2").val(ide);
    formulario.find("#nomeE-alterar").val(nome);
    formulario.find("#pais-select").val(pais);
    
});//ok


$("#gridCidade.table tbody tr").dblclick(function () {

    var formulario = $("#form-cadastro-cidades");
    var ide = $(this).attr("data-id");
    var nome = $(this).attr('data-nome');
    var estado = $(this).attr('data-estado');

    console.log("1 " + ide);
    console.log("2 " + nome);
    console.log("3 " + estado);

    formulario.find("#id-secreto3").val(ide);
    formulario.find("#nomec-alterar").val(nome);
    formulario.find("#estado-select").val(estado);
});//ok