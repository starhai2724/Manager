function loadData(idPrice) {
    alert("idEmployee" + idPrice);
    $.ajax({
        type: "POST",
        url: "price.aspx/getPrice",
        data: JSON.stringify({ id: idPrice }),
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
    $('#text_idPrice').val(item.idPrice);
    $('#text_priceElectric').val(item.priceElectric);
    $('#text_priceWater').val(item.priceWater);
    $('#text_priceInternet').val(item.priceInternet);
    $('#text_priceTrash').val(item.priceTrash);

}
//edit 
function edit() {
    var idPrice = $('#text_idPrice').val();
    var priceElectric = $('#text_priceElectric').val();
    var priceWater = $('#text_priceWater').val();
    var priceInternet = $('#text_priceInternet').val();
    var priceTrash = $('#text_priceTrash').val();
    var status = $('#text_status').val();

    $.ajax({
        type: "POST",
        url: "price.aspx/editPrice",
        data: JSON.stringify({ idPrice: idPrice, priceElectric: priceElectric, priceWater: priceWater, priceInternet: priceInternet, priceTrash: priceTrash, status: status }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            bindData();
            clear();
            alert("Sua thanh cong");
        },
        error: function (result) {
            alert("Error edit");
        }

    });
}
// them price



function add() {

    var priceElectric = $('#text_priceElectric').val();
    var priceWater = $('#text_priceWater').val();
    var priceInternet = $('#text_priceInternet').val();
    var priceTrash = $('#text_priceTrash').val();
    var status = $('#text_status').val();
    $.ajax({
        type: "POST",
        url: "price.aspx/add",
        data: JSON.stringify({ priceElectric: priceElectric, priceWater: priceWater, priceInternet: priceInternet, priceTrash: priceTrash, status: status }),
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
    $('#text_idPrice').val('');
    $('#text_priceElectric').val('');
    $('#text_priceWater').val('');
    $('#text_priceInternet').val('');
    $('#text_priceTrash').val('');
    $('#text_status').val('');

}
//delete 

function del(idPrice) {
    var msg = confirm("Ban co chac chan muon xoa!")
    if (msg == true) {
        $.ajax({
            type: "POST",
            url: "price.aspx/delete_byId",
            data: JSON.stringify({ idPrice: idPrice }),
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
    //alert("bind data");
    $.ajax({
        type: "POST",
        url: "price.aspx/getPrices",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Error bindData");
        }
    });
}
//OnSuccess
function getDatas(response) {
    if ($('#dataTables-price').length != 0) {
        $('#dataTables-price').remove();
    }
    var items = response.d;
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-price' style='margin-top: -13px;'>" +
                    "<thead>" +
                        "<tr class='info'>"
                            +" <th>Mã giá </th>"
                            +"  <th>Giá điện</th>"
                            +"  <th>Giá nước</th>"
                            +"<th>Giá internet</th>"
                            +"<th>Giá rác</th>"
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
        row += "<td class=''>" + items[i].idPrice + "</td>";
        row += "<td class=''>" + items[i].priceElectric + "</td>";
        row += "<td class=''>" + items[i].priceWater + "</td>";
        row += "<td class=''>" + items[i].priceInternet + "</td>";
        row += "<td class=''>" + items[i].priceTrash + "</td>";
        row += " <td class='a-right a-right '>" + items[i].status + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateUpdate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userUpdate + "</td>"
        row += " <td class=' last'><a onclick='loadData(" + items[i].idPrice + ")'><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a> |"
          + "<a onclick='del(" + items[i].idPrice + ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable_price').html(table);
}


//search 



function search() {
    var find = $('#srch').val();
    alert("search  " + find);
    $.ajax({
        type: "POST",
        url: "price.aspx/search",
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
    var table_div = document.getElementById('divtable_price');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'Prices' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}