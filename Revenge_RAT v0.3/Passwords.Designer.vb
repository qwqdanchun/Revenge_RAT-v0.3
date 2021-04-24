<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passwords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Passwords))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListView1 = New Revenge_RAT_v0._3.RevengeRAT.FXLSV()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListView1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(726, 257)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(720, 231)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "URL"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Password"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenURLToolStripMenuItem, Me.CopyUserToolStripMenuItem, Me.ToolStripMenuItem1, Me.CopyPasswordToolStripMenuItem, Me.SaveAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 120)
        '
        'OpenURLToolStripMenuItem
        '
        Me.OpenURLToolStripMenuItem.Image = CType(resources.GetObject("OpenURLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenURLToolStripMenuItem.Name = "OpenURLToolStripMenuItem"
        Me.OpenURLToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenURLToolStripMenuItem.Text = "Open URL"
        '
        'CopyUserToolStripMenuItem
        '
        Me.CopyUserToolStripMenuItem.Image = CType(resources.GetObject("CopyUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyUserToolStripMenuItem.Name = "CopyUserToolStripMenuItem"
        Me.CopyUserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CopyUserToolStripMenuItem.Text = "Copy User"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        '
        'CopyPasswordToolStripMenuItem
        '
        Me.CopyPasswordToolStripMenuItem.Image = CType(resources.GetObject("CopyPasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyPasswordToolStripMenuItem.Name = "CopyPasswordToolStripMenuItem"
        Me.CopyPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CopyPasswordToolStripMenuItem.Text = "Copy Password"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Image = CType(resources.GetObject("SaveAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 237)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(726, 20)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(130, 15)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(11, 15)
        Me.ToolStripStatusLabel1.Text = "."
        '
        'Passwords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 257)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(742, 296)
        Me.Name = "Passwords"
        Me.Text = "Passwords"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListView1 As RevengeRAT.FXLSV
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CopyPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
