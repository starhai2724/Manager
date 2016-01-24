


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
        url: "thongke.aspx/tk",
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
        url: "thongke.aspx/tk",
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
   // alert("haha");
    var items = response.d;
    var date_start = $('#date_start').val();
    var date_end = $('#date_end').val();
    var arrs = date_start.split('-');
    var start = arrs[2] + "/" + arrs[1] + "/" + arrs[0];
    var arre = date_end.split('-');
    var end = arre[2] + "/" + arre[1] + "/" + arre[0];

    var value = items.split(' ');
   // alert("items[0]" + items[0]);
    var table = " <div class='col col-sm-8 col-md-8 col-lg-8'>" +
              "<div class='form-group'>" +
              "<h4>Tổng doanh thu từ ngày " + start + " đến ngày " + end + ": " + value[0] + " </h4>" +
               "<h4>Tổng doanh thu từ việc thuê căn hộ từ ngày " + start + " đến ngày " + end + ": " + value[1] + " </h4>" +
                "<h4>Tổng doanh thu từ việc bán căn hộ từ ngày " + start + " đến ngày " + end + ": " + value[2] + " </h4>" +
                 "<h4>Tổng tiền điện từ ngày " + start + " đến ngày " + end + ": " + value[3] + " </h4>" +
                  "<h4>Tổng tiền nước từ ngày " + start + " đến ngày " + end + ": " + value[4] + " </h4>" +
                  "<h4>Tổng tiền rác từ ngày " + start + " đến ngày " + end + ": " + value[5] + " </h4>" +
                   "<h4>Tổng tiền internet từ ngày " + start + " đến ngày " + end + ": " + value[6] + " </h4>" +
                "</div> </div>"
    $('#divtk').html(table);


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
    a.download = 'Thongke' + '.xls';
    //triggering the function
    a.click();
    //just in case, prevent default behaviour

}
