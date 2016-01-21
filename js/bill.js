// load lst<Price>, lst<Apartment>, lst<Bill>
var prices;
var apartments;
var bills;
var electrics;
var warters;
$(document).ready(function () {
    load();


});

function load() {
    loadData_bill();
    getApartments();
    getPriceApply();
    getElectrics();
    getWaters();
}

function loadData_bill() {
    // alert("idBill_EDIT : " + idBill);
    $.ajax({
        type: "POST",
        url: "bill.aspx/getBills",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getDatas_bill,
        error: function (result) {
            alert("Error load data");
        }
    });
}

function getDatas_bill(response) {
    if ($('#dataTables_cus').length != 0) {
        $('#dataTables_cus').remove();
    }

    var items = response.d;
    bills = items;
    //alert("size bill : " + items.length);
    var table = "<table class='table table-striped table-bordered table-hover' id='dataTables_cus' style='margin-top: -13px;'>" +
                    "<thead>" +
                        "<tr class='info'>"
                           + "<th>Mã</th>"
                            + "<th>Tên căn hộ </th>"
                            + "<th>Tiền phòng</th>"
                            + "<th>Tiền điện</th>"
                            + "<th>Tiền nước</th>"
                            + "<th>Tiền rác</th>"
                            + "<th>Tiền internet</th>"
                            + "<th>Tình trạng</th>"
                            + "<th>Ngày lập</th>"
                            + "<th>Thành tiền</th>"
                            + "<th class=' no-link last'><span class='nobr'>Thao tác</span>"
                            + "</th>"
                        + "</tr>"
                    + "</thead> <tbody>"

    for (var i = 0; i < items.length; i++) {
        var row = " <tr class='even pointer'>";
        row += "<td class=''>" + items[i].idBill + "</td>";
        row += "<td class=''>" + items[i].idApartment + "</td>";
        row += "<td class=''>" + items[i].totalApartment + "</td>";
        row += "<td class=''>" + items[i].totalElectric + "</td>";
        row += "<td class=''>" + items[i].totalWater + "</td>";
        row += "<td class=''>" + items[i].totalTrash + "</td>";
        row += "<td class=''>" + items[i].totalInternet + "</td>";
        row += "<td class=''>" + items[i].status + "</td>";
        row += "<td class=''>" + items[i].dateBill + "</td>";
        row += "<td class=''>" + items[i].total + "</td>";
        row += " <td class=' last'><a onclick='loadData_bill(" + items[i].idBill + ")'><i data-toggle='tooltip' title='Sửa' class='glyphicon glyphicon-edit'></i></a> |"
            + "<a onclick='del_bill(" + items[i].idBill + ")'><i data-toggle='tooltip' title='Xóa' class='glyphicon glyphicon-remove'></i></a></td>"
        row += "</tr>"
        table += row
    }
    table += "</tbody></table>"
    $('#divtable_bill').html(table);

    //--------load trash,internet
    //  var price = 
}
// load apartment

function getApartments() {
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartmentsExcept",
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            if ($('#idApartment').length != 0) {
                $('#idApartment').remove();
            }
            apartments = data.d;
            alert("apartments " + apartments.length);
            var st = " <div class='form-group'>"
                    + "<p>Căn hộ</p>"
                    + "<select class='form-control' style='margin-top: -10px;' id='idApartment' onblur='get_oldWater_oldElectric_trash_internet(this.value)' >";
            var row;
            for (var i = 0; i < apartments.length; i++) {
                row += "<option  value='" + apartments[i].idApartment + "'>" + apartments[i].nameApartment + "</option>";
            }
            row += "<option  selected='selected'>" + "</option>";
            st += row;
            st += "/select></div>"
            $('#getApartments').html(st);
        },
        error: function (result) {
            alert("Error");
        }
    });
}
// 
function getPriceApply() {
    // alert("idBill_EDIT : " + idBill);
    $.ajax({
        type: "POST",
        url: "bill.aspx/getPriceApply",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            prices = data.d;
        },
        error: function (result) {
            alert("Error load data");
        }
    });
}
// get electrics
function getElectrics() {
    // alert("idBill_EDIT : " + idBill);
    $.ajax({
        type: "POST",
        url: "bill.aspx/getElectrics",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            electrics = data.d;
        },
        error: function (result) {
            alert("Error load data");
        }
    });
}
// get electrics
function getWaters() {
    // alert("idBill_EDIT : " + idBill);
    $.ajax({
        type: "POST",
        url: "bill.aspx/getWaters",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            warters = data.d;
        },
        error: function (result) {
            alert("Error load data");
        }
    });
}






