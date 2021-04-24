Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net

Namespace RevengeRAT
    Public Class Getcountry
        Public Sub New(ByVal mss As MemoryStream)
            Me.MS = mss
        End Sub

        Public Sub New(ByVal FileLocation As String)
            Dim stream As New FileStream(FileLocation, FileMode.Open, FileAccess.Read)
            Me.MS = New MemoryStream
            Dim array As Byte() = New Byte(&H101 - 1) {}
            Do While (stream.Read(array, 0, array.Length) <> 0)
                Me.MS.Write(array, 0, array.Length)
            Loop
            stream.Close()
        End Sub

        Private Function ConvertIPAddressToNumber(ByVal IPA As IPAddress) As Long
            Dim array As String() = Strings.Split(IPA.ToString, ".", -1, CompareMethod.Binary)
            If (Information.UBound(array, 1) = 3) Then
                Return CLng(Math.Round(CDbl(((((16777216 * Conversions.ToDouble(array(0))) + (65536 * Conversions.ToDouble(array(1)))) + (256 * Conversions.ToDouble(array(2)))) + Conversions.ToDouble(array(3))))))
            End If
            Return 0
        End Function

        Private Function ConvertIPNumberToAddress(ByVal IPN As Long) As String
            Return String.Concat(New String() {Conversions.ToString(CDbl((Conversion.Int(CDbl((CDbl(IPN) / 16777216))) Mod 256))), ".", Conversions.ToString(CDbl((Conversion.Int(CDbl((CDbl(IPN) / 65536))) Mod 256))), ".", Conversions.ToString(CDbl((Conversion.Int(CDbl((CDbl(IPN) / 256))) Mod 256))), ".", Conversions.ToString(CLng((Conversion.Int(IPN) Mod &H100)))})
        End Function

        Public Shared Function FileToMemory(ByVal FileLocation As String) As MemoryStream
            Dim stream2 As New FileStream(FileLocation, FileMode.Open, FileAccess.Read)
            Dim stream3 As New MemoryStream
            Dim array As Byte() = New Byte(&H101 - 1) {}
            Do While (stream2.Read(array, 0, array.Length) <> 0)
                stream3.Write(array, 0, array.Length)
            Loop
            stream2.Close()
            Return stream3
        End Function

        Public Function LookupCountryCode(ByVal IPA As IPAddress) As String
            Return Getcountry.CountryCode(CInt(Me.SeekCountry(0, Me.ConvertIPAddressToNumber(IPA), &H1F)))
        End Function

        Public Function LookupCountryCode(ByVal IPA As String) As String
            Dim address As IPAddress
            Try
                address = IPAddress.Parse(IPA)
            Catch exception1 As FormatException
                ProjectData.SetProjectError(exception1)
                Dim exception As FormatException = exception1
                Dim str As String = "--"
                ProjectData.ClearProjectError()
                Return str
                ProjectData.ClearProjectError()
            End Try
            Return Me.LookupCountryCode(address)
        End Function

        Public Function LookupCountryName(ByVal addr As IPAddress) As String
            Return Getcountry.CountryName(CInt(Me.SeekCountry(0, Me.ConvertIPAddressToNumber(addr), &H1F)))
        End Function

        Public Function LookupCountryName(ByVal IPA As String) As String
            Dim address As IPAddress
            Try
                address = IPAddress.Parse(IPA)
            Catch exception1 As FormatException
                ProjectData.SetProjectError(exception1)
                Dim exception As FormatException = exception1
                Dim str As String = "N/A"
                ProjectData.ClearProjectError()
                Return str
                ProjectData.ClearProjectError()
            End Try
            Return Me.LookupCountryName(address)
        End Function

        Public Function LookupCountryNump(ByVal IPA As IPAddress) As String
            Return Getcountry.CountryNump(CInt(Me.SeekCountry(0, Me.ConvertIPAddressToNumber(IPA), &H1F)))
        End Function

        Public Function LookupCountryNump(ByVal IPA As String) As String
            Dim address As IPAddress
            Try
                address = IPAddress.Parse(IPA)
            Catch exception1 As FormatException
                ProjectData.SetProjectError(exception1)
                Dim exception As FormatException = exception1
                Dim str As String = "--"
                ProjectData.ClearProjectError()
                Return str
                ProjectData.ClearProjectError()
            End Try
            Return Me.LookupCountryNump(address)
        End Function

        Private Function SeekCountry(ByVal StartOffset As Long, ByVal IPNumber As Long, ByVal SearchDepth As Integer) As Long
            Dim num6 As Integer
            Dim buffer As Byte() = New Byte(7 - 1) {}
            Dim numArray As Long() = New Long(3 - 1) {}
            If (SearchDepth = 0) Then
            End If
            Try
                Me.MS.Seek((6 * StartOffset), SeekOrigin.Begin)
                Me.MS.Read(buffer, 0, 6)
            Catch exception1 As IOException
                ProjectData.SetProjectError(exception1)
                Dim exception As IOException = exception1
                ProjectData.ClearProjectError()
            End Try
            Dim index As Integer = 0
            Do
                numArray(index) = 0
                Dim num3 As Integer = 0
                Do
                    Dim num4 As Integer = buffer(((index * 3) + num3))
                    If (num4 < 0) Then
                        num4 = (num4 + &H100)
                    End If
                    Dim numArray2 As Long() = numArray
                    Dim num5 As Integer = index
                    numArray2(num5) = (numArray2(num5) + Me.vbShiftLeft(CLng(num4), (num3 * 8)))
                    num3 += 1
                    num6 = 2
                Loop While (num3 <= num6)
                index += 1
                num6 = 1
            Loop While (index <= num6)
            If ((IPNumber And Me.vbShiftLeft(1, SearchDepth)) > 0) Then
                If (numArray(1) >= Getcountry.CountryBegin) Then
                    Return (numArray(1) - Getcountry.CountryBegin)
                End If
                Return Me.SeekCountry(numArray(1), IPNumber, (SearchDepth - 1))
            End If
            If (numArray(0) >= Getcountry.CountryBegin) Then
                Return (numArray(0) - Getcountry.CountryBegin)
            End If
            Return Me.SeekCountry(numArray(0), IPNumber, (SearchDepth - 1))
        End Function

        Private Function vbShiftLeft(ByVal Value As Long, ByVal Count As Integer) As Long
            Dim num2 As Long = Value
            Dim num3 As Integer = Count
            Dim i As Integer = 1
            Do While (i <= num3)
                num2 = (num2 * 2)
                i += 1
            Loop
            Return num2
        End Function

        Private Function vbShiftRight(ByVal Value As Long, ByVal Count As Integer) As Long
            Dim num2 As Long = Value
            Dim num3 As Integer = Count
            Dim i As Integer = 1
            Do While (i <= num3)
                num2 = (num2 / 2)
                i += 1
            Loop
            Return num2
        End Function


        ' Fields
        Private Shared CountryBegin As Long = &HFFFF00
        Private Shared CountryCode As String() = New String() {"--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AN", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "FX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "Palestine", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "SAU", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF"}
        Private Shared CountryName As String() = New String() {"Unknown", "Asia/Pacific Region", "European Union", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua & Barbuda", "Anguilla", "Albania", "Armenia", "Netherlands Antilles", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia & Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cook Islands", "Democratic Republic of the Congo", "Central African Republic", "Congo-Brazzaville", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia", "Faroes", "France", "France, Metropolitan", "Gabon", "United Kingdom", "Grenada", "GeorgiaGermany", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Occupied Palestinian Territory", "India", "British Indian Ocean Territory", "Iraq", "Islamic Republic of Iran", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "St Kitts & Nevis", "North Korea", "South Korea", "Kuwait", "Cayman Islands", "Kazakhstan", "Laos", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macao", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "Tahiti (French Polinesia)", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory, Occupied", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome & Principe", "El Salvador", "Syria", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad & Tobago", "Tuvalu", "Taiwan", "Tanzania", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States of America", "Uruguay", "Uzbekistan", "Vatican City", "St Vincent & the Grenadines", "Venezuela", "Virgin Islands British", "Virgin Islands US", "Viet Nam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin"}
        Private Shared CountryNump As String() = New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254"}
        Public MS As MemoryStream
    End Class
End Namespace


