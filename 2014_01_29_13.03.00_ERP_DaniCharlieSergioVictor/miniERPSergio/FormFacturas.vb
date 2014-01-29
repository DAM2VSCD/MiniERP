Public Class FormFacturas

    Dim search As ConnectDB
    Dim data As DataSet
    Dim id As Integer
    Dim elegir As Boolean

    Private Sub Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal

        estilodgvArtDani(dgvFacturas)

        actualizarDGV()
    End Sub

  

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        FrmFacturas.Show()
    End Sub

    Private Sub actualizarDGV()
        ''Filtra por numero si hay algo introducido
        'Dim num As String = "%"
        'If (Not txtNumero.Text.Equals("")) Then
        '    num = txtNumero.Text
        'End If

        ''Filtra por fecha si el checkbox esta activo
        'Dim fec As String = "%"
        'If cbFecha.Checked Then
        '    fec = Fecha2number(dtpFecha.Value)
        '    'MsgBox(Fecha2number(dtpFecha.Value))
        'End If

        dgvFacturas.Rows.Clear()


        Dim Data As DataSet = Comun.conexion.getData("SELECT numfactura, fecha, hora, refcliente, importeneto, importetotal " & _
                                                          "FROM facturas_clientes " & _
                                                          "ORDER BY fecha DESC, hora", "facturas")

        Dim t As DataTable = Data.Tables("facturas")

        For Each f As DataRow In t.Rows
            Dim fecha As Date = number2Date(f("fecha"), f("hora"))
            dgvFacturas.Rows.Add(f("numfactura"), fecha, f("refcliente"), f("importeneto"), f("importetotal"))
        Next
    End Sub
End Class