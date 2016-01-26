<%@ Page Language="C#" AutoEventWireup="true" CodeFile="price.aspx.cs" Inherits="pages_price" MasterPageFile="~/masterPage/HomePage.master" %>

<%@ Import Namespace="Manager.Models" %>
<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="../js/price.js"></script>
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Giá</h3>
           <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px" onclick="clearPrice()">Làm lại</button>
             <button id="btnadd" type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 150px" onclick="add()">Thêm</button>
            <button id="btnedit" type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 85px"" onclick="edit()">Lưu</button>
            <button  type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 225px" onclick="exportFile()">In</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- add apartment -->
    <div class="row">
         <div class="row">

            <div class="col col-sm-4 col-md-4 col-lg-4" id="err">
            </div>


        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Mã giá</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="text_idPrice" placeholder="" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá điện/ký</p>
                    <input type="text" class="form-control" style="margin-top: -10px; TEXT-ALIGN: right;" id="text_priceElectric" placeholder="0VND" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá nước/m3</p>
                    <input type="text" class="form-control" style="margin-top: -10px; TEXT-ALIGN: right;" id="text_priceWater" placeholder="0VND" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá internet/tháng</p>
                    <input type="text" class="form-control" style="margin-top: -10px; TEXT-ALIGN: right;" id="text_priceInternet" placeholder="0VND" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giá rác/tháng</p>
                    <input type="text" class="form-control" style="margin-top: -10px; TEXT-ALIGN: right;" id="text_priceTrash" placeholder="0VND" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tình trạng</p>
                    <select class="form-control" style="margin-top: -10px;" id="text_status">
                        <option id="active">Đang hoạt động</option>
                        <option id="unactive">Không hoạt động</option>
                    </select>
                </div>
            </div>
        </div>


    </div>


    <div class="row">
        <div class="x_panel">
            <div class="x_content" style="margin-top: -20px;">
                <div class="row">
                    <div class="col col-sm-3 col-md-3 col-lg-3 pull-right">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Tìm kiếm" name="srch-term" id="srch" />
                            <div class="input-group-btn">
                                <button class="btn btn-primary" type="button" onclick="search()" id="btn_search"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <br />

                <div class="row" id="divtable_price">
                </div>
            </div>
        </div>


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

    <script>
        $('#text_priceElectric').priceFormat({
            prefix: '',
            suffix: ' VND',
        });
        $('#text_priceWater').priceFormat({
            prefix: '',
            suffix: ' VND',
        });
        $('#text_priceInternet').priceFormat({
            prefix: '',
            suffix: ' VND',
        });
        $('#text_priceTrash').priceFormat({
            prefix: '',
            suffix: ' VND',
        });


    </script>
</asp:Content>
