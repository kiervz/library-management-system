Imports System.Text
Imports System.Security.Cryptography

Module MD5Hasher

    Public Function GetMd5Hash(ByVal input As String)
        Dim md5Hash = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        For i As Integer = 0 To data.Length - 1 Step 1
            sBuilder.Append(data(i).ToString("X2"))
        Next

        ' Return the hexadecimal string.
        Return sBuilder.ToString()
    End Function

End Module