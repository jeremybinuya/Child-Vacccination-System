Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmaddchild
    Dim SQL As New SQLControl

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtnameRHUBHS.Text = "" OrElse txtcname.Text = "" Then
                MsgBox("You must Complete the Information")
            ElseIf IsNumeric(txtnameRHUBHS.Text & txtnamebrgy.Text & txtcname.Text & txtcmother.Text & txtcpurok.Text) Then
                MsgBox("Invalid Input! Try again")
            Else
                SQL.AddChildInfo(txtnameRHUBHS.Text, txtnamebrgy.Text, cmbpurok.Text, dtpdatecompletion.Text,
                         txtcname.Text, txtcage.Text, dtpbday.Text, txtcmother.Text, txtcpurok.Text)
                SQL.ChildOknotok(txtcname.Text, "", "", "", "", "", "", "", "", "", "", "", "", "")
                SQL.AddDates(txtcname.Text, "", "", "", "", "", "", "", "", "", "", "", "", "")
                ClearAll()
                CurrentDataDGV()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub CurrentDataDGV()
        If SQL.HasConnection = True Then
            SQL.ExecuteQuery("Select *from tbl_mstrlistchildren")

            If SQL.SQLDataSet.Tables.Count > 0 Then
                dgvData.DataSource = SQL.SQLDataSet.Tables(0)
            End If


            With dgvData
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Width = 170
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).Width = 40
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(7).Visible = False
                .Columns(8).Width = 200
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(9).Visible = False
            End With
        End If
    End Sub

    Public Sub ClearAll()
        txtnameRHUBHS.Clear()
        txtnamebrgy.Clear()
        dtpdatecompletion.Text = Date.Today
        txtcname.Clear()
        txtcage.Clear()
        dtpbday.Text = Date.Today
        txtcmother.Clear()
        txtcpurok.Clear()


    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        btnviewvaccine.Enabled = True
    End Sub

    Private Sub frmaddchild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentDataDGV()
        txtnameRHUBHS.Focus()
    End Sub

    Private Sub btnviewvaccine_Click(sender As Object, e As EventArgs) Handles btnviewvaccine.Click
        With frmviewvaccine
            .Show()
            If .lblBCG.Text = "OK" Then
                .cbBCG.Checked = True
            End If
            If .lblHepBBD.Text = "OK" Then
                .cbHepBBD.Checked = True
            End If
            If .lblpenta1.Text = "OK" Then
                .cbpenta1.Checked = True
            End If
            If .lblpenta2.Text = "OK" Then
                .cbpenta2.Checked = True
            End If
            If .lblpenta3.Text = "OK" Then
                .cbpenta3.Checked = True
            End If
            If .lblopv1.Text = "OK" Then
                .cbOPV1.Checked = True
            End If
            If .lblopv2.Text = "OK" Then
                .cbOPV2.Checked = True
            End If
            If .lblopv3.Text = "OK" Then
                .cbOPV3.Checked = True
            End If
            If .lblipv.Text = "OK" Then
                .cbIPV.Checked = True
            End If
            If .lblmcv1.Text = "OK" Then
                .cbMCV1.Checked = True
            End If
            If .lblmcv2.Text = "OK" Then
                .cbMCV2.Checked = True
            End If
            If .lblTT.Text = "OK" Then
                .cbTT.Checked = True
            End If
            If .lblTT2.Text = "OK" Then
                .cbTT2.Checked = True
            End If
            If dgvData.Rows.Count > 0 Then
                .lblchildname.Text = dgvData.CurrentRow.Cells(5).Value
                .lblnamemother.Text = dgvData.CurrentRow.Cells(8).Value
            End If
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        SQL.FilterData(txtsearch.Text)
    End Sub

    Private Sub dtpbday_ValueChanged(sender As Object, e As EventArgs) Handles dtpbday.ValueChanged
        Dim date1, date2 As Date
        Dim days, months, years As Long

        date1 = dtpbday.Value.ToShortDateString
        date2 = Now.ToShortDateString

        years = Year(date1)
        months = Month(date1)
        days = date1.Day

        years = Year(date2) - years
        months = Month(date2) - months
        days = date2.Day - days

        If Math.Sign(days) = -1 Then
            days = 30 - Math.Abs(days)
            months -= 1
        End If

        If Math.Sign(months) = -1 Then
            months = 12 - Math.Abs(months)
            years -= 1
        End If

        txtcage.Text = years.ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        SQL.FilterData(txtsearch.Text)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click, btnsummary.Click
        Try
            If dgvData.Rows.Count > 0 Then
                If MsgBox("Do you want to delete " & dgvData.CurrentRow.Cells(5).Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    SQL.DataDelete("DELETE FROM tbl_mstrlistchildren WHERE childnumber ='" & dgvData.CurrentRow.Cells(0).Value & " '")
                    SQL.DataDateDelete("DELETE FROM tbl_dates WHERE childnumber ='" & dgvData.CurrentRow.Cells(0).Value & " '")
                    SQL.DataOKNOTOKDelete("DELETE FROM tbl_checkvaccine WHERE childnumber ='" & dgvData.CurrentRow.Cells(0).Value & " '")
                    CurrentDataDGV()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click
        Label16.Visible = False
        btnviewvaccine.Enabled = False
    End Sub

    Private Sub frmaddchild_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Label16.Visible = True
        txtsearch.Clear()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        With frmlogin
            .txtuser.Clear()
            .txtpword.Clear()
            .Show()
        End With
    End Sub
End Class