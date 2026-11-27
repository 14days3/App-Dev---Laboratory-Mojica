<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblEmployeeName = New Label()
        lblEmployeeNumber = New Label()
        lblDays = New Label()
        txtDays = New TextBox()
        lblDailyRate = New Label()
        txtDailyRate = New TextBox()
        lblBasicSalary = New Label()
        lblSSS = New Label()
        lblPagIbig = New Label()
        lblPhilHealth = New Label()
        lblTotalDeductions = New Label()
        lblNetSalary = New Label()
        txtBasicSalary = New TextBox()
        txtSSS = New TextBox()
        txtPagIbig = New TextBox()
        txtPhilHealth = New TextBox()
        txtTotalDeductions = New TextBox()
        txtNetSalary = New TextBox()
        txtEmployeeNumber = New TextBox()
        txtEmployeeName = New TextBox()
        btnClear = New Button()
        btnCalculate = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Font = New Font("Rockwell", 12F)
        lblEmployeeName.Location = New Point(37, 29)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(131, 19)
        lblEmployeeName.TabIndex = 0
        lblEmployeeName.Text = "Employee Name"
        ' 
        ' lblEmployeeNumber
        ' 
        lblEmployeeNumber.AutoSize = True
        lblEmployeeNumber.Font = New Font("Rockwell", 12F)
        lblEmployeeNumber.Location = New Point(37, 65)
        lblEmployeeNumber.Name = "lblEmployeeNumber"
        lblEmployeeNumber.Size = New Size(148, 19)
        lblEmployeeNumber.TabIndex = 1
        lblEmployeeNumber.Text = "Employee Number"
        ' 
        ' lblDays
        ' 
        lblDays.AutoSize = True
        lblDays.Font = New Font("Rockwell", 12F)
        lblDays.Location = New Point(37, 101)
        lblDays.Name = "lblDays"
        lblDays.Size = New Size(187, 19)
        lblDays.TabIndex = 2
        lblDays.Text = "Number of days worked"
        ' 
        ' txtDays
        ' 
        txtDays.Font = New Font("Rockwell", 12F)
        txtDays.Location = New Point(232, 98)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(254, 26)
        txtDays.TabIndex = 3
        ' 
        ' lblDailyRate
        ' 
        lblDailyRate.AutoSize = True
        lblDailyRate.Font = New Font("Rockwell", 12F)
        lblDailyRate.Location = New Point(36, 142)
        lblDailyRate.Name = "lblDailyRate"
        lblDailyRate.Size = New Size(84, 19)
        lblDailyRate.TabIndex = 4
        lblDailyRate.Text = "Daily Rate"
        ' 
        ' txtDailyRate
        ' 
        txtDailyRate.Font = New Font("Rockwell", 12F)
        txtDailyRate.Location = New Point(232, 135)
        txtDailyRate.Name = "txtDailyRate"
        txtDailyRate.Size = New Size(254, 26)
        txtDailyRate.TabIndex = 5
        ' 
        ' lblBasicSalary
        ' 
        lblBasicSalary.AutoSize = True
        lblBasicSalary.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        lblBasicSalary.Location = New Point(37, 179)
        lblBasicSalary.Name = "lblBasicSalary"
        lblBasicSalary.Size = New Size(105, 19)
        lblBasicSalary.TabIndex = 6
        lblBasicSalary.Text = "Basic salary"
        ' 
        ' lblSSS
        ' 
        lblSSS.AutoSize = True
        lblSSS.Font = New Font("Rockwell", 12F)
        lblSSS.Location = New Point(40, 221)
        lblSSS.Name = "lblSSS"
        lblSSS.Size = New Size(36, 19)
        lblSSS.TabIndex = 7
        lblSSS.Text = "SSS"
        ' 
        ' lblPagIbig
        ' 
        lblPagIbig.AutoSize = True
        lblPagIbig.Font = New Font("Rockwell", 12F)
        lblPagIbig.Location = New Point(36, 272)
        lblPagIbig.Name = "lblPagIbig"
        lblPagIbig.Size = New Size(75, 19)
        lblPagIbig.TabIndex = 8
        lblPagIbig.Text = "Pag-IBIG"
        ' 
        ' lblPhilHealth
        ' 
        lblPhilHealth.AutoSize = True
        lblPhilHealth.Font = New Font("Rockwell", 12F)
        lblPhilHealth.Location = New Point(36, 322)
        lblPhilHealth.Name = "lblPhilHealth"
        lblPhilHealth.Size = New Size(82, 19)
        lblPhilHealth.TabIndex = 9
        lblPhilHealth.Text = "PhilHealth"
        ' 
        ' lblTotalDeductions
        ' 
        lblTotalDeductions.AutoSize = True
        lblTotalDeductions.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        lblTotalDeductions.Location = New Point(34, 363)
        lblTotalDeductions.Name = "lblTotalDeductions"
        lblTotalDeductions.Size = New Size(144, 19)
        lblTotalDeductions.TabIndex = 10
        lblTotalDeductions.Text = "Total Deductions"
        ' 
        ' lblNetSalary
        ' 
        lblNetSalary.AutoSize = True
        lblNetSalary.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        lblNetSalary.Location = New Point(34, 404)
        lblNetSalary.Name = "lblNetSalary"
        lblNetSalary.Size = New Size(91, 19)
        lblNetSalary.TabIndex = 11
        lblNetSalary.Text = "Net Salary"
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtBasicSalary.Location = New Point(232, 179)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.Size = New Size(254, 26)
        txtBasicSalary.TabIndex = 12
        ' 
        ' txtSSS
        ' 
        txtSSS.Font = New Font("Rockwell", 12F)
        txtSSS.Location = New Point(232, 221)
        txtSSS.Name = "txtSSS"
        txtSSS.Size = New Size(254, 26)
        txtSSS.TabIndex = 13
        ' 
        ' txtPagIbig
        ' 
        txtPagIbig.Font = New Font("Rockwell", 12F)
        txtPagIbig.Location = New Point(232, 265)
        txtPagIbig.Name = "txtPagIbig"
        txtPagIbig.Size = New Size(254, 26)
        txtPagIbig.TabIndex = 14
        ' 
        ' txtPhilHealth
        ' 
        txtPhilHealth.Font = New Font("Rockwell", 12F)
        txtPhilHealth.Location = New Point(232, 315)
        txtPhilHealth.Name = "txtPhilHealth"
        txtPhilHealth.Size = New Size(254, 26)
        txtPhilHealth.TabIndex = 15
        ' 
        ' txtTotalDeductions
        ' 
        txtTotalDeductions.Enabled = False
        txtTotalDeductions.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtTotalDeductions.Location = New Point(232, 356)
        txtTotalDeductions.Name = "txtTotalDeductions"
        txtTotalDeductions.Size = New Size(254, 26)
        txtTotalDeductions.TabIndex = 16
        ' 
        ' txtNetSalary
        ' 
        txtNetSalary.Enabled = False
        txtNetSalary.Font = New Font("Rockwell", 12F, FontStyle.Bold)
        txtNetSalary.Location = New Point(232, 397)
        txtNetSalary.Name = "txtNetSalary"
        txtNetSalary.Size = New Size(254, 26)
        txtNetSalary.TabIndex = 17
        ' 
        ' txtEmployeeNumber
        ' 
        txtEmployeeNumber.Font = New Font("Rockwell", 12F)
        txtEmployeeNumber.Location = New Point(232, 58)
        txtEmployeeNumber.Name = "txtEmployeeNumber"
        txtEmployeeNumber.Size = New Size(254, 26)
        txtEmployeeNumber.TabIndex = 18
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Font = New Font("Rockwell", 12F)
        txtEmployeeName.Location = New Point(232, 26)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(254, 26)
        txtEmployeeName.TabIndex = 19
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(206, 468)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(122, 39)
        btnClear.TabIndex = 20
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(334, 449)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(152, 58)
        btnCalculate.TabIndex = 21
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(579, 484)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 22
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(703, 559)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(btnClear)
        Controls.Add(txtEmployeeName)
        Controls.Add(txtEmployeeNumber)
        Controls.Add(txtNetSalary)
        Controls.Add(txtTotalDeductions)
        Controls.Add(txtPhilHealth)
        Controls.Add(txtPagIbig)
        Controls.Add(txtSSS)
        Controls.Add(txtBasicSalary)
        Controls.Add(lblNetSalary)
        Controls.Add(lblTotalDeductions)
        Controls.Add(lblPhilHealth)
        Controls.Add(lblPagIbig)
        Controls.Add(lblSSS)
        Controls.Add(lblBasicSalary)
        Controls.Add(txtDailyRate)
        Controls.Add(lblDailyRate)
        Controls.Add(txtDays)
        Controls.Add(lblDays)
        Controls.Add(lblEmployeeNumber)
        Controls.Add(lblEmployeeName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblEmployeeNumber As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents lblDailyRate As Label
    Friend WithEvents txtDailyRate As TextBox
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents lblSSS As Label
    Friend WithEvents lblPagIbig As Label
    Friend WithEvents lblPhilHealth As Label
    Friend WithEvents lblTotalDeductions As Label
    Friend WithEvents lblNetSalary As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtPagIbig As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtTotalDeductions As TextBox
    Friend WithEvents txtNetSalary As TextBox
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button

End Class
