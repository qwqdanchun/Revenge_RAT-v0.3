<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AN = New System.Windows.Forms.CheckBox()
        Me.P = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.C = New System.Windows.Forms.Button()
        Me.SC = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type the name or path of program, document , picture , etc .." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and client will op" &
    "en it for you"
        '
        'AN
        '
        Me.AN.AutoSize = True
        Me.AN.Location = New System.Drawing.Point(9, 62)
        Me.AN.Name = "AN"
        Me.AN.Size = New System.Drawing.Size(287, 17)
        Me.AN.TabIndex = 1
        Me.AN.Text = "    Create this task with adminstartive pirviles"
        Me.AN.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.Location = New System.Drawing.Point(9, 38)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(372, 21)
        Me.P.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(225, 85)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(75, 23)
        Me.C.TabIndex = 4
        Me.C.Text = "Cancel"
        Me.C.UseVisualStyleBackColor = True
        '
        'SC
        '
        Me.SC.Location = New System.Drawing.Point(306, 85)
        Me.SC.Name = "SC"
        Me.SC.Size = New System.Drawing.Size(75, 23)
        Me.SC.TabIndex = 5
        Me.SC.Text = "Contiune"
        Me.SC.UseVisualStyleBackColor = True
        '
        'CT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 113)
        Me.Controls.Add(Me.SC)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.AN)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Create Task .."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AN As CheckBox
    Friend WithEvents P As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents C As Button
    Friend WithEvents SC As Button
End Class
