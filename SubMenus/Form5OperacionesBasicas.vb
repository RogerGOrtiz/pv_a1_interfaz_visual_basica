Public Class Form5OperacionesBasicas
    Private _numero1 As String = ""
    Private _numero2 As String = ""
    Private _tipoOper As String = ""

    Private Sub ButtonMenuPrincipal_Click(sender As Object, e As EventArgs) Handles ButtonMenuPrincipal.Click
        'Oculatamos el formulario de operaciones basicas
        Me.Hide()
        'Nos redirigimos al formulario principal
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        _numero1 = TextBoxNum1.Text
        _numero2 = TextBoxNum2.Text
        _tipoOper = ComboBoxTipoOp.Text

        Dim numero1 As Decimal
        Dim numero2 As Decimal
        Dim resultado As Decimal
        Dim errorRes As Boolean = False

        If Not String.IsNullOrEmpty(_numero1) AndAlso Not String.IsNullOrWhiteSpace(_numero1) AndAlso
            Not String.IsNullOrEmpty(_numero2) AndAlso Not String.IsNullOrWhiteSpace(_numero2) Then
            If Not String.IsNullOrEmpty(_tipoOper) Then

                If Decimal.TryParse(_numero1, numero1) AndAlso
                    Decimal.TryParse(_numero2, numero2) Then
                    Select Case _tipoOper
                        Case "Suma"
                            resultado = numero1 + numero2
                        Case "Resta"
                            resultado = numero1 - numero2
                        Case "Multiplicacion"
                            resultado = numero1 * numero2
                        Case "Division"
                            If numero2 <> 0 Then
                                resultado = numero1 / numero2
                            Else
                                errorRes = True
                                MessageBox.Show("No se puede dividir por 0")
                            End If
                    End Select

                    If errorRes Then
                        LabelResultado.Text = "No se pudo realizar la operacion"
                    Else
                        LabelResultado.Text = "El resultado de la operacion " & _tipoOper & " es de " & resultado
                    End If
                Else
                    MessageBox.Show("Favor de ingresar numeros")
                End If
            Else
                MessageBox.Show("Favor seleccionar un tipo de operacion")
            End If
        Else
            MessageBox.Show("Favor de ingresar los dos numeros")
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxNum1.Clear()
        TextBoxNum2.Clear()
        LabelResultado.Text = ""
    End Sub
End Class