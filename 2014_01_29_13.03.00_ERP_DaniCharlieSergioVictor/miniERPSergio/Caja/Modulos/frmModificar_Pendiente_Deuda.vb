Public Class frmModificar_Pendiente_Deuda

    ' id de la deuda o cobro pendiente a cambiar.
    Private idPendienteDeuda As Integer

    ' Tipo de problema que se está solventando.
    ' tipo = 0 -- > deuda.
    ' tipo = 1 -- > pendiente
    Private tipoOperacionRealizar As Integer

    ' Atributos usados a la hora de modificar una deuda o un pendiente de cobro.
    Private importeViejo, importeNuevo As Double

    Public Property ppIdPendienteDeuda As Integer
        Get
            Return idPendienteDeuda
        End Get
        Set(ByVal value As Integer)
            idPendienteDeuda = value
        End Set
    End Property

    Public Property ppTipoOperacionRealizar As Integer
        Get
            Return tipoOperacionRealizar
        End Get
        Set(ByVal value As Integer)
            tipoOperacionRealizar = value
        End Set
    End Property

    

    Private Sub frmModificar_Pendiente_Deuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal

        Me.TopMost = True



        realizaOperacionesIniciales()

        compruebaImporte()

    End Sub

    Private Sub frmModificar_Pendientes_Deuda_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not frmNuevoCaja.Visible Then
            frmCaja.Enabled = True
        End If
    End Sub

    ' Operaciones automáticas. Algunas dependen de si es deuda o no.
    Private Sub realizaOperacionesIniciales()
        inhabilitaClickDerecho(txtImporte)

        lblTipoOperacion.Text = "Cantidad a ingresar"

        If tipoOperacionRealizar = 0 Then
            lblTipoOperacion.Text = "Cantidad a pagar"
        End If

        ' Se obtiene la cantidad máxima a pagar.
        dameCantidadMaxima()

    End Sub

    ' Obtiene la cantidad máxima que se puede pagar o cobrar.
    Public Function dameCantidadMaxima() As Double
        Dim cantidadMaxima As Double = 0

        ' Se anota el cambio en el log.
        Dim dataSetUsado As DataSet = conexion.getData("select IMPORTE from caja_cobrodeudas where id = " & idPendienteDeuda, "tabla")
        Dim tablaUsada As DataTable = dataSetUsado.Tables("tabla")
        Dim filaUsada As DataRow = tablaUsada.Rows(0)
        cantidadMaxima = filaUsada("IMPORTE").ToString

        txtImporteActual.Text = cantidadMaxima

        Return cantidadMaxima

    End Function

    ' Realiza el update correspondiente en PendienteDeuda.
    ' Recordatorio = 0 -- > deuda.
    ' Recordatorio = 1 -- > pendiente
    Public Sub realizaUpdateenPendienteDeuda(ByVal importeNuevoLocal As Double)
        Me.importeViejo = dameCantidadMaxima()
        Me.importeNuevo = importeNuevoLocal
        Dim operacionValida As Boolean = True

        If importeNuevo > importeViejo Then
            operacionValida = False
            MsgBox("El importe propuesto es superior al del montante, luego no puede añadirse")
        End If

        If operacionValida Then


            ' Haz operación en entradas/salidas.
            realizaOperacionEntradaSalida(importeNuevo)
            ' conexion.setData("UPDATE CAJA_COBRODEUDAS SET IMPORTE= '" & importeViejo - importeNuevo & "' WHERE ID = " & idPendienteDeuda)
        End If

    End Sub

    ' Actualiza una deuda o un pendiente de cobro una vez se ha realizado la entrada o salida del mismo.
    Public Sub realizaActualizacion()
        conexion.setData("UPDATE CAJA_COBRODEUDAS SET IMPORTE= '" & importeViejo - importeNuevo & "' WHERE ID = " & idPendienteDeuda)
        ' Si es del mismo valor se borra la deuda o el pendiente.
        If (importeViejo = importeNuevo) Then
            conexion.setData("UPDATE CAJA_COBRODEUDAS SET ELIMINADO= 1 WHERE ID = " & idPendienteDeuda)
        End If
    End Sub

    ' Si se realizó la operación de update en CAJA_COBRODEUDAS, se realiza la operación correspondiente de entrada/salida
    ' Recordatorio = 0 -- > deuda.
    ' Recordatorio = 1 -- > pendiente
    Private Sub realizaOperacionEntradaSalida(ByVal montante As Double)
        Dim texto1 As String = "E"
        Dim texto2 As String = "Nueva entrada"
        Dim texto3 As String = "un pendiente de cobro"
        Dim texto4 As String = "una entrada"
        Dim textoProblema As String = "Sustituya pendiente de cobro por entrada"
        If tipoOperacionRealizar = 0 Then
            texto1 = "S"
            texto2 = "Nueva salida"
            texto3 = "una deuda"
            texto4 = "una salida"
            textoProblema = "Sustituya deuda por salida"
        End If

        Dim cadena As String = Convert.ToString(montante)
        Dim cadenaAuxiliar As String = ""
        For i = 0 To cadena.Length - 1
            'If cadena(i) = "," Then
            'cadenaAuxiliar += "."
            'Else
            cadenaAuxiliar += cadena(i)
            'End If
        Next

        frmNuevoCaja.lblTipoProblema.Text = textoProblema
        frmNuevoCaja.tipo = texto1
        frmNuevoCaja.Text = texto2
        frmNuevoCaja.txtImporte.Enabled = False
        frmNuevoCaja.txtImporte.Text = cadenaAuxiliar
        frmNuevoCaja.lblMensajeTipoAccion.Text = "Conversión de " & texto3 & " en una " & texto4
        frmNuevoCaja.Show()
        frmNuevoCaja.ppModificoPendienteDeuda = True
        frmNuevoCaja.TopMost = True
        Me.Hide()


    End Sub

    ' Comprueba si los datos introducidos en el importe son válidos.
    Private Function compruebaImporte() As Boolean
        lblAvisos.Text = "Los campos son correctos"
        Dim esValido As Boolean = True

        Dim importe As String = txtImporte.Text
        Dim importeMaximo As String = txtImporteActual.Text

        ' Se comprueba si es un número flotante.
        If (Not esUnFloat(importe)) Then
            ' El importe ha de ser un double.
            esValido = False
            lblAvisos.Text = "Formato incorrecto en el número introducido"
        End If

        ' Se comprueba si la cantidad es mayor de cero y no superior a lo que se adeuda o está pendiente de cobro.
        If esValido Then
            If Convert.ToDouble(importe) <= 0 Or Convert.ToDouble(importe) > Convert.ToDouble(importeMaximo) Then
                esValido = False
                lblAvisos.Text = "El valor ha de ser positivo"
                If Convert.ToDouble(importe) > Convert.ToDouble(importeMaximo) Then
                    lblAvisos.Text = "El valor no puede superar al importe máximo"
                End If
            End If
        End If


        If esValido Then
            btnRealizarCambio.Enabled = True
            gestionarErroresEtiquetas(True, Me.pboxImporteFallo, Me.pboxImporteAcierto)
        Else
            btnRealizarCambio.Enabled = False
            gestionarErroresEtiquetas(False, Me.pboxImporteFallo, Me.pboxImporteAcierto)
        End If


        Return esValido
    End Function

    Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        compruebaImporte()
    End Sub

    Private Sub btnRealizarCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarCambio.Click
        Me.Enabled = False
        realizaUpdateenPendienteDeuda(Convert.ToDouble(txtImporte.Text))
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    
End Class