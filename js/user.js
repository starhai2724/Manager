/**
load table users
**/
var customers;
var employees;
var items;
$(document).ready(function () {


    bindData();
    getEmloyees();
    getCustomers();
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
    getEmloyees();
    getCustomers();
    items = data.d;
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>"
                + "<thead>"
                    + "<tr class='info'>"
                        + "<th>Tên tài khoản</th>"
                        + "<th>ID khách hàng</th>"
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
        row += " <tr class='even pointer'>";
        row += " <td class=''>" + items[i].username + "</td>";
        row += "<td class=''>" + items[i].id_cus + "</td>";
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
    table += row;
    table += "</tbody></table>";
    $('#divtable').html(table);
}

// add 
function add() {
    var username = $('#txt_username').val();
    var password = $('#txt_password').val();
    var customer = $('#customer').val();
    var rePassword = $('#txt_rePassword').val();
    var employee = $('#employee').val();
    var rule = $('#rule').val();
    // alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation(username, password, customer, rePassword, employee, rule);

    if (chek == true) {
        // 
        if (0 != customer) {
            alert("Employee " + customer);
            employee = 0;
        } else {
            alert("customer");
            customer = 0;
        }
        alert("abc")
        $.ajax({
            url: 'user.aspx/add',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username, password: password, customer: customer, rePassword: rePassword, employee: employee, rule: rule }),
            success: function (data) {
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
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var err = "<div class='form-group' id='listErr'";
    err += "<p>Các lỗi:</p>"
    var chek = true;
    if (customer == null)
        customer = 0;
    if (employee == null)
        employee = 0;

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
    if ((customer == 0 && employee == 0) || (customer != 0 && employee != 0)) {

        err += "<p style='color:red'>Vui lòng chọn khách hàng hoặc nhân viên</p>";
        chek = false;
    }
    if (chek == false) {

        err += "</div>";
        $('#err').html(err);
    }

    return chek;
}


//get customer

function getCustomers() {
    $.ajax({
        type: "POST",
        url: "customers.aspx/getCustomersByHolder",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            customers = data.d;
           



            if (null != customers) {
                if ($('#customer').length != 0) {
                    $('#customer').remove();
                }
               
                var st = ""
                   + "<p>Khách hàng</p>"
                   + "<select class='form-control' style='margin-top: -10px;' id='customer'  >";
                var row;
                for (var i = 0; i < customers.length; i++) {
                    row += "<option  value='" + customers[i].idCustomer + "'>" + customers[i].identifiCardCustomer + "</option>";
                }
                row += "<option  selected='selected' value='0'>" + "</option>";
                st += row;
                st += "/select>"
                $('#getCustomers').html(st);

              //  $('#identifiCardCustomer0').val('ABC');

            }

        },
        error: function (result) {
            alert("Error");
        }
    });

}

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
                    row += "<option  value='" + employees[i].idEmployee + "'>" + employees[i].identifiCard + "</option>";
                }
                row += "<option  selected='selected' value='0'>" + "</option>";
                st += row;
                st += "/select>"
                $('#getEmployees').html(st);


            }

        },
        error: function (result) {
            alert("Error");
        }
    });

}
//delete 
function deleteUser(username) {
    alert("delete");
    var chek = confirm("Ban chac chan muon xoa?");
    if (chek == true) {
        $.ajax({
            url: 'user.aspx/delete',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username }),
            success: function (data) {
                if (data.d != null) {
                    alert("Xoa thanh cong!")
                    bindData();
                }
            },
            error: function (data) {
                alert("error  ")
            }
        });
    }

}
//edit 
function editUser() {
    var username = $('#txt_username').val();
    var password = $('#txt_password').val();
    var customer = $('#customer').val();
    var rePassword = $('#txt_rePassword').val();
    var employee = $('#employee').val();
    var rule = $('#rule').val();
    alert("rule: " + rule);
    // alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation("DHF", password, customer, rePassword, employee, rule);
    alert("check " + chek+" customer: "+customer+" employee: "+employee);
    if (chek == true) {
        if (chek == true) {
            alert("check " + chek);
            if (0 != customer) {
                alert("Employee " + customer);
                employee = 0;
            } else {
                alert("customer");
                customer = 0;
            }
            $.ajax({
                url: 'user.aspx/editUser',
                type: 'POST',
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ username: username, password: password, customer: customer, rePassword: rePassword, employee: employee, rule: rule }),
                success: function (data) {
                    if (null != data.d) {
                        alert("Sua thanh cong!")
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
}
// load user 
function loadUser(username) {
    var user;
    var customer;
    var employee;

    alert("user: " + username);
    for (var i = 0; i < items.length; i++) {
        if (username == items[i].username)
            user = items[i];

    }
    if (user != null) {

        for (var i = 0; i < customers.length; i++) {
            if (user.id_cus == customers[i].idCustomer)
                customer = customers[i];
        }

        for (var i = 0; i < employees.length; i++) {
            if (user.idEmp == employees[i].idEmployee)
                employee = employees[i];
        }

        $('#txt_username').val(user.username);
        $('#txt_username').prop('disabled', true);
        if (null != customers && null != customer) {
            if ($('#customer').length != 0) {
                $('#customer').remove();
            }
            $('#employee').val('');
            var selectCustomer = ""
               + "<p>Khách hàng</p>"
               + "<select class='form-control' style='margin-top: -10px;' id='customer'  >";
            var row;
            for (var i = 0; i < customers.length; i++) {
                if (customer.idCustomer == customers[i].idCustomer) {
                    row += "<option selected='selected'  value='" + customers[i].idCustomer + "'>" + customers[i].identifiCardCustomer + "</option>";

                } else {
                    row += "<option  value='" + customers[i].idCustomer + "'>" + customers[i].identifiCardCustomer + "</option>";
                }
            }
            row += "<option  value='0'>" + "</option>";
            selectCustomer += row;
            selectCustomer += "/select>"
            $('#getCustomers').html(selectCustomer);
        }



        if (null != employees && null != employee) {
            if ($('#employee').length != 0) {
                $('#employee').remove();
            }
            $('#customer').val('');
            var st = ""
               + "<p>Nhân viên</p>"
               + "<select class='form-control' style='margin-top: -10px;' id='employee'  >";
            var row;
            for (var i = 0; i < employees.length; i++) {
                if (employee.idEmployee == employees[i].idEmployee) {
                    row += "<option selected='selected'  value='" + employees[i].idEmployee + "'>" + employees[i].identifiCard + "</option>";
                } else {
                    row += "<option  value='" + employees[i].idEmployee + "'>" + employees[i].identifiCard + "</option>";

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
            $('#managerApartment').remove();
            $('#managerEmployee').remove();

            rule += "<option id='manager' selected='selected'>Quản lý</option>"
            rule += "<option id='managerApartment'>Xem thông tin căn hộ</option>"
            rule += " <option id='managerEmployee'>Xem thông tin nhân viên</option>"

            $('#rule').html(rule);
        } else if (user.rule == "Xem thông tin căn hộ") {
            $('#manager').remove();
            $('#managerApartment').remove();
            $('#managerEmployee').remove();
            rule += "<option id='manager' >Quản lý</option>"
            rule += "<option id='managerApartment' selected='selected'>Xem thông tin căn hộ</option>"
            rule += " <option id='managerEmployee'>Xem thông tin nhân viên</option>"

            $('#rule').html(rule);
        } else if (user.rule == "Xem thông tin nhân viên") {
            $('#manager').remove();
            $('#managerApartment').remove();
            $('#managerEmployee').remove();
            rule += "<option id='manager' >Quản lý</option>"
            rule += "<option id='managerApartment' >Xem thông tin căn hộ</option>"
            rule += " <option id='managerEmployee' selected='selected'>Xem thông tin nhân viên</option>"

            $('#rule').html(rule);
        }




    }


}