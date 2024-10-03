<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.labelProbs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckedListMenu = New System.Windows.Forms.CheckedListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonContinuar = New System.Windows.Forms.Button()
        Me.ButtonTerminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTitulo
        '
        Me.labelTitulo.AutoSize = True
        Me.labelTitulo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.labelTitulo.Location = New System.Drawing.Point(158, 43)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(457, 22)
        Me.labelTitulo.TabIndex = 0
        Me.labelTitulo.Text = "ACTIVIDAD 1 - INTERFACES VISUALES BASICAS"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelProbs
        '
        Me.labelProbs.AutoSize = True
        Me.labelProbs.Location = New System.Drawing.Point(94, 117)
        Me.labelProbs.Name = "labelProbs"
        Me.labelProbs.Size = New System.Drawing.Size(126, 15)
        Me.labelProbs.TabIndex = 1
        Me.labelProbs.Text = "Selecciona una opcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 4
        '
        'CheckedListMenu
        '
        Me.CheckedListMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListMenu.FormattingEnabled = True
        Me.CheckedListMenu.Items.AddRange(New Object() {"Calcular el promedio de un grupo para una misma materia.", "Calcular el numero mayor de una lista de números.", "Calcular si un numero es par o impar.", "Realizar el calculo de las cuatro operaciones aritméticas.", "Calcular calificación final en base a una ponderación."})
        Me.CheckedListMenu.Location = New System.Drawing.Point(94, 145)
        Me.CheckedListMenu.Name = "CheckedListMenu"
        Me.CheckedListMenu.Size = New System.Drawing.Size(603, 92)
        Me.CheckedListMenu.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"lista", "lista1", "lista2"})
        Me.ListBox1.Location = New System.Drawing.Point(212, 303)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(0, 4)
        Me.ListBox1.TabIndex = 6
        '
        'ButtonContinuar
        '
        Me.ButtonContinuar.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonContinuar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonContinuar.ForeColor = System.Drawing.Color.Black
        Me.ButtonContinuar.Location = New System.Drawing.Point(253, 368)
        Me.ButtonContinuar.Name = "ButtonContinuar"
        Me.ButtonContinuar.Size = New System.Drawing.Size(105, 33)
        Me.ButtonContinuar.TabIndex = 7
        Me.ButtonContinuar.Text = "Continuar"
        Me.ButtonContinuar.UseVisualStyleBackColor = False
        '
        'ButtonTerminar
        '
        Me.ButtonTerminar.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonTerminar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTerminar.ForeColor = System.Drawing.Color.Black
        Me.ButtonTerminar.Location = New System.Drawing.Point(468, 368)
        Me.ButtonTerminar.Name = "ButtonTerminar"
        Me.ButtonTerminar.Size = New System.Drawing.Size(105, 33)
        Me.ButtonTerminar.TabIndex = 8
        Me.ButtonTerminar.Text = "Terminar"
        Me.ButtonTerminar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonTerminar)
        Me.Controls.Add(Me.ButtonContinuar)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckedListMenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelProbs)
        Me.Controls.Add(Me.labelTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTitulo As Label
    Friend WithEvents labelProbs As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckedListMenu As CheckedListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonContinuar As Button
    Friend WithEvents ButtonTerminar As Button
End Class
