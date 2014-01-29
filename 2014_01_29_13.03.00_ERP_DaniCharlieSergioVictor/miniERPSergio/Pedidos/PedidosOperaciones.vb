Module PedidosOperaciones

    ' Operaciones a realizar cuando se pulsa el botón que elimina un artículo del pedido.
    ' Es decir, se elimina un artículo del dgv del pedido.
    Public Sub eliminarArticuloDelPedido(ByRef dgvPedidos As DataGridView)

        If Not dgvPedidos.SelectedCells Is Nothing Then
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea borrar este Articulo de la lista del pedido?", MsgBoxStyle.YesNo, "Confirmacion")
            If (respuesta = MsgBoxResult.Yes) Then
                dgvPedidos.Rows.RemoveAt(dgvPedidos.CurrentCell.RowIndex)
            End If
        Else
            MsgBox("Seleccione una fila para poder borrarla")
        End If

    End Sub

    ' Calcula el precio total a pagar.
    Public Function calculaPrecioTotalAPagar(ByVal dgvPedidos As DataGridView) As Double
        Dim precioTotalAPagar As Double = 0
        For i = 0 To dgvPedidos.Rows.Count() - 1
            If Not dgvPedidos.Item(6, i).Value Is Nothing Then
                precioTotalAPagar += Convert.ToDouble(dgvPedidos.Item(6, i).Value)
            End If
        Next

        Return precioTotalAPagar
    End Function

    ' Mientras se crear un pedido o al modificarlo, a la par que se añaden o quitan artículos cambia el precio total
    ' del pedido y ese valor se asigna a la celda correspondiente.
    Public Sub asignaNuevoPrecioTotalAPagarASuCasilla(ByVal precioTotalAPagar As Double, ByRef txtDineroPagado As TextBox, ByVal soyModificar As Boolean)
        txtDineroPagado.Text = precioTotalAPagar.ToString
        If Not soyModificar Then
            txtDineroPagado.Text = precioTotalAPagar
        End If

    End Sub
        
    ' Rellena el precio del datagridView.
    Public Sub calculaColumnaPrecioTotal(ByRef dgvPedidos As DataGridView, ByVal columnaConPrecioTotal As Integer, ByVal fila As Integer, ByVal precioUnitario As Double, ByVal cantidadItems As Double)
        Dim filaSeleccionadaDGV = dgvPedidos.CurrentCell.RowIndex
        dgvPedidos.Item(columnaConPrecioTotal, fila).Value = (precioUnitario * cantidadItems).ToString
    End Sub




End Module
