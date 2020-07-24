﻿Imports System.Text.RegularExpressions

Class NumLetra
    Private UNIDADES As String() = {"", "Un ", "Dos ", "Tres ", "Cuatro ", "Cinco ", "Seis ", "Siete ", "Ocho ", "Nueve "}
    Private DECENAS As String() = {"Diez ", "Once ", "Doce ", "Trece ", "Catorce ", "Quince ", "Dieciséis ", "Diecisiete ", "Dieciocho ", "Diecinueve ", "Veinte ", "Veintiún ", "Veintidós ", "Veintitrés ", "Veinticuatro ", "Veinticinco ", "Veintiséis ", "Veintisiete ", "Veintiocho ", "Veintinueve ", "Treinta ", "Cuarenta ", "Cincuenta ", "Sesenta ", "Setenta ", "Ochenta ", "Noventa "}
    Private CENTENAS As String() = {"", "Ciento ", "Doscientos ", "Trescientos ", "Cuatrocientos ", "Quinientos ", "Seiscientos ", "Setecientos ", "Ochocientos ", "Novecientos "}
    Private r As Regex

    Public Function Convertir(ByVal numero As String, ByVal mayusculas As Boolean) As String
        Dim literal As String = ""
        Dim parte_decimal As String
        numero = numero.Replace(".", ",")

        If numero.IndexOf(",") = -1 Then
            numero = numero & ",00"
        End If

        r = New Regex("\d{1,9},\d{1,2}")
        Dim mc As System.Text.RegularExpressions.MatchCollection = r.Matches(numero)

        If mc.Count > 0 Then
            Dim Num As String() = numero.Split(","c)
            parte_decimal = Convert.ToInt64(Num(1) * 10).ToString("00") & "/100 M.N."

            If Integer.Parse(Num(0)) = 0 Then
                literal = "Cero "
            ElseIf Integer.Parse(Num(0)) > 999999 Then
                literal = getMillones(Num(0))
            ElseIf Integer.Parse(Num(0)) > 999 Then
                literal = getMiles(Num(0))
            ElseIf Integer.Parse(Num(0)) > 99 Then
                literal = getCentenas(Num(0))
            ElseIf Integer.Parse(Num(0)) > 9 Then
                literal = getDecenas(Num(0))
            Else
                literal = getUnidades(Num(0))
            End If

            If mayusculas Then
                Return "(" & (literal & " PESOS " + parte_decimal).ToUpper() & ")"
            Else
                Return "(" & (literal & " Pesos " + parte_decimal) & ")"
            End If
        Else
            Return CSharpImpl.__Assign(literal, Nothing)
        End If
    End Function

    Private Function getUnidades(ByVal numero As String) As String
        Dim num As String = numero.Substring(numero.Length - 1)
        Return UNIDADES(Integer.Parse(num))
    End Function

    Private Function getDecenas(ByVal num As String) As String
        Dim n As Integer = Integer.Parse(num)

        If n < 10 Then
            Return getUnidades(num)
        ElseIf n > 29 Then
            Dim u As String = getUnidades(num)

            If u.Equals("") Then
                Return DECENAS(Integer.Parse(num.Substring(0, 1)) + 17)
            Else
                Return DECENAS(Integer.Parse(num.Substring(0, 1)) + 17) & "y " + u
            End If
        Else
            Return DECENAS(n - 10)
        End If
    End Function

    Private Function getCentenas(ByVal num As String) As String
        If Integer.Parse(num) > 99 Then

            If Integer.Parse(num) = 100 Then
                Return " Cien "
            Else
                Return CENTENAS(Integer.Parse(num.Substring(0, 1))) + getDecenas(num.Substring(1))
            End If
        Else
            Return getDecenas(Integer.Parse(num) & "")
        End If
    End Function

    Private Function getMiles(ByVal numero As String) As String
        Dim c As String = numero.Substring(numero.Length - 3)
        Dim m As String = numero.Substring(0, numero.Length - 3)
        Dim n As String = ""

        If Integer.Parse(m) > 0 Then
            n = getCentenas(m)
            Return n & "Mil " + getCentenas(c)
        Else
            Return "" & getCentenas(c)
        End If
    End Function

    Private Function getMillones(ByVal numero As String) As String
        Dim miles As String = numero.Substring(numero.Length - 6)
        Dim millon As String = numero.Substring(0, numero.Length - 6)
        Dim n As String = ""

        If millon.Length > 1 Then
            n = getCentenas(millon) & "Millones "
        Else
            n = getUnidades(millon) & "Millon "
        End If

        Return n + getMiles(miles)
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class

