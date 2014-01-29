Imports System.Text.RegularExpressions

Public Class frm_Nuevo_Modificar_Clientes
    Dim search As ConnectDB
    Dim data As DataSet
    Dim id As Integer

    Dim tip As ToolTip

    'costructor
    Sub New(ByVal num As Integer)
        InitializeComponent()
        Me.TopMost = True

        Me.id = num
       
        inhabilitaClick()
        search = New ConnectDB
        data = New DataSet
        tip = New ToolTip()
        Dim sSql As String = "Select distinct idcomunidad, comunidad from comunidades order by comunidad"
        rellenacombobox(cboComunidades, sSql, "-- Elija comunidad --")

        If Not Me.id = -1 Then
            btnNuevo.Visible = False
            rellena()
            bien()
        Else
            btnGuardar.Visible = False
            If TypeOf search.DLookUp("max(numcliente)", "clientes", "") Is DBNull Then
                txtNumero.Text = "1000"
            Else
                Dim numero As Integer = search.DLookUp("max(numcliente)", "clientes", "")

                txtNumero.Text = numero + 1
            End If
            errores()
        End If
    End Sub

    'busca si existe algun icono de error activo
    Private Function algunError() As Boolean
        If (pboxAp1Fallo.Visible = True Or pboxAp2Fallo.Visible = True Or pboxDireccionFallo.Visible = True Or pboxEmailFallo.Visible = True Or
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
        inhabilitaClickDerecho(txtApellido1)
        inhabilitaClickDerecho(txtApellido2)
        inhabilitaClickDerecho(txtDireccion)
        inhabilitaClickDerecho(txtTelefono)
        inhabilitaClickDerecho(txtEmail)

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
        pboxAp1Fallo.Visible = True
        pboxAp2Fallo.Visible = True
        pboxDireccionFallo.Visible = True
        pboxEmailFallo.Visible = True
        pboxNombreFallo.Visible = True
        pboxPoblacionFallo.Visible = True
        pboxTelefonoFallo.Visible = True
        pboxProvinciaFallo.Visible = True
        pboxCPFallo.Visible = True
        pboxComunidadFallo.Visible = True
    End Sub

    'pone visisbles todos los iconos de acierto 
    Private Sub bien()
        pboxAp1Acierto.Visible = True
        pboxAp2Acierto.Visible = True
        pboxDireccionAcierto.Visible = True
        pboxEmailAcierto.Visible = True
        pboxNombreAcierto.Visible = True
        pboxPoblacionAcierto.Visible = True
        pboxTelefonAcierto.Visible = True
        pboxProvinciaAcierto.Visible = True
        pboxCPAcierto.Visible = True
        pboxComunidadAcierto.Visible = True
    End Sub

    'rellena introduce todos los campos actuales del cliente a modificar
    Public Sub rellena()
        data = search.getData("SELECT * FROM clientes where idcliente = " & id, "data")
        Dim tabla As DataTable = data.Tables("data")
        Dim row As DataRow = tabla.Rows(0)

        txtNumero.Text = row("numcliente")
        txtNombre.Text = row("nombre")
        txtApellido1.Text = row("apellido1")
        txtApellido2.Text = row("apellido2")
        txtDireccion.Text = row("direccion")

        Dim pob As Integer = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row("refcppoblaciones"))

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
        sSql = ("Select distinct idcodigopostal, codigopostal from codigospostalespoblaciones, codigospostales, provincias " & _
                                "where refpoblacion = " & cboPoblacion.SelectedValue() & _
                                " and refprovincia=" & cboProvincia.SelectedValue() & " and refcodigopostal = idcodigopostal and " & _
                                "refprovincia = idprovincia")

        rellenacombobox(cboCodigoPostal, sSql, "")

        cboCodigoPostal.SelectedValue = row("refcppoblaciones")
        txtTelefono.Text = row("telefono")
        txtEmail.Text = row("mail")

    End Sub

    'La serie de cambios que ocurren cuando se seleciona una comunidad.
    Private Sub cboComunidades_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboComunidades.SelectionChangeCommitted
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

    

    'Cuando se pulsa el boton salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("Sus cambios no se almacenaran ¿Seguro que deseea salir?", MsgBoxStyle.YesNo, "Confirmacion")
        If respuesta = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    'Cuando se pulsa el boton guardar se realiza un update al al cliente en cuestion
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (algunError()) Then
            MsgBox("Alguno(s) campos son erroneos")
        Else
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea modificar el cliente?", MsgBoxStyle.YesNo, "Confirmacion")
            If respuesta = MsgBoxResult.Yes Then
                search.setData("update clientes set nombre = '" & txtNombre.Text & "', apellido1 = '" & txtApellido1.Text & _
                               "' , apellido2 = '" & txtApellido2.Text & "', direccion = '" & txtDireccion.Text & _
                               "' , refcppoblaciones = " & cboCodigoPostal.SelectedValue & " , telefono =" & txtTelefono.Text & _
                               ", mail = '" & txtEmail.Text & "' where idcliente = " & id)
                Dim nombre As String = search.DLookUp("nombre", "clientes", "idcliente=" & id)
                insertarCambio("Actualizado cliente " & nombre, 0)
                MsgBox("Modificado con exito")
                Me.Dispose()
            End If
        End If
    End Sub

    'Cuando se clica en nuevo se añade el nuevo cliente
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If (algunError()) Then
            MsgBox("Alguno(s) campos son erroneos")
        Else
            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea almacenar el nuevo cliente?", MsgBoxStyle.YesNo, "Confirmacion")
            If respuesta = MsgBoxResult.Yes Then
                If TypeOf search.DLookUp("max(idcliente)", "clientes", "") Is DBNull Then
                    id = 1
                Else
                    id = (search.DLookUp("max(idcliente)", "clientes", "") + 1)
                End If
                search.setData("insert into clientes (nombre, apellido1, apellido2, direccion, refcppoblaciones, " &
                               "telefono, mail, eliminado, numcliente) values('" & txtNombre.Text & "' , '" & txtApellido1.Text & _
                              "' , '" & txtApellido2.Text & "' , '" & txtDireccion.Text & "' , " & cboCodigoPostal.SelectedValue & _
                            " , " & Integer.Parse(txtTelefono.Text) & " , '" & txtEmail.Text & "' , 0 , " & txtNumero.Text & ")")
                insertarCambio("Creado cliente " & txtNombre.Text, 0)
                MsgBox("Datos almacenados correctamente")
                Me.Dispose()
            End If
        End If
    End Sub

    'Control de la entrada en el campo de texto
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtNombre.Text.Length = 30 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tip.Show("Solo puede introducir letras con una logitud máxima de 30", txtNombre)
        Else
            tip.Hide(txtNombre)
        End If
    End Sub

    'Control de la entrada en el campo de texto
    Private Sub txtApellido1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido1.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtApellido1.Text.Length = 20 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tip.Show("Solo puede introducir letras con una logitud máxima de 20", txtApellido1)
        Else
            tip.Hide(txtApellido1)
        End If
    End Sub

    'Control de la entrada en el campo de texto
    Private Sub txtApellido2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido2.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtApellido2.Text.Length = 20 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tip.Show("Solo puede introducir letras con una logitud máxima de 20", txtApellido2)
        Else
            tip.Hide(txtApellido2)
        End If
    End Sub

    'Control de la entrada en el campo de texto
    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If txtDireccion.Text.Length = 30 And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tip.Show("Dirección solo tiene una logitud máxima de 30", txtDireccion)
        Else
            tip.Hide(txtDireccion)
        End If
    End Sub

    'Control de la entrada en el campo de texto
    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If (txtEmail.Text.Length = 30) And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tip.Show("Solo puede introducir letras con una logitud máxima de 30", txtEmail)
        Else
            tip.Hide(txtDireccion)
           
        End If
    End Sub

    'Control de la entrada en el campo de texto
    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If (ValorNumerico(AscW(e.KeyChar)) = False Or txtTelefono.Text.Length = 9) And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tip.Show("Solo puede introducir numeros con una logitud máxima de 9", txtTelefono)
        Else
            tip.Hide(txtTelefono)
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
    Private Sub txtApellido1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellido1.KeyUp
        If txtApellido1.Text.Equals("") Then
            pboxAp1Acierto.Visible = False
            pboxAp1Fallo.Visible = True
        Else
            pboxAp1Acierto.Visible = True
            pboxAp1Fallo.Visible = False
        End If
    End Sub


    'Comprobación en la que se mira sei el campo de texto esta vacio
    Private Sub txtApellido2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellido2.KeyUp
        If txtApellido2.Text.Equals("") Then
            pboxAp2Acierto.Visible = False
            pboxAp2Fallo.Visible = True
        Else
            pboxAp2Acierto.Visible = True
            pboxAp2Fallo.Visible = False

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

    'Comprobación en la que se mira sei el campo de texto esta vacio y que el email sea correcto
    Private Sub txtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyUp
        If txtEmail.Text.Equals("") Then
            pboxEmailAcierto.Visible = False
            pboxEmailFallo.Visible = True
        Else
            Dim mail As String = txtEmail.Text
            Dim rgx As New Regex("^[\w-\.]+@\w+\.\w+$")
            If rgx.IsMatch(mail) Then
                pboxEmailAcierto.Visible = True
                pboxEmailFallo.Visible = False
            Else
                pboxEmailAcierto.Visible = False
                pboxEmailFallo.Visible = True
            End If
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

   
    Private Sub btnLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLC.Click
        frmCambios.Show()
    End Sub

End Class