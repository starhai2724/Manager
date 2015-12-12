
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

function sendMail() {
    var link = "mailto:hai2724@gmail.com"
             + "?cc=hai272404237@gmail.com"
             + "&subject=" + escape("This is my subject")
             + "&body=" + escape("NGuyen Trung Hai")
    ;

    window.location.href = link;
}
function a() {

    var recipient = 'hai2724@gmail.com',
         subject = 'Hi',
         message = 'Write the body of your message here';

    location.href = 'http://mail.google.com/mail/?view=cm&fs=1' +
                    '&to=' + recipient +
                    '&su=' + subject +
                    '&body=' + message +

                      '&ui=1';
}