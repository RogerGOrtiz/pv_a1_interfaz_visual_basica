Public Class Form2Promedio
    Private _nombMateria As String = ""
    Private _numEstudiantesText As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonMenuPrincipal.Click
        'Oculatamos el formulario de promedio
        Me.Hide()
        'Nos redirigimos al formulario principal
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        _nombMateria = TextBoxNombMateria.Text
        _numEstudiantesText = TextBoxNumEstudiantes.Text

        Dim sumaCalificacion As Double = 0.0
        Dim promedio As Double = 0.0
        Dim calificacion As Double

        If Not String.IsNullOrEmpty(_nombMateria) AndAlso Not String.IsNullOrEmpty(_numEstudiantesText) Then
            Dim numEstudiantes As Integer

            If Integer.TryParse(_numEstudiantesText, numEstudiantes) Then
                'Se configura el modal
                Dim formModal As New FormModal()
                formModal.ControlBox = False

                ButtonMenuPrincipal.Enabled = False

                For i As Integer = 1 To numEstudiantes
                    formModal.ConfigurarModal("Calcular Promeido", "Ingrese la calificacion del estudiante " & i & " :")

                    If formModal.ShowDialog() = DialogResult.OK AndAlso Double.TryParse(formModal.InputValue, calificacion) Then
                        sumaCalificacion = sumaCalificacion + calificacion
                    Else
                        MessageBox.Show("El valor ingresado no es un número válido.")
                        Exit For
                    End If
                Next

                promedio = sumaCalificacion / numEstudiantes
                LabelResultado.Text = "En la materia de " & _nombMateria & " el promedio fue de " & promedio.ToString("F2")
            Else
                MessageBox.Show("Favor de ingresar un numero valido en el campo de numero de estudiantes")
            End If
        Else
            MessageBox.Show("Favor de ingresar el nombre de la materia y la cantidad de estudiantes")
        End If

        ButtonMenuPrincipal.Enabled = True
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxNombMateria.Clear()
        TextBoxNumEstudiantes.Clear()
        LabelResultado.Text = ""
    End Sub
End Class