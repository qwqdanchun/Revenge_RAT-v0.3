Public Class EPRN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.TextBox1.Text = Nothing) Then
            MessageBox.Show("add a profile name!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            My.Forms.Main.Save_Builder_Settings(Me.TextBox1.Text)
            Me.Close()
        End If
    End Sub
End Class