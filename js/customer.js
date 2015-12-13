var apartments;
// get apartments
function getApartments() {
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartments",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if ($('#idApartment').length != 0) {
                $('#idApartment').remove();
            }
            apartments = data.d;

            var st = " <div class='form-group'>"
                    + "<p>Căn hộ</p>"
                    + "<select class='form-control' style='margin-top: -10px;' id='idApartment'>";
            var row;
            for (var i = 0; i < apartments.length; i++) {
                row += "<option value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
            }
            st += row;
            st += "/select></div>"
            $('#getApartments').html(st);

        },
        error: function (result) {
            alert("Error");
        }
    });
}



$(document).ready(function () {

    bindData();
    getApartments();
});



// load table

function bindData() {
    alert("bind");
    $.ajax({
        type: "POST",
        url: "customers.aspx/getCustomers",
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
                    "<thead id='header'>" +
                        "<tr class='info'>"
                           + " <th>Mã</th>"
                            + "<th>Tên</th>"
                            + "<th>Ngày sinh</th>"
                            + "<th>Giới tính </th>"
                            + "<th>Quê quán</th>"
                            + "<th>CMND</th>"
                            + "<th>Email</th>"
                            + "<th>SDT</th>"
                            + "<th>Căn hộ</th>"
                             + "<th>Quyền </th>"
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
        row += "<td class=''>" + items[i].idCustomer + "</td>";
        row += "<td class=''>" + items[i].nameCustomer + "</td>";
        row += "<td class=''>" + items[i].birthday + "</td>";
        row += "<td class=''>" + items[i].sex + "</td>";
        row += "<td class=''>" + items[i].addressCustomer + "</td>";
        row += "<td class=''>" + items[i].identifiCardCustomer + "</td>";
        row += "<td class=''>" + items[i].email + "</td>";
        row += " <td class='a-right a-right '>" + items[i].sdt + "</td>"

        row += " <td class='a-right a-right '>" + items[i].idApartment + "</td>"
        row += " <td class='a-right a-right '>" + items[i].holder + "</td>"
        row += " <td class='a-right a-right '>" + items[i].status + "</td>"

        row += " <td class='a-right a-right '>" + items[i].dateCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userCreate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].dateUpdate + "</td>"
        row += " <td class='a-right a-right '>" + items[i].userUpdate + "</td>"
        row += " <td class=' last'><a onclick='loadCustomer(" + items[i].idCustomer + ")'><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a> |"
            + "<a onclick='del(" + items[i].idCustomer + ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable').html(table);
}
// add


function add() {
    var name = $('#txtName').val();
    var address = $('#txtAddress').val();
    var identifiCard = $('#txt_identifiCard').val();
    var sex = $('#sex').val();
    var idApartment = $('#idApartment').val();
    var birthday = $('#txtBirthday').val() + "";
    var holder = $('#holder').val();
    var email = $('#txtEmail').val();
    var phone = $('#txtPhone').val();
    var status = $('#status').val();

    alert("idApartment  " + idApartment);
    alert("name:" + name + " address:" + address + " address:" + identifiCard + " address:" + sex + " address:" + idApartment, "address:" + birthday + " address:" + holder + " address:" + email + " address:" + phone + " address:" + status);
    $.ajax({
        type: "POST",
        url: "customers.aspx/add",
        data: JSON.stringify({ name: name, address: address, identifiCard: identifiCard, sex: sex, idApartment: idApartment, birthday: birthday, holder: holder, email: email, phone: phone, status: status }),
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

//clear 
function clear() {

    $('#txtName').val('');
    $('#txtAddress').val('');
    $('#txt_identifiCard').val('');
    $('#sex').val('');
    $('#idApartment').val('');
    $('#txtBirthday').val('');
    $('#holder').val('');
    $('#txtEmail').val('');
    $('#txtPhone').val('');
    $('#status').val('');

}
//Edit
function loadCustomer(idCustomer) {

    $.ajax({
        type: "POST",
        url: "customers.aspx/getCustomer",
        data: JSON.stringify({ idCustomer: idCustomer }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getData,
        error: function (result) {
            alert("Error");
        }
    });


}

function getData(data) {
    var customer = data.d;
    alert("customer: " + customer.idCustomer);

    $('#txtName').val(customer.nameCustomer);
    $('#txtAddress').val(customer.addressCustomer);
    $('#txt_identifiCard').val(customer.identifiCardCustomer);
    $('#sex').val(customer.sex);
    // $('#idApartment').val(customer.);
    $('#txtBirthday').val(customer.birthday);
    $('#holder').val(customer.holder);
    $('#txtEmail').val(customer.email);
    $('#txtPhone').val(customer.sdt);
    $('#status').val(customer.status);



    if ($('#idApartment').length != 0) {
        $('#idApartment').remove();
    }
    alert("apartment: " + apartments.length);
    var st = " <div class='form-group'>"
            + "<p>Căn hộ</p>"
            + "<select class='form-control' style='margin-top: -10px;' id='idApartment'>";
    var row;
    for (var i = 0; i < apartments.length; i++) {
        if (apartments[i].idApartment == customer.idApartment) {
            row += "<option  selected='selected' value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
        } else {

            row += "<option value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
        }
    }
    st += row;
    st += "/select></div>"
    $('#getApartments').html(st);


}



