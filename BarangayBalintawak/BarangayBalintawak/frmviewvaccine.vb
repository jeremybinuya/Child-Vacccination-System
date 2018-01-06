Public Class frmviewvaccine
    Dim SQL As New SQLControl

    Private Sub cbBCG_CheckedChanged(sender As Object, e As EventArgs) Handles cbBCG.CheckedChanged
        If cbBCG.Checked = True Then
            dtpBCG.Visible = True
        Else
            dtpBCG.Visible=false

        End If
    End Sub

    Private Sub cbHepBBD_CheckedChanged(sender As Object, e As EventArgs) Handles cbHepBBD.CheckedChanged
        If cbHepBBD.Checked = True Then
            dtpHepBBD.Visible = True
        Else
            dtpHepBBD.Visible = False
        End If
    End Sub

    Private Sub cbpenta1_CheckedChanged(sender As Object, e As EventArgs) Handles cbpenta1.CheckedChanged
        If cbpenta1.Checked = True Then
            dtppenta1.Visible = True
        Else
            dtppenta1.Visible = False
        End If
    End Sub

    Private Sub cbpenta2_CheckedChanged(sender As Object, e As EventArgs) Handles cbpenta2.CheckedChanged
        If cbpenta2.Checked = True Then
            dtppenta2.Visible = True
        Else
            dtppenta2.Visible = False

        End If
    End Sub

    Private Sub cbpenta3_CheckedChanged(sender As Object, e As EventArgs) Handles cbpenta3.CheckedChanged
        If cbpenta3.Checked = True Then
            dtppenta3.Visible = True
        Else
            dtppenta3.Visible = False
        End If
    End Sub

    Private Sub cbOPV1_CheckedChanged(sender As Object, e As EventArgs) Handles cbOPV1.CheckedChanged
        If cbOPV1.Checked = True Then
            dtpOPV1.Visible = True
        Else
            dtpOPV1.Visible = False
        End If
    End Sub

    Private Sub cbOPV2_CheckedChanged(sender As Object, e As EventArgs) Handles cbOPV2.CheckedChanged
        If cbOPV2.Checked = True Then
            dtpOPV2.Visible = True
        Else
            dtpOPV2.Visible = False
        End If
    End Sub

    Private Sub cbOPV3_CheckedChanged(sender As Object, e As EventArgs) Handles cbOPV3.CheckedChanged
        If cbOPV3.Checked = True Then
            dtpOPV3.Visible = True
        Else
            dtpOPV3.Visible = False
        End If
    End Sub

    Private Sub cbIPV_CheckedChanged(sender As Object, e As EventArgs) Handles cbIPV.CheckedChanged
        If cbIPV.Checked = True Then
            dtpIPV.Visible = True
        Else
            dtpIPV.Visible = False
        End If
    End Sub

    Private Sub cbMCV1_CheckedChanged(sender As Object, e As EventArgs) Handles cbMCV1.CheckedChanged
        If cbMCV1.Checked = True Then
            dtpMCV1.Checked = True
        Else
            dtpMCV1.Checked = False
        End If

    End Sub

    Private Sub cbMCV2_CheckedChanged(sender As Object, e As EventArgs) Handles cbMCV2.CheckedChanged
        If cbMCV2.Checked = True Then
            dtpMCV2.Visible = True
        Else
            dtpMCV2.Visible = False
        End If
    End Sub

    Private Sub cbTT_CheckedChanged(sender As Object, e As EventArgs) Handles cbTT.CheckedChanged
        If cbTT.Checked = True Then
            dtpTT.Visible = True
        Else
            dtpTT.Visible = false
        End If
    End Sub

    Private Sub cbTT2_CheckedChanged(sender As Object, e As EventArgs) Handles cbTT2.CheckedChanged
        If cbTT2.Checked = True Then
            dtpTT2.Visible = True
        Else
            dtpTT2.Visible = False
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Try
            Dim strtBCG As String
            Dim strHepBBD As String
            Dim strpenta1 As String
            Dim strpenta2 As String
            Dim strpenta3 As String
            Dim strOPV1 As String
            Dim strOPV2 As String
            Dim strOPV3 As String
            Dim strIPV As String
            Dim strMVC1 As String
            Dim strMVC2 As String
            Dim strTT As String
            Dim strTT2 As String

            If cbBCG.Checked = True Then strtBCG = "OK" Else strtBCG = "NOT OK"
            If cbHepBBD.Checked = True Then strHepBBD = "OK" Else strHepBBD = "NOT OK"
            If cbpenta1.Checked = True Then strpenta1 = "OK" Else strpenta1 = "NOT OK"
            If cbpenta2.Checked = True Then strpenta2 = "OK" Else strpenta2 = "NOT OK"
            If cbpenta3.Checked = True Then strpenta3 = "OK" Else strpenta3 = "NOT OK"
            If cbOPV1.Checked = True Then strOPV1 = "OK" Else strOPV1 = "NOT OK"
            If cbOPV2.Checked = True Then strOPV2 = "OK" Else strOPV2 = "NOT OK"
            If cbOPV3.Checked = True Then strOPV3 = "OK" Else strOPV3 = "NOT OK"
            If cbIPV.Checked = True Then strIPV = "OK" Else strIPV = "NOT OK"
            If cbMCV1.Checked = True Then strMVC1 = "OK" Else strMVC1 = "NOT OK"
            If cbMCV2.Checked = True Then strMVC2 = "OK" Else strMVC2 = "NOT OK"
            If cbTT.Checked = True Then strTT = "OK" Else strTT = "NOT OK"
            If cbTT2.Checked = True Then strTT2 = "OK" Else strTT2 = "NOT OK"

            Dim updatecmd As String = "UPDATE tbl_dates " &
                                        "SET BCG='" & dtpBCG.Text & "', " &
                                        "[HepB BD]='" & dtpHepBBD.Text & "', " &
                                        "fPenta='" & dtppenta1.Text & "', " &
                                        "sPenta='" & dtppenta2.Text & "', " &
                                        "tPenta='" & dtppenta3.Text & "', " &
                                        "fOPV='" & dtpOPV1.Text & "', " &
                                        "sOPV='" & dtpOPV2.Text & "', " &
                                        "tOPV='" & dtpOPV3.Text & "', " &
                                        "IPV='" & dtpOPV3.Text & "', " &
                                        "fMVC='" & dtpMCV1.Text & "', " &
                                        "sMVC='" & dtpMCV2.Text & "', " &
                                        "TT='" & dtpTT.Text & "', " &
                                        "sTT='" & dtpTT2.Text & "' " &
                                        "WHERE childname ='" & lblchildname.Text & "' "
            SQL.ChildAddDate(updatecmd)

            Dim updatecmd2 As String = "UPDATE tbl_checkvaccine " &
                                        "SET BCG='" & strtBCG & "', " &
                                         "[HepB BD]='" & strHepBBD & "', " &
                                        "fPenta='" & strpenta1 & "', " &
                                        "sPenta='" & strpenta2 & "', " &
                                        "tPenta='" & strpenta3 & "', " &
                                        "fOPV='" & strOPV1 & "', " &
                                        "sOPV='" & strOPV2 & "', " &
                                        "tOPV='" & strOPV3 & "', " &
                                        "IPV='" & strIPV & "', " &
                                        "fMVC='" & strMVC1 & "', " &
                                        "sMVC='" & strMVC2 & "', " &
                                        "TT='" & strTT & "', " &
                                        "sTT='" & strTT2 & "' " &
                                        "WHERE childname ='" & lblchildname.Text & "' "
            SQL.AddOkNotOk(updatecmd2)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmviewvaccine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOK.Focus()
        With frmaddchild
            .btnviewvaccine.PerformClick()
        End With
        SQL.ExecuteQuery("SELECT * FROM tbl_dates WHERE childname = '" & lblchildname.Text & "'")
        SQL.SQLConn.Open()
        SQL.SQLDR = SQL.SQLcmd.ExecuteReader()
        SQL.SQLDR.Read()

        If SQL.SQLDR.HasRows Then
            dtpBCG.Text = SQL.SQLDR.Item("BCG").ToString
            dtpHepBBD.Text = SQL.SQLDR.Item("HepB BD").ToString
            dtppenta1.Text = SQL.SQLDR.Item("fPenta").ToString
            dtppenta2.Text = SQL.SQLDR.Item("sPenta").ToString
            dtppenta3.Text = SQL.SQLDR.Item("tPenta").ToString
            dtpOPV1.Text = SQL.SQLDR.Item("fOPV").ToString
            dtpOPV2.Text = SQL.SQLDR.Item("sOPV").ToString
            dtpOPV3.Text = SQL.SQLDR.Item("tOPV").ToString
            dtpIPV.Text = SQL.SQLDR.Item("IPV").ToString
            dtpMCV1.Text = SQL.SQLDR.Item("fMVC").ToString
            dtpMCV2.Text = SQL.SQLDR.Item("sMVC").ToString
            dtpTT.Text = SQL.SQLDR.Item("TT").ToString
            dtpTT2.Text = SQL.SQLDR.Item("sTT").ToString
        End If
        SQL.SQLConn.Close()

        SQL.ExecuteQuery("SELECT * FROM tbl_checkvaccine WHERE childname = '" & lblchildname.Text & "'")
        SQL.SQLConn.Open()
        SQL.SQLDR = SQL.SQLcmd.ExecuteReader()
        SQL.SQLDR.Read()

        If SQL.SQLDR.HasRows Then
            lblBCG.Text = SQL.SQLDR.Item("BCG").ToString
            lblHepBBD.Text = SQL.SQLDR.Item("HepB BD").ToString
            lblpenta1.Text = SQL.SQLDR.Item("fPenta").ToString
            lblpenta2.Text = SQL.SQLDR.Item("sPenta").ToString
            lblpenta3.Text = SQL.SQLDR.Item("tPenta").ToString
            lblopv1.Text = SQL.SQLDR.Item("fOPV").ToString
            lblopv2.Text = SQL.SQLDR.Item("sOPV").ToString
            lblopv3.Text = SQL.SQLDR.Item("tOPV").ToString
            lblipv.Text = SQL.SQLDR.Item("IPV").ToString
            lblmcv1.Text = SQL.SQLDR.Item("fMVC").ToString
            lblmcv2.Text = SQL.SQLDR.Item("sMVC").ToString
            lblTT.Text = SQL.SQLDR.Item("TT").ToString
            lblTT2.Text = SQL.SQLDR.Item("sTT").ToString
        End If
        SQL.SQLConn.Close()

    End Sub
End Class