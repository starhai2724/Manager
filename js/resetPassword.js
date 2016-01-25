function validation() {
    var passwordOld = $('#passwordold').val();
    var password = $('#password').val();
    var repassword = $('#repassword').val();
    if ("" == passwordOld || "" == password || "" == repassword || password != repassword) {
        document.getElementById("error").innerHTML='Kiểm tra lại thông tin nhập'
    } else {
        $.ajax({
            url: 'ResetPassword.aspx/checkPassword',
            type: 'POST',
            data: JSON.stringify({ passwordOld: passwordOld, password: password }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: chek,
            error: function (result) {
                alert("Không thành công");
            }
        });
    }
    }
    function chek(data) {
        var check = data.d;
        if (check == 'false') {
            document.getElementById("error").innerHTML = 'Kiểm tra lại thông tin nhập'
        } else {
         
            window.location.href =check;
            alert("Đổi mật khẩu thành công")
        }




    }