$('#gridUsuarios.table tbody tr').dblclick(function () {
    console.log("aa");
    var formulario = $("#form-cadastro-usuario");
    var ide = $(this).attr('data-id');
    var login = $(this).attr('data-login');
    var senha = $(this).attr('data-senha');
    var status = $(this).attr('data-status');
   

    formulario.find(".id-secreto").val(ide);
    formulario.find(".login-alterar").val(login);
    formulario.find(".senha-alterar").val(senha);
    formulario.find(".status-alterar").val(status);
   


});


$("#botao-add-usuarios").click(function () {
    console.log("a")

    var formulario = $("#form-cadastro-usuario");

    formulario.find(".id-secreto").val(0);
    formulario.find(".login-alterar").val(null);
    formulario.find(".senha-alterar").val(null);
    formulario.find(".status-alterar").val(0);


});//ok