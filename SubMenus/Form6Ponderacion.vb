Public Class Form6Ponderacion
    Private _examen1 As String = ""
    Private _examen2 As String = ""
    Private _tarea As String = ""
    Private _expoClase As String = ""

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        _examen1 = TextBoxExa1.Text
        _examen2 = TextBoxExa2.Text
        _tarea = TextBoxTarea.Text
        _expoClase = TextBoxExpo.Text

        Dim califExa1, califExa2, califTarea, califExpo, califFinal As Double

        If Not String.IsNullOrEmpty(_examen1) AndAlso Not String.IsNullOrWhiteSpace(_examen1) AndAlso
            Not String.IsNullOrEmpty(_examen2) AndAlso Not String.IsNullOrWhiteSpace(_examen2) AndAlso
            Not String.IsNullOrEmpty(_tarea) AndAlso Not String.IsNullOrWhiteSpace(_tarea) AndAlso
            Not String.IsNullOrEmpty(_expoClase) AndAlso Not String.IsNullOrWhiteSpace(_expoClase) Then

            califExa1 = _examen1 * 0.25
            califExa2 = _examen2 * 0.35
            califTarea = _tarea * 0.15
            califExpo = _expoClase * 0.25

            califFinal = califExa1 + califExa2 + califTarea + califExpo

            LabelResultado.Text = "La calificacion final es de " & califFinal

        Else
            LabelResultado.Text = "No se pudo calcular la calificacion"
            MessageBox.Show("Favor de ingresar un valor en todos los campos")
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxExa1.Clear()
        TextBoxExa2.Clear()
        TextBoxTarea.Clear()
        TextBoxExpo.Clear()
        LabelResultado.Text = ""
    End Sub

    Private Sub ButtonMenuPrincipal_Click(sender As Object, e As EventArgs) Handles ButtonMenuPrincipal.Click
        'Oculatamos el formulario de ponderacion
        Me.Hide()
        'Nos redirigimos al formulario principal
        Dim form1 As New Form1()
        form1.Show()
    End Sub
End Class