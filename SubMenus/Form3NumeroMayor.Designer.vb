<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3NumeroMayor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelLista = New System.Windows.Forms.Label()
        Me.LabelNota = New System.Windows.Forms.Label()
        Me.TextBoxLista = New System.Windows.Forms.TextBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonMenuPrincipal = New System.Windows.Forms.Button()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTitulo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelTitulo.Location = New System.Drawing.Point(50, 25)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(390, 19)
        Me.LabelTitulo.TabIndex = 2
        Me.LabelTitulo.Text = "Calcular el número mayor de una lista de numeros"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelLista
        '
        Me.LabelLista.AutoSize = True
        Me.LabelLista.Location = New System.Drawing.Point(187, 130)
        Me.LabelLista.Name = "LabelLista"
        Me.LabelLista.Size = New System.Drawing.Size(151, 15)
        Me.LabelLista.TabIndex = 3
        Me.LabelLista.Text = "Ingresar la lista de numeros"
        '
        'LabelNota
        '
        Me.LabelNota.AutoSize = True
        Me.LabelNota.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.LabelNota.ForeColor = System.Drawing.Color.Gray
        Me.LabelNota.Location = New System.Drawing.Point(187, 94)
        Me.LabelNota.Name = "LabelNota"
        Me.LabelNota.Size = New System.Drawing.Size(388, 16)
        Me.LabelNota.TabIndex = 4
        Me.LabelNota.Text = "NOTA: Ingresar la lista de numeros separados por comas "","""
        '
        'TextBoxLista
        '
        Me.TextBoxLista.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxLista.Location = New System.Drawing.Point(353, 122)
        Me.TextBoxLista.Name = "TextBoxLista"
        Me.TextBoxLista.Size = New System.Drawing.Size(283, 23)
        Me.TextBoxLista.TabIndex = 5
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonCalcular.Location = New System.Drawing.Point(414, 187)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 6
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonLimpiar.Location = New System.Drawing.Point(518, 187)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(106, 23)
        Me.ButtonLimpiar.TabIndex = 7
        Me.ButtonLimpiar.Text = "Limpiar campos"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'ButtonMenuPrincipal
        '
        Me.ButtonMenuPrincipal.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonMenuPrincipal.Location = New System.Drawing.Point(335, 403)
        Me.ButtonMenuPrincipal.Name = "ButtonMenuPrincipal"
        Me.ButtonMenuPrincipal.Size = New System.Drawing.Size(124, 23)
        Me.ButtonMenuPrincipal.TabIndex = 9
        Me.ButtonMenuPrincipal.Text = "Menu principal"
        Me.ButtonMenuPrincipal.UseVisualStyleBackColor = False
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelResultado.ForeColor = System.Drawing.Color.Black
        Me.LabelResultado.Location = New System.Drawing.Point(237, 240)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(0, 19)
        Me.LabelResultado.TabIndex = 10
        '
        'Form3NumeroMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.ButtonMenuPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBoxLista)
        Me.Controls.Add(Me.LabelNota)
        Me.Controls.Add(Me.LabelLista)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "Form3NumeroMayor"
        Me.Text = "Form3NumeroMayor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelLista As Label
    Friend WithEvents LabelNota As Label
    Friend WithEvents TextBoxLista As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonMenuPrincipal As Button
    Friend WithEvents LabelResultado As Label
End Class
