<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bai1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.Tinh = New System.Windows.Forms.Button()
        Me.Tong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Thoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(186, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tính tổng 2 số"
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(232, 73)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(154, 23)
        Me.a.TabIndex = 1
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(232, 120)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(154, 23)
        Me.b.TabIndex = 2
        '
        'Tinh
        '
        Me.Tinh.BackColor = System.Drawing.SystemColors.Control
        Me.Tinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Tinh.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Tinh.Location = New System.Drawing.Point(216, 207)
        Me.Tinh.Name = "Tinh"
        Me.Tinh.Size = New System.Drawing.Size(75, 27)
        Me.Tinh.TabIndex = 7
        Me.Tinh.Text = "Tính"
        Me.Tinh.UseVisualStyleBackColor = False
        '
        'Tong
        '
        Me.Tong.Location = New System.Drawing.Point(232, 164)
        Me.Tong.Name = "Tong"
        Me.Tong.Size = New System.Drawing.Size(154, 23)
        Me.Tong.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(216, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Design by @ Hải Đăng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(134, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(113, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nhập số a: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(113, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nhập số b: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label7.Location = New System.Drawing.Point(150, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tổng:"
        '
        'Thoat
        '
        Me.Thoat.BackColor = System.Drawing.SystemColors.Control
        Me.Thoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Thoat.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Thoat.Location = New System.Drawing.Point(323, 207)
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(75, 27)
        Me.Thoat.TabIndex = 14
        Me.Thoat.Text = "Thoát"
        Me.Thoat.UseVisualStyleBackColor = False
        '
        'Bai1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 308)
        Me.Controls.Add(Me.Thoat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tong)
        Me.Controls.Add(Me.Tinh)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bai1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents Tinh As Button
    Friend WithEvents Tong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Thoat As Button
End Class
