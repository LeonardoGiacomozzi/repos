$('#gridPrincipal.table tbody tr').dblclick(function () {
    console.log("aa");
    var formulario = $("#form-cadastro-caracteristicaP");
    var ide = $(this).attr('data-id');
    var nome = $(this).attr('data-nome');
    var valor = $(this).attr('data-valor');
    var tipoDado = $(this).attr('data-tipo');
    var ativo = $(this).attr('data-ativo');


    formulario.find(".id-secreto-p").val(ide);
    formulario.find(".nome-alterar-p").val(nome);
    formulario.find(".valor-alterar-p").val(valor);
    formulario.find(".tipo-alterar-p").val(tipoDado);
    formulario.find(".ativo-alterar-p").val(ativo);



});


$("#botao-add-caracP").click(function () {
    console.log("a")

    var formulario = $("#form-cadastro-caracteristicaP");

    formulario.find(".id-secreto-p").val(0);
    formulario.find(".nome-alterar-p").val(null);
    formulario.find(".valor-alterar-p").val(0);
    formulario.find(".tipo-alterar-p").val(0);
    formulario.find(".ativo-alterar-p").val(false);


});//ok

$('#gridGeral.table tbody tr').dblclick(function () {
    console.log("bb");
    var formulario = $("#form-cadastro-caracteristicaG");
    var ide = $(this).attr('data-id');
    var nome = $(this).attr('data-nome');
    var valor = $(this).attr('data-valor');
    var tipoDado = $(this).attr('data-tipo');
    var ativo = $(this).attr('data-ativo');


    formulario.find("#id-secreto-g").val(ide);
    console.log(formulario.find("#id-secreto-g").val());
    formulario.find(".nome-alterar-g").val(nome);
    formulario.find(".valor-alterar-g").val(valor);
    formulario.find(".tipo-alterar-g").val(tipoDado);
    formulario.find(".ativo-alterar-g").val(ativo);



});


$("#botao-add-caracG").click(function () {
    console.log("a")

    var formulario = $("#form-cadastro-caracteristicaG");

    formulario.find(".id-secreto-g").val(0);
    formulario.find(".nome-alterar-g").val(null);
    formulario.find(".valor-alterar-g").val(0);
    formulario.find(".tipo-alterar-g").val(0);
    formulario.find(".ativo-alterar-g").val(false);


});//ok