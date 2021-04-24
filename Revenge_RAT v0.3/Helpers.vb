Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Drawing

Namespace RevengeRAT
    <StandardModule>
    Public NotInheritable Class Helpers
        ' Methods
        Public Shared Sub CenterString(ByVal G As Graphics, ByVal T As String, ByVal F As Font, ByVal C As Color, ByVal R As Rectangle)
            Dim ef As SizeF = G.MeasureString(T, F)
            Using brush As SolidBrush = New SolidBrush(C)
                Dim point As New Point(CInt(Math.Round(CDbl(((CDbl(R.Width) / 2) - (ef.Width / 2.0!))))), CInt(Math.Round(CDbl(((CDbl(R.Height) / 2) - (ef.Height / 2.0!))))))
                G.DrawString(T, F, brush, CType(point, PointF))
            End Using
        End Sub

        Public Shared Sub DrawRoundRect(ByVal G As Graphics, ByVal R As Rectangle, ByVal Curve As Integer, ByVal C As Color)
            Using pen As Pen = New Pen(C)
                G.DrawArc(pen, R.X, R.Y, Curve, Curve, 180, 90)
                G.DrawLine(pen, CInt(Math.Round(CDbl((R.X + (CDbl(Curve) / 2))))), R.Y, CInt(Math.Round(CDbl(((R.X + R.Width) - (CDbl(Curve) / 2))))), R.Y)
                G.DrawArc(pen, ((R.X + R.Width) - Curve), R.Y, Curve, Curve, 270, 90)
                G.DrawLine(pen, R.X, CInt(Math.Round(CDbl((R.Y + (CDbl(Curve) / 2))))), R.X, CInt(Math.Round(CDbl(((R.Y + R.Height) - (CDbl(Curve) / 2))))))
                G.DrawLine(pen, (R.X + R.Width), CInt(Math.Round(CDbl((R.Y + (CDbl(Curve) / 2))))), (R.X + R.Width), CInt(Math.Round(CDbl(((R.Y + R.Height) - (CDbl(Curve) / 2))))))
                G.DrawLine(pen, CInt(Math.Round(CDbl((R.X + (CDbl(Curve) / 2))))), (R.Y + R.Height), CInt(Math.Round(CDbl(((R.X + R.Width) - (CDbl(Curve) / 2))))), (R.Y + R.Height))
                G.DrawArc(pen, R.X, ((R.Y + R.Height) - Curve), Curve, Curve, 90, 90)
                G.DrawArc(pen, ((R.X + R.Width) - Curve), ((R.Y + R.Height) - Curve), Curve, Curve, 0, 90)
            End Using
        End Sub

        Public Shared Sub DrawTriangle(ByVal G As Graphics, ByVal Rect As Rectangle, ByVal D As Direction, ByVal C As Color)
            Dim num2 As Integer = CInt(Math.Round(CDbl((CDbl(Rect.Width) / 2))))
            Dim num As Integer = CInt(Math.Round(CDbl((CDbl(Rect.Height) / 2))))
            Dim empty As Point = Point.Empty
            Dim point2 As Point = Point.Empty
            Dim point3 As Point = Point.Empty
            Select Case CByte(D)
                Case 0
                    empty = New Point((Rect.Left + num2), Rect.Top)
                    point2 = New Point(Rect.Left, Rect.Bottom)
                    point3 = New Point(Rect.Right, Rect.Bottom)
                    Exit Select
                Case 1
                    empty = New Point((Rect.Left + num2), Rect.Bottom)
                    point2 = New Point(Rect.Left, Rect.Top)
                    point3 = New Point(Rect.Right, Rect.Top)
                    Exit Select
                Case 2
                    empty = New Point(Rect.Left, (Rect.Top + num))
                    point2 = New Point(Rect.Right, Rect.Top)
                    point3 = New Point(Rect.Right, Rect.Bottom)
                    Exit Select
                Case 3
                    empty = New Point(Rect.Right, (Rect.Top + num))
                    point2 = New Point(Rect.Left, Rect.Bottom)
                    point3 = New Point(Rect.Left, Rect.Top)
                    Exit Select
            End Select
            Using brush As SolidBrush = New SolidBrush(C)
                Dim points As Point() = New Point() {empty, point2, point3}
                G.FillPolygon(brush, points)
            End Using
        End Sub

        Public Shared Sub FillRoundRect(ByVal G As Graphics, ByVal R As Rectangle, ByVal Curve As Integer, ByVal C As Color)
            Using brush As SolidBrush = New SolidBrush(C)
                G.FillPie(brush, R.X, R.Y, Curve, Curve, 180, 90)
                G.FillPie(brush, ((R.X + R.Width) - Curve), R.Y, Curve, Curve, 270, 90)
                G.FillPie(brush, R.X, ((R.Y + R.Height) - Curve), Curve, Curve, 90, 90)
                G.FillPie(brush, ((R.X + R.Width) - Curve), ((R.Y + R.Height) - Curve), Curve, Curve, 0, 90)
                G.FillRectangle(brush, CInt(Math.Round(CDbl((R.X + (CDbl(Curve) / 2))))), R.Y, (R.Width - Curve), CInt(Math.Round(CDbl((CDbl(Curve) / 2)))))
                G.FillRectangle(brush, R.X, CInt(Math.Round(CDbl((R.Y + (CDbl(Curve) / 2))))), R.Width, (R.Height - Curve))
                G.FillRectangle(brush, CInt(Math.Round(CDbl((R.X + (CDbl(Curve) / 2))))), CInt(Math.Round(CDbl(((R.Y + R.Height) - (CDbl(Curve) / 2))))), (R.Width - Curve), CInt(Math.Round(CDbl((CDbl(Curve) / 2)))))
            End Using
        End Sub

        Public Shared Function FullRectangle(ByVal S As Size, ByVal Subtract As Boolean) As Rectangle
            If Subtract Then
                Return New Rectangle(0, 0, (S.Width - 1), (S.Height - 1))
            End If
            Return New Rectangle(0, 0, S.Width, S.Height)
        End Function

        Public Shared Function GreyColor(ByVal G As UInt32) As Color
            Return Color.FromArgb(CInt(G), CInt(G), CInt(G))
        End Function


        ' Nested Types
        Public Enum Direction As Byte
            ' Fields
            Down = 1
            Left = 2
            Right = 3
            Up = 0
        End Enum

        Public Enum MouseState As Byte
            ' Fields
            Down = 2
            None = 0
            Over = 1
        End Enum
    End Class
End Namespace


