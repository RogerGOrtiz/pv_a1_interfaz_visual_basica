﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5OperacionesBasicas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxTipoOp = New System.Windows.Forms.ComboBox()
        Me.ButtonMenuPrincipal = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTipoOp = New System.Windows.Forms.Label()
        Me.TextBoxNum1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNum2 = New System.Windows.Forms.TextBox()
        Me.LabelNum1 = New System.Windows.Forms.Label()
        Me.LabelNum2 = New System.Windows.Forms.Label()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        Me.BackColor = Color.LightGray
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Realizar el calculo de las cuatro operaciones aritméticas"
        Me.Label1.Font = New Font("Arial", 16, FontStyle.Bold)
        Me.Label1.ForeColor = Color.DarkBlue
        Me.Label1.Location = New Point((Me.ClientSize.Width - Me.Label1.Width) / 72, 40)
        '
        'ComboBoxTipoOp
        '
        Me.ComboBoxTipoOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoOp.FormattingEnabled = True
        Me.ComboBoxTipoOp.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division"})
        Me.ComboBoxTipoOp.Location = New System.Drawing.Point(359, 180)
        Me.ComboBoxTipoOp.Name = "ComboBoxTipoOp"
        Me.ComboBoxTipoOp.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxTipoOp.TabIndex = 1
        '
        'ButtonMenuPrincipal
        '
        Me.ButtonMenuPrincipal.Location = New System.Drawing.Point(338, 396)
        Me.ButtonMenuPrincipal.Name = "ButtonMenuPrincipal"
        Me.ButtonMenuPrincipal.Size = New System.Drawing.Size(124, 23)
        Me.ButtonMenuPrincipal.TabIndex = 2
        Me.ButtonMenuPrincipal.Text = "Menu principal"
        Me.ButtonMenuPrincipal.UseVisualStyleBackColor = True
        Me.ButtonMenuPrincipal.BackColor = Color.LightBlue
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(487, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'LabelTipoOp
        '
        Me.LabelTipoOp.AutoSize = True
        Me.LabelTipoOp.Location = New System.Drawing.Point(251, 183)
        Me.LabelTipoOp.Name = "LabelTipoOp"
        Me.LabelTipoOp.Size = New System.Drawing.Size(102, 15)
        Me.LabelTipoOp.TabIndex = 9
        Me.LabelTipoOp.Text = "Tipo de operacion"
        '
        'TextBoxNum1
        '
        Me.TextBoxNum1.Location = New System.Drawing.Point(253, 116)
        Me.TextBoxNum1.Name = "TextBoxNum1"
        Me.TextBoxNum1.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNum1.TabIndex = 10
        Me.TextBoxNum1.Font = New Font("Arial", 12, FontStyle.Regular)
        '
        'TextBoxNum2
        '
        Me.TextBoxNum2.Location = New System.Drawing.Point(427, 116)
        Me.TextBoxNum2.Name = "TextBoxNum2"
        Me.TextBoxNum2.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNum2.TabIndex = 11
        Me.TextBoxNum2.Font = New Font("Arial", 12, FontStyle.Regular)
        '
        'LabelNum1
        '
        Me.LabelNum1.AutoSize = True
        Me.LabelNum1.Location = New System.Drawing.Point(255, 87)
        Me.LabelNum1.Name = "LabelNum1"
        Me.LabelNum1.Size = New System.Drawing.Size(60, 15)
        Me.LabelNum1.TabIndex = 12
        Me.LabelNum1.Text = "Numero 1"
        '
        'LabelNum2
        '
        Me.LabelNum2.AutoSize = True
        Me.LabelNum2.Location = New System.Drawing.Point(427, 87)
        Me.LabelNum2.Name = "LabelNum2"
        Me.LabelNum2.Size = New System.Drawing.Size(60, 15)
        Me.LabelNum2.TabIndex = 13
        Me.LabelNum2.Text = "Numero 2"
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(412, 247)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 14
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        Me.ButtonCalcular.BackColor = Color.LightGreen
        Me.ButtonCalcular.ForeColor = Color.Black
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(548, 247)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(115, 23)
        Me.ButtonLimpiar.TabIndex = 15
        Me.ButtonLimpiar.Text = "Limpiar campos"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        Me.ButtonLimpiar.BackColor = Color.LightCoral
        Me.ButtonLimpiar.ForeColor = Color.Black
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Location = New System.Drawing.Point(359, 332)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(0, 15)
        Me.LabelResultado.TabIndex = 16
        Me.LabelResultado.Font = New Font("Arial", 12, FontStyle.Bold)
        Me.LabelResultado.ForeColor = Color.Black
        Me.LabelResultado.Location = New Point((Me.ClientSize.Width - Me.LabelResultado.Width) / 2, 332)
        '
        'Form5OperacionesBasicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.LabelNum2)
        Me.Controls.Add(Me.LabelNum1)
        Me.Controls.Add(Me.TextBoxNum2)
        Me.Controls.Add(Me.TextBoxNum1)
        Me.Controls.Add(Me.LabelTipoOp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonMenuPrincipal)
        Me.Controls.Add(Me.ComboBoxTipoOp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5OperacionesBasicas"
        Me.Text = "Form5OperacionesBasicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxTipoOp As ComboBox
    Friend WithEvents ButtonMenuPrincipal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTipoOp As Label
    Friend WithEvents TextBoxNum1 As TextBox
    Friend WithEvents TextBoxNum2 As TextBox
    Friend WithEvents LabelNum1 As Label
    Friend WithEvents LabelNum2 As Label
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents LabelResultado As Label
End Class
