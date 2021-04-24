Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace RevengeRAT
    Public Class UltimatumTabControl
        Inherits TabControl
        Public Sub New()
            Me.Alignment = TabAlignment.Left
            Me.SizeMode = TabSizeMode.Fixed
            Dim size2 As New Size(40, 170)
            Me.ItemSize = size2
            Me.DoubleBuffered = True
            Me.Dock = DockStyle.Fill
        End Sub

        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            e.Control.BackColor = Color.White
            e.Control.ForeColor = Color.FromArgb(150, 150, 150)
            e.Control.Font = New Font("Verdana", 8.0!)
        End Sub

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            Me.SetStyle(ControlStyles.UserPaint, True)
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
                Dim rectangle As Rectangle
                Dim point As Point
                Dim rectangle2 As Rectangle
                Me.Rect = Me.GetTabRect(i)
                If String.IsNullOrEmpty(Conversions.ToString(Me.TabPages.Item(i).Tag)) Then
                    Using brush As SolidBrush = New SolidBrush(XylosTabControl.Over)
                        rectangle = New Rectangle((Me.Rect.X + &H19), (Me.Rect.Y + 11), 13, 12)
                        Me.G.FillRectangle(brush, rectangle)
                    End Using
                    rectangle = New Rectangle((Me.Rect.X + &H19), (Me.Rect.Y + 11), 13, 12)
                    Helpers.DrawRoundRect(Me.G, rectangle, 3, XylosTabControl.Over)
                    If (Me.SelectedIndex = i) Then
                        Using brush2 As SolidBrush = New SolidBrush(XylosTabControl.Overtext)
                            rectangle = New Rectangle((Me.Rect.X + &H1C), (Me.Rect.Y + 13), 7, 7)
                            Me.G.FillRectangle(brush2, rectangle)
                        End Using
                        rectangle = New Rectangle((Me.Rect.X + &H1C), (Me.Rect.Y + 13), 7, 7)
                        Helpers.DrawRoundRect(Me.G, rectangle, 3, XylosTabControl.Overtext)
                    End If
                    Using brush3 As SolidBrush = New SolidBrush(XylosTabControl.Overtext)
                        point = New Point((Me.Rect.X + &H2D), (Me.Rect.Y + 9))
                        Me.G.DrawString(Me.TabPages.Item(i).Text, New Font("Verdana", 8.0!), brush3, CType(point, PointF))
                    End Using
                Else
                    rectangle = New Rectangle(Me.Rect.X, Me.Rect.Y, Me.Rect.Width, (Me.Rect.Height + 5))
                    Using brush4 As LinearGradientBrush = New LinearGradientBrush(rectangle, XylosTabControl.Overtext, XylosTabControl.Overtext, LinearGradientMode.Vertical)
                        rectangle2 = New Rectangle((Me.Rect.X - 2), (Me.Rect.Y + 1), (Me.Rect.Width + 2), (Me.Rect.Height - 2))
                        Me.G.FillRectangle(brush4, rectangle2)
                    End Using
                    Using pen As Pen = New Pen(XylosTabControl.Overtext)
                        rectangle2 = New Rectangle((Me.Rect.X - 2), (Me.Rect.Y + 1), (Me.Rect.Width + 2), (Me.Rect.Height - 2))
                        Me.G.DrawRectangle(pen, rectangle2)
                    End Using
                    Using brush5 As SolidBrush = New SolidBrush(XylosTabControl.Overtext)
                        point = New Point((Me.Rect.X + &H35), (Me.Rect.Y + 11))
                        Me.G.DrawString(Me.TabPages.Item(i).Text, New Font("Verdana", 8.0!), brush5, CType(point, PointF))
                    End Using
                    Using brush6 As SolidBrush = New SolidBrush(Color.FromArgb(220, 220, 220))
                        point = New Point((Me.Rect.X + &H87), (Me.Rect.Y + 11))
                        Me.G.DrawString("6", New Font("Verdana", 8.0!, FontStyle.Regular), brush6, CType(point, PointF))
                    End Using
                End If
                If (Not Information.IsNothing(Me.ImageList) AndAlso ((Me.TabPages.Item(i).ImageIndex >= 0) And Not String.IsNullOrEmpty(Conversions.ToString(Me.TabPages.Item(i).Tag)))) Then
                    rectangle2 = New Rectangle((Me.Rect.X + &H18), CInt(Math.Round(CDbl((Me.Rect.Y + ((CDbl(Me.Rect.Height) / 2) - 9))))), &H10, &H10)
                    Me.G.DrawImage(Me.ImageList.Images.Item(Me.TabPages.Item(i).ImageIndex), rectangle2)
                End If
                i += 1
            Loop
        End Sub

        Protected Overrides Sub OnSelecting(ByVal e As TabControlCancelEventArgs)
            MyBase.OnSelecting(e)
            If (Not Information.IsNothing(e.TabPage) AndAlso Not String.IsNullOrEmpty(Conversions.ToString(e.TabPage.Tag))) Then
                e.Cancel = True
            End If
        End Sub

        Private G As Graphics
        Private Rect As Rectangle
    End Class
End Namespace

