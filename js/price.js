function loadData(idPrice) {
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnedit').prop('disabled', false);
    $('#btnadd').prop('disabled', true);
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

    var status;
    if (item.status == "Đang hoạt động") {
        if ($('#active').length != 0) {
            $('#active').remove();
            status = "<option id='active' selected='selected'>Đang hoạt động</option>";
            status += " <option  id='noActive'>Không hoạt động</option>";
        }

    } else {
        if ($('#unactive').length != 0) {
            $('#unactive').remove();
            status = "<option id='active' >Đang hoạt động</option>";
            status += " <option  id='unactive' selected='selected'>Không hoạt động</option>";
        }
    }
    $('#text_status').html(status);



}
//edit 
function edit() {
    var idPrice = $('#text_idPrice').val();
    var priceElectric = $('#text_priceElectric').val();
    var priceWater = $('#text_priceWater').val();
    var priceInternet = $('#text_priceInternet').val();
    var priceTrash = $('#text_priceTrash').val();
    var status = $('#text_status').val();
    var check = validationPrice(priceElectric, priceWater, priceInternet, priceTrash, status);
    if (check == true) {
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
}
// them price



function add() {

    var priceElectric = $('#text_priceElectric').val();
    var priceWater = $('#text_priceWater').val();
    var priceInternet = $('#text_priceInternet').val();
    var priceTrash = $('#text_priceTrash').val();
    var status = $('#text_status').val();
    var check = validationPrice(priceElectric, priceWater, priceInternet, priceTrash, status);
    if (check == true) {
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
}
//refesh data
function clearPrice() {
    clear();

}

//reset input
function clear() {
    $('#text_idPrice').val('');
    $('#text_priceElectric').val('');
    $('#text_priceWater').val('');
    $('#text_priceInternet').val('');
    $('#text_priceTrash').val('');
   // $('#text_status').val('');
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnedit').prop('disabled', true);
    $('#btnadd').prop('disabled', false);

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
    if ($('#listErr').length != 0)
        $('#listErr').remove();
    $('#btnedit').prop('disabled', true);
    $('#btnadd').prop('disabled', false);
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
    if ($('#listErr').length != 0)
        $('#listErr').remove();
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
    if ($('#listErr').length != 0)
        $('#listErr').remove();
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

function validationPrice(priceElectric, priceWater, priceInternet, priceTrash, status) {

    if ($('#listErr').length != 0)
        $('#listErr').remove();
    var err = "<div class='form-group' id='listErr'";
    err += "<p>Các lỗi:</p>"
    var check = true;
    
    if ("" == priceElectric  || null == priceElectric ) {
        check = false;
        err += "<p style='color:red'>Nhập giá tiền điện</p>";
    }
    if ("" == priceWater  || null == priceWater ) {
        check = false;
        err += "<p style='color:red'>Nhập giá tiền nước</p>";
    }
    if ("" == priceInternet || null == priceInternet ) {
        check = false;
        err += "<p style='color:red'>Nhập giá tiền internet</p>";
    }
    if ("" == priceTrash || null == priceTrash ) {
        check = false;
        err += "<p style='color:red'>Nhập giá tiền rác</p>";
    }
    if ("" == status) {
        check = false;
        err += "<p style='color:red'>Chọn trạng thái</p>";
    }

    if (check == false) {

        err += "</div>";
        $('#err').html(err);
    }
    return check;


}