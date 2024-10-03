<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2Promedio
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
        Me.ButtonMenuPrincipal = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.TextBoxNumEstudiantes = New System.Windows.Forms.TextBox()
        Me.LabelNumEstudiantes = New System.Windows.Forms.Label()
        Me.LabelNombMateria = New System.Windows.Forms.Label()
        Me.TextBoxNombMateria = New System.Windows.Forms.TextBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Me.BackColor = Color.LightGray
        '
        'ButtonMenuPrincipal
        '
        Me.ButtonMenuPrincipal.Location = New System.Drawing.Point(353, 396)
        Me.ButtonMenuPrincipal.Name = "ButtonMenuPrincipal"
        Me.ButtonMenuPrincipal.Size = New System.Drawing.Size(124, 23)
        Me.ButtonMenuPrincipal.TabIndex = 0
        Me.ButtonMenuPrincipal.Text = "Menu principal"
        Me.ButtonMenuPrincipal.UseVisualStyleBackColor = True
        Me.ButtonMenuPrincipal.BackColor = Color.LightBlue
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(316, 15)
        Me.LabelTitulo.TabIndex = 1
        Me.LabelTitulo.Text = "Calcular el promedio de un grupo para una misma materia"
        Me.LabelTitulo.Font = New Font("Arial", 12, FontStyle.Bold)
        Me.LabelTitulo.ForeColor = Color.DarkBlue
        Me.LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        Me.LabelTitulo.Location = New Point((Me.ClientSize.Width - Me.LabelTitulo.Width) / 52, 40)
        '
        'TextBoxNumEstudiantes
        '
        Me.TextBoxNumEstudiantes.Location = New System.Drawing.Point(257, 150)
        Me.TextBoxNumEstudiantes.Name = "TextBoxNumEstudiantes"
        Me.TextBoxNumEstudiantes.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxNumEstudiantes.TabIndex = 2
        '
        'LabelNumEstudiantes
        '
        Me.LabelNumEstudiantes.AutoSize = True
        Me.LabelNumEstudiantes.Location = New System.Drawing.Point(118, 158)
        Me.LabelNumEstudiantes.Name = "LabelNumEstudiantes"
        Me.LabelNumEstudiantes.Size = New System.Drawing.Size(133, 15)
        Me.LabelNumEstudiantes.TabIndex = 3
        Me.LabelNumEstudiantes.Text = "Numero de estudiantes:"
        '
        'LabelNombMateria
        '
        Me.LabelNombMateria.AutoSize = True
        Me.LabelNombMateria.Location = New System.Drawing.Point(118, 113)
        Me.LabelNombMateria.Name = "LabelNombMateria"
        Me.LabelNombMateria.Size = New System.Drawing.Size(125, 15)
        Me.LabelNombMateria.TabIndex = 4
        Me.LabelNombMateria.Text = "Nombre de la materia:"
        '
        'TextBoxNombMateria
        '
        Me.TextBoxNombMateria.Location = New System.Drawing.Point(257, 105)
        Me.TextBoxNombMateria.Name = "TextBoxNombMateria"
        Me.TextBoxNombMateria.Size = New System.Drawing.Size(293, 23)
        Me.TextBoxNombMateria.TabIndex = 5
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(475, 188)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 6
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        Me.ButtonCalcular.BackColor = Color.LightGreen
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Font = New Font("Arial", 12, FontStyle.Bold)
        Me.LabelResultado.ForeColor = Color.Black
        Me.LabelResultado.Location = New Point(237, 240)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(0, 15)
        Me.LabelResultado.TabIndex = 8
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(575, 188)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(116, 23)
        Me.ButtonLimpiar.TabIndex = 9
        Me.ButtonLimpiar.Text = "Limpiar Campos"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        Me.ButtonLimpiar.BackColor = Color.LightCoral
        '
        'Form2Promedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBoxNombMateria)
        Me.Controls.Add(Me.LabelNombMateria)
        Me.Controls.Add(Me.LabelNumEstudiantes)
        Me.Controls.Add(Me.TextBoxNumEstudiantes)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.ButtonMenuPrincipal)
        Me.Name = "Form2Promedio"
        Me.Text = "Form2Promedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonMenuPrincipal As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents TextBoxNumEstudiantes As TextBox
    Friend WithEvents LabelNumEstudiantes As Label
    Friend WithEvents LabelNombMateria As Label
    Friend WithEvents TextBoxNombMateria As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents ButtonLimpiar As Button
End Class
