<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Torrent_Seeder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Torrent_Seeder))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Clients = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CLogs = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SW = New System.Windows.Forms.ComboBox()
        Me.Seed = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(829, 572)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Clients, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CLogs, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.9877!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.0123!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(823, 526)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Clients
        '
        Me.Clients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Clients.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Clients.FullRowSelect = True
        Me.Clients.GridLines = True
        Me.Clients.LargeImageList = Me.ImageList1
        Me.Clients.Location = New System.Drawing.Point(3, 3)
        Me.Clients.Name = "Clients"
        Me.Clients.Size = New System.Drawing.Size(817, 398)
        Me.Clients.SmallImageList = Me.ImageList1
        Me.Clients.TabIndex = 0
        Me.Clients.UseCompatibleStateImageBehavior = False
        Me.Clients.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Clients"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Exists"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "006.png")
        '
        'CLogs
        '
        Me.CLogs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.CLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CLogs.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CLogs.FullRowSelect = True
        Me.CLogs.GridLines = True
        Me.CLogs.Location = New System.Drawing.Point(3, 407)
        Me.CLogs.Name = "CLogs"
        Me.CLogs.Size = New System.Drawing.Size(817, 116)
        Me.CLogs.TabIndex = 1
        Me.CLogs.UseCompatibleStateImageBehavior = False
        Me.CLogs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Logs :"
        Me.ColumnHeader3.Width = 750
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Seed, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 535)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(823, 26)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 20)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seed with :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SW)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(83, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 20)
        Me.Panel2.TabIndex = 1
        '
        'SW
        '
        Me.SW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SW.FormattingEnabled = True
        Me.SW.Items.AddRange(New Object() {"Utorrent", "BitTorrent", "Bot"})
        Me.SW.Location = New System.Drawing.Point(0, -1)
        Me.SW.Name = "SW"
        Me.SW.Size = New System.Drawing.Size(661, 21)
        Me.SW.TabIndex = 0
        '
        'Seed
        '
        Me.Seed.Location = New System.Drawing.Point(750, 3)
        Me.Seed.Name = "Seed"
        Me.Seed.Size = New System.Drawing.Size(70, 20)
        Me.Seed.TabIndex = 2
        Me.Seed.Text = "Seed"
        Me.Seed.UseVisualStyleBackColor = True
        '
        'Torrent_Seeder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(829, 572)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(845, 610)
        Me.Name = "Torrent_Seeder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Torrent_Seeder"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Clients As RevengeRAT.FXLSV
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents CLogs As RevengeRAT.FXLSV
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SW As ComboBox
    Friend WithEvents Seed As Button
End Class
