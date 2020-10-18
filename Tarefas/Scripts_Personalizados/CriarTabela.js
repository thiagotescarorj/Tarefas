$(document).ready(function () {

    $.ajax({
        url: '/Tarefas/CriarTabelaTarefa',
        success: function (result) {
            $('#tabelaDiv').html(result);
        }
    });
});