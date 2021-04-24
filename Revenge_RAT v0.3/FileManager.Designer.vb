<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileManager))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Desktop", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Downloads", 2, 2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Documents", 3, 3)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Favorite", 5, 5)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pictures", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Startup", 7, 7)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AppData", 7, 7)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temp", 6, 6)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Quick Access", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My Computer", 8, 8)
        Me.UltimatumTabControl1 = New Revenge_RAT_v0._3.RevengeRAT.UltimatumTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Pathloc = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Re = New System.Windows.Forms.Button()
        Me.En = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.Fxtrv1 = New Revenge_RAT_v0._3.RevengeRAT.FXTRV()
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.Files = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HiddenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsAdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscoverWhatInsideRarFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadFileViaURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThumbnailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.SPath = New System.Windows.Forms.TextBox()
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.StartS = New System.Windows.Forms.Button()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.SearchFiles = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExecuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Download = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lim1 = New Revenge_RAT_v0._3.RevengeRAT.LIM()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip4 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Downloads = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DOP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveAllCompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDownloadFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.RF = New System.Windows.Forms.TextBox()
        Me.GRF = New System.Windows.Forms.Button()
        Me.ListView2 = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RARCM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Save = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextPath = New System.Windows.Forms.TextBox()
        Me.Go = New System.Windows.Forms.Button()
        Me.rat = New System.Windows.Forms.TextBox()
        Me.StatusStrip5 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.UltimatumTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.StatusStrip4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.DOP.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.RARCM.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.StatusStrip5.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltimatumTabControl1
        '
        Me.UltimatumTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.UltimatumTabControl1.Controls.Add(Me.TabPage1)
        Me.UltimatumTabControl1.Controls.Add(Me.TabPage2)
        Me.UltimatumTabControl1.Controls.Add(Me.TabPage6)
        Me.UltimatumTabControl1.Controls.Add(Me.TabPage3)
        Me.UltimatumTabControl1.Controls.Add(Me.TabPage4)
        Me.UltimatumTabControl1.Controls.Add(Me.TabPage5)
        Me.UltimatumTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltimatumTabControl1.ItemSize = New System.Drawing.Size(40, 170)
        Me.UltimatumTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltimatumTabControl1.Multiline = True
        Me.UltimatumTabControl1.Name = "UltimatumTabControl1"
        Me.UltimatumTabControl1.SelectedIndex = 0
        Me.UltimatumTabControl1.Size = New System.Drawing.Size(1049, 521)
        Me.UltimatumTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.UltimatumTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel6)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(174, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(871, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Computer"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.StatusStrip1, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(865, 507)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 26)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel9, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(859, 26)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 20)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(797, 20)
        Me.Panel3.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(797, 20)
        Me.Panel5.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Pathloc)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(797, 20)
        Me.Panel7.TabIndex = 0
        '
        'Pathloc
        '
        Me.Pathloc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pathloc.Location = New System.Drawing.Point(0, 0)
        Me.Pathloc.Name = "Pathloc"
        Me.Pathloc.Size = New System.Drawing.Size(797, 20)
        Me.Pathloc.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Re)
        Me.Panel9.Controls.Add(Me.En)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(806, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(50, 20)
        Me.Panel9.TabIndex = 1
        '
        'Re
        '
        Me.Re.Dock = System.Windows.Forms.DockStyle.Left
        Me.Re.Image = CType(resources.GetObject("Re.Image"), System.Drawing.Image)
        Me.Re.Location = New System.Drawing.Point(0, 0)
        Me.Re.Name = "Re"
        Me.Re.Size = New System.Drawing.Size(25, 20)
        Me.Re.TabIndex = 1
        Me.Re.UseVisualStyleBackColor = True
        '
        'En
        '
        Me.En.Dock = System.Windows.Forms.DockStyle.Right
        Me.En.Image = CType(resources.GetObject("En.Image"), System.Drawing.Image)
        Me.En.Location = New System.Drawing.Point(25, 0)
        Me.En.Name = "En"
        Me.En.Size = New System.Drawing.Size(25, 20)
        Me.En.TabIndex = 0
        Me.En.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel15, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 35)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(859, 450)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.Fxtrv1, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Files, 1, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 1
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(853, 444)
        Me.TableLayoutPanel15.TabIndex = 0
        '
        'Fxtrv1
        '
        Me.Fxtrv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fxtrv1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Fxtrv1.ImageIndex = 0
        Me.Fxtrv1.ImageList = Me.ImageList4
        Me.Fxtrv1.Location = New System.Drawing.Point(3, 3)
        Me.Fxtrv1.Name = "Fxtrv1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Node1"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Desktop"
        TreeNode2.ImageIndex = 2
        TreeNode2.Name = "Node2"
        TreeNode2.SelectedImageIndex = 2
        TreeNode2.Text = "Downloads"
        TreeNode3.ImageIndex = 3
        TreeNode3.Name = "Node3"
        TreeNode3.SelectedImageIndex = 3
        TreeNode3.Text = "Documents"
        TreeNode4.ImageIndex = 5
        TreeNode4.Name = "Node4"
        TreeNode4.SelectedImageIndex = 5
        TreeNode4.Text = "Favorite"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Node5"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Pictures"
        TreeNode6.ImageIndex = 7
        TreeNode6.Name = "Node6"
        TreeNode6.SelectedImageIndex = 7
        TreeNode6.Text = "Startup"
        TreeNode7.ImageIndex = 7
        TreeNode7.Name = "Node9"
        TreeNode7.SelectedImageIndex = 7
        TreeNode7.Text = "AppData"
        TreeNode8.ImageIndex = 6
        TreeNode8.Name = "Node11"
        TreeNode8.SelectedImageIndex = 6
        TreeNode8.Text = "Temp"
        TreeNode9.Name = "Node0"
        TreeNode9.SelectedImageIndex = 0
        TreeNode9.Text = "Quick Access"
        TreeNode10.ImageIndex = 8
        TreeNode10.Name = "Node12"
        TreeNode10.SelectedImageIndex = 8
        TreeNode10.Text = "My Computer"
        Me.Fxtrv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Me.Fxtrv1.SelectedImageIndex = 0
        Me.Fxtrv1.Size = New System.Drawing.Size(193, 438)
        Me.Fxtrv1.TabIndex = 0
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "1.png")
        Me.ImageList4.Images.SetKeyName(1, "2.png")
        Me.ImageList4.Images.SetKeyName(2, "3.png")
        Me.ImageList4.Images.SetKeyName(3, "4.png")
        Me.ImageList4.Images.SetKeyName(4, "5.png")
        Me.ImageList4.Images.SetKeyName(5, "6.png")
        Me.ImageList4.Images.SetKeyName(6, "7.png")
        Me.ImageList4.Images.SetKeyName(7, "8.png")
        Me.ImageList4.Images.SetKeyName(8, "9.png")
        Me.ImageList4.Images.SetKeyName(9, "10.png")
        Me.ImageList4.Images.SetKeyName(10, "11.png")
        Me.ImageList4.Images.SetKeyName(11, "12.png")
        Me.ImageList4.Images.SetKeyName(12, "13.png")
        Me.ImageList4.Images.SetKeyName(13, "14.png")
        Me.ImageList4.Images.SetKeyName(14, "15.png")
        '
        'Files
        '
        Me.Files.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader21})
        Me.Files.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Files.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Files.FullRowSelect = True
        Me.Files.GridLines = True
        Me.Files.LargeImageList = Me.ImageList1
        Me.Files.Location = New System.Drawing.Point(202, 3)
        Me.Files.Name = "Files"
        Me.Files.Size = New System.Drawing.Size(648, 438)
        Me.Files.SmallImageList = Me.ImageList1
        Me.Files.TabIndex = 1
        Me.Files.UseCompatibleStateImageBehavior = False
        Me.Files.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "LargeIcon"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Size :"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Type :"
        Me.ColumnHeader12.Width = 100
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Creation date :"
        Me.ColumnHeader16.Width = 100
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Last Access :"
        Me.ColumnHeader17.Width = 100
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Last Updated :"
        Me.ColumnHeader21.Width = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunToolStripMenuItem, Me.ViewToolStripMenuItem, Me.BackToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripMenuItem1, Me.RenameToolStripMenuItem, Me.Delete, Me.DiscoverWhatInsideRarFileToolStripMenuItem, Me.DownloadFileViaURLToolStripMenuItem, Me.ThumbnailsToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.ToolStripMenuItem2, Me.PropertiesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(219, 280)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.HiddenToolStripMenuItem, Me.AsAdministratorToolStripMenuItem})
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Image = CType(resources.GetObject("NormalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'HiddenToolStripMenuItem
        '
        Me.HiddenToolStripMenuItem.Image = CType(resources.GetObject("HiddenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HiddenToolStripMenuItem.Name = "HiddenToolStripMenuItem"
        Me.HiddenToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.HiddenToolStripMenuItem.Text = "Hidden"
        '
        'AsAdministratorToolStripMenuItem
        '
        Me.AsAdministratorToolStripMenuItem.Image = CType(resources.GetObject("AsAdministratorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AsAdministratorToolStripMenuItem.Name = "AsAdministratorToolStripMenuItem"
        Me.AsAdministratorToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AsAdministratorToolStripMenuItem.Text = "As administrator"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem, Me.LargeToolStripMenuItem, Me.TitleToolStripMenuItem, Me.ListToolStripMenuItem})
        Me.ViewToolStripMenuItem.Image = CType(resources.GetObject("ViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'LargeToolStripMenuItem
        '
        Me.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem"
        Me.LargeToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LargeToolStripMenuItem.Text = "Large"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.TitleToolStripMenuItem.Text = "Title"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Image = CType(resources.GetObject("BackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 6)
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Image = CType(resources.GetObject("RenameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'Delete
        '
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(218, 22)
        Me.Delete.Text = "Delete"
        '
        'DiscoverWhatInsideRarFileToolStripMenuItem
        '
        Me.DiscoverWhatInsideRarFileToolStripMenuItem.Image = CType(resources.GetObject("DiscoverWhatInsideRarFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DiscoverWhatInsideRarFileToolStripMenuItem.Name = "DiscoverWhatInsideRarFileToolStripMenuItem"
        Me.DiscoverWhatInsideRarFileToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DiscoverWhatInsideRarFileToolStripMenuItem.Text = "Discover what inside rar file"
        '
        'DownloadFileViaURLToolStripMenuItem
        '
        Me.DownloadFileViaURLToolStripMenuItem.Image = CType(resources.GetObject("DownloadFileViaURLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadFileViaURLToolStripMenuItem.Name = "DownloadFileViaURLToolStripMenuItem"
        Me.DownloadFileViaURLToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DownloadFileViaURLToolStripMenuItem.Text = "Download file via URL"
        '
        'ThumbnailsToolStripMenuItem
        '
        Me.ThumbnailsToolStripMenuItem.Image = CType(resources.GetObject("ThumbnailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThumbnailsToolStripMenuItem.Name = "ThumbnailsToolStripMenuItem"
        Me.ThumbnailsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ThumbnailsToolStripMenuItem.Text = "Thumbnails"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.Image = CType(resources.GetObject("DownloadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Image = CType(resources.GetObject("UploadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(215, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = CType(resources.GetObject("PropertiesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "01.png")
        Me.ImageList1.Images.SetKeyName(1, "02.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 488)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(865, 19)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 14)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(12, 14)
        Me.ToolStripStatusLabel3.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 14)
        Me.ToolStripStatusLabel2.Text = "-"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(12, 14)
        Me.ToolStripStatusLabel1.Text = "-"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(174, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(871, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search File"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel9, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(865, 507)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TableLayoutPanel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(859, 60)
        Me.Panel6.TabIndex = 0
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.34816!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.32005!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.343711!))
        Me.TableLayoutPanel7.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.StartS, 2, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(859, 60)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(82, 54)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "  Search Path :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Name :"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.SPath, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.FileName, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(91, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(692, 54)
        Me.TableLayoutPanel8.TabIndex = 1
        '
        'SPath
        '
        Me.SPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SPath.Location = New System.Drawing.Point(3, 3)
        Me.SPath.Name = "SPath"
        Me.SPath.Size = New System.Drawing.Size(686, 20)
        Me.SPath.TabIndex = 0
        Me.SPath.Text = "C:\"
        '
        'FileName
        '
        Me.FileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileName.Location = New System.Drawing.Point(3, 30)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(686, 20)
        Me.FileName.TabIndex = 1
        Me.FileName.Text = "*.jpg"
        '
        'StartS
        '
        Me.StartS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartS.Image = CType(resources.GetObject("StartS.Image"), System.Drawing.Image)
        Me.StartS.Location = New System.Drawing.Point(789, 3)
        Me.StartS.Name = "StartS"
        Me.StartS.Size = New System.Drawing.Size(67, 54)
        Me.StartS.TabIndex = 2
        Me.StartS.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.SearchFiles, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.StatusStrip2, 0, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 69)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.48276!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.517241!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(859, 435)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'SearchFiles
        '
        Me.SearchFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.SearchFiles.ContextMenuStrip = Me.ContextMenuStrip2
        Me.SearchFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchFiles.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SearchFiles.FullRowSelect = True
        Me.SearchFiles.GridLines = True
        Me.SearchFiles.LargeImageList = Me.ImageList1
        Me.SearchFiles.Location = New System.Drawing.Point(3, 3)
        Me.SearchFiles.Name = "SearchFiles"
        Me.SearchFiles.Size = New System.Drawing.Size(853, 404)
        Me.SearchFiles.SmallImageList = Me.ImageList1
        Me.SearchFiles.TabIndex = 0
        Me.SearchFiles.UseCompatibleStateImageBehavior = False
        Me.SearchFiles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "File Path :"
        Me.ColumnHeader5.Width = 755
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Size :"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExecuteToolStripMenuItem, Me.Download})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(129, 48)
        '
        'ExecuteToolStripMenuItem
        '
        Me.ExecuteToolStripMenuItem.Image = CType(resources.GetObject("ExecuteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExecuteToolStripMenuItem.Name = "ExecuteToolStripMenuItem"
        Me.ExecuteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExecuteToolStripMenuItem.Text = "Execute"
        '
        'Download
        '
        Me.Download.Image = CType(resources.GetObject("Download.Image"), System.Drawing.Image)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(128, 22)
        Me.Download.Text = "Download"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel6})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 413)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(136, 17)
        Me.ToolStripStatusLabel6.Text = "Ready to any command!"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel14)
        Me.TabPage6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TabPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(174, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(871, 513)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Thumbnails"
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.Lim1, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.StatusStrip4, 0, 1)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(865, 507)
        Me.TableLayoutPanel14.TabIndex = 0
        '
        'Lim1
        '
        Me.Lim1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lim1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Lim1.FullRowSelect = True
        Me.Lim1.LargeImageList = Me.ImageList3
        Me.Lim1.Location = New System.Drawing.Point(3, 3)
        Me.Lim1.Name = "Lim1"
        Me.Lim1.Size = New System.Drawing.Size(859, 481)
        Me.Lim1.SmallImageList = Me.ImageList3
        Me.Lim1.TabIndex = 0
        Me.Lim1.UseCompatibleStateImageBehavior = False
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(150, 156)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusStrip4
        '
        Me.StatusStrip4.BackColor = System.Drawing.Color.White
        Me.StatusStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5})
        Me.StatusStrip4.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip4.Name = "StatusStrip4"
        Me.StatusStrip4.Size = New System.Drawing.Size(865, 20)
        Me.StatusStrip4.TabIndex = 1
        Me.StatusStrip4.Text = "StatusStrip3"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(88, 15)
        Me.ToolStripStatusLabel5.Text = "Total items ( 0 )"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Downloads)
        Me.TabPage3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(174, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(871, 513)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Transfer Files"
        '
        'Downloads
        '
        Me.Downloads.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.Downloads.ContextMenuStrip = Me.DOP
        Me.Downloads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Downloads.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Downloads.FullRowSelect = True
        Me.Downloads.GridLines = True
        Me.Downloads.LargeImageList = Me.ImageList1
        Me.Downloads.Location = New System.Drawing.Point(3, 3)
        Me.Downloads.Name = "Downloads"
        Me.Downloads.Size = New System.Drawing.Size(865, 507)
        Me.Downloads.SmallImageList = Me.ImageList1
        Me.Downloads.TabIndex = 0
        Me.Downloads.UseCompatibleStateImageBehavior = False
        Me.Downloads.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Name :"
        Me.ColumnHeader14.Width = 125
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "File Size :"
        Me.ColumnHeader15.Width = 125
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "File Type :"
        Me.ColumnHeader18.Width = 125
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Progress :"
        Me.ColumnHeader19.Width = 125
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Status :"
        Me.ColumnHeader20.Width = 125
        '
        'DOP
        '
        Me.DOP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResumeToolStripMenuItem, Me.ToolStripMenuItem3, Me.RemoveAllCompletedToolStripMenuItem, Me.OpenDownloadFolderToolStripMenuItem})
        Me.DOP.Name = "DOP"
        Me.DOP.Size = New System.Drawing.Size(197, 120)
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = CType(resources.GetObject("StopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Image = CType(resources.GetObject("PauseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PauseToolStripMenuItem.Text = "Suspend"
        '
        'ResumeToolStripMenuItem
        '
        Me.ResumeToolStripMenuItem.Image = CType(resources.GetObject("ResumeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem"
        Me.ResumeToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ResumeToolStripMenuItem.Text = "Continue"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(193, 6)
        '
        'RemoveAllCompletedToolStripMenuItem
        '
        Me.RemoveAllCompletedToolStripMenuItem.Image = CType(resources.GetObject("RemoveAllCompletedToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveAllCompletedToolStripMenuItem.Name = "RemoveAllCompletedToolStripMenuItem"
        Me.RemoveAllCompletedToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RemoveAllCompletedToolStripMenuItem.Text = "Remove All Completed"
        '
        'OpenDownloadFolderToolStripMenuItem
        '
        Me.OpenDownloadFolderToolStripMenuItem.Image = CType(resources.GetObject("OpenDownloadFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenDownloadFolderToolStripMenuItem.Name = "OpenDownloadFolderToolStripMenuItem"
        Me.OpenDownloadFolderToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OpenDownloadFolderToolStripMenuItem.Text = "Open Download Folder"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.TableLayoutPanel10)
        Me.TabPage4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TabPage4.Location = New System.Drawing.Point(174, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(871, 513)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Discover RAR File"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel13, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.ListView2, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.StatusStrip3, 0, 2)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 3
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(865, 507)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.RF, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.GRF, 1, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(859, 27)
        Me.TableLayoutPanel13.TabIndex = 0
        '
        'RF
        '
        Me.RF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RF.Location = New System.Drawing.Point(3, 3)
        Me.RF.Name = "RF"
        Me.RF.Size = New System.Drawing.Size(821, 20)
        Me.RF.TabIndex = 0
        '
        'GRF
        '
        Me.GRF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRF.Image = CType(resources.GetObject("GRF.Image"), System.Drawing.Image)
        Me.GRF.Location = New System.Drawing.Point(830, 3)
        Me.GRF.Name = "GRF"
        Me.GRF.Size = New System.Drawing.Size(26, 21)
        Me.GRF.TabIndex = 1
        Me.GRF.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView2.ContextMenuStrip = Me.RARCM
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Enabled = False
        Me.ListView2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.LargeImageList = Me.ImageList1
        Me.ListView2.Location = New System.Drawing.Point(3, 36)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(859, 448)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name :"
        Me.ColumnHeader1.Width = 570
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size :"
        Me.ColumnHeader2.Width = 80
        '
        'RARCM
        '
        Me.RARCM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1})
        Me.RARCM.Name = "RARCM"
        Me.RARCM.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = CType(resources.GetObject("RefreshToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'StatusStrip3
        '
        Me.StatusStrip3.BackColor = System.Drawing.Color.White
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel7})
        Me.StatusStrip3.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(865, 20)
        Me.StatusStrip3.TabIndex = 2
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(136, 15)
        Me.ToolStripStatusLabel7.Text = "Ready to any command!"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.TableLayoutPanel11)
        Me.TabPage5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TabPage5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(174, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(871, 513)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Read Text File"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.Panel8, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.rat, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.StatusStrip5, 0, 2)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 3
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(865, 507)
        Me.TableLayoutPanel11.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TableLayoutPanel12)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(859, 29)
        Me.Panel8.TabIndex = 0
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 3
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Save, 2, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Panel10, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Go, 1, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(859, 29)
        Me.TableLayoutPanel12.TabIndex = 0
        '
        'Save
        '
        Me.Save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.Location = New System.Drawing.Point(834, 3)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(22, 23)
        Me.Save.TabIndex = 2
        Me.Save.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TextPath)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(792, 23)
        Me.Panel10.TabIndex = 0
        '
        'TextPath
        '
        Me.TextPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextPath.Location = New System.Drawing.Point(0, 0)
        Me.TextPath.Multiline = True
        Me.TextPath.Name = "TextPath"
        Me.TextPath.Size = New System.Drawing.Size(792, 23)
        Me.TextPath.TabIndex = 0
        '
        'Go
        '
        Me.Go.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Go.Image = CType(resources.GetObject("Go.Image"), System.Drawing.Image)
        Me.Go.Location = New System.Drawing.Point(801, 3)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(27, 23)
        Me.Go.TabIndex = 1
        Me.Go.UseVisualStyleBackColor = True
        '
        'rat
        '
        Me.rat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rat.Enabled = False
        Me.rat.Location = New System.Drawing.Point(3, 38)
        Me.rat.Multiline = True
        Me.rat.Name = "rat"
        Me.rat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rat.Size = New System.Drawing.Size(859, 446)
        Me.rat.TabIndex = 1
        '
        'StatusStrip5
        '
        Me.StatusStrip5.BackColor = System.Drawing.Color.White
        Me.StatusStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel9})
        Me.StatusStrip5.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip5.Name = "StatusStrip5"
        Me.StatusStrip5.Size = New System.Drawing.Size(865, 20)
        Me.StatusStrip5.TabIndex = 2
        Me.StatusStrip5.Text = "StatusStrip5"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(136, 15)
        Me.ToolStripStatusLabel9.Text = "Ready to any command!"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "1.png")
        Me.ImageList2.Images.SetKeyName(1, "2.png")
        Me.ImageList2.Images.SetKeyName(2, "3.png")
        Me.ImageList2.Images.SetKeyName(3, "4.png")
        Me.ImageList2.Images.SetKeyName(4, "5.png")
        Me.ImageList2.Images.SetKeyName(5, "6.png")
        Me.ImageList2.Images.SetKeyName(6, "7.png")
        Me.ImageList2.Images.SetKeyName(7, "8.png")
        '
        'FileManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1049, 521)
        Me.Controls.Add(Me.UltimatumTabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1065, 560)
        Me.Name = "FileManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileManager"
        Me.UltimatumTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.StatusStrip4.ResumeLayout(False)
        Me.StatusStrip4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.DOP.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.RARCM.ResumeLayout(False)
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.StatusStrip5.ResumeLayout(False)
        Me.StatusStrip5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltimatumTabControl1 As RevengeRAT.UltimatumTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Pathloc As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents En As Button
    Friend WithEvents Re As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Fxtrv1 As RevengeRAT.FXTRV
    Friend WithEvents ImageList4 As ImageList
    Friend WithEvents Files As RevengeRAT.FXLSV
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HiddenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsAdministratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Delete As ToolStripMenuItem
    Friend WithEvents DiscoverWhatInsideRarFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadFileViaURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThumbnailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents SPath As TextBox
    Friend WithEvents FileName As TextBox
    Friend WithEvents StartS As Button
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents SearchFiles As RevengeRAT.FXLSV
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ExecuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Download As ToolStripMenuItem
    Friend WithEvents DOP As ContextMenuStrip
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents RemoveAllCompletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDownloadFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents RARCM As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents Lim1 As RevengeRAT.LIM
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents StatusStrip4 As StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Downloads As RevengeRAT.FXLSV
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents RF As TextBox
    Friend WithEvents GRF As Button
    Friend WithEvents ListView2 As RevengeRAT.FXLSV
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents StatusStrip3 As StatusStrip
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextPath As TextBox
    Friend WithEvents Save As Button
    Friend WithEvents Go As Button
    Friend WithEvents rat As TextBox
    Friend WithEvents StatusStrip5 As StatusStrip
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
    Friend WithEvents ImageList2 As ImageList
End Class
