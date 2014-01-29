Module deudas_pendientes_comunes

    ' Corrige un apunte en PENDIENTE o DEUDA.
    ' Lo actualiza a importe 0 y lo pone como eliminado.
    ' Crea entrada/salida positiva y negativa de ese valor para anularlo.
    ' tipo = 0 -- > deuda.
    ' tipo = 1 -- > pendiente
    Public Sub creaDeudaPendienteOpuesta(ByVal id As Integer, ByVal tipoProblema As Integer)

        ' Lo primero que se hace es leer el importe de esa deuda / pendiente.
        Dim dataSetUsado As DataSet = conexion.getData("select importe from caja_cobrodeudas where id= " & id, "tabla")
        Dim tablaUsada As DataTable = dataSetUsado.Tables("tabla")
        Dim filaUsada As DataRow = tablaUsada.Rows(0)

        ' Lo segundo que se hace es actualizar esa deuda o pendiente a importe cero y eliminarla.
        conexion.setData("UPDATE CAJA_COBRODEUDAS SET IMPORTE= '0' WHERE ID = " & id)
        conexion.setData("UPDATE CAJA_COBRODEUDAS SET ELIMINADO= 1 WHERE ID = " & id)

        ' Lo tercer es hacer la operación de insercción correspondiente en CAJA_APUNTES.
        Dim tipoapunte As String = "E"
        Dim procedencia As Integer = 4
        Dim textoCorreccion As String = "Corrección de un pendiente de cobro"
        If tipoProblema = 0 Then
            tipoapunte = "S"
            procedencia = 9
            textoCorreccion = "Corrección de una deuda"
        End If

        Dim consultasql As String

        Dim fecha_insert As Integer = Fecha2number(DateTime.Now())
        Dim hora_insert As Integer = hora2number(DateTime.Now())

        ' Se define la primera insercción.
        consultasql = "insert into caja_apuntes (tipoapunte, proced_destino, tipo_pago, concepto, importe, fecha, hora, usuario) " & _
            "values ('" & tipoapunte & "','" & procedencia & "', " &
                     "" & 1 & ",'" & textoCorreccion & "','" & filaUsada("importe").ToString & "'," &
                     "" & fecha_insert & "," & hora_insert & ", " & idUsuario & ")"
        conexion.setData(consultasql)

        ' Se define la insercción opuesta.
        consultasql = "insert into caja_apuntes (tipoapunte, proced_destino, tipo_pago, concepto, importe, fecha, hora, usuario) " & _
            "values ('" & tipoapunte & "','" & procedencia & "', " &
                     "" & 1 & ",'" & textoCorreccion & "','" & (-1) * Convert.ToDouble(filaUsada("importe").ToString) & "'," &
                     "" & fecha_insert & "," & hora_insert & ", " & idUsuario & ")"

        conexion.setData(consultasql)

        frmCaja.actualizarDGV()

        MsgBox("Apunte corregido con éxito")


    End Sub

    ' Determina si los campos están rellenos de forma adecuada como para hacer
    ' una sentencia de inserción en CAJA_COBRODEUDAS
    Public Function compruebaValores(ByVal tipo As Integer) As Boolean
        Dim esValido As Boolean = True

        Dim concepto As String = frmNuevoCaja.txtConcepto.Text.Trim()
        Dim importe As String = frmNuevoCaja.txtImporte.Text.Trim()
        Dim procedencia As Integer = 1 ' Se dejará a uno por defecto en el caso de DEUDAS (no saldrá en la tabla).
        If (Not frmNuevoCaja.cboProDes.SelectedValue Is Nothing) Then
            Try
                procedencia = frmNuevoCaja.cboProDes.SelectedValue
            Catch ex As Exception
                ' En este punto no está construido aún el combo con el formato que queremos.
            End Try

        End If

        Dim fecha As Integer = Fecha2number(frmNuevoCaja.dtpInicio.Value)

        ' Se comprueba concepto.
        If (Not concepto.Length > 0 Or concepto.Length > 100) Then
            ' Ha de haber algo escrito en concepto y su longitud no puede ser mayor de 100.
            gestionarErroresEtiquetas(False, frmNuevoCaja.pboxConceptoFallo, frmNuevoCaja.pboxConceptoAcierto)
            esValido = False
        Else
            gestionarErroresEtiquetas(True, frmNuevoCaja.pboxConceptoFallo, frmNuevoCaja.pboxConceptoAcierto)
        End If

        ' Se comprueba importe.
        If (Not esUnFloat(importe)) Then
            ' El importe ha de ser un double.
            esValido = False
            gestionarErroresEtiquetas(False, frmNuevoCaja.pboxImporteFallo, frmNuevoCaja.pboxImporteAcierto)
        Else
            gestionarErroresEtiquetas(True, frmNuevoCaja.pboxImporteFallo, frmNuevoCaja.pboxImporteAcierto)
        End If

        ' Se comprueba la fecha.
        If (Not Fecha2number(DateTime.Now) >= fecha) Then
            ' La fecha no puede ser mayor que la actual del sistema.
            esValido = False
            gestionarErroresEtiquetas(False, frmNuevoCaja.pboxFechaFallo, frmNuevoCaja.pboxFechaAcierto)
        Else
            gestionarErroresEtiquetas(True, frmNuevoCaja.pboxFechaFallo, frmNuevoCaja.pboxFechaAcierto)
        End If

        ' Se comprueba la procedencia (solo se comprueba en pendientes).
        If (tipo = 1) Then
            If (Not procedencia > 0) Then
                ' El id de procedencia ha de ser mayor que cero.
                esValido = False
                gestionarErroresEtiquetas(False, frmNuevoCaja.pboxProcedenciaFallo, frmNuevoCaja.pboxProcedenciaAcierto)
            Else
                gestionarErroresEtiquetas(True, frmNuevoCaja.pboxProcedenciaFallo, frmNuevoCaja.pboxProcedenciaAcierto)
            End If
        End If

        ' Aquí se determina si el botón está o no habilitado
        If (Not esValido) Then
            frmNuevoCaja.btnGuardar.Enabled = False
        Else
            frmNuevoCaja.btnGuardar.Enabled = True
        End If

        Return esValido
    End Function

    ' Realiza una inserción en la tabla CAJA_COBRODEUDAS
    ' tipo = 0 -- > deuda.
    ' tipo = 1 -- > pendiente
    Public Sub insertaDeudaPendiente(ByVal tipo As Integer)
        ' Se ajustan las variables en función de los campos seleccionados en frmNuevoCaja.
        Dim concepto As String = frmNuevoCaja.txtConcepto.Text.Trim().ToUpper
        Dim importe As String = frmNuevoCaja.txtImporte.Text.Trim()
        Dim fecha As Integer = Fecha2number(frmNuevoCaja.dtpInicio.Value)
        Dim hora As Integer = hora2number(frmNuevoCaja.dtpInicio.Value)
        Dim usuario As Integer = Comun.idUsuario
        Dim procedencia As Integer = 1
        If (tipo = 1) Then
            procedencia = frmNuevoCaja.cboProDes.SelectedValue

        End If


        ' No sería necesario pero de cara a futuros cambios se vuelve a realizar la comprobación antes de entrar.
        If compruebaValores(tipo) Then
            ' A continuación se crea la sentencia de inserción.
            Dim sentenciaInsercion As String = "INSERT INTO CAJA_COBRODEUDAS (PROCEDENCIA, CONCEPTO, IMPORTE, FECHA, HORA, TIPO, USUARIO, ELIMINADO) VALUES ('" & _
            procedencia & "', '" & _
            concepto & "', '" & _
            importe & "', '" & _
            fecha & "', '" & _
            hora & "', '" & _
            tipo & "', '" & _
            usuario & "', '" & _
            "0" & "')"

            ' Se añade la sentencia de inserción
            conexion.setData(sentenciaInsercion)

            ' Se da mensaje de confirmación.
            Dim tipoAccion As String = "PENDIENTE DE COBRO"
            If (tipo = 0) Then
                tipoAccion = "DEUDA"
            End If
            MsgBox(tipoAccion & " realizado con éxito")

            ' Se anota el cambio en el log.
            Dim dataSetUsado As DataSet = conexion.getData("SELECT MAX(ID) AS MAXIMO_ID FROM CAJA_COBRODEUDAS", "tabla")
            Dim tablaUsada As DataTable = dataSetUsado.Tables("tabla")
            Dim filaUsada As DataRow = tablaUsada.Rows(0)
            Dim idLeido As String = filaUsada("MAXIMO_ID").ToString
            insertarCambio("creación de " & tipoAccion.ToLower & " " & idLeido, 0)

        Else
            ' Se da mensaje de error.
            MsgBox("Hay campos incorrectos, luego no puede realizar la operación solicitada")
        End If

    End Sub

    ' Da formato al DGV para que se adapte al común estilodgvArt.
    ' Además hace varias cosas:
    ' A mano no se pueden añadir filas.
    ' Las columnas se adaptan al margen dejado.
    ' Los campos no son editables
    Public Sub darFormatoADGV(ByRef datagridView As DataGridView)
        ' Se llama al método común.
        estilodgvArt(datagridView)

        ' para que no se muestre una fila de más (la editable por defecto para el usuario).
        datagridView.AllowUserToAddRows = False

        ' Para que el tamaño de la columnas se adapte al texto.
        datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Sin columnas editables.
        datagridView.ReadOnly = True
    End Sub

    ' Carga el DGV de DEUDAS / PENDIENTES en función de los filtros.
    ' tipo = 0 -- > deuda.
    ' tipo = 1 -- > pendiente
    Public Sub cargarDGVDeudas_Pendientes(ByVal tipo As Integer)

        ' Doy el formato que requiere el DGV.
        darFormatoADGV(frmCaja.dgvCaja)

        Dim filtroProcedencia As String = "PROCEDENCIA LIKE '%'"
        Dim filtroFechaMinima As String = "FECHA LIKE '%'"
        Dim filtroFechaMaxima As String = "FECHA LIKE '%'"
        Dim filtroConcepto As String = "CONCEPTO LIKE '%'"
        Dim filtroImporte As String = "IMPORTE LIKE '%'"

        If (tipo = 1 And frmCaja.cboProDes.SelectedValue > 0) Then
            filtroProcedencia = "PROCEDENCIA = " & frmCaja.cboProDes.SelectedValue
        End If

        If (frmCaja.cbFecha.Checked) Then
            filtroFechaMinima = "FECHA >= " & Fecha2number(frmCaja.dtpInicio.Value)
        End If

        If (frmCaja.cbIntervalo.Checked) Then
            filtroFechaMaxima = "FECHA <= " & Fecha2number(frmCaja.dtpFin.Value)
        End If

        If (frmCaja.txtConcepto.Text.Trim.Length > 0) Then
            filtroConcepto = "CONCEPTO LIKE '%" & frmCaja.txtConcepto.Text.Trim.ToUpper & "%'"
        End If

        If (esUnFloat(frmCaja.txtImporte.Text.Trim)) Then
            filtroImporte = "IMPORTE " & frmCaja.cboImporte.SelectedItem & " " & frmCaja.txtImporte.Text.Trim
        End If

        Dim inicioConsulta As String = "SELECT ID, CONCEPTO, IMPORTE, FECHA, HORA, USUARIOS.NOMBRE FROM CAJA_COBRODEUDAS, USUARIOS WHERE ( USUARIOS.IDUSUARIO = CAJA_COBRODEUDAS.USUARIO "
        If (tipo = 1) Then
            ' Si es Pendiente.
            inicioConsulta = "SELECT CAJA_COBRODEUDAS.ID, CAJA_PROCEDENCIADESTINO.DESCRIPCION, CONCEPTO, IMPORTE, FECHA, HORA, USUARIOS.NOMBRE FROM CAJA_COBRODEUDAS, USUARIOS, CAJA_PROCEDENCIADESTINO where ( USUARIOS.IDUSUARIO = CAJA_COBRODEUDAS.USUARIO AND CAJA_PROCEDENCIADESTINO.ID = CAJA_COBRODEUDAS.PROCEDENCIA "
        End If

        Dim consulta As String = inicioConsulta & " AND CAJA_COBRODEUDAS.TIPO = " & tipo & " AND " & _
            filtroProcedencia & " AND " & _
            filtroFechaMinima & " AND " & _
            filtroFechaMaxima & " AND " & _
            filtroConcepto & " AND " & _
            filtroImporte & " AND " & _
            " CAJA_COBRODEUDAS.ELIMINADO = 0 ) " & _
            "order by fecha desc, hora desc"

        ' Se hace la select de DEUDAS.
        Dim dataSetUsado As DataSet = conexion.getData(consulta, "tabla")
        Dim tablaUsada As DataTable = dataSetUsado.Tables("tabla")
        'frmCaja.dgvCaja.DataSource = tablaUsada

        frmCaja.dgvCaja.Columns.Clear()
        frmCaja.dgvCaja.Rows.Clear()

        frmCaja.dgvCaja.Columns.Add("id", "ID")
        frmCaja.dgvCaja.Columns.Add("Concepto", "Concepto")
        frmCaja.dgvCaja.Columns.Add("Importe", "Importe")
        frmCaja.dgvCaja.Columns.Add("Fecha", "Fecha")
        frmCaja.dgvCaja.Columns.Add("Hora", "Hora")
        frmCaja.dgvCaja.Columns.Add("Nombre", "Nombre")

        Dim fecha As Date

        For Each row As DataRow In tablaUsada.Rows

            fecha = number2Date(row("FECHA"), row("HORA"))
            frmCaja.dgvCaja.Rows.Add(row("ID"), row("CONCEPTO"), row("IMPORTE"), FormatDateTime(fecha, DateFormat.ShortDate), fecha.TimeOfDay, row("NOMBRE"))

        Next

        ' Se ocultan las columnas pertinentes.
        frmCaja.dgvCaja.Columns("ID").Visible = False

    End Sub




End Module
