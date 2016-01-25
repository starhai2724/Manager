
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
            dataType: "json",
            success: chek,
            error: function (result) {
                alert("Không thành công");
            }
        });
    } else {

        document.getElementById("error").innerHTML = "Sai tên hoặc mật khẩu!";

    }
}
// kiem tra user co ton tai hay khong
function chek(data) {
    var user = data.d;
    // alert("user: "+user.username);
    if (null != user) {

        if (user.rule == "Quản lý") {
            window.location.href = "home.aspx";
        } else if (user.rule == "Xem thông tin căn hộ") {
            window.location.href = "infoApartment.aspx";
        } else if (user.rule == "Xem thông tin nhân viên") {
            window.location.href = "infoEmployee.aspx";
        }
    } else {
        
        document.getElementById("error").innerHTML = "Sai tên hoặc mật khẩu!";

    }




}
