Public Class frnsignup
    Dim SQL As New SQLControl
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        SQL.ExecuteQuery("select *from tbl_admin where tbl_admin.username ='" & txtuname.Text & "'")

        If SQL.SQLDataSet.Tables(0).Rows.Count > 0 Then
            MsgBox("User aldready exist")
            Exit Sub
        ElseIf IsNumeric(txtfname.Text) OrElse IsNumeric(txtmname.Text) OrElse IsNumeric(txtlname.Text) OrElse IsNumeric(cmbgender.Text) OrElse IsNumeric(cmbposition.Text) Then
            MsgBox("Invalid Credentials")
        ElseIf txtfname.Text = "" OrElse txtmname.Text = "" OrElse txtlname.Text = "" OrElse cmbposition.Text = "" OrElse cmbgender.Text = "" OrElse txtuname.Text = "" OrElse txtscode.Text = "" OrElse txtpword.Text = "" Then
            MsgBox("You must complete the info")
        Else
            CreateData()
            ClearAll()
        End If


    End Sub

    Private Sub ClearAll()
        txtfname.Clear()
        txtmname.Clear()
        txtpword.Clear()
        txtscode.Clear()
        txtuname.Clear()
        txtlname.Clear()
        cmbgender.Text = ""
        cmbposition.Text = ""
    End Sub

    Public Sub CreateData()
        If Len(txtuname.Text) >= 6 And Len(txtpword.Text) >= 8 Then

            SQL.AddUser(txtuname.Text, txtpword.Text, txtfname.Text, txtmname.Text, txtlname.Text, BdayDateTimePicker.Text, cmbgender.Text, txtscode.Text, cmbposition.Text)
        Else
            MsgBox("Username And Passwod Is too short!")
        End If

    End Sub

    Private Sub frnsignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If SQL.HasConnection = True Then
        'MsgBox("Successfully Conneted!")
        'SQL.ExecuteQuery("SELECT username from tbl_admin")
        'End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        frmlogin.Show()
    End Sub
End Class
