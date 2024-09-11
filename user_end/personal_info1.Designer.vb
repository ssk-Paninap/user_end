<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personal_info1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(personal_info1))
        Me.fn_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.goToProfForm = New System.Windows.Forms.Button()
        Me.goToStudForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fn_tb
        '
        Me.fn_tb.Location = New System.Drawing.Point(122, 201)
        Me.fn_tb.Multiline = True
        Me.fn_tb.Name = "fn_tb"
        Me.fn_tb.Size = New System.Drawing.Size(192, 43)
        Me.fn_tb.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Full Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please ensure the information you provide is true and honest!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First, you have to introduce yourself to us!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(107, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Please type in your name based on your ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Demographic"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Click the button that suits your demographic:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'goToProfForm
        '
        Me.goToProfForm.Location = New System.Drawing.Point(223, 364)
        Me.goToProfForm.Name = "goToProfForm"
        Me.goToProfForm.Size = New System.Drawing.Size(91, 38)
        Me.goToProfForm.TabIndex = 12
        Me.goToProfForm.Text = "I am a professor"
        Me.goToProfForm.UseVisualStyleBackColor = True
        '
        'goToStudForm
        '
        Me.goToStudForm.Location = New System.Drawing.Point(115, 364)
        Me.goToStudForm.Name = "goToStudForm"
        Me.goToStudForm.Size = New System.Drawing.Size(91, 38)
        Me.goToStudForm.TabIndex = 13
        Me.goToStudForm.Text = "I am a student"
        Me.goToStudForm.UseVisualStyleBackColor = True
        '
        'personal_info1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 450)
        Me.Controls.Add(Me.goToStudForm)
        Me.Controls.Add(Me.goToProfForm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fn_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "personal_info1"
        Me.Text = "personal_info1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fn_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents goToProfForm As Button
    Friend WithEvents goToStudForm As Button
End Class
