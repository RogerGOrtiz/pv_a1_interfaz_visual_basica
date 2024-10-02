Public Class Form4NumParImpar

    Private _numero As String = ""
    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        _numero = TextBoxNumero.Text
        Dim numero As Double
        Dim mensaje As String

        If Not String.IsNullOrEmpty(_numero) AndAlso Not String.IsNullOrWhiteSpace(_numero) Then
            If Double.TryParse(_numero, numero) Then
                If numero Mod 2 = 0 Then
                    mensaje = "El numero " & numero & " es par"
                Else
                    mensaje = "El numero " & numero & " es impar"
                End If
                LabelResultado.Text = mensaje
            Else
                MessageBox.Show("Favor de ingresar un numero valido")
                LabelResultado.Text = "No se pudo determinar si el numero es par o impar"
            End If

        Else
            MessageBox.Show("Favor de ingresar un numero")
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxNumero.Clear()
        LabelResultado.Text = ""
    End Sub

    Private Sub ButtonMenuPrincipal_Click(sender As Object, e As EventArgs) Handles ButtonMenuPrincipal.Click
        'Oculatamos el formulario de parImpar
        Me.Hide()
        'Nos redirigimos al formulario principal
        Dim form1 As New Form1()
        form1.Show()
    End Sub
End Class