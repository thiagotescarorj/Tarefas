$(document).ready(function () {

    $('.AtivarCheck').change(function () {

        var self = $(this);
        var id = self.attr('id');
        var value = self.prop('checked');

        $.ajax({
            url: '/Tarefas/AJAXEdit',
            data: {
                id: id,
                value: value
            },
            type: 'POST',
            success: function (result) {
                $('#tabelaDiv').html(result);
            }
        });

    });

});