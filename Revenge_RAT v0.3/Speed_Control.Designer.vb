<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Speed_Control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Speed_Control))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File Manager", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Manager", 3, 3)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hosts File Manager", 4, 4)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manager", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Screen Capture", 6, 6)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Command Prompt", 10, 10)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Surveillance", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chat", 9, 9)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fun", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notes", 11, 11)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"System Information"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Windows Version")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CPU Model")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("PC Name")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Current User")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Account Type")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Country")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Default Language")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Security Software"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Antivirus")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Firewall")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Antispyware")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Memory Status"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Total Physical")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Free Physical")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Used Physical")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Total Virtual")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Free Virtual")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Used Virtual")
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ResultCMD = New System.Windows.Forms.TextBox()
        Me.Commands = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Fxtrv1 = New Revenge_RAT_v0._3.RevengeRAT.FXTRV()
        Me.Fxlsv1 = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fxlsv2 = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fxlsv3 = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.StatusStrip1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0295!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.970497!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(809, 461)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 631.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Fxtrv1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(803, 432)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1.png")
        Me.ImageList1.Images.SetKeyName(1, "2.png")
        Me.ImageList1.Images.SetKeyName(2, "3.png")
        Me.ImageList1.Images.SetKeyName(3, "4.png")
        Me.ImageList1.Images.SetKeyName(4, "5.png")
        Me.ImageList1.Images.SetKeyName(5, "6.png")
        Me.ImageList1.Images.SetKeyName(6, "7.png")
        Me.ImageList1.Images.SetKeyName(7, "8.png")
        Me.ImageList1.Images.SetKeyName(8, "9.png")
        Me.ImageList1.Images.SetKeyName(9, "10.png")
        Me.ImageList1.Images.SetKeyName(10, "11.png")
        Me.ImageList1.Images.SetKeyName(11, "12.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(175, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(625, 426)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(617, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "System Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Fxlsv1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(611, 394)
        Me.Panel3.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem2, Me.SaveAsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 48)
        '
        'RefreshToolStripMenuItem2
        '
        Me.RefreshToolStripMenuItem2.Image = CType(resources.GetObject("RefreshToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
        Me.RefreshToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.RefreshToolStripMenuItem2.Text = "Refresh"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = CType(resources.GetObject("SaveAsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "16.png")
        Me.ImageList2.Images.SetKeyName(1, "17.png")
        Me.ImageList2.Images.SetKeyName(2, "18.png")
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(617, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "File Manager"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(611, 394)
        Me.Panel4.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Fxlsv2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(611, 394)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(605, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.RunToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(114, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem1.Text = "Refresh"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "19.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ".."
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Fxlsv3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(617, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Process Manager"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(114, 48)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem2.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem3.Text = "Kill"
        '
        'ImageList4
        '
        Me.ImageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList4.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(617, 400)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Hosts File"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(611, 394)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(605, 362)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Location = New System.Drawing.Point(3, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(617, 400)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Screen Capture"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Button2, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(611, 394)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(605, 360)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage6.Controls.Add(Me.ResultCMD)
        Me.TabPage6.Controls.Add(Me.Commands)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(617, 400)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Command Prompt"
        '
        'ResultCMD
        '
        Me.ResultCMD.BackColor = System.Drawing.Color.Black
        Me.ResultCMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultCMD.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ResultCMD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultCMD.ForeColor = System.Drawing.Color.White
        Me.ResultCMD.Location = New System.Drawing.Point(3, 3)
        Me.ResultCMD.Multiline = True
        Me.ResultCMD.Name = "ResultCMD"
        Me.ResultCMD.ReadOnly = True
        Me.ResultCMD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ResultCMD.Size = New System.Drawing.Size(611, 373)
        Me.ResultCMD.TabIndex = 2
        '
        'Commands
        '
        Me.Commands.BackColor = System.Drawing.Color.White
        Me.Commands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Commands.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Commands.Location = New System.Drawing.Point(3, 376)
        Me.Commands.Name = "Commands"
        Me.Commands.Size = New System.Drawing.Size(611, 21)
        Me.Commands.TabIndex = 1
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage7.Controls.Add(Me.TableLayoutPanel6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(617, 400)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Chat"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox3, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(611, 394)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(605, 362)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Location = New System.Drawing.Point(3, 371)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(605, 21)
        Me.TextBox3.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage8.Controls.Add(Me.TextBox4)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(617, 400)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Notes"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Location = New System.Drawing.Point(3, 3)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(611, 394)
        Me.TextBox4.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(809, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "Hello Sir!"
        '
        'Fxtrv1
        '
        Me.Fxtrv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fxtrv1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Fxtrv1.ImageIndex = 0
        Me.Fxtrv1.ImageList = Me.ImageList1
        Me.Fxtrv1.Location = New System.Drawing.Point(3, 3)
        Me.Fxtrv1.Name = "Fxtrv1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Node"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "File Manager"
        TreeNode2.ImageIndex = 3
        TreeNode2.Name = "Node3"
        TreeNode2.SelectedImageIndex = 3
        TreeNode2.Text = "Process Manager"
        TreeNode3.ImageIndex = 4
        TreeNode3.Name = "Node4"
        TreeNode3.SelectedImageIndex = 4
        TreeNode3.Text = "Hosts File Manager"
        TreeNode4.ImageIndex = 0
        TreeNode4.Name = "Node5"
        TreeNode4.SelectedImageIndex = 0
        TreeNode4.Text = "Manager"
        TreeNode5.ImageIndex = 6
        TreeNode5.Name = "Node6"
        TreeNode5.SelectedImageIndex = 6
        TreeNode5.Text = "Screen Capture"
        TreeNode6.ImageIndex = 10
        TreeNode6.Name = "Node7"
        TreeNode6.SelectedImageIndex = 10
        TreeNode6.Text = "Command Prompt"
        TreeNode7.ImageIndex = 5
        TreeNode7.Name = "Node8"
        TreeNode7.SelectedImageIndex = 5
        TreeNode7.Text = "Surveillance"
        TreeNode8.ImageIndex = 9
        TreeNode8.Name = "Node9"
        TreeNode8.SelectedImageIndex = 9
        TreeNode8.Text = "Chat"
        TreeNode9.ImageIndex = 8
        TreeNode9.Name = "Node10"
        TreeNode9.SelectedImageIndex = 8
        TreeNode9.Text = "Fun"
        TreeNode10.ImageIndex = 11
        TreeNode10.Name = "Node2"
        TreeNode10.SelectedImageIndex = 11
        TreeNode10.Text = "Notes"
        Me.Fxtrv1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode7, TreeNode9, TreeNode10})
        Me.Fxtrv1.SelectedImageIndex = 0
        Me.Fxtrv1.Size = New System.Drawing.Size(158, 426)
        Me.Fxtrv1.TabIndex = 0
        '
        'Fxlsv1
        '
        Me.Fxlsv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Fxlsv1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Fxlsv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fxlsv1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Fxlsv1.FullRowSelect = True
        Me.Fxlsv1.GridLines = True
        Me.Fxlsv1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21})
        Me.Fxlsv1.LargeImageList = Me.ImageList2
        Me.Fxlsv1.Location = New System.Drawing.Point(0, 0)
        Me.Fxlsv1.Name = "Fxlsv1"
        Me.Fxlsv1.Size = New System.Drawing.Size(611, 394)
        Me.Fxlsv1.SmallImageList = Me.ImageList2
        Me.Fxlsv1.TabIndex = 0
        Me.Fxlsv1.UseCompatibleStateImageBehavior = False
        Me.Fxlsv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 187
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Data"
        Me.ColumnHeader2.Width = 252
        '
        'Fxlsv2
        '
        Me.Fxlsv2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.Fxlsv2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Fxlsv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fxlsv2.Enabled = False
        Me.Fxlsv2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Fxlsv2.FullRowSelect = True
        Me.Fxlsv2.GridLines = True
        Me.Fxlsv2.LargeImageList = Me.ImageList3
        Me.Fxlsv2.Location = New System.Drawing.Point(3, 27)
        Me.Fxlsv2.Name = "Fxlsv2"
        Me.Fxlsv2.Size = New System.Drawing.Size(605, 347)
        Me.Fxlsv2.SmallImageList = Me.ImageList3
        Me.Fxlsv2.TabIndex = 1
        Me.Fxlsv2.UseCompatibleStateImageBehavior = False
        Me.Fxlsv2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "File Name :"
        Me.ColumnHeader3.Width = 307
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size :"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Last Access Time :"
        Me.ColumnHeader5.Width = 136
        '
        'Fxlsv3
        '
        Me.Fxlsv3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.Fxlsv3.ContextMenuStrip = Me.ContextMenuStrip3
        Me.Fxlsv3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fxlsv3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Fxlsv3.FullRowSelect = True
        Me.Fxlsv3.GridLines = True
        Me.Fxlsv3.LargeImageList = Me.ImageList4
        Me.Fxlsv3.Location = New System.Drawing.Point(3, 3)
        Me.Fxlsv3.Name = "Fxlsv3"
        Me.Fxlsv3.Size = New System.Drawing.Size(611, 394)
        Me.Fxlsv3.SmallImageList = Me.ImageList4
        Me.Fxlsv3.TabIndex = 0
        Me.Fxlsv3.UseCompatibleStateImageBehavior = False
        Me.Fxlsv3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Process Name :"
        Me.ColumnHeader10.Width = 185
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Process PID :"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Window Title :"
        Me.ColumnHeader12.Width = 150
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Creation Date :"
        Me.ColumnHeader13.Width = 150
        '
        'Speed_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 461)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(825, 500)
        Me.Name = "Speed_Control"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Speed_Control"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Fxtrv1 As RevengeRAT.FXTRV
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Fxlsv1 As RevengeRAT.FXLSV
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ImageList4 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Fxlsv2 As RevengeRAT.FXLSV
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Fxlsv3 As RevengeRAT.FXLSV
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ResultCMD As TextBox
    Friend WithEvents Commands As TextBox
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
End Class
