<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customers.aspx.cs" Inherits="pages_customers" MasterPageFile="~/masterPage/HomePage.master" %>


<asp:Content ContentPlaceHolderID="CPH1" runat="server">


    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Khách hàng</h3>
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
                    <p>Mã khách hàng</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tên khách hàng</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập tên khách hàng" />
                </div>
            </div>

        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Quê quán</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập quê quán" />
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Chứng minh nhân dân</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập chứng minh nhân dân" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Giới tính</p>
                    <select class="form-control" style="margin-top: -10px;">
                        <option>Nam</option>
                        <option>Nữ</option>
                    </select>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Chọn căn hộ</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập tên căn hộ" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Ngày sinh</p>
                    <input min="2010-01-01"
                        type="date" name="txtTGTu" value="" id="txtTGTu"
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày sinh"/>
                </div>
            </div>
            <div class="col col-sm-4 col-md-4 col-lg-4">
                <div class="form-group">
                    <p>Tình trạng</p>
                    <select class="form-control" style="margin-top: -10px;">
                        <option>Đang hoạt động</option>
                        <option>Không hoạt động</option>
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
                <table class="table table-striped table-bordered table-hover" id="dataTables-example" style="margin-top: -13px;">
                    <thead>
                        <tr class="info">
                            <th>Mã khách hàng</th>
                            <th>Tên</th>
                            <th>Ngày sinh</th>
                            <th>Quê quán</th>
                            <th>Chứng minh nhân dân</th>
                            <th>Giới tính</th>
                            <th>Tên căn hộ</th>
                            <th>Tình trạng</th>
                            <th class=" no-link last"><span class="nobr">Thao tác</span>
                            </th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr class="even pointer">
                            <td class=" ">0001</td>
                            <td class=" ">Nguyễn Thị B</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">Khánh Hòa</td>
                            <td class=" ">205622121</td>
                            <td class=" ">Nữ</td>
                            <td class="a-right a-right ">A10</td>
                            <td class=" ">Đang hoạt động</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">0002</td>
                            <td class=" ">Nguyễn Văn A</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">Khánh Hòa</td>
                            <td class=" ">205622121</td>
                            <td class=" ">Nam</td>
                            <td class="a-right a-right ">A10</td>
                            <td class=" ">Đang hoạt động</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">0003</td>
                            <td class=" ">Nguyễn Văn B</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">Khánh Hòa</td>
                            <td class=" ">205622121</td>
                            <td class=" ">Nam</td>
                            <td class="a-right a-right ">A10</td>
                            <td class=" ">Đang hoạt động</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">0004</td>
                            <td class=" ">Nguyễn Văn C</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">Khánh Hòa</td>
                            <td class=" ">205622121</td>
                            <td class=" ">Nam</td>
                            <td class="a-right a-right ">A10</td>
                            <td class=" ">Đang hoạt động</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="odd pointer">
                            <td class=" ">0005</td>
                            <td class=" ">Nguyễn Thị A</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">Khánh Hòa</td>
                            <td class=" ">205622121</td>
                            <td class=" ">Nữ</td>
                            <td class="a-right a-right ">A09</td>
                            <td class=" ">Đang hoạt động</td>
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
