<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BLogs))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Logs = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OK = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Logs, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.71848!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.28153!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(435, 229)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Logs
        '
        Me.Logs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Logs.Location = New System.Drawing.Point(3, 3)
        Me.Logs.Name = "Logs"
        Me.Logs.ReadOnly = True
        Me.Logs.Size = New System.Drawing.Size(429, 188)
        Me.Logs.TabIndex = 0
        Me.Logs.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 29)
        Me.Panel1.TabIndex = 1
        '
        'OK
        '
        Me.OK.Enabled = False
        Me.OK.Location = New System.Drawing.Point(275, 3)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(87, 23)
        Me.OK.TabIndex = 0
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'BLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 229)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(451, 268)
        Me.MinimumSize = New System.Drawing.Size(451, 268)
        Me.Name = "BLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BLogs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Logs As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OK As Button
End Class
