Imports System.ComponentModel

Namespace RevengeRAT
    <DefaultEvent("ToggleChanged")>
    Public Class ToggleSwitch
        Inherits Panel
        Private SliderBackColorChangedEvent As ToggleSwitch.SliderBackColorChangedEventHandler
        Private SliderWidthChangedEvent As ToggleSwitch.SliderWidthChangedEventHandler
        Private ToggleChangedEvent As ToggleSwitch.ToggleChangedEventHandler
        Private ToggleFalseBackColorChangedEvent As ToggleSwitch.ToggleFalseBackColorChangedEventHandler
        Private ToggleTrueBackColorChangedEvent As ToggleSwitch.ToggleTrueBackColorChangedEventHandler
        Public Custom Event SliderBackColorChanged As SliderBackColorChangedEventHandler
            AddHandler(value As SliderBackColorChangedEventHandler)
                Me.SliderBackColorChangedEvent = CType([Delegate].Combine(Me.SliderBackColorChangedEvent, value), ToggleSwitch.SliderBackColorChangedEventHandler)
            End AddHandler
            RemoveHandler(value As SliderBackColorChangedEventHandler)
                Me.SliderBackColorChangedEvent = CType([Delegate].Remove(Me.SliderBackColorChangedEvent, value), ToggleSwitch.SliderBackColorChangedEventHandler)
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)

            End RaiseEvent
        End Event
        Public Custom Event SliderWidthChanged As SliderWidthChangedEventHandler
            AddHandler(value As SliderWidthChangedEventHandler)
                Me.SliderWidthChangedEvent = CType([Delegate].Combine(Me.SliderWidthChangedEvent, value), ToggleSwitch.SliderWidthChangedEventHandler)
            End AddHandler
            RemoveHandler(value As SliderWidthChangedEventHandler)
                Me.SliderWidthChangedEvent = CType([Delegate].Remove(Me.SliderWidthChangedEvent, value), ToggleSwitch.SliderWidthChangedEventHandler)
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)

            End RaiseEvent
        End Event
        Public Custom Event ToggleChanged As ToggleChangedEventHandler
            AddHandler(value As ToggleChangedEventHandler)
                Me.ToggleChangedEvent = CType([Delegate].Combine(Me.ToggleChangedEvent, value), ToggleSwitch.ToggleChangedEventHandler)
            End AddHandler
            RemoveHandler(value As ToggleChangedEventHandler)
                Me.ToggleChangedEvent = CType([Delegate].Remove(Me.ToggleChangedEvent, value), ToggleSwitch.ToggleChangedEventHandler)
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)

            End RaiseEvent
        End Event
        Public Custom Event ToggleFalseBackColorChanged As ToggleFalseBackColorChangedEventHandler
            AddHandler(value As ToggleFalseBackColorChangedEventHandler)
                Me.ToggleFalseBackColorChangedEvent = CType([Delegate].Combine(Me.ToggleFalseBackColorChangedEvent, value), ToggleSwitch.ToggleFalseBackColorChangedEventHandler)
            End AddHandler
            RemoveHandler(value As ToggleFalseBackColorChangedEventHandler)
                Me.ToggleFalseBackColorChangedEvent = CType([Delegate].Remove(Me.ToggleFalseBackColorChangedEvent, value), ToggleSwitch.ToggleFalseBackColorChangedEventHandler)
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)

            End RaiseEvent
        End Event
        Public Custom Event ToggleTrueBackColorChanged As ToggleTrueBackColorChangedEventHandler
            AddHandler(value As ToggleTrueBackColorChangedEventHandler)
                Me.ToggleTrueBackColorChangedEvent = CType([Delegate].Combine(Me.ToggleTrueBackColorChangedEvent, value), ToggleSwitch.ToggleTrueBackColorChangedEventHandler)
            End AddHandler
            RemoveHandler(value As ToggleTrueBackColorChangedEventHandler)
                Me.ToggleTrueBackColorChangedEvent = CType([Delegate].Remove(Me.ToggleTrueBackColorChangedEvent, value), ToggleSwitch.ToggleTrueBackColorChangedEventHandler)
            End RemoveHandler
            RaiseEvent(sender As Object, e As EventArgs)

            End RaiseEvent
        End Event

        ' Methods
        Public Sub New()
            AddHandler MyBase.Click, New EventHandler(AddressOf Me.ToggleSwitch_Click)
            AddHandler SliderBackColorChanged, New SliderBackColorChangedEventHandler(AddressOf Me.ToggleSwitch_SliderBackColorChanged)
            AddHandler SliderWidthChanged, New SliderWidthChangedEventHandler(AddressOf Me.ToggleSwitch_SliderWidthChanged)
            AddHandler MyBase.Resize, New EventHandler(AddressOf Me.ToggleSwitch_SliderWidthChanged)
            AddHandler ToggleChanged, New ToggleChangedEventHandler(AddressOf Me.ToggleSwitch_ToggleChanged)
            AddHandler ToggleFalseBackColorChanged, New ToggleFalseBackColorChangedEventHandler(AddressOf Me.ToggleSwitch_ToggleChanged)
            AddHandler ToggleTrueBackColorChanged, New ToggleTrueBackColorChangedEventHandler(AddressOf Me.ToggleSwitch_ToggleChanged)
            Me._sliderBackColor = Color.White
            Me._sliderWidth = 25.0!
            Me._toggle = False
            Me._toggleFalseBackColor = Color.Gray
            Me._toggleTrueBackColor = Color.CornflowerBlue
            Dim button As New Button
            button.BackColor = Me.SliderBackColor
            button.FlatStyle = FlatStyle.Popup
            Dim padding As New Padding(1)
            button.Margin = padding
            button.Text = String.Empty
            button.Width = Convert.ToInt32(CSng(((Me.SliderWidth / 100.0!) * Me.ClientSize.Width)))
            Me.btnToggle = button
            AddHandler Me.btnToggle.Click, New EventHandler(AddressOf Me.controls_Click)
            Me.Controls.Add(Me.btnToggle)
            If Me.Toggle Then
                Me.SetToggleTrue()
            Else
                Me.SetToggleFalse()
            End If
        End Sub
        Private Sub controls_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Toggle = Not Me.Toggle
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim clientRectangle As Rectangle = Me.ClientRectangle
            ControlPaint.DrawBorder3D(e.Graphics, clientRectangle, Border3DStyle.Flat)
        End Sub

        Protected Overridable Sub OnSliderBackColorChanged()
            Dim sliderBackColorChangedEvent As SliderBackColorChangedEventHandler = Me.SliderBackColorChangedEvent
            If (Not sliderBackColorChangedEvent Is Nothing) Then
                sliderBackColorChangedEvent.Invoke(Me, EventArgs.Empty)
            End If
        End Sub

        Protected Overridable Sub OnSliderWidthChanged()
            Dim sliderWidthChangedEvent As SliderWidthChangedEventHandler = Me.SliderWidthChangedEvent
            If (Not sliderWidthChangedEvent Is Nothing) Then
                sliderWidthChangedEvent.Invoke(Me, EventArgs.Empty)
            End If
        End Sub

        Protected Overridable Sub OnToggleChanged()
            Dim toggleChangedEvent As ToggleChangedEventHandler = Me.ToggleChangedEvent
            If (Not toggleChangedEvent Is Nothing) Then
                toggleChangedEvent.Invoke(Me, EventArgs.Empty)
            End If
        End Sub

        Protected Overridable Sub OnToggleFalseBackColorChanged()
            Dim toggleFalseBackColorChangedEvent As ToggleFalseBackColorChangedEventHandler = Me.ToggleFalseBackColorChangedEvent
            If (Not toggleFalseBackColorChangedEvent Is Nothing) Then
                toggleFalseBackColorChangedEvent.Invoke(Me, EventArgs.Empty)
            End If
        End Sub

        Protected Overridable Sub OnToggleTrueBackColorChanged()
            Dim toggleTrueBackColorChangedEvent As ToggleTrueBackColorChangedEventHandler = Me.ToggleTrueBackColorChangedEvent
            If (Not toggleTrueBackColorChangedEvent Is Nothing) Then
                toggleTrueBackColorChangedEvent.Invoke(Me, EventArgs.Empty)
            End If
        End Sub

        Private Sub SetToggleFalse()
            Me.BackColor = Me._toggleFalseBackColor
            Me.btnToggle.Dock = DockStyle.Left
        End Sub

        Private Sub SetToggleTrue()
            Me.BackColor = Me._toggleTrueBackColor
            Me.btnToggle.Dock = DockStyle.Right
        End Sub

        Private Sub ToggleSwitch_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Toggle = Not Me.Toggle
        End Sub

        Private Sub ToggleSwitch_SliderBackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnToggle.BackColor = Me.SliderBackColor
        End Sub

        Private Sub ToggleSwitch_SliderWidthChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.btnToggle.Width = Convert.ToInt32(CSng(((Me.SliderWidth / 100.0!) * Me.ClientSize.Width)))
        End Sub

        Private Sub ToggleSwitch_ToggleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Toggle Then
                Me.SetToggleTrue()
            Else
                Me.SetToggleFalse()
            End If
        End Sub


        ' Properties
        Public Property SliderBackColor As Color
            Get
                Return Me._sliderBackColor
            End Get
            Set(ByVal value As Color)
                If (Me._sliderBackColor <> value) Then
                    Me._sliderBackColor = value
                    Me.OnSliderBackColorChanged()
                End If
            End Set
        End Property

        Public Property SliderWidth As Single
            Get
                Return Me._sliderWidth
            End Get
            Set(ByVal value As Single)
                If (((Me._sliderWidth <> value) AndAlso (value > 0!)) AndAlso (value <= 100.0!)) Then
                    Me._sliderWidth = value
                    Me.OnSliderWidthChanged()
                End If
            End Set
        End Property

        Public Property Toggle As Boolean
            Get
                Return Me._toggle
            End Get
            Set(ByVal value As Boolean)
                If (Me._toggle <> value) Then
                    Me._toggle = value
                    Me.OnToggleChanged()
                End If
            End Set
        End Property

        Public Property ToggleFalseBackColor As Color
            Get
                Return Me._toggleFalseBackColor
            End Get
            Set(ByVal value As Color)
                If (Me._toggleFalseBackColor <> value) Then
                    Me._toggleFalseBackColor = value
                    Me.OnToggleFalseBackColorChanged()
                End If
            End Set
        End Property

        Public Property ToggleTrueBackColor As Color
            Get
                Return Me._toggleTrueBackColor
            End Get
            Set(ByVal value As Color)
                If (Me._toggleTrueBackColor <> value) Then
                    Me._toggleTrueBackColor = value
                    Me.OnToggleTrueBackColorChanged()
                End If
            End Set
        End Property


        Private _sliderBackColor As Color
        Private _sliderWidth As Single
        Private _toggle As Boolean
        Private _toggleFalseBackColor As Color
        Private _toggleTrueBackColor As Color
        Private btnToggle As Button

        Public Delegate Sub SliderBackColorChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Delegate Sub SliderWidthChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Delegate Sub ToggleChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Delegate Sub ToggleFalseBackColorChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Public Delegate Sub ToggleTrueBackColorChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
    End Class
End Namespace


