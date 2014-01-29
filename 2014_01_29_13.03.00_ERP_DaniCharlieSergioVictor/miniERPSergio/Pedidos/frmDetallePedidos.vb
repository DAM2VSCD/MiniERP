Public Class frmDetallePedidos

    ' Id del pedido que se está manejando
    Shared idPedido As Integer

    ' Id del detallepedido que se está manejando
    Shared idDetallePedido As Integer

    ' Índice de fila seleccionada del dgDetallePedido.
    Private filaDetallePedido As Integer

    ' Elemento para controlar los keyPress y keyDown de la cantidad de elementos pedidos.
    Private WithEvents txtNumeric As New DataGridViewTextBoxEditingControl

    ' Flag para controlar que realmente no se haya introducido un número en la cantidad del producto.
    Private noSeIntrodujoNumero As Boolean = False

    Private tip4 As ToolTip = Nothing

    'rellena el dgv con los clientes que hay en ese momenot
    Sub iniciardgv()

        idPedido = frmPedidosBuscar.ppIdPedido

        editarFormatoDGV()

        rellenarDGV()

    End Sub

    Private Sub operacionesIniciales()
        tip4 = New ToolTip
    End Sub

    Private Sub frmDetallePedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        operacionesIniciales()
        iniciardgv()
        Me.TopMost = True
    End Sub

    ' Rellena el DGV.
    Private Sub rellenarDGV()

        Dim datosDetallePedido As DataSet = conexion.getData("SELECT IDPEDIDOSARTICULOS, REFARTICULO, PRECIOVENTA, CANTIDAD_ESPERADA FROM PEDIDOSARTICULOS WHERE REFPEDIDO=" & idPedido, "tablas")
        Dim tablas As DataTable = datosDetallePedido.Tables("tablas")
        Dim filaUsada As DataRow = Nothing
        Dim nombreArticulo, stockArticulo, precioArticulo As String

        Dim contador As Integer = 0

        For i = 0 To tablas.Rows.Count() - 1
            filaUsada = tablas.Rows(i)

            Dim datosIdPedido As DataSet = Nothing
            datosIdPedido = conexion.getData("SELECT NOMBRE, STOCK, PRECIO FROM ARTICULOS WHERE IDARTICULO =" & filaUsada("REFARTICULO").ToString, "tablas2")
            Dim tablas2 As DataTable = datosIdPedido.Tables("tablas2")
            Dim filaUsada2 As DataRow = tablas2.Rows(0)

            nombreArticulo = filaUsada2("NOMBRE").ToString
            stockArticulo = filaUsada2("STOCK").ToString
            precioArticulo = filaUsada2("PRECIO").ToString

            Dim cantidad As String = filaUsada("CANTIDAD").ToString

            dgvDetallePedido.Rows.Add()
            dgvDetallePedido.Item(0, contador).Value = filaUsada("REFARTICULO").ToString
            dgvDetallePedido.Item(1, contador).Value = nombreArticulo
            dgvDetallePedido.Item(3, contador).Value = precioArticulo
            dgvDetallePedido.Item(2, contador).Value = cantidad
            dgvDetallePedido.Item(4, contador).Value = stockArticulo
            dgvDetallePedido.Item(5, contador).Value = (Convert.ToDouble(dgvDetallePedido.Item(2, contador).Value) * Convert.ToDouble(dgvDetallePedido.Item(3, contador).Value)).ToString
            dgvDetallePedido.Item(6, contador).Value = filaUsada("IDPEDIDOSARTICULOS").ToString
            contador += 1

        Next
        If dgvDetallePedido.Rows.Count > 0 Then
            dgvDetallePedido.Rows(0).Selected = True
            idDetallePedido = dgvDetallePedido.Item(6, 0).Value
        End If

    End Sub

    ' Configura el formato inicial del dataGridView
    Private Sub editarFormatoDGV()

        ' Se llama al método común.
        estilodgvArt(dgvDetallePedido)

        ' para que no se muestre una fila de más (la editable por defecto para el usuario).
        dgvDetallePedido.AllowUserToAddRows = False

        ' Para que el tamaño de la columnas se adapte al texto.
        dgvDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    ' Se sobreescribe el método dispose de este frame.
    Private Sub frmDetallePedidosDisposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmPedidosBuscar.Enabled = True
        frmPedidosBuscar.actualizaLista()
    End Sub

    ' Gestiona el consumo de eventos de KeyDown en los que solo se permitan cifras. 
    Private Sub txtNumeric_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeric.KeyDown
        seMarcoNoCifra(e)
    End Sub

    ' Gestiona el consumo de eventos de KeyPress en los que solo se permitan cifras.
    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeric.KeyPress
        If noSeIntrodujoNumero = True Then
            e.Handled = True
        End If
    End Sub

    ' Se controlan cambios en el dgvPedidos en la única casilla editable
    Private Sub dgvDetallePedido_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetallePedido.EditingControlShowing
        txtNumeric = TryCast(e.Control, DataGridViewTextBoxEditingControl)
    End Sub

    ' Cuando cambia el valor de una celda del datagrid view.
    Private Sub DataGridCellValueChanged(ByVal sender As DataGridView, ByVal e As DataGridViewCellEventArgs) Handles dgvDetallePedido.CellValueChanged
        If Not dgvDetallePedido.CurrentCell Is Nothing Then
            Dim filaSeleccionadaDGV = dgvDetallePedido.CurrentCell.RowIndex
            If (Not dgvDetallePedido.Item(2, filaSeleccionadaDGV).Value Is Nothing And Not dgvDetallePedido.Item(3, filaSeleccionadaDGV).Value Is Nothing) Then
                If esUnDoubleMayorQueCero(dgvDetallePedido.Item(2, filaSeleccionadaDGV).Value, Nothing) Then
                    calculaPrecioFila(filaSeleccionadaDGV, Convert.ToDouble(dgvDetallePedido.Item(2, filaSeleccionadaDGV).Value.ToString), Convert.ToDouble(dgvDetallePedido.Item(3, filaSeleccionadaDGV).Value.ToString))
                    tip4.Hide(txtOculto2)
                Else
                    dgvDetallePedido.Item(2, dgvDetallePedido.CurrentRow.Index).Value = Nothing
                    tip4.Show("La cantidad PEDIDA de un artículo no pueden ser nula o menor que cero", txtOculto2)
                    gestionarErroresArticulo(False)
                End If
            Else
                dgvDetallePedido.Item(2, dgvDetallePedido.CurrentRow.Index).Value = Nothing
                tip4.Show("La cantidad PEDIDA de un artículo no pueden ser nula o menor que cero", txtOculto2)
                gestionarErroresArticulo(False)
            End If
        End If
        If Not dgvDetallePedido.CurrentCell Is Nothing Then
            Dim esValido As Boolean = True
            Dim contador As Integer = 0
            Do
                If dgvDetallePedido.Item(5, contador).Value Is Nothing Then
                    esValido = False
                    tip4.Show("Uno o varios artículos no cumplen los criterios marcados", txtOculto2)
                    gestionarErroresArticulo(False)
                    btnConfirmarModificaciones.Enabled = False
                End If
                contador += 1
            Loop While (contador < dgvDetallePedido.Rows.Count And esValido)
            If esValido Then
                tip4.Hide(txtOculto2)
                gestionarErroresArticulo(True)
                btnConfirmarModificaciones.Enabled = True
                comprobarSiSePuedeInsertarPedido()
            Else
                comprobarSiSePuedeInsertarPedido()
            End If
        End If
        
    End Sub

    ' Se comprueba si se puede o no confirmar los cambios.
    ' El botón de confirmar cambios habilitará o deshabilitará en función de si se puede o no efectuar el cambio.
    Private Sub comprobarSiSePuedeInsertarPedido()
        Dim sePuedeConfirmarCambio As Boolean = True

        'cantidadAcumulada = 0
        Dim numeroColumnas As Integer = dgvDetallePedido.Columns.Count
        Dim numeroFilas As Integer = dgvDetallePedido.Rows.Count

        If numeroFilas > 0 Then

            Dim i As Integer = 0

            ' De cada artículo ha de haberse introducido una cantidad correcta mayor que CERO.
            While (i < numeroFilas And sePuedeConfirmarCambio)
                If (dgvDetallePedido.Item(2, i).Value Is Nothing) Then
                    sePuedeConfirmarCambio = False
                Else
                    If (Not dgvDetallePedido.Item(2, i).Value Is Nothing) Then
                        If (dgvDetallePedido.Item(2, i).Value.ToString.Length <= 0) Then
                            sePuedeConfirmarCambio = False
                        Else
                        End If
                    Else
                        sePuedeConfirmarCambio = False
                    End If
                End If
                i += 1
            End While

        End If

        If sePuedeConfirmarCambio Then
            tip4.Hide(txtOculto2)
            gestionarErroresArticulo(True)
            btnConfirmarModificaciones.Enabled = True
        Else
            btnConfirmarModificaciones.Enabled = False
        End If
    End Sub

    ' Comprueba que los posibles errores que haya en las cantidades que se van añadiendo.
    Public Sub gestionarErroresArticulo(ByVal valido As Boolean)
        If valido Then
            gestionarErroresEtiquetas(True, pboxUnidadesFallo, pboxUnidadesAcierto)
        Else
            gestionarErroresEtiquetas(False, pboxUnidadesFallo, pboxUnidadesAcierto)
        End If
    End Sub

    ' Rellena el precio del datagridView.
    Private Sub calculaPrecioFila(ByVal fila As Integer, ByVal precioUnitario As Double, ByVal cantidadItems As Double)
        Dim filaSeleccionadaDGV = dgvDetallePedido.CurrentCell.RowIndex
        dgvDetallePedido.Item(5, fila).Value = (precioUnitario * cantidadItems).ToString
    End Sub

    'Evento que ocurre al pulsar en el datagridview
    Private Sub dgvDetallePedido_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDetallePedido.CellMouseClick
        If e.RowIndex > -1 Then
            idDetallePedido = dgvDetallePedido.Rows(e.RowIndex).Cells(0).Value
            filaDetallePedido = dgvDetallePedido.CurrentCell.RowIndex
        End If
    End Sub

    ' Cuando se pulsa el botón confirmar modificaciones.
    Private Sub btnConfirmarModificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarModificaciones.Click

        Dim valido As Boolean = True

        If Not dgvDetallePedido.Rows.Count > 0 Then
            valido = False
        Else
            For i = 0 To dgvDetallePedido.Rows.Count - 1
                If Not esUnEnteroMayorDeCero(dgvDetallePedido.Item(2, i).Value, Nothing) Then
                    valido = False
                End If
            Next
        End If

        ' Solo tiene sentido hacer las pruebas si hay por lo menos un campo y si los valores de cantidad son correctos
        If valido Then

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Desea introducir los cambios?", MsgBoxStyle.YesNo, "Confirmacion")
            If (respuesta = MsgBoxResult.Yes) Then

                Dim sentenciaBorrarDetalles As String = "DELETE FROM PEDIDOS_CLIENTES_ARTICULOS WHERE REFPEDIDO= '" & idPedido & "'"
                conexion.setData(sentenciaBorrarDetalles)

                ' Se borran todos los detalles.
                ' PENDIENTE.
                Dim sentencia As String = ""

                ' Se añaden los nuevos detalles.

                Dim datasethere As DataSet = Nothing
                Dim tablashere As DataTable = Nothing
                Dim filaUsadahere As DataRow = Nothing
                Dim IDPEDIDOARTIC As String = ""

                Dim REFPEDIDO, REFARTICULO, CANTIDAD, PRECIOVENTA As String

                Dim nuevoPrecioTotal As Double = 0
                REFPEDIDO = idPedido
                Dim idLibre As Integer = 1

                For i = 0 To dgvDetallePedido.Rows.Count - 1
                    Dim libreEncontrado As Boolean = False
                    Do
                        sentencia = "SELECT IDPEDIDOSARTICULOS AS IDP FROM PEDIDOS_CLIENTES_ARTICULOS WHERE IDPEDIDOSARTICULOS =" & idLibre
                        datasethere = conexion.getData(sentencia, "tablas")
                        tablashere = datasethere.Tables("tablas")
                        If tablashere.Rows.Count = 0 Then
                            libreEncontrado = True
                        Else
                            idLibre += 1
                        End If

                    Loop While (Not libreEncontrado)


                    REFARTICULO = dgvDetallePedido.Item(0, i).Value
                    CANTIDAD = dgvDetallePedido.Item(2, i).Value
                    PRECIOVENTA = dgvDetallePedido.Item(3, i).Value
                    nuevoPrecioTotal += dgvDetallePedido.Item(5, i).Value
                    IDPEDIDOARTIC = idLibre
                    Dim sentencia2 As String = "INSERT INTO PEDIDOS_CLIENTES_ARTICULOS (IDPEDIDOSARTICULOS, REFPEDIDO, REFARTICULO, CANTIDAD_ESPERADA, PRECIOVENTA) VALUES (" & _
                            IDPEDIDOARTIC & "," & _
                            REFPEDIDO & "," & _
                            REFARTICULO & "," & _
                            CANTIDAD & ",'" & _
                            PRECIOVENTA & "')"
                    conexion.setData(sentencia2)
                Next

                sentencia = "UPDATE PEDIDOS " & _
                            "SET TOTAL= '" & nuevoPrecioTotal & _
                            "' WHERE IDPEDIDO =" & REFPEDIDO
                conexion.setData(sentencia)

                insertarCambio("Detalles Pedido " & idPedido & " actualizado", 0)

                Me.Dispose()
            End If
        Else
            MsgBox("CUIDADO: algun campo no tiene el formato correcto")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambios.Click
        frmCambios.Show()
    End Sub

    ' Evento de pulsar el botón eliminar.
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvDetallePedido.Rows.Count > 1 Then

            dgvDetallePedido.Rows.RemoveAt(filaDetallePedido)
            If dgvDetallePedido.Rows.Count > 1 Then
                filaDetallePedido = 0
            Else
                filaDetallePedido = -1
            End If
        Else
            MsgBox("Si desea eliminar todos los detalles elimine directamente el pedido en la ventana correspondiente")
        End If

    End Sub
End Class