
var pApartments;
function loadData(name) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnEdit').prop('disabled', false);
    $('#btnAdd').prop('disabled', true);
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartment",
        data: JSON.stringify({ id: name }),
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
    $('#text_idApartment').val(item.idApartment);
    $('#text_nameApartment').val(item.nameApartment);
    $('#text_priceSale').val(item.priceSale);
    $('#text_size').val(item.size);
    $('#text_priceRent').val(item.priceRent);

    var status;
    if (item.statusApartment == "Trống") {
        if ($('#status1').length != 0) {
            $('#status1').remove();
            $('#status2').remove();
            $('#status3').remove();
            status = "<option selected='selected' id='status1'>Trống</option>";
            status += "<option id='status2'>Đang thuê</option>";
            status += "<option id='status3'>Đã bán</option>";
        }

    } else if (item.statusApartment == "Đang thuê") {

        if ($('#status2').length != 0) {
            $('#status1').remove();
            $('#status2').remove();
            $('#status3').remove();
            status = "<option  id='status1'>Trống</option>";
            status += "<option id='status2' selected='selected'>Đang thuê</option>";
            status += "<option id='status3'>Đã bán</option>";
        }


    } else if (item.statusApartment == "Đã bán") {


        if ($('#status3').length != 0) {
            $('#status1').remove();
            $('#status2').remove();
            $('#status3').remove();
            status = "<option  id='status1'>Trống</option>";
            status += "<option id='status2'>Đang thuê</option>";
            status += "<option id='status3' selected='selected'>Đã bán</option>";
        }
    }

    $('#status').html(status);



    var type;
    if (item.typeApartment == "VIP") {
        if ($('#VIP').length != 0) {
            $('#VIP').remove();
            $('#Nomal').remove();
            type = "<option selected='selected' id='VIP'>VIP</option>";
            type += "<option id='Nomal'>Bình thường</option>";
           
        }

       

    } else  {
        if ($('#Nomal').length != 0) {
            $('#VIP').remove();
            $('#Nomal').remove();
            type = "<option  id='VIP'>VIP</option>";
            type += "<option selected='selected' id='Nomal'>Bình thường</option>";

        }

    } 

    $('#type').html(type);



}
//edit 
function edit() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var idApartment = $('#text_idApartment').val();
    var nameApartment = $('#text_nameApartment').val();
    var typeApartment = $('#type').val();
    var size = $('#text_size').val();
    var priceSale = $('#text_priceSale').val();
    var priceRent = $('#text_priceRent').val();
    var statusApartment = $('#status').val();
    var userEdit = localStorage.getItem('username');
    var check = validationApartment(idApartment, nameApartment, typeApartment, size, priceSale, priceRent, statusApartment);
    if (check == true) {
        $.ajax({
            type: "POST",
            url: "apartment.aspx/editApartment",
            data: JSON.stringify({ id: idApartment, name: nameApartment, type: typeApartment, size: size, priceS: priceSale, priceR: priceRent, status: statusApartment, userUpdate: userEdit }),
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
// them can ho



function add() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var nameApartment = $('#text_nameApartment').val();
    var typeApartment = $('#type').val();
    var size = $('#text_size').val();
    var priceSale = $('#text_priceSale').val();
    var priceRent = $('#text_priceRent').val();
    var statusApartment = $('#status').val();
    var idApartment = $('#text_idApartment').val();
    var check = validationApartment(idApartment, nameApartment, typeApartment, size, priceSale, priceRent, statusApartment);
    if (check == true) {
        $.ajax({
            type: "POST",
            url: "apartment.aspx/add",
            data: JSON.stringify({ name: nameApartment, type: typeApartment, size: size, priceS: priceSale, priceR: priceRent, status: statusApartment }),
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
function clearDataApartment() {
    clear();
}



//reset input
function clear() {
    $('#text_idApartment').val('');
    $('#text_nameApartment').val('');
    //$('#type').val('');
    $('#text_size').val('');
    $('#text_priceSale').val('');
    $('#text_priceRent').val('');
   // $('#status').val('');
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnEdit').prop('disabled', true);
    $('#btnAdd').prop('disabled', false);
}
//delete 

function del(idDelete) {
    var msg = confirm("Bạn muốn xóa!")
    if (msg == true) {
        $.ajax({
            type: "POST",
            url: "apartment.aspx/delete",
            data: JSON.stringify({ id: idDelete }),
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
    //bat loi





});
// load table

function bindData() {
    $('#btnEdit').prop('disabled', true);
    $('#btnAdd').prop('disabled', false);
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartments",
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
    pApartments = items;

    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>" +
                    "<thead id='header'>" +
                        "<tr class='info'>"
                           + " <th>Mã </th>"
                            + "<th>Tên </th>"
                            + "<th>Loại</th>"
                            + "<th>Kích thước </th>"
                            + "<th>Giá bán </th>"
                            + "<th>Giá thuê </th>"
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
        row += "<td class=''>" + items[i].idApartment + "</td>";
        row += "<td class=''>" + items[i].nameApartment + "</td>";
        row += "<td class=''>" + items[i].typeApartment + "</td>";
        row += "<td class=''>" + items[i].size + "</td>";
        row += "<td class=''>" + items[i].priceSale + "</td>";
        row += "<td class=''>" + items[i].priceRent + "</td>";      
        row += " <td class='a-right a-right '>" + items[i].statusApartment + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateUpdate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userUpdate + "</td>"
        row += " <td class=' last'><a onclick='loadData(" + items[i].idApartment + ")'><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a> |"
            + "<a onclick='del(" + items[i].idApartment + ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable').html(table);
}

//search 



function search() {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var find = $('#srch').val();
   
    $.ajax({
        type: "POST",
        url: "apartment.aspx/search",
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
    var table_div = document.getElementById('divtable');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'Apartments' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}
function validationApartment(idApartment, nameApartment, typeApartment, size, priceSale, priceRent, statusApartment) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var err = "<div class='form-group' id='listErr'";
    err += "<p>Các lỗi:</p>"
    var check = true;
    if ("" == nameApartment) {
        check = false;
        err += "<p style='color:red'>Nhập tên</p>";
    }
    if ("" == size) {
        check = false;
        err += "<p style='color:red'>Nhập kích thước</p>";
    }
    
    for (var i = 0; i < pApartments.length; i++) {
        if (pApartments[i].nameApartment == nameApartment && idApartment!=pApartments[i].idApartment) {
            check = false;
            err += "<p style='color:red'>Tên đã tồn tại</p>";
            break;
        }

    }


    if ("" == priceSale  || null == priceSale ) {
        check = false;
        err += "<p style='color:red'>Nhập giá bán</p>";
    }
    if ("" == priceRent  || null == priceRent ) {
        check = false;
        err += "<p style='color:red'>Nhập giá thuê</p>";
    }
    if ("" == statusApartment) {
        check = false;
        err += "<p style='color:red'>Chọn trạng thái</p>";
    }
    if ("" == typeApartment) {
        check = false;
        err += "<p style='color:red'>Chọn loại</p>";
    }
    if (check == false) {

        err += "</div>";
        $('#err').html(err);
    }
    return check;

}






function Test() {
    
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartment",
        data: JSON.stringify({ id: "11" }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
           
            return data.d;
        },
        error: function (result) {
            alert("Không thành công");
        }
    });
}