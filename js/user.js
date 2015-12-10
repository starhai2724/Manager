/**
load table users
**/
$(document).ready(function () {


    bindData();

});

// load table 
function bindData() {

    $.ajax({
        url: 'user.aspx/getUsers',
        type: 'POST',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: {},
        success: loadTable,
        error: function (data) {
            alert("error  sfsdf")
        }
    });
}

function loadTable(data) {
    if ($('#dataTables-example').length != 0) {
        $('#dataTables-example').remove();
    }
    var items = data.d;
    if (items != null) {
        alert(items.length + "  size")
        var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>"
                    + "<thead>"
                        + "<tr class='info'>"
                            + "<th>Tên tài khoản</th>"
                            + "<th>Tên khách hàng</th>"
                            + "<th>Tên nhân viên</th>"
                            + "<th>Ngày tạo</th>"
                            + "<th>Người tạo</th>"
                            + "<th>Ngày sửa</th>"
                            + "<th>Người sửa</th>"
                            + "<th>Quyền</th>"
                            + "<th class=' no-link last'><span class='nobr'>Thao tác</span>"
                            + "</th></tr></thead><tbody>";

        for (var i = 0; i < items.length; i++) {
            alert("  size")
            var row = " <tr class='even pointer'>";
            row += " <td class=''>" + items[i].username + "</td>";
            row += "<td class=''>" + items[i].id_cus + "</td>";
            row += "<td class=''>" + items[i].idEmp + "</td>";
            row += "<td class=''>" + items[i].dateCreate + "</td>";
            row += "<td class=''>" + items[i].userCreate + "</td>";
            row += "<td class=''>" + items[i].dateUpdate + "</td>";
            row += "<td class=''>" + items[i].userUpdate + "</td>";
            row += "<td class=''>" + items[i].rule + "</td>";
            row += " <td class=' last'><a ><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a>|"
            + "<a ><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>";
            row += "</tr>";
        }
        table += row;
        table += "</tbody></table>";
        $('#divtable').html(table);
    }
}


// add 
function add() {
    var username = $('#txt_username').val();
    var password = $('#txt_password').val();
    var customer = $('#customer').val();
    var rePassword = $('#txt_rePassword').val();
    var employee = $('#employee').val();
    var rule = $('#rule').val();
    alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation(username, password, customer, rePassword, employee, rule);
    alert("check:  " + chek);
    if (chek == true) {
        alert("abc")
        $.ajax({
            url: 'user.aspx/add',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username, password: password, customer: customer, rePassword: rePassword, employee: employee, rule: rule }),
            success: function (data) {
                alert("g");
                if (null != data.d) {
                    alert("Them thanh cong!")
                    bindData();
                } else {
                    alert("Khong thanh cong!")
                }

            },
            error: function (data) {
                alert("error  Add")
            }
        });
    } 
    
}


function validation(username, password, customer, rePassword, employee, rule) {
    var chek = true;
    if ('' != username || null != username) {
        $.ajax({
            url: 'user.aspx/chekUsername',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username }),
            success: function (data) {
                var st = data.d;
                if (null != st) {
                    $('#username_err').val('Tên tài khoản đã tồn tại ');
                    chek = false;
                }

            },
            error: function (data) {
                chek = false;
            }
        });
    } else {
        $('#username_err').val('Nhập lại');
        chek = false;
    }
    if ('' == password || null == password) {
        $('#password_err').val('Nhập lại');
        chek = false;
    }
    if ('' == rePassword || null == rePassword) {
        $('#rePassword_err').val('Nhập lại');
        chek = false;
    }
    if (('' != password || null != password) && ('' != rePassword || null != rePassword)) {
        if (password != rePassword) {
            $('#rePassword_err').val('Mật khẩu không trùng nhau');
            chek = false;
        }
    }
    return chek;
}
