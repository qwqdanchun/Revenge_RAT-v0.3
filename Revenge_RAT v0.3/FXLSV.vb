Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Runtime.InteropServices


Namespace RevengeRAT
    Public Class FXLSV
        Inherits ListView
        ' Methods
        Public Sub New()
            AddHandler MyBase.HandleCreated, New EventHandler(AddressOf Me.Lam__1)
            Me.Font = New Font("Verdana", 8.0!, FontStyle.Regular)
            Me.Dock = DockStyle.Fill
            Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint), True)
            Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
        End Sub
        Private Sub Lam__1(ByVal a0 As Object, ByVal a1 As EventArgs)
            Me.HC()
        End Sub

        Public Sub HC()
            If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.Tag, "Null", False))) Then
                Try
                    FXLSV.SetWindowTheme(Me.Handle, "explorer", Nothing)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    ProjectData.ClearProjectError()
                End Try
            End If
        End Sub

        <DllImport("uxtheme", CharSet:=CharSet.Unicode)>
        Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal textSubAppName As String, ByVal textSubIdList As String) As Integer
        End Function

    End Class
End Namespace

