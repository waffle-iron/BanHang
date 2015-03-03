﻿
Namespace LightSwitchApplication

    Public Class XuatSanPhamChiTiet
        Public TonThuc As Decimal = Nothing
        Private Sub Thành_tiền_Compute(ByRef result As Decimal)
            ' Set result to the desired field value
            result = Số_lượng * Giá_bán
        End Sub

        Private Sub Tiền_thuế_Compute(ByRef result As Decimal)
            result = Số_lượng * Giá_bán * Phần_trăm_thuế
        End Sub

        Private Sub Tổng_tiền_Compute(ByRef result As Decimal)
            result = Thành_tiền + Tổng_tiền
        End Sub

        Private Sub Tồn_Compute(ByRef result As Integer)
            ' Set result to the desired field value
            result = TonThuc
        End Sub

        Private Sub Số_lượng_Validate(results As EntityValidationResultsBuilder)
            If Số_lượng = 0 Then
                results.AddPropertyError("Số lượng phải lớn hơn 0 !")
            End If
            If Số_lượng > TonThuc And TonThuc <> 0 Then
                results.AddPropertyError("Số lượng xuất lớn hơn số lượng tồn : " & TonThuc & " !")
            End If '
        End Sub
    End Class

End Namespace
