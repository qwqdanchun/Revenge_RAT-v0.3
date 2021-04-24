<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rve))
        Me.VName = New System.Windows.Forms.TextBox()
        Me.ValueData = New System.Windows.Forms.TextBox()
        Me.Create = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VName
        '
        Me.VName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VName.Location = New System.Drawing.Point(11, 5)
        Me.VName.Name = "VName"
        Me.VName.Size = New System.Drawing.Size(357, 21)
        Me.VName.TabIndex = 0
        Me.VName.Text = "Name"
        '
        'ValueData
        '
        Me.ValueData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ValueData.Location = New System.Drawing.Point(11, 32)
        Me.ValueData.Multiline = True
        Me.ValueData.Name = "ValueData"
        Me.ValueData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ValueData.Size = New System.Drawing.Size(357, 189)
        Me.ValueData.TabIndex = 1
        '
        'Create
        '
        Me.Create.Location = New System.Drawing.Point(11, 227)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(357, 23)
        Me.Create.TabIndex = 2
        Me.Create.Text = "Create"
        Me.Create.UseVisualStyleBackColor = True
        '
        'Rve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(376, 258)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.ValueData)
        Me.Controls.Add(Me.VName)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(392, 297)
        Me.Name = "Rve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VName As TextBox
    Friend WithEvents ValueData As TextBox
    Friend WithEvents Create As Button
End Class
