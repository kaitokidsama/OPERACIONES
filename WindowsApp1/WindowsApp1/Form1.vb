Public Class Form1

    Dim selecionar As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbllado.Visible = False
        lblareacu.Visible = False
        lblpericu.Visible = False
        txtlado.Visible = False
        txtperimetrocu.Visible = False
        TxtAreaCuadradoo.Visible = False
        btncalcularcuadrado.Visible = False


        lblbase.Visible = False
        lblareatri.Visible = False
        lblperitri.Visible = False
        lblalturatri.Visible = False
        txtaltura.Visible = False
        BtnCalcularTriangulo.Visible = False
        txtbase.Visible = False
        txtperimetrotri.Visible = False
        txtareatri.Visible = False


        lblradio.Visible = False
        lblareaciur.Visible = False
        Btncalcularcirculo.Visible = False

        lblpericir.Visible = False
        txtperimetrocir.Visible = False
        txtareacirculo.Visible = False
        txtradio.Visible = False

    End Sub

    Private Sub btncuadrado_Click(sender As Object, e As EventArgs) Handles btncuadrado.Click
        Lbllado.Visible = True
        lblareacu.Visible = True
        lblpericu.Visible = True
        txtlado.Visible = True
        btncalcularcuadrado.Visible = True
        txtperimetrocu.Visible = True
        TxtAreaCuadradoo.Visible = True
        txtperimetrocu.Enabled = False
        TxtAreaCuadradoo.Enabled = False
        selecionar = "cuadrado"



    End Sub

    Private Sub btncalcularcuadrado_Click(sender As Object, e As EventArgs) Handles btncalcularcuadrado.Click
        Dim valor1, res, d As Double
        Dim resP, a As Double
        valor1 = CDbl(txtlado.Text)
        res = valor1 * valor1
        d = CStr(res)
        TxtAreaCuadradoo.Text = d

        resP = valor1 * 4
        a = CStr(resP)
        txtperimetrocu.Text = a
















    End Sub

    Private Sub btnnewcalcu_Click(sender As Object, e As EventArgs) Handles btnnewcalcu.Click

        Select Case (selecionar)
            Case "cuadrado"
                txtlado.Clear()
                TxtAreaCuadradoo.Clear()
                txtperimetrocu.Clear()

                Lbllado.Visible = False
                lblareacu.Visible = False
                lblpericu.Visible = False
                txtlado.Visible = False
                txtperimetrocu.Visible = False
                TxtAreaCuadradoo.Visible = False
                btncalcularcuadrado.Visible = False
            Case "triangulo"
                txtperimetrotri.Clear()
                txtareatri.Clear()
                txtbase.Clear()
                txtaltura.Clear()
                lblbase.Visible = False
                lblareatri.Visible = False
                lblperitri.Visible = False
                lblalturatri.Visible = False
                txtaltura.Visible = False
                BtnCalcularTriangulo.Visible = False
                txtbase.Visible = False
                txtperimetrotri.Visible = False
                txtareatri.Visible = False
            Case "circulo"
                txtradio.Clear()
                txtareacirculo.Clear()
                txtperimetrocir.Clear()
                lblradio.Visible = False
                lblareaciur.Visible = False
                Btncalcularcirculo.Visible = False
                lblpericir.Visible = False
                txtperimetrocir.Visible = False
                txtareacirculo.Visible = False
                txtradio.Visible = False

        End Select


    End Sub

    Private Sub btntriangulo_Click(sender As Object, e As EventArgs) Handles btntriangulo.Click
        lblbase.Visible = True
        lblareatri.Visible = True
        lblperitri.Visible = True
        lblalturatri.Visible = True
        BtnCalcularTriangulo.Visible = True
        txtaltura.Visible = True
        txtbase.Visible = True
        txtperimetrotri.Visible = True
        txtareatri.Visible = True
        txtperimetrotri.Enabled = False
        txtareatri.Enabled = False


        selecionar = "triangulo"


    End Sub

    Private Sub BtnCalcularTriangulo_Click(sender As Object, e As EventArgs) Handles BtnCalcularTriangulo.Click
        Dim ba, al, res, conver, res1, conver1 As Double

        ba = CDbl(txtbase.Text)
        al = CDbl(txtaltura.Text)
        res = (ba * al) / 2
        conver = CStr(res)
        txtareatri.Text = conver
        res1 = ba + al + al
        conver1 = CStr(res1)
        txtperimetrotri.Text = conver1




    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btncalcularcirculo_Click(sender As Object, e As EventArgs) Handles Btncalcularcirculo.Click
        Dim radio, conver2, res As Double
        Dim pi = 3.1416
        radio = CDbl(txtradio.Text)
        res = (radio * radio) * pi
        conver2 = CStr(res)
        txtareacirculo.Text = conver2
        Dim conver3, res1 As Double
        res1 = (radio * 2) * pi
        conver3 = CStr(res1)
        txtperimetrocir.Text = conver3

    End Sub

    Private Sub btncirculo_Click(sender As Object, e As EventArgs) Handles btncirculo.Click
        lblradio.Visible = True
        lblareaciur.Visible = True

        lblpericir.Visible = True
        txtperimetrocir.Visible = True
        txtareacirculo.Visible = True
        txtradio.Visible = True
        Btncalcularcirculo.Visible = True

        txtperimetrocir.Enabled = False
        txtareacirculo.Enabled = False
        selecionar = "circulo"

    End Sub
End Class
