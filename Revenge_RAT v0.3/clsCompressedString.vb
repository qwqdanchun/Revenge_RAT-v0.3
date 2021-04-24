Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.IO.Compression
Imports System.Security.Cryptography
Imports System.Text

Namespace RevengeRAT
    Public Class clsCompressedString
        ' Methods
        Public Sub New()
            Me._UnCompressed = String.Empty
            Me._Compressed = String.Empty
            Me._TextEncoding = Encoding.UTF8
            Me._PrefixForCompressedString = String.Empty
            Me._SuffixForCompressedString = String.Empty
            Me._Passphrase = String.Empty
            Me._CompressedGiven = False
        End Sub

        Public Sub New(ByVal TextEncoding As Encoding)
            Me._UnCompressed = String.Empty
            Me._Compressed = String.Empty
            Me._TextEncoding = Encoding.UTF8
            Me._PrefixForCompressedString = String.Empty
            Me._SuffixForCompressedString = String.Empty
            Me._Passphrase = String.Empty
            Me._CompressedGiven = False
            Me._TextEncoding = TextEncoding
        End Sub

        Public Sub New(ByVal TextEncoding As Encoding, ByVal InputString As String, ByVal InputDataType As InputDataTypeClass, ByVal Optional Passphrase As String = "", ByVal Optional PrefixForCompressedString As String = "", ByVal Optional SuffixForCompressedString As String = "")
            Me._UnCompressed = String.Empty
            Me._Compressed = String.Empty
            Me._TextEncoding = Encoding.UTF8
            Me._PrefixForCompressedString = String.Empty
            Me._SuffixForCompressedString = String.Empty
            Me._Passphrase = String.Empty
            Me._CompressedGiven = False
            Me._TextEncoding = TextEncoding
            Me._PrefixForCompressedString = PrefixForCompressedString
            Me._SuffixForCompressedString = SuffixForCompressedString
            Me._Passphrase = Passphrase
            Select Case CInt(InputDataType)
                Case 1
                    Dim str As String = InputString
                    If ((str.Length > 0) And (str.Length > (Me._PrefixForCompressedString.Length + Me._SuffixForCompressedString.Length))) Then
                        If (Me._PrefixForCompressedString.Length > 0) Then
                            str = InputString.Substring(Me._PrefixForCompressedString.Length, (str.Length - Me._PrefixForCompressedString.Length))
                        End If
                        If (Me._SuffixForCompressedString.Length > 0) Then
                            str = str.Substring(0, (str.Length - Me._SuffixForCompressedString.Length))
                        End If
                    End If
                    Me._Compressed = str
                    Me._CompressedGiven = True
                    Me.Decompress()
                    Exit Select
                Case 2
                    Me._UnCompressed = InputString
                    Me.Compress()
                    Exit Select
            End Select
        End Sub

        Private Sub Compress()
            If (Me._UnCompressed.Length = 0) Then
                Me._Compressed = String.Empty
            Else
                Dim str As String = String.Empty
                Try
                    Dim buffer2 As Byte()
                    Dim bytes As Byte() = Me._TextEncoding.GetBytes(Me._UnCompressed)
                    Dim stream2 As New MemoryStream
                    Dim stream As New GZipStream(stream2, CompressionMode.Compress)
                    stream.Write(bytes, 0, bytes.Length)
                    stream.Close()

                    If (Me._Passphrase.Length > 0) Then
                        buffer2 = Me.Encrypt(stream2.ToArray)
                    Else
                        buffer2 = stream2.ToArray
                    End If
                    str = Convert.ToBase64String(buffer2)
                    stream2.Close()
                    stream.Dispose()
                    stream2.Dispose()
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                Finally
                    Me._Compressed = str
                End Try
            End If
        End Sub

        Public Shared Function Decode(ByVal Input As String) As Object
            Dim str2 As New clsCompressedString(Encoding.GetEncoding("UTF-8"))
            str2.Compressed = Input
            Return str2.UnCompressed
        End Function

        Private Sub Decompress()
            If (Me._Compressed.Length = 0) Then
                Me._UnCompressed = String.Empty
            Else
                Dim str As String = String.Empty
                Try
                    Dim buffer3 As Byte()
                    If (Me._Passphrase.Length > 0) Then
                        buffer3 = Me.Decrypt(Convert.FromBase64String(Me._Compressed))
                    Else
                        buffer3 = Convert.FromBase64String(Me._Compressed)
                    End If
                    Dim stream2 As New MemoryStream(buffer3)
                    Dim stream As New GZipStream(stream2, CompressionMode.Decompress)
                    Dim buffer As Byte() = New Byte(4 - 1) {}
                    stream2.Position = (stream2.Length - 5)
                    stream2.Read(buffer, 0, 4)
                    Dim count As Integer = BitConverter.ToInt32(buffer, 0)
                    stream2.Position = 0
                    Dim array As Byte() = New Byte(((count - 1) + 1) - 1) {}
                    stream.Read(array, 0, count)
                    stream.Dispose()
                    stream2.Dispose()
                    str = Me._TextEncoding.GetString(array)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                Finally
                    Me._UnCompressed = str
                End Try
            End If
        End Sub

        Private Function Decrypt(ByVal EncData As Byte()) As Byte()
            Dim buffer2 As Byte()
            Try
                Dim managed As New RijndaelManaged
                managed.KeySize = &H100
                managed.Key = Me.Encryption_Key
                managed.IV = Me.Encryption_IV
                Dim stream2 As New MemoryStream(EncData)
                Dim stream As New CryptoStream(stream2, managed.CreateDecryptor, CryptoStreamMode.Read)
                Dim buffer As Byte() = New Byte((EncData.Length + 1) - 1) {}
                Dim length As Integer = stream.Read(buffer, 0, EncData.Length)
                stream.Close()
                stream2.Close()
                stream.Dispose()
                stream2.Dispose()
                buffer2 = New Byte((length + 1) - 1) {}
                Array.Copy(buffer, buffer2, length)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                buffer2 = Nothing
                ProjectData.ClearProjectError()
            End Try
            Return buffer2
        End Function

        Public Shared Function Encode(ByVal Input As String) As Object
            Dim str2 As New clsCompressedString(Encoding.GetEncoding("UTF-8"))
            str2.UnCompressed = Input
            Return str2.Compressed
        End Function

        Private Function Encrypt(ByVal PlainData As Byte()) As Byte()
            Dim buffer2 As Byte()
            Try
                Dim managed As New RijndaelManaged
                managed.KeySize = &H100
                managed.Key = Me.Encryption_Key
                managed.IV = Me.Encryption_IV
                Dim stream2 As New MemoryStream
                Dim stream As New CryptoStream(stream2, managed.CreateEncryptor, CryptoStreamMode.Write)
                stream.Write(PlainData, 0, PlainData.Length)
                stream.FlushFinalBlock()
                buffer2 = stream2.ToArray
                stream.Close()
                stream2.Close()
                stream.Dispose()
                stream2.Dispose()
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                buffer2 = Nothing
                ProjectData.ClearProjectError()
            End Try
            Return buffer2
        End Function

        Private Function Encryption_IV() As Byte()
            Dim provider As New MD5CryptoServiceProvider
            Dim str As String = Convert.ToBase64String(provider.ComputeHash(Me._TextEncoding.GetBytes(Me._Passphrase)))
            Dim s As String = (Me.Passphrase & str)
            Return provider.ComputeHash(Me._TextEncoding.GetBytes(s))
        End Function

        Private Function Encryption_Key() As Byte()
            Dim managed As New SHA256Managed
            Dim str As String = Convert.ToBase64String(managed.ComputeHash(Me._TextEncoding.GetBytes(Me._Passphrase)))
            Dim s As String = (Me.Passphrase & str)
            Return managed.ComputeHash(Me._TextEncoding.GetBytes(s))
        End Function


        ' Properties
        Public Property Compressed As String
            Get
                Dim str2 As String = Me._Compressed
                If (str2.Length > 0) Then
                    If (Me._PrefixForCompressedString.Length > 0) Then
                        str2 = (Me._PrefixForCompressedString & str2)
                    End If
                    If (Me._SuffixForCompressedString.Length > 0) Then
                        str2 = (str2 & Me._SuffixForCompressedString)
                    End If
                End If
                Return str2
            End Get
            Set(ByVal value As String)
                Dim str As String = value
                If ((str.Length > 0) And (str.Length > (Me._PrefixForCompressedString.Length + Me._SuffixForCompressedString.Length))) Then
                    If (Me._PrefixForCompressedString.Length > 0) Then
                        str = value.Substring(Me._PrefixForCompressedString.Length, (str.Length - Me._PrefixForCompressedString.Length))
                    End If
                    If (Me._SuffixForCompressedString.Length > 0) Then
                        str = str.Substring(0, (str.Length - Me._SuffixForCompressedString.Length))
                    End If
                End If
                Me._Compressed = str
                Me._CompressedGiven = True
                Me.Decompress()
            End Set
        End Property

        Public Property Passphrase As String
            Get
                Return Me._Passphrase
            End Get
            Set(ByVal value As String)
                Me._Passphrase = value
                If Me._CompressedGiven Then
                    If (Me._Compressed.Length > 0) Then
                        Me.Decompress()
                    Else
                        Me._UnCompressed = String.Empty
                    End If
                ElseIf (Me._UnCompressed.Length > 0) Then
                    Me.Compress()
                Else
                    Me._Compressed = String.Empty
                End If
            End Set
        End Property

        Public Property TextEncoding As Encoding
            Get
                Return Me._TextEncoding
            End Get
            Set(ByVal value As Encoding)
                Me._TextEncoding = value
            End Set
        End Property

        Public Property UnCompressed As String
            Get
                Return Me._UnCompressed
            End Get
            Set(ByVal value As String)
                Me._UnCompressed = value
                Me._CompressedGiven = False
                Me.Compress()
            End Set
        End Property


        ' Fields
        Private _Compressed As String
        Private _CompressedGiven As Boolean
        Private _Passphrase As String
        Private _PrefixForCompressedString As String
        Private _SuffixForCompressedString As String
        Private _TextEncoding As Encoding
        Private _UnCompressed As String

        ' Nested Types
        Public Enum InputDataTypeClass
            ' Fields
            Compressed = 1
            UnCompressed = 2
        End Enum
    End Class
End Namespace

