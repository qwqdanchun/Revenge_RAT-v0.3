Imports System.IO
Public Class LPRO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.Fxlsv1.SelectedItems.Count > 0) Then
            My.Forms.Main.Load_Builder_Settings(Me.Fxlsv1.SelectedItems.Item(0).SubItems.Item(0).Text)
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LPRO_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Fxlsv1.Items.Clear()
        Dim str As String
        For Each str In Directory.GetFiles((Application.StartupPath & "\Profiles\"))
            If (Path.GetExtension(str).ToLower = ".ini") Then
                Me.Fxlsv1.Items.Add(Path.GetFileNameWithoutExtension(str))
            End If
        Next
    End Sub
End Class