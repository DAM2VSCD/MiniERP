Imports System.Text.RegularExpressions

Module Entrada_Salida_Comunes

    Public Sub creaEntradaSalidaOpuesta(ByVal id As String)

        Dim dataSetUsado As DataSet = conexion.getData("select tipoapunte, proced_destino, tipo_pago, concepto, importe from caja_apuntes where id= " & id, "tabla")
        Dim tablaUsada As DataTable = dataSetUsado.Tables("tabla")
        Dim filaUsada As DataRow = tablaUsada.Rows(0)

        ' A continuación se crea la sentencia de inserción.
        Dim sentenciaInsercion As String = "INSERT INTO caja_apuntes (tipoapunte, proced_destino, tipo_pago, concepto, importe, fecha, hora, usuario) " & _
            " VALUES ( '" & filaUsada("tipoapunte").ToString & _
            "', '" & filaUsada("proced_destino").ToString & _
            "', '" & filaUsada("tipo_pago").ToString & _
            "', '" & filaUsada("concepto").ToString & _
            "', '" & (-1) * Convert.ToDouble(filaUsada("importe").ToString) & _
            "', '" & Fecha2number(DateTime.Now()) & _
            "', '" & hora2number(DateTime.Now()) & _
            "', '" & idUsuario & _
            "')"

        ' Se añade la sentencia de inserción
        conexion.setData(sentenciaInsercion)

        frmCaja.actualizarDGV()

        MsgBox("Apunte corregido con éxito")


    End Sub


    Public Sub filtroES(tipoNota As String)

        'Dim fila As Integer
        'If Not IsDataGridViewEmpty(frmCaja.dgvCaja) Then
        '    If frmCaja.dgvCaja.Rows.Count > 0 Then
        '        fila = frmCaja.dgvCaja.CurrentCell.RowIndex
        '    End If
        'Else
        '    fila = -1
        'End If




        darFormatoADGV(frmCaja.dgvCaja)

        'Filtro importe
        Dim filtroimporte As String

        If frmCaja.txtImporte.Text.Equals("") Then
            filtroimporte = ""
        Else
            filtroimporte = " and importe " & frmCaja.cboImporte.SelectedItem.ToString & " " & frmCaja.txtImporte.Text
        End If

        'Filtro concepto
        Dim filtroConcepto As String

        If frmCaja.txtConcepto.Text.Equals("") Then
            filtroConcepto = ""
        Else
            filtroConcepto = " and upper(concepto) like '%" & frmCaja.txtConcepto.Text.ToUpper & "%'"
        End If

        'Filtro tipo
        Dim filtrotipo As String

        If frmCaja.cboTipo.SelectedIndex >= 0 Then
            If frmCaja.cboTipo.SelectedIndex = 0 Then
                filtrotipo = ""
            Else
                filtrotipo = " and tipo_pago = '" & frmCaja.cboTipo.SelectedValue.ToString & "'"
            End If
        Else
            filtrotipo = ""
        End If

        'Filtro procedencia
        Dim filtroproced As String

        If frmCaja.cboProDes.SelectedIndex >= 0 Then
            If frmCaja.cboProDes.SelectedIndex = 0 Then
                filtroproced = ""
            Else
                filtroproced = " and proced_destino = '" & frmCaja.cboProDes.SelectedValue.ToString & "'"
            End If
        Else
            filtroproced = ""
        End If

        'Filtro fecha
        Dim filtrofecha As String
        If frmCaja.cbFecha.Checked Then
            If frmCaja.cbIntervalo.Checked Then
                filtrofecha = " and fecha >= " & Fecha2number(frmCaja.dtpInicio.Value) & " and " &
                              " fecha <= " & Fecha2number(frmCaja.dtpFin.Value)
            Else
                filtrofecha = " and fecha = " & Fecha2number(frmCaja.dtpInicio.Value) & ""
            End If
        Else
            filtrofecha = ""
        End If

        Dim request As New DataSet

        Dim consulta As String
        'Mostramos los resultados


        If tipoNota.Equals("E") Then
            consulta = "select ap.id, cprod.descripcion as PROCEDENCIA, cpago.descripcion as TIPO_PAGO, CONCEPTO, IMPORTE, FECHA, HORA, usu.nombre as USUARIO " &
                    "from caja_apuntes ap, usuarios usu, caja_procedenciadestino cprod, caja_tipospago cpago where ap.usuario = usu.idusuario " &
                    "and cprod.id = ap.proced_destino and cpago.id = ap.tipo_pago and tipoapunte = '" & tipoNota & "' and cprod.tipo = 0 " &
                    "" & filtroConcepto & filtroimporte & filtrotipo & filtroproced & filtrofecha
        Else
            consulta = "select ap.id, cprod.descripcion as DESTINO, cpago.descripcion as TIPO_PAGO, CONCEPTO, IMPORTE, FECHA, HORA, usu.nombre as USUARIO " &
                        "from caja_apuntes ap, usuarios usu, caja_procedenciadestino cprod, caja_tipospago cpago where ap.usuario = usu.idusuario " &
                        "and cprod.id = ap.proced_destino and cpago.id = ap.tipo_pago and tipoapunte = '" & tipoNota & "' and cprod.tipo = 1 " &
                        "" & filtroConcepto & filtroimporte & filtrotipo & filtroproced & filtrofecha
        End If


        request = conexion.getData(consulta & "order by fecha desc, hora desc", "entradas")

        Dim t As DataTable = request.Tables("entradas")

        frmCaja.dgvCaja.Columns.Clear()

        Dim proc_des As String

        frmCaja.dgvCaja.Columns.Add("id", "ID")
        If tipoNota.Equals("E") Then
            proc_des = "procedencia"
            frmCaja.dgvCaja.Columns.Add(proc_des, "Procedencia")
        Else
            proc_des = "destino"
            frmCaja.dgvCaja.Columns.Add(proc_des, "Destino")
        End If
        frmCaja.dgvCaja.Columns.Add("tipo_pago", "Pago")
        frmCaja.dgvCaja.Columns.Add("concepto", "Concepto")
        frmCaja.dgvCaja.Columns.Add("Importe", "Importe")
        frmCaja.dgvCaja.Columns.Add("Fecha", "Fecha")
        frmCaja.dgvCaja.Columns.Add("Hora", "Hora")
        frmCaja.dgvCaja.Columns.Add("Usuario", "Usuario")

        Dim fecha As Date



        For Each row As DataRow In t.Rows

            fecha = number2Date(row("FECHA"), row("HORA"))
            frmCaja.dgvCaja.Rows.Add(row("ID"), row(proc_des), row("TIPO_PAGO"), row("CONCEPTO"), row("IMPORTE"), FormatDateTime(fecha, DateFormat.ShortDate), fecha.TimeOfDay, row("USUARIO"))

        Next

        frmCaja.dgvCaja.Columns(0).Visible = False

        'If fila >= 0 Then
        '    frmCaja.dgvCaja.CurrentCell = frmCaja.dgvCaja.Rows(fila).Cells(0)
        'End If
    End Sub

    Public Sub compruebaES()
        'Comprueba los valores introducidos en  frmNuevoCaja

        'Concepto
        If frmNuevoCaja.txtConcepto.Text.Equals("") Then
            frmNuevoCaja.pboxConceptoAcierto.Visible = False
            frmNuevoCaja.pboxConceptoFallo.Visible = True
        Else
            frmNuevoCaja.pboxConceptoAcierto.Visible = True
            frmNuevoCaja.pboxConceptoFallo.Visible = False
        End If

        'Importe
        If Not validarFloat(frmNuevoCaja.txtImporte.Text) Then
            frmNuevoCaja.pboxImporteAcierto.Visible = False
            frmNuevoCaja.pboxImporteFallo.Visible = True
        Else
            frmNuevoCaja.pboxImporteAcierto.Visible = True
            frmNuevoCaja.pboxImporteFallo.Visible = False
        End If

        'Procedencia / Destino
        If frmNuevoCaja.cboProDes.SelectedIndex = 0 Then
            frmNuevoCaja.pboxProcedenciaAcierto.Visible = False
            frmNuevoCaja.pboxProcedenciaFallo.Visible = True
        Else
            frmNuevoCaja.pboxProcedenciaAcierto.Visible = True
            frmNuevoCaja.pboxProcedenciaFallo.Visible = False
        End If

        'Tipo
        If frmNuevoCaja.cboTipo.SelectedIndex = 0 Then
            frmNuevoCaja.pboxTipoAcierto.Visible = False
            frmNuevoCaja.pboxTipoFallo.Visible = True
        Else
            frmNuevoCaja.pboxTipoAcierto.Visible = True
            frmNuevoCaja.pboxTipoFallo.Visible = False
        End If

        'Fecha
        Dim hoy As Date = DateTime.Now()
        'hoy = hoy.AddDays(-1)

        If DateTime.Compare(frmNuevoCaja.dtpInicio.Value(), hoy) > 0 Then
            frmNuevoCaja.pboxFechaAcierto.Visible = False
            frmNuevoCaja.pboxFechaFallo.Visible = True
            MsgBox("No puede elegir fechas posteriores a hoy")
        Else
            frmNuevoCaja.pboxFechaAcierto.Visible = True
            frmNuevoCaja.pboxFechaFallo.Visible = False
        End If

        ' Condición para controlar la situación en que se modifique un pendiente de cobro o una deuda.
        ' No se pueden poner fechas en la entrada/salida correspondiente que sean anteriores a la propia en
        ' se anotó el pendiente de cobro o la deuda.
        If frmNuevoCaja.ppModificoPendienteDeuda Then
            Dim dataSetUsado As DataSet = conexion.getData("SELECT FECHA FROM CAJA_COBRODEUDAS WHERE ID = " & frmModificar_Pendiente_Deuda.ppIdPendienteDeuda, "tabla")
            Dim tablaUsada As DataTable = dataSetUsado.Tables("tabla")
            Dim filaUsada As DataRow = tablaUsada.Rows(0)
            Dim fechaLeida As String = filaUsada("FECHA").ToString

            ' Por si hubiera fallos de formato se usa try/catch
            Try
                If Fecha2number(frmNuevoCaja.dtpInicio.Value()) < Convert.ToInt32(fechaLeida) Then
                    frmNuevoCaja.pboxFechaAcierto.Visible = False
                    frmNuevoCaja.pboxFechaFallo.Visible = True
                    MsgBox("No puede elegir fechas anteriores al original (" & fechaLeida & ")")
                End If
            Catch ex As Exception
                MsgBox("Alerta, error a la hora de convertir un valor de fecha de la BD en número. Consulte con Sergio que fue el innombrable sujeto que programó esto")
            End Try

        End If


        If frmNuevoCaja.pboxConceptoFallo.Visible Or frmNuevoCaja.pboxImporteFallo.Visible Or
            frmNuevoCaja.pboxProcedenciaFallo.Visible Or frmNuevoCaja.pboxTipoFallo.Visible Or
            frmNuevoCaja.pboxFechaFallo.Visible Then

            frmNuevoCaja.btnGuardar.Enabled = False

        Else

            frmNuevoCaja.btnGuardar.Enabled = True

        End If
    End Sub

    Function validarFloat(ByVal numero As String) As Boolean
        Dim valida = "^\d{1,7}(?:,\d{1,2})?$"

        If Regex.IsMatch(numero, valida) Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
