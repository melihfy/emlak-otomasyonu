
Public Class Form1
    Sub SayfaGetir(frm As Form)


        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        frm.Show()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SayfaGetir(Form4)




    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SayfaGetir(Form5)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        SayfaGetir(Form4)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
