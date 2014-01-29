Imports System.Text.RegularExpressions

Module Pedidos_Comprobaciones

    ' Gestiona el mostrado de etiqueta de error-acierto en el caso de que haya o no un cliente-proveedor elegido.
    Public Sub gestionarErroresCliente_Proveedor(ByVal idClienteProveedor As Integer, ByRef pboxAcierto As PictureBox, ByRef pboxFallo As PictureBox)
        If idClienteProveedor = -1 Then
            gestionarErroresEtiquetas(False, pboxFallo, pboxAcierto)
        Else
            gestionarErroresEtiquetas(True, pboxFallo, pboxAcierto)
        End If
    End Sub

    'gestionarErroresCliente_Proveedor(idCliente, pboxClienteAcierto, pboxClienteError)

    ' Determina si la cantidad total a pagar introducida por el usuario es válida o no.
    Function validarDineroPagado(ByVal numero As String, ByVal precioTotal1 As Double) As Boolean
        Dim esValido As Boolean = esUnFloat(numero)

        If esValido Then
            Dim numeroFloat As Double = Convert.ToDouble(numero)
            If numeroFloat < 0 Or numeroFloat > precioTotal1 Then
                esValido = False
            End If
        End If

        Return esValido
    End Function

    ' Cuando se cambie la cantidad pagada en el pedido, se comprueba si el nuevo número introducido es válido o no.
    Public Function procesoCambioCantidadPagar(ByVal dineroPagado As Double, ByVal precioTotal As Double, ByRef lblErrorCantidadAPagar As Label) As Boolean
        Dim cantidadAPagarValida As Boolean = validarDineroPagado(dineroPagado, precioTotal)
        If Not cantidadAPagarValida Then
            lblErrorCantidadAPagar.Visible = True
        Else
            lblErrorCantidadAPagar.Visible = False
        End If


        Return cantidadAPagarValida
    End Function

    ' De cada artículo ha de haberse introducido una cantidad correcta mayor que CERO.
    ' Se comprueba este hecho.
    Public Function comprobarTodasCantidadesDGVMayorQueCero(ByRef dgvPedidos As DataGridView, ByVal columnaDelDGVConCampoCantidad As Integer) As Boolean
        Dim numeroColumnas As Integer = dgvPedidos.Columns.Count
        Dim numeroFilas As Integer = dgvPedidos.Rows.Count

        Dim i As Integer = 0
        Dim esValidoElDGV As Boolean = True
        While (i < numeroFilas)
            If (dgvPedidos.Item(columnaDelDGVConCampoCantidad, i).Value Is Nothing) Then
                esValidoElDGV = False
            Else
                If (Not dgvPedidos.Item(columnaDelDGVConCampoCantidad, i).Value Is Nothing) Then
                    If (dgvPedidos.Item(columnaDelDGVConCampoCantidad, i).Value.ToString.Length <= 0) Then
                        esValidoElDGV = False
                    Else
                        Try
                            If Convert.ToDouble(dgvPedidos.Item(columnaDelDGVConCampoCantidad, i).Value.ToString) <= 0 Then
                                esValidoElDGV = False
                            End If
                        Catch ex As Exception
                            esValidoElDGV = False
                        End Try
                    End If
                Else
                    esValidoElDGV = False
                End If
            End If
            i += 1
        End While

        Return esValidoElDGV
    End Function

    Public Function verificaViajeNoAlPasado(ByVal fechaHoraPedido As Date, ByVal fechaHoraLlegada As Date) As Boolean
        ' El pedido no puede enviarse al pasado.
        If fechaHoraPedido >= fechaHoraLlegada.AddDays(1) Then
            Return False
        Else
            Return True
        End If
    End Function

End Module
