Public Class BLogs
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Public Function C(ByVal Y As Color, ByVal H As String) As Object
        Dim obj2 As Object
        Dim num2 As Integer
        Try
            Dim num3 As Integer
Label_0001:
            Dim num As Integer = -2
Label_0009:
            num3 = 2
            Me.Logs.AppendText(H)
Label_0019:
            num3 = 3
            Me.Logs.SelectionColor = Y
Label_0029:
            num3 = 4
            Me.Logs.ScrollToCaret()
Label_0038:
            num3 = 5
            If Not H.Contains("Aborted") Then
                GoTo Label_00D8
            End If
Label_004C:
            num3 = 6
            Me.OK.Enabled = True
            GoTo Label_00D8
Label_0065:
            num2 = 0
            Select Case (num2 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_0009
                Case 3
                    GoTo Label_0019
                Case 4
                    GoTo Label_0029
                Case 5
                    GoTo Label_0038
                Case 6
                    GoTo Label_004C
                Case 7, 8
                    GoTo Label_00D8
                Case Else
                    GoTo Label_00CD
            End Select
Label_0092:
            num2 = num3
            Select Case If((num > -2), num, 1)
                Case 0
                    GoTo Label_00CD
                Case 1
                    GoTo Label_0065
            End Select
        Catch obj1 As Exception
            GoTo Label_0092
        End Try
Label_00CD:
        '    Throw ProjectData.CreateProjectError(-2146828237)
Label_00D8:
        Return obj2
    End Function

End Class