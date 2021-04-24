Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Namespace RevengeRAT
    Public Class XylosSeparator
        Inherits Control
        Public Sub New()
            Me.DoubleBuffered = True
        End Sub


        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Me.G = e.Graphics
            Me.G.SmoothingMode = SmoothingMode.HighQuality
            Me.G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            MyBase.OnPaint(e)
            Using pen As Pen = New Pen(VBHER.ColorFromHex("#EBEBEC"))
                Dim point As New Point(0, 0)
                Dim point2 As New Point(Me.Width, 0)
                Me.G.DrawLine(pen, point, point2)
            End Using
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Dim size2 As New Size(Me.Width, 2)
            Me.Size = size2
        End Sub

        Private G As Graphics
    End Class
End Namespace

