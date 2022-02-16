<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnFact = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnPorcentaje = New System.Windows.Forms.Button()
        Me.btnTangente = New System.Windows.Forms.Button()
        Me.btnCoseno = New System.Windows.Forms.Button()
        Me.btnSeno = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNro1
        '
        Me.txtNro1.Location = New System.Drawing.Point(99, 149)
        Me.txtNro1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(72, 20)
        Me.txtNro1.TabIndex = 0
        '
        'txtNro2
        '
        Me.txtNro2.Location = New System.Drawing.Point(184, 149)
        Me.txtNro2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(76, 20)
        Me.txtNro2.TabIndex = 1
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSuma.Location = New System.Drawing.Point(117, 224)
        Me.btnSuma.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(76, 30)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnFact
        '
        Me.btnFact.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnFact.Location = New System.Drawing.Point(117, 258)
        Me.btnFact.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFact.Name = "btnFact"
        Me.btnFact.Size = New System.Drawing.Size(76, 32)
        Me.btnFact.TabIndex = 3
        Me.btnFact.Text = "Factorial"
        Me.btnFact.UseVisualStyleBackColor = False
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(275, 149)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(76, 20)
        Me.txtResultado.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Calculadora Con WEB SERVICE"
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.Color.DarkCyan
        Me.btnResta.Location = New System.Drawing.Point(117, 373)
        Me.btnResta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(76, 34)
        Me.btnResta.TabIndex = 6
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnMulti.Location = New System.Drawing.Point(117, 334)
        Me.btnMulti.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(76, 35)
        Me.btnMulti.TabIndex = 7
        Me.btnMulti.Text = "Multiplicar"
        Me.btnMulti.UseVisualStyleBackColor = False
        '
        'btnDiv
        '
        Me.btnDiv.BackColor = System.Drawing.Color.Turquoise
        Me.btnDiv.Location = New System.Drawing.Point(117, 294)
        Me.btnDiv.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(76, 36)
        Me.btnDiv.TabIndex = 8
        Me.btnDiv.Text = "Dividir"
        Me.btnDiv.UseVisualStyleBackColor = False
        '
        'btnPotencia
        '
        Me.btnPotencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPotencia.Location = New System.Drawing.Point(247, 224)
        Me.btnPotencia.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(79, 30)
        Me.btnPotencia.TabIndex = 9
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = False
        '
        'btnPorcentaje
        '
        Me.btnPorcentaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPorcentaje.Location = New System.Drawing.Point(247, 258)
        Me.btnPorcentaje.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPorcentaje.Name = "btnPorcentaje"
        Me.btnPorcentaje.Size = New System.Drawing.Size(79, 32)
        Me.btnPorcentaje.TabIndex = 10
        Me.btnPorcentaje.Text = "Porcentaje"
        Me.btnPorcentaje.UseVisualStyleBackColor = False
        '
        'btnTangente
        '
        Me.btnTangente.BackColor = System.Drawing.Color.Aqua
        Me.btnTangente.Location = New System.Drawing.Point(247, 295)
        Me.btnTangente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTangente.Name = "btnTangente"
        Me.btnTangente.Size = New System.Drawing.Size(79, 35)
        Me.btnTangente.TabIndex = 11
        Me.btnTangente.Text = "Tangente"
        Me.btnTangente.UseVisualStyleBackColor = False
        '
        'btnCoseno
        '
        Me.btnCoseno.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCoseno.Location = New System.Drawing.Point(247, 334)
        Me.btnCoseno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoseno.Name = "btnCoseno"
        Me.btnCoseno.Size = New System.Drawing.Size(79, 35)
        Me.btnCoseno.TabIndex = 12
        Me.btnCoseno.Text = "Coseno"
        Me.btnCoseno.UseVisualStyleBackColor = False
        '
        'btnSeno
        '
        Me.btnSeno.BackColor = System.Drawing.Color.Teal
        Me.btnSeno.Location = New System.Drawing.Point(247, 373)
        Me.btnSeno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSeno.Name = "btnSeno"
        Me.btnSeno.Size = New System.Drawing.Size(79, 34)
        Me.btnSeno.TabIndex = 13
        Me.btnSeno.Text = "Seno"
        Me.btnSeno.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.Location = New System.Drawing.Point(337, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Num 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Num 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Respuesta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Operaciones Basicas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(10, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 34)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Team University Boys"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(456, 438)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSeno)
        Me.Controls.Add(Me.btnCoseno)
        Me.Controls.Add(Me.btnTangente)
        Me.Controls.Add(Me.btnPorcentaje)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnFact)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnFact As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnTangente As Button
    Friend WithEvents btnCoseno As Button
    Friend WithEvents btnSeno As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