// 
function get_oldWater_oldElectric_trash_internet(idApartment) {
    alert("test");
    var bill;
    var apartment;
    for (var i = 0; i < apartments.length; i++) {
        if (apartments[i].idApartment == idApartment) {
            apartment = apartments[i];

        }
    }
    for (var i = 0; i < bills.length; i++) {
        if (bills[i].idApartment == idApartment) {
            bill = bills[i];

        }
    }


    if (null != bill) {
        var water;
        var electric;
        for (var i = 0; i < electrics.length; i++) {
            if (electrics[i].idBill == bill.idBill)
                electric = electrics[i];

        }
        for (var i = 0; i < warters.length; i++) {
            if (warters[i].idBill == bill.idBill)
                water = warters[i];
        }
        if (null != water && null != electric && null != apartment) {
            alert("test");
            $('#total_apartment').val(apartment.priceRent);
            $('#electric_old').val(electric.numberNew);
            $('#water_old').val(water.numberNew);
            $('#trash').val(prices.priceTrash);
            $('#internet').val(prices.priceInternet);
            $('#trash').prop('disabled', true);
            $('#electric_old').prop('disabled', true);
            $('#water_old').prop('disabled', true);
            $('#internet').prop('disabled', true);
            $('#total_apartment').prop('disabled', true);
        }
    } else {
        $('#total_apartment').val(apartment.priceRent);
        $('#electric_old').val('0');
        $('#water_old').val('0');
        $('#trash').val(prices.priceTrash);
        $('#internet').val(prices.priceInternet);
        $('#trash').prop('disabled', true);
        $('#electric_old').prop('disabled', true);
        $('#water_old').prop('disabled', true);
        $('#internet').prop('disabled', true);
        $('#total_apartment').prop('disabled', true);
    }


}

//caculate
function totalElectric() {
    alert("Dien");

    var electric_new = $('#electric_new').val();
    var electric_old = $('#electric_old').val();
    if ("" != electric_new && "" != electric_old) {
        var newNumber = parseFloat(electric_new);
        var oldNumber = parseFloat(electric_old);
        var total;
        if (newNumber >= oldNumber) {
            total = (newNumber - oldNumber) * prices.priceElectric;
            $('#total_electric').val(total);
            $('#total_electric').prop('disabled', true);
            totalPrice();
        }


    }


}


function totalWater() {
    alert("Nuoc");
    var water_new = $('#water_new').val();
    var water_old = $('#water_old').val();
    if ("" != water_new && "" != water_old) {
        var newNumber = parseFloat(water_new);
        var oldNumber = parseFloat(water_old);
        var total;
        if (newNumber >= oldNumber) {
            total = (newNumber - oldNumber) * prices.priceWater;
            $('#total_water').val(total);
            $('#total_water').prop('disabled', true);
            totalPrice();
        }


    }

}





function totalPrice() {

    var totalWater = $('#total_water').val();
    var totalElectric = $('#total_electric').val();
    var totalApartment = $('#total_apartment').val();
    var totalTrash = $('#trash').val();
    var totalInternet = $('#internet').val();
    var total;
    if ("" != totalWater && "" != totalElectric) {
        total = parseFloat(totalWater) + parseFloat(totalElectric) + parseFloat(totalApartment) + parseFloat(totalTrash) + parseFloat(totalInternet);
        $('#total').val(total);
        $('#total').prop('disabled', true);
    }
}

//add

function add_Bill() {
    var idApartment = $('#idApartment').val();
    var water_new = $('#water_new').val();
    var water_old = $('#water_old').val();
    var electric_new = $('#electric_new').val();
    var electric_old = $('#electric_old').val();
    var totalWater = $('#total_water').val();
    var totalElectric = $('#total_electric').val();
    var totalApartment = $('#total_apartment').val();
    var totalTrash = $('#trash').val();
    var totalInternet = $('#internet').val();
    var total = $('#total').val();
    var dateBill = $('#dateBill').val();

    alert("DIEN:  " + electric_new + "; " + electric_old);
    $.ajax({
        type: "POST",
        url: "bill.aspx/add",
        data: JSON.stringify({ idApartment: idApartment, water_new: water_new, water_old: water_old, electric_new: electric_new, electric_old: electric_old, totalWater: totalWater, totalElectric: totalElectric, totalApartment: totalApartment, totalTrash: totalTrash, totalInternet: totalInternet, total: total, dateBill: dateBill, idPrice: prices.idPrice }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            loadData_bill();
            clear();
            alert("Them thanh cong");
        },
        error: function (result) {
            alert("Error add");
        }

    });
}

function clear() {
    $('#total_apartment').val('');
    $('#electric_old').val('');
    $('#water_old').val('');
    $('#trash').val('');
    $('#internet').val('');
    $('#trash').prop('disabled', false);
    $('#electric_old').prop('disabled', false);
    $('#water_old').prop('disabled', false);
    $('#internet').prop('disabled', false);
    $('#total_apartment').prop('disabled', false);
    $('#total').val('');
    $('#total').prop('disabled', false);
    $('#total_water').val('');
    $('#total_water').prop('disabled', false);
    $('#total_electric').val('');
    $('#total_electric').prop('disabled', false);
    $('#electric_new').val('');
    $('#water_new').val('');
}