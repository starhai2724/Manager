


function thongke() {
    var date_start = $('#date_start').val();
    var date_end = $('#date_end').val();
    var arrs = date_start.split('-');
    var start = arrs[2] + "/" + arrs[1] + "/" + arrs[0];
    var arre = date_end.split('-');
    var end = arre[2] + "/" + arre[1] + "/" + arre[0];
    // alert("date_start : " + start + ",date_end :" + end);
    $.ajax({
        type: "POST",
        url: "thongke.aspx/thongKe_Bill",
        data: JSON.stringify({ a: start, b: end }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Error1");
        }

    });
}

// load table

function bindData() {
    $.ajax({
        type: "POST",
        url: "thongke.aspx/thongKe_Bill",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas,
        error: function (result) {
            alert("Error2");
        }
    });
}
//OnSuccess
function getDatas(response) {
    var items = response.d;
    bills = items;
    alert("size bill : " + items.length);
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables_cus' style='margin-top: -13px;margin-left :20px'>" +
                    "<thead>" +
                        "<tr class='info'>"
                            + "<th>Mã căn hộ</th>"
                            + "<th>Tiền phòng</th>"
                            + "<th>Tiền điện</th>"
                            + "<th>Tiền nước</th>"
                            + "<th>Tiền rác</th>"
                            + "<th>Tiền internet</th>"
                            + "<th>Thành tiền</th>"
                             + "<th>Ngày lập</th>"
                             + "<th>Tình trạng</th>"
                            + "</th>"
                        + "</tr>"
                    + "</thead> <tbody>"
    var total_apartment = 0;
    var total_electric = 0;
    var total_water = 0;
    var total_internet = 0;
    var total_trash = 0;
    var total = 0;
    for (var i = 0; i < items.length; i++) { // đã thanh toán
        if (items[i].status == "Đã thanh toán") {
           // alert("da thanh toan");
            var row = " <tr class='even pointer'>";
            row += "<td class=''>" + items[i].idApartment + "</td>";
            row += "<td class=''>" + items[i].totalApartment + "</td>";
            row += "<td class=''>" + items[i].totalElectric + "</td>";
            row += "<td class=''>" + items[i].totalWater + "</td>";
            row += "<td class=''>" + items[i].totalTrash + "</td>";
            row += "<td class=''>" + items[i].totalInternet + "</td>";
            row += "<td class=''>" + items[i].total + "</td>";
            row += "<td class=''>" + items[i].dateBill + "</td>";
            row += "<td class=''>" + items[i].status + "</td>";
            row += "</tr>"
            table += row
            total_apartment += items[i].totalApartment;
            total_electric += items[i].totalElectric;
            total_water += items[i].totalWater;
            total_internet += items[i].totalInternet;
            total_trash += items[i].totalTrash;
            total += items[i].total;
        }
    }
    var row = " <div class='col col-sm-8 col-md-8 col-lg-8'>" +
              "<div class='form-group'>" +
              "<h5>Tổng tiền phòng : " + total_apartment + " </h5>" +
               "<h5>Tổng tiên nước : " + total_water + " </h5>" +
                "<h5>Tổng tiền điện : " + total_electric + " </h5>" +
                 "<h5>Tổng tiền rác : " + total_trash + " </h5>" +
                  "<h5>Tổng tiền internet : " + total_internet + " </h5>" +
                  "<h4> TỔNG TIỀN TỪ NHỮNG HÓA ĐƠN ĐÃ THANH TOÁN : " + total + " </h4>" +
                "</div> </div>";
    table += row

    //------------------chưa thanh toán---------------------------
    table += "<table class='table table-striped table-bordered table-hover' id='dataTables_cus' style='margin-top: -13px;margin-left :20px'>" +
                    "<thead>" +
                        "<tr class='info'>"
                            + "<th>Mã căn hộ</th>"
                            + "<th>Tiền phòng</th>"
                            + "<th>Tiền điện</th>"
                            + "<th>Tiền nước</th>"
                            + "<th>Tiền rác</th>"
                            + "<th>Tiền internet</th>"
                            + "<th>Thành tiền</th>"
                             + "<th>Ngày lập</th>"
                             + "<th>Tình trạng</th>"
                            + "</th>"
                        + "</tr>"
                    + "</thead> <tbody>"
     total_apartment = 0;
     total_electric = 0;
     total_water = 0;
     total_internet = 0;
     total_trash = 0;
     total = 0;
    for (var i = 0; i < items.length; i++) { // đã thanh toán
        if (items[i].status == "Chưa thanh toán") {
            //alert("da thanh toan");
            var row = " <tr class='even pointer'>";
            row += "<td class=''>" + items[i].idApartment + "</td>";
            row += "<td class=''>" + items[i].totalApartment + "</td>";
            row += "<td class=''>" + items[i].totalElectric + "</td>";
            row += "<td class=''>" + items[i].totalWater + "</td>";
            row += "<td class=''>" + items[i].totalTrash + "</td>";
            row += "<td class=''>" + items[i].totalInternet + "</td>";
            row += "<td class=''>" + items[i].total + "</td>";
            row += "<td class=''>" + items[i].dateBill + "</td>";
            row += "<td class=''>" + items[i].status + "</td>";
            row += "</tr>"
            table += row
            total_apartment += items[i].totalApartment;
            total_electric += items[i].totalElectric;
            total_water += items[i].totalWater;
            total_internet += items[i].totalInternet;
            total_trash += items[i].totalTrash;
            total += items[i].total;
        }
    }
    var row1 = " <div class='col col-sm-8 col-md-8 col-lg-8'>" +
              "<div class='form-group'>" +
              "<h5>Tổng tiền phòng : " + total_apartment + " </h5>" +
               "<h5>Tổng tiên nước : " + total_water + " </h5>" +
                "<h5>Tổng tiền điện : " + total_electric + " </h5>" +
                 "<h5>Tổng tiền rác : " + total_trash + " </h5>" +
                  "<h5>Tổng tiền internet : " + total_internet + " </h5>" +
                  "<h4> TỔNG TIỀN TỪ NHỮNG HÓA ĐƠN CHƯA THANH TOÁN: " + total + " </h4>" +
                "</div> </div>";
    table += row1;






    table += "</tbody></table>"
    $('#divtable_bill').html(table);
}


// xuat file excel

function exportFileThongKe() {

    var a = document.createElement('a');
    //getting data from our div that contains the HTML table
    var data_type = 'data:application/vnd.ms-excel';
    var table_div = document.getElementById('divtable_bill');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'Thongke' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}
