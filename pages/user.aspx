<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="pages_user" MasterPageFile="~/masterPage/HomePage.master" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">
    <script src="../js/user.js"></script>
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Tài khoản</h3>
            <button type="button" onclick="add()" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 65px">Thêm</button>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px;">Lưu</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- add apartment -->
    <div class="row">
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tên tài khoản</p>
                    
                    <input type="text" class="form-control" style="margin-top: -10px;" id="txt_username" placeholder="Nhập tên tài khoản" />
                    <p id="username_err" style="color:red"></p>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Mật khẩu</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="txt_password" placeholder="Nhập mật khẩu" />
                    <p id="password_err" style="color:red"></p>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Khách hàng</p>
                    <select class="form-control" style="margin-top: -10px;" id="customer">
                        <option value="0">Khách hàng A</option>
                        <option value="1">Khách hàng B</option>
                        <option value="2">Khách hàng C</option>
                    </select>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Nhập lại mật khẩu</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="txt_rePassword" placeholder="Nhập lại mật khẩu" />
                    <p id="rePassword_err" style="color:red"></p>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Nhân viên</p>
                    <select class="form-control" style="margin-top: -10px;" id="employee">
                        <option value="0">Nhân viên A</option>
                        <option value="1">Nhân viên B</option>
                        <option value="2">Nhân viên C</option>
                    </select>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Quyền</p>
                    <select class="form-control" style="margin-top: -10px;" id="rule">
                        <option value="0">Quản lý</option>
                        <option value="1">Xem thông tin nhân viên</option>
                        <option value="2">Xem thông tin nhân viên</option>
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
                                <button class="btn btn-default " type="submit"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row" id="divtable"></div>

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
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
</asp:Content>
