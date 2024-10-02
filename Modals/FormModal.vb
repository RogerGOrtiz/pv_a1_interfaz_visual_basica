Public Class FormModal
    Public Property InputValue As String

    'Configura el titulo y el mensaje de entrada del input del modal
    Public Sub ConfigurarModal(titulo As String, etiqueta As String)
        Me.Text = titulo
        LabelMensaje.Text = etiqueta
    End Sub

    'Evento boton aceptar
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        If Not String.IsNullOrWhiteSpace(TextBoxValue.Text) Then
            InputValue = TextBoxValue.Text
            TextBoxValue.Clear()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Por favor ingrese un valor válido.")
        End If
    End Sub

    'Evento boton cancelar
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class