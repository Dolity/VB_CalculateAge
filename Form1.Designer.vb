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
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        btnExit = New Button()
        btnReset = New Button()
        btnSave = New Button()
        btnCalculator = New Button()
        txtAge = New TextBox()
        txtFullName = New TextBox()
        txtSecond = New Label()
        l8 = New Label()
        txtWeek = New Label()
        txtMinute = New Label()
        l4 = New Label()
        txtMonth = New Label()
        l7 = New Label()
        txtHour = New Label()
        l3 = New Label()
        l6 = New Label()
        txtDay = New Label()
        l2 = New Label()
        l5 = New Label()
        l1 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightBlue
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel4)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(715, 57)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(705, 47)
        Panel4.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(236, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 40)
        Label1.TabIndex = 0
        Label1.Text = "Age Calculator"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightBlue
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(12, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(715, 553)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnExit)
        Panel3.Controls.Add(btnReset)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnCalculator)
        Panel3.Controls.Add(txtAge)
        Panel3.Controls.Add(txtFullName)
        Panel3.Controls.Add(txtSecond)
        Panel3.Controls.Add(l8)
        Panel3.Controls.Add(txtWeek)
        Panel3.Controls.Add(txtMinute)
        Panel3.Controls.Add(l4)
        Panel3.Controls.Add(txtMonth)
        Panel3.Controls.Add(l7)
        Panel3.Controls.Add(txtHour)
        Panel3.Controls.Add(l3)
        Panel3.Controls.Add(l6)
        Panel3.Controls.Add(txtDay)
        Panel3.Controls.Add(l2)
        Panel3.Controls.Add(l5)
        Panel3.Controls.Add(l1)
        Panel3.Location = New Point(3, 11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(705, 535)
        Panel3.TabIndex = 1
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Location = New Point(401, 419)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(283, 99)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(401, 275)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(283, 99)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Location = New Point(401, 139)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(283, 99)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCalculator
        ' 
        btnCalculator.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculator.Location = New Point(401, 10)
        btnCalculator.Name = "btnCalculator"
        btnCalculator.Size = New Size(283, 99)
        btnCalculator.TabIndex = 2
        btnCalculator.Text = "Calculator"
        btnCalculator.UseVisualStyleBackColor = True
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtAge.Location = New Point(158, 66)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(216, 43)
        txtAge.TabIndex = 1
        txtAge.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullName.Location = New Point(158, 10)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(216, 43)
        txtFullName.TabIndex = 1
        txtFullName.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtSecond
        ' 
        txtSecond.BackColor = Color.White
        txtSecond.BorderStyle = BorderStyle.Fixed3D
        txtSecond.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSecond.Location = New Point(158, 483)
        txtSecond.Name = "txtSecond"
        txtSecond.Size = New Size(216, 37)
        txtSecond.TabIndex = 0
        txtSecond.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' l8
        ' 
        l8.AutoSize = True
        l8.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l8.Location = New Point(12, 483)
        l8.Name = "l8"
        l8.Size = New Size(115, 37)
        l8.TabIndex = 0
        l8.Text = "Seconds"
        ' 
        ' txtWeek
        ' 
        txtWeek.BackColor = Color.White
        txtWeek.BorderStyle = BorderStyle.Fixed3D
        txtWeek.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtWeek.Location = New Point(158, 207)
        txtWeek.Name = "txtWeek"
        txtWeek.Size = New Size(216, 37)
        txtWeek.TabIndex = 0
        txtWeek.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtMinute
        ' 
        txtMinute.BackColor = Color.White
        txtMinute.BorderStyle = BorderStyle.Fixed3D
        txtMinute.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMinute.Location = New Point(158, 419)
        txtMinute.Name = "txtMinute"
        txtMinute.Size = New Size(216, 37)
        txtMinute.TabIndex = 0
        txtMinute.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' l4
        ' 
        l4.AutoSize = True
        l4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l4.Location = New Point(12, 207)
        l4.Name = "l4"
        l4.Size = New Size(93, 37)
        l4.TabIndex = 0
        l4.Text = "Weeks"
        ' 
        ' txtMonth
        ' 
        txtMonth.BackColor = Color.White
        txtMonth.BorderStyle = BorderStyle.Fixed3D
        txtMonth.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMonth.Location = New Point(158, 139)
        txtMonth.Name = "txtMonth"
        txtMonth.Size = New Size(216, 37)
        txtMonth.TabIndex = 0
        txtMonth.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' l7
        ' 
        l7.AutoSize = True
        l7.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l7.Location = New Point(12, 419)
        l7.Name = "l7"
        l7.Size = New Size(112, 37)
        l7.TabIndex = 0
        l7.Text = "Minutes"
        ' 
        ' txtHour
        ' 
        txtHour.BackColor = Color.White
        txtHour.BorderStyle = BorderStyle.Fixed3D
        txtHour.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHour.Location = New Point(158, 340)
        txtHour.Name = "txtHour"
        txtHour.Size = New Size(216, 37)
        txtHour.TabIndex = 0
        txtHour.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' l3
        ' 
        l3.AutoSize = True
        l3.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l3.Location = New Point(12, 139)
        l3.Name = "l3"
        l3.Size = New Size(107, 37)
        l3.TabIndex = 0
        l3.Text = "Months"
        ' 
        ' l6
        ' 
        l6.AutoSize = True
        l6.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l6.Location = New Point(12, 340)
        l6.Name = "l6"
        l6.Size = New Size(87, 37)
        l6.TabIndex = 0
        l6.Text = "Hours"
        ' 
        ' txtDay
        ' 
        txtDay.BackColor = Color.White
        txtDay.BorderStyle = BorderStyle.Fixed3D
        txtDay.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtDay.Location = New Point(158, 275)
        txtDay.Name = "txtDay"
        txtDay.Size = New Size(216, 37)
        txtDay.TabIndex = 0
        txtDay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' l2
        ' 
        l2.AutoSize = True
        l2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l2.Location = New Point(12, 72)
        l2.Name = "l2"
        l2.Size = New Size(64, 37)
        l2.TabIndex = 0
        l2.Text = "Age"
        ' 
        ' l5
        ' 
        l5.AutoSize = True
        l5.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l5.Location = New Point(12, 275)
        l5.Name = "l5"
        l5.Size = New Size(74, 37)
        l5.TabIndex = 0
        l5.Text = "Days"
        ' 
        ' l1
        ' 
        l1.AutoSize = True
        l1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        l1.Location = New Point(12, 10)
        l1.Name = "l1"
        l1.Size = New Size(132, 37)
        l1.TabIndex = 0
        l1.Text = "Full name"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(739, 640)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l8 As Label
    Friend WithEvents l4 As Label
    Friend WithEvents l7 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents l6 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents l5 As Label
    Friend WithEvents l1 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtSecond As Label
    Friend WithEvents txtWeek As Label
    Friend WithEvents txtMinute As Label
    Friend WithEvents txtMonth As Label
    Friend WithEvents txtHour As Label
    Friend WithEvents txtDay As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalculator As Button
End Class
