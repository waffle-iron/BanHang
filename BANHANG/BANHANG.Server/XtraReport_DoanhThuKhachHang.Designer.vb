﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport_DoanhThuKhachHang
    Inherits DevExpress.XtraReports.UI.LightSwitchReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TenKhachHang = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DiaChiDonVi = New DevExpress.XtraReports.Parameters.Parameter()
        Me.TenDonVi = New DevExpress.XtraReports.Parameters.Parameter()
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DenNgay = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DiaChi = New DevExpress.XtraReports.UI.XRLabel()
        Me.TenCongTy = New DevExpress.XtraReports.UI.XRLabel()
        Me.NgayCT2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TuNgay = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Title = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.mavt = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.slx = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.KhachHang = New DevExpress.XtraReports.Parameters.Parameter()
        Me.LightSwitchDataSource1 = New DevExpress.XtraReports.LightSwitchDataSource()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.TenKhachHang, "Text", "")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(699.2917!, 83.00002!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(411.7498!, 24.99999!)
        Me.XrLabel8.Text = "XrLabel8"
        '
        'TenKhachHang
        '
        Me.TenKhachHang.Name = "TenKhachHang"
        Me.TenKhachHang.Visible = False
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Tên_Sản_Phẩm")})
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 0.33574074665764142R
        '
        'xrLabel22
        '
        Me.xrLabel22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.xrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(966.0001!, 75.0!)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel22.SizeF = New System.Drawing.SizeF(75.0!, 25.0!)
        XrSummary1.FormatString = "{0:###}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.DCount
        Me.xrLabel22.Summary = XrSummary1
        Me.xrLabel22.Text = "(Ký, họ tên)"
        Me.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel16
        '
        Me.xrLabel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.xrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLabel16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(225.0!, 0.0!)
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel16.SizeF = New System.Drawing.SizeF(161.0416!, 50.00001!)
        Me.xrLabel16.Text = "MÃ SẢN PHẨM"
        Me.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell2})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Tổng cộng"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 0.93138599538814915R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Doanh_thu")})
        Me.XrTableCell2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n0}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell2.Summary = XrSummary2
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell2.Weight = 3.8029798170796152R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Mã_Sản_Phẩm")})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.14314812086654721R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel2, Me.xrLabel31, Me.xrLabel16})
        Me.PageHeader.HeightF = 50.00001!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrLabel5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(763.7499!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(186.2501!, 50.00001!)
        Me.XrLabel5.Text = "ĐƠN VỊ TÍNH"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(161.0416!, 50.00001!)
        Me.XrLabel4.Text = "SỐ TIỀN"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrLabel2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(386.0416!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(377.7083!, 50.00001!)
        Me.XrLabel2.Text = "TÊN SẢN PHẨM"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel31
        '
        Me.xrLabel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.xrLabel31.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLabel31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(7.999992!, 0.0!)
        Me.xrLabel31.Name = "xrLabel31"
        Me.xrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel31.SizeF = New System.Drawing.SizeF(217.0!, 50.0!)
        Me.xrLabel31.StylePriority.UseBorders = False
        Me.xrLabel31.Text = "NGÀY"
        Me.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel3
        '
        Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(317.2916!, 83.00001!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(56.625!, 25.0!)
        Me.xrLabel3.Text = "Từ ngày"
        Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'DiaChiDonVi
        '
        Me.DiaChiDonVi.Name = "DiaChiDonVi"
        Me.DiaChiDonVi.Visible = False
        '
        'TenDonVi
        '
        Me.TenDonVi.Name = "TenDonVi"
        Me.TenDonVi.Visible = False
        '
        'xrLabel17
        '
        Me.xrLabel17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(950.0001!, 50.0!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        XrSummary3.FormatString = "{0:###}"
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.DCount
        Me.xrLabel17.Summary = XrSummary3
        Me.xrLabel17.Text = "Người lập"
        Me.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrLabel26})
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1100.0!, 0.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(34.0!, 25.0!)
        Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLabel26
        '
        Me.xrLabel26.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.xrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 0.0!)
        Me.xrLabel26.Name = "xrLabel26"
        Me.xrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel26.SizeF = New System.Drawing.SizeF(150.0!, 25.0!)
        Me.xrLabel26.Text = "Trang"
        Me.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrLabel10
        '
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(850.0001!, 25.0!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(261.0415!, 25.0!)
        XrSummary4.FormatString = "{0:###}"
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.DCount
        Me.xrLabel10.Summary = XrSummary4
        Me.xrLabel10.Text = ".....................,  ngày...........tháng...........năm 20......."
        Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel6, Me.XrLabel7, Me.DiaChi, Me.TenCongTy, Me.NgayCT2, Me.xrLabel3, Me.Title, Me.XrLabel1})
        Me.ReportHeader.HeightF = 111.125!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(617.6666!, 83.00001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(81.62506!, 25.0!)
        Me.XrLabel6.Text = "Khách hàng"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.DenNgay, "Text", "{0:dd/MM/yyyy}")})
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(543.3749!, 83.00001!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(74.29163!, 25.0!)
        Me.XrLabel7.Text = "NgayCT2"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'DenNgay
        '
        Me.DenNgay.Description = "Parameter1"
        Me.DenNgay.Name = "DenNgay"
        Me.DenNgay.Type = GetType(Date)
        Me.DenNgay.Visible = False
        '
        'DiaChi
        '
        Me.DiaChi.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.DiaChiDonVi, "Text", "")})
        Me.DiaChi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DiaChi.LocationFloat = New DevExpress.Utils.PointFloat(7.999992!, 25.0!)
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DiaChi.SizeF = New System.Drawing.SizeF(395.125!, 25.0!)
        Me.DiaChi.StylePriority.UseTextAlignment = False
        Me.DiaChi.Text = "DiaChi"
        Me.DiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TenCongTy
        '
        Me.TenCongTy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.TenDonVi, "Text", "")})
        Me.TenCongTy.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TenCongTy.LocationFloat = New DevExpress.Utils.PointFloat(7.999992!, 0.0!)
        Me.TenCongTy.Name = "TenCongTy"
        Me.TenCongTy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TenCongTy.SizeF = New System.Drawing.SizeF(395.125!, 25.0!)
        Me.TenCongTy.StylePriority.UseTextAlignment = False
        Me.TenCongTy.Text = "TenCongTy"
        Me.TenCongTy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'NgayCT2
        '
        Me.NgayCT2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.TuNgay, "Text", "{0:dd/MM/yyyy}")})
        Me.NgayCT2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.NgayCT2.LocationFloat = New DevExpress.Utils.PointFloat(373.9166!, 83.00001!)
        Me.NgayCT2.Name = "NgayCT2"
        Me.NgayCT2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NgayCT2.SizeF = New System.Drawing.SizeF(95.12494!, 25.0!)
        Me.NgayCT2.Text = "NgayCT2"
        Me.NgayCT2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TuNgay
        '
        Me.TuNgay.Description = "Parameter1"
        Me.TuNgay.Name = "TuNgay"
        Me.TuNgay.Type = GetType(Date)
        Me.TuNgay.Visible = False
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Title.LocationFloat = New DevExpress.Utils.PointFloat(317.2916!, 50.0!)
        Me.Title.Name = "Title"
        Me.Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Title.SizeF = New System.Drawing.SizeF(489.9167!, 33.0!)
        Me.Title.StylePriority.UseFont = False
        Me.Title.Text = "DOANH THU KHÁCH HÀNG"
        Me.Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(469.0416!, 83.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(74.3334!, 25.0!)
        Me.XrLabel1.Text = "Đến ngày"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(7.999992!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1103.042!, 20.83333!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.mavt, Me.XrTableCell4, Me.XrTableCell3, Me.XrTableCell1, Me.slx})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTableRow2.Weight = 1.0R
        '
        'mavt
        '
        Me.mavt.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.mavt.CanGrow = False
        Me.mavt.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Ngày", "{0:dd/MM/yyyy}")})
        Me.mavt.Name = "mavt"
        Me.mavt.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.mavt.StylePriority.UseBorders = False
        Me.mavt.StylePriority.UseTextAlignment = False
        Me.mavt.Text = "mavt"
        Me.mavt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.mavt.Weight = 0.19288892279730904R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Đơn_Vị_Tính")})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 0.16512034246667959R
        '
        'slx
        '
        Me.slx.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.slx.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Doanh_thu", "{0:n0}")})
        Me.slx.Name = "slx"
        Me.slx.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.slx.StylePriority.UseTextAlignment = False
        Me.slx.Text = "slx"
        Me.slx.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.slx.Weight = 0.14358328096220768R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.xrLabel17, Me.xrLabel22, Me.xrLabel10})
        Me.ReportFooter.HeightF = 165.9583!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTable2
        '
        Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 0.0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(1103.042!, 25.0!)
        Me.xrTable2.StylePriority.UseBorders = False
        Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TTSX", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'KhachHang
        '
        Me.KhachHang.Description = "Parameter1"
        Me.KhachHang.Name = "KhachHang"
        Me.KhachHang.Type = GetType(Integer)
        Me.KhachHang.ValueInfo = "0"
        Me.KhachHang.Visible = False
        '
        'LightSwitchDataSource1
        '
        Me.LightSwitchDataSource1.CollectionName = "vDoanh_Thu_Ngay_Theo_Khach_Hang"
        Me.LightSwitchDataSource1.DataSource = GetType(LightSwitchApplication.vDoanh_Thu_Ngày_Theo_Khách_HàngItem)
        Me.LightSwitchDataSource1.DataSourceName = "BanHangData"
        '
        'XtraReport_DoanhThuKhachHang
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.ReportFooter, Me.BottomMargin, Me.PageHeader, Me.TopMarginBand1})
        Me.DataSource = Me.LightSwitchDataSource1
        Me.FilterString = "[Ngày] Between(?TuNgay, ?DenNgay) And [c__KhachHang] = ?KhachHang"
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(16, 16, 25, 25)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.TenDonVi, Me.DiaChiDonVi, Me.TuNgay, Me.DenNgay, Me.TenKhachHang, Me.KhachHang})
        Me.Version = "13.1"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TenKhachHang As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DiaChiDonVi As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents TenDonVi As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DenNgay As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DiaChi As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TenCongTy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NgayCT2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TuNgay As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents mavt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents slx As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents KhachHang As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents LightSwitchDataSource1 As DevExpress.XtraReports.LightSwitchDataSource
End Class
