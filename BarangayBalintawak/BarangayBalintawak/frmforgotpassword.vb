Public Class frmforgotpassword
    Dim SQL As New SQLControl

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If txtusername.Text <> "" AndAlso txtsecretcode.Text <> "" Then
            Dim Updatecmd As String = "Update tbl_admin " &
                                      "SET Password='" & txtnewpass.Text & "' " &
                                      "WHERE securitycode ='" & txtsecretcode.Text & "' AND username ='" & txtusername.Text & "' "

            If SQL.UpdatePassword(Updatecmd) = 0 Then
                MsgBox("Mismatch: Username and Security code! ")
            Else
                Label3.Visible = True
                txtnewpass.Visible = True
                btnchangepass.Visible = True
            End If
        End If
    End Sub

    Private Sub btnchangepass_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        If txtnewpass.Text <> "" Then
            Dim Updatecmd As String = "Update tbl_admin " &
                                    "SET Password=CONVERT(NVARCHAR(50),HashBytes('MD5','" & txtnewpass.Text & "'),2)" &
                                    "WHERE securitycode ='" & txtsecretcode.Text & "' AND username ='" & txtusername.Text & "' "
            If SQL.UpdatePassword(Updatecmd) Then
                If MsgBox("Successfully Change", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                    Me.Hide()
                    With frmlogin
                        .timeLeft = 0
                        .Show()
                        .lnklblforgotpassword.Visible = False
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub frmforgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmlogin.Show()
    End Sub
End Class