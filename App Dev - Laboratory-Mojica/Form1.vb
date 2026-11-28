Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim days As Integer
        Dim daily, basicSal, SSS, Ph, Deductions, netSal, Pagibig As Double

        days = Val(txtDays.Text)
        daily = Val(txtDailyRate.Text)

        SSS = Val(txtSSS.Text)
        Ph = Val(txtPhilHealth.Text)
        Deductions = Val(txtTotalDeductions.Text)
        netSal = Val(txtNetSalary.Text)
        PagIbig = Val(txtPagIbig.Text)

        basicSal = days * daily
        SSS = basicSal * 0.05
        Pagibig = basicSal * 0.02
        Ph = basicSal * 0.025
        Deductions = SSS + Pagibig + Ph
        netSal = basicSal - Deductions

        txtBasicSalary.Text = "₱" & basicSal.ToString("N2")
        txtNetSalary.Text = "₱" & netSal.ToString("N2")
        txtSSS.Text = " ₱" & SSS.ToString("N2")
        txtPhilHealth.Text = "₱" & Ph.ToString("N2")
        txtPagIbig.Text = "₱" & Pagibig.ToString("N2")
        txtTotalDeductions.Text = "₱" & Deductions.ToString("N2")
        txtNetSalary.Text = "₱" & netSal.ToString("N2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDays.Clear()
        txtEmployeeName.Clear()
        txtEmployeeNumber.Clear()
        txtBasicSalary.Clear()
        txtDailyRate.Clear()
        txtNetSalary.Clear()
        txtSSS.Clear()
        txtPhilHealth.Clear()
        txtPagIbig.Clear()
        txtTotalDeductions.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
