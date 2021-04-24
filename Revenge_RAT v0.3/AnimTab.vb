Namespace RevengeRAT
    Public Class AnimTab
        Inherits TabControl
        Public Sub New()
            Me._Speed = 9
            Me.SetStyle((ControlStyles.OptimizedDoubleBuffer Or (ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw)), True)
        End Sub


        Public Sub DoAnimationScrollLeft(ByVal Control1 As Control, ByVal Control2 As Control)
            Dim width As Integer
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim enumerator3 As IEnumerator
            Dim graphics As Graphics = Control1.CreateGraphics
            Dim bitmap As New Bitmap(Control1.Width, Control1.Height)
            Dim bitmap2 As New Bitmap(Control2.Width, Control2.Height)
            Dim targetBounds As New Rectangle(0, 0, Control1.Width, Control1.Height)
            Control1.DrawToBitmap(bitmap, targetBounds)
            targetBounds = New Rectangle(0, 0, Control2.Width, Control2.Height)
            Control2.DrawToBitmap(bitmap2, targetBounds)
            Try
                enumerator = Control1.Controls.GetEnumerator
                Do While enumerator.MoveNext
                    DirectCast(enumerator.Current, Control).Hide()
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim num3 As Integer = (Control1.Width - (Control1.Width Mod Me._Speed))
            Dim num4 As Integer = Me._Speed
            width = 0
            Do While (((num4 >> &H1F) Xor width) <= ((num4 >> &H1F) Xor num3))
                targetBounds = New Rectangle(width, 0, Control1.Width, Control1.Height)
                graphics.DrawImage(bitmap, targetBounds)
                targetBounds = New Rectangle((width - Control2.Width), 0, Control2.Width, Control2.Height)
                graphics.DrawImage(bitmap2, targetBounds)
                width = (width + num4)
            Loop
            width = Control1.Width
            targetBounds = New Rectangle(width, 0, Control1.Width, Control1.Height)
            graphics.DrawImage(bitmap, targetBounds)
            targetBounds = New Rectangle((width - Control2.Width), 0, Control2.Width, Control2.Height)
            graphics.DrawImage(bitmap2, targetBounds)
            Me.SelectedTab = DirectCast(Control2, TabPage)
            Try
                enumerator2 = Control2.Controls.GetEnumerator
                Do While enumerator2.MoveNext
                    DirectCast(enumerator2.Current, Control).Show()
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Try
                enumerator3 = Control1.Controls.GetEnumerator
                Do While enumerator3.MoveNext
                    DirectCast(enumerator3.Current, Control).Show()
                Loop
            Finally
                If TypeOf enumerator3 Is IDisposable Then
                    TryCast(enumerator3, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Public Sub DoAnimationScrollRight(ByVal Control1 As Control, ByVal Control2 As Control)
            Dim width As Integer
            Dim enumerator As IEnumerator
            Dim enumerator2 As IEnumerator
            Dim enumerator3 As IEnumerator
            Dim graphics As Graphics = Control1.CreateGraphics
            Dim bitmap As New Bitmap(Control1.Width, Control1.Height)
            Dim bitmap2 As New Bitmap(Control2.Width, Control2.Height)
            Dim targetBounds As New Rectangle(0, 0, Control1.Width, Control1.Height)
            Control1.DrawToBitmap(bitmap, targetBounds)
            targetBounds = New Rectangle(0, 0, Control2.Width, Control2.Height)
            Control2.DrawToBitmap(bitmap2, targetBounds)
            Try
                enumerator = Control1.Controls.GetEnumerator
                Do While enumerator.MoveNext
                    DirectCast(enumerator.Current, Control).Hide()
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            Dim num2 As Integer = (Control1.Width - (Control1.Width Mod Me._Speed))
            Dim num3 As Integer = (0 - num2)
            Dim num4 As Integer = (0 - Me._Speed)
            width = 0
            Do While (((num4 >> &H1F) Xor width) <= ((num4 >> &H1F) Xor num3))
                targetBounds = New Rectangle(width, 0, Control1.Width, Control1.Height)
                graphics.DrawImage(bitmap, targetBounds)
                targetBounds = New Rectangle((width + Control2.Width), 0, Control2.Width, Control2.Height)
                graphics.DrawImage(bitmap2, targetBounds)
                width = (width + num4)
            Loop
            width = Control1.Width
            targetBounds = New Rectangle(width, 0, Control1.Width, Control1.Height)
            graphics.DrawImage(bitmap, targetBounds)
            targetBounds = New Rectangle((width + Control2.Width), 0, Control2.Width, Control2.Height)
            graphics.DrawImage(bitmap2, targetBounds)
            Me.SelectedTab = DirectCast(Control2, TabPage)
            Try
                enumerator2 = Control2.Controls.GetEnumerator
                Do While enumerator2.MoveNext
                    DirectCast(enumerator2.Current, Control).Show()
                Loop
            Finally
                If TypeOf enumerator2 Is IDisposable Then
                    TryCast(enumerator2, IDisposable).Dispose()
                End If
            End Try
            Try
                enumerator3 = Control1.Controls.GetEnumerator
                Do While enumerator3.MoveNext
                    DirectCast(enumerator3.Current, Control).Show()
                Loop
            Finally
                If TypeOf enumerator3 Is IDisposable Then
                    TryCast(enumerator3, IDisposable).Dispose()
                End If
            End Try
        End Sub

        Protected Overrides Sub OnDeselecting(ByVal e As TabControlCancelEventArgs)
            Me.OldIndex = e.TabPageIndex
        End Sub

        Protected Overrides Sub OnSelecting(ByVal e As TabControlCancelEventArgs)
            If (Me.OldIndex < e.TabPageIndex) Then
                Me.DoAnimationScrollRight(Me.TabPages.Item(Me.OldIndex), Me.TabPages.Item(e.TabPageIndex))
            Else
                Me.DoAnimationScrollLeft(Me.TabPages.Item(Me.OldIndex), Me.TabPages.Item(e.TabPageIndex))
            End If
        End Sub
        Public Property Speed As Integer
            Get
                Return Me._Speed
            End Get
            Set(ByVal value As Integer)
                If ((value > 20) Or (value < -20)) Then
                    Interaction.MsgBox("Speed needs to be in between -20 and 20.", MsgBoxStyle.ApplicationModal, Nothing)
                Else
                    Me._Speed = value
                End If
            End Set
        End Property

        Private _Speed As Integer
        Private OldIndex As Integer
    End Class
End Namespace


