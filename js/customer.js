var apartments;
var pCustomers;
// get apartments
function getApartments() {
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartmentsExcept",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if ($('#idApartment').length != 0) {
                $('#idApartment').remove();
            }
            apartments = data.d;

            var st = " <div class='form-group'>"
                    + "<p>Căn hộ</p>"
                    + "<select class='form-control' style='margin-top: -10px;' id='idApartment'>";
            var row;
            for (var i = 0; i < apartments.length; i++) {
                row += "<option value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
            }
            st += row;
            st += "/select></div>"
            $('#getApartments').html(st);

        },
        error: function (result) {
            alert("Không thành công");
        }
    });
}



$(document).ready(function () {

    bindData();
    getApartments();
});
// load table
function bindData() {
    $('#btnEdit').prop('disabled', true);
    $('#btnAdd').prop('disabled', false);

    $.ajax({
        type: "POST",
        url: "customers.aspx/getCustomers",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Không thành công");
        }
    });
}
//OnSuccess
function getDatas(response) {
    if ($('#dataTables-example').length != 0) {
        $('#dataTables-example').remove();
    }
    var items = response.d;
    pCustomers = items;
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>" +
                    "<thead id='header'>" +
                        "<tr class='info'>"
                           + " <th>Mã</th>"
                            + "<th>Tên</th>"
                            + "<th>Ngày sinh</th>"
                            + "<th>Giới tính </th>"
                            + "<th>Quê quán</th>"
                            + "<th>CMND</th>"
                            + "<th>Email</th>"
                            + "<th>SDT</th>"
                            + "<th>Căn hộ</th>"
                             + "<th>Quyền </th>"
                            + "<th>Tình trạng </th>"
                            + "<th>Ngày tạo</th>"
                            + "<th>Người tạo </th>"
                            + "<th>Ngày sửa </th>"
                            + "<th>Người sửa</th>"
                            + "<th class=' no-link last'><span class='nobr'>Thao tác</span>"
                            + "</th>"
                        + "</tr>"
                    + "</thead> <tbody>"

    for (var i = 0; i < items.length; i++) {
        var row = " <tr class='even pointer'>";
        row += "<td class=''>" + items[i].idCustomer + "</td>";
        row += "<td class=''>" + items[i].nameCustomer + "</td>";
        row += "<td class=''>" + items[i].birthday + "</td>";
        row += "<td class=''>" + items[i].sex + "</td>";
        row += "<td class=''>" + items[i].addressCustomer + "</td>";
        row += "<td class=''>" + items[i].identifiCardCustomer + "</td>";
        row += "<td class=''>" + items[i].email + "</td>";
        row += " <td class='a-right a-right '>" + items[i].sdt + "</td>";
        row += " <td class='a-right a-right '>" + items[i].idApartment + "</td>";
        row += " <td class='a-right a-right '>" + items[i].holder + "</td>"
        row += " <td class='a-right a-right '>" + items[i].status + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateUpdate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userUpdate + "</td>"
        row += " <td class=' last'><a onclick='loadCustomer(" + items[i].idCustomer + ")'><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a> |"
            + "<a onclick='deleteCustomer(" + items[i].idCustomer + ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable').html(table);
}
// add


function add() {
    var id = $('#idCustomer').val();
    var name = $('#txtName').val();
    var address = $('#txtAddress').val();
    var identifiCard = $('#txt_identifiCard').val();
    var sex = $('#sex').val();
    var idApartment = $('#idApartment').val();
    var birthday = $('#txtBirthday').val() + "";
    var holder = $('#holder').val();
    var email = $('#txtEmail').val();
    var phone = $('#txtPhone').val();
    var status = $('#status').val();
    var check = validationCustomer(name, identifiCard, phone, id, idApartment, holder, email);
    if (check == true) {
        $.ajax({
            type: "POST",
            url: "customers.aspx/add",
            data: JSON.stringify({ name: name, address: address, identifiCard: identifiCard, sex: sex, idApartment: idApartment, birthday: birthday, holder: holder, email: email, phone: phone, status: status }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                bindData();
                clear();
                alert("Thêm thành công");
            },
            error: function (result) {
                alert("Không thành công");
            }

        });
    }


}

//refesh data

function clearDataCustomer() {
    clear();
}




//clear 
function clear() {

    $('#txtName').val('');
    $('#txtAddress').val('');
    $('#txt_identifiCard').val('');
    //$('#sex').val('');
    $('#idApartment').val('');
    $('#txtBirthday').val('');
    //$('#holder').val('');
    $('#txtEmail').val('');
    $('#txtPhone').val('');
    //$('#status').val('');
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnEdit').prop('disabled', true);
    $('#btnAdd').prop('disabled', false);
}
//Edit
function loadCustomer(idCustomer) {
    $('#btnEdit').prop('disabled', false);
    $('#btnAdd').prop('disabled', true);
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $.ajax({
        type: "POST",
        url: "customers.aspx/getCustomer",
        data: JSON.stringify({ idCustomer: idCustomer }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getData,
        error: function (result) {
            alert("Không thành công");
        }
    });


}

function getData(data) {
    var customer = data.d;
    
    $('#idCustomer').val(customer.idCustomer);
    $('#txtName').val(customer.nameCustomer);
    $('#txtAddress').val(customer.addressCustomer);
    $('#txt_identifiCard').val(customer.identifiCardCustomer);
    $('#sex').val(customer.sex);
    // $('#idApartment').val(customer.);
    $('#txtBirthday').val(customer.birthday);
    $('#holder').val(customer.holder);
    $('#txtEmail').val(customer.email);
    $('#txtPhone').val(customer.sdt);
    $('#status').val(customer.status);

    if ($('#listErr').length != 0)
        $('#listErr').remove();

    if ($('#idApartment').length != 0) {
        $('#idApartment').remove();
    }
   // alert("apartment: " + apartments.length);
    var st = " <div class='form-group'>"
            + "<p>Căn hộ</p>"
            + "<select class='form-control' style='margin-top: -10px;' id='idApartment'>";
    var row;
    for (var i = 0; i < apartments.length; i++) {
        if (apartments[i].idApartment == customer.idApartment) {
            row += "<option  selected='selected' value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
        } else {

            row += "<option value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
        }
    }
    st += row;
    st += "/select></div>"
    $('#getApartments').html(st);
    var holder;
    if (customer.holder == "Thành viên") {
        if ($('#optionmember').length != 0) {
            $('#optionmember').remove();
            holder = "<option id='optionmember' selected='selected'>Thành viên</option>";
            holder += "<option id='optionholder'>Chủ</option>";
        }

    } else {
        if ($('#optionholder').length != 0) {
            $('#optionholder').remove();
            holder = "<option id='optionholder' selected='selected'>Chủ</option>";
            holder += "<option id='optionmember' >Thành viên</option>";
        }
    }
    $('#holder').html(holder);

    var sex;
    if (customer.sex == "Nam") {
        if ($('#male').length != 0) {
            $('#male').remove();
            sex = "<option selected='selected' id='male'>Nam</option>";
            sex += "<option id='female'>Nữ</option>";
        }

    } else {
        if ($('#female').length != 0) {
            $('#female').remove();
            sex = "<option  id='male'>Nam</option>";
            sex += "<option selected='selected' id='female'>Nữ</option>";
        }

    }
    $('#sex').html(sex);


    var status;
    if (customer.status == "Đang hoạt động") {
        if ($('#active').length != 0) {
            $('#active').remove();
            status = "<option id='active' selected='selected'>Đang hoạt động</option>";
            status += " <option  id='noActive'>Không hoạt động</option>";
        }

    } else {
        if ($('#noActive').length != 0) {
            $('#noActive').remove();
            status = "<option id='active' >Đang hoạt động</option>";
            status += " <option  id='noActive' selected='selected'>Không hoạt động</option>";
        }
    }
    $('#status').html(status);
}
function edit() {

    var name = $('#txtName').val();
    var address = $('#txtAddress').val();
    var identifiCard = $('#txt_identifiCard').val();
    var sex = $('#sex').val();
    var idApartment = $('#idApartment').val();
    var birthday = $('#txtBirthday').val() + "";
    var holder = $('#holder').val();
    var email = $('#txtEmail').val();
    var phone = $('#txtPhone').val();
    var status = $('#status').val();
    var id = $('#idCustomer').val();
    //alert("idApartment  " + idApartment);
    //alert("name:" + name + " address:" + address + " address:" + identifiCard + " address:" + sex + " address:" + idApartment, "address:" + birthday + " address:" + holder + " address:" + email + " address:" + phone + " address:" + status);
    var check = validationCustomer(name, identifiCard, phone, id, idApartment, holder, email);
    if (check == true) {
        $.ajax({
            type: "POST",
            url: "customers.aspx/edit",
            data: JSON.stringify({ id: id, name: name, address: address, identifiCard: identifiCard, sex: sex, idApartment: idApartment, birthday: birthday, holder: holder, email: email, phone: phone, status: status }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                bindData();
                clear();
                alert("Sửa thành công");

            },
            error: function (result) {
                alert("Không thành công");
            }

        });
    }

}
//search 
function search() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var find = $('#srch-term').val();
    $.ajax({
        type: "POST",
        url: "customers.aspx/search",
        data: JSON.stringify({ find: find }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Không thành công");
        }
    });


}
//delete
function deleteCustomer(id) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var msg = confirm("Bạn có chắc chắn muốn xóa!")
    if (msg == true) {

        $.ajax({
            type: "POST",
            url: "customers.aspx/delete",
            data: JSON.stringify({ id: id }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert("Xóa thành công!");
                bindData();


            },
            error: function (result) {
                alert("Không thành công");
            }
        });
    }

}
// in
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
    a.download = 'Customers' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}


