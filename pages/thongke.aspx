<%@ Page Language="C#" AutoEventWireup="true" CodeFile="thongke.aspx.cs" Inherits="pages_thongke" MasterPageFile="~/masterPage/HomePage.master"%>

<%@ Import Namespace="Manager.Models" %>
<asp:Content ContentPlaceHolderID="CPH1" runat="server">
     <script src="../js/thongke.js"></script>
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Thống kê</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px;" onclick="thongke()">Thống kê</button>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 140px" onclick="exportFile()">In</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
         <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Thống kê theo</p>
                   <input min="2010-01-01"
                        type="date" id="date_start" value=""
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày tạo"/>
                </div>
            </div>
         <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá trị</p>
                    <input min="2010-01-01"
                        type="date" id="date_end" value=""
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày tạo"/>
                </div>
            </div>
        </div>
     <div class="row" id="divtk">
     </div>
    <%-- <div class="row">
         <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tổng doanh thu của tháng :</p>
                    <p>Tổng doanh thu từ việc thuê căn hộ trong tháng:</p>
                    <p>Tổng doanh thu từ việc bán căn hộ trong tháng :</p>
                    <p>Tổng số căn hộ được thuê :</p>
                    <p>Tổng số căn hộ được bán :</p>
                    <p>Tổng số căn hộ trống :</p>
                </div>
            </div>
        </div>
     <div class="row">
         <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tổng doanh thu của năm :</p>
                    <p>Tổng doanh thu từ việc thuê căn hộ trong năm:</p>
                    <p>Tổng doanh thu từ việc bán căn hộ trong năm :</p>
                </div>
            </div>
        </div>--%>
    <div class="row">
        <br />
        <!--footer -->
        <hr />
        <address class="text-center">
            <strong>Tên Công Ty</strong><br />
            Linh Trung
                   
               

            <br />
            Quận Thủ Đức
                   
               

            <br />
            Phone : 097800000
               
           
        </address>
        <address class="text-center">
            <strong>Phạm Thị Ngọc Thư</strong><br />
            <a href="#">thu225656294@gmail.com</a>
        </address>

        <!--/. footer  -->

    </div>

  
</asp:Content>

