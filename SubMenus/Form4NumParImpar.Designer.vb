<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4NumParImpar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.TextBoxNumero = New System.Windows.Forms.TextBox()
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
        Me.LabelTitulo.Location = New System.Drawing.Point(304, 41)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(201, 15)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "Calcular si un numero es par o impar"
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.Location = New System.Drawing.Point(277, 113)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(54, 15)
        Me.LabelNumero.TabIndex = 1
        Me.LabelNumero.Text = "Numero:"
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(337, 105)
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(128, 23)
        Me.TextBoxNumero.TabIndex = 2
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(390, 176)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 3
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(486, 176)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLimpiar.TabIndex = 4
        Me.ButtonLimpiar.Text = "Limpiar campo"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'ButtonMenuPrincipal
        '
        Me.ButtonMenuPrincipal.Location = New System.Drawing.Point(341, 401)
        Me.ButtonMenuPrincipal.Name = "ButtonMenuPrincipal"
        Me.ButtonMenuPrincipal.Size = New System.Drawing.Size(124, 23)
        Me.ButtonMenuPrincipal.TabIndex = 9
        Me.ButtonMenuPrincipal.Text = "Menu principal"
        Me.ButtonMenuPrincipal.UseVisualStyleBackColor = True
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Location = New System.Drawing.Point(391, 297)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(10, 15)
        Me.LabelResultado.TabIndex = 10
        Me.LabelResultado.Text = "l"
        '
        'Form4NumParImpar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.ButtonMenuPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBoxNumero)
        Me.Controls.Add(Me.LabelNumero)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "Form4NumParImpar"
        Me.Text = "Form4NumParImpar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabelNumero As Label
    Friend WithEvents TextBoxNumero As TextBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonMenuPrincipal As Button
    Friend WithEvents LabelResultado As Label
End Class
