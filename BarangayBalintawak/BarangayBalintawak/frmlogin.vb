Public Class frmlogin
    Private SQL As New SQLControl
    Private AuthUser As String
    Private loginfailed As Integer
    ' This integer variable keeps track of the 
    ' remaining time.
    Public timeLeft As Integer


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If SQL.HasConnection = True Then
            If IsAuthenticated() = True Then
                AuthUser = txtuser.Text
                frmaddchild.Show()
                Me.Hide()

            ElseIf loginfailed = 2 Then
                timeLeft = 60
                Timer1.Start()
                Label3.Text = "Invalid credentials you" & Environment.NewLine & "can't login in 1 minute"
                btnlogin.Text = "Login(60)"
                btnlogin.Enabled = False


            End If
        End If
    End Sub

    Private Function IsAuthenticated() As Boolean


        'Clear Existing Record

        If SQL.SQLDataSet IsNot Nothing Then
            SQL.SQLDataSet.Clear()
        End If

        SQL.ExecuteQuery("SELECT Count(username) As UserCount " &
                     "FROM tbl_admin " &
                     "WHERE username='" & txtuser.Text & "' AND password=CONVERT(NVARCHAR(50),HashBytes('MD5','" & txtpword.Text & "'),2)COLLATE SQL_Latin1_General_CP1_CS_AS")


        If SQL.SQLDataSet.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True
        End If

        If Label3.Text = "Invalid user credetials." Then
            loginfailed += 1
        Else
            loginfailed = 0
        End If

        Label3.Text = "Invalid user credetials."
        Return False
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft > 0 Then
            ' Display the new time left
            ' by updating the Time Left label.
            timeLeft -= 1
            btnlogin.Text = "Login(" & timeLeft & ")"
            lnklblforgotpassword.Visible = True
        Else
            Timer1.Stop()
            btnlogin.Text = "Login"
            btnlogin.Enabled = True
            Label3.Text = ""

        End If
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lnklblforgotpassword.Visible = False
        txtuser.Focus()
    End Sub

    Private Sub lnklblforgotpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblforgotpassword.LinkClicked
        frmforgotpassword.Show()
        txtpword.Clear()
        txtuser.Clear()

        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frnsignup.Show()
        Me.Hide()
    End Sub
End Class