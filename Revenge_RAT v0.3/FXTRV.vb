Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.InteropServices


Namespace RevengeRAT
    Public Class FXTRV
        Inherits TreeView
        ' Methods
        Public Sub New()
            AddHandler MyBase.HandleCreated, New EventHandler(AddressOf Me.Lam__2)
            Me.Font = New Font("Verdana", 8.0!, FontStyle.Regular)
            Me.Dock = DockStyle.Fill
            Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint), True)
            Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
        End Sub
        Private Sub Lam__2(ByVal a0 As Object, ByVal a1 As EventArgs)
            Me.HC()
        End Sub

        Public Sub HC()
            Try
                FXTRV.SetWindowTheme(Me.Handle, "explorer", Nothing)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        <DllImport("uxtheme", CharSet:=CharSet.Unicode)>
        Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal textSubAppName As String, ByVal textSubIdList As String) As Integer
        End Function

    End Class
End Namespace

