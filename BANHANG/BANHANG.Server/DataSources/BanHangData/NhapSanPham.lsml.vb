﻿
Namespace LightSwitchApplication

    Public Class NhapSanPham

        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            ' Set result to the desired field value
            Dim tien = 0.0
            For Each d In Nhập_Sản_Phẩm_Chi_Tiết
                tien += d.Thành_tiền
            Next
            If tien > 0 Then
                result = tien
            End If
        End Sub

        Private Sub Tiền_thuế_Compute(ByRef result As Decimal)
            Dim tien = 0.0
            For Each d In Nhập_Sản_Phẩm_Chi_Tiết
                tien += d.Tiền_thuế
            Next
            If tien > 0 Then
                result = tien
            End If
        End Sub

        Private Sub Tổng_tiền_Compute(ByRef result As Decimal)
            Dim tien = 0.0
            For Each d In Nhập_Sản_Phẩm_Chi_Tiết
                tien += d.Tổng_tiền
            Next
            If tien > 0 Then
                result = tien
            End If
        End Sub
    End Class

End Namespace
