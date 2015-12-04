<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example of jQuery AJAX Callback using Asp.net C#</title>
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
  
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>First Name :</td>
                    <td>
                        <input type="text" id="txtFirstName" />
                    </td>
                </tr>
                <tr>
                    <td>Last Name :</td>
                    <td>
                        <input type="text" id="txtLastName" />
                    </td>
                </tr>
                <tr>
                    <td>City :</td>
                    <td>
                          <input type="text" id="txtCity" />
                    </td>
                </tr>
                <tr>
                    <td>EmailID :</td>
                    <td>
                          <input type="text" id="txtEmailID" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="button" id="btnSubmit" value="Submit" />
                        <label id="lblmsg" style="color:green" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="gvData" AutoGenerateColumns="true" runat="server"></asp:GridView>
        </div>
    </form>
      <script type="text/javascript">
          $(function () {
              $('#btnSubmit').click(function () {
                  $.ajax({
                      type: "POST",
                      contentType: "application/json; charset=utf-8",
                      url: "Default.aspx/InsertData",
                      dataType: "json",
                      data: "{'FirstName':'" + $('#txtFirstName').val() + "','LastName':'" + $('#txtLastName').val() + "','City':'" + $('#txtCity').val() + "','EmailID':'" + $('#txtEmailID').val() + "'}",
                      success: function (data) {
                          var obj = data.d;
                          alert(data.d);
                          if (obj == 'true') {
                              $('#txtFirstName').val('');
                              $('#txtLastName').val('');
                              $('#txtCity').val('');
                              $('#txtEmailID').val('');
                              $('#lblmsg').html('Data Inserted Successfully');
                          }
                      },
                      error: function (result) {
                          alert(result);
                      }
                  });
              });
          });
    </script>
</body>
</html>
