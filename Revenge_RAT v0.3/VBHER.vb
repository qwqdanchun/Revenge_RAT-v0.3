Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D
Imports System.Globalization

Namespace RevengeRAT
    <StandardModule>
    Friend NotInheritable Class VBHER
        ' Methods
        Public Shared Sub CenterString(ByVal G As Graphics, ByVal T As String, ByVal F As Font, ByVal C As Color, ByVal R As Rectangle)
            Dim ef As SizeF = G.MeasureString(T, F)
            Using brush As SolidBrush = New SolidBrush(C)
                Dim point As New Point(CInt(Math.Round(CDbl(((CDbl(R.Width) / 2) - (ef.Width / 2.0!))))), CInt(Math.Round(CDbl(((CDbl(R.Height) / 2) - (ef.Height / 2.0!))))))
                G.DrawString(T, F, brush, CType(point, PointF))
            End Using
        End Sub

        Public Shared Function ColorFromHex(ByVal Hex As String) As Color
            Return Color.FromArgb(CInt(Long.Parse(String.Format("FFFFFFFFFF{0}", Hex.Substring(1)), NumberStyles.HexNumber)))
        End Function

        Public Shared Function FullRectangle(ByVal S As Size, ByVal Subtract As Boolean) As Rectangle
            If Subtract Then
                Return New Rectangle(0, 0, (S.Width - 1), (S.Height - 1))
            End If
            Return New Rectangle(0, 0, S.Width, S.Height)
        End Function

        Public Shared Function RoundRect(ByVal Rect As Rectangle, ByVal Rounding As Integer, ByVal Optional Style As RoundingStyle = 0) As GraphicsPath
            Dim rectangle As Rectangle
            Dim point As Point
            Dim point2 As Point
            Dim path As New GraphicsPath
            Dim width As Integer = (Rounding * 2)
            path.StartFigure()

            If (Rounding = 0) Then
                path.AddRectangle(Rect)
                path.CloseAllFigures()
                Return path
            End If
            Select Case CByte(Style)
                Case 0
                    rectangle = New Rectangle(Rect.X, Rect.Y, width, width)
                    path.AddArc(rectangle, -180.0!, 90.0!)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), Rect.Y, width, width)
                    path.AddArc(rectangle, -90.0!, 90.0!)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 0!, 90.0!)
                    rectangle = New Rectangle(Rect.X, ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 90.0!, 90.0!)
                    Exit Select
                Case 1
                    rectangle = New Rectangle(Rect.X, Rect.Y, width, width)
                    path.AddArc(rectangle, -180.0!, 90.0!)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), Rect.Y, width, width)
                    path.AddArc(rectangle, -90.0!, 90.0!)
                    point = New Point((Rect.X + Rect.Width), (Rect.Y + Rect.Height))
                    point2 = New Point(Rect.X, (Rect.Y + Rect.Height))
                    path.AddLine(point, point2)
                    Exit Select
                Case 2
                    point2 = New Point(Rect.X, Rect.Y)
                    point = New Point((Rect.X + Rect.Width), Rect.Y)
                    path.AddLine(point2, point)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 0!, 90.0!)
                    rectangle = New Rectangle(Rect.X, ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 90.0!, 90.0!)
                    Exit Select
                Case 3
                    rectangle = New Rectangle(Rect.X, Rect.Y, width, width)
                    path.AddArc(rectangle, -180.0!, 90.0!)
                    point2 = New Point((Rect.X + Rect.Width), Rect.Y)
                    point = New Point((Rect.X + Rect.Width), (Rect.Y + Rect.Height))
                    path.AddLine(point2, point)
                    rectangle = New Rectangle(Rect.X, ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 90.0!, 90.0!)
                    Exit Select
                Case 4
                    point2 = New Point(Rect.X, (Rect.Y + Rect.Height))
                    point = New Point(Rect.X, Rect.Y)
                    path.AddLine(point2, point)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), Rect.Y, width, width)
                    path.AddArc(rectangle, -90.0!, 90.0!)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 0!, 90.0!)
                    Exit Select
                Case 5
                    point2 = New Point(Rect.X, (Rect.Y + 1))
                    point = New Point(Rect.X, Rect.Y)
                    path.AddLine(point2, point)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), Rect.Y, width, width)
                    path.AddArc(rectangle, -90.0!, 90.0!)
                    point2 = New Point((Rect.X + Rect.Width), ((Rect.Y + Rect.Height) - 1))
                    point = New Point((Rect.X + Rect.Width), (Rect.Y + Rect.Height))
                    path.AddLine(point2, point)
                    point2 = New Point((Rect.X + 1), (Rect.Y + Rect.Height))
                    point = New Point(Rect.X, (Rect.Y + Rect.Height))
                    path.AddLine(point2, point)
                    Exit Select
                Case 6
                    point2 = New Point(Rect.X, (Rect.Y + 1))
                    point = New Point(Rect.X, Rect.Y)
                    path.AddLine(point2, point)
                    point2 = New Point(((Rect.X + Rect.Width) - 1), Rect.Y)
                    point = New Point((Rect.X + Rect.Width), Rect.Y)
                    path.AddLine(point2, point)
                    rectangle = New Rectangle(((Rect.Width - width) + Rect.X), ((Rect.Height - width) + Rect.Y), width, width)
                    path.AddArc(rectangle, 0!, 90.0!)
                    point2 = New Point((Rect.X + 1), (Rect.Y + Rect.Height))
                    point = New Point(Rect.X, (Rect.Y + Rect.Height))
                    path.AddLine(point2, point)
                    Exit Select
            End Select
            path.CloseAllFigures()
            Return path
        End Function


        ' Nested Types
        Public Enum RoundingStyle As Byte
            ' Fields
            All = 0
            Bottom = 2
            BottomRight = 6
            Left = 3
            Right = 4
            Top = 1
            TopRight = 5
        End Enum
    End Class
End Namespace

