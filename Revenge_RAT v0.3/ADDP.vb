Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Imaging
Imports System.IO
Public Class ADDP
    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Try
            If Not Directory.Exists((Application.StartupPath & "\User Plugins\")) Then
                Directory.CreateDirectory((Application.StartupPath & "\User Plugins\"))
            End If
            File.Copy(Me.PP.Text, (Application.StartupPath & "\User Plugins\" & Path.GetFileName(Me.PP.Text)), True)
            Dim stream As New MemoryStream
            Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Me.PP.Text)
            Icon.ExtractAssociatedIcon(Me.PP.Text).ToBitmap.Save(stream, ImageFormat.Png)
            My.Forms.Main.ILP.Images.Add(versionInfo.LegalTrademarks, Image.FromStream(New MemoryStream(stream.ToArray)))
            Dim item As ListViewItem = My.Forms.Main.Plugin.Items.Add(versionInfo.LegalTrademarks, versionInfo.LegalTrademarks, versionInfo.LegalTrademarks)
            item.SubItems.Add(versionInfo.CompanyName)
            item.SubItems.Add(versionInfo.FileDescription)
            item.ToolTipText = (Application.StartupPath & "\User Plugins\" & Path.GetFileName(Me.PP.Text))
            Dim item2 As New ToolStripMenuItem(versionInfo.LegalTrademarks)
            Dim original As New Bitmap(My.Forms.Main.ILP.Images.Item(My.Forms.Main.ILP.Images.IndexOfKey(versionInfo.LegalTrademarks)))
            Dim newSize As New Size(&H10, &H10)
            Dim bitmap2 As New Bitmap(original, newSize)
            item2.Tag = (Application.StartupPath & "\User Plugins\" & Path.GetFileName(Me.PP.Text))
            item2.Image = bitmap2
            item2.Name = (Application.StartupPath & "\User Plugins\" & Path.GetFileName(Me.PP.Text))
            My.Forms.Main.ContextMenuStrip1.Items.Add(item2)
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ProjectData.ClearProjectError()
            Return
            ProjectData.ClearProjectError()
        End Try
        Me.Close()
    End Sub

    Private Sub MECL_Click(sender As Object, e As EventArgs) Handles MECL.Click
        Me.Close()
    End Sub

    Private Sub SelectPlugin_Click(sender As Object, e As EventArgs) Handles SelectPlugin.Click
        Dim dialog As New OpenFileDialog
        Dim dialog2 As OpenFileDialog = dialog
        dialog.Title = "Select your plugin"
        dialog.Filter = "Class Library|*.dll"
        dialog.ShowDialog()
        dialog2 = Nothing
        If (dialog.FileName.Length > 0) Then
            Me.PP.Text = dialog.FileName
        End If
    End Sub
End Class