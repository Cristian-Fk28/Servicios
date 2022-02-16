Public Class Form1
    'llamar al servicio web
    Dim servicio As New ServiceReference1.CalculadoraSoapClient

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        'sumar los numeros utilizando el servicio web
        Dim nro1, nro2 As Double
        nro1 = txtNro1.Text
        nro2 = Double.Parse(txtNro2.Text)
        Dim Suma As Double = servicio.Suma(nro1, nro2)
        txtResultado.Text = Suma.ToString

    End Sub

    Private Sub btnFact_Click(sender As Object, e As EventArgs) Handles btnFact.Click
        'restar los numeros utilizando el servicio web
        Dim nro1 As Double
        nro1 = txtNro1.Text
        Dim Factorial As Double = servicio.Factorial(nro1)
        txtResultado.Text = Factorial.ToString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        'restar los numeros utilizando el servicio web
        Dim nro1, nro2 As Double
        nro1 = txtNro1.Text
        nro2 = Double.Parse(txtNro2.Text)
        Dim Multiplicar As Double = servicio.Mult(nro1, nro2)
        txtResultado.Text = Multiplicar.ToString
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        'restar los numeros utilizando el servicio web
        Dim nro1, nro2 As Double
        nro1 = txtNro1.Text
        nro2 = Double.Parse(txtNro2.Text)
        Dim Resta As Double = servicio.Resta(nro1, nro2)
        txtResultado.Text = Resta.ToString
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        'restar los numeros utilizando el servicio web
        Dim nro1, nro2 As Double
        nro1 = txtNro1.Text
        nro2 = Double.Parse(txtNro2.Text)
        Dim Potencia As Double = servicio.Potencia(nro1, nro2)
        txtResultado.Text = Potencia.ToString

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtNro1.Text = ("")
        txtNro2.Text = ("")
        txtResultado.Text = ("")
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        'restar los numeros utilizando el servicio web
        Dim nro1 As Double
        nro1 = txtNro1.Text
        Dim Porcentaje As Double = servicio.Porcentaje(nro1)
        txtResultado.Text = Porcentaje.ToString
    End Sub

    Private Sub btnTangente_Click(sender As Object, e As EventArgs) Handles btnTangente.Click
        'restar los numeros utilizando el servicio web
        Dim nro1 As Double
        nro1 = txtNro1.Text
        Dim Tangente As Double = servicio.Tangente(nro1)
        txtResultado.Text = Tangente.ToString
    End Sub

    Private Sub btnCoseno_Click(sender As Object, e As EventArgs) Handles btnCoseno.Click
        'restar los numeros utilizando el servicio web
        Dim nro1 As Double
        nro1 = txtNro1.Text
        Dim Coseno As Double = servicio.Coseno(nro1)
        txtResultado.Text = Coseno.ToString
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        'restar los numeros utilizando el servicio web
        Dim nro1 As Double
        nro1 = txtNro1.Text
        Dim Seno As Double = servicio.Seno(nro1)
        txtResultado.Text = Seno.ToString
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        'restar los numeros utilizando el servicio web
        Dim nro1, nro2 As Double
        nro1 = txtNro1.Text
        nro2 = Double.Parse(txtNro2.Text)
        Dim Dividir As Double = servicio.Division(nro1, nro2)
        txtResultado.Text = Dividir.ToString
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
