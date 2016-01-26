<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customers.aspx.cs" Inherits="pages_customers" MasterPageFile="~/masterPage/HomePage.master" %>


<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="../js/customer.js"></script>

    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Khách hàng</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px" onclick="clearDataCustomer()">Làm lại</button>
            <button id="btnAdd" type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 150px" onclick="add()">Thêm</button>
            <button id="btnEdit" type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 85px" onclick="edit()">Lưu</button>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 225px" onclick="exportFile()">In</button>
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
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Mã khách hàng</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="idCustomer" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tên khách hàng *</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="txtName" placeholder="Nhập tên khách hàng" />
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Quê quán</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="txtAddress" placeholder="Nhập quê quán" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Chứng minh nhân dân *</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="txt_identifiCard" placeholder="Nhập chứng minh nhân dân" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giới tính</p>
                    <select class="form-control" style="margin-top: -10px;" id="sex">
                        <option selected="selected" id="male">Nam</option>
                        <option id="female">Nữ</option>
                    </select>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4" id="getApartments">
            </div>
        </div>

        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Ngày sinh *</p>
                    <input min="1920-01-01"
                        type="date" name="txtTGTu" value="" id="txtBirthday"
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày sinh" />
                </div>
            </div>

            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group" id="dvholder">
                    <p>Quyền căn hộ</p>
                    <select class="form-control" style="margin-top: -10px;" id="holder">
                        <option id="optionmember" selected="selected">Thành viên</option>
                        <option id="optionholder">Chủ</option>
                    </select>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Email *</p>
                    <input type="email" class="form-control" style="margin-top: -10px;" id="txtEmail" placeholder="Nhập email" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Số điên thoại *</p>
                    <input type="number" class="form-control" style="margin-top: -10px;" id="txtPhone" placeholder="Nhập số điên thoại" />
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tình trạng</p>
                    <select class="form-control" style="margin-top: -10px;" id="status">
                        <option id="active">Đang hoạt động</option>
                        <option selected="selected" id="noActive">Không hoạt động</option>
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
                            <input type="text" class="form-control" placeholder="Tìm kiếm" name="srch-term" id="srch-term" />
                            <div class="input-group-btn">
                                <button class="btn btn-primary" type="button" onclick="search()"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row" id="divtable">
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



</asp:Content>
