﻿function loadData(idEmployee) {
    alert("idEmployee" + idEmployee);
    $.ajax({
        type: "POST",
        url: "employee.aspx/getEmployee",
        data: JSON.stringify({ id: idEmployee }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        error: function (result) {
            alert("Error");
        }
    });
}

function OnSuccess(response) {
    var item = response.d;
    //alert(item.priceSale);
    $('#text_idEmployee').val(item.idEmployee);
    $('#text_nameEmployee').val(item.nameEmployee);
    $('#text_officeEmployee').val(item.officeEmployee);
    $('#text_sexEmployee').val(item.sex);
    $('#text_addressEmployee').val(item.address);
    $('#text_salaryEmployee').val(item.salaryEmployee);
    $('#text_identyfi_card_emp').val(item.identifiCard);
   // $('#text_status').val(item.status);
    $('#birthday_emp').val(item.birthday);

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

    $.ajax({
        type: "POST",
        url: "employee.aspx/editEmployee",
        data: JSON.stringify({ id: idEmployee, name_emp: nameEmployee, salary_emp: salaryEmployee, sex_emp: sexEmployee, office_emp: officeEmployee, address_emp : address,  identify_card_emp: identifyCardEmployee,  status: status,  birthday_emp: birthday }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            bindData();
            clear();
            alert("Sua thanh cong");
        },
        error: function (result) {
            alert("Error");
        }

    });
}
// them emp

function add() {
    var nameEmployee = $('#text_nameEmployee').val();
    var salaryEmployee = $('#text_salaryEmployee').val();
    var sexEmployee = $('#text_sexEmployee').val();
    var officeEmployee = $('#text_officeEmployee').val();
    var address = $('#text_addressEmployee').val();
    var identifyCardEmployee = $('#text_identyfi_card_emp').val();
    var status = $('#text_status').val();
    var birthday = $('#birthday_emp').val();
    alert("add " + nameEmployee);
    $.ajax({
        type: "POST",
        url: "employee.aspx/add",
        data: JSON.stringify({ name_emp: nameEmployee, salary_emp: salaryEmployee, sex_emp: sexEmployee, office_emp: officeEmployee, address_emp: address, identify_card_emp: identifyCardEmployee, status: status, birthday_emp: birthday }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            bindData();
            clear();
            alert("Them thanh cong");
        },
        error: function (result) {
            alert("Error");
        }

    });
}

//reset input
function clear() {
    $('#text_idEmployee').val('');
    $('#text_nameEmployee').val('');
    $('#text_officeEmployee').val('');
    $('#text_sexEmployee').val('');
    $('#birthday_emp').val('');
    $('#text_identyfi_card_emp').val('');
    $('#text_addressEmployee').val('');
    $('#text_salaryEmployee').val('');
    $('#text_status').val('');

}


//delete 

function del(idEmployee) {
    var msg = confirm("Ban co chac chan muon xoa!")
    if (msg == true) {
        $.ajax({
            type: "POST",
            url: "employee.aspx/delete",
            data: JSON.stringify({ id: idEmployee }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function () {
                bindData();
                alert("Xoa thanh cong!")

            },
            error: function (result) {
                alert("Error");
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
    $.ajax({
        type: "POST",
        url: "employee.aspx/getEmployees",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Error bind employee");
        }
    });
}
//OnSuccess
function getDatas(response) {
    if ($('#dataTables-example').length != 0) {
        $('#dataTables-example').remove();
    }
    var items = response.d;
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
           + "<a onclick='del(" + items[i].idEmployee+ ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable_emp').html(table);
}


//search 



function search() {
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

            alert("Error");
        }
    });
}

// xuat file excel

function exportFile() {

    var a = document.createElement('a');
    //getting data from our div that contains the HTML table
    var data_type = 'data:application/vnd.ms-excel';
    var table_div = document.getElementById('divtable_emp');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'Employees' +'.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour
   
}