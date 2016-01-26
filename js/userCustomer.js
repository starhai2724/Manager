/**
load table users
**/

var customers;
var items;
$(document).ready(function () {


    bindData();
    getCustomers();

});

// load table 
function bindData() {

    $.ajax({
        url: 'userCustomer.aspx/getUsers',
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
    getCustomers();

    items = data.d;
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>"
                + "<thead>"
                    + "<tr class='info'>"
                        + "<th>Tên tài khoản</th>"
                        + "<th>ID khách hàng</th>"
                        + "<th>Ngày tạo</th>"
                        + "<th>Người tạo</th>"
                        + "<th>Ngày sửa</th>"
                        + "<th>Người sửa</th>"
                        + "<th>Quyền</th>"
                        + "<th class=' no-link last'><span class='nobr'>Thao tác</span>"
                        + "</th></tr></thead><tbody>";
    var row;
    for (var i = 0; i < items.length; i++) {
        if (items[i].id_cus != 0) {
            row += " <tr class='even pointer'>";
            row += " <td class=''>" + items[i].username + "</td>";
            row += "<td class=''>" + items[i].id_cus + "</td>";
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
    var customer = $('#customer').val();
    var rule = $('#rule').val();
    // alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation(username, password, rePassword, customer, rule);

    if (chek == true) {

        
        $.ajax({
            url: 'userCustomer.aspx/add',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username, password: password, rePassword: rePassword, customer: customer, rule: rule }),
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


function validation(username, password, rePassword, customer, rule) {
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
    if ("" == customer || 0 == customer || null == customer) {
        err += "<p style='color:red'>Chọn khách hàng</p>";
        chek = false;
    } else {

        for (var i = 0; i < items.length; i++) {
            if ("DHF" != username && items[i].id_cus == customer) {
                chek = false;
                err += "<p style='color:red'>Khách hàng đã được tạo tài khoản</p>";
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
            url: 'userCustomer.aspx/delete',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username }),
            success: function (data) {
                if (data.d != null) {
                    
                    bindData();
                    alert("Xóa thành công!")
                }
            },
            error: function (data) {
                alert("Không thành công  ")
            }
        });
    }

}
//edit 
function editUser() {

    var username = $('#txt_username').val();
    var password = $('#txt_password').val();
    var rePassword = $('#txt_rePassword').val();
    var customer = $('#customer').val();
    var rule = $('#rule').val();
   
    // alert("username  " + username + "; " + "password  " + password + "; " + "customer  " + customer + "; " + "rePassword  " + rePassword + "; " + "employee  " + employee + "; " + "  " + "; " + "rule  " + rule + " ");
    var chek = validation("DHF", password, rePassword, customer, rule);
    
    if (chek == true) {


        $.ajax({
            url: 'userCustomer.aspx/editUser',
            type: 'POST',
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ username: username, password: password, rePassword: rePassword, customer: customer, rule: rule }),
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
// load user 
function loadUser(username) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnEdit').prop('disabled', false);
    $('#btnAdd').prop('disabled', true);
    var user;
    var customer;
    
    for (var i = 0; i < items.length; i++) {
        if (username == items[i].username)
            user = items[i];

    }
    if (user != null) {
        for (var i = 0; i < customers.length; i++) {
            if (user.id_cus == customers[i].idCustomer)
                customer = customers[i];
        }

        $('#txt_username').val(user.username);
        $('#txt_username').prop('disabled', true);


        if (null != customers && null != customer) {
            if ($('#customer').length != 0) {
                $('#customer').remove();
            }
            $('#txt_password').val(user.password);
            $('#txt_rePassword').val(user.password);
            var st = ""
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
            st += row;
            st += "/select>"
            $('#getCustomers').html(st);


        }


        var rule;
        if (user.rule == "Quản lý") {

            $('#managerApartment').remove();


            rule += "<option id='managerApartment' selected='selected'>Xem thông tin căn hộ</option>"

            $('#rule').html(rule);

        } else if (user.rule == "Xem thông tin căn hộ") {


            $('#managerApartment').remove();

            rule += "<option id='managerApartment' selected='selected'>Xem thông tin căn hộ</option>"

            $('#rule').html(rule);
        }


    }


}

//refesh data
function clearUserCustomer() {
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
    a.download = 'UserCustomer' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}


function searchUserCustomer() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var find = $('#srch').val();
  
    $.ajax({
        type: "POST",
        url: "userCustomer.aspx/search",
        data: JSON.stringify({ find: find }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: loadTable,
        error: function (result) {

            alert("Không thành công");
        }
    });

}
