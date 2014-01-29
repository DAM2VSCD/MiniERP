Public Class frm_Nuevo_Modificar_Proveedores

    Dim search As ConnectDB
    Dim data As DataSet
    Public id As Integer

    Dim tip As ToolTip

    Private Sub frm_Nuevo_Modificar_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'InitializeComponent()
        'Me.TopMost = True

        Me.MdiParent = frmPrincipal

        'Me.id = num

        inhabilitaClick()
        search = New ConnectDB
        data = New DataSet
        tip = New ToolTip()
        Dim sSql As String = "Select distinct idcomunidad, comunidad from comunidades order by comunidad"
        rellenacombobox(cboComunidades, sSql, "Seleccione comunidad")

        If Not Me.id = -1 Then
            btnNuevo.Visible = False
            rellena()
            bien()
        Else
            btnGuardar.Visible = False
            errores()
        End If

        crearDGV()
    End Sub

    Private Sub crearDGV()
        Dim Data As DataSet = Comun.conexion.getData("select idarticulo, numarticulo, nombre " & _
                                                         "from articulos " & _
                                                         "where eliminado=0 " & _
                                                         "order by numarticulo", "art")

        Dim t As DataTable = Data.Tables("art")

        Dim idArtic As String
        Dim nomProv As String = ""
        Dim preProv As String = ""
        Dim asociado As Boolean = False
        Dim idRel As String = ""

        For Each f As DataRow In t.Rows

            idArtic = f("idarticulo")

            Dim DataProb As DataSet = Comun.conexion.getData("select id, nombreprov, precioprov " & _
                                                                "from relacionarticulos " & _
                                                                "where eliminado = 0 and " & _
                                                                "refarticulo=" & idArtic & " and " & _
                                                                "refproveedor=" & id, "prob")

            Dim tProb As DataTable = DataProb.Tables("prob")

            If tProb.Rows.Count > 0 Then
                Dim fProb As DataRow = tProb.Rows(0)
                nomProv = fProb("nombreprov")
                preProv = fProb("precioprov")
                asociado = True
                idRel = fProb("id")
            Else
                nomProv = ""
                preProv = ""
                asociado = False
                idRel = ""
            End If



            dgvArticulos.Rows.Add(f("numarticulo"), f("nombre"), asociado, nomProv, preProv, f("idarticulo"), False, idRel)
        Next
    End Sub



    Private Sub dgvArticulos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticulos.CellContentClick

        If dgvArticulos.CurrentCell.ColumnIndex = 2 Then
            dgvArticulos.CurrentRow.Cells(2).Value = Not dgvArticulos.CurrentRow.Cells(2).Value 'actualiza el valor de la celda, necesario para que funcione
            'MsgBox(dgvArticulos.CurrentRow.Cells(2).Value)
            If dgvArticulos.CurrentRow.Cells(2).Value = True Then


                Dim numero = dgvArticulos.CurrentRow.Cells(0).Value
                Dim nombre = dgvArticulos.CurrentRow.Cells(1).Value

                Dim nomProb = dgvArticulos.CurrentRow.Cells(3).Value
                Dim preProb = dgvArticulos.CurrentRow.Cells(4).Value

                frmNuevoRelacion.asociados = dgvArticulos.Rows(e.RowIndex).Cells(2).Value

                frmNuevoRelacion.row = e.RowIndex

                frmNuevoRelacion.numero = numero
                frmNuevoRelacion.nombre = nombre

                frmNuevoRelacion.nomProb = nomProb
                frmNuevoRelacion.preProb = preProb

                frmNuevoRelacion.Show()

                Me.Enabled = False

            Else

                dgvArticulos.CurrentRow.Cells(6).Value = True

            End If
        End If
    End Sub


   

    Private Sub dgvArticulos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvArticulos.CellMouseDoubleClick

        If (e.RowIndex >= 0) Then

            dgvArticulos.Rows(e.RowIndex).Cells(2).Value = Not dgvArticulos.Rows(e.RowIndex).Cells(2).Value

            Dim numero = dgvArticulos.Rows(e.RowIndex).Cells(0).Value
            Dim nombre = dgvArticulos.Rows(e.RowIndex).Cells(1).Value

            Dim nomProb = dgvArticulos.Rows(e.RowIndex).Cells(3).Value
            Dim preProb = dgvArticulos.Rows(e.RowIndex).Cells(4).Value

            frmNuevoRelacion.asociados = dgvArticulos.Rows(e.RowIndex).Cells(2).Value

            frmNuevoRelacion.row = e.RowIndex

            frmNuevoRelacion.numero = numero
            frmNuevoRelacion.nombre = nombre

            frmNuevoRelacion.nomProb = nomProb
            frmNuevoRelacion.preProb = preProb

            frmNuevoRelacion.Show()

            Me.Enabled = False
        End If

    End Sub

    Public Sub nuevoRelacion(ByVal asociado As Boolean, ByVal nombre As String, ByVal precio As String, ByVal row As Integer)
        dgvArticulos.Rows(row).Cells(2).Value = asociado

        dgvArticulos.Rows(row).Cells(3).Value = nombre
        dgvArticulos.Rows(row).Cells(4).Value = precio

        dgvArticulos.Rows(row).Cells(6).Value = True


        'actualizarDGV()
    End Sub

    Public Sub cancelarRelacion(ByVal row As Integer)
        dgvArticulos.Rows(row).Cells(2).Value = False
    End Sub



    'Sub New(ByVal num As Integer)
    '    InitializeComponent()
    '    Me.TopMost = True

    '    Me.id = num

    '    inhabilitaClick()
    '    search = New ConnectDB
    '    Data = New DataSet
    '    tip = New ToolTip()
    '    Dim sSql As String = "Select distinct idcomunidad, comunidad from comunidades order by comunidad"
    '    rellenacombobox(cboComunidades, sSql, "Seleccione comunidad")

    '    If Not Me.id = -1 Then
    '        btnNuevo.Visible = False
    '        rellena()
    '        bien()
    '    Else
    '        btnGuardar.Visible = False
    '        errores()
    '    End If
    'End Sub

    ' Se sobreescribe el Dispose de frm_Nuevo_Modificar_Proveedores.
    Private Sub frmProveedorNuevo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_Proveedores.Enabled = True
        frm_Proveedores.iniciardgv(0)
    End Sub

    'busca si existe algun icono de error activo
    Private Function algunError() As Boolean
        If (pboxDireccionFallo.Visible = True Or pboxNIFFallo.Visible = True Or
            pboxNombreFallo.Visible = True Or pboxPoblacionFallo.Visible = True Or pboxTelefonoFallo.Visible = True Or
            pboxProvinciaFallo.Visible = True Or pboxCPFallo.Visible = True Or pboxComunidadFallo.Visible = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Quita a todos los campos de texto el menu que se despliega con el click derecho
    Private Sub inhabilitaClick()
        inhabilitaClickDerecho(txtNombre)
        inhabilitaClickDerecho(txtDireccion)
        inhabilitaClickDerecho(txtTelefono)
        inhabilitaClickDerecho(txtCIF)

        'Dim contextmenusts As New ContextMenuStrip
        'txtNombre.ContextMenuStrip = contextmenusts
        'txtApellido1.ContextMenuStrip = contextmenusts
        ' txtApellido2.ContextMenuStrip = contextmenusts
        'txtDireccion.ContextMenuStrip = contextmenusts
        'txtTelefono.ContextMenuStrip = contextmenusts
        'txtEmail.ContextMenuStrip = contextmenusts
    End Sub

    'Pone visible todos los iconos de error
    Private Sub errores()

        pboxDireccionFallo.Visible = True
        pboxNIFFallo.Visible = True
        pboxNombreFallo.Visible = True
        pboxPoblacionFallo.Visible = True
        pboxTelefonoFallo.Visible = True
        pboxProvinciaFallo.Visible = True
        pboxCPFallo.Visible = True
        pboxComunidadFallo.Visible = True
    End Sub

    'pone visisbles todos los iconos de acierto 
    Private Sub bien()

        pboxDireccionAcierto.Visible = True
        pboxNIFAcierto.Visible = True
        pboxNombreAcierto.Visible = True
        pboxPoblacionAcierto.Visible = True
        pboxTelefonAcierto.Visible = True
        pboxProvinciaAcierto.Visible = True
        pboxCPAcierto.Visible = True
        pboxComunidadAcierto.Visible = True
    End Sub

    Public Sub rellena()
        data = search.getData("SELECT * FROM proveedores where id = " & id, "data")
        Dim tabla As DataTable = data.Tables("data")
        Dim row As DataRow = tabla.Rows(0)

        txtCIF.Text = row("cifnif")
        txtNombre.Text = row("nombre")
        txtTelefono.Text = row("telefono")
        txtDireccion.Text = row("direccion")

        Dim pob As Integer = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row("cp"))

        Dim pro As Integer = search.DLookUp("refprovincia", "codigospostalespoblaciones", "refpoblacion = " & pob.ToString)

        cboComunidades.SelectedValue = search.DLookUp("refcomunidad", "provincias", "idprovincia = " & pro.ToString)

        Dim sSql As String = ("Select distinct idprovincia, provincia from provincias " & _
                              "where idprovincia = " & pro & "order by provincia")

        rellenacombobox(cboProvincia, sSql, "")
        cboProvincia.SelectedValue = pro
        sSql = ("Select distinct idpoblacion, poblacion from codigospostalespoblaciones, poblaciones " & _
                              "where refprovincia = " & cboProvincia.SelectedValue() & _
                              " and refpoblacion = idpoblacion order by poblacion")

        rellenacombobox(cboPoblacion, sSql, "")
        cboPoblacion.SelectedValue = pob
        sSql = ("Select distinct idcodigopostal, codigopostal from codigospostalespoblaciones, codigospostales " & _
                                "where refpoblacion = " & cboPoblacion.SelectedValue() & _
                                " and refcodigopostal = idcodigopostal")

        rellenacombobox(cboCodigoPostal, sSql, "")

        cboCodigoPostal.SelectedValue = row("cp")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Sus cambios no se almacenaran ¿Seguro que deseea salir?", MsgBoxStyle.YesNo, "Confirmacion")
        If respuesta = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtNombre.Text.Length = 50 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tip.Show("Solo puede introducir letras con una logitud máxima de 50", txtNombre)
        Else
            tip.Hide(txtNombre)
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If (ValorNumerico(AscW(e.KeyChar)) = False Or txtTelefono.Text.Length = 9) And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tip.Show("Solo puede introducir numeros con una logitud máxima de 9", txtTelefono)
        Else
            tip.Hide(txtTelefono)
        End If
    End Sub


    'La serie de cambios que ocurren cuando se seleciona una comunidad.
    Private Sub cboComunidades_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboComunidades.SelectionChangeCommitted
        MsgBox(cboComunidades.SelectedValue)
        cambioComboComunidades(cboComunidades, cboProvincia, cboPoblacion, cboCodigoPostal, tip, pboxComunidadAcierto, pboxComunidadFallo, pboxProvinciaAcierto, pboxProvinciaFallo, pboxPoblacionAcierto, pboxPoblacionFallo, pboxCPAcierto, pboxCPFallo)
    End Sub

    'La serie de cambios que ocurren cuando se seleciona una provincia.
    Private Sub cboProvincia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectionChangeCommitted
        cambioComboProvincias(cboProvincia, cboPoblacion, cboCodigoPostal, tip, pboxProvinciaAcierto, pboxProvinciaFallo, pboxPoblacionAcierto, pboxPoblacionFallo, pboxCPAcierto, pboxCPFallo)
    End Sub

    'La serie de cambios que ocurren cuando se seleciona una población.
    Private Sub cboPoblacion_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPoblacion.SelectionChangeCommitted
        cambioComboPoblacion(cboProvincia, cboPoblacion, cboCodigoPostal, tip, pboxPoblacionAcierto, pboxPoblacionFallo, pboxCPAcierto, pboxCPFallo)
    End Sub




    Private Sub txtCIF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCIF.KeyPress

        If txtCIF.Text.Length = 9 And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tip.Show("Solo puede introducir caracteres con una logitud máxima de 9", txtNombre)
        Else
            tip.Hide(txtNombre)
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress

        If txtDireccion.Text.Length = 100 And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tip.Show("Solo puede introducir letras con una logitud máxima de 100", txtNombre)
        Else
            tip.Hide(txtNombre)
        End If

    End Sub

    'Comprobación en la que se mira sei el campo de texto esta vacio
    Private Sub txtNombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyUp
        If txtNombre.Text.Equals("") Then
            pboxNombreAcierto.Visible = False
            pboxNombreFallo.Visible = True
        Else
            pboxNombreAcierto.Visible = True
            pboxNombreFallo.Visible = False
        End If
    End Sub

    'Comprobación en la que se mira sei el campo de texto esta vacio
    Private Sub txtDireccion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDireccion.KeyUp
        If txtDireccion.Text.Equals("") Then
            pboxDireccionAcierto.Visible = False
            pboxDireccionFallo.Visible = True
        Else
            pboxDireccionAcierto.Visible = True
            pboxDireccionFallo.Visible = False
        End If
    End Sub

    'Comprobación en la que se mira sei el campo de texto esta vacio
    Private Sub txtTelefono_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyUp
        If txtTelefono.Text.Equals("") Then
            pboxTelefonAcierto.Visible = False
            pboxTelefonoFallo.Visible = True
        Else
            pboxTelefonAcierto.Visible = True
            pboxTelefonoFallo.Visible = False
        End If
    End Sub

    Private Sub txtCIF_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCIF.KeyUp
        If txtCIF.Text.Length = 9 Then

            If testNIF(txtCIF.Text) Then
                pboxNIFAcierto.Visible = True
                pboxNIFFallo.Visible = False
            Else
                pboxNIFAcierto.Visible = False
                pboxNIFFallo.Visible = True
            End If
        Else
            pboxNIFAcierto.Visible = False
            pboxNIFFallo.Visible = True
        End If
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim idcodigopostal As String

        If (algunError()) Then
            MsgBox("Alguno(s) campos son erroneos")
        ElseIf existeCIF(txtCIF.Text) Then
            MsgBox("Ese CIF / NIF no está disponible")

        Else
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea almacenar el nuevo proveedor?", MsgBoxStyle.YesNo, "Confirmacion")
            If respuesta = MsgBoxResult.Yes Then
                If TypeOf search.DLookUp("max(id)", "proveedores", "") Is DBNull Then
                    id = 1
                    idcodigopostal = search.DLookUp("idcodigopostal", "codigospostales", "codigopostal like " & cboCodigoPostal.Text).ToString
                Else
                    id = (search.DLookUp("max(id)", "proveedores", "") + 1)
                    idcodigopostal = search.DLookUp("idcodigopostal", "codigospostales", "codigopostal like " & cboCodigoPostal.Text).ToString
                End If

                'insert
                search.setData("insert into proveedores values(" & id & ",'" & txtCIF.Text & "','" & txtNombre.Text & "','" & txtDireccion.Text & "'," & Integer.Parse(idcodigopostal) & "," & Integer.Parse(txtTelefono.Text) & ", 0)")

                insertarCambio("Creado proveedor " & txtNombre.Text, 0)
                MsgBox("Datos almacenados correctamente")
                MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_AUTOMATICA_proveedores.xml", "proveedores")

                guardarRelaciones()

                Me.Dispose()
            End If
        End If


    End Sub

    Private Function existeCIF(ByVal cif As String) As Boolean
        Dim existe As String

        existe = search.DLookUp("count(CIFNIF)", "proveedores", "CIFNIF like '" & cif & "'")

        If existe <> "0" Then
            Return True
        End If

        Return False

    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim idcodigopostal As String

        Dim cif As String


        cif = search.DLookUp("CIFNIF", "proveedores", "id like " & id)



        If (algunError()) Then
            MsgBox("Alguno(s) campos son erroneos")
        ElseIf existeCIF(txtCIF.Text) And cif <> txtCIF.Text Then
            MsgBox("Ese CIF / NIF no está disponible")
        Else
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea modificar el proveedor?", MsgBoxStyle.YesNo, "Confirmacion")
            If respuesta = MsgBoxResult.Yes Then

                idcodigopostal = search.DLookUp("idcodigopostal", "codigospostales", "codigopostal like '" & cboCodigoPostal.Text & "'")

                search.setData("update proveedores set cifnif = '" & txtCIF.Text & "', nombre = '" & txtNombre.Text & "', direccion = '" & txtDireccion.Text & "', cp = " & Integer.Parse(idcodigopostal) & ", telefono = " & Integer.Parse(txtTelefono.Text) & " where id = " & id)

                Dim nombre As String = search.DLookUp("nombre", "proveedores", "id=" & id)

                insertarCambio("Actualizado proveedor " & nombre, 0)
                MsgBox("Modificado con exito")

                guardarRelaciones()

                Me.Dispose()
            End If
        End If


    End Sub

    '--Victor

    Private Sub guardarRelaciones()



        Dim idRelacion As Integer = 0

        For i = 0 To dgvArticulos.Rows.Count - 1

            If dgvArticulos.Rows(i).Cells(6).Value = True Then


                Dim idArt As String = dgvArticulos.Rows(i).Cells(5).Value
                Dim nomProv As String = dgvArticulos.Rows(i).Cells(3).Value
                Dim preProv As String = dgvArticulos.Rows(i).Cells(4).Value

                If dgvArticulos.Rows(i).Cells(7).Value.Equals("") Then ' Si no existia la relacion

                    If dgvArticulos.Rows(i).Cells(2).Value Then




                        Dim Data As DataSet = Comun.conexion.getData("select max(id) from relacionarticulos", "rel")

                        Dim t As DataTable = Data.Tables("rel")

                        Dim f As DataRow = t.Rows(0)

                        If Not IsDBNull(f("max(id)")) Then
                            idRelacion = f("max(id)") + 1
                        Else
                            idRelacion = 1
                        End If



                        'MsgBox("id " & idRelacion)



                        conexion.setData("insert into relacionarticulos (id, refarticulo, refproveedor, eliminado, nombreprov, precioprov) " &
                                    "values ('" & idRelacion & "','" & idArt & "','" & id & "', 0,'" & nomProv & "', '" & preProv & "' )")

                    End If
                Else ' si existia la relacion

                    Dim rel As String = dgvArticulos.Rows(i).Cells(7).Value


                    If dgvArticulos.Rows(i).Cells(2).Value = True Then

                        conexion.setData("update relacionarticulos set nombreprov='" & nomProv & "', precioprov='" & preProv & "' where id='" & rel & "'")
                    Else
                        conexion.setData("update relacionarticulos set eliminado='1' where id='" & rel & "'")

                    End If


                End If

            End If

        Next

    End Sub

    Private Function testNIF(ByVal a As String) As Boolean
        Dim dni As String = a.ToUpper
        Try
            Dim numero As Integer = Integer.Parse((dni.Substring(0, dni.Length - 1)))
            Dim leta As String = dni.Substring(dni.Length - 1, 1)
            leta = leta.ToUpper
            numero = numero Mod 23
            Dim letra = "TRWAGMYFPDXBNJZSQVHLCKET"
            Dim lletra As String = letra.Chars(numero)
            Return (lletra = leta)
        Catch ex As Exception
            Return False
        End Try

    End Function


    


    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged
        actualizarDGV()
    End Sub

    Private Sub txtArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArticulo.TextChanged
        actualizarDGV()
    End Sub

    Private Sub actualizarDGV()



        For i = 0 To dgvArticulos.Rows.Count - 1
            'Muestra u oculta las filas segun los criterios de filtro
            If dgvArticulos.Rows(i).Cells(0).Value.ToString.StartsWith(txtNumero.Text) And
                dgvArticulos.Rows(i).Cells(1).Value.ToString.ToUpper.Contains(txtArticulo.Text.ToUpper) Then

                dgvArticulos.Rows(i).Visible = True
            Else
                dgvArticulos.Rows(i).Visible = False
            End If

        Next

    End Sub

    
End Class

