Public Class FormFacturas

    Dim search As ConnectDB
    Dim data As DataSet
    Dim id As Integer
    Dim elegir As Boolean

    Private Sub Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        iniciardgv(0)
    End Sub

    'rellena el dgv con los proveedores que hay en ese momento
    Sub iniciardgv(ByVal eliminado As Integer)

        'Dim poblacion As String
        'Dim pob As Integer

        'Data = search.getData("Select id , cifnif, nombre , direccion , telefono , cp from proveedores where eliminado =" & eliminado, "tproveedores")

        'Dim tProveedores As DataTable = data.Tables("tproveedores")


        estilodgvArtDani(dgvFacturas)

        For i As Integer = 0 To dgvFacturas.ColumnCount
            dgvFacturas.Rows.Clear()
        Next
        'Dim fila As String()
        'For Each row As DataRow In tProveedores.Rows

        'pob = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row("cp"))
        'poblacion = search.DLookUp("poblacion", "poblaciones", "idpoblacion = '" & pob & "'")


        'fila = {row(0).ToString, row(1).ToString, row(2).ToString, poblacion, row(3).ToString, row(4).ToString}
        'dgvProveedores.Rows.Add(fila)
        'Next

        'dgvProveedores.Columns(0).Visible = False

        'If (dgvProveedores.RowCount > 0) Then
        'id = dgvProveedores.Rows(0).Cells(0).Value
        'Else
        'id = -1
        'End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmFacturas.Show()
    End Sub
End Class