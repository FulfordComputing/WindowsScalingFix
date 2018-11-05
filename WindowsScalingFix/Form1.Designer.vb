<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSetDPI = New System.Windows.Forms.Button()
        Me.btnSetScaleFactor = New System.Windows.Forms.Button()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.txtScaleFactor = New System.Windows.Forms.TextBox()
        Me.chkDPIScaling = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDPI)
        Me.GroupBox1.Controls.Add(Me.btnSetDPI)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DPI for all displays:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtScaleFactor)
        Me.GroupBox2.Controls.Add(Me.btnSetScaleFactor)
        Me.GroupBox2.Location = New System.Drawing.Point(123, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scale factor:"
        '
        'btnSetDPI
        '
        Me.btnSetDPI.Location = New System.Drawing.Point(21, 84)
        Me.btnSetDPI.Name = "btnSetDPI"
        Me.btnSetDPI.Size = New System.Drawing.Size(75, 23)
        Me.btnSetDPI.TabIndex = 2
        Me.btnSetDPI.Text = "Set"
        Me.btnSetDPI.UseVisualStyleBackColor = True
        '
        'btnSetScaleFactor
        '
        Me.btnSetScaleFactor.Location = New System.Drawing.Point(18, 86)
        Me.btnSetScaleFactor.Name = "btnSetScaleFactor"
        Me.btnSetScaleFactor.Size = New System.Drawing.Size(75, 23)
        Me.btnSetScaleFactor.TabIndex = 3
        Me.btnSetScaleFactor.Text = "Set"
        Me.btnSetScaleFactor.UseVisualStyleBackColor = True
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(6, 19)
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(100, 20)
        Me.txtDPI.TabIndex = 3
        '
        'txtScaleFactor
        '
        Me.txtScaleFactor.Location = New System.Drawing.Point(6, 19)
        Me.txtScaleFactor.Name = "txtScaleFactor"
        Me.txtScaleFactor.Size = New System.Drawing.Size(100, 20)
        Me.txtScaleFactor.TabIndex = 4
        '
        'chkDPIScaling
        '
        Me.chkDPIScaling.AutoSize = True
        Me.chkDPIScaling.Location = New System.Drawing.Point(13, 13)
        Me.chkDPIScaling.Name = "chkDPIScaling"
        Me.chkDPIScaling.Size = New System.Drawing.Size(121, 17)
        Me.chkDPIScaling.TabIndex = 2
        Me.chkDPIScaling.Text = "DPI scaling enabled"
        Me.chkDPIScaling.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "96 is normal value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0 is normal value"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 199)
        Me.Controls.Add(Me.chkDPIScaling)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Windows Scaling Fix:"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDPI As TextBox
    Friend WithEvents btnSetDPI As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtScaleFactor As TextBox
    Friend WithEvents btnSetScaleFactor As Button
    Friend WithEvents chkDPIScaling As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
