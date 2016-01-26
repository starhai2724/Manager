var pEmployees;
function loadData(idEmployee) {
    $('#btnedit').prop('disabled', false);
    $('#btnadd').prop('disabled', true);

    if ($('#listErr').length != 0)
        $('#listErr').remove();
    
    $.ajax({
        type: "POST",
        url: "employee.aspx/getEmployee",
        data: JSON.stringify({ id: idEmployee }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        error: function (result) {
            alert("Không thành công");
        }
    });
}

function OnSuccess(response) {
    var item = response.d;
    //alert(item.priceSale);
    $('#text_idEmployee').val(item.idEmployee);
    $('#text_nameEmployee').val(item.nameEmployee);
    $('#text_officeEmployee').val(item.officeEmployee);
    $('#text_addressEmployee').val(item.address);
    $('#text_salaryEmployee').val(item.salaryEmployee);
    $('#text_identyfi_card_emp').val(item.identifiCard);
    // $('#text_status').val(item.status);
    $('#birthday_emp').val(item.birthday);

    var sex;
    if (item.sex == "Nam") {
        if ($('#sexMale').length != 0) {
            $('#sexMale').remove();
            sex = "<option selected='selected' id='sexMale'>Nam</option>";
            sex += "<option id='sexFemale'>Nữ</option>";
        }

    } else {
        if ($('#sexFemale').length != 0) {
            $('#sexFemale').remove();
            sex = "<option  id='sexMale'>Nam</option>";
            sex += "<option selected='selected' id='sexFemale'>Nữ</option>";
        }

    }
    $('#text_sexEmployee').html(sex);


    var status;
    if (item.status == "Đang hoạt động") {
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
    $('#text_status').html(status);

}
//edit 
function edit() {
    var idEmployee = $('#text_idEmployee').val();
    var nameEmployee = $('#text_nameEmployee').val();
    var salaryEmployee = $('#text_salaryEmployee').val();
    var sexEmployee = $('#text_sexEmployee').val();
    var officeEmployee = $('#text_officeEmployee').val();
    var address = $('#text_addressEmployee').val();
    var identifyCardEmployee = $('#text_identyfi_card_emp').val();
    var status = $('#text_status').val();
    var birthday = $('#birthday_emp').val();
    var check = validationEmployee(idEmployee, nameEmployee, salaryEmployee, sexEmployee, officeEmployee, address, identifyCardEmployee, status, birthday);
    if (check == true) {
        $.ajax({
            type: "POST",
            url: "employee.aspx/editEmployee",
            data: JSON.stringify({ id: idEmployee, name_emp: nameEmployee, salary_emp: salaryEmployee, sex_emp: sexEmployee, office_emp: officeEmployee, address_emp: address, identify_card_emp: identifyCardEmployee, status: status, birthday_emp: birthday }),
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
// them emp

function add() {
    var idEmployee = $('#text_idEmployee').val();
    var nameEmployee = $('#text_nameEmployee').val();
    var salaryEmployee = $('#text_salaryEmployee').val();
    var sexEmployee = $('#text_sexEmployee').val();
    var officeEmployee = $('#text_officeEmployee').val();
    var address = $('#text_addressEmployee').val();
    var identifyCardEmployee = $('#text_identyfi_card_emp').val();
    var status = $('#text_status').val();
    var birthday = $('#birthday_emp').val();
    var check = validationEmployee(idEmployee, nameEmployee, salaryEmployee, sexEmployee, officeEmployee, address, identifyCardEmployee, status, birthday);
    if (check == true) {
        $.ajax({
            type: "POST",
            url: "employee.aspx/add",
            data: JSON.stringify({ name_emp: nameEmployee, salary_emp: salaryEmployee, sex_emp: sexEmployee, office_emp: officeEmployee, address_emp: address, identify_card_emp: identifyCardEmployee, status: status, birthday_emp: birthday }),
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

function clearDataEmployee() {

    clear();
}


//reset input
function clear() {

    $('#text_idEmployee').val('');
    $('#text_nameEmployee').val('');
    $('#text_officeEmployee').val('');
    //$('#text_sexEmployee').val('');
    $('#birthday_emp').val('');
    $('#text_identyfi_card_emp').val('');
    $('#text_addressEmployee').val('');
    $('#text_salaryEmployee').val('');
    //$('#text_status').val('');
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnedit').prop('disabled', true);
    $('#btnadd').prop('disabled', false);

}


//delete 

function del(idEmployee) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var msg = confirm("Bạn có muốn xóa!")
    if (msg == true) {
        $.ajax({
            type: "POST",
            url: "employee.aspx/delete",
            data: JSON.stringify({ id: idEmployee }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function () {
                bindData();
                alert("Xóa thành công!")

            },
            error: function (result) {
                alert("Không thành công");
            }
        });
    }
}
// show ra bang du lieu khi trang vua dc load.
$(document).ready(function () {

    bindData();
});
// load table

function bindData() {
    $('#btnedit').prop('disabled', true);
    $('#btnadd').prop('disabled', false);
    $.ajax({
        type: "POST",
        url: "employee.aspx/getEmployees",
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
    pEmployees = items;
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>" +
                    "<thead>" +
                        "<tr class='info'>"
                          + "<th>Mã nhân viên</th>"
                            + "<th>Tên </th>"
                            + "<th>Ngày sinh</th>"
                            + "<th>Quê quán</th>"
                            + "<th>Chứng minh nhân dân</th>"
                            + "<th>Giới tính</th>"
                            + "<th>Chức vụ</th>"
                            + "<th>Lương</th>"
                            + "<th>Tình trạng</th>"
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
        row += "<td class=''>" + items[i].idEmployee + "</td>";
        row += "<td class=''>" + items[i].nameEmployee + "</td>";
        row += "<td class=''>" + items[i].birthday + "</td>";
        row += "<td class=''>" + items[i].address + "</td>";
        row += "<td class=''>" + items[i].identifiCard + "</td>";
        row += "<td class=''>" + items[i].sex + "</td>";
        row += "<td class=''>" + items[i].officeEmployee + "</td>";
        row += "<td class=''>" + items[i].salaryEmployee + "</td>";
        row += " <td class='a-right a-right '>" + items[i].status + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateUpdate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userUpdate + "</td>"
        row += " <td class=' last'><a onclick='loadData(" + items[i].idEmployee + ")'><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a> |"
           + "<a onclick='del(" + items[i].idEmployee + ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable_emp').html(table);
}


//search 



function search() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var find = $('#srch').val();
    alert("search  " + find);
    $.ajax({
        type: "POST",
        url: "employee.aspx/search",
        data: JSON.stringify({ st: find }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {

            alert("Không thành công");
        }
    });
}

// xuat file excel

function exportFile() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var a = document.createElement('a');
    //getting data from our div that contains the HTML table
    var data_type = 'data:application/vnd.ms-excel';
    var table_div = document.getElementById('divtable_emp');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'Employees' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}
function validationEmployee(id, nameEmployee, salaryEmployee, sexEmployee, officeEmployee, address, identifyCardEmployee, status, birthday) {

    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var err = "<div class='form-group' id='listErr'";
    err += "<p>Các lỗi:</p>"
    var check = true;
    if ("" == nameEmployee) {
        check = false;
        err += "<p style='color:red'>Nhập Tên</p>";
    }
    if ("" == salaryEmployee || 0 == salaryEmployee || null == salaryEmployee) {
        check = false;
        err += "<p style='color:red'>Nhập lương</p>";
    }
    if ("" == sexEmployee) {
        check = false;
        err += "<p style='color:red'>Chọn giới tính</p>";
    }
    if ("" == officeEmployee) {
        check = false;
        err += "<p style='color:red'>Nhập chức vụ</p>";
    }
    if ("" == address) {
        check = false;
        err += "<p style='color:red'>Nhập địa chỉ</p>";
    }
    if ("" == identifyCardEmployee) {
        check = false;
        err += "<p style='color:red'>Nhập số CMND</p>";
    }
    for (var i = 0; i < pEmployees.length; i++) {
        if (pEmployees[i].identifiCard == identifyCardEmployee && id != pEmployees[i].idEmployee) {
            err += "<p style='color:red'>Số CMND đã tồn tại</p>";
            check = false;
            break;
        }
    }

    if ("" == status) {
        check = false;
        err += "<p style='color:red'>Chọn trạng thái</p>";
    }
    if ("" == birthday) {
        check = false;
        err += "<p style='color:red'>Chọn ngày sinh</p>";
    }


    if (check == false) {

        err += "</div>";
        $('#err').html(err);
    }
    return check;

}