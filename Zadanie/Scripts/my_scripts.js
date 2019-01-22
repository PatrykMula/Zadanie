$("#lnkCreate").click(function (e) {

    e.preventDefault();

    url = $(this).attr('href');

    $("#dialog-edit").dialog('open');

});

$(document).ready(function () {
    $("#details-links button [href]").click(function (a) {
        a.preventDefault();

        url = $(this).attr('href');

        $("#dialog-edit").dialog('open');
    });
});


$("#dialog-edit").dialog({

    title: 'Dodaj zadanie',

    autoOpen: false,

    resizable: false,

    width: 600,

    show: { effect: 'drop', direction: "top" },

    modal: true,

    draggable: true,

    dialogClass: "myDialog",

    open: function (event, ui) {

        $(".ui-dialog-titlebar-close").hide();

        $(this).load(url);

    }

});
