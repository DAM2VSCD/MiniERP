Public Class frmCambios

    Dim sec As String

    Private Sub frmCambios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = frmPrincipal
        estilodgvArt(dgvCambios)

        Dim sql As String = "SELECT IDUSUARIO, NOMBRE FROM USUARIOS"
        rellenacombobox(cboUsuario, sql, "--Todos--")

        dtpFecha.Enabled = False

        actualizar()

    End Sub

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged
        actualizar()
    End Sub


    Private Sub cboUsuario_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsuario.SelectedIndexChanged
        'Filtra por usuario

        If IsNumeric(cboUsuario.SelectedValue.ToString) Then
            sec = cboUsuario.SelectedValue.ToString
            If sec = -1 Then
                sec = "%"
            End If
        Else
            sec = "%"
        End If

        actualizar()

    End Sub

    Private Sub cbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged

        'Abilita o inabilita la fecha
        If cbFecha.Checked Then
            dtpFecha.Enabled = True
        Else
            dtpFecha.Enabled = False
        End If

        actualizar()

    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        actualizar()
    End Sub


    Private Sub actualizar()

        'Filtra por numero si hay algo introducido
        Dim num As String = "%"
        If (Not txtNumero.Text.Equals("")) Then
            num = txtNumero.Text
        End If

        'Filtra por fecha si el checkbox esta activo
        Dim fec As String = "%"
        If cbFecha.Checked Then
            fec = Fecha2number(dtpFecha.Value)
            'MsgBox(Fecha2number(dtpFecha.Value))
        End If

        dgvCambios.Rows.Clear()


        Dim Data As DataSet = Comun.conexion.getData("SELECT NUMCAMBIO AS NUMERO, NOMBRE AS USUARIO, FECHA, HORA, DESCRIPCION " & _
                                                          "FROM CAMBIOS, USUARIOS " & _
                                                          "WHERE REFUSUARIO=IDUSUARIO " & _
                                                          "AND NUMCAMBIO LIKE '" & num & "%' " & _
                                                          "AND REFUSUARIO LIKE '" & sec & "' " & _
                                                          "AND FECHA LIKE '" & fec & "' " & _
                                                          "ORDER BY NUMCAMBIO DESC, NUMERO, HORA", "CAM")

        Dim t As DataTable = Data.Tables("CAM")

        For Each f As DataRow In t.Rows 'Convierte la fecha de cientifico a date
            Dim fecha As Date = number2Date(f("FECHA"), f("HORA"))
            dgvCambios.Rows.Add(f("NUMERO"), f("USUARIO"), fecha, f("DESCRIPCION"))
        Next

    End Sub


    Private Sub frmCambios_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        dgvCambios.Width = Me.Width - 40
        dgvCambios.Height = Me.Height - 140
    End Sub

    ' Crea una copia de seguridad en xml de la tabla CAMBIOS
    Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_cambios.xml", "cambios")
    End Sub
End Class