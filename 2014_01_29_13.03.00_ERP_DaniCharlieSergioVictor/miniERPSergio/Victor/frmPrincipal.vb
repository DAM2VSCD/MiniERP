Public Class frmPrincipal

    Private Sub frmPrincipal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        insertarCambio("Cierre de sesión", 0)
    End Sub


    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'DANI: Cremamos el objeto crypt y le damos la cadena que usará como clave para el método de encriptación.
        crypt = New Simple3Des("MiniERP&DAM2_2013")
        primer_inicio = False
        genera_admin()
        '==========================

        actualizarMenus()


    End Sub

    Private Sub ConectarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmIniciasSesion.Click
        msMenu.Enabled = False
        'frmConectar.Show()
        genera_admin()
    End Sub

    Private Sub tsmCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCerrarSesion.Click
        insertarCambio("Cierre de sesión", 0)
        Comun.idUsuario = 0
        Comun.nombre = Nothing
        'Dim frm As Form

        Dim Success As Boolean
        Do
            Success = True
            Try
                For Each f As Form In My.Application.OpenForms
                    If Not f.Name.Equals("frmPrincipal") Then f.Close()
                Next f
            Catch ex As Exception
                Success = False
            End Try
        Loop Until Success
        actualizarMenus()
    End Sub




    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSalir.Click
        If MsgBox("¿Desea salir de la aplicación?", vbYesNo) = vbYes Then
            If Not idUsuario = 0 Then
                insertarCambio("Cierre de sesión", 0)
            End If

            End
        End If
        
    End Sub


    'Cambia los menus accesibles segun el usuario conectado
    Sub actualizarMenus()

        'Comun.idUsuario = 1

        'If (Comun.idUsuario = 1) Then 'Usuario administrador
        If (Comun.nombre = "admin00") Then 'Usuario administrador
            tsmUsuarios.Visible = True

            tsmUsuarios.Visible = True
            tsmArticulos.Visible = True
            tsmClientes.Visible = True

            tsmIniciasSesion.Visible = False
            tsmCerrarSesion.Visible = True

            tsmPedidos.Visible = True
            tsmTipos.Visible = True
            tsmCambios.Visible = True

            ProveedoresToolStripMenuItem.Visible = True

            tsmCopiaGeneralXML.Visible = True

            'AÑADIDO POR DANI
            tsmCaja.Visible = True

        ElseIf Not Comun.idUsuario = 0 Then 'Usuario no administrador

            tsmUsuarios.Visible = False
            tsmArticulos.Visible = True
            tsmClientes.Visible = True

            tsmIniciasSesion.Visible = False
            tsmCerrarSesion.Visible = True

            tsmPedidos.Visible = True
            tsmTipos.Visible = False
            tsmCambios.Visible = True

            ProveedoresToolStripMenuItem.Visible = True

            tsmCopiaGeneralXML.Visible = False

            'AÑADIDO POR DANI
            tsmCaja.Visible = False

        Else 'Ningun usuario conectado

            tsmUsuarios.Visible = False
            tsmArticulos.Visible = False
            tsmClientes.Visible = False

            tsmIniciasSesion.Visible = True
            tsmCerrarSesion.Visible = False

            tsmPedidos.Visible = False
            tsmTipos.Visible = False
            tsmCambios.Visible = False

            ProveedoresToolStripMenuItem.Visible = False

            tsmCopiaGeneralXML.Visible = False

            'AÑADIDO POR DANI
            tsmCaja.Visible = False
        End If
    End Sub



    Private Sub tsmCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCambios.Click
        frmCambios.Show()
    End Sub

    'Private Sub tsmPeididosNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'frmPedidosPrincipal.Show()
    'End Sub


    'DANI
    Private Sub genera_admin()

        Dim request As New DataSet

        request = conexion.getData("select * from usuarios", "USUARIOS")

        Dim t As DataTable = request.Tables("USUARIOS")

        If (t.Rows.Count > 0) Then
            frmConectar.Show()
        Else
            Dim frmNUser As New frmNewUser("N", 1)
            frmNUser.Text = "Genera Admin"
            frmNUser.txtUser.Text = "admin00"
            frmNUser.txtUser.Enabled = False
            frmNUser.pbErrorUser.Visible = False
            frmNUser.pbOkUser.Visible = True
            frmNUser.ShowDialog()
        End If

    End Sub

    

    Private Sub tsmUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUsuarios.Click

        frmUsuarios.Show()
    End Sub

    Private Sub tsmArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmArticulos.Click
        frmArticulos.setElegir = False
        frmArticulos.Show()
    End Sub

    'Private Sub tsmPedidosRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' frmPedidosBuscar.Show()
    'End Sub

    Private Sub tsmPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPedidos.Click

        frmPedidosBuscar.Show()
    End Sub

    Private Sub tsmClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmClientes.Click
        frm_Clientes.setElegir = False
        frm_Clientes.Show()
    End Sub

    Private Sub TiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTipos.Click

        frmGenero.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frm_Proveedores.setElegir = False
        frm_Proveedores.Show()
    End Sub

    Private Sub tsmCopiaGeneralXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCopiaGeneralXML.Click
        Comun.generaCopiaSeguridadGeneralEnXML()
    End Sub

    Private Sub tsmArticProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmArticulosProv.Show()
    End Sub

    Private Sub CajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCaja.Click
        frmCaja.Show()
    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not MsgBox("¿Desea salir de la aplicación?", vbYesNo) = vbYes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        FormFacturas.Show()
    End Sub

    Private Sub PruebaFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PruebaFacturasToolStripMenuItem.Click
        Try
            crearFacturaDesdePedidos(1, 1)
            MsgBox("Insertado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class