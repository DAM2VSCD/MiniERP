Module PedidosFuncionesAuxiliares

    ' Cambia una etiqueta de HORA al valor que le corresponde.
    Public Sub actualizaEtiquetaHora(ByRef txt As TextBox, ByRef date1 As Date)
        txt.Text = date1.Hour & ":" & date1.Minute & ":" & date1.Second
    End Sub

    ' Cambia una etiqueta de DATE (año, mes, día) al valor que le corresponde.
    Public Sub actualizaEtiquetaFecha(ByRef txt As TextBox, ByRef date1 As Date)
        txt.Text = date1.Year & "-" & date1.Month & "-" & date1.Day
    End Sub

    ' Determina si un Double es un entero mayor que cero.
    Function esUnDoubleMayorQueCero(ByVal candidato As String, ByRef numero As Double) As Boolean
        Dim esDoublePositivo As Boolean = False
        Try
            Convert.ToDouble(candidato)
            If (Convert.ToDouble(candidato) > 0) Then
                esDoublePositivo = True
                numero = Convert.ToDouble(candidato)
            End If
        Catch ex As Exception
            ' No hace nada.
        End Try
        
        Return esDoublePositivo
    End Function

    ' Determina si un String es un entero mayor o igual que cero.
    Function esUnEnteroNoNegativo(ByVal candidato As String, ByRef numero As Integer) As Boolean
        Dim esEnteroPositivo As Boolean = False
        Try
            Convert.ToInt32(candidato)
            If (Convert.ToInt32(candidato) >= 0) Then
                esEnteroPositivo = True
                numero = Convert.ToInt32(candidato)
            End If
        Catch ex As Exception
            ' No hace nada.
        End Try
        
        Return esEnteroPositivo
    End Function

    ' Determina si un String es un entero mayor que cero.
    Function esUnEnteroMayorDeCero(ByVal candidato As String, ByRef numero As Integer) As Boolean
        Dim esEnteroPositivo As Boolean = False
        Try
            Convert.ToInt32(candidato)
            If (Convert.ToInt32(candidato) > 0) Then
                esEnteroPositivo = True
                numero = Convert.ToInt32(candidato)
            End If
        Catch ex As Exception
            ' No hace nada.
        End Try

        Return esEnteroPositivo
    End Function

    ' Comprueba un evento de pulsación, si se ha escrito algo distinto de números o letras normales marca error.
    ' Sigue permitiendo poner DELETE, SUBTRACT Y SPACE.
    Public Function seMarcoLetraProhibida(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        Dim SePulsoTipoProhibido As Boolean = False

        If (e.KeyData > Keys.D9 Or e.KeyData < Keys.D0) And (e.KeyData > Keys.Z Or e.KeyData < Keys.A) Then
            If (Keys.Delete And e.KeyData <> Keys.Subtract And e.KeyData <> Keys.Back And e.KeyData <> Keys.Space) Then
                e.SuppressKeyPress = True
                SePulsoTipoProhibido = True
            End If
        End If

        Return SePulsoTipoProhibido
    End Function

    ' Comprueba un evento de pulsación, si se ha escrito algo distinto de números.
    ' Sigue permitiendo poner DELETE, SUBTRACT Y SPACE.
    Public Function seMarcoNoCifra(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        Dim SePulsoTipoProhibido As Boolean = False

        If e.KeyData > Keys.D9 Or e.KeyData < Keys.D0 Then
            If (Keys.Delete And e.KeyData <> Keys.Subtract And e.KeyData <> Keys.Back And e.KeyData <> Keys.Space) Then
                e.SuppressKeyPress = True
                SePulsoTipoProhibido = True
            End If
        End If

        Return SePulsoTipoProhibido
    End Function

    ' Comprueba un evento de pulsación, si se ha escrito algo distinto letras normales marca error.
    ' Sigue permitiendo poner DELETE, SUBTRACT Y SPACE.
    Public Function seMarcoNoLetraAlfabeto(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        Dim SePulsoTipoProhibido As Boolean = False

        If (e.KeyData > Keys.Z Or e.KeyData < Keys.A) Then
            If (Keys.Delete And e.KeyData <> Keys.Subtract And e.KeyData <> Keys.Back And e.KeyData <> Keys.Space) Then
                e.SuppressKeyPress = True
                SePulsoTipoProhibido = True
            End If
        End If

        Return SePulsoTipoProhibido
    End Function


End Module
