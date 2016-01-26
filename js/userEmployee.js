/**
load table users
**/

var employees;
var items;
$(document).ready(function () {


    bindData();
    getEmloyees();

});

// load table 
function bindData() {

    $.ajax({
        url: 'userEmployee.aspx/getUsers',
        type: 'POST',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: {},
        success: loadTable,
        error: function (data) {
            alert("Không thành công")
        }
    });
}

function loadTable(data) {
    clear();
    $('#btnEdit').prop('disabled', true);
    $('#btnAdd').prop('disabled', false);
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    if ($('#dataTables-example').length != 0) {
        $('#dataTables-example').remove();
    }
    getEmloyees();

    items = data.d;
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>"
                + "<thead>"
                    + "<tr class='info'>"
                        + "<th>Tên tài khoản</th>"
                        + "<th>ID nhân viên</th>"
                        + "<th>Ngày tạo</th>"
                        + "<th>Người tạo</th>"
                        + "<th>Ngày sửa</th>"
                        + "<th>Người sửa</th>"
                        + "<th>Quyền</th>"
                        + "<th class=' no-link last'><span class='nobr'>Thao tác</span>"
                        + "</th></tr></thead><tbody>";
    var row;
    for (var i = 0; i < items.length; i++) {
        if (items[i].idEmp != 0) {
            row += " <tr class='even pointer'>";
            row += " <td class=''>" + items[i].username + "</td>";
            row += "<td class=''>" + items[i].idEmp + "</td>";
            row += "<td class=''>" + items[i].dateCreate + "</td>";
            row += "<td class=''>" + items[i].userCreate + "</td>";
            row += "<td class=''>" + items[i].dateUpdate + "</td>";
            row += "<td class=''>" + items[i].userUpdate + "</td>";
            row += "<td class=''>" + items[i].rule + "</td>";
            row += " <td class=' last'><a onclick='loadUser(\"" + items[i].username + "\")' ><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a>|"
            + "<a onclick='deleteUser(\"" + items[i].username + "\")' ><i data-toggle='tooltip' title='Xóa'  class='glyphicon glyphicon-remove'></i></a></td>";
            row += "</tr>";
        }
    }
    table += row;
    table += "</tbody></table>";
    $('#divtable').html(table);
}

// add 
function add() {
    var username = $('#txt_username').val();
    var password = $('#txt_password').val();
    var rePassword = $('#txt_rePassword').val();
    var employee = $('#employee').val();
    var rule = $('#rule').val();
    // alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation(username, password, rePassword, employee, rule);

    if (chek == true) {

        
        $.ajax({
            url: 'userEmployee.aspx/add',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username, password: password, rePassword: rePassword, employee: employee, rule: rule }),
            success: function (data) {
                if (null != data.d) {
                    alert("Thêm thành công!")
                    bindData();
                } else {
                    alert("Không thành công")
                }

            },
            error: function (data) {
                alert("Không thành công")
            }
        });
    }

}


function validation(username, password, rePassword, employee, rule) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var err = "<div class='form-group' id='listErr'";
    err += "<p>Các lỗi:</p>"
    var chek = true;
    if (username != "") {
        for (var i = 0; i < items.length; i++) {
            if (items[i].username == username) {
                chek = false;
                err += "<p style='color:red'>Tên tài khoản đã tồn tại</p>";
                break;
            }
        }

    } else {
        err += "<p style='color:red'>Nhập Tên</p>";
        chek = false;
    }
    if ("" == password) {
        err += "<p style='color:red'>Nhập mật khẩu</p>";
        chek = false;
    }

    if ("" == rePassword) {
        err += "<p style='color:red'>Nhập lại mật khẩu</p>";
        chek = false;
    }
    if (("" != password) && ("" != rePassword)) {
        if (password != rePassword) {

            err += "<p style='color:red'>Mật khẩu không trùng nhau</p>";
            chek = false;
        }
    }
    if ("" == employee || 0 == employee || null == employee) {
        err += "<p style='color:red'>Chọn nhân viên</p>";
        chek = false;
    } else {

        for (var i = 0; i < items.length; i++) {
            if ("DHF" != username&&items[i].idEmp==employee) {
                chek = false;
                err += "<p style='color:red'>Nhân viên đã được tạo tài khoản</p>";
                break;
            }
        }
    }

    if (chek == false) {

        err += "</div>";
        $('#err').html(err);
    }

    return chek;
}


