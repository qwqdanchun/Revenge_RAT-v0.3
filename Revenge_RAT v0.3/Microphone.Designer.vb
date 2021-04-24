<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Microphone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Microphone))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DV = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BZ = New System.Windows.Forms.ComboBox()
        Me.StartRec = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CT = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device :"
        '
        'DV
        '
        Me.DV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DV.FormattingEnabled = True
        Me.DV.Location = New System.Drawing.Point(6, 64)
        Me.DV.Name = "DV"
        Me.DV.Size = New System.Drawing.Size(273, 21)
        Me.DV.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buffer Size :"
        '
        'BZ
        '
        Me.BZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BZ.FormattingEnabled = True
        Me.BZ.Items.AddRange(New Object() {"4 kb - 8bit", "4 kb - 16bit", "6 kb - 8bit", "6 kb - 16bit", "8 kb - 8bit", "8 kb - 16bit", "12 kb - 8bit", "12 kb - 16bit", "16 kb - 8bit", "16 kb - 16bit", "20 kb - 8bit", "20 kb - 16bit", "24 kb - 8bit", "24 kb - 16bi"})
        Me.BZ.Location = New System.Drawing.Point(6, 104)
        Me.BZ.Name = "BZ"
        Me.BZ.Size = New System.Drawing.Size(273, 21)
        Me.BZ.TabIndex = 3
        '
        'StartRec
        '
        Me.StartRec.Location = New System.Drawing.Point(204, 174)
        Me.StartRec.Name = "StartRec"
        Me.StartRec.Size = New System.Drawing.Size(75, 23)
        Me.StartRec.TabIndex = 4
        Me.StartRec.Text = "Start"
        Me.StartRec.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Channel :"
        '
        'CT
        '
        Me.CT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CT.FormattingEnabled = True
        Me.CT.Items.AddRange(New Object() {"Stereo", "Mono"})
        Me.CT.Location = New System.Drawing.Point(6, 144)
        Me.CT.Name = "CT"
        Me.CT.Size = New System.Drawing.Size(273, 21)
        Me.CT.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ".."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Output Device :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(273, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Microphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 206)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartRec)
        Me.Controls.Add(Me.BZ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DV)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 245)
        Me.Name = "Microphone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Microphone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DV As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BZ As ComboBox
    Friend WithEvents StartRec As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CT As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
