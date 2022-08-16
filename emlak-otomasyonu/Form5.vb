Imports System.Data.OleDb
Public Class Form5
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D1.mdb")
    Dim tablo As New DataTable

    Private Sub listele()
        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select*from Ürünler", baglanti)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        baglanti.Close()

    End Sub
    Private Sub temizle()
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox3.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""


    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        baglanti.Open()
        Dim komut As New OleDbCommand("insert into Ürünler(s_no,il_ilce,adres,kat_sayisi,b_kat,isitma,alani,oda_sayisi,bina_yasi,fiyat,durumu,musteri)values('" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox3.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "')", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
        MessageBox.Show("Kayıt Eklendi")
        temizle()
        tablo.Clear()
        listele()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        baglanti.Open()
        Dim adtr1 As New OleDbDataAdapter("Select*from Ürünler where   il_ilce Like '" + TextBox2.Text + "%'", baglanti)
        Dim tablo1 As New DataTable
        adtr1.Fill(tablo1)

        DataGridView1.DataSource = tablo1
        baglanti.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        baglanti.Open()
        Dim adtr1 As New OleDbDataAdapter("Select*from Ürünler where adres Like '" + TextBox6.Text + "%'", baglanti)
        Dim tablo2 As New DataTable
        adtr1.Fill(tablo2)

        DataGridView1.DataSource = tablo2
        baglanti.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class