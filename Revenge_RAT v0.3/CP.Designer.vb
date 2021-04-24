<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CP))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Addd = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lim1 = New Revenge_RAT_v0._3.RevengeRAT.LIM()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.243697!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.7563!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(569, 357)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 26)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Addd, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(563, 26)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(522, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Addd
        '
        Me.Addd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addd.Dock = System.Windows.Forms.DockStyle.Right
        Me.Addd.Image = CType(resources.GetObject("Addd.Image"), System.Drawing.Image)
        Me.Addd.Location = New System.Drawing.Point(531, 3)
        Me.Addd.Name = "Addd"
        Me.Addd.Size = New System.Drawing.Size(29, 20)
        Me.Addd.TabIndex = 1
        Me.Addd.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Lim1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 35)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(563, 319)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Lim1
        '
        Me.Lim1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lim1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Lim1.FullRowSelect = True
        Me.Lim1.LargeImageList = Me.ImageList1
        Me.Lim1.Location = New System.Drawing.Point(3, 3)
        Me.Lim1.MultiSelect = False
        Me.Lim1.Name = "Lim1"
        Me.Lim1.Size = New System.Drawing.Size(557, 278)
        Me.Lim1.SmallImageList = Me.ImageList1
        Me.Lim1.TabIndex = 0
        Me.Lim1.UseCompatibleStateImageBehavior = False
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
        Me.ImageList1.Images.SetKeyName(12, "13.png")
        Me.ImageList1.Images.SetKeyName(13, "14.png")
        Me.ImageList1.Images.SetKeyName(14, "15.png")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 29)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 357)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CP"
        Me.Text = "Chat Display Picture Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Addd As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Lim1 As RevengeRAT.LIM
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
