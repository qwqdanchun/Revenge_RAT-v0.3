Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.Imaging
Imports System.IO
Public Class CP
    Public OS As Integer
    Public PP As Boolean
    Public Sock As Integer
    Private Sub Addd_Click(sender As Object, e As EventArgs) Handles Addd.Click
        Dim dialog As New OpenFileDialog
        Dim dialog2 As OpenFileDialog = dialog
        dialog.Title = "Select client display picture"
        dialog.Filter = "Display picture |*.png"
        dialog.ShowDialog()
        dialog2 = Nothing
        Try
            Dim ch As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & Conversions.ToString(Me.OS))), CH)
            If Not Me.PP Then
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"CLDP", My.Forms.Main.Key, Convert.ToBase64String(File.ReadAllBytes(dialog.FileName)), My.Forms.Main.Key, Conversions.ToString(False)}))
                ch.PictureBox1.ImageLocation = dialog.FileName
            Else
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"ADP", My.Forms.Main.Key, Convert.ToBase64String(File.ReadAllBytes(dialog.FileName)), My.Forms.Main.Key, Conversions.ToString(False)}))
                ch.PictureBox2.ImageLocation = dialog.FileName
            End If
            Me.Close()
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.Lim1.SelectedItems.Count <> 0) Then
            Dim ch As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & Conversions.ToString(Me.OS))), CH)
            If Not Me.PP Then
                ch.PictureBox1.Image = Me.ImageList1.Images.Item(Conversions.ToInteger(Me.Lim1.SelectedItems.Item(0).Text))
            Else
                ch.PictureBox2.Image = Me.ImageList1.Images.Item(Conversions.ToInteger(Me.Lim1.SelectedItems.Item(0).Text))
            End If
            Dim stream As New MemoryStream
            Dim bitmap As New Bitmap(Me.ImageList1.Images.Item(Conversions.ToInteger(Me.Lim1.SelectedItems.Item(0).Text)))
            Dim info As ImageCodecInfo = Me.GetEncoder(ImageFormat.Jpeg)
            Dim quality As Encoder = Encoder.Quality
            Dim encoderParams As New EncoderParameters(1)
            Dim parameter As New EncoderParameter(quality, 100)
            encoderParams.Param(0) = parameter
            bitmap.Save(stream, info, encoderParams)
            If Not Me.PP Then
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"CLDP", My.Forms.Main.Key, Convert.ToBase64String(stream.ToArray), My.Forms.Main.Key, Conversions.ToString(False)}))
            Else
                My.Forms.Main.s.Send(Me.Sock, String.Concat(New String() {"ADP", My.Forms.Main.Key, Convert.ToBase64String(stream.ToArray), My.Forms.Main.Key, Conversions.ToString(False)}))
            End If
            Me.Close()
        End If
    End Sub

    Private Sub CP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim num2 As Integer = (Me.ImageList1.Images.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            Me.Lim1.Items.Add(i.ToString, i)
            i += 1
        Loop
    End Sub
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
        Dim info As ImageCodecInfo
        For Each info In ImageCodecInfo.GetImageDecoders
            If (info.FormatID = format.Guid) Then
                Return info
            End If
        Next
        Return Nothing
    End Function

End Class