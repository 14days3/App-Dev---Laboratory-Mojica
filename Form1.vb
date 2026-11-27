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

        txtBasicSalary.Text = basicSal.ToString()
        txtNetSalary.Text = netSal.ToString()
        txtSSS.Text = SSS.ToString()
        txtPhilHealth.Text = Ph.ToString()
        txtPagIbig.Text = Pagibig.ToString()
        txtTotalDeductions.Text = Deductions.ToString()
        txtNetSalary.Text = netSal.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDays.Clear()
        txtEmployeeName.Clear()
        txtEmployeeNumber.Clear()
    End Sub
End Class
