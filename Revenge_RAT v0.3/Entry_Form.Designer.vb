<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entry_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entry_Form))
        Me.CPort = New System.Windows.Forms.NumericUpDown()
        Me.SocketKey = New System.Windows.Forms.TextBox()
        Me.StartL = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PINGN = New System.Windows.Forms.NumericUpDown()
        CType(Me.CPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PINGN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPort
        '
        Me.CPort.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPort.Location = New System.Drawing.Point(6, 61)
        Me.CPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.CPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CPort.Name = "CPort"
        Me.CPort.Size = New System.Drawing.Size(106, 21)
        Me.CPort.TabIndex = 0
        Me.CPort.Value = New Decimal(New Integer() {333, 0, 0, 0})
        '
        'SocketKey
        '
        Me.SocketKey.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SocketKey.Location = New System.Drawing.Point(6, 21)
        Me.SocketKey.Name = "SocketKey"
        Me.SocketKey.Size = New System.Drawing.Size(324, 21)
        Me.SocketKey.TabIndex = 1
        Me.SocketKey.Text = "Revenge-RAT"
        '
        'StartL
        '
        Me.StartL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartL.Image = CType(resources.GetObject("StartL.Image"), System.Drawing.Image)
        Me.StartL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StartL.Location = New System.Drawing.Point(5, 110)
        Me.StartL.Name = "StartL"
        Me.StartL.Size = New System.Drawing.Size(324, 22)
        Me.StartL.TabIndex = 2
        Me.StartL.Text = "Start Listening"
        Me.StartL.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Socket Key :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sec"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Automatically Ping each Client every :"
        '
        'PINGN
        '
        Me.PINGN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PINGN.Location = New System.Drawing.Point(230, 87)
        Me.PINGN.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PINGN.Name = "PINGN"
        Me.PINGN.Size = New System.Drawing.Size(43, 21)
        Me.PINGN.TabIndex = 7
        Me.PINGN.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Entry_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 137)
        Me.Controls.Add(Me.PINGN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StartL)
        Me.Controls.Add(Me.SocketKey)
        Me.Controls.Add(Me.CPort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Entry_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.CPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PINGN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPort As NumericUpDown
    Friend WithEvents SocketKey As TextBox
    Friend WithEvents StartL As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PINGN As NumericUpDown
End Class
