<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WCV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WCV))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AWCD = New System.Windows.Forms.ComboBox()
        Me.CWCD = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.q = New System.Windows.Forms.TrackBar()
        Me.Panel1.SuspendLayout()
        CType(Me.q, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your device   :"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(292, 87)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client device :"
        '
        'AWCD
        '
        Me.AWCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AWCD.FormattingEnabled = True
        Me.AWCD.Location = New System.Drawing.Point(96, 12)
        Me.AWCD.Name = "AWCD"
        Me.AWCD.Size = New System.Drawing.Size(271, 21)
        Me.AWCD.TabIndex = 3
        '
        'CWCD
        '
        Me.CWCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CWCD.FormattingEnabled = True
        Me.CWCD.Location = New System.Drawing.Point(96, 38)
        Me.CWCD.Name = "CWCD"
        Me.CWCD.Size = New System.Drawing.Size(271, 21)
        Me.CWCD.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quality :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "30%"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.q)
        Me.Panel1.Location = New System.Drawing.Point(67, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 16)
        Me.Panel1.TabIndex = 7
        '
        'q
        '
        Me.q.Dock = System.Windows.Forms.DockStyle.Fill
        Me.q.Location = New System.Drawing.Point(0, 0)
        Me.q.Maximum = 100
        Me.q.Name = "q"
        Me.q.Size = New System.Drawing.Size(263, 16)
        Me.q.TabIndex = 0
        Me.q.Value = 30
        '
        'WCV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 116)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CWCD)
        Me.Controls.Add(Me.AWCD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(390, 155)
        Me.Name = "WCV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose video call settings!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.q, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Start As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AWCD As ComboBox
    Friend WithEvents CWCD As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents q As TrackBar
End Class
