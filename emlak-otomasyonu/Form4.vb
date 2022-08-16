Imports System.Data.OleDb




Public Class Form4
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D1.mdb")


    Private Sub listele()
        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select*from Müşteriler", baglanti)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        baglanti.Close()

    End Sub
    Private Sub temizle()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        baglanti.Open()
        Dim komut As New OleDbCommand("insert into Müşteriler(Adi,Soyadi,Adres,Telefon,Tc,ev_no)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "')", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Kayıt Eklendi", "Kayıt")
        temizle()
        tablo.Clear()
        listele()

    End Sub

    Dim tablo As New DataTable


    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        baglanti.Open()
        Dim adtr1 As New OleDbDataAdapter("select*from Müşteriler where   Adi like '" + TextBox6.Text + "%'", baglanti)
        Dim tablo1 As New DataTable
        adtr1.Fill(tablo1)

        DataGridView1.DataSource = tablo1
        baglanti.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