//get customer
function getEmloyees() {
    $.ajax({
        type: "POST",
        url: "employee.aspx/getEmployees",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            employees = data.d;
            if (null != employees) {
                if ($('#employee').length != 0) {
                    $('#employee').remove();
                }

                var st = ""
                   + "<p>Nhân viên</p>"
                   + "<select class='form-control' style='margin-top: -10px;' id='employee'  >";
                var row;
                for (var i = 0; i < employees.length; i++) {
                    row += "<option  value='" + employees[i].idEmployee + "'>" + employees[i].idEmployee + "</option>";
                }
                row += "<option  selected='selected' value='0'>" + "</option>";
                st += row;
                st += "/select>"
                $('#getEmployees').html(st);


            }

        },
        error: function (result) {
            alert("Không thành công");
        }
    });

}
//delete 
function deleteUser(username) {
   
    var chek = confirm("Bạn có muốn xóa?");
    if (chek == true) {
        $.ajax({
            url: 'userEmployee.aspx/delete',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username }),
            success: function (data) {
                if (data.d != null) {
                    alert("Xóa thành công!")
                    bindData();
                }
            },
            error: function (data) {
                alert("Không thành công ")
            }
        });
    }

}
//edit 
function editUser() {

    var username = $('#txt_username').val();
    var password = $('#txt_password').val();
    var rePassword = $('#txt_rePassword').val();
    var employee = $('#employee').val();
    var rule = $('#rule').val();
   
    // alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation("DHF", password, rePassword, employee, rule);
    
    if (chek == true) {
        if (chek == true) {

            $.ajax({
                url: 'userEmployee.aspx/editUser',
                type: 'POST',
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ username: username, password: password, rePassword: rePassword, employee: employee, rule: rule }),
                success: function (data) {
                    if (null != data.d) {
                        alert("Sửa thành công!")
                        bindData();
                    } else {
                        alert("Không thành công")
                    }

                },
                error: function (data) {
                    alert("Không thành công")
                }
            });

        }

    }
}
// load user 
function loadUser(username) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnEdit').prop('disabled', false);
    $('#btnAdd').prop('disabled', true);
    var user;
    var employee;
    
    for (var i = 0; i < items.length; i++) {
        if (username == items[i].username)
            user = items[i];

    }
    if (user != null) {
        for (var i = 0; i < employees.length; i++) {
            if (user.idEmp == employees[i].idEmployee)
                employee = employees[i];
        }

        $('#txt_username').val(user.username);
        $('#txt_username').prop('disabled', true);


        if (null != employees && null != employee) {
            if ($('#employee').length != 0) {
                $('#employee').remove();
            }
            $('#txt_password').val(user.password);
            $('#txt_rePassword').val(user.password);
            var st = ""
               + "<p>Nhân viên</p>"
               + "<select class='form-control' style='margin-top: -10px;' id='employee'  >";
            var row;
            for (var i = 0; i < employees.length; i++) {
                if (employee.idEmployee == employees[i].idEmployee) {
                    row += "<option selected='selected'  value='" + employees[i].idEmployee + "'>" + employees[i].idEmployee + "</option>";
                } else {
                    row += "<option  value='" + employees[i].idEmployee + "'>" + employees[i].idEmployee + "</option>";
                }
            }
            row += "<option  value='0'>" + "</option>";
            st += row;
            st += "/select>"
            $('#getEmployees').html(st);


        }


        var rule;
        if (user.rule == "Quản lý") {
            $('#manager').remove();

            $('#managerEmployee').remove();

            rule += "<option id='manager' selected='selected'>Quản lý</option>"
            rule += " <option id='managerEmployee'>Xem thông tin nhân viên</option>"

            $('#rule').html(rule);

        } else if (user.rule == "Xem thông tin nhân viên") {
            $('#manager').remove();

            $('#managerEmployee').remove();
            rule += "<option id='manager' >Quản lý</option>"
            rule += " <option id='managerEmployee' selected='selected'>Xem thông tin nhân viên</option>"

            $('#rule').html(rule);
        }


    }


}

//refesh data
function clearUserEmployee() {
    clear();

}


function clear() {

    $('#txt_username').val('');
    $('#txt_password').val('');
    $('#txt_rePassword').val('');
    $('#txt_username').prop('disabled', false);
    //   $('#employee').val();
    //  $('#rule').val();
    $('#btnEdit').prop('disabled', true);
    $('#btnAdd').prop('disabled', false);
    if ($('#listErr').length != 0)
        $('#listErr').remove();
}
function exportFile() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var a = document.createElement('a');
    //getting data from our div that contains the HTML table
    var data_type = 'data:application/vnd.ms-excel';
    var table_div = document.getElementById('divtable');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'UserEmployee' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}


function searchUserEmployee() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var find = $('#srch').val();
  
    $.ajax({
        type: "POST",
        url: "userEmployee.aspx/search",
        data: JSON.stringify({ find: find }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: loadTable,
        error: function (result) {

            alert("Không thành công");
        }
    });

}
