/**
load table users
**/
$(document).ready(function () {




});

// load table 
function bindData() {

    $.ajax({
        url: 'user.aspx/getUsers',
        type: 'POST',
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        data: {},
        success: loadTable,
        error: alert('error')
    });
}

function loadTable(data) {
    var items = data.d;
    if (items != null) {
        var table = "<table class='table table-striped table-bordered table-hover' id='dataTables-example' style='margin-top: -13px;'>"
                    + "<thead>"
                        + "<tr class='info'>"
                            + "<th>Tên tài khoản</th>"
                            + "<th>Tên căn hộ</th>"
                            + "<th>Tên nhân viên</th>"
                            + "<th>Ngày tạo</th>"
                            + "<th>Người tạo</th>"
                            + "<th>Ngày sửa</th>"
                            + "<th>Người sửa</th>"
                            + "<th class=' no-link last'><span class='nobr'>Thao tác</span>"
                            + "</th></tr></thead><tbody>";

        for (var i = 0; i < items.length; i++) {
            var row = " <tr class='even pointer'>";
            row += " <td class=''>" + items[i].username + "</td>";
            row += "<td class=''>"+"</td>";
            row += " <td class=' last'><a ><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a>|" 
            +"<a ><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>";      
            row += "</tr>";
        }





    }



}



