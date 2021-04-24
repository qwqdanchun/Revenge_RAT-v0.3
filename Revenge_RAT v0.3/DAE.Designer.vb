<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DAE))
        Me.DAEC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.URL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DAEC
        '
        Me.DAEC.Location = New System.Drawing.Point(10, 62)
        Me.DAEC.Name = "DAEC"
        Me.DAEC.Size = New System.Drawing.Size(340, 23)
        Me.DAEC.TabIndex = 0
        Me.DAEC.Text = "Download and execute"
        Me.DAEC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Link :"
        '
        'URL
        '
        Me.URL.Location = New System.Drawing.Point(44, 8)
        Me.URL.Name = "URL"
        Me.URL.Size = New System.Drawing.Size(306, 21)
        Me.URL.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "File :"
        '
        'FN
        '
        Me.FN.Location = New System.Drawing.Point(44, 35)
        Me.FN.Name = "FN"
        Me.FN.Size = New System.Drawing.Size(306, 21)
        Me.FN.TabIndex = 4
        '
        'DAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(360, 92)
        Me.Controls.Add(Me.FN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.URL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DAEC)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DAE"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DAEC As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents URL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FN As TextBox
End Class
