Imports System.Buffers

Public Class Form3NumeroMayor
    Private _listNums As String = ""

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        _listNums = TextBoxLista.Text
        Dim numero As Double
        Dim valorSinEspacios As String
        Dim numMayor As Double
        Dim listaNumeros As New List(Of Double)
        Dim errorNum As Boolean = False

        If Not String.IsNullOrEmpty(_listNums) AndAlso
            Not String.IsNullOrWhiteSpace(_listNums) Then

            Dim valoresArray() As String = _listNums.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)

            For Each valor As String In valoresArray
                valorSinEspacios = valor.Trim().Replace(" ", "")

                If Double.TryParse(valorSinEspacios, numero) Then
                    listaNumeros.Add(numero)
                Else
                    errorNum = True
                    MessageBox.Show("El valor '" & valor & "' no es un número válido.")
                    Exit For
                End If
            Next

            If errorNum Then
                LabelResultado.Text = "No se pudo calcular el numero mayor"
            Else
                numMayor = listaNumeros.Max
                LabelResultado.Text = "El numero mayor es " & numMayor
            End If
        Else
            MessageBox.Show("Favor de ingresar la lista de numeros")
        End If
    End Sub

    Private Sub ButtonMenuPrincipal_Click(sender As Object, e As EventArgs) Handles ButtonMenuPrincipal.Click
        'Oculatamos el formulario de numMayor
        Me.Hide()
        'Nos redirigimos al formulario principal
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxLista.Clear()
        LabelResultado.Text = ""
    End Sub
End Class