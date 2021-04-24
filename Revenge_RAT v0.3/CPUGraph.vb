Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D

Namespace RevengeRAT
    Public Class CPUGraph
        Inherits Control
        Private ValueAddedEvent As CPUGraph.ValueAddedEventHandler
        Public Custom Event ValueAdded As ValueAddedEventHandler
            AddHandler(value As ValueAddedEventHandler)
                Me.ValueAddedEvent = CType([Delegate].Combine(Me.ValueAddedEvent, value), CPUGraph.ValueAddedEventHandler)
            End AddHandler
            RemoveHandler(value As ValueAddedEventHandler)
                Me.ValueAddedEvent = CType([Delegate].Remove(Me.ValueAddedEvent, value), CPUGraph.ValueAddedEventHandler)
            End RemoveHandler
            RaiseEvent()

            End RaiseEvent
        End Event

        ' Methods
        Public Sub New()
            Me._MaximumValue = Single.MinValue
            Me._MinimumValue = Single.MaxValue
            Me.Index = -1
            Try
                Dim image As New Bitmap(1, 1)
                Me.SG = Graphics.FromImage(image)
                Me.GP = New GraphicsPath
                Me._Values = New List(Of Single)
                Me.Font = New Font("Verdana", 8.25!)
                Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or (ControlStyles.AllPaintingInWmPaint Or (ControlStyles.ResizeRedraw Or (ControlStyles.Opaque Or ControlStyles.UserPaint)))), True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub
        Public Sub AddValue(ByVal value As Single)
            Try
                Me.Index = -1
                If (Me._Values.Count >= &H19) Then
                    Me._Values.RemoveAt(0)
                End If
                Me._Values.Add(value)
                Me.allbytes = CULng(Math.Round(CDbl((Me.allbytes + value))))
                Me.FindMinMax()
                Me.Invalidate()
                Dim valueAddedEvent As ValueAddedEventHandler = Me.ValueAddedEvent
                If (Not valueAddedEvent Is Nothing) Then
                    valueAddedEvent.Invoke
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub FindMinMax()
            Try
                Me._MaximumValue = Single.MinValue
                Me._MinimumValue = Single.MaxValue
                Dim num2 As Integer = (Me._Values.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    Me.CurrentValue = Me._Values.Item(i)
                    If (Me.CurrentValue > Me._MaximumValue) Then
                        Me._MaximumValue = Me.CurrentValue
                    End If
                    If (Me.CurrentValue < Me._MinimumValue) Then
                        Me._MinimumValue = Me.CurrentValue
                    End If
                    i += 1
                Loop
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            Try
                If True Then
                    Me.Index = -1
                    Me.Invalidate()
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            Try
                If True Then
                    Me.R1 = New Rectangle(Me.SW, 0, (Me.Width - Me.SW), (Me.Height - Me.SH))
                    Me.R2 = New Rectangle((Me.R1.X + 8), (Me.R1.Y + 8), (Me.R1.Width - &H10), (Me.R1.Height - &H10))
                    Me.FB1 = CSng((CDbl((Me.R2.Width - 1)) / CDbl((Me._Values.Count - 1))))
                    If Me.R1.Contains(e.Location) Then
                        Me.Index = CInt(Math.Round(CDbl((CSng((e.X - Me.R2.X)) / Me.FB1))))
                        If (Me.Index >= Me._Values.Count) Then
                            Me.Index = -1
                        End If
                    Else
                        Me.Index = -1
                    End If
                    If (DateTime.Compare(DateTime.Now, Me.LastMove.AddMilliseconds(33)) > 0) Then
                        Me.LastMove = DateTime.Now
                        Me.Invalidate()
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Try
                Dim num4 As Integer
                Me.G = e.Graphics
                Me.G.Clear(Me.BackColor)
                Me.R1 = New Rectangle(Me.SW, 0, (Me.Width - Me.SW), Me.Height)
                If False Then
                    Me.R1.X = 0
                    Me.R1.Width = Me.Width
                End If
                Me.R2 = New Rectangle((Me.R1.X + 10), (Me.R1.Y + 10), (Me.R1.Width - 20), (Me.R1.Height - 20))
                If False Then
                    Me.R2.X = Me.R1.X
                    Me.R2.Width = Me.R1.Width
                End If
                Me.G.FillRectangle(New SolidBrush(Color.White), Me.R1)
                Dim num As Integer = 0
                Do
                    Me.FB1 = (Me.R2.Y + CSng(((Me.R2.Height - 1) * (num * 0.1))))
                    If True Then
                        Me.G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(&HEE, &HEE, &HEE))), CSng(Me.R1.X), Me.FB1, CSng((Me.R1.Right - 1)), Me.FB1)
                    End If
                    If (((1 <> 0) AndAlso (Me._Values.Count > 1)) AndAlso ((num Mod 2) = 0)) Then
                        Me.G.DrawLine(New Pen(New SolidBrush(Color.Black)), CSng((Me.R1.X - 4)), Me.FB1, CSng(Me.R1.X), Me.FB1)
                        Me.CurrentValue = CInt(Math.Round(CDbl((((Me._MaximumValue - Me._MinimumValue) * (1 - (num * 0.1))) + Me._MinimumValue))))
                        Me.SB = Me.SmallValue(Me.CurrentValue)
                        Me.SS = Me.G.MeasureString(Me.SB, Me.Font).ToSize
                        Me.G.DrawString(Me.SB, Me.Font, New SolidBrush(Color.Black), CSng(((Me.R1.X - 5) - Me.SS.Width)), (Me.FB1 - Me.SHH))
                    End If
                    num += 1
                    num4 = 10
                Loop While (num <= num4)
                If (Me._Values.Count > 1) Then
                    Me.PS = New PointF(((Me._Values.Count + 1) + 1) - 1) {}
                    Me.FB1 = CSng((CDbl((Me.R2.Width - 1)) / CDbl((Me._Values.Count - 1))))
                    Dim num3 As Integer = (Me._Values.Count - 1)
                    Dim i As Integer = 0
                    Do While (i <= num3)
                        Me.FB2 = (Me.R2.X + (i * Me.FB1))
                        Me.CurrentValue = ((Me._Values.Item(i) - Me._MinimumValue) / Math.Max(CSng((Me._MaximumValue - Me._MinimumValue)), CSng(1.0!)))
                        If (Me.CurrentValue > 1.0!) Then
                            Me.CurrentValue = 1.0!
                        ElseIf (Me.CurrentValue < 0!) Then
                            Me.CurrentValue = 0!
                        End If
                        Me.PS(i) = New PointF(Me.FB2, CSng(CInt(Math.Round(CDbl(((Me.R2.Bottom - ((Me.R2.Height - 1) * Me.CurrentValue)) - 1.0!))))))
                        If True Then
                            Me.G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(&HF8, &HF8, &HF8))), Me.FB2, CSng(Me.R1.Y), Me.FB2, CSng(Me.R1.Bottom))
                        End If
                        i += 1
                    Loop
                    Me.PS((Me.PS.Length - 2)) = New PointF(CSng((Me.R2.Right - 1)), CSng((Me.R1.Bottom - 1)))
                    Me.PS((Me.PS.Length - 1)) = New PointF(CSng(Me.R2.X), CSng((Me.R1.Bottom - 1)))
                    Me.G.SmoothingMode = SmoothingMode.HighQuality
                    If False Then
                        Array.Resize(Of PointF)(Me.PS, (Me.PS.Length - 2))
                        Me.G.DrawLines(New Pen(New SolidBrush(Color.FromArgb(130, 0, 200, &HFF))), Me.PS)
                    Else
                        Me.GP.AddPolygon(Me.PS)
                        Me.GP.CloseFigure()
                        Me.G.FillPath(New SolidBrush(Color.FromArgb(50, Color.FromArgb(&HAD, &HD8, 230))), Me.GP)
                        Me.G.DrawPath(New Pen(New SolidBrush(Color.FromArgb(&HAD, &HD8, 230))), Me.GP)
                        Me.GP.Reset()
                    End If
                    If ((1 <> 0) AndAlso (Me.Index >= 0)) Then
                        Me.G.SetClip(Me.R1)
                        Me.P = New Point(CInt(Math.Round(CDbl(Me.PS(Me.Index).X))), CInt(Math.Round(CDbl(Me.PS(Me.Index).Y))))
                        Me.R3 = New Rectangle((Me.P.X - 4), (Me.P.Y - 4), 8, 8)
                        If False Then
                            Me.G.DrawLine(New Pen(New SolidBrush(Color.FromArgb(&H23, &H22, &H8B, &H22))), Me.P.X, Me.R1.Y, Me.P.X, (Me.R1.Bottom - 1))
                        End If
                        Me.G.FillEllipse(New SolidBrush(Color.White), Me.R3)
                        Me.G.DrawEllipse(New Pen(New SolidBrush(Color.FromArgb(&HAD, &HD8, 230))), Me.R3)
                        Me.SB = String.Format("{0:#,##0.##}", Me._Values.Item(Me.Index))
                        Me.SS = Me.G.MeasureString((Me.SB & " %"), Me.Font).ToSize
                        Me.P = Me.PointToClient(Control.MousePosition)
                        Me.R3 = New Rectangle((Me.P.X + &H18), Me.P.Y, (Me.SS.Width + 20), (Me.SS.Height + 10))
                        If ((Me.R3.X + Me.R3.Width) > (Me.R1.Right - 1)) Then
                            Me.R3.X = ((Me.P.X - Me.R3.Width) - &H10)
                        End If
                        If ((Me.R3.Y + Me.R3.Height) > (Me.R1.Bottom - 1)) Then
                            Me.R3.Y = ((Me.R1.Bottom - Me.R3.Height) - 1)
                        End If
                        Me.G.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(&H23, 0, 0, 0))), Me.R3)
                        Me.G.FillRectangle(New SolidBrush(Color.White), Me.R3)
                        Me.G.DrawRectangle(New Pen(New SolidBrush(Color.Black)), Me.R3)
                        Dim point As New Point((Me.R3.X + 10), (Me.R3.Y + 5))
                        Me.G.DrawString((Me.SB & " %"), Me.Font, New SolidBrush(Color.Black), CType(point, PointF))
                    End If
                    Me.G.ResetClip()
                    Me.G.SmoothingMode = SmoothingMode.None
                End If
                Me.G.DrawRectangle(New Pen(New SolidBrush(Color.Black)), Me.R1.X, Me.R1.Y, (Me.R1.Width - 1), (Me.R1.Height - 1))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Function SmallValue(ByVal value As Single) As String
            Dim str As String
            Try
                Dim num As Integer = CInt(Math.Round(CDbl(value)))
                Dim num2 As Integer = num
                If (num2 >= &H3B9ACA00) Then
                    Return (Conversions.ToString(CInt((num / &H3B9ACA00))) & "B")
                End If
                If (num2 >= &HF4240) Then
                    Return (Conversions.ToString(CInt((num / &HF4240))) & "M")
                End If
                If (num2 >= &H3E8) Then
                    Return (Conversions.ToString(CInt((num / &H3E8))) & "K")
                End If
                Return Conversions.ToString(num)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            Return str
        End Function

        Private _MaximumValue As Single
        Private _MinimumValue As Single
        Private _Values As List(Of Single)
        Public allbytes As UInt64
        Private CurrentValue As Single
        Private FB1 As Single
        Private FB2 As Single
        Private G As Graphics
        Private GP As GraphicsPath
        Private Index As Integer
        Private LastMove As DateTime
        Private P As Point
        Private PS As PointF()
        Private R1 As Rectangle
        Private R2 As Rectangle
        Private R3 As Rectangle
        Private SB As String
        Private SG As Graphics
        Private SH As Integer
        Private SHH As Integer
        Private SS As Size
        Private SW As Integer

        ' Nested Types
        Public Delegate Sub ValueAddedEventHandler()
    End Class
End Namespace

