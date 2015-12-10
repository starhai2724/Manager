<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/masterPage/HomePage.master" %>





<asp:content contentplaceholderid="CPH1" runat="server">
   // <script src="../js/apartment.js"></script>
    <script src="../js/test.js"></script>
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
                        <input type="button" id="btnSubmit"  value="Submit" />
                        <button type="button" onclick="foo()">TEST</button>
                        <label id="lblmsg" style="color:green" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="gvData" AutoGenerateColumns="true" runat="server"></asp:GridView>
        </div>
    
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

        </asp:content>

