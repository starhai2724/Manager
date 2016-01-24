


function xem() {
    var id_Cus = $('#id_Cus').val();
    var date_start = $('#date_start').val();
    var date_end = $('#date_end').val();
    var arrs = date_start.split('-');
    var start = arrs[2] + "/" + arrs[1] + "/" + arrs[0];
    var arre = date_end.split('-');
    var end = arre[2] + "/" + arre[1] + "/" + arre[0];
     alert("date_start : " + start + ",date_end :" + end + "ID " + id_Cus);
    $.ajax({
        type: "POST",
        url: "infoApartment.aspx/getInfomation_apartment",
        data: JSON.stringify({ id_Cus: id_Cus, date_start: start, date_end: end }),
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
        url: "infoApartment.aspx/tk",
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
                            + "<th>Tiền phòng</th>"
                            + "<th>Tiền điện</th>"
                            + "<th>Tiền nước</th>"
                            + "<th>Tiền rác</th>"
                            + "<th>Tiền internet</th>"
                            + "<th>Tình trạng</th>"
                            + "<th>Ngày lập</th>"
                            + "<th>Thành tiền</th>"
                            + "</th>"
                        + "</tr>"
                    + "</thead> <tbody>"

    for (var i = 0; i < items.length; i++) {
        var row = " <tr class='even pointer'>";
        row += "<td class=''>" + items[i].totalApartment + "</td>";
        row += "<td class=''>" + items[i].totalElectric + "</td>";
        row += "<td class=''>" + items[i].totalWater + "</td>";
        row += "<td class=''>" + items[i].totalTrash + "</td>";
        row += "<td class=''>" + items[i].totalInternet + "</td>";
        row += "<td class=''>" + items[i].status + "</td>";
        row += "<td class=''>" + items[i].dateBill + "</td>";
        row += "<td class=''>" + items[i].total + "</td>";
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable_bill').html(table);
}


// xuat file excel

function exportFile() {

    var a = document.createElement('a');
    //getting data from our div that contains the HTML table
    var data_type = 'data:application/vnd.ms-excel';
    var table_div = document.getElementById('divtk');
    var table_html = table_div.outerHTML.replace(/ /g, '%20');
    a.href = data_type + ', ' + table_html;
    //setting the file name
    a.download = 'Hóa đơn' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}
