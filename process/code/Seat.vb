Imports System.Data.OleDb

Public Class Seat

    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim cmdSeat As OleDbCommand
    Dim cmdHall As New OleDbCommand
    Dim drSeat As OleDbDataReader
    Dim drHall As OleDbDataReader
    Dim hallID As String = ""          'Receive the HallID for current Seat Form
    Public hallName As String = ""
    Public strSeatNumber(197) As String

    Private Sub Seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xuan\Desktop\ticketingSystem\Seat.accdb")
        conn.Open()
        Dim strMoviename As String
        Dim strHall As String
        Dim intCount As Integer = 0

        strMoviename = SelectedMovie.strItm    'Receive the value of MovieName
        strHall = SelectedMovie.strItm2        'Receive the value of HallName

        Dim cmdHall As New OleDbCommand("Select h.HallName,s.HallID From Movie m, Hall h, Seat s WHERE h.HallID = m.HallID AND m.MovieID = s.MovieID AND s.HallID = h.HallID AND m.MovieName ='" & strMoviename & "' AND h.HallName ='" & strHall & "'", conn)
        dr = cmdHall.ExecuteReader
        If dr.Read Then
            hallID = dr("HallID")
            hallName = dr("HallName")
        End If

        Dim cmd As New OleDbCommand("Select s.SeatAvailability From Movie m, Hall h, Seat s WHERE h.HallID = m.HallID AND m.MovieID = s.MovieID AND s.HallID = h.HallID AND m.MovieName ='" & strMoviename & "' AND h.HallName ='" & strHall & "'", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            If dr("SeatAvailability") = 1 Then
                intCount += 1
            End If
        End While

        'Read the Seat Availability and then change the color of the seat if the Seat Availability is equal to 0
        Dim cmdSeat As New OleDbCommand("Select s.SeatNo From Movie m, Hall h, Seat s WHERE h.HallID = m.HallID AND m.MovieID = s.MovieID AND s.HallID = h.HallID AND m.MovieName ='" & strMoviename & "' AND h.HallName ='" & strHall & "' AND s.SeatAvailability = 0", conn)
        drSeat = cmdSeat.ExecuteReader
        While drSeat.Read
            'Row A
            If A1.Name = drSeat.GetString(0) Then
                A1.BackColor = Color.Red
            End If

            If A2.Name = drSeat.GetString(0) Then
                A2.BackColor = Color.Red
            End If

            If A3.Name = drSeat.GetString(0) Then
                A3.BackColor = Color.Red
            End If

            If A4.Name = drSeat.GetString(0) Then
                A4.BackColor = Color.Red
            End If

            If A5.Name = drSeat.GetString(0) Then
                A5.BackColor = Color.Red
            End If

            If A6.Name = drSeat.GetString(0) Then
                A6.BackColor = Color.Red
            End If

            If A7.Name = drSeat.GetString(0) Then
                A7.BackColor = Color.Red
            End If

            If A8.Name = drSeat.GetString(0) Then
                A8.BackColor = Color.Red
            End If

            If A9.Name = drSeat.GetString(0) Then
                A9.BackColor = Color.Red
            End If

            If A10.Name = drSeat.GetString(0) Then
                A10.BackColor = Color.Red
            End If
            'Row B
            If B1.Name = drSeat.GetString(0) Then
                B1.BackColor = Color.Red
            End If

            If B2.Name = drSeat.GetString(0) Then
                B2.BackColor = Color.Red
            End If

            If B3.Name = drSeat.GetString(0) Then
                B3.BackColor = Color.Red
            End If

            If B4.Name = drSeat.GetString(0) Then
                B4.BackColor = Color.Red
            End If

            If B5.Name = drSeat.GetString(0) Then
                B5.BackColor = Color.Red
            End If

            If B6.Name = drSeat.GetString(0) Then
                B6.BackColor = Color.Red
            End If

            If B7.Name = drSeat.GetString(0) Then
                B7.BackColor = Color.Red
            End If

            If B8.Name = drSeat.GetString(0) Then
                B8.BackColor = Color.Red
            End If

            If B9.Name = drSeat.GetString(0) Then
                B9.BackColor = Color.Red
            End If

            If B10.Name = drSeat.GetString(0) Then
                B10.BackColor = Color.Red
            End If

            If B11.Name = drSeat.GetString(0) Then
                B11.BackColor = Color.Red
            End If

            If B12.Name = drSeat.GetString(0) Then
                B12.BackColor = Color.Red
            End If

            If B13.Name = drSeat.GetString(0) Then
                B13.BackColor = Color.Red
            End If

            If B14.Name = drSeat.GetString(0) Then
                B14.BackColor = Color.Red
            End If

            If B15.Name = drSeat.GetString(0) Then
                B15.BackColor = Color.Red
            End If

            If B16.Name = drSeat.GetString(0) Then
                B16.BackColor = Color.Red
            End If

            If B17.Name = drSeat.GetString(0) Then
                B17.BackColor = Color.Red
            End If
            'Row C
            If C1.Name = drSeat.GetString(0) Then
                C1.BackColor = Color.Red
            End If

            If C2.Name = drSeat.GetString(0) Then
                C2.BackColor = Color.Red
            End If

            If C3.Name = drSeat.GetString(0) Then
                C3.BackColor = Color.Red
            End If

            If C4.Name = drSeat.GetString(0) Then
                C4.BackColor = Color.Red
            End If

            If C5.Name = drSeat.GetString(0) Then
                C5.BackColor = Color.Red
            End If

            If C6.Name = drSeat.GetString(0) Then
                C6.BackColor = Color.Red
            End If

            If C7.Name = drSeat.GetString(0) Then
                C7.BackColor = Color.Red
            End If

            If C8.Name = drSeat.GetString(0) Then
                C8.BackColor = Color.Red
            End If

            If C9.Name = drSeat.GetString(0) Then
                C9.BackColor = Color.Red
            End If

            If C10.Name = drSeat.GetString(0) Then
                C10.BackColor = Color.Red
            End If

            If C11.Name = drSeat.GetString(0) Then
                C11.BackColor = Color.Red
            End If

            If C12.Name = drSeat.GetString(0) Then
                C12.BackColor = Color.Red
            End If

            If C13.Name = drSeat.GetString(0) Then
                C13.BackColor = Color.Red
            End If

            If C14.Name = drSeat.GetString(0) Then
                C14.BackColor = Color.Red
            End If

            If C15.Name = drSeat.GetString(0) Then
                C15.BackColor = Color.Red
            End If

            If C16.Name = drSeat.GetString(0) Then
                C16.BackColor = Color.Red
            End If

            If C17.Name = drSeat.GetString(0) Then
                C17.BackColor = Color.Red
            End If
            'Row D
            If D1.Name = drSeat.GetString(0) Then
                D1.BackColor = Color.Red
            End If

            If D2.Name = drSeat.GetString(0) Then
                D2.BackColor = Color.Red
            End If

            If D3.Name = drSeat.GetString(0) Then
                D3.BackColor = Color.Red
            End If

            If D4.Name = drSeat.GetString(0) Then
                D4.BackColor = Color.Red
            End If

            If D5.Name = drSeat.GetString(0) Then
                D5.BackColor = Color.Red
            End If

            If D6.Name = drSeat.GetString(0) Then
                D6.BackColor = Color.Red
            End If

            If D7.Name = drSeat.GetString(0) Then
                D7.BackColor = Color.Red
            End If

            If D8.Name = drSeat.GetString(0) Then
                D8.BackColor = Color.Red
            End If

            If D9.Name = drSeat.GetString(0) Then
                D9.BackColor = Color.Red
            End If

            If D10.Name = drSeat.GetString(0) Then
                D10.BackColor = Color.Red
            End If

            If D11.Name = drSeat.GetString(0) Then
                D11.BackColor = Color.Red
            End If

            If D12.Name = drSeat.GetString(0) Then
                D12.BackColor = Color.Red
            End If

            If D13.Name = drSeat.GetString(0) Then
                D13.BackColor = Color.Red
            End If

            If D14.Name = drSeat.GetString(0) Then
                D14.BackColor = Color.Red
            End If

            If D15.Name = drSeat.GetString(0) Then
                D15.BackColor = Color.Red
            End If

            If D16.Name = drSeat.GetString(0) Then
                D16.BackColor = Color.Red
            End If

            If D17.Name = drSeat.GetString(0) Then
                D17.BackColor = Color.Red
            End If
            'Row E
            If E1.Name = drSeat.GetString(0) Then
                E1.BackColor = Color.Red
            End If

            If E2.Name = drSeat.GetString(0) Then
                E2.BackColor = Color.Red
            End If

            If E3.Name = drSeat.GetString(0) Then
                E3.BackColor = Color.Red
            End If

            If E4.Name = drSeat.GetString(0) Then
                E4.BackColor = Color.Red
            End If

            If E5.Name = drSeat.GetString(0) Then
                E5.BackColor = Color.Red
            End If

            If E6.Name = drSeat.GetString(0) Then
                E6.BackColor = Color.Red
            End If

            If E7.Name = drSeat.GetString(0) Then
                E7.BackColor = Color.Red
            End If

            If E8.Name = drSeat.GetString(0) Then
                E8.BackColor = Color.Red
            End If

            If E9.Name = drSeat.GetString(0) Then
                E9.BackColor = Color.Red
            End If

            If E10.Name = drSeat.GetString(0) Then
                E10.BackColor = Color.Red
            End If

            If E11.Name = drSeat.GetString(0) Then
                E11.BackColor = Color.Red
            End If

            If E12.Name = drSeat.GetString(0) Then
                E12.BackColor = Color.Red
            End If

            If E13.Name = drSeat.GetString(0) Then
                E13.BackColor = Color.Red
            End If

            If E14.Name = drSeat.GetString(0) Then
                E14.BackColor = Color.Red
            End If

            If E15.Name = drSeat.GetString(0) Then
                E15.BackColor = Color.Red
            End If

            If E16.Name = drSeat.GetString(0) Then
                E16.BackColor = Color.Red
            End If

            If E17.Name = drSeat.GetString(0) Then
                E17.BackColor = Color.Red
            End If
            'Row F
            If F1.Name = drSeat.GetString(0) Then
                F1.BackColor = Color.Red
            End If

            If F2.Name = drSeat.GetString(0) Then
                F2.BackColor = Color.Red
            End If

            If F3.Name = drSeat.GetString(0) Then
                F3.BackColor = Color.Red
            End If

            If F4.Name = drSeat.GetString(0) Then
                F4.BackColor = Color.Red
            End If

            If F5.Name = drSeat.GetString(0) Then
                F5.BackColor = Color.Red
            End If

            If F6.Name = drSeat.GetString(0) Then
                F6.BackColor = Color.Red
            End If

            If F7.Name = drSeat.GetString(0) Then
                F7.BackColor = Color.Red
            End If

            If F8.Name = drSeat.GetString(0) Then
                F8.BackColor = Color.Red
            End If

            If F9.Name = drSeat.GetString(0) Then
                F9.BackColor = Color.Red
            End If

            If F10.Name = drSeat.GetString(0) Then
                F10.BackColor = Color.Red
            End If

            If F11.Name = drSeat.GetString(0) Then
                F11.BackColor = Color.Red
            End If

            If F12.Name = drSeat.GetString(0) Then
                F12.BackColor = Color.Red
            End If

            If F13.Name = drSeat.GetString(0) Then
                F13.BackColor = Color.Red
            End If

            If F14.Name = drSeat.GetString(0) Then
                F14.BackColor = Color.Red
            End If

            If F15.Name = drSeat.GetString(0) Then
                F15.BackColor = Color.Red
            End If

            If F16.Name = drSeat.GetString(0) Then
                F16.BackColor = Color.Red
            End If

            If F17.Name = drSeat.GetString(0) Then
                F17.BackColor = Color.Red
            End If
            'Row G
            If G1.Name = drSeat.GetString(0) Then
                G1.BackColor = Color.Red
            End If

            If G2.Name = drSeat.GetString(0) Then
                G2.BackColor = Color.Red
            End If

            If G3.Name = drSeat.GetString(0) Then
                G3.BackColor = Color.Red
            End If

            If G4.Name = drSeat.GetString(0) Then
                G4.BackColor = Color.Red
            End If

            If G5.Name = drSeat.GetString(0) Then
                G5.BackColor = Color.Red
            End If

            If G6.Name = drSeat.GetString(0) Then
                G6.BackColor = Color.Red
            End If

            If G7.Name = drSeat.GetString(0) Then
                G7.BackColor = Color.Red
            End If

            If G8.Name = drSeat.GetString(0) Then
                G8.BackColor = Color.Red
            End If

            If G9.Name = drSeat.GetString(0) Then
                G9.BackColor = Color.Red
            End If

            If G10.Name = drSeat.GetString(0) Then
                G10.BackColor = Color.Red
            End If

            If G11.Name = drSeat.GetString(0) Then
                G11.BackColor = Color.Red
            End If

            If G12.Name = drSeat.GetString(0) Then
                G12.BackColor = Color.Red
            End If

            If G13.Name = drSeat.GetString(0) Then
                G13.BackColor = Color.Red
            End If

            If G14.Name = drSeat.GetString(0) Then
                G14.BackColor = Color.Red
            End If

            If G15.Name = drSeat.GetString(0) Then
                G15.BackColor = Color.Red
            End If

            If G16.Name = drSeat.GetString(0) Then
                G16.BackColor = Color.Red
            End If

            If G17.Name = drSeat.GetString(0) Then
                G17.BackColor = Color.Red
            End If
            'Row H
            If H1.Name = drSeat.GetString(0) Then
                H1.BackColor = Color.Red
            End If

            If H2.Name = drSeat.GetString(0) Then
                H2.BackColor = Color.Red
            End If

            If H3.Name = drSeat.GetString(0) Then
                H3.BackColor = Color.Red
            End If

            If H4.Name = drSeat.GetString(0) Then
                H4.BackColor = Color.Red
            End If

            If H5.Name = drSeat.GetString(0) Then
                H5.BackColor = Color.Red
            End If

            If H6.Name = drSeat.GetString(0) Then
                H6.BackColor = Color.Red
            End If

            If H7.Name = drSeat.GetString(0) Then
                H7.BackColor = Color.Red
            End If

            If H8.Name = drSeat.GetString(0) Then
                H8.BackColor = Color.Red
            End If

            If H9.Name = drSeat.GetString(0) Then
                H9.BackColor = Color.Red
            End If

            If H10.Name = drSeat.GetString(0) Then
                H10.BackColor = Color.Red
            End If

            If H11.Name = drSeat.GetString(0) Then
                H11.BackColor = Color.Red
            End If

            If H12.Name = drSeat.GetString(0) Then
                H12.BackColor = Color.Red
            End If

            If H13.Name = drSeat.GetString(0) Then
                H13.BackColor = Color.Red
            End If

            If H14.Name = drSeat.GetString(0) Then
                H14.BackColor = Color.Red
            End If

            If H15.Name = drSeat.GetString(0) Then
                H15.BackColor = Color.Red
            End If

            If H16.Name = drSeat.GetString(0) Then
                H16.BackColor = Color.Red
            End If

            If H17.Name = drSeat.GetString(0) Then
                H17.BackColor = Color.Red
            End If
            'Row I
            If I1.Name = drSeat.GetString(0) Then
                I1.BackColor = Color.Red
            End If

            If I2.Name = drSeat.GetString(0) Then
                I2.BackColor = Color.Red
            End If

            If I3.Name = drSeat.GetString(0) Then
                I3.BackColor = Color.Red
            End If

            If I4.Name = drSeat.GetString(0) Then
                I4.BackColor = Color.Red
            End If

            If I5.Name = drSeat.GetString(0) Then
                I5.BackColor = Color.Red
            End If

            If I6.Name = drSeat.GetString(0) Then
                I6.BackColor = Color.Red
            End If

            If I7.Name = drSeat.GetString(0) Then
                I7.BackColor = Color.Red
            End If

            If I8.Name = drSeat.GetString(0) Then
                I8.BackColor = Color.Red
            End If

            If I9.Name = drSeat.GetString(0) Then
                I9.BackColor = Color.Red
            End If

            If I10.Name = drSeat.GetString(0) Then
                I10.BackColor = Color.Red
            End If

            If I11.Name = drSeat.GetString(0) Then
                I11.BackColor = Color.Red
            End If

            If I12.Name = drSeat.GetString(0) Then
                I12.BackColor = Color.Red
            End If

            If I13.Name = drSeat.GetString(0) Then
                I13.BackColor = Color.Red
            End If

            If I14.Name = drSeat.GetString(0) Then
                I14.BackColor = Color.Red
            End If

            If I15.Name = drSeat.GetString(0) Then
                I15.BackColor = Color.Red
            End If

            If I16.Name = drSeat.GetString(0) Then
                I16.BackColor = Color.Red
            End If

            If I17.Name = drSeat.GetString(0) Then
                I17.BackColor = Color.Red
            End If
            'Row J
            If J1.Name = drSeat.GetString(0) Then
                J1.BackColor = Color.Red
            End If

            If J2.Name = drSeat.GetString(0) Then
                J2.BackColor = Color.Red
            End If

            If J3.Name = drSeat.GetString(0) Then
                J3.BackColor = Color.Red
            End If

            If J4.Name = drSeat.GetString(0) Then
                J4.BackColor = Color.Red
            End If

            If J5.Name = drSeat.GetString(0) Then
                J5.BackColor = Color.Red
            End If

            If J6.Name = drSeat.GetString(0) Then
                J6.BackColor = Color.Red
            End If

            If J7.Name = drSeat.GetString(0) Then
                J7.BackColor = Color.Red
            End If

            If J8.Name = drSeat.GetString(0) Then
                J8.BackColor = Color.Red
            End If

            If J9.Name = drSeat.GetString(0) Then
                J9.BackColor = Color.Red
            End If

            If J10.Name = drSeat.GetString(0) Then
                J10.BackColor = Color.Red
            End If

            If J11.Name = drSeat.GetString(0) Then
                J11.BackColor = Color.Red
            End If

            If J12.Name = drSeat.GetString(0) Then
                J12.BackColor = Color.Red
            End If

            If J13.Name = drSeat.GetString(0) Then
                J13.BackColor = Color.Red
            End If

            If J14.Name = drSeat.GetString(0) Then
                J14.BackColor = Color.Red
            End If

            If J15.Name = drSeat.GetString(0) Then
                J15.BackColor = Color.Red
            End If

            If J16.Name = drSeat.GetString(0) Then
                J16.BackColor = Color.Red
            End If

            If J17.Name = drSeat.GetString(0) Then
                J17.BackColor = Color.Red
            End If
            'Row K
            If K1.Name = drSeat.GetString(0) Then
                K1.BackColor = Color.Red
            End If

            If K2.Name = drSeat.GetString(0) Then
                K2.BackColor = Color.Red
            End If

            If K3.Name = drSeat.GetString(0) Then
                K3.BackColor = Color.Red
            End If

            If K4.Name = drSeat.GetString(0) Then
                K4.BackColor = Color.Red
            End If

            If K5.Name = drSeat.GetString(0) Then
                K5.BackColor = Color.Red
            End If

            If K6.Name = drSeat.GetString(0) Then
                K6.BackColor = Color.Red
            End If

            If K7.Name = drSeat.GetString(0) Then
                K7.BackColor = Color.Red
            End If

            If K8.Name = drSeat.GetString(0) Then
                K8.BackColor = Color.Red
            End If

            If K9.Name = drSeat.GetString(0) Then
                K9.BackColor = Color.Red
            End If

            If K10.Name = drSeat.GetString(0) Then
                K10.BackColor = Color.Red
            End If

            If K11.Name = drSeat.GetString(0) Then
                K11.BackColor = Color.Red
            End If

            If K12.Name = drSeat.GetString(0) Then
                K12.BackColor = Color.Red
            End If

            If K13.Name = drSeat.GetString(0) Then
                K13.BackColor = Color.Red
            End If

            If K14.Name = drSeat.GetString(0) Then
                K14.BackColor = Color.Red
            End If

            If K15.Name = drSeat.GetString(0) Then
                K15.BackColor = Color.Red
            End If

            If K16.Name = drSeat.GetString(0) Then
                K16.BackColor = Color.Red
            End If

            If K17.Name = drSeat.GetString(0) Then
                K17.BackColor = Color.Red
            End If
            'Row L
            If L1.Name = drSeat.GetString(0) Then
                L1.BackColor = Color.Red
            End If

            If L2.Name = drSeat.GetString(0) Then
                L2.BackColor = Color.Red
            End If

            If L3.Name = drSeat.GetString(0) Then
                L3.BackColor = Color.Red
            End If

            If L4.Name = drSeat.GetString(0) Then
                L4.BackColor = Color.Red
            End If

            If L5.Name = drSeat.GetString(0) Then
                L5.BackColor = Color.Red
            End If

            If L6.Name = drSeat.GetString(0) Then
                L6.BackColor = Color.Red
            End If

            If L7.Name = drSeat.GetString(0) Then
                L7.BackColor = Color.Red
            End If

            If L8.Name = drSeat.GetString(0) Then
                L8.BackColor = Color.Red
            End If

            If L9.Name = drSeat.GetString(0) Then
                L9.BackColor = Color.Red
            End If

            If L10.Name = drSeat.GetString(0) Then
                L10.BackColor = Color.Red
            End If

            If L11.Name = drSeat.GetString(0) Then
                L11.BackColor = Color.Red
            End If

            If L12.Name = drSeat.GetString(0) Then
                L12.BackColor = Color.Red
            End If

            If L13.Name = drSeat.GetString(0) Then
                L13.BackColor = Color.Red
            End If

            If L14.Name = drSeat.GetString(0) Then
                L14.BackColor = Color.Red
            End If

            If L15.Name = drSeat.GetString(0) Then
                L15.BackColor = Color.Red
            End If

            If L16.Name = drSeat.GetString(0) Then
                L16.BackColor = Color.Red
            End If

            If L17.Name = drSeat.GetString(0) Then
                L17.BackColor = Color.Red
            End If
        End While


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Me.Hide()
        MoviePayment.Show()
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(0) = ""
                A1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(0) = "A1 RM20"
                A1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A2_Click_1(sender As Object, e As EventArgs) Handles A2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(1) = ""
                A2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(1) = "A2 RM20"
                A2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A3_Click_1(sender As Object, e As EventArgs) Handles A3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(2) = ""
                A3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(2) = "A3 RM20"
                A3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(3) = ""
                A4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(3) = "A4 RM20"
                A4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(4) = ""
                A5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(4) = "A5 RM20"
                A5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(5) = ""
                A6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(5) = "A6 RM20"
                A6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(6) = ""
                A7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(6) = "A7 RM20"
                A7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(7) = ""
                A8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(7) = "A8 RM20"
                A8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A9_Click(sender As Object, e As EventArgs) Handles A9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(8) = ""
                A9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(8) = "A9 RM20"
                A9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub A10_Click(sender As Object, e As EventArgs) Handles A10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'A10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'A10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(9) = ""
                A10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(9) = "A10 RM20"
                A10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(10) = ""
                B1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(10) = "B1 RM15"
                B1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(11) = ""
                B2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(11) = "B2 RM15"
                B2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(12) = ""
                B3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(12) = "B3 RM15"
                B3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(13) = ""
                B4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(13) = "B4 RM15"
                B4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(14) = ""
                B5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(14) = "B5 RM15"
                B5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(15) = ""
                B6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(15) = "B6 RM15"
                B6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(16) = ""
                B7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(16) = "B7 RM15"
                B7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(17) = ""
                B8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(17) = "B8 RM15"
                B8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(18) = ""
                B9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(18) = "B9 RM15"
                B9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(19) = ""
                B10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(19) = "B10 RM15"
                B10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(20) = ""
                B11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(20) = "B11 RM15"
                B11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B12_Click(sender As Object, e As EventArgs) Handles B12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(21) = ""
                B12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(21) = "B15 RM18"
                B12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B13_Click(sender As Object, e As EventArgs) Handles B13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(22) = ""
                B13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(22) = "B13 RM15"
                B13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B14_Click(sender As Object, e As EventArgs) Handles B14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(23) = ""
                B14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(23) = "B14 RM15"
                B14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B15_Click(sender As Object, e As EventArgs) Handles B15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(24) = ""
                B15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(24) = "B15 RM15"
                B15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B16_Click(sender As Object, e As EventArgs) Handles B16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(25) = ""
                B16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(25) = "B16 RM15"
                B16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub B17_Click(sender As Object, e As EventArgs) Handles B17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'B17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'B17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(26) = ""
                B17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(26) = "B17 RM15"
                B17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(27) = ""
                C1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(27) = "C1 RM15"
                C1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(28) = ""
                C2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(28) = "C2 RM15"
                C2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(29) = ""
                C3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(29) = "C3 RM15"
                C3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(30) = ""
                C4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(30) = "C4 RM15"
                C4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(31) = ""
                C5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(31) = "C5 RM15"
                C5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(32) = ""
                C6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(32) = "C6 RM15"
                C6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(33) = ""
                C7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(33) = "C7 RM15"
                C7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C8_Click(sender As Object, e As EventArgs) Handles C8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(34) = ""
                C8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(34) = "C8 RM15"
                C8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C9_Click(sender As Object, e As EventArgs) Handles C9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(35) = ""
                C9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(35) = "C9 RM15"
                C9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C10_Click(sender As Object, e As EventArgs) Handles C10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(36) = ""
                C10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(36) = "C10 RM15"
                C10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C11_Click(sender As Object, e As EventArgs) Handles C11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(37) = ""
                C11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(37) = "C11 RM15"
                C11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C12_Click(sender As Object, e As EventArgs) Handles C12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(38) = ""
                C12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(38) = "C12 RM15"
                C12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C13_Click(sender As Object, e As EventArgs) Handles C13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(39) = ""
                C13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(39) = "C13 RM15"
                C13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C14_Click(sender As Object, e As EventArgs) Handles C14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(40) = ""
                C14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(40) = "C14 RM15"
                C14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C15_Click(sender As Object, e As EventArgs) Handles C15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(41) = ""
                C15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(41) = "C15 RM15"
                C15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C16_Click(sender As Object, e As EventArgs) Handles C16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(42) = ""
                C16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(42) = "C16 RM15"
                C16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub C17_Click(sender As Object, e As EventArgs) Handles C17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'C17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'C17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(43) = ""
                C17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(43) = "C17 RM15"
                C17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D1_Click(sender As Object, e As EventArgs) Handles D1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(44) = ""
                D1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(44) = "D1 RM15"
                D1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D2_Click(sender As Object, e As EventArgs) Handles D2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(45) = ""
                D2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(45) = "D2 RM15"
                D2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D3_Click(sender As Object, e As EventArgs) Handles D3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(46) = ""
                D3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(46) = "D3 RM15"
                D3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D4_Click(sender As Object, e As EventArgs) Handles D4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(47) = ""
                D4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(47) = "D4 RM15"
                D4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D5_Click(sender As Object, e As EventArgs) Handles D5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(48) = ""
                D5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(48) = "D5 RM15"
                D5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D6_Click(sender As Object, e As EventArgs) Handles D6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(49) = ""
                D6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(49) = "D6 RM15"
                D6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D7_Click(sender As Object, e As EventArgs) Handles D7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(50) = ""
                D7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(50) = "D7 RM15"
                D7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D8_Click(sender As Object, e As EventArgs) Handles D8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(51) = ""
                D8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(51) = "D8 RM15"
                D8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D9_Click(sender As Object, e As EventArgs) Handles D9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(52) = ""
                D9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(52) = "D9 RM15"
                D9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D10_Click(sender As Object, e As EventArgs) Handles D10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(53) = ""
                D10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(53) = "D10 RM15"
                D10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D11_Click(sender As Object, e As EventArgs) Handles D11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(54) = ""
                D11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(54) = "D11 RM15"
                D11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D12_Click(sender As Object, e As EventArgs) Handles D12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(55) = ""
                D12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(55) = "D12 RM15"
                D12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D13_Click(sender As Object, e As EventArgs) Handles D13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(56) = ""
                D13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(56) = "D13 RM15"
                D13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D14_Click(sender As Object, e As EventArgs) Handles D14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(57) = ""
                D14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(57) = "D14 RM15"
                D14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D15_Click(sender As Object, e As EventArgs) Handles D15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(58) = ""
                D15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(58) = "D15 RM15"
                D15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D16_Click(sender As Object, e As EventArgs) Handles D16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(59) = ""
                D16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(59) = "D16 RM15"
                D16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub D17_Click(sender As Object, e As EventArgs) Handles D17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'D17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'D17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(60) = ""
                D17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(60) = "D17 RM15"
                D17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(61) = ""
                E1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(61) = "E1 RM15"
                E1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E2_Click(sender As Object, e As EventArgs) Handles E2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(62) = ""
                E2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(62) = "E2 RM15"
                E2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E3_Click(sender As Object, e As EventArgs) Handles E3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(63) = ""
                E3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(63) = "E3 RM15"
                E3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E4_Click(sender As Object, e As EventArgs) Handles E4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(64) = ""
                E4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(64) = "E4 RM15"
                E4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E5_Click(sender As Object, e As EventArgs) Handles E5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(65) = ""
                E5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(65) = "E5 RM15"
                E5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E6_Click(sender As Object, e As EventArgs) Handles E6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(66) = ""
                E6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(66) = "E6 RM15"
                E6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E7_Click(sender As Object, e As EventArgs) Handles E7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(67) = ""
                E7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(67) = "E7 RM15"
                E7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E8_Click(sender As Object, e As EventArgs) Handles E8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(68) = ""
                E8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(68) = "E8 RM15"
                E8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E9_Click(sender As Object, e As EventArgs) Handles E9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(69) = ""
                E9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(69) = "E9 RM15"
                E9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E10_Click(sender As Object, e As EventArgs) Handles E10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(70) = ""
                E10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(70) = "E10 RM15"
                E10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E11_Click(sender As Object, e As EventArgs) Handles E11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(71) = ""
                E11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(71) = "E11 RM15"
                E11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E12_Click(sender As Object, e As EventArgs) Handles E12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(72) = ""
                E12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(72) = "E12 RM15"
                E12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E13_Click(sender As Object, e As EventArgs) Handles E13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(73) = ""
                E13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(73) = "E13 RM15"
                E13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E14_Click(sender As Object, e As EventArgs) Handles E14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(74) = ""
                E14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(74) = "E14 RM15"
                E14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E15_Click(sender As Object, e As EventArgs) Handles E15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(75) = ""
                E15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(75) = "E15 RM15"
                E15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E16_Click(sender As Object, e As EventArgs) Handles E16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(76) = ""
                E16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(76) = "E16 RM15"
                E16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub E17_Click(sender As Object, e As EventArgs) Handles E17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'E17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'E17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(77) = ""
                E17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(77) = "E17 RM15"
                E17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(78) = ""
                F1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(78) = "F1 RM15"
                F1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(79) = ""
                F2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(79) = "F2 RM15"
                F2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(80) = ""
                F3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(80) = "F3 RM15"
                F3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(81) = ""
                F4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(81) = "F4 RM15"
                F4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(82) = ""
                F5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(82) = "F5 RM15"
                F5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(83) = ""
                F6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(83) = "F6 RM15"
                F6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F7_Click(sender As Object, e As EventArgs) Handles F7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(84) = ""
                F7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(84) = "F7 RM15"
                F7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F8_Click(sender As Object, e As EventArgs) Handles F8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(85) = ""
                F8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(85) = "F8 RM15"
                F8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F9_Click(sender As Object, e As EventArgs) Handles F9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(86) = ""
                F9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(86) = "F9 RM15"
                F9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F10_Click(sender As Object, e As EventArgs) Handles F10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(87) = ""
                F10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(87) = "F10 RM15"
                F10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F11_Click(sender As Object, e As EventArgs) Handles F11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(88) = ""
                F11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(88) = "F11 RM15"
                F11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F12_Click(sender As Object, e As EventArgs) Handles F12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(89) = ""
                F12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(89) = "F12 RM15"
                F12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F13_Click(sender As Object, e As EventArgs) Handles F13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(90) = ""
                F13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(90) = "F13 RM15"
                F13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F14_Click(sender As Object, e As EventArgs) Handles F14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(91) = ""
                F14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(91) = "F14 RM15"
                F14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F15_Click(sender As Object, e As EventArgs) Handles F15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(92) = ""
                F15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(92) = "F15 RM15"
                F15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F16_Click(sender As Object, e As EventArgs) Handles F16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(93) = ""
                F16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(93) = "F16 RM15"
                F16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub F17_Click(sender As Object, e As EventArgs) Handles F17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'F17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'F17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(94) = ""
                F17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(94) = "F17 RM15"
                F17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G1_Click(sender As Object, e As EventArgs) Handles G1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(95) = ""
                G1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(95) = "G1 RM15"
                G1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G2_Click(sender As Object, e As EventArgs) Handles G2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(96) = ""
                G2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(96) = "G2 RM15"
                G2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G3_Click(sender As Object, e As EventArgs) Handles G3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(97) = ""
                G3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(97) = "G3 RM15"
                G3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G4_Click(sender As Object, e As EventArgs) Handles G4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(98) = ""
                G4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(98) = "G4 RM15"
                G4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G5_Click(sender As Object, e As EventArgs) Handles G5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(99) = ""
                G5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(99) = "G5 RM15"
                G5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G6_Click(sender As Object, e As EventArgs) Handles G6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(100) = ""
                G6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(100) = "G6 RM15                            "
                G6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G7_Click(sender As Object, e As EventArgs) Handles G7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(101) = ""
                G7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(101) = "G7 RM15"
                G7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G8_Click(sender As Object, e As EventArgs) Handles G8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(102) = ""
                G8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(102) = "G8 RM15"
                G8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G9_Click(sender As Object, e As EventArgs) Handles G9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(103) = ""
                G9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(103) = "G9 RM15"
                G9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G10_Click(sender As Object, e As EventArgs) Handles G10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(104) = ""
                G10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(104) = "G10 RM15"
                G10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G11_Click(sender As Object, e As EventArgs) Handles G11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(105) = ""
                G11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(105) = "G11 RM15"
                G11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G12_Click(sender As Object, e As EventArgs) Handles G12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(106) = ""
                G12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(106) = "G12 RM15"
                G12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G13_Click(sender As Object, e As EventArgs) Handles G13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(107) = ""
                G13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(107) = "G13 RM15"
                G13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G14_Click(sender As Object, e As EventArgs) Handles G14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(108) = ""
                G14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(108) = "G14 RM15"
                G14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G15_Click(sender As Object, e As EventArgs) Handles G15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(109) = ""
                G15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(109) = "G15 RM15"
                G15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G16_Click(sender As Object, e As EventArgs) Handles G16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(110) = ""
                G16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(110) = "G16 RM15"
                G16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub G17_Click(sender As Object, e As EventArgs) Handles G17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'G17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'G17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(111) = ""
                G17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(111) = "G17 RM15"
                G17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H1_Click(sender As Object, e As EventArgs) Handles H1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(112) = ""
                H1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(112) = "H1 RM15"
                H1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H2_Click(sender As Object, e As EventArgs) Handles H2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(113) = ""
                H2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(113) = "H2 RM15"
                H2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H3_Click(sender As Object, e As EventArgs) Handles H3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(114) = ""
                H3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(114) = "H3 RM15"
                H3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H4_Click(sender As Object, e As EventArgs) Handles H4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(115) = ""
                H4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(115) = "H4 RM15"
                H4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H5_Click(sender As Object, e As EventArgs) Handles H5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(116) = ""
                H5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(116) = "H5 RM15"
                H5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H6_Click(sender As Object, e As EventArgs) Handles H6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(117) = ""
                H6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(117) = "H6 RM15"
                H6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H7_Click(sender As Object, e As EventArgs) Handles H7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(118) = ""
                H7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(118) = "H7 RM15"
                H7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H8_Click(sender As Object, e As EventArgs) Handles H8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(119) = ""
                H8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(119) = "H8 RM15"
                H8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H9_Click(sender As Object, e As EventArgs) Handles H9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(120) = ""
                H9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(120) = "H9 RM15"
                H9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H10_Click(sender As Object, e As EventArgs) Handles H10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(121) = ""
                H10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(121) = "H10 RM15"
                H10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H11_Click(sender As Object, e As EventArgs) Handles H11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(122) = ""
                H11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(122) = "H11 RM15"
                H11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H12_Click(sender As Object, e As EventArgs) Handles H12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(123) = ""
                H12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(123) = "H12 RM15"
                H12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H13_Click(sender As Object, e As EventArgs) Handles H13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(124) = ""
                H13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(124) = "H13 RM15"
                H13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H14_Click(sender As Object, e As EventArgs) Handles H14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(125) = ""
                H14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(125) = "H14 RM15"
                H14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H15_Click(sender As Object, e As EventArgs) Handles H15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(126) = ""
                H15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(126) = "H15 RM15"
                H15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H16_Click(sender As Object, e As EventArgs) Handles H16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(127) = ""
                H16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(127) = "H16 RM15"
                H16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub H17_Click(sender As Object, e As EventArgs) Handles H17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'H17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'H17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(128) = ""
                H17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(128) = "H17 RM15"
                H17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I1_Click(sender As Object, e As EventArgs) Handles I1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(129) = ""
                I1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(129) = "I1 RM15"
                I1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I2_Click(sender As Object, e As EventArgs) Handles I2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(130) = ""
                I2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(130) = "I2 RM15"
                I2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I3_Click(sender As Object, e As EventArgs) Handles I3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(131) = ""
                I3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(131) = "I3 RM15"
                I3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I4_Click(sender As Object, e As EventArgs) Handles I4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(132) = ""
                I4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(132) = "I4 RM15"
                I4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I5_Click(sender As Object, e As EventArgs) Handles I5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(133) = ""
                I5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(133) = "I5 RM15"
                I5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I6_Click(sender As Object, e As EventArgs) Handles I6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(134) = ""
                I6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(134) = "I6 RM15"
                I6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I7_Click(sender As Object, e As EventArgs) Handles I7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(135) = ""
                I7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(135) = "I7 RM15"
                I7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I8_Click(sender As Object, e As EventArgs) Handles I8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(136) = ""
                I8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(136) = "I8 RM15"
                I8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I9_Click(sender As Object, e As EventArgs) Handles I9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(137) = ""
                I9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(137) = "I9 RM15"
                I9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I10_Click(sender As Object, e As EventArgs) Handles I10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(138) = ""
                I10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(138) = "I10 RM15"
                I10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I11_Click(sender As Object, e As EventArgs) Handles I11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(139) = ""
                I11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(139) = "I11 RM15"
                I11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I12_Click(sender As Object, e As EventArgs) Handles I12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(140) = ""
                I12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(140) = "I12 RM15"
                I12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I13_Click(sender As Object, e As EventArgs) Handles I13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(141) = ""
                I13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(141) = "I13 RM15"
                I13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I14_Click(sender As Object, e As EventArgs) Handles I14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(142) = ""
                I14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(142) = "I14 RM15"
                I14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I15_Click(sender As Object, e As EventArgs) Handles I15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(143) = ""
                I15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(143) = "I15 RM15"
                I15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I16_Click(sender As Object, e As EventArgs) Handles I16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(144) = ""
                I16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(144) = "I16 RM15"
                I16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub I17_Click(sender As Object, e As EventArgs) Handles I17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'I17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'I17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(145) = ""
                I17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(145) = "I17 RM15"
                I17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J1_Click(sender As Object, e As EventArgs) Handles J1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(146) = ""
                J1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(146) = "J1 RM15"
                J1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J2_Click(sender As Object, e As EventArgs) Handles J2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(147) = ""
                J2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(147) = "J2 RM15"
                J2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J3_Click(sender As Object, e As EventArgs) Handles J3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(148) = ""
                J3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(148) = "J3 RM15"
                J3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J4_Click(sender As Object, e As EventArgs) Handles J4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(149) = ""
                J4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(149) = "J4 RM15"
                J4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J5_Click(sender As Object, e As EventArgs) Handles J5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(150) = ""
                J5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(150) = "J5 RM15"
                J5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J6_Click(sender As Object, e As EventArgs) Handles J6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(151) = ""
                J6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(151) = "J6 RM15"
                J6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J7_Click(sender As Object, e As EventArgs) Handles J7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(152) = ""
                J7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(152) = "J7 RM15"
                J7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J8_Click(sender As Object, e As EventArgs) Handles J8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(153) = ""
                J8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(153) = "J8 RM15"
                J8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J9_Click(sender As Object, e As EventArgs) Handles J9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(154) = ""
                J9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(154) = "J9 RM15"
                J9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J10_Click(sender As Object, e As EventArgs) Handles J10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(155) = ""
                J10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(155) = "J10 RM15"
                J10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J11_Click(sender As Object, e As EventArgs) Handles J11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(156) = ""
                J11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(156) = "J11 RM15"
                J11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J12_Click(sender As Object, e As EventArgs) Handles J12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(157) = ""
                J12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(157) = "J12 RM15"
                J12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J13_Click(sender As Object, e As EventArgs) Handles J13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(158) = ""
                J13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(158) = "J13 RM15"
                J13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J14_Click(sender As Object, e As EventArgs) Handles J14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(159) = ""
                J14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(159) = "J14 RM15"
                J14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J15_Click(sender As Object, e As EventArgs) Handles J15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(160) = ""
                J15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(160) = "J15 RM15"
                J15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J16_Click(sender As Object, e As EventArgs) Handles J16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(161) = ""
                J16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(161) = "J16 RM15"
                J16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub J17_Click(sender As Object, e As EventArgs) Handles J17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'J17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'J17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(162) = ""
                J17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(162) = "J17 RM15"
                J17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K1_Click(sender As Object, e As EventArgs) Handles K1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(163) = ""
                K1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(163) = "K1 RM15"
                K1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K2_Click(sender As Object, e As EventArgs) Handles K2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(164) = ""
                K2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(164) = "K2 RM15"
                K2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K3_Click(sender As Object, e As EventArgs) Handles K3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(165) = ""
                K3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(165) = "K3 RM15"
                K3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K4_Click(sender As Object, e As EventArgs) Handles K4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(166) = ""
                K4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(166) = "K4 RM15"
                K4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K5_Click(sender As Object, e As EventArgs) Handles K5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(167) = ""
                K5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(167) = "K5 RM15"
                K5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K6_Click(sender As Object, e As EventArgs) Handles K6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(168) = ""
                K6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(168) = "K6 RM15"
                K6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K7_Click(sender As Object, e As EventArgs) Handles K7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(169) = ""
                K7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(169) = "K7 RM15"
                K7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K8_Click(sender As Object, e As EventArgs) Handles K8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(170) = ""
                K8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(170) = "K8 RM15"
                K8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K9_Click(sender As Object, e As EventArgs) Handles K9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(171) = ""
                K9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(171) = "K9 RM15"
                K9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K10_Click(sender As Object, e As EventArgs) Handles K10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(172) = ""
                K10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(172) = "K10 RM15"
                K10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K11_Click(sender As Object, e As EventArgs) Handles K11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(173) = ""
                K11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(173) = "K11 RM15"
                K11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K12_Click(sender As Object, e As EventArgs) Handles K12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(174) = ""
                K12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(174) = "K12 RM15"
                K12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K13_Click(sender As Object, e As EventArgs) Handles K13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(175) = ""
                K13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(175) = "K13 RM15"
                K13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K14_Click(sender As Object, e As EventArgs) Handles K14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(176) = ""
                K14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(176) = "K14 RM15"
                K14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K15_Click(sender As Object, e As EventArgs) Handles K15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(177) = ""
                K15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(177) = "K15 RM15"
                K15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K16_Click(sender As Object, e As EventArgs) Handles K16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(178) = ""
                K16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(178) = "K16 RM15"
                K16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub K17_Click(sender As Object, e As EventArgs) Handles K17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'K17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'K17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(179) = ""
                K17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(179) = "K17 RM15"
                K17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L1_Click(sender As Object, e As EventArgs) Handles L1.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L1' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L1' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(180) = ""
                L1.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(180) = "L1 RM15"
                L1.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L2_Click(sender As Object, e As EventArgs) Handles L2.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L2' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L2' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(181) = ""
                L2.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(181) = "L2 RM15"
                L2.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L3_Click(sender As Object, e As EventArgs) Handles L3.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L3' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L3' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(182) = ""
                L3.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(182) = "L3 RM15"
                L3.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L4_Click(sender As Object, e As EventArgs) Handles L4.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L4' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L4' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(183) = ""
                L4.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(183) = "L4 RM15"
                L4.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L5_Click(sender As Object, e As EventArgs) Handles L5.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L5' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L5' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(184) = ""
                L5.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(184) = "L5 RM15"
                L5.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L6_Click(sender As Object, e As EventArgs) Handles L6.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L6' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L6' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(185) = ""
                L6.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(185) = "L6 RM15"
                L6.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L7_Click(sender As Object, e As EventArgs) Handles L7.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L7' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L7' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(186) = ""
                L7.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(186) = "L7 RM15"
                L7.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L8_Click(sender As Object, e As EventArgs) Handles L8.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L8' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L8' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(187) = ""
                L8.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(187) = "L8 RM15"
                L8.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L9_Click(sender As Object, e As EventArgs) Handles L9.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L9' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L9' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(188) = ""
                L9.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(188) = "L9 RM15"
                L9.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L10_Click(sender As Object, e As EventArgs) Handles L10.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L10' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L10' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(189) = ""
                L10.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(189) = "L10 RM15"
                L10.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L11_Click(sender As Object, e As EventArgs) Handles L11.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L11' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L11' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(190) = ""
                L11.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(190) = "L11 RM15"
                L11.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L12_Click(sender As Object, e As EventArgs) Handles L12.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L12' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L12' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(191) = ""
                L12.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(191) = "L12 RM15"
                L12.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
       btnNext.Enabled = True
    End Sub

    Private Sub L13_Click(sender As Object, e As EventArgs) Handles L13.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L13' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L13' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(192) = ""
                L13.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(192) = "L13 RM15"
                L13.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L14_Click(sender As Object, e As EventArgs) Handles L14.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L14' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L14' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(193) = ""
                L14.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(193) = "L14 RM15"
                L14.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L15_Click(sender As Object, e As EventArgs) Handles L15.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L15' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L15' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(194) = ""
                L15.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(194) = "L15 RM15"
                L15.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L16_Click(sender As Object, e As EventArgs) Handles L16.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L16' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L16' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(195) = ""
                L16.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(195) = "L16 RM15"
                L16.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub

    Private Sub L17_Click(sender As Object, e As EventArgs) Handles L17.Click
        Dim cmd As New OleDbCommand("UPDATE Seat SET SeatAvailability = @seatAvailability WHERE SeatNo = 'L17' AND HallID = '" & hallID & "'", conn)
        Dim cmdRead As New OleDbCommand("SELECT SeatPrice,SeatCode,SeatAvailability FROM Seat WHERE SeatNo = 'L17' AND HallID = '" & hallID & "'", conn)
        Dim dr As OleDbDataReader = cmdRead.ExecuteReader

        If dr.Read Then
            If dr("SeatAvailability") = 0 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 1)
                MoviePayment.seatprice -= dr("SeatPrice")
                strSeatNumber(196) = ""
                L17.BackColor = Color.Empty
            ElseIf dr("SeatAvailability") = 1 Then
                cmd.Parameters.AddWithValue("@seatAvailability", 0)
                MoviePayment.seatprice += dr("SeatPrice")
                strSeatNumber(196) = "L17 RM15"
                L17.BackColor = Color.Red
            End If
        End If

        cmd.ExecuteNonQuery()
        btnNext.Enabled = True
    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Close()
        SelectedMovie.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutUs.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class
