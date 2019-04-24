Public Class FrmMain
    Private Escenario As Integer = 1 ' Numero del Escenario
    Private distanciaX_segura As Integer = 65 ' Distancia segura en X
    Private distanciaY_segura As Integer = 150 ' Distancia segura en Y

    Private Sub UbicarEgo(ByVal Lugar As String) ' Función para ubicar el coche Ego
        Select Case Lugar
            Case "Izquierda" : Ego.Location = New Point(37, 380) ' Ubicar Ego en el carril izquierdo
            Case "Derecha" : Ego.Location = New Point(170, 380) ' Ubicar Ego en el carril derecho
        End Select
    End Sub

    Private Sub UbicarPrincipal(ByVal Lugar As String, ByVal y As Integer) ' Función para ubicar el coche Principal
        Select Case Lugar
            Case "Izquierda" : Principal.Location = New Point(37, y) ' Ubicar Principal en el carril izquierdo
            Case "Derecha" : Principal.Location = New Point(170, y) ' Ubicar Principal en el carril derecho
        End Select
    End Sub

    Private Sub tmMoverCarros_Tick(sender As Object, e As EventArgs) Handles tmMoverCarros.Tick
        ' Función Timer para el movimiento de los carros
        Dim distanciaX As Integer = Math.Abs(Ego.Left - Principal.Left) ' Valor absuluto de la diferencia de la posición del Ego y el Principal en X
        Dim distanciaY As Integer = Ego.Top - Principal.Top ' Diferencia de la posición del Ego y el Principal en Y
        SistemaACC(Ego, distanciaX, distanciaY) ' Asignar Sistema ACC al Carro Ego
        Select Case Escenario ' Realizar movimiento específico del carro Principal para ver como reacciona el ACC del carro Ego en algunos Escenarios
            Case 2 ' Escenario 2
                If Ego.Top <= 180 Then ' Si el Ego se acerca a una distanciaY de 180
                    If Principal.Left <= 110 Then ' Si el carro Principal está lejos del carril derecho --->
                        Principal.Left = Principal.Left + 3 ' Mover Principal a la derecha a velocidad rápida (3)
                    ElseIf Principal.Left <= 130 Then ' Si el carro Principal está a medias del carril derecho -->
                        Principal.Left = Principal.Left + 2 ' Mover Principal a la derecha a velocidad media (2)
                    ElseIf Principal.Left <= 170 Then ' Si el carro Principal está cerca del carril derecho ->
                        Principal.Left = Principal.Left + 1 ' Mover Principal a la derecha a velocidad lenta (1)
                    End If
                End If
            Case 3 ' Escenario 3
                If Principal.Top = 20 Then ' Si la posición en Y del carro Principal es 20
                    Principal.Top = Principal.Top ' Tomar una velocidad constante
                Else
                    Principal.Top = Principal.Top - 1 ' Mover el coche principal hacia arriba con una velocidad lenta (1)
                End If
            Case 4 ' Escenario 4
                If Principal.Top = 20 Then ' Si la posición en Y del carro Principal es 20
                    Principal.Top = Principal.Top ' Tomar una velocidad constante
                    If Principal.Left >= 97 Then ' Si el carro Principal está lejos del carril izquierdo <---
                        Principal.Left = Principal.Left - 3 ' Mover Principal a la izquierda a velocidad rápida (3)
                    ElseIf Principal.Left >= 77 Then ' Si el carro Principal está a medias del carril izquierdo <--
                        Principal.Left = Principal.Left - 2 ' Mover Principal a la izquierda a velocidad media (2)
                    ElseIf Principal.Left >= 37 Then ' Si el carro Principal está cerca del carril izquierdo <-
                        Principal.Left = Principal.Left - 1 ' Mover Principal a la derecha a velocidad lenta (1)
                    End If
                Else
                    Principal.Top = Principal.Top - 1 ' Mover el coche principal hacia arriba con una velocidad lenta (1)
                End If
        End Select
    End Sub

    Private Sub Empezar_Click(sender As Object, e As EventArgs) Handles Empezar.Click
        ' Si el botón de empezar es presionado
        Reiniciar() ' Reiniciar el Escenario
        If Escenario <> 1 Then ' Si el escenario no es el Escenario 1
            tmMoverCalle.Start() ' Activar timer para mover las calles
        End If
        tmMoverCarros.Start() ' Activar timer para mover los carros
    End Sub

    Private Sub tmCalle_Tick(sender As Object, e As EventArgs) Handles tmMoverCalle.Tick
        Calle1.Top = Calle1.Top + 6 ' Mover calle 1 hacia abajo
        Calle2.Top = Calle2.Top + 6 ' Mover calle 2 hacia abajo
        Calle3.Top = Calle3.Top + 6 ' Mover calle 3 hacia abajo
        ReiniciarCalles() ' Cuando una calle salga de la ventana, reiniciarla para que sea infinita
    End Sub

    Private Sub Escenario1_Click(sender As Object, e As EventArgs) Handles Escenario1.Click
        Titulo(1) ' Asignar el número del escenario al título ventana
        Reiniciar() ' Reiniciar Escenario
        Escenario1.BackColor = Color.ForestGreen
        Escenario2.BackColor = Color.MediumSeaGreen
        Escenario3.BackColor = Color.MediumSeaGreen
        Escenario4.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub Escenario2_Click(sender As Object, e As EventArgs) Handles Escenario2.Click
        Titulo(2) ' Asignar el número del escenario al título ventana
        Reiniciar() ' Reiniciar Escenario
        Escenario1.BackColor = Color.MediumSeaGreen
        Escenario2.BackColor = Color.ForestGreen
        Escenario3.BackColor = Color.MediumSeaGreen
        Escenario4.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub Escenario3_Click(sender As Object, e As EventArgs) Handles Escenario3.Click
        Titulo(3) ' Asignar el número del escenario al título ventana
        Reiniciar() ' Reiniciar Escenario
        Escenario1.BackColor = Color.MediumSeaGreen
        Escenario2.BackColor = Color.MediumSeaGreen
        Escenario3.BackColor = Color.ForestGreen
        Escenario4.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub Escenario4_Click(sender As Object, e As EventArgs) Handles Escenario4.Click
        Titulo(4) ' Asignar el número del escenario al título ventana
        Reiniciar() ' Reiniciar Escenario
        Escenario1.BackColor = Color.MediumSeaGreen
        Escenario2.BackColor = Color.MediumSeaGreen
        Escenario3.BackColor = Color.MediumSeaGreen
        Escenario4.BackColor = Color.ForestGreen
    End Sub

    Private Sub Titulo(ByVal n As Integer)
        Escenario = n ' Captar el numero de escenario
        Me.Text = "Escenario " & Escenario ' Asignar título de la ventana
        Empezar.Enabled = True ' Habilitar el botón de empezar
        tmMoverCarros.Stop() ' Detener el movimiento de los carros
        tmMoverCalle.Stop() ' Detener el movimiento de las calles
    End Sub

    Private Sub ReiniciarCalles()
        If Calle1.Top >= 365 Then
            Calle1.Top = 0
        End If
        If Calle2.Top >= 0 Then
            Calle2.Top = -365
        End If
        If Calle3.Top >= -365 Then
            Calle3.Top = -730
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()  ' Salir
    End Sub

    Private Sub SistemaACC(ByVal Carro As PictureBox, ByVal distanciaX As Integer, ByVal distanciaY As Integer) ' Función del sistema ACC
        If distanciaX <= distanciaX_segura And distanciaY <= distanciaY_segura And distanciaY >= -70 Then
            ' Si la distanciaX es menor o igual a la distancia segura en X (Distancia segura)
            ' Y Si la distanciaY es menor o igual a la distancia segura en Y, y El Ego no está delante del Principal
            If distanciaY < distanciaY_segura Then ' Si distanciaY es menor a la distancia segura
                Carro.Top = Carro.Top + 1 ' Activar Control de Espacio  para volver a la distancia segura
                Carro.Image = My.Resources.Resources.CarroFrenando ' Activar luces de frenado del carro
            Else ' Si distanciaY es igual a la distancia segura
                Carro.Top = Carro.Top ' Velocidad constante para mantener la distancia relativa
                Carro.Image = My.Resources.Resources.Carro ' Desactivar luces de frenado del carro
            End If
        ElseIf distanciaX <= distanciaX_segura And distanciaY <= distanciaY_segura + 20 And distanciaY >= -70 Then
            ' Si la distanciaX es menor o igual a la distancia segura en X (Distancia segura)
            ' Y Si la distanciaY es menor o igual a la distancia segura en Y + 20 (Cerca de la distancia segura), y El Ego no está delante del Principal
            Carro.Top = Carro.Top - 1 ' Desacelerar para tomar una velocidad mas lenta
            Carro.Image = My.Resources.Resources.CarroFrenando ' Activar luces de frenado
        ElseIf distanciaX <= distanciaX_segura + 5 And distanciaY <= distanciaY_segura + 50 And distanciaY >= -70 Then
            ' Si la distanciaX es menor o igual a la distancia segura en X + 5 (Cerca de la distancia segura)
            ' Y Si la distanciaY es menor o igual a la distancia segura en Y + 50 (Acercandose a la distancia segura), y El Ego no está delante del Principal
            Carro.Top = Carro.Top - 2 ' Desacelerar para tomar una velocidad mediana
            Carro.Image = My.Resources.Resources.CarroFrenando ' Activar luces de frenado
        Else ' Si está muy lejos de algún carro
            Carro.Top = Carro.Top - 3 ' Velocidad rápida
            Carro.Image = My.Resources.Resources.Carro ' Imágen del carro
        End If
    End Sub

    Private Sub Reiniciar()
        Select Case Escenario
            Case 1 ' Escenario 1
                UbicarEgo("Izquierda") ' Ubicar Ego en el carril izquierdo
                UbicarPrincipal("Izquierda", 19) ' Ubicar principal en el carril izquierdo por arriba
            Case 2
                UbicarEgo("Derecha") ' Ubicar Ego en el carril derecho
                UbicarPrincipal("Izquierda", 19) ' Ubicar principal en el carril izquierdo por arriba
            Case 3
                UbicarEgo("Izquierda") ' Ubicar Ego en el carril izquierdo
                UbicarPrincipal("Izquierda", 100) ' Ubicar principal en el carril izquierdo, y más abajo
            Case 4
                UbicarEgo("Derecha") ' Ubicar Ego en el carril derecho
                UbicarPrincipal("Derecha", 100) ' Ubicar principal en el carril derecho, y más abajo
        End Select
    End Sub
End Class