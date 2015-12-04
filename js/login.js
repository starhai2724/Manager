
/**
Kiem tra username va passoword

**/

function chekLogin() {
    var username = $('#username').val();
    var pass = $('#password').val();

    if ("" != username && ("" != pass)) {
        $.ajax({
            url: 'login.aspx/checkUsernameAndPassword',
            type: 'POST',
            data: JSON.stringify({ username: username, password: pass }),
            contentType: "application/json; charset=utf-8",
            success: chek,
            error: function (result) {
                alert("Error");
            }
        });
    } else {

        document.getElementById("error").innerHTML = "Sai ten hoac mat khau!";

    }
}
// kiem tra user co ton tai hay khong
function chek(data) {
    var user = data.d;
    if (null != user) {
        localStorage.setItem('user', user);
        window.location.href = 'home.aspx';


    } else {

        document.getElementById("error").innerHTML = "Sai ten hoac mat khau!";

    }




}
