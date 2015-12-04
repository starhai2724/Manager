function loadData(name) {
    alert("name" + name);
    $.ajax({
        type: "POST",
        url: "apartment.aspx/testJson",
        data: JSON.stringify({ id: name }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        error: function (result) {
            alert("Error");
        }
    });
}

function OnSuccess(response) {
	//---thuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu---//
    var item = response.d;
    alert(item.priceSale);
    $('#text_idApartment').val(item.idApartment);
    $('#text_nameApartment').val(item.nameApartment);
    $('#text_priceSale').val(item.priceSale);
    $('#text_size').val(item.size);
    $('#text_priceRent').val(item.priceRent);

}
//edit 
function edit() {
    var idApartment = $('#text_idApartment').val();
    var nameApartment = $('#text_nameApartment').val();
    var typeApartment = $('#type').val();
    var size = $('#text_size').val();
    var priceSale = $('#text_priceSale').val();
    var priceRent = $('#text_priceRent').val();
    var statusApartment = $('#status').val();

    $.ajax({
        type: "POST",
        url: "apartment.aspx/editApartment",
        data: JSON.stringify({ id: idApartment, name: nameApartment, type: typeApartment, size: size, priceS: priceSale, priceR: priceRent, status: statusApartment }),
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
// them can ho



function add() {

    var nameApartment = $('#text_nameApartment').val();
    var typeApartment = $('#type').val();
    var size = $('#text_size').val();
    var priceSale = $('#text_priceSale').val();
    var priceRent = $('#text_priceRent').val();
    var statusApartment = $('#status').val();
    $.ajax({
        type: "POST",
        url: "apartment.aspx/add",
        data: JSON.stringify({ name: nameApartment, type: typeApartment, size: size, priceS: priceSale, priceR: priceRent, status: statusApartment }),
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
    $('#text_idApartment').val('');
    $('#text_nameApartment').val('');
    $('#type').val('');
    $('#text_size').val('');
    $('#text_priceSale').val('');
    $('#text_priceRent').val('');
    $('#status').val('');

}
//delete 

function del(idDelete) {
    var msg = confirm("Ban co chac chan muon xoa!")
    if (msg == true) {
        $.ajax({
            type: "POST",
            url: "apartment.aspx/delete",
            data: JSON.stringify({ id: idDelete }),
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
        url: "apartment.aspx/getApartments",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Error");
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
                           + " <th>Mã </th>"
                            + "<th>Tên </th>"
                            + "<th>Loại</th>"
                            + "<th>Kích thước </th>"
                            + "<th>Giá bán </th>"
                            + "<th>Giá thuê </th>"
                            + "<th>Tầng </th>"
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


