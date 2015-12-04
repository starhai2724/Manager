<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bill.aspx.cs" Inherits="pages_bill" MasterPageFile="~/masterPage/HomePage.master" %>


<asp:Content ContentPlaceHolderID="CPH1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header" style="margin: 15px 0 20px;">Hóa đơn</h3>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px; margin-right: 65px">Thêm</button>
            <button type="button" class="btn btn-primary pull-right" style="margin-top: -64px;">Lưu</button>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <!-- add apartment -->
    <div class="row">
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Mã hóa đơn</p>
                    <input disabled="disabled" type="text" class="form-control" style="margin-top: -10px;" id="idBill" placeholder="" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Ngày tạo hóa đơn</p>
                    <input min="2010-01-01"
                        type="date" name="txtTGTu" value=""
                        class="form-control" style="margin-top: -10px;" data-toggle="tooltip" title="Ngày sinh"/>
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Áp dụng cho căn hộ</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập tên căn hộ" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số điện củ</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số điện mới</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập số điện mới" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền điện</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập số điện mới" />

                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số nước củ</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Số nước mới</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập số nước mới" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền nước</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" placeholder="Nhập số nước mới" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền rác</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tổng tiền internet</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" />
                </div>
            </div>
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>Tiền phòng</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col col-sm-3 col-md-3 col-lg-3">
                <div class="form-group">
                    <p>TỔNG TIỀN</p>
                    <input type="text" class="form-control" style="margin-top: -10px;" id="" />
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
                            <input type="text" class="form-control" placeholder="Tìm kiếm" name="srch-term" id="srch-term">
                            <div class="input-group-btn">
                                <button class="btn btn-primary" type="submit"><i class="glyphicon glyphicon-search"></i></button>
                            </div>
                        </div>
                    </div>
                </div>
                <br>
                <table class="table table-striped table-bordered table-hover" id="dataTables-example" style="margin-top: -13px;">
                    <thead>
                        <tr class="info">
                            <th>Mã </th>
                            <th>Tên căn hộ</th>
                            <th>Tổng tiền điện</th>
                            <th>Tổng tiền nước</th>
                            <th>Tổng tiền rác</th>
                            <th>Tổng tiền internet</th>
                            <th>Tổng tiền phòng</th>
                            <th>Ngày lập</th>
                            <th>Thành tiền</th>
                            <th class=" no-link last"><span class="nobr">Thao tác</span>
                            </th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr class="even pointer">
                            <td class=" ">0001</td>
                            <td class=" ">A001</td>
                            <td class=" ">520,000</td>
                            <td class=" ">230,000</td>
                            <td class=" ">25,000</td>
                            <td class=" ">100,000</td>
                            <td class=" ">9,000,000</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">11,200,000</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">0001</td>
                            <td class=" ">A001</td>
                            <td class=" ">520,000</td>
                            <td class=" ">230,000</td>
                            <td class=" ">25,000</td>
                            <td class=" ">100,000</td>
                            <td class=" ">9,000,000</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">11,200,000</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">0001</td>
                            <td class=" ">A001</td>
                            <td class=" ">520,000</td>
                            <td class=" ">230,000</td>
                            <td class=" ">25,000</td>
                            <td class=" ">100,000</td>
                            <td class=" ">9,000,000</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">11,200,000</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="even pointer">
                            <td class=" ">0001</td>
                            <td class=" ">A001</td>
                            <td class=" ">520,000</td>
                            <td class=" ">230,000</td>
                            <td class=" ">25,000</td>
                            <td class=" ">100,000</td>
                            <td class=" ">9,000,000</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">11,200,000</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>| <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                        </tr>
                        <tr class="odd pointer">
                            <td class=" ">0001</td>
                            <td class=" ">A001</td>
                            <td class=" ">520,000</td>
                            <td class=" ">230,000</td>
                            <td class=" ">25,000</td>
                            <td class=" ">100,000</td>
                            <td class=" ">9,000,000</td>
                            <td class=" ">28/11/1993</td>
                            <td class=" ">11,200,000</td>
                            <td class=" last"><a href="#"><i data-toggle="tooltip" title="Sửa" class="glyphicon glyphicon-edit"></i></a>|  <a href="#"><i data-toggle="tooltip" title="Xóa" class="glyphicon glyphicon-remove"></i></a>
                            </td>
                            <script>
                                $(document).ready(function () {
                                    $('[data-toggle="tooltip"]').tooltip();
                                });

                                $('idBill').prop('disabled', true);
                            </script>
                        </tr>

                    </tbody>

                </table>
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
