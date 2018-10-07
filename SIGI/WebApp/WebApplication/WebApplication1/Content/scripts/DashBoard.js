$(function () {

    $.ajax({
        url: '/DashBoard/Refresh',
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        //data: JSON.stringify({ idEstado: idLinha }),
        success: function (resultado) {

            var PORCENTAGEM_BOA = 75;
            var PORCENTAGEM_MEDIA = 50;
            var PORCENTAGEM_RUIM = 25;
            //Semana
            var valorPrincipal = $("#semana-valorprincipal");
            if (resultado.EstaSemana.Percentual < PORCENTAGEM_RUIM) {
                $("#semana-valorprincipal-cor").attr('class', 'font-red');
                $("#semana-valorprincipal-cor-icon").attr('class', 'font-red');
                $("#barra-progresso-semana").attr('class', 'progress-bar progress-bar-success red');
            } else if (resultado.EstaSemana.Percentual < PORCENTAGEM_MEDIA) {
                $("#semana-valorprincipal-cor").attr('class', 'font-yellow-gold');
                $("#semana-valorprincipal-cor-icon").attr('class', 'font-yellow-gold');
                $("#barra-progresso-semana").attr('class', 'progress-bar progress-bar-success yellow-gold');
            } else if (resultado.EstaSemana.Percentual < PORCENTAGEM_BOA) {
                $("#semana-valorprincipal-cor").attr('class', 'font-yellow-lemon');
                $("#semana-valorprincipal-cor-icon").attr('class', 'font-yellow-lemon');
                $("#barra-progresso-semana").attr('class', 'progress-bar progress-bar-success yellow-lemon');
            }
            //Numero Grande
            valorPrincipal.attr('data-value', resultado.EstaSemana.Percentual);
            valorPrincipal.text(resultado.EstaSemana.Percentual);
            //Barra de progresso
            var barra = $("#barra-progresso-semana")
            barra.attr("style", "width:" + resultado.EstaSemana.Percentual + "%;");
            var barralegenda = $("#barra-progresso-legenda-semana")
            barralegenda.text(resultado.EstaSemana.Percentual + "% progress");
            //Legenda
            var legenda = $("#legenda-semana")
            legenda.text(resultado.EstaSemana.Descricao);
            var legendanum = $("#legenda-num-semana")
            legendanum.text(resultado.EstaSemana.Percentual + "%");
            //Fim
            //Mês
            if (resultado.MesPassado.Percentual < PORCENTAGEM_RUIM) {
                $("#mes-valorprincipal-cor").attr('class', 'font-red');
                $("#mes-valorprincipal-cor-icon").attr('class', 'font-red');
                $("#barra-progresso-mes").attr('class', 'progress-bar progress-bar-success red');
            } else if (resultado.MesPassado.Percentual < PORCENTAGEM_MEDIA) {
                $("#mes-valorprincipal-cor").attr('class', 'font-yellow-gold');
                $("#mes-valorprincipal-cor-icon").attr('class', 'font-yellow-gold');
                $("#barra-progresso-mes").attr('class', 'progress-bar progress-bar-success yellow-gold');
            } else if (resultado.MesPassado.Percentual < PORCENTAGEM_BOA) {
                $("#mes-valorprincipal-cor").attr('class', 'font-yellow-lemon');
                $("#mes-valorprincipal-cor-icon").attr('class', 'font-yellow-lemon');
                $("#barra-progresso-mes").attr('class', 'progress-bar progress-bar-success yellow-lemon');
            }
            //Numero Grande
            var valorPrincipal = $("#mes-valorprincipal");
            valorPrincipal.attr('data-value', resultado.MesPassado.Percentual);
            valorPrincipal.text(resultado.MesPassado.Percentual);
            //Barra de progresso
            var barra = $("#barra-progresso-mes")
            barra.attr("style", "width:" + resultado.MesPassado.Percentual + "%;");
            var barralegenda = $("#barra-progresso-legenda-mes")
            barralegenda.text(resultado.MesPassado.Percentual + "% progress");
            //Legenda
            var legenda = $("#legenda-mes")
            legenda.text(resultado.MesPassado.Descricao);
            var legendanum = $("#legenda-num-mes")
            legendanum.text(resultado.MesPassado.Percentual + "%");
            //Fim
            //Ano
            if (resultado.Ultimos12Meses.Percentual < PORCENTAGEM_RUIM) {
                $("#ano-valorprincipal-cor").attr('class', 'font-red');
                $("#ano-valorprincipal-cor-icon").attr('class', 'font-red');
                $("#barra-progresso-ano").attr('class', 'progress-bar progress-bar-success red');
            } else if (resultado.Ultimos12Meses.Percentual < PORCENTAGEM_MEDIA) {
                $("#ano-valorprincipal-cor").attr('class', 'font-yellow-gold');
                $("#ano-valorprincipal-cor-icon").attr('class', 'font-yellow-gold');
                $("#barra-progresso-ano").attr('class', 'progress-bar progress-bar-success yellow-gold');
            } else if (resultado.Ultimos12Meses.Percentual < PORCENTAGEM_BOA) {
                $("#ano-valorprincipal-cor").attr('class', 'font-yellow-lemon');
                $("#ano-valorprincipal-cor-icon").attr('class', 'font-yellow-lemon');
                $("#barra-progresso-ano").attr('class', 'progress-bar progress-bar-success yellow-lemon');
            }
            //Numero Grande
            var valorPrincipal = $("#ano-valorprincipal");
            valorPrincipal.attr('data-value', resultado.Ultimos12Meses.Percentual);
            valorPrincipal.text(resultado.Ultimos12Meses.Percentual);
            //Barra de progresso
            var barra = $("#barra-progresso-ano")
            barra.attr("style", "width:" + resultado.Ultimos12Meses.Percentual + "%;");
            var barralegenda = $("#barra-progresso-legenda-ano")
            barralegenda.text(resultado.Ultimos12Meses.Percentual + "% progress");
            //Legenda
            var legenda = $("#legenda-ano")
            legenda.text(resultado.Ultimos12Meses.Descricao);
            var legendanum = $("#legenda-num-ano")
            legendanum.text(resultado.Ultimos12Meses.Percentual + "%");
            //Fim


        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });

    //--------------------- PIZZA ------------------------

    //var chart = AmCharts.makeChart("chartdiv", {
    //    "type": "pie",
    //    "theme": "light",
    //    "dataProvider": e.ListaPercentualFuncionarios,
    //    "valueField": "Percentual",
    //    "titleField": "NomeFuncionario",
    //    "balloon": {
    //        "fixedPosition": true
    //    },
    //    "export": {
    //        "enabled": true
    //    }
    //});

    $.ajax({
        url: '/DashBoard/Refresh',
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
    }).success(function (e) {
        var chart = AmCharts.makeChart("chartdiv", {

            "type": "pie",
            "theme": "light",
            "dataProvider": e.ListaPizzaFuncionario,
            "valueField": "Percentual",
            "titleField": "NomeFuncionario",
            "balloon": {
                "fixedPosition": true
            },
            "export": {
                "enabled": true
            }
        });
        var chart = AmCharts.makeChart("chartdiv2", {

            "type": "pie",
            "theme": "light",
            "dataProvider": e.ListaPizzaValor,
            "valueField": "Percentual",
            "titleField": "NomeFuncionario",
            "balloon": {
                "fixedPosition": true
            },
            "export": {
                "enabled": true
            }
        });


    });

});