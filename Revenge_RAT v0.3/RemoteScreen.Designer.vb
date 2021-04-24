<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RemoteScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteScreen))
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProgressBar1 = New Revenge_RAT_v0._3.RevengeRAT.SocketServer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CO = New System.Windows.Forms.Panel()
        Me.D = New System.Windows.Forms.ComboBox()
        Me.ST = New System.Windows.Forms.Button()
        Me.DL = New System.Windows.Forms.Button()
        Me.FE = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenATerminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripSeparator()
        Me.M = New System.Windows.Forms.ToolStripMenuItem()
        Me.KE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SA = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Q = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SH = New System.Windows.Forms.Button()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CO.SuspendLayout()
        Me.FE.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Q, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ProgressBar1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(701, 388)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(14, 382)
        Me.ProgressBar1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(675, 382)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.CO)
        Me.Panel2.Controls.Add(Me.SH)
        Me.Panel2.Controls.Add(Me.P1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(669, 376)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 3
        '
        'CO
        '
        Me.CO.Controls.Add(Me.D)
        Me.CO.Controls.Add(Me.ST)
        Me.CO.Controls.Add(Me.DL)
        Me.CO.Controls.Add(Me.TableLayoutPanel2)
        Me.CO.Location = New System.Drawing.Point(246, 0)
        Me.CO.Name = "CO"
        Me.CO.Size = New System.Drawing.Size(228, 60)
        Me.CO.TabIndex = 2
        Me.CO.Visible = False
        '
        'D
        '
        Me.D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.D.FormattingEnabled = True
        Me.D.Location = New System.Drawing.Point(3, 5)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(172, 21)
        Me.D.TabIndex = 3
        '
        'ST
        '
        Me.ST.Location = New System.Drawing.Point(181, 4)
        Me.ST.Name = "ST"
        Me.ST.Size = New System.Drawing.Size(44, 22)
        Me.ST.TabIndex = 2
        Me.ST.Tag = "0"
        Me.ST.Text = "Start"
        Me.ST.UseVisualStyleBackColor = True
        '
        'DL
        '
        Me.DL.ContextMenuStrip = Me.FE
        Me.DL.Image = CType(resources.GetObject("DL.Image"), System.Drawing.Image)
        Me.DL.Location = New System.Drawing.Point(181, 29)
        Me.DL.Name = "DL"
        Me.DL.Size = New System.Drawing.Size(44, 25)
        Me.DL.TabIndex = 1
        Me.DL.Tag = "0"
        Me.DL.UseVisualStyleBackColor = True
        '
        'FE
        '
        Me.FE.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenATerminalToolStripMenuItem, Me.OpenTaskManagerToolStripMenuItem, Me.OpenFileExplorerToolStripMenuItem, Me.ToolStripComboBox1, Me.M, Me.KE, Me.MN, Me.ToolStripMenuItem1, Me.SA, Me.HideToolStripMenuItem})
        Me.FE.Name = "FE"
        Me.FE.Size = New System.Drawing.Size(178, 192)
        '
        'OpenATerminalToolStripMenuItem
        '
        Me.OpenATerminalToolStripMenuItem.Image = CType(resources.GetObject("OpenATerminalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenATerminalToolStripMenuItem.Name = "OpenATerminalToolStripMenuItem"
        Me.OpenATerminalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OpenATerminalToolStripMenuItem.Text = "Open a terminal"
        '
        'OpenTaskManagerToolStripMenuItem
        '
        Me.OpenTaskManagerToolStripMenuItem.Image = CType(resources.GetObject("OpenTaskManagerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenTaskManagerToolStripMenuItem.Name = "OpenTaskManagerToolStripMenuItem"
        Me.OpenTaskManagerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OpenTaskManagerToolStripMenuItem.Text = "Open task manager"
        '
        'OpenFileExplorerToolStripMenuItem
        '
        Me.OpenFileExplorerToolStripMenuItem.Image = CType(resources.GetObject("OpenFileExplorerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenFileExplorerToolStripMenuItem.Name = "OpenFileExplorerToolStripMenuItem"
        Me.OpenFileExplorerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OpenFileExplorerToolStripMenuItem.Text = "Open file explorer"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(174, 6)
        '
        'M
        '
        Me.M.Image = CType(resources.GetObject("M.Image"), System.Drawing.Image)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(177, 22)
        Me.M.Tag = "0"
        Me.M.Text = "Mouse"
        '
        'KE
        '
        Me.KE.Image = CType(resources.GetObject("KE.Image"), System.Drawing.Image)
        Me.KE.Name = "KE"
        Me.KE.Size = New System.Drawing.Size(177, 22)
        Me.KE.Tag = "0"
        Me.KE.Text = "Keyboard"
        '
        'MN
        '
        Me.MN.Image = CType(resources.GetObject("MN.Image"), System.Drawing.Image)
        Me.MN.Name = "MN"
        Me.MN.Size = New System.Drawing.Size(177, 22)
        Me.MN.Tag = "0"
        Me.MN.Text = "Full Screen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'SA
        '
        Me.SA.Image = CType(resources.GetObject("SA.Image"), System.Drawing.Image)
        Me.SA.Name = "SA"
        Me.SA.Size = New System.Drawing.Size(177, 22)
        Me.SA.Text = "Auto Save"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Image = CType(resources.GetObject("HideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Q, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 31)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(172, 23)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Q
        '
        Me.Q.Location = New System.Drawing.Point(3, 3)
        Me.Q.Maximum = 100
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(114, 17)
        Me.Q.TabIndex = 0
        Me.Q.Value = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(123, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(46, 17)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "100%"
        '
        'SH
        '
        Me.SH.Location = New System.Drawing.Point(335, 60)
        Me.SH.Name = "SH"
        Me.SH.Size = New System.Drawing.Size(53, 22)
        Me.SH.TabIndex = 1
        Me.SH.Tag = "0"
        Me.SH.Text = "Show"
        Me.SH.UseVisualStyleBackColor = True
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Black
        Me.P1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P1.Location = New System.Drawing.Point(0, 0)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(669, 376)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'RemoteScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 388)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(717, 427)
        Me.Name = "RemoteScreen"
        Me.Text = "RemoteScreen"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CO.ResumeLayout(False)
        Me.FE.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Q, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ProgressBar1 As RevengeRAT.SocketServer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents P1 As PictureBox
    Friend WithEvents SH As Button
    Friend WithEvents CO As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Q As TrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DL As Button
    Friend WithEvents FE As ContextMenuStrip
    Friend WithEvents OpenATerminalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripSeparator
    Friend WithEvents M As ToolStripMenuItem
    Friend WithEvents KE As ToolStripMenuItem
    Friend WithEvents MN As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SA As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ST As Button
    Friend WithEvents D As ComboBox
    Friend WithEvents Label3 As Label
End Class
