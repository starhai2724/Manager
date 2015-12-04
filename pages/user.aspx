<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="pages_user" MasterPageFile="~/masterPage/HomePage.master" %>

<asp:Content ContentPlaceHolderID="CPH1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Tài khoản</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 65px">Thêm</button>
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
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập tên tài khoản" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Mật khẩu</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập mật khẩu" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Nhập lại mật khẩu</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập lại mật khẩu" />
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
                                <button class="btn btn-default " type="submit"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <br/>
                <table class="table table-striped table-bordered table-hover" id="dataTables-example" style="margin-top: -13px;">
                    <thead>
                        <tr class="info">
                            <th>Tên tài khoản</th>
                            <th>Mật khẩu</th>
                            <th class=" no-link last"><span class="nobr">Thao tác</span>
                            </th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr class="even pointer">
                            <td class=" ">thu225656294@gmail.com</td>
                            <td class=" ">1234567890</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">Lee93929190@gmail.com</td>
                            <td class=" ">1234567890</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">sunflower.bmt@gmail.com</td>
                            <td class=" ">1234567890</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">hai@gmail.com</td>
                            <td class=" ">1234567890</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="odd pointer">
                            <td class=" ">thu225656294@gmail.com</td>
                            <td class=" ">1234567890</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>|  <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                            <script>
                                $(document).ready(function () {
                                    $('[data-toggle="tooltip"]').tooltip();
                                });
                            </script>
                        </tr>

                    </tbody>

                </table>
            </div>
        </div>


        <br />

        <!--footer -->
        <hr/>
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
