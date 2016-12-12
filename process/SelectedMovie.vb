Imports System.Data.OleDb
Public Class SelectedMovie

    'Public strMovie As String
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public strItm As String = ""    'Keep the MovieName
    Public strItm2 As String = ""   'Keep the HallName
    Public strMovieTime(1) As String
    Public strHall As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
        conn.Open()

        cmd = New OleDbCommand("Select * from Movie order by MovieID", conn)
        dr = cmd.ExecuteReader

        While dr.Read
            cboMovie.Items.Add(dr(1))
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboMovie.Text = "" Then
            MessageBox.Show("Please choose a MOVIE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Seat.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged
        Dim split() As Char = {", "}

        strItm = cboMovie.SelectedItem()
        strMovieTime = strItm.Split(split)

        Dim cmd As New OleDbCommand("Select h.HallName, h.HallID From Movie m, Hall h WHERE h.HallID = m.HallID And m.MovieName ='" & strItm & "'", conn)
        dr = cmd.ExecuteReader

        While dr.Read
            txtHall.Text = (dr("HallName"))
            strHall = dr("HallID")
        End While

        strItm2 = txtHall.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class

