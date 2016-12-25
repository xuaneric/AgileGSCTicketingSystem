
Imports System.Data.OleDb
Public Class MoviePayment


    Dim conn As OleDbConnection
    Dim intChildrenCount As Integer = 0  'Number of children selected
    Public seatprice As Double = 0     'Receive seat price from the seat form
    Dim hall As String = ""
    Dim paymentTime As String = ""
    Dim dblChildDiscount As Double = 0  'Children discount
    Dim dblDiscount As Double = 0       'Member discount


    Private Sub MoviePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
        conn.Open()
        Dim intCount As Integer = 0
        For i = 0 To 196
            If Seat.strSeatNumber(i) = "" Then
                Continue For
            Else
                intCount += 1
                cboChildren.Items.Add(intCount)
            End If
        Next

        If Seat.hallName = "Hall A Morning" Or Seat.hallName = "Hall A Afternoon" Or Seat.hallName = "Hall A Evening" Then
            hall = "A"
        ElseIf Seat.hallName = "Hall B Morning" Or Seat.hallName = "Hall B Afternoon" Or Seat.hallName = "Hall B Evening" Then
            hall = "B"
        ElseIf Seat.hallName = "Hall C Morning" Or Seat.hallName = "Hall C Afternoon" Or Seat.hallName = "Hall C Evening" Then
            hall = "C"
        ElseIf Seat.hallName = "Hall D Morning" Or Seat.hallName = "Hall D Afternoon" Or Seat.hallName = "Hall D Evening" Then
            hall = "D"
        ElseIf Seat.hallName = "Hall E Morning" Or Seat.hallName = "Hall E Afternoon" Or Seat.hallName = "Hall E Evening" Then
            hall = "E"
        ElseIf Seat.hallName = "Hall F Morning" Or Seat.hallName = "Hall F Afternoon" Or Seat.hallName = "Hall F Evening" Then
            hall = "F"
        ElseIf Seat.hallName = "Hall G Morning" Or Seat.hallName = "Hall G Afternoon" Or Seat.hallName = "Hall G Evening" Then
            hall = "G"
        ElseIf Seat.hallName = "Hall H Morning" Or Seat.hallName = "Hall H Afternoon" Or Seat.hallName = "Hall H Evening" Then
            hall = "H"
        End If
    End Sub

    Private Function generateID() As String
        Dim strPayment As String = ""
        'Dim intNum As String = 0
        Dim strNewID As String = ""
        Dim intPaymentCount As Integer = 1

        Dim cmd As New OleDbCommand("Select * FROM Payment", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            strPayment = dr.GetString(0) & vbCrLf
            intPaymentCount += 1
        End While

        'intNum = strPayment.Substring(3, 7) + 1
        strNewID = "PID" & intPaymentCount

        Return strNewID
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim insertCmd As New OleDbCommand("INSERT INTO Payment (PaymentID, MovieDeal, Payment, TransactionDate, HallID) VALUES (@PaymentID, @MovieDeal, @Payment,  @TransDate, @HallID)", conn)
        Dim cmd As New OleDbCommand("Select * FROM Payment", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim readCmd As New OleDbCommand("Select * FROM Member", conn)
        Dim drRead As OleDbDataReader = readCmd.ExecuteReader

        Dim intCount As Integer = 0
        Dim strPaymentID As String = ""
        Dim strNewID As String = ""
        Dim intNum As String = ""

        'insert paymentID into database
        If IsDBNull(dr.Read) = True Then
            strPaymentID = "PID1"
            insertCmd.Parameters.AddWithValue("@PaymentID", strPaymentID)
        Else
            strNewID = generateID()
            insertCmd.Parameters.AddWithValue("@PaymentID", strNewID)
        End If

        txtMovie.Text = SelectedMovie.strMovieTime(0).ToString
        txtTime.Text = SelectedMovie.strMovieTime(1).ToString

        'insert movie into database
        insertCmd.Parameters.AddWithValue("@MovieDeal", SelectedMovie.strMovieTime(0) & " " & SelectedMovie.strMovieTime(1))

        'Calculate discount for children and member
        If txtVerify.Enabled = True Then
            While drRead.Read
                If drRead(0) = txtVerify.Text Then
                    dblDiscount = seatprice * 0.2
                    Exit While
                End If
            End While

            If dblDiscount = 0 Then
                MessageBox.Show("Invalid Member ID entered")
                Exit Sub
            Else
                seatprice -= dblDiscount
            End If
        End If

        dblChildDiscount = intChildrenCount * 5
        seatprice -= dblChildDiscount

        'insert payment into database
        insertCmd.Parameters.AddWithValue("@Payment", seatprice)

        paymentTime = Date.UtcNow
        'insert time into database
        insertCmd.Parameters.AddWithValue("@TransDate", paymentTime)

        'Insert hall into database
        For i = 0 To 196
            If Seat.strSeatNumber(i) = "" Then
                Continue For
            Else
                lstSeat.Items.Add(Seat.strSeatNumber(i))
                insertCmd.Parameters.AddWithValue("@HallID", SelectedMovie.strHall)
            End If
        Next

        txtPayment.Text = seatprice.ToString("C2")

        btnPrint.Enabled = True
        btnCalculate.Enabled = False
        'GroupBox2.Enabled = False
        'ComboBox1.Enabled = False

        insertCmd.ExecuteNonQuery()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChildren.SelectedIndexChanged
        intChildrenCount = cboChildren.SelectedItem
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        
        prntDialog.Document = prntDoc
        prntDialog.ShowDialog()
    End Sub

    Private Sub prntDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles prntDoc.PrintPage
        Dim strSeatItm As String
        Dim splitItm(1) As String
        Dim split() As Char = {" "}

        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top
        Dim font1 As New Font("Times New roman", 20)
        Dim font2 As New Font("Times New roman", 28, FontStyle.Bold)
        Dim font3 As New Font("Times New roman", 32)
        Dim linespace As Single = font1.GetHeight
        Dim linespace2 As Single = font2.GetHeight
        Dim linespace3 As Single = font3.GetHeight

        For Each strSeatItm In lstSeat.Items
            splitItm = strSeatItm.Split(split)
            e.Graphics.DrawString("-----------------------------------", font2, Brushes.Black, x, y)
            y += linespace
            'GSC title
            e.Graphics.DrawString("Golden Screen Cinema", font2, Brushes.Black, x, y)
            y += linespace
            e.Graphics.DrawString("-----------------------------------", font2, Brushes.Black, x, y)
            y += linespace2
            'Hall Name
            e.Graphics.DrawString(hall, font3, Brushes.Black, x + 400, y)
            y += linespace2
            'Movie Name
            e.Graphics.DrawString(txtMovie.Text, font1, Brushes.Black, x, y)
            y += linespace
            'Time
            e.Graphics.DrawString(txtTime.Text, font1, Brushes.Black, x, y)
            y += linespace
            'Date
            e.Graphics.DrawString(paymentTime, font1, Brushes.Black, x, y)
            y += linespace
            'Seat number
            e.Graphics.DrawString(splitItm(0), font3, Brushes.Black, x, y)
            y += linespace3
        Next

        e.Graphics.DrawString("-----------------------------------", font2, Brushes.Black, x, y)
        y += linespace * 2
        'Price
        e.Graphics.DrawString("Number Of Children: " & intChildrenCount, font1, Brushes.Black, x, y)
        y += linespace
        e.Graphics.DrawString("Children Discount: " & dblChildDiscount, font1, Brushes.Black, x, y)
        y += linespace
        e.Graphics.DrawString("Member Discount: " & dblDiscount, font1, Brushes.Black, x, y)
        y += linespace
        e.Graphics.DrawString("Total Price: " & seatprice, font1, Brushes.Black, x, y)
        y += linespace
    End Sub

    Private Sub chkMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkMember.CheckedChanged
        If chkMember.Checked = True Then
            txtVerify.Enabled = True
        Else
            txtVerify.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Seat.Close()
        SelectedMovie.Close()
        SelectedMovie.Show()
    End Sub

    Private Sub chkChildren_CheckedChanged(sender As Object, e As EventArgs) Handles chkChildren.CheckedChanged
        If chkChildren.Checked = True Then
            cboChildren.Enabled = True
        Else
            cboChildren.Enabled = False
        End If

    End Sub


    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub txtMovie_TextChanged(sender As Object, e As EventArgs) Handles txtMovie.TextChanged

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = txtPayment.Text()
        b = txtAmount.Text()
        c = b - a

        txtBalance.Text = c.ToString("C2")


    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub
End Class