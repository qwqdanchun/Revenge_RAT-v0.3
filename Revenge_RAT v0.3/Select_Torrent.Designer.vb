<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Torrent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_Torrent))
        Me.STF = New System.Windows.Forms.Button()
        Me.TFP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DP = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NextF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'STF
        '
        Me.STF.Location = New System.Drawing.Point(303, 6)
        Me.STF.Name = "STF"
        Me.STF.Size = New System.Drawing.Size(48, 20)
        Me.STF.TabIndex = 0
        Me.STF.Text = "..."
        Me.STF.UseVisualStyleBackColor = True
        '
        'TFP
        '
        Me.TFP.Location = New System.Drawing.Point(84, 6)
        Me.TFP.Name = "TFP"
        Me.TFP.Size = New System.Drawing.Size(213, 21)
        Me.TFP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Torrent file :"
        '
        'DP
        '
        Me.DP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DP.FormattingEnabled = True
        Me.DP.Items.AddRange(New Object() {"Temp", "AppData", "Documents"})
        Me.DP.Location = New System.Drawing.Point(84, 31)
        Me.DP.Name = "DP"
        Me.DP.Size = New System.Drawing.Size(267, 21)
        Me.DP.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Drop Path  :"
        '
        'NextF
        '
        Me.NextF.Location = New System.Drawing.Point(276, 57)
        Me.NextF.Name = "NextF"
        Me.NextF.Size = New System.Drawing.Size(75, 23)
        Me.NextF.TabIndex = 5
        Me.NextF.Text = "Next"
        Me.NextF.UseVisualStyleBackColor = True
        '
        'Select_Torrent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 91)
        Me.Controls.Add(Me.NextF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TFP)
        Me.Controls.Add(Me.STF)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(375, 130)
        Me.Name = "Select_Torrent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Torrent File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents STF As Button
    Friend WithEvents TFP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DP As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NextF As Button
End Class
