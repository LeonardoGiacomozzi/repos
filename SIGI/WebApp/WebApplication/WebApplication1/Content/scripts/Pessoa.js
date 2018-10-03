$('#gridPessoa.table tbody tr').dblclick(function () {
    var formulario = $("#form-cadastro-Pessoa");
    var ide = $(this).attr('data-id');
    var nome = $(this).attr('data-nome');
    var cpf = $(this).attr('data-cpf');
    var cnpj = $(this).attr('data-cnpj');
    var tipo = $(this).attr('data-tipo');
    var proficao = $(this).attr('data-prof');
    var nacionalidade = $(this).attr('data-nacionalidade');
    var nacimeto = $(this).attr('data-nacimento');
    var tel = $(this).attr('data-tel');
    var cel = $(this).attr('data-cell');
    var email = $(this).attr('data-email');
    var web= $(this).attr('data-web');
    var ie = $(this).attr('data-ie');
    var obs = $(this).attr('data-obs');
    var im = $(this).attr('data-im');
    var rg = $(this).attr('data-rg');
    var endereco = $(this).attr('data-endereco');
    var ec = $(this).attr('data-ec');
    var pessoaTipo = $(this).attr('data-pessoaTipo');
    


    formulario.find(".id-secreto").val(ide);
    formulario.find(".nome-alterar").val(nome);
    formulario.find(".cpf-alterar").val(cpf);
    formulario.find(".cnpj-alterar").val(cnpj);
    formulario.find(".rg-alterar").val(rg);
    formulario.find(".etipo-alterar").val(tipo);
    formulario.find(".im-alterar").val(im);
    formulario.find(".ie-alterar").val(ie);
    formulario.find(".prof-alterar").val(proficao);
    formulario.find(".nascio-alterar").val(nacionalidade);
    formulario.find(".ec-alterar").val(ec);
    formulario.find(".nac-alterar").val(nacimeto);
    formulario.find(".email-alterar").val(email);
    formulario.find(".web-alterar").val(web);
    formulario.find(".obs-alterar").val(obs);
    formulario.find(".endereco-alterar").val(endereco);
    formulario.find(".tel-alterar").val(tel);
    formulario.find(".cell-alterar").val(cel);
    formulario.find(".pessoa-alterar").val(pessoaTipo);
    mudaPessoa();
    console.log("aa");
 
    



});

$(".pessoa-alterar").change(mudaPessoa);

function mudaPessoa () {
    var selcecionado = $(".pessoa-alterar").val();

    if (selcecionado == "Pessoa_Juridica") {
        $(".pessoaJuridica").attr("style", "display: block;")
        $(".pessoaFisica").attr("style", "display: none;")
    } else {
        $(".pessoaJuridica").attr("style", "display: none;")
        $(".pessoaFisica").attr("style", "display: block;")
    }
}
$("#botao-add-pessoa").click(function () {
    console.log("a")

    var formulario = $("#form-cadastro-Pessoa");


    formulario.find(".id-secreto").val(0);
    formulario.find(".nome-alterar").val(null);
    formulario.find(".cpf-alterar").val(null);
    formulario.find(".rg-alterar").val(null);
    formulario.find(".etipo-alterar").val(0);
    formulario.find(".im-alterar").val(null);
    formulario.find(".ie-alterar").val(null);
    formulario.find(".prof-alterar").val(null);
    formulario.find(".nascio-alterar").val(null);
    formulario.find(".ec-alterar").val(0);
    formulario.find(".nac-alterar").val(null);
    formulario.find(".email-alterar").val(null);
    formulario.find(".obs-alterar").val(null);
    formulario.find(".endereco-alterar").val(0);
    formulario.find(".tel-alterar").val(null);
    formulario.find(".cell-alterar").val(null);
    formulario.find(".pessoa-alterar").val("Pessoa_Fisica");
    mudaPessoa();


});//ok
