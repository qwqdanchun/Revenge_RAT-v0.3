<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PN = New System.Windows.Forms.TextBox()
        Me.PAR = New System.Windows.Forms.TextBox()
        Me.PD = New System.Windows.Forms.TextBox()
        Me.AddP = New System.Windows.Forms.Button()
        Me.WB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plugin Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plugin Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author :"
        '
        'PN
        '
        Me.PN.BackColor = System.Drawing.Color.White
        Me.PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PN.Location = New System.Drawing.Point(6, 50)
        Me.PN.Name = "PN"
        Me.PN.ReadOnly = True
        Me.PN.Size = New System.Drawing.Size(332, 21)
        Me.PN.TabIndex = 3
        '
        'PAR
        '
        Me.PAR.BackColor = System.Drawing.Color.White
        Me.PAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAR.Location = New System.Drawing.Point(6, 89)
        Me.PAR.Name = "PAR"
        Me.PAR.ReadOnly = True
        Me.PAR.Size = New System.Drawing.Size(332, 21)
        Me.PAR.TabIndex = 4
        '
        'PD
        '
        Me.PD.BackColor = System.Drawing.Color.White
        Me.PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PD.Location = New System.Drawing.Point(7, 167)
        Me.PD.Name = "PD"
        Me.PD.ReadOnly = True
        Me.PD.Size = New System.Drawing.Size(332, 21)
        Me.PD.TabIndex = 5
        '
        'AddP
        '
        Me.AddP.Location = New System.Drawing.Point(263, 251)
        Me.AddP.Name = "AddP"
        Me.AddP.Size = New System.Drawing.Size(75, 23)
        Me.AddP.TabIndex = 6
        Me.AddP.Text = "OK"
        Me.AddP.UseVisualStyleBackColor = True
        '
        'WB
        '
        Me.WB.BackColor = System.Drawing.Color.White
        Me.WB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WB.Location = New System.Drawing.Point(7, 128)
        Me.WB.Name = "WB"
        Me.WB.ReadOnly = True
        Me.WB.Size = New System.Drawing.Size(332, 21)
        Me.WB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Website :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 281)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WB)
        Me.Controls.Add(Me.AddP)
        Me.Controls.Add(Me.PD)
        Me.Controls.Add(Me.PAR)
        Me.Controls.Add(Me.PN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 320)
        Me.Name = "PA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PN As TextBox
    Friend WithEvents PAR As TextBox
    Friend WithEvents PD As TextBox
    Friend WithEvents AddP As Button
    Friend WithEvents WB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
