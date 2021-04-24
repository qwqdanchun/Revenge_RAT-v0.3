Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Namespace RevengeRAT
    Public Class XylosTabControl
        Inherits TabControl
        ' Methods
        Public Sub New()
            Me._OverIndex = -1
            Me.DoubleBuffered = True
            Me.Alignment = TabAlignment.Left
            Me.SizeMode = TabSizeMode.Fixed
            Dim size2 As New Size(40, 180)
            Me.ItemSize = size2
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            e.Control.BackColor = Color.White
            e.Control.ForeColor = XylosTabControl.CCB
            e.Control.Font = New Font("Verdana", 8.0!, FontStyle.Regular)
        End Sub

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            Me.SetStyle(ControlStyles.UserPaint, True)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            Me.OverIndex = -1
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            Dim num2 As Integer = (Me.TabPages.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If ((Me.GetTabRect(i).Contains(e.Location) And (Me.SelectedIndex <> i)) And String.IsNullOrEmpty(Conversions.ToString(Me.TabPages.Item(i).Tag))) Then
                    Me.OverIndex = i
                    Exit Do
                End If
                Me.OverIndex = -1
                i += 1
            Loop
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Me.G = e.Graphics
            Me.G.SmoothingMode = SmoothingMode.HighQuality
            Me.G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            MyBase.OnPaint(e)
            Me.G.Clear(XylosTabControl.CCB)
            Dim num2 As Integer = (Me.TabPages.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Dim point As Point
                Me.Rect = Me.GetTabRect(i)
                If String.IsNullOrEmpty(Conversions.ToString(Me.TabPages.Item(i).Tag)) Then
                    Dim tabRect As Rectangle
                    Dim rectangle5 As Rectangle
                    If (Me.SelectedIndex = i) Then
                        Using brush As SolidBrush = New SolidBrush(XylosTabControl.Over)
                            Using brush2 As SolidBrush = New SolidBrush(XylosTabControl.MainColor)
                                Using font As Font = New Font("Verdana", 8.0!, FontStyle.Regular)
                                    tabRect = New Rectangle((Me.Rect.X - 5), (Me.Rect.Y + 1), (Me.Rect.Width + 7), Me.Rect.Height)
                                    Me.G.FillRectangle(brush, tabRect)
                                    point = New Point(((Me.Rect.X + 50) + (Me.ItemSize.Height - 180)), (Me.Rect.Y + 12))
                                    Me.G.DrawString(Me.TabPages.Item(i).Text, font, brush2, CType(point, PointF))
                                End Using
                            End Using
                        End Using
                        Using brush3 As SolidBrush = New SolidBrush(XylosTabControl.SI1ST)
                            tabRect = New Rectangle((Me.Rect.X - 2), (Me.Rect.Y + 2), 4, (Me.Rect.Height - 2))
                            Me.G.FillRectangle(brush3, tabRect)
                        End Using
                    Else
                        Using brush4 As SolidBrush = New SolidBrush(XylosTabControl.Overtext)
                            Using font2 As Font = New Font("Verdana", 8.0!, FontStyle.Regular)
                                point = New Point(((Me.Rect.X + 50) + (Me.ItemSize.Height - 180)), (Me.Rect.Y + 12))
                                Me.G.DrawString(Me.TabPages.Item(i).Text, font2, brush4, CType(point, PointF))
                            End Using
                        End Using
                    End If
                    If ((Me.OverIndex <> -1) And (Me.SelectedIndex <> Me.OverIndex)) Then
                        Dim rectangle2 As Rectangle
                        Using brush5 As SolidBrush = New SolidBrush(XylosTabControl.CoverC)
                            Using brush6 As SolidBrush = New SolidBrush(XylosTabControl.Overtext)
                                Using font3 As Font = New Font("Verdana", 8.0!, FontStyle.Regular)
                                    tabRect = Me.GetTabRect(Me.OverIndex)
                                    rectangle2 = Me.GetTabRect(Me.OverIndex)
                                    rectangle5 = New Rectangle((tabRect.X - 5), (rectangle2.Y + 1), (Me.GetTabRect(Me.OverIndex).Width + 7), Me.GetTabRect(Me.OverIndex).Height)
                                    Me.G.FillRectangle(brush5, rectangle5)
                                    rectangle5 = Me.GetTabRect(Me.OverIndex)
                                    point = New Point(((rectangle5.X + 50) + (Me.ItemSize.Height - 180)), (Me.GetTabRect(Me.OverIndex).Y + 12))
                                    Me.G.DrawString(Me.TabPages.Item(Me.OverIndex).Text, font3, brush6, CType(point, PointF))
                                End Using
                            End Using
                        End Using
                        If (Not Information.IsNothing(Me.ImageList) AndAlso (Me.TabPages.Item(Me.OverIndex).ImageIndex >= 0)) Then
                            rectangle5 = Me.GetTabRect(Me.OverIndex)
                            rectangle2 = New Rectangle(((rectangle5.X + &H19) + (Me.ItemSize.Height - 180)), CInt(Math.Round(CDbl((Me.GetTabRect(Me.OverIndex).Y + ((CDbl(Me.GetTabRect(Me.OverIndex).Height) / 2) - 9))))), &H10, &H10)
                            Me.G.DrawImage(Me.ImageList.Images.Item(Me.TabPages.Item(Me.OverIndex).ImageIndex), rectangle2)
                        End If
                    End If
                    If (Not Information.IsNothing(Me.ImageList) AndAlso (Me.TabPages.Item(i).ImageIndex >= 0)) Then
                        rectangle5 = New Rectangle(((Me.Rect.X + &H19) + (Me.ItemSize.Height - 180)), CInt(Math.Round(CDbl((Me.Rect.Y + ((CDbl(Me.Rect.Height) / 2) - 9))))), &H10, &H10)
                        Me.G.DrawImage(Me.ImageList.Images.Item(Me.TabPages.Item(i).ImageIndex), rectangle5)
                    End If
                Else
                    Using brush7 As SolidBrush = New SolidBrush(XylosTabControl.HeaderColor)
                        Using font4 As Font = New Font("Verdana", 8.0!, FontStyle.Regular)
                            Using pen As Pen = New Pen(XylosTabControl.Over)
                                Dim point2 As Point
                                If Me.FirstHeaderBorder Then
                                    point = New Point((Me.Rect.X - 5), (Me.Rect.Y + 1))
                                    point2 = New Point((Me.Rect.Width + 7), (Me.Rect.Y + 1))
                                    Me.G.DrawLine(pen, point, point2)
                                ElseIf (i <> 0) Then
                                    point2 = New Point((Me.Rect.X - 5), (Me.Rect.Y + 1))
                                    point = New Point((Me.Rect.Width + 7), (Me.Rect.Y + 1))
                                    Me.G.DrawLine(pen, point2, point)
                                End If
                                point2 = New Point(((Me.Rect.X + &H19) + (Me.ItemSize.Height - 180)), (Me.Rect.Y + &H10))
                                Me.G.DrawString(Me.TabPages.Item(i).Text, font4, brush7, CType(point2, PointF))
                            End Using
                        End Using
                    End Using
                End If
                i += 1
            Loop
        End Sub

        Protected Overrides Sub OnSelecting(ByVal e As TabControlCancelEventArgs)
            MyBase.OnSelecting(e)
            If Not Information.IsNothing(e.TabPage) Then
                If Not String.IsNullOrEmpty(Conversions.ToString(e.TabPage.Tag)) Then
                    e.Cancel = True
                Else
                    Me.OverIndex = -1
                End If
            End If
        End Sub

        Public Property FirstHeaderBorder As Boolean
            <DebuggerNonUserCode>
            Get
                Return Me._FirstHeaderBorder
            End Get
            <DebuggerNonUserCode>
            Set(ByVal AutoPropertyValue As Boolean)
                Me._FirstHeaderBorder = AutoPropertyValue
            End Set
        End Property

        Private Property OverIndex As Integer
            Get
                Return Me._OverIndex
            End Get
            Set(ByVal value As Integer)
                Me._OverIndex = value
                Me.Invalidate()
            End Set
        End Property

        Private _FirstHeaderBorder As Boolean
        Private _OverIndex As Integer
        Public Shared CCB As Color = VBHER.ColorFromHex("#33373B")
        Public Shared CoverC As Color = VBHER.ColorFromHex("#2F3338")
        Private G As Graphics
        Public Shared HeaderColor As Color = VBHER.ColorFromHex("#6A7279")
        Public Shared MainColor As Color = VBHER.ColorFromHex("#BECCD9")
        Public Shared Over As Color = VBHER.ColorFromHex("#2B2F33")
        Public Shared Overtext As Color = VBHER.ColorFromHex("#919BA6")
        Private Rect As Rectangle
        Public Shared SI1ST As Color = Color.FromArgb(&H33, &H66, &HFF)
    End Class
End Namespace


