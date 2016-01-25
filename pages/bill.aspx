<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bill.aspx.cs" Inherits="pages_bill" MasterPageFile="~/masterPage/HomePage.master" %>
<%@ Import Namespace="Manager.Models" %>
<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="../js/apartment.js"></script>
    <script src="../js/bill.js"></script>
   
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Hóa đơn</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px" onclick="clearBill()">Làm lại</button>
            <button id="btnAddBill" type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 150px" onclick="add_Bill()">Thêm</button>
            <button id="btnEditBill" type="button" class="btn btn-primary pull-right" style="margin-top: -64px;margin-right: 85px" onclick="edit()">Lưu</button>
             <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 225px" onclick="exportFileBill()">In</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- add apartment -->
    <div class="row">
         <div class="row">

            <div class="col col-sm-4 col-md-4 col-lg-4" id="err" >
            </div>


        </div>

        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Mã hóa đơn</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="idBill" placeholder="" />
                </div>
            </div>
           
            <div class="col col-sm-3 col-md-3 col-lg-3" id="getApartments">
                
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tiền phòng</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="total_apartment" placeholder="Tiền phòng" />
                </div>
            </div>
            
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số điện củ</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="electric_old" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số điện mới</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="electric_new" placeholder="Nhập số điện mới" onblur="totalElectric()"/>
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền điện</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="total_electric"  />

                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số nước củ</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="water_old" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số nước mới</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="water_new" placeholder="Nhập số nước mới" onblur="totalWater()" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền nước</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="total_water"  />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền rác</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="trash" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền internet</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="internet" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Hóa đơn của tháng</p>
                    <input min="2010-01-01"
                        type="date" id="dateBill" value=""
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày tạo"/>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>TỔNG TIỀN</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="total" />
                </div>
            </div>
            
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tình trạng</p>
                   <select class="form-control" style="margin-top: -10px;" id="status">
                        <option id="status1">Đã thanh toán</option>
                        <option id="status2">Chưa thanh toán</option>
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
                            <input type="text" class="form-control" placeholder="Tìm kiếm" name="srch-term" id="srch-term"/>
                            <div class="input-group-btn">
                                <button class="btn btn-primary" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <br/>
                <div class="row" id="divtable_bill">
                </div>
              
            </div>
        </div>


        <br />

        <!--footer -->
        <hr>
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


    <
</asp:Content>
