<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADDP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PP = New System.Windows.Forms.TextBox()
        Me.MECL = New System.Windows.Forms.Button()
        Me.Cont = New System.Windows.Forms.Button()
        Me.SelectPlugin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select your plugin :"
        '
        'PP
        '
        Me.PP.Location = New System.Drawing.Point(5, 25)
        Me.PP.Name = "PP"
        Me.PP.Size = New System.Drawing.Size(201, 20)
        Me.PP.TabIndex = 1
        '
        'MECL
        '
        Me.MECL.Location = New System.Drawing.Point(5, 51)
        Me.MECL.Name = "MECL"
        Me.MECL.Size = New System.Drawing.Size(115, 23)
        Me.MECL.TabIndex = 2
        Me.MECL.Text = "Cancel"
        Me.MECL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MECL.UseVisualStyleBackColor = True
        '
        'Cont
        '
        Me.Cont.Location = New System.Drawing.Point(126, 51)
        Me.Cont.Name = "Cont"
        Me.Cont.Size = New System.Drawing.Size(115, 23)
        Me.Cont.TabIndex = 3
        Me.Cont.Text = "Continue"
        Me.Cont.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Cont.UseVisualStyleBackColor = True
        '
        'SelectPlugin
        '
        Me.SelectPlugin.Location = New System.Drawing.Point(212, 24)
        Me.SelectPlugin.Name = "SelectPlugin"
        Me.SelectPlugin.Size = New System.Drawing.Size(29, 20)
        Me.SelectPlugin.TabIndex = 4
        Me.SelectPlugin.Text = "..."
        Me.SelectPlugin.UseVisualStyleBackColor = True
        '
        'ADDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(247, 81)
        Me.Controls.Add(Me.SelectPlugin)
        Me.Controls.Add(Me.Cont)
        Me.Controls.Add(Me.MECL)
        Me.Controls.Add(Me.PP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(263, 120)
        Me.MinimumSize = New System.Drawing.Size(263, 120)
        Me.Name = "ADDP"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADDP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PP As TextBox
    Friend WithEvents MECL As Button
    Friend WithEvents Cont As Button
    Friend WithEvents SelectPlugin As Button
End Class
