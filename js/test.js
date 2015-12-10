
function abc() {
    var a = Test();

    alert("abs  " + a);
   
}


function Test() {
    alert("a1");
    $.ajax({
        type: "POST",
        url: "apartment.aspx/getApartment",
        data: JSON.stringify({ id: "11" }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            alert("a2");
            return data.d;
        },
        error: function (result) {
            alert("Error");
        }
    });
}
function foo() {
    var result;
    $.post("apartment.aspx/getApartment", {id:"11"}, function (data) {
        result = data.d;
        alert("result  " + data.d);
    });
    return result;
}
