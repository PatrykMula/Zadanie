$("#lnkCreate").click(function (e) {

    e.preventDefault();

    url = $(this).attr('href');

    $("#dialog-edit").dialog('open');

});



$(document).ready(function () {
    $("#delete-links button [href]").click(function (a) {
        a.preventDefault();

        if (confirm("Na pewno chcesz usun¹æ element?")) {
            url = $(this).attr('href');

            window.location.href = url;

        } else {
            txt = "You pressed Cancel!";
        }


    });
});



$("#lnkEdit").click(function (e) {
    e.preventDefault();
    var input = $("div input:checked").length;
    if (input == 0) {
        alert('zaznacz checboxa, ktorego chcesz edytowac');
    }
    else if (input > 1) {
        alert("maksymalnie mozesz edytowac jedno pole");
    }
    else {
         
        url = $(this).attr('href');
        url += "/" + $("input:checked").val();
        $("#dialog-edit").dialog('open');
    }

});

$(document).ready(function () {
    $("#details-links button [href], #details-links [href]").click(function (a) {
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




