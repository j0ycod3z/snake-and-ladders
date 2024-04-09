Imports System.Diagnostics.Contracts
Imports System.Windows

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Select Case ComboBox1.Text
            Case "1 player"
                p1.Visible = True
                p2.Visible = False
                p3.Visible = False
                p4.Visible = False

                p1smol.Visible = True
                p2smol.Visible = False
                p3smol.Visible = False
                p4smol.Visible = False

                Label5.Visible = True
                Label6.Visible = False
                Label7.Visible = False
                Label8.Visible = False

            Case "2 player"
                p1.Visible = True
                p2.Visible = True
                p3.Visible = False
                p4.Visible = False


                p1smol.Visible = True
                p2smol.Visible = True
                p3smol.Visible = False
                p4smol.Visible = False


                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = False
                Label8.Visible = False
            Case "3 player"
                p1.Visible = True
                p2.Visible = True
                p3.Visible = True
                p4.Visible = False

                p1smol.Visible = True
                p2smol.Visible = True
                p3smol.Visible = True
                p4smol.Visible = False

                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = False
            Case "4 player"
                p1.Visible = True
                p2.Visible = True
                p3.Visible = True
                p4.Visible = True

                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True

                p1smol.Visible = True
                p2smol.Visible = True
                p3smol.Visible = True
                p4smol.Visible = True
            Case Else
                Label1.Text = "Invalid input pls try again"
                Return
        End Select




        play()
        powers()
        Panel1.Visible = False
        Panel2.Visible = True
        Label3.Visible = False
        Label4.Visible = False
    End Sub


    Dim row As Integer = 0
    Dim pic(99) As Button
    Private Sub play()

        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim z = 9

        For i As Integer = 99 To 0 Step -1
            pic(i) = New Button
            If (row Mod 2 = 0) Then
                z = 9
                If (i Mod 2 = 0) Then
                    pic(i).BackColor = Color.FromArgb(255, 201, 107, 107)
                Else
                    pic(i).BackColor = Color.FromArgb(255, 202, 182, 182)
                End If
                pic(i).Text = i + 1
                pic(i).Name = pic(i).Text


            Else
                If (i Mod 2 = 1) Then
                    pic(i).BackColor = Color.FromArgb(255, 201, 107, 107)
                Else
                    pic(i).BackColor = Color.FromArgb(255, 202, 182, 182)
                End If
                pic(i).Text = i - z + 1
                pic(i).Name = pic(i).Text
                z -= 2
            End If
            pic(i).SetBounds(x, y, 85, 85)
            Me.Controls.Add(pic(i))
            x += 85
            If (i) Mod 10 = 0 Then
                y += 85
                x = 0
                row += 1
            End If
        Next

    End Sub

    Private rand As New Random()
    Private usedNumbers As New HashSet(Of Integer)()

    Private Function GetUniqueRandomNumber() As Integer
        Dim num As Integer
        Do
            num = rand.Next(1, 100)
        Loop While usedNumbers.Contains(num)
        usedNumbers.Add(num)
        Return num
    End Function



    Dim power1 As Integer
    Dim power2 As Integer
    Dim power3 As Integer
    Dim power4 As Integer
    Dim power5 As Integer
    Dim power6 As Integer
    Dim power7 As Integer
    Dim power8 As Integer
    Dim power9 As Integer
    Dim power10 As Integer

    Dim down1 As Integer
    Dim down2 As Integer
    Dim down3 As Integer
    Dim down4 As Integer
    Dim down5 As Integer
    Dim down6 As Integer
    Dim down7 As Integer
    Dim down8 As Integer
    Dim down9 As Integer
    Dim down10 As Integer



    Dim onep As Integer
    Dim twop As Integer
    Dim threep As Integer
    Dim fourp As Integer
    Dim fivep As Integer


    Dim oned As Integer
    Dim twod As Integer
    Dim threed As Integer
    Dim fourd As Integer
    Dim fived As Integer


    Dim low As Integer
    Dim low1 As Integer
    Dim low2 As Integer
    Dim low3 As Integer
    Dim low4 As Integer
    Dim high As Integer
    Dim high1 As Integer
    Dim high2 As Integer
    Dim high3 As Integer
    Dim high4 As Integer



    Sub powers()
        power1 = GetUniqueRandomNumber()
        power2 = GetUniqueRandomNumber()


        If power1 < power2 Then
            onep = power2
            low = power1
        Else
            onep = power1
            low = power2
        End If



        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power1.ToString Then
                pow1.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power2.ToString Then
                pow2.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next


        power3 = GetUniqueRandomNumber()
        power4 = GetUniqueRandomNumber()

        If power3 < power4 Then
            twop = power4
            low1 = power3
        Else
            twop = power3
            low1 = power4
        End If


        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power3.ToString Then
                pow3.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power4.ToString Then
                pow4.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next

        power5 = GetUniqueRandomNumber()
        power6 = GetUniqueRandomNumber()


        If power5 < power6 Then
            threep = power6
            low2 = power5
        Else
            threep = power5
            low2 = power6
        End If


        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power5.ToString Then
                pow5.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power6.ToString Then
                pow6.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next
        power7 = GetUniqueRandomNumber()
        power8 = GetUniqueRandomNumber()

        If power7 < power8 Then
            fourp = power8
            low3 = power7
        Else
            fourp = power7
            low3 = power8
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power7.ToString Then
                pow7.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power8.ToString Then
                pow8.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next
        power9 = GetUniqueRandomNumber()
        power10 = GetUniqueRandomNumber()


        If power9 < power10 Then
            fivep = power10
            low4 = power9
        Else
            fivep = power9
            low4 = power10
        End If



        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power9.ToString Then
                pow9.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = power10.ToString Then
                pow10.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next


        down1 = GetUniqueRandomNumber()
        down2 = GetUniqueRandomNumber()

        If down1 < down2 Then
            high = down2
            oned = down1
        Else
            high = down1
            oned = down2
        End If



        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down1.ToString Then
                dow1.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down2.ToString Then
                dow2.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next


        down3 = GetUniqueRandomNumber()
        down4 = GetUniqueRandomNumber()

        If down3 < down4 Then
            high1 = down4
            twod = down3
        Else
            twod = down4
            high1 = down3
        End If



        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down3.ToString Then
                dow3.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down4.ToString Then
                dow4.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next

        down5 = GetUniqueRandomNumber()
        down6 = GetUniqueRandomNumber()


        If down5 < down6 Then
            high2 = down6
            threed = down5
        Else
            threed = down6
            high2 = down5
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down5.ToString Then
                dow5.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down6.ToString Then
                dow6.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next
        down7 = GetUniqueRandomNumber()
        down8 = GetUniqueRandomNumber()

        If down7 < down8 Then
            high3 = down8
            fourd = down7
        Else
            fourd = down8
            high3 = down7
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down7.ToString Then
                dow7.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down8.ToString Then
                dow8.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next
        down9 = GetUniqueRandomNumber()
        down10 = GetUniqueRandomNumber()


        If down9 < down10 Then
            high4 = down10
            fived = down9
        Else
            fived = down10
            high4 = down9
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down9.ToString Then
                dow9.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)


                Exit For
            End If
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = down10.ToString Then
                dow10.Location = New Point(ctrl.Left + 25, ctrl.Top + 55)
                Exit For
            End If
        Next



    End Sub



    Dim img() = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Panel2.Visible = False
    End Sub

    Dim rolld As Integer
    Dim all As Integer
    Dim st() As Integer = {1, 2, 3, 4, 5, 6}
    Dim ai2 As Integer
    Dim allai2 As Integer
    Dim ai3 As Integer
    Dim allai3 As Integer
    Dim ai4 As Integer
    Dim allai4 As Integer
    Dim huli As Integer
    Dim toh As Integer
    Private Sub dice()
        Shuffle(st)

        PictureBox1.BackgroundImage = img(st(0) - 1)
        PictureBox2.BackgroundImage = img(st(5) - 1)

        rolld = st(0) + st(5)
        Label2.Text = "ROLLED:" + rolld.ToString
        all += rolld




        If p1.Visible = True Then

            If all = 100 Then
                MessageBox.Show("Player 1 won the game")
            End If

            If all > 100 Then
                huli = all - 100
                toh = 100 - huli
                all = toh
            End If

        End If

        If p2.Visible = True Then

            If all = 100 Then
                MessageBox.Show("Player 1 won the game")
            End If

            If all > 100 Then
                huli = all - 100
                toh = 100 - huli
                all = toh
            End If


            Shuffle(st)
            ai2 = st(0) + st(5)
            allai2 += ai2

            If allai2 = 100 Then
                MessageBox.Show("Player 2 won the game")
            End If

            If allai2 > 100 Then
                huli = allai2 - 100
                toh = 100 - huli
                allai2 = toh
            End If

        End If

        If p3.Visible = True Then

            Shuffle(st)
            ai3 = st(0) + st(5)
            allai3 += ai3

            If allai3 = 100 Then
                MessageBox.Show("Player 3 won the game")
            End If

            If allai3 > 100 Then
                huli = allai3 - 100
                toh = 100 - huli
                allai3 = toh
            End If
        End If

        If p4.Visible = True Then

            Shuffle(st)
            ai4 = st(0) + st(5)
            allai4 += ai4

            If allai4 = 100 Then
                MessageBox.Show("Player 4 won the game")
            End If

            If allai4 > 100 Then
                huli = allai4 - 100
                toh = 100 - huli
                allai4 = toh
            End If

        End If

        players()
    End Sub

    Private random As New Random()

    Public Sub Shuffle(items As Integer())
        Dim j As Int32
        Dim temp As Integer

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = random.Next(0, n + 1)

            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dice()

    End Sub

    Sub players()




        If all = low Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = onep.ToString Then
                    all = onep
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = low1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twop.ToString Then
                    all = twop
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = low2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threep.ToString Then
                    all = threep
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = low3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourp.ToString Then
                    all = fourp
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = low4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fivep.ToString Then
                    all = fivep
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = high Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = oned.ToString Then
                    all = oned
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = high1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twod.ToString Then
                    all = twod
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = high2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threed.ToString Then
                    all = threed
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = high3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourd.ToString Then
                    all = fourd
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf all = high4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fived.ToString Then
                    all = fived
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        Else

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = all.ToString Then
                    all = all
                    p1smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        End If










        If allai2 = low Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = onep.ToString Then
                    allai2 = onep
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = low1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twop.ToString Then
                    allai2 = twop
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = low2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threep.ToString Then
                    allai2 = threep
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = low3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourp.ToString Then
                    allai2 = fourp
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = low4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fivep.ToString Then
                    allai2 = fivep
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = high Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = oned.ToString Then
                    allai2 = oned
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = high1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twod.ToString Then
                    allai2 = twod
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = high2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threed.ToString Then
                    allai2 = threed
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = high3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourd.ToString Then
                    allai2 = fourd
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai2 = high4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fived.ToString Then
                    allai2 = fived
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        Else


            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = allai2.ToString Then
                    p2smol.Location = New Point(ctrl.Left, ctrl.Top + 50)
                    Exit For
                End If
            Next
        End If

        If allai3 = low Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = onep.ToString Then
                    allai3 = onep
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = low1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twop.ToString Then
                    allai3 = twop
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = low2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threep.ToString Then
                    allai3 = threep
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = low3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourp.ToString Then
                    allai3 = fourp
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = low4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fivep.ToString Then
                    allai3 = fivep
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = high Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = oned.ToString Then
                    allai3 = oned
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = high1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twod.ToString Then
                    allai3 = twod
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = high2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threed.ToString Then
                    allai3 = threed
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = high3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourd.ToString Then
                    allai3 = fourd
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai3 = high4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fived.ToString Then
                    allai3 = fived
                    p3smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        Else

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = allai3.ToString Then
                    p3smol.Location = New Point(ctrl.Left + 50, ctrl.Top)
                    Exit For
                End If
            Next
        End If



        If allai4 = low Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = onep.ToString Then
                    allai4 = onep
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = low1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twop.ToString Then
                    allai4 = twop
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = low2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threep.ToString Then
                    allai4 = threep
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = low3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourp.ToString Then
                    allai4 = fourp
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = low4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fivep.ToString Then
                    allai4 = fivep
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = high Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = oned.ToString Then
                    allai4 = oned
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = high1 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = twod.ToString Then
                    allai4 = twod
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = high2 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = threed.ToString Then
                    allai4 = threed
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = high3 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fourd.ToString Then
                    allai4 = fourd
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        ElseIf allai4 = high4 Then
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = fived.ToString Then
                    allai4 = fived
                    p4smol.Location = New Point(ctrl.Left, ctrl.Top)
                    Exit For
                End If
            Next
        Else



            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button AndAlso DirectCast(ctrl, Button).Text = allai4.ToString Then
                    p4smol.Location = New Point(ctrl.Left + 50, ctrl.Top + 50)
                    Exit For
                End If
            Next
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Restart()
    End Sub
End Class
