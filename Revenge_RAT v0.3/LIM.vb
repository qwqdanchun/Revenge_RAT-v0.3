Namespace RevengeRAT
    Public Class LIM
        Inherits ListView
        Public Sub New()
            Me.AllowDrop = False
            Me.Font = New Font("Verdana", 8.0!, FontStyle.Regular)
            Me.Dock = DockStyle.Fill
            Me.View = View.LargeIcon
            Me.FullRowSelect = True
            Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint), True)
            Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
        End Sub

        Protected Overrides Sub OnNotifyMessage(ByVal m As Message)
            Return
            MyBase.OnNotifyMessage(m)
        End Sub


    End Class
End Namespace

