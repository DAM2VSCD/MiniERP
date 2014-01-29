Imports System.Text.RegularExpressions

Module validacionesNumeros


    Function esUnFloat(ByVal numero As String) As Boolean
        Dim valida = "^\d{1,7}(?:,\d{1,2})?$"

        If Regex.IsMatch(numero, valida) Then
            Return True
        Else
            Return False
        End If

    End Function

    ' Determina si un candidato dado como String es un Double.
    ' Si es Double, por referencia asigna a un Dim numero As Double el valor de la conversión.
    Function esUnDouble(ByVal candidato As String, ByRef numero As Double) As Boolean
        Dim esDoublePositivo As Boolean = False
        Try
            Convert.ToDouble(candidato)
            esDoublePositivo = True
            numero = Convert.ToDouble(candidato)
        Catch ex As Exception
            ' No hace nada.
        End Try

        Return esDoublePositivo
    End Function


End Module
