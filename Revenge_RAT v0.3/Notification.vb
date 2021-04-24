Imports System.Drawing.Drawing2D
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class Notification
    Private v As Integer
    Private V2 As Integer
    Private Const WS_EX_NOACTIVATE As Integer = &H8000000
    Public Sub New()
        Me.v = 0
        Me.V2 = 100
        Me.InitializeComponent()
    End Sub
    Public Sub KILLFORM()
        Me.Timer1.Enabled = False
        Me.Timer1.Stop()
        Me.T.Stop()
        Me.T.Enabled = False
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.KILLFORM()
    End Sub

    Private Sub Notification_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        e.Graphics.DrawLine(New Pen(XylosTabControl.CoverC, 2.0!), 0, 0, 350, 0)
        e.Graphics.DrawLine(New Pen(XylosTabControl.CoverC, 2.0!), 0, 0, 0, 100)
        e.Graphics.DrawLine(New Pen(XylosTabControl.CoverC, 2.0!), 300, 0, 300, &H63)
        e.Graphics.DrawLine(New Pen(XylosTabControl.CoverC, 2.0!), 0, 70, 300, 70)
        e.Graphics.DrawLine(New Pen(XylosTabControl.CoverC, 2.0!), &H54, 30, &H125, 30)
    End Sub

    Private Sub T_Tick(sender As Object, e As EventArgs) Handles T.Tick
        If (Me.v <= 100) Then
            Me.Opacity = (0.1 + (CDbl(Me.v) / 100))
        End If
        Me.v += 1
        If (Me.v = &HAF) Then
            Me.v = 0
            Me.T.Enabled = False
            Me.T.Stop()
            Me.Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = (0.1 + (CDbl(Me.V2) / 100))
        Me.V2 -= 1
        If (Me.V2 = 0) Then
            Me.KILLFORM()
        End If
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim createParamsss As CreateParams = MyBase.CreateParams
            createParamsss.ExStyle = (createParamsss.ExStyle Or &H8000000)
            Return createParamsss
        End Get
    End Property

End Class