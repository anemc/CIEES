$(function () {
    $('#btnlogin').click(function (e) {
        e.preventDefault();
        var user = $('#user').val();
        var password = $('#password').val();
        var data = { user: user, password: password };
        $.post("validation", data, function (res) {
            var a = res;
            if (a == 1)
                location.href = "menuadmin.jsp";
            else if (a == 0)
                location.href = "menu_usuario.jsp";
            else
                alert(res);
        });
    });

});