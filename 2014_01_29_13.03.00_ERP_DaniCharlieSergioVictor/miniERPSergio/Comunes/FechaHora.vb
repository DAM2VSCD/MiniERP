Module FechaHora

    '-----------------------------------------------------------

    ' CAMBIOS DE SERGIO
    Sub rellenaComboEnteros(ByRef combo As ComboBox, ByVal valorMenor As Integer, ByVal valorMayor As Integer, ByVal paso As Integer, ByVal textoInicial As String, ByVal indiceElegidoInicial As Integer)
        combo.Items.Clear()

        If Not textoInicial Is Nothing Then
            combo.Items.Add(textoInicial)
        End If
        For i = valorMenor To valorMayor Step paso
            combo.Items.Add(i)
        Next

        If indiceElegidoInicial <> -1 Then
            combo.SelectedIndex = indiceElegidoInicial
        End If

    End Sub


    '-------------------------------------------

    Function Fecha2number(ByVal dt As Date) As Integer

        Dim fecha_num As Integer

        'Formateamos como numero la fecha
        'Ej 28/10/2013 --> 20131028
        fecha_num = dt.Year * 10000 + dt.Month * 100 + dt.Day

        Return fecha_num
    End Function

    Function hora2number(ByVal dt As Date) As Integer

        Dim hora_num As Integer

        'Formateamos como numero la hora
        'Ej 12:25:38 --> 122538
        hora_num = dt.Hour * 10000 + dt.Minute * 100 + dt.Second

        Return hora_num

    End Function

    Sub inserta_fecha_number_BD(ByVal dt As Date)

        'Recuperamos la fecha en formato numérico
        Dim fechan = Fecha2number(dt)

        'Recuperamos la hora en formato numérico
        Dim horan = hora2number(dt)

        'Insertamos en la base de datos.
        Dim cDB As New ConnectDB()
        cDB.setData("INSERT INTO FECHA_HORA VALUES(" & fechan & "," & horan & ")")


    End Sub

    Function number2Date(ByVal fecha As Integer, ByVal hora As Integer) As Date

        Dim anio, mes, dia, h, m, s As Integer
        Dim f, t As String
        Dim fecha_completa As Date

        f = fecha
        t = hora

        'Se completa la fecha si el año es menor de 1000, de 100 o de 10
        If fecha < 100000 Then
            f = "000" & fecha
        ElseIf fecha < 1000000 Then
            f = "00" & fecha
        ElseIf fecha < 10000000 Then
            f = "0" & fecha
        End If

        'Se completa el tiempo si los segundos fueran menor de 10 o 0 o si los 
        'minutos fueran menores de 10, o 0, o la hora menor de 10 o 0
        If hora = 0 Then
            t = "000000"
        ElseIf hora < 10 Then
            t = "00000" & hora
        ElseIf hora < 100 Then
            t = "0000" & hora
        ElseIf hora < 1000 Then
            t = "000" & hora
        ElseIf hora < 10000 Then
            t = "00" & hora
        ElseIf hora < 100000 Then
            t = "0" & hora
        End If


        'Separamos los elementos de la fecha
        anio = f.Substring(0, 4)
        mes = f.Substring(4, 2)
        dia = f.Substring(6, 2)

        'Separamos los elementos de la hora
        h = t.Substring(0, 2)
        m = t.Substring(2, 2)
        s = t.Substring(4, 2)

        'Montamos el objeto Date
        fecha_completa = New Date(anio, mes, dia, h, m, s)

        Return fecha_completa
    End Function

End Module
