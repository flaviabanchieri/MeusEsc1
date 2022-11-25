Imports System.Globalization

Module Module1
    Public Function UpperCase(str As String) As String
        UpperCase =
            CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower())
    End Function

    Public Function UpperCasename(nome As String) As String
        Dim result = ""
        Dim palavrasex = {"da", "de", "di", "do", "du", "e"}
        Dim palavras = nome.Split("")

        For Each palavra In palavras
            If palavrasex.Contains(palavra) Then
                result += palavra + " "
            Else
                result += UpperCase(palavra) + " "
            End If

        Next
        result = result.Trim()
        UpperCasename = result

    End Function
End Module
