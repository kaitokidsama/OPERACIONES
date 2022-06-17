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
        Me.Lbllado = New System.Windows.Forms.Label()
        Me.txtlado = New System.Windows.Forms.TextBox()
        Me.btncuadrado = New System.Windows.Forms.Button()
        Me.btncirculo = New System.Windows.Forms.Button()
        Me.btntriangulo = New System.Windows.Forms.Button()
        Me.lblareacu = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblpericu = New System.Windows.Forms.Label()
        Me.txtperimetrocu = New System.Windows.Forms.TextBox()
        Me.lblradio = New System.Windows.Forms.Label()
        Me.txtradio = New System.Windows.Forms.TextBox()
        Me.btnnewcalcu = New System.Windows.Forms.Button()
        Me.lblareaciur = New System.Windows.Forms.Label()
        Me.txtareacirculo = New System.Windows.Forms.TextBox()
        Me.lblpericir = New System.Windows.Forms.Label()
        Me.txtperimetrocir = New System.Windows.Forms.TextBox()
        Me.lblbase = New System.Windows.Forms.Label()
        Me.txtbase = New System.Windows.Forms.TextBox()
        Me.lblalturatri = New System.Windows.Forms.Label()
        Me.txtaltura = New System.Windows.Forms.TextBox()
        Me.lblareatri = New System.Windows.Forms.Label()
        Me.txtareatri = New System.Windows.Forms.TextBox()
        Me.lblperitri = New System.Windows.Forms.Label()
        Me.txtperimetrotri = New System.Windows.Forms.TextBox()
        Me.btncalcularcuadrado = New System.Windows.Forms.Button()
        Me.TxtAreaCuadradoo = New System.Windows.Forms.TextBox()
        Me.BtnCalcularTriangulo = New System.Windows.Forms.Button()
        Me.Btncalcularcirculo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbllado
        '
        Me.Lbllado.AutoSize = True
        Me.Lbllado.Location = New System.Drawing.Point(242, 62)
        Me.Lbllado.Name = "Lbllado"
        Me.Lbllado.Size = New System.Drawing.Size(31, 13)
        Me.Lbllado.TabIndex = 0
        Me.Lbllado.Text = "Lado"
        '
        'txtlado
        '
        Me.txtlado.Location = New System.Drawing.Point(305, 59)
        Me.txtlado.Name = "txtlado"
        Me.txtlado.Size = New System.Drawing.Size(100, 20)
        Me.txtlado.TabIndex = 1
        '
        'btncuadrado
        '
        Me.btncuadrado.Location = New System.Drawing.Point(95, 62)
        Me.btncuadrado.Name = "btncuadrado"
        Me.btncuadrado.Size = New System.Drawing.Size(75, 23)
        Me.btncuadrado.TabIndex = 2
        Me.btncuadrado.Text = "Cuadrado"
        Me.btncuadrado.UseVisualStyleBackColor = True
        '
        'btncirculo
        '
        Me.btncirculo.Location = New System.Drawing.Point(95, 131)
        Me.btncirculo.Name = "btncirculo"
        Me.btncirculo.Size = New System.Drawing.Size(75, 23)
        Me.btncirculo.TabIndex = 3
        Me.btncirculo.Text = "Circulo"
        Me.btncirculo.UseVisualStyleBackColor = True
        '
        'btntriangulo
        '
        Me.btntriangulo.Location = New System.Drawing.Point(95, 193)
        Me.btntriangulo.Name = "btntriangulo"
        Me.btntriangulo.Size = New System.Drawing.Size(75, 23)
        Me.btntriangulo.TabIndex = 4
        Me.btntriangulo.Text = "Triangulo"
        Me.btntriangulo.UseVisualStyleBackColor = True
        '
        'lblareacu
        '
        Me.lblareacu.AutoSize = True
        Me.lblareacu.Location = New System.Drawing.Point(446, 59)
        Me.lblareacu.Name = "lblareacu"
        Me.lblareacu.Size = New System.Drawing.Size(29, 13)
        Me.lblareacu.TabIndex = 5
        Me.lblareacu.Text = "Area"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(595, 361)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Cerrar"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblpericu
        '
        Me.lblpericu.AutoSize = True
        Me.lblpericu.Location = New System.Drawing.Point(649, 59)
        Me.lblpericu.Name = "lblpericu"
        Me.lblpericu.Size = New System.Drawing.Size(51, 13)
        Me.lblpericu.TabIndex = 8
        Me.lblpericu.Text = "Perimetro"
        '
        'txtperimetrocu
        '
        Me.txtperimetrocu.Location = New System.Drawing.Point(714, 55)
        Me.txtperimetrocu.Name = "txtperimetrocu"
        Me.txtperimetrocu.Size = New System.Drawing.Size(100, 20)
        Me.txtperimetrocu.TabIndex = 9
        '
        'lblradio
        '
        Me.lblradio.AutoSize = True
        Me.lblradio.Location = New System.Drawing.Point(242, 134)
        Me.lblradio.Name = "lblradio"
        Me.lblradio.Size = New System.Drawing.Size(35, 13)
        Me.lblradio.TabIndex = 10
        Me.lblradio.Text = "Radio"
        '
        'txtradio
        '
        Me.txtradio.Location = New System.Drawing.Point(305, 134)
        Me.txtradio.Name = "txtradio"
        Me.txtradio.Size = New System.Drawing.Size(100, 20)
        Me.txtradio.TabIndex = 11
        '
        'btnnewcalcu
        '
        Me.btnnewcalcu.Location = New System.Drawing.Point(122, 361)
        Me.btnnewcalcu.Name = "btnnewcalcu"
        Me.btnnewcalcu.Size = New System.Drawing.Size(191, 23)
        Me.btnnewcalcu.TabIndex = 13
        Me.btnnewcalcu.Text = "Nuevo calculo"
        Me.btnnewcalcu.UseVisualStyleBackColor = True
        '
        'lblareaciur
        '
        Me.lblareaciur.AutoSize = True
        Me.lblareaciur.Location = New System.Drawing.Point(436, 136)
        Me.lblareaciur.Name = "lblareaciur"
        Me.lblareaciur.Size = New System.Drawing.Size(29, 13)
        Me.lblareaciur.TabIndex = 15
        Me.lblareaciur.Text = "Area"
        '
        'txtareacirculo
        '
        Me.txtareacirculo.Location = New System.Drawing.Point(491, 134)
        Me.txtareacirculo.Name = "txtareacirculo"
        Me.txtareacirculo.Size = New System.Drawing.Size(100, 20)
        Me.txtareacirculo.TabIndex = 16
        '
        'lblpericir
        '
        Me.lblpericir.AutoSize = True
        Me.lblpericir.Location = New System.Drawing.Point(649, 136)
        Me.lblpericir.Name = "lblpericir"
        Me.lblpericir.Size = New System.Drawing.Size(51, 13)
        Me.lblpericir.TabIndex = 17
        Me.lblpericir.Text = "Perimetro"
        '
        'txtperimetrocir
        '
        Me.txtperimetrocir.Location = New System.Drawing.Point(714, 133)
        Me.txtperimetrocir.Name = "txtperimetrocir"
        Me.txtperimetrocir.Size = New System.Drawing.Size(100, 20)
        Me.txtperimetrocir.TabIndex = 18
        '
        'lblbase
        '
        Me.lblbase.AutoSize = True
        Me.lblbase.Location = New System.Drawing.Point(242, 203)
        Me.lblbase.Name = "lblbase"
        Me.lblbase.Size = New System.Drawing.Size(31, 13)
        Me.lblbase.TabIndex = 19
        Me.lblbase.Text = "Base"
        '
        'txtbase
        '
        Me.txtbase.Location = New System.Drawing.Point(305, 203)
        Me.txtbase.Name = "txtbase"
        Me.txtbase.Size = New System.Drawing.Size(100, 20)
        Me.txtbase.TabIndex = 20
        '
        'lblalturatri
        '
        Me.lblalturatri.AutoSize = True
        Me.lblalturatri.Location = New System.Drawing.Point(439, 209)
        Me.lblalturatri.Name = "lblalturatri"
        Me.lblalturatri.Size = New System.Drawing.Size(34, 13)
        Me.lblalturatri.TabIndex = 21
        Me.lblalturatri.Text = "Altura"
        '
        'txtaltura
        '
        Me.txtaltura.Location = New System.Drawing.Point(491, 209)
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(100, 20)
        Me.txtaltura.TabIndex = 22
        '
        'lblareatri
        '
        Me.lblareatri.AutoSize = True
        Me.lblareatri.Location = New System.Drawing.Point(652, 209)
        Me.lblareatri.Name = "lblareatri"
        Me.lblareatri.Size = New System.Drawing.Size(29, 13)
        Me.lblareatri.TabIndex = 23
        Me.lblareatri.Text = "Area"
        '
        'txtareatri
        '
        Me.txtareatri.Location = New System.Drawing.Point(714, 208)
        Me.txtareatri.Name = "txtareatri"
        Me.txtareatri.Size = New System.Drawing.Size(100, 20)
        Me.txtareatri.TabIndex = 24
        '
        'lblperitri
        '
        Me.lblperitri.AutoSize = True
        Me.lblperitri.Location = New System.Drawing.Point(652, 267)
        Me.lblperitri.Name = "lblperitri"
        Me.lblperitri.Size = New System.Drawing.Size(51, 13)
        Me.lblperitri.TabIndex = 25
        Me.lblperitri.Text = "Perimetro"
        '
        'txtperimetrotri
        '
        Me.txtperimetrotri.Location = New System.Drawing.Point(714, 267)
        Me.txtperimetrotri.Name = "txtperimetrotri"
        Me.txtperimetrotri.Size = New System.Drawing.Size(100, 20)
        Me.txtperimetrotri.TabIndex = 26
        '
        'btncalcularcuadrado
        '
        Me.btncalcularcuadrado.Location = New System.Drawing.Point(838, 55)
        Me.btncalcularcuadrado.Name = "btncalcularcuadrado"
        Me.btncalcularcuadrado.Size = New System.Drawing.Size(75, 23)
        Me.btncalcularcuadrado.TabIndex = 27
        Me.btncalcularcuadrado.Text = "calcular"
        Me.btncalcularcuadrado.UseVisualStyleBackColor = True
        '
        'TxtAreaCuadradoo
        '
        Me.TxtAreaCuadradoo.Location = New System.Drawing.Point(482, 54)
        Me.TxtAreaCuadradoo.Name = "TxtAreaCuadradoo"
        Me.TxtAreaCuadradoo.Size = New System.Drawing.Size(100, 20)
        Me.TxtAreaCuadradoo.TabIndex = 28
        '
        'BtnCalcularTriangulo
        '
        Me.BtnCalcularTriangulo.Location = New System.Drawing.Point(838, 209)
        Me.BtnCalcularTriangulo.Name = "BtnCalcularTriangulo"
        Me.BtnCalcularTriangulo.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcularTriangulo.TabIndex = 29
        Me.BtnCalcularTriangulo.Text = "Calcular"
        Me.BtnCalcularTriangulo.UseVisualStyleBackColor = True
        '
        'Btncalcularcirculo
        '
        Me.Btncalcularcirculo.Location = New System.Drawing.Point(838, 130)
        Me.Btncalcularcirculo.Name = "Btncalcularcirculo"
        Me.Btncalcularcirculo.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcularcirculo.TabIndex = 30
        Me.Btncalcularcirculo.Text = "Calcular"
        Me.Btncalcularcirculo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 452)
        Me.Controls.Add(Me.Btncalcularcirculo)
        Me.Controls.Add(Me.BtnCalcularTriangulo)
        Me.Controls.Add(Me.TxtAreaCuadradoo)
        Me.Controls.Add(Me.btncalcularcuadrado)
        Me.Controls.Add(Me.txtperimetrotri)
        Me.Controls.Add(Me.lblperitri)
        Me.Controls.Add(Me.txtareatri)
        Me.Controls.Add(Me.lblareatri)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.lblalturatri)
        Me.Controls.Add(Me.txtbase)
        Me.Controls.Add(Me.lblbase)
        Me.Controls.Add(Me.txtperimetrocir)
        Me.Controls.Add(Me.lblpericir)
        Me.Controls.Add(Me.txtareacirculo)
        Me.Controls.Add(Me.lblareaciur)
        Me.Controls.Add(Me.btnnewcalcu)
        Me.Controls.Add(Me.txtradio)
        Me.Controls.Add(Me.lblradio)
        Me.Controls.Add(Me.txtperimetrocu)
        Me.Controls.Add(Me.lblpericu)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblareacu)
        Me.Controls.Add(Me.btntriangulo)
        Me.Controls.Add(Me.btncirculo)
        Me.Controls.Add(Me.btncuadrado)
        Me.Controls.Add(Me.txtlado)
        Me.Controls.Add(Me.Lbllado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbllado As Label
    Friend WithEvents txtlado As TextBox
    Friend WithEvents btncuadrado As Button
    Friend WithEvents btncirculo As Button
    Friend WithEvents btntriangulo As Button
    Friend WithEvents lblareacu As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents lblpericu As Label
    Friend WithEvents txtperimetrocu As TextBox
    Friend WithEvents lblradio As Label
    Friend WithEvents txtradio As TextBox
    Friend WithEvents btnnewcalcu As Button
    Friend WithEvents lblareaciur As Label
    Friend WithEvents txtareacirculo As TextBox
    Friend WithEvents lblpericir As Label
    Friend WithEvents txtperimetrocir As TextBox
    Friend WithEvents lblbase As Label
    Friend WithEvents txtbase As TextBox
    Friend WithEvents lblalturatri As Label
    Friend WithEvents txtaltura As TextBox
    Friend WithEvents lblareatri As Label
    Friend WithEvents txtareatri As TextBox
    Friend WithEvents lblperitri As Label
    Friend WithEvents txtperimetrotri As TextBox
    Friend WithEvents btncalcularcuadrado As Button
    Friend WithEvents TxtAreaCuadradoo As TextBox
    Friend WithEvents BtnCalcularTriangulo As Button
    Friend WithEvents Btncalcularcirculo As Button
End Class
