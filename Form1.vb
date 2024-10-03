Imports System.Windows

Public Class Form1
    Private _selectCheckValue As Integer? = Nothing

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As ItemCheckEventArgs) Handles CheckedListMenu.ItemCheck
        'Valida si el usuario está seleccionando (y no desmarcando)
        If e.NewValue = CheckState.Checked Then
            ' Recorre todos los ítems de la lista
            _selectCheckValue = e.Index
            For i As Integer = 0 To CheckedListMenu.Items.Count - 1
                'Si un elemento del checkbox es diferente al que se está seleccionando, se desmarca
                If i <> e.Index Then
                    CheckedListMenu.SetItemChecked(i, False)
                End If
            Next
        Else
            If e.CurrentValue = CheckState.Checked AndAlso _selectCheckValue = e.Index Then
                _selectCheckValue = Nothing
            End If
        End If
    End Sub

    Private Sub ButtonContinuar_Click(sender As Object, e As EventArgs) Handles ButtonContinuar.Click
        'Obtenemos el valor de la lista del checkbox
        Dim value As Integer? = _selectCheckValue

        'Validamos si no es nulo
        If value.HasValue Then
            Select Case value
                Case 0
                    'Se crea una instancia del formulario 2 de promedio
                    Dim form2Promedio As New Form2Promedio()
                    'Mostramos el formulario
                    form2Promedio.ControlBox = False
                    form2Promedio.Show()
                    'Ocultamos el formulario principal
                    Me.Hide()
                Case 1
                    Dim form3NumeroMayor As New Form3NumeroMayor()
                    form3NumeroMayor.ControlBox = False
                    form3NumeroMayor.Show()
                    'Ocultamos el formulario principal
                    Me.Hide()
                Case 2
                    Dim form4NumParImpar As New Form4NumParImpar()
                    form4NumParImpar.ControlBox = False
                    form4NumParImpar.Show()
                    Me.Hide()
                Case 3
                    Dim form5OperacionesBasicas As New Form5OperacionesBasicas()
                    form5OperacionesBasicas.ControlBox = False
                    form5OperacionesBasicas.Show()
                    Me.Hide()
                Case 4
                    Dim form6Ponderacion As New Form6Ponderacion()
                    form6Ponderacion.ControlBox = False
                    form6Ponderacion.Show()
                    Me.Hide()
            End Select
        Else
            MessageBox.Show("Favor seleccionar una opcion")
        End If
    End Sub

    Private Sub ButtonTerminar_Click(sender As Object, e As EventArgs) Handles ButtonTerminar.Click
        'Terminar la aplicacion con un codigo de salida exitoso
        Environment.Exit(0)
    End Sub
End Class
