<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6Ponderacion
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
        Me.LabelEx1 = New System.Windows.Forms.Label()
        Me.LabelEx2 = New System.Windows.Forms.Label()
        Me.LabelTarea = New System.Windows.Forms.Label()
        Me.LabelExpoClase = New System.Windows.Forms.Label()
        Me.TextBoxExa1 = New System.Windows.Forms.TextBox()
        Me.TextBoxTarea = New System.Windows.Forms.TextBox()
        Me.TextBoxExpo = New System.Windows.Forms.TextBox()
        Me.TextBoxExa2 = New System.Windows.Forms.TextBox()
        Me.LabelPorcentaje = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonMenuPrincipal = New System.Windows.Forms.Button()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        Me.BackColor = Color.LightGray
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Location = New Point((Me.ClientSize.Width - Me.LabelTitulo.Width) / 2, 40)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(284, 15)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "Calcular calificación final en base a una ponderación"
        Me.LabelTitulo.Font = New Font("Arial", 12, FontStyle.Bold)
        Me.LabelTitulo.ForeColor = Color.DarkSlateBlue
        '
        'LabelEx1
        '
        Me.LabelEx1.AutoSize = True
        Me.LabelEx1.Location = New System.Drawing.Point(163, 95)
        Me.LabelEx1.Name = "LabelEx1"
        Me.LabelEx1.Size = New System.Drawing.Size(91, 15)
        Me.LabelEx1.TabIndex = 1
        Me.LabelEx1.Text = "Examen 1 - 25%"
        '
        'LabelEx2
        '
        Me.LabelEx2.AutoSize = True
        Me.LabelEx2.Location = New System.Drawing.Point(385, 95)
        Me.LabelEx2.Name = "LabelEx2"
        Me.LabelEx2.Size = New System.Drawing.Size(91, 15)
        Me.LabelEx2.TabIndex = 2
        Me.LabelEx2.Text = "Examen 2 - 35%"
        '
        'LabelTarea
        '
        Me.LabelTarea.AutoSize = True
        Me.LabelTarea.Location = New System.Drawing.Point(163, 163)
        Me.LabelTarea.Name = "LabelTarea"
        Me.LabelTarea.Size = New System.Drawing.Size(72, 15)
        Me.LabelTarea.TabIndex = 3
        Me.LabelTarea.Text = "Tareas - 15%"
        '
        'LabelExpoClase
        '
        Me.LabelExpoClase.AutoSize = True
        Me.LabelExpoClase.Location = New System.Drawing.Point(385, 163)
        Me.LabelExpoClase.Name = "LabelExpoClase"
        Me.LabelExpoClase.Size = New System.Drawing.Size(142, 15)
        Me.LabelExpoClase.TabIndex = 4
        Me.LabelExpoClase.Text = "Exposición de clase - 25%"
        '
        'TextBoxExa1
        '
        Me.TextBoxExa1.Location = New System.Drawing.Point(260, 92)
        Me.TextBoxExa1.Name = "TextBoxExa1"
        Me.TextBoxExa1.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxExa1.TabIndex = 5
        '
        'TextBoxTarea
        '
        Me.TextBoxTarea.Location = New System.Drawing.Point(260, 155)
        Me.TextBoxTarea.Name = "TextBoxTarea"
        Me.TextBoxTarea.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxTarea.TabIndex = 6
        '
        'TextBoxExpo
        '
        Me.TextBoxExpo.Location = New System.Drawing.Point(533, 158)
        Me.TextBoxExpo.Name = "TextBoxExpo"
        Me.TextBoxExpo.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxExpo.TabIndex = 7
        '
        'TextBoxExa2
        '
        Me.TextBoxExa2.Location = New System.Drawing.Point(482, 92)
        Me.TextBoxExa2.Name = "TextBoxExa2"
        Me.TextBoxExa2.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxExa2.TabIndex = 8
        '
        'LabelPorcentaje
        '
        Me.LabelPorcentaje.AutoSize = True
        Me.LabelPorcentaje.Location = New System.Drawing.Point(206, 128)
        Me.LabelPorcentaje.Name = "LabelPorcentaje"
        Me.LabelPorcentaje.Size = New System.Drawing.Size(0, 15)
        Me.LabelPorcentaje.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(536, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(699, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(487, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'ButtonMenuPrincipal
        '
        Me.ButtonMenuPrincipal.Location = New System.Drawing.Point(337, 415)
        Me.ButtonMenuPrincipal.Name = "ButtonMenuPrincipal"
        Me.ButtonMenuPrincipal.Size = New System.Drawing.Size(124, 23)
        Me.ButtonMenuPrincipal.TabIndex = 14
        Me.ButtonMenuPrincipal.Text = "Menu principal"
        Me.ButtonMenuPrincipal.UseVisualStyleBackColor = True
        Me.ButtonMenuPrincipal.BackColor = Color.LightGreen
        Me.ButtonMenuPrincipal.ForeColor = Color.Black
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(360, 253)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 15
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        Me.ButtonCalcular.BackColor = Color.LightBlue
        Me.ButtonCalcular.ForeColor = Color.Black
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(507, 253)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLimpiar.TabIndex = 16
        Me.ButtonLimpiar.Text = "LimpiarCampos"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        Me.ButtonLimpiar.BackColor = Color.LightCoral
        Me.ButtonLimpiar.ForeColor = Color.Black
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(0, 15)
        Me.LabelResultado.TabIndex = 17
        Me.LabelResultado.Font = New Font("Arial", 12, FontStyle.Bold)
        Me.LabelResultado.ForeColor = Color.Black
        Me.LabelResultado.Location = New Point((Me.ClientSize.Width - Me.LabelResultado.Width) / 2, 297)
        '
        'Form6Ponderacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.ButtonMenuPrincipal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPorcentaje)
        Me.Controls.Add(Me.TextBoxExa2)
        Me.Controls.Add(Me.TextBoxExpo)
        Me.Controls.Add(Me.TextBoxTarea)
        Me.Controls.Add(Me.TextBoxExa1)
        Me.Controls.Add(Me.LabelExpoClase)
        Me.Controls.Add(Me.LabelTarea)
        Me.Controls.Add(Me.LabelEx2)
        Me.Controls.Add(Me.LabelEx1)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "Form6Ponderacion"
        Me.Text = "Form6Ponderacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelEx1 As Label
    Friend WithEvents LabelEx2 As Label
    Friend WithEvents LabelTarea As Label
    Friend WithEvents LabelExpoClase As Label
    Friend WithEvents TextBoxExa1 As TextBox
    Friend WithEvents TextBoxTarea As TextBox
    Friend WithEvents TextBoxExpo As TextBox
    Friend WithEvents TextBoxExa2 As TextBox
    Friend WithEvents LabelPorcentaje As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonMenuPrincipal As Button
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents LabelResultado As Label
End Class