function validationCustomer(name, identifiCard, phone, id, idApartment, holder, email) {
    $('#holder').val();
    var checkEmail = isEmailAddress(email);
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var err = "<div class='form-group' id='listErr'";
    err += "<p>Các lỗi:</p>"
    var check = true;
    if ("" == name) {
        check = false;
        err += "<p style='color:red'>Nhập Tên</p>";


    }
    if ("" == identifiCard) {
        check = false;
        err += "<p style='color:red'>Nhập cmnd</p>";
    }

    if ("" == email) {
        check = false;
        err += "<p style='color:red'>Nhập email</p>";
    } else {
        if (checkEmail == false) {
            check = false;
            err += "<p style='color:red'>Nhập lại email</p>";
        }
    }

    for (var i = 0; i < pCustomers.length; i++) {
        if (pCustomers[i].email == email && id != pCustomers[i].idCustomer) {
            err += "<p style='color:red'>Email đã tồn tại</p>";
            check = false;
            break;
        }
    }



    if ("" == phone) {
        check = false;
        err += "<p style='color:red'>Nhập sdt</p>";
    }
    for (var i = 0; i < pCustomers.length; i++) {
        if (pCustomers[i].identifiCardCustomer == identifiCard && id != pCustomers[i].idCustomer) {
            err += "<p style='color:red'>Số CMND đã tồn tại</p>";
            check = false;
            break;
        }
    }
    if (check == false) {

        err += "</div>";
        $('#err').html(err);
    }
    return check;



}
function ruleCustomer(idApartment) {

    for (var i = 0; i < pCustomers; i++) {
        if (pCustomers[i].idApartment == idApartment && pCustomers[i].holder == "Chủ") {

        }

    }


}



function isEmailAddress(str) {
    var pattern = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    return pattern.test(str);  // returns a boolean 
}