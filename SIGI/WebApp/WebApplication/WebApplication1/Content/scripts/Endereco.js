$('#gridEndereco.table tbody tr').dblclick(function () {
    console.log("aa");
    var formulario = $("#form-cadastro-endereco");
    var ide = $(this).attr('data-id');
    var rua = $(this).attr('data-rua');
    var bairro = $(this).attr('data-bairro');
    var cidade = $(this).attr('data-cidade');
    var estado = $(this).attr('data-estado');
    var pais = $(this).attr('data-pais');
    var cep = $(this).attr('data-cep');
    var numero = $(this).attr('data-num');
    var complemento = $(this).attr('data-complemento');

    formulario.find(".id-secreto").val(ide);
    formulario.find(".rua-alterar").val(rua);
    formulario.find(".bairro-alterar").val(bairro);
    formulario.find("#endereco-pais-select").val(pais);
    formulario.find("#endereco-estado-select").val(estado);
    formulario.find("#endereco-cidade-select").val(cidade);
    formulario.find(".cep-alterar").val(cep);
    formulario.find(".numero-alterar").val(numero);
    formulario.find(".complemento-alterar").val(complemento);


});


$("#botao-add-endereco").click(function () {
    console.log("a")

    var formulario = $("#form-cadastro-endereco");

    formulario.find(".id-secreto").val(0);
    formulario.find(".rua-alterar").val(null);
    formulario.find(".bairro-alterar").val(null);
    formulario.find("#endereco-pais-select").val(0);
    formulario.find("#endereco-estado-select").val(0);
    formulario.find("#endereco-cidade-select").val(0);
    formulario.find(".cep-alterar").val(null);
    formulario.find(".numero-alterar").val(0);
    formulario.find(".complemento-alterar").val(null);

});//ok